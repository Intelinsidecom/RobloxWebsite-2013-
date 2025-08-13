using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Roblox.Redis;

public class SwitchingConnectionBuilder : IConnectionBuilder
{
	private class SwitchingConnectionMultiplexer : IConnectionMultiplexer
	{
		private bool _UseSecond;

		private IConnectionMultiplexer _CurrentConnectionMultiplexer;

		private readonly IConnectionBuilder _FirstConnectionBuilder;

		private readonly IConnectionBuilder _SecondConnectionBuilder;

		private readonly ConfigurationOptions _Configuration;

		public string ClientName => _CurrentConnectionMultiplexer.ClientName;

		public string Configuration => _CurrentConnectionMultiplexer.Configuration;

		public int TimeoutMilliseconds => _CurrentConnectionMultiplexer.TimeoutMilliseconds;

		public long OperationCount => _CurrentConnectionMultiplexer.OperationCount;

		public bool PreserveAsyncOrder
		{
			get
			{
				return _CurrentConnectionMultiplexer.PreserveAsyncOrder;
			}
			set
			{
				_CurrentConnectionMultiplexer.PreserveAsyncOrder = value;
			}
		}

		public bool IsConnected => _CurrentConnectionMultiplexer.IsConnected;

		public bool IncludeDetailInExceptions
		{
			get
			{
				return _CurrentConnectionMultiplexer.IncludeDetailInExceptions;
			}
			set
			{
				_CurrentConnectionMultiplexer.IncludeDetailInExceptions = value;
			}
		}

		public int StormLogThreshold
		{
			get
			{
				return _CurrentConnectionMultiplexer.StormLogThreshold;
			}
			set
			{
				_CurrentConnectionMultiplexer.StormLogThreshold = value;
			}
		}

		public event EventHandler<RedisErrorEventArgs> ErrorMessage;

		public event EventHandler<ConnectionFailedEventArgs> ConnectionFailed;

		public event EventHandler<InternalErrorEventArgs> InternalError;

		public event EventHandler<ConnectionFailedEventArgs> ConnectionRestored;

		public event EventHandler<EndPointEventArgs> ConfigurationChanged;

		public event EventHandler<EndPointEventArgs> ConfigurationChangedBroadcast;

		public event EventHandler<HashSlotMovedEventArgs> HashSlotMoved;

		public SwitchingConnectionMultiplexer(IConnectionMultiplexer initialConnectionMultiplexer, IConnectionBuilder firstConnectionMultiplexer, IConnectionBuilder secondConnectionBuilder, bool initialUseSecond, ConfigurationOptions configuration)
		{
			_CurrentConnectionMultiplexer = initialConnectionMultiplexer;
			_FirstConnectionBuilder = firstConnectionMultiplexer;
			_SecondConnectionBuilder = secondConnectionBuilder;
			_UseSecond = initialUseSecond;
			_Configuration = configuration;
			SubscribeToEvents(_CurrentConnectionMultiplexer);
		}

		public async void SetSwitch(bool useSecond)
		{
			if (_UseSecond != useSecond)
			{
				_UseSecond = true;
				IConnectionMultiplexer connectionMultiplexer = await (_UseSecond ? _SecondConnectionBuilder : _FirstConnectionBuilder).CreateConnectionMultiplexerAsync(_Configuration).ConfigureAwait(continueOnCapturedContext: false);
				SubscribeToEvents(connectionMultiplexer);
				IConnectionMultiplexer oldConnectionMultiplexer = Interlocked.Exchange(ref _CurrentConnectionMultiplexer, connectionMultiplexer);
				await oldConnectionMultiplexer.CloseAsync().ConfigureAwait(continueOnCapturedContext: false);
				UnsubscribeFromEvents(oldConnectionMultiplexer);
			}
		}

		public void RegisterProfiler(IProfiler profiler)
		{
			_CurrentConnectionMultiplexer.RegisterProfiler(profiler);
		}

		public void BeginProfiling(object forContext)
		{
			_CurrentConnectionMultiplexer.BeginProfiling(forContext);
		}

		public ProfiledCommandEnumerable FinishProfiling(object forContext, bool allowCleanupSweep = true)
		{
			return _CurrentConnectionMultiplexer.FinishProfiling(forContext, allowCleanupSweep);
		}

		public ServerCounters GetCounters()
		{
			return _CurrentConnectionMultiplexer.GetCounters();
		}

		public EndPoint[] GetEndPoints(bool configuredOnly = false)
		{
			return _CurrentConnectionMultiplexer.GetEndPoints(configuredOnly);
		}

		public void Wait(Task task)
		{
			_CurrentConnectionMultiplexer.Wait(task);
		}

		public T Wait<T>(Task<T> task)
		{
			return _CurrentConnectionMultiplexer.Wait(task);
		}

		public void WaitAll(params Task[] tasks)
		{
			_CurrentConnectionMultiplexer.WaitAll(tasks);
		}

		public int HashSlot(RedisKey key)
		{
			return _CurrentConnectionMultiplexer.HashSlot(key);
		}

		public ISubscriber GetSubscriber(object asyncState = null)
		{
			return _CurrentConnectionMultiplexer.GetSubscriber(asyncState);
		}

		public IDatabase GetDatabase(int db = -1, object asyncState = null)
		{
			return _CurrentConnectionMultiplexer.GetDatabase(db, asyncState);
		}

		public IServer GetServer(string host, int port, object asyncState = null)
		{
			return _CurrentConnectionMultiplexer.GetServer(host, port, asyncState);
		}

		public IServer GetServer(string hostAndPort, object asyncState = null)
		{
			return _CurrentConnectionMultiplexer.GetServer(hostAndPort, asyncState);
		}

