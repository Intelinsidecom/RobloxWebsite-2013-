using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Roblox.Redis;

internal class RedisConnectionMultiplexerWatcher
{
	private Dictionary<ConnectionType, CancellationTokenSource> _TokenSources = new Dictionary<ConnectionType, CancellationTokenSource>();

	private readonly object _TokenSync = new object();

	private readonly IConnectionBuilder _ConnectionBuilder;

	private readonly ConfigurationOptions _ConnectionConfiguration;

	private readonly RedisPooledClientOptions _ClientOptions;

	private WeakReference<IConnectionMultiplexer> _LastRefreshed;

	public IConnectionMultiplexer Connection { get; private set; }

	public event EventHandler<ConnectionFailedEventArgs> ConnectionFailed;

	public RedisConnectionMultiplexerWatcher(IConnectionMultiplexer connection, IConnectionBuilder connectionBuilder, ConfigurationOptions connectionConfiguration, RedisPooledClientOptions clientOptions)
	{
		Connection = connection ?? throw new ArgumentNullException("connection");
		_ConnectionBuilder = connectionBuilder ?? throw new ArgumentNullException("connectionBuilder");
		_ConnectionConfiguration = connectionConfiguration ?? throw new ArgumentNullException("connectionConfiguration");
		_ClientOptions = clientOptions ?? throw new ArgumentNullException("clientOptions");
		connection.ConnectionFailed += OnConnectionFailed;
		connection.ConnectionRestored += OnConnectionRestored;
	}

	public void Dispose()
	{
		lock (_TokenSync)
		{
			Connection.Dispose();
			foreach (KeyValuePair<ConnectionType, CancellationTokenSource> tokenSource in _TokenSources)
			{
				CancellationTokenSource value = tokenSource.Value;
				value.Cancel();
				value.Dispose();
			}
			_TokenSources.Clear();
		}
	}

	public void Close()
	{
		lock (_TokenSync)
		{
			Connection.Close(allowCommandsToComplete: false);
			foreach (KeyValuePair<ConnectionType, CancellationTokenSource> tokenSource in _TokenSources)
			{
				CancellationTokenSource value = tokenSource.Value;
				value.Cancel();
				value.Dispose();
			}
			_TokenSources.Clear();
		}
	}

	private void OnConnectionRestored(object sender, ConnectionFailedEventArgs args)
	{
		if (_ClientOptions.MaxReconnectTimeout <= 0)
		{
			return;
		}
		lock (_TokenSync)
		{
			if ((_LastRefreshed == null || !_LastRefreshed.TryGetTarget(out var target) || sender != target) && _TokenSources.TryGetValue(args.ConnectionType, out var value))
			{
				value = _TokenSources[args.ConnectionType];
				_TokenSources.Remove(args.ConnectionType);
				value.Cancel();
				value.Dispose();
			}
		}
	}

	private void OnConnectionFailed(object sender, ConnectionFailedEventArgs args)
	{
		if (_ClientOptions.MaxReconnectTimeout > 0)
		{
			lock (_TokenSync)
			{
				if (_LastRefreshed != null && _LastRefreshed.TryGetTarget(out var target) && sender == target)
				{
					return;
				}
				if (!_TokenSources.ContainsKey(args.ConnectionType))
				{
					CancellationTokenSource tokenSource = new CancellationTokenSource();
					Task.Run(async delegate
					{
						_ = 1;
						try
						{
							await Task.Delay(_ClientOptions.MaxReconnectTimeout, tokenSource.Token).ConfigureAwait(continueOnCapturedContext: false);
							await RefreshConnection(Connection).ConfigureAwait(continueOnCapturedContext: false);
						}
						catch (TaskCanceledException)
						{
						}
					});
					_TokenSources.Add(args.ConnectionType, tokenSource);
				}
			}
		}
		this.ConnectionFailed?.Invoke(sender, args);
	}

	private async Task RefreshConnection(IConnectionMultiplexer oldConnection)
	{
		lock (_TokenSync)
		{
			if (Connection != oldConnection)
			{
				return;
			}
			_LastRefreshed = new WeakReference<IConnectionMultiplexer>(oldConnection);
			oldConnection.ConnectionFailed -= OnConnectionFailed;
			oldConnection.ConnectionRestored -= OnConnectionRestored;
			foreach (KeyValuePair<ConnectionType, CancellationTokenSource> tokenSource in _TokenSources)
			{
				CancellationTokenSource value = tokenSource.Value;
				value.Cancel();
				value.Dispose();
			}
			_TokenSources.Clear();
		}
		IConnectionMultiplexer connectionMultiplexer = await _ConnectionBuilder.CreateConnectionMultiplexerAsync(_ConnectionConfiguration).ConfigureAwait(continueOnCapturedContext: false);
		connectionMultiplexer.ConnectionFailed += OnConnectionFailed;
		connectionMultiplexer.ConnectionRestored += OnConnectionRestored;
		Connection = connectionMultiplexer;
		oldConnection.Dispose();
	}
}
