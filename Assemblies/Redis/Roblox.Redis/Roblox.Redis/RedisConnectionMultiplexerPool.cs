using System;
using System.Threading;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Roblox.Redis;

internal class RedisConnectionMultiplexerPool
{
	private RedisConnectionMultiplexerWatcher[] _ConnectionWatchers;

	private int _RoundRobinIndex;

	private readonly IConnectionBuilder _ConnectionBuilder;

	private readonly ParallelOptions _ParallelOptions = new ParallelOptions
	{
		MaxDegreeOfParallelism = 10
	};

	public ConfigurationOptions BaseConfiguration { get; }

	public RedisPooledClientOptions ClientOptions { get; }

	public IConnectionMultiplexer PrimaryConnection
	{
		get
		{
			CheckIfReady();
			return _ConnectionWatchers[0].Connection;
		}
	}

	public int Size
	{
		get
		{
			CheckIfReady();
			return _ConnectionWatchers.Length;
		}
	}

	public ISubscriber Subscriber => PrimaryConnection.GetSubscriber();

	public RedisConnectionMultiplexerPool(ConfigurationOptions baseConfiguration, RedisPooledClientOptions clientOptions)
	{
		BaseConfiguration = baseConfiguration ?? throw new ArgumentNullException("baseConfiguration");
		ClientOptions = clientOptions ?? throw new ArgumentNullException("clientOptions");
		_ConnectionBuilder = clientOptions.ConnectionBuilder ?? new DefaultConnectionBuilder();
		if (clientOptions.ReconnectRetryPolicy != null)
		{
			BaseConfiguration.ReconnectRetryPolicy = clientOptions.ReconnectRetryPolicy;
		}
		_RoundRobinIndex = -1;
	}

	public IConnectionMultiplexer GetConnectionMultiplexer()
	{
		CheckIfReady();
		int num = Interlocked.Increment(ref _RoundRobinIndex);
		if (num < 0)
		{
			num -= int.MinValue;
		}
		num %= _ConnectionWatchers.Length;
		return _ConnectionWatchers[num].Connection;
	}

	public void Close()
	{
		CheckIfReady();
		Parallel.ForEach(_ConnectionWatchers, _ParallelOptions, delegate(RedisConnectionMultiplexerWatcher w)
		{
			w.Close();
		});
	}

	public void Dispose()
	{
		CheckIfReady();
		Parallel.ForEach(_ConnectionWatchers, _ParallelOptions, delegate(RedisConnectionMultiplexerWatcher w)
		{
			w.Dispose();
		});
	}

	public async Task ConnectAsync()
	{
		Task<IConnectionMultiplexer>[] array = new Task<IConnectionMultiplexer>[ClientOptions.PoolSize];
		for (int i = 0; i < ClientOptions.PoolSize; i++)
		{
			array[i] = _ConnectionBuilder.CreateConnectionMultiplexerAsync(BaseConfiguration);
		}
		IConnectionMultiplexer[] array2 = await Task.WhenAll(array).ConfigureAwait(continueOnCapturedContext: false);
		RedisConnectionMultiplexerWatcher[] array3 = new RedisConnectionMultiplexerWatcher[array2.Length];
		for (int j = 0; j < array2.Length; j++)
		{
			array3[j] = new RedisConnectionMultiplexerWatcher(array2[j], _ConnectionBuilder, BaseConfiguration, ClientOptions);
		}
		_ConnectionWatchers = array3;
	}

	private void CheckIfReady()
	{
		if (_ConnectionWatchers == null || _ConnectionWatchers.Length == 0)
		{
			throw new InvalidOperationException("The pool is not ready");
		}
	}
}