		public IServer GetServer(IPAddress host, int port)
		{
			return _CurrentConnectionMultiplexer.GetServer(host, port);
		}

		public IServer GetServer(EndPoint endpoint, object asyncState = null)
		{
			return _CurrentConnectionMultiplexer.GetServer(endpoint, asyncState);
		}

		public Task<bool> ConfigureAsync(TextWriter log = null)
		{
			return _CurrentConnectionMultiplexer.ConfigureAsync(log);
		}

		public bool Configure(TextWriter log = null)
		{
			return _CurrentConnectionMultiplexer.Configure(log);
		}

		public string GetStatus()
		{
			return _CurrentConnectionMultiplexer.GetStatus();
		}

		public void GetStatus(TextWriter log)
		{
			_CurrentConnectionMultiplexer.GetStatus(log);
		}

		public void Close(bool allowCommandsToComplete = true)
		{
			_CurrentConnectionMultiplexer.Close(allowCommandsToComplete);
		}

		public Task CloseAsync(bool allowCommandsToComplete = true)
		{
			return _CurrentConnectionMultiplexer.CloseAsync(allowCommandsToComplete);
		}

		public void Dispose()
		{
			_CurrentConnectionMultiplexer.Dispose();
		}

		public string GetStormLog()
		{
			return _CurrentConnectionMultiplexer.GetStormLog();
		}

		public void ResetStormLog()
		{
			_CurrentConnectionMultiplexer.ResetStormLog();
		}

		public long PublishReconfigure(CommandFlags flags = CommandFlags.None)
		{
			return _CurrentConnectionMultiplexer.PublishReconfigure(flags);
		}

		public Task<long> PublishReconfigureAsync(CommandFlags flags = CommandFlags.None)
		{
			return _CurrentConnectionMultiplexer.PublishReconfigureAsync(flags);
		}

		private void SubscribeToEvents(IConnectionMultiplexer cm)
		{
			cm.ErrorMessage += OnErrorMessage;
			cm.ConfigurationChanged += OnConfigurationChanged;
			cm.ConfigurationChangedBroadcast += OnConfigurationChangedBroadcast;
			cm.ConnectionFailed += OnConnectionFailed;
			cm.ConnectionRestored += OnConnectionRestored;
			cm.HashSlotMoved += OnHashSlotMoved;
			cm.InternalError += OnInternalError;
		}

		private void UnsubscribeFromEvents(IConnectionMultiplexer cm)
		{
			cm.ErrorMessage -= OnErrorMessage;
			cm.ConfigurationChanged -= OnConfigurationChanged;
			cm.ConfigurationChangedBroadcast -= OnConfigurationChangedBroadcast;
			cm.ConnectionFailed -= OnConnectionFailed;
			cm.ConnectionRestored -= OnConnectionRestored;
			cm.HashSlotMoved -= OnHashSlotMoved;
			cm.InternalError -= OnInternalError;
		}

		private void OnHashSlotMoved(object sender, HashSlotMovedEventArgs e)
		{
			this.HashSlotMoved?.Invoke(sender, e);
		}

		private void OnConfigurationChangedBroadcast(object sender, EndPointEventArgs e)
		{
			this.ConfigurationChangedBroadcast?.Invoke(sender, e);
		}

		private void OnConfigurationChanged(object sender, EndPointEventArgs e)
		{
			this.ConfigurationChanged?.Invoke(sender, e);
		}

		private void OnConnectionRestored(object sender, ConnectionFailedEventArgs e)
		{
			this.ConnectionRestored?.Invoke(sender, e);
		}

		private void OnInternalError(object sender, InternalErrorEventArgs e)
		{
			this.InternalError?.Invoke(sender, e);
		}

		private void OnConnectionFailed(object sender, ConnectionFailedEventArgs e)
		{
			this.ConnectionFailed?.Invoke(sender, e);
		}

		private void OnErrorMessage(object sender, RedisErrorEventArgs e)
		{
			this.ErrorMessage?.Invoke(sender, e);
		}
	}

	private bool _UseSecond;

	private readonly IConnectionBuilder _FirstConnectionBuilder;

	private readonly IConnectionBuilder _SecondConnectionBuilder;

	private event Action<bool> SwitchSet;

	public SwitchingConnectionBuilder(IConnectionBuilder firstConnectionBuilder, IConnectionBuilder secondConnectionBuilder)
	{
		_FirstConnectionBuilder = firstConnectionBuilder ?? throw new ArgumentNullException("firstConnectionBuilder");
		_SecondConnectionBuilder = secondConnectionBuilder ?? throw new ArgumentNullException("secondConnectionBuilder");
	}

	public void SetSwitch(bool useSecond)
	{
		if (_UseSecond != useSecond)
		{
			_UseSecond = useSecond;
			this.SwitchSet?.Invoke(_UseSecond);
		}
	}

	public async Task<IConnectionMultiplexer> CreateConnectionMultiplexerAsync(ConfigurationOptions configuration)
	{
		bool useSecond = _UseSecond;
		IConnectionMultiplexer initialConnectionMultiplexer = ((!useSecond) ? (await _FirstConnectionBuilder.CreateConnectionMultiplexerAsync(configuration).ConfigureAwait(continueOnCapturedContext: false)) : (await _SecondConnectionBuilder.CreateConnectionMultiplexerAsync(configuration).ConfigureAwait(continueOnCapturedContext: false)));
		SwitchingConnectionMultiplexer switchingConnectionMultiplexer = new SwitchingConnectionMultiplexer(initialConnectionMultiplexer, _FirstConnectionBuilder, _SecondConnectionBuilder, useSecond, configuration);
		SwitchSet += switchingConnectionMultiplexer.SetSwitch;
		return switchingConnectionMultiplexer;
	}
}
