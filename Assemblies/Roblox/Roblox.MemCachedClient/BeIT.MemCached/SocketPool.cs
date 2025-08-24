using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Roblox.Sentinels;

namespace BeIT.MemCached;

[DebuggerDisplay("Host: {Host}")]
internal class SocketPool : ISocketPool, IDisposable
{
	private int _SocketObjectsAlive;

	private readonly IServerPool _Owner;

	private readonly MemcachedMonitor _Monitor;

	private readonly IEndpointResolver _EndpointResolver;

	private readonly Queue<IPooledSocket> _Queue;

	private readonly IMemCachedClientSettings _Settings;

	private readonly IMemcachedClientExceptionHandler _ExceptionHandler;

	private readonly ThresholdExecutionCircuitBreaker _ConnectionCircuitBreaker;

	private readonly ThresholdExecutionCircuitBreaker _ExecutionCircuitBreaker;

	private readonly IRateLimiter _ConnectionCreationRateLimiter;

	private volatile bool _Disposed;

	public long PoolSize => _Queue.Count;

	public int OwnedSocketCount => _SocketObjectsAlive;

	public string Host { get; }

	public ThresholdExecutionCircuitBreaker ExecutionCircuitBreaker => _ExecutionCircuitBreaker;

	internal SocketPool(ServerPool owner, string host, MemcachedMonitor monitor, IMemCachedClientSettings settings, IMemcachedClientExceptionHandler exceptionHandler, IEndpointResolver endpointResolver)
	{
		Host = host;
		_Owner = owner;
		_Monitor = monitor;
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_ExceptionHandler = exceptionHandler ?? throw new ArgumentNullException("exceptionHandler");
		_Queue = new Queue<IPooledSocket>();
		_ConnectionCircuitBreaker = new ThresholdExecutionCircuitBreaker(string.Format("{0}_Connections", "SocketPool"), (Exception _) => true, () => _Settings.ConnectionCircuitBreakerRetryInterval, () => _Settings.ConnectionCircuitBreakerExceptionCountForTripping, () => _Settings.ConnectionCircuitBreakerExceptionIntervalForTripping);
		_ExecutionCircuitBreaker = new ThresholdExecutionCircuitBreaker(string.Format("{0}_Executions", "SocketPool"), ShouldTripExecutionCircuitBreaker, () => _Settings.ExecutionCircuitBreakerRetryInterval, () => _Settings.ExecutionCircuitBreakerExceptionCountForTripping, () => _Settings.ExecutionCircuitBreakerExceptionIntervalForTripping);
		_ConnectionCreationRateLimiter = new RateLimiter(() => _Settings.IsConnectionCreationRateLimitingEnabled, () => _Settings.ConnectionCreationRateLimitPeriodLength, () => _Settings.MaximumConnectionCreationsPerPeriod);
		_EndpointResolver = endpointResolver ?? throw new ArgumentNullException("endpointResolver");
	}

