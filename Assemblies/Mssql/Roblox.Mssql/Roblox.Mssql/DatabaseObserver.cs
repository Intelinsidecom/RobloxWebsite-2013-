using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Instrumentation;

namespace Roblox.Mssql;

public class DatabaseObserver : IDisposable, IDatabaseObserver
{
	private readonly IDatabase _Database;

	private readonly ICounterRegistry _CounterRegistry;

	private DatabaseMonitor _DatabaseMonitor;

	private bool _IsDisposed;

	private bool _IsRegistered;

	private ConcurrentDictionary<long, Stopwatch> _RequestTimers;

	private SemaphoreSlim _Semaphore = new SemaphoreSlim(1, 1);

	public DatabaseObserver(IDatabase database, ICounterRegistry counterRegistry)
	{
		_Database = database ?? throw new ArgumentNullException("database");
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	~DatabaseObserver()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (_IsDisposed)
		{
			return;
		}
		if (disposing)
		{
			Unregister();
			if (_Semaphore != null)
			{
				_Semaphore.Dispose();
				_Semaphore = null;
			}
		}
		_IsDisposed = true;
	}

	public void Register()
	{
		if (_IsDisposed)
		{
			throw new ObjectDisposedException(GetType().ToString());
		}
		if (_IsRegistered)
		{
			return;
		}
		try
		{
			_Semaphore.Wait();
			if (_IsRegistered)
			{
				return;
			}
			_IsRegistered = true;
		}
		finally
		{
			_Semaphore.Release();
		}
		DoRegister();
	}

	public async Task RegisterAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (_IsDisposed)
		{
			throw new ObjectDisposedException(GetType().ToString());
		}
		if (_IsRegistered)
		{
			return;
		}
		try
		{
			await _Semaphore.WaitAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (_IsRegistered)
			{
				return;
			}
			_IsRegistered = true;
		}
		finally
		{
			_Semaphore.Release();
		}
		DoRegister();
	}

	public void Unregister()
	{
		if (!_IsRegistered)
		{
			return;
		}
		try
		{
			_Semaphore.Wait();
			if (!_IsRegistered)
			{
				return;
			}
			_IsRegistered = false;
		}
		finally
		{
			_Semaphore.Release();
		}
		DoUnregister();
	}

	public async Task UnregisterAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!_IsRegistered)
		{
			return;
		}
		try
		{
			await _Semaphore.WaitAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (!_IsRegistered)
			{
				return;
			}
			_IsRegistered = false;
		}
		finally
		{
			_Semaphore.Release();
		}
		DoUnregister();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void RequestStarted(object sender, DatabaseExecutionEventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		Stopwatch stopwatch = Stopwatch.StartNew();
		_RequestTimers.GetOrAdd(e.RequestId, stopwatch);
		_DatabaseMonitor.GetRequestsOutstanding().Increment();
		if ((int)e.CommandType == 4)
		{
			_DatabaseMonitor.GetOrCreateAction(e.CommandText).RequestsOutstanding.Increment();
		}
	}

	private void RequestSucceeded(object sender, DatabaseExecutionEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		_DatabaseMonitor.GetRequestsPerSecond().Increment();
		if ((int)e.CommandType == 4)
		{
			_DatabaseMonitor.GetOrCreateAction(e.CommandText).RequestsPerSecond.Increment();
		}
	}

	private void DoRegister()
	{
		_RequestTimers = new ConcurrentDictionary<long, Stopwatch>();
		_DatabaseMonitor = new DatabaseMonitor(_Database.Name, _CounterRegistry);
		_Database.ExecutionStarted += RequestStarted;
		_Database.ExecutionSucceeded += RequestSucceeded;
		_Database.ExecutionFailed += RequestFailed;
		_Database.ExecutionFinished += RequestFinished;
	}

	private void DoUnregister()
	{
		_Database.ExecutionStarted -= RequestStarted;
		_Database.ExecutionSucceeded -= RequestSucceeded;
		_Database.ExecutionFailed -= RequestFailed;
		_Database.ExecutionFinished -= RequestFinished;
		_RequestTimers = null;
		_DatabaseMonitor = null;
	}

	private void RequestFailed(object sender, DatabaseExecutionEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		_DatabaseMonitor.GetFailuresPerSecond().Increment();
		if ((int)e.CommandType == 4)
		{
			_DatabaseMonitor.GetOrCreateAction(e.CommandText).FailuresPerSecond.Increment();
		}
	}

	private void RequestFinished(object sender, DatabaseExecutionEventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		if (_RequestTimers.TryRemove(e.RequestId, out var stopwatch))
		{
			stopwatch.Stop();
			double elapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds;
			_DatabaseMonitor.GetAverageResponseTime().Sample(elapsedMilliseconds);
			_DatabaseMonitor.GetRequestsOutstanding().Decrement();
			if ((int)e.CommandType == 4)
			{
				ExecutionCounterSet orCreateAction = _DatabaseMonitor.GetOrCreateAction(e.CommandText);
				orCreateAction.AverageResponseTime.Sample(elapsedMilliseconds);
				orCreateAction.RequestsOutstanding.Decrement();
			}
		}
	}
}