	public IPooledSocket Acquire()
	{
		_Monitor.AcquireAttemptsPerSecond.Increment();
		lock (_Queue)
		{
			if (_Disposed)
			{
				return null;
			}
			while (_Queue.Count > 0)
			{
				IPooledSocket pooledSocket2 = _Queue.Dequeue();
				if (pooledSocket2 != null)
				{
					if (pooledSocket2.IsAlive)
					{
						_Monitor.AcquireSuccessesPerSecond.Increment();
						return pooledSocket2;
					}
					pooledSocket2.Dispose();
				}
			}
		}
		_Monitor.AcquireFailuresPerSecond.Increment();
		if (!_ConnectionCreationRateLimiter.TryOperation())
		{
			_Monitor.AcquireSocketCreationAbortDueToRateLimitPerSecond.Increment();
			return null;
		}
		if (Interlocked.Increment(ref _SocketObjectsAlive) > _Settings.MaximumNumberOfSocketsPerPool)
		{
			Interlocked.Decrement(ref _SocketObjectsAlive);
			_Monitor.AcquireSocketCreationAbortDueToMaximumCountReachedPerSecond.Increment();
			return null;
		}
		try
		{
			IPooledSocket pooledSocket = null;
			_ConnectionCircuitBreaker.Execute(Action);
			return pooledSocket;
			void Action()
			{
				Stopwatch stopwatch = Stopwatch.StartNew();
				IPEndPoint endPoint = _EndpointResolver.GetEndPoint(Host, 11211);
				pooledSocket = CreatePooledSocket(_Monitor, endPoint, _Settings, _ExceptionHandler);
				stopwatch.Stop();
				pooledSocket.Disposed += PooledSocket_Disposed;
				_Monitor.AcquireSocketCreationAverageTimeInMilliseconds.Sample(stopwatch.Elapsed.TotalMilliseconds);
				_Monitor.AcquireSocketCreationSuccessesPerSecond.Increment();
			}
		}
		catch (Exception ex)
		{
			if (ex is CircuitBreakerException)
			{
				_Monitor.AcquireSocketCreationAbortedDueToBrokenCircuit.Increment();
				_ExceptionHandler.HandleVerboseException(ex);
			}
			else if (ex is TimeoutException)
			{
				_Monitor.AcquireSocketCreationTimeoutsPerSecond.Increment();
				_ExceptionHandler.HandleVerboseException(ex);
			}
			else
			{
				_Monitor.AcquireSocketCreationFailuresPerSecond.Increment();
				_ExceptionHandler.HandleException(ex);
			}
			Interlocked.Decrement(ref _SocketObjectsAlive);
			return null;
		}
	}

	public void Return(IPooledSocket pooledSocket, bool forceReset)
	{
		_Monitor.ReturnAttemptsPerSecond.Increment();
		if (!pooledSocket.IsAlive)
		{
			pooledSocket.Dispose();
			return;
		}
		if (pooledSocket.Reset(forceReset))
		{
			_Monitor.ReturnDirtySocketsPerSecond.Increment();
		}
		if (_Settings.IsRespectingMaxPoolSizeEnabled && _Queue.Count >= _Settings.MaximumPoolSize)
		{
			pooledSocket.Dispose();
			_Monitor.ReturnPoolIsFullPerSecond.Increment();
			return;
		}
		if (_Queue.Count > _Settings.MinimumPoolSize && DateTime.UtcNow - pooledSocket.Created > _Settings.SocketRecycleAge)
		{
			pooledSocket.Dispose();
			_Monitor.ReturnSocketsDestroyedPerSecond.Increment();
			return;
		}
		lock (_Queue)
		{
			if (_Disposed)
			{
				pooledSocket.Dispose();
				return;
			}
			_Queue.Enqueue(pooledSocket);
			_Monitor.ReturnSuccessesPerSecond.Increment();
		}
	}

	public void Dispose()
	{
		_Disposed = true;
		lock (_Queue)
		{
			while (_Queue.Count > 0)
			{
				_Queue.Dequeue().Dispose();
			}
		}
	}

	private void PooledSocket_Disposed(object sender, EventArgs e)
	{
		if (sender != null && sender is PooledSocket pooledSocket)
		{
			Interlocked.Decrement(ref _SocketObjectsAlive);
			pooledSocket.Disposed -= PooledSocket_Disposed;
		}
	}

	private bool ShouldTripExecutionCircuitBreaker(Exception ex)
	{
		if (!(ex.InnerException is SocketException ex2))
		{
			return false;
		}
		return _Settings.SocketErrorsThatTripExecutionCircuitBreaker.Contains(ex2.SocketErrorCode);
	}

	internal virtual IPooledSocket CreatePooledSocket(MemcachedMonitor monitor, IPEndPoint endPoint, IMemCachedClientSettings clientSettings, IMemcachedClientExceptionHandler exceptionHandler)
	{
		return new PooledSocket(monitor, endPoint, clientSettings, exceptionHandler);
	}
}
