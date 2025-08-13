using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Hashing;
using Roblox.Instrumentation;
using Roblox.Redis.Properties;
using StackExchange.Redis;

namespace Roblox.Redis;

public class RedisPooledClient : RedisClientBase<RedisPooledClientOptions>
{
	private RedisConnectionMultiplexerPool[] _Pools;

	private ConsistentHash<ConsistentHashConnectionWrapperBase> _NodeProvider;

	private readonly ParallelOptions _ParallelOptions = new ParallelOptions
	{
		MaxDegreeOfParallelism = 10
	};

	private readonly ISelfHealingConnectionMultiplexerSettings _BadStateSelfHealingConnectionMultiplexerSettings;

	private readonly Func<DateTime> _GetCurrentTimeFunc;

	public RedisPooledClient(ICounterRegistry counterRegistry, IEnumerable<string> redisEndpoints, string performanceMonitorCategory, Action<Exception> exceptionHandler = null, RedisPooledClientOptions clientOptions = null, ISelfHealingConnectionMultiplexerSettings badStateSelfHealingConnectionMultiplexerSettings = null, Func<DateTime> getCurrentTimeFunc = null)
		: base(counterRegistry, performanceMonitorCategory, clientOptions ?? new RedisPooledClientOptions(), exceptionHandler)
	{
		_BadStateSelfHealingConnectionMultiplexerSettings = badStateSelfHealingConnectionMultiplexerSettings ?? SelfHealingConnectionMultiplexerSettings.Default;
		_GetCurrentTimeFunc = getCurrentTimeFunc ?? ((Func<DateTime>)(() => DateTime.UtcNow));
		ChangePools(redisEndpoints.ToArray());
	}

	public RedisPooledClient(ICounterRegistry counterRegistry, RedisEndpoints redisEndpoints, string performanceMonitorCategory, Action<Exception> exceptionHandler = null, RedisPooledClientOptions clientOptions = null, ISelfHealingConnectionMultiplexerSettings badStateSelfHealingConnectionMultiplexerSettings = null, Func<DateTime> getCurrentTimeFunc = null)
		: this(counterRegistry, redisEndpoints?.Endpoints, performanceMonitorCategory, exceptionHandler, clientOptions, badStateSelfHealingConnectionMultiplexerSettings, getCurrentTimeFunc)
	{
	}

	public override IDatabase GetDatabase(string partitionKey)
	{
		if (_Pools.Length == 1)
		{
			return _Pools[0].GetConnectionMultiplexer().GetDatabase();
		}
		return _NodeProvider.GetNode(partitionKey).Database;
	}

	public override IServer GetServer(string partitionKey)
	{
		if (_Pools.Length == 1)
		{
			return RedisClientBase<RedisPooledClientOptions>.GetServerFromMultiplexer(_Pools[0].GetConnectionMultiplexer());
		}
		return _NodeProvider.GetNode(partitionKey).Server;
	}

	public override ISubscriber GetSubscriber(string partitionKey)
	{
		if (_Pools.Length == 1)
		{
			return _Pools[0].Subscriber;
		}
		return _NodeProvider.GetNode(partitionKey).Subscriber;
	}

	public override IDictionary<IDatabase, IReadOnlyCollection<string>> GetDatabases(IReadOnlyCollection<string> partitionKeys)
	{
		if (partitionKeys == null || partitionKeys.Any((string pk) => pk == null))
		{
			throw new ArgumentNullException("partitionKeys");
		}
		return ConsistentHashConnectionWrapperBase.GetDatabasesByConsistentHashingAlgorithm(partitionKeys, _NodeProvider);
	}

	public override IReadOnlyCollection<IDatabase> GetAllDatabases()
	{
		return _Pools.Select((RedisConnectionMultiplexerPool p) => p.GetConnectionMultiplexer().GetDatabase()).ToList();
	}

	public override IReadOnlyCollection<ISubscriber> GetAllSubscribers()
	{
		return _Pools.Select((RedisConnectionMultiplexerPool p) => p.Subscriber).ToList();
	}

	public override IReadOnlyCollection<IServer> GetAllServers()
	{
		return _Pools.Select((RedisConnectionMultiplexerPool p) => RedisClientBase<RedisPooledClientOptions>.GetServerFromMultiplexer(p.GetConnectionMultiplexer())).ToList();
	}

	public override void Refresh(string[] redisEndpoints)
	{
		ChangePools(redisEndpoints);
		OnRefreshed();
	}

	public override void Close()
	{
		Parallel.ForEach(_Pools, _ParallelOptions, delegate(RedisConnectionMultiplexerPool p)
		{
			p.Close();
		});
	}

	private void ChangePools(string[] redisEndpoints)
	{
		RedisConnectionMultiplexerPool[] array = _Pools ?? Array.Empty<RedisConnectionMultiplexerPool>();
		RedisConnectionMultiplexerPool[] keepingOldPools = array.Where((RedisConnectionMultiplexerPool op) => redisEndpoints.Contains(GetMultiplexerDescriptor(op.PrimaryConnection))).ToArray();
		IEnumerable<RedisConnectionMultiplexerPool> enumerable = array.Except(keepingOldPools);
		Task<RedisConnectionMultiplexerPool>[] array2 = (from re in redisEndpoints
			where keepingOldPools.All((RedisConnectionMultiplexerPool kop) => kop.PrimaryConnection.GetEndPoints()[0].ToString() != re)
			select re into endpoint
			select CreatePoolAsync(endpoint, base.RedisClientOptions)).ToArray();
		Task[] tasks = array2;
		Task.WaitAll(tasks);
		_Pools = keepingOldPools.Concat(array2.Select((Task<RedisConnectionMultiplexerPool> t) => t.Result)).ToArray();
		List<RedisConnectionMultiplexerPoolWrapper> nodes = _Pools.Select((RedisConnectionMultiplexerPool p) => new RedisConnectionMultiplexerPoolWrapper(p, p.BaseConfiguration)).ToList();
		ConsistentHash<ConsistentHashConnectionWrapperBase> consistentHash = new ConsistentHash<ConsistentHashConnectionWrapperBase>();
		consistentHash.Init(nodes);
		Interlocked.Exchange(ref _NodeProvider, consistentHash);
		foreach (RedisConnectionMultiplexerPool item in enumerable)
		{
			item.Dispose();
		}
		static string GetMultiplexerDescriptor(IConnectionMultiplexer cm)
		{
			return cm.GetEndPoints()[0].ToString();
		}
	}

	private async Task<RedisConnectionMultiplexerPool> CreatePoolAsync(string redisEndpoint, RedisPooledClientOptions clientOptions)
	{
		ConfigurationOptions configurationOptions = GetConfigurationOptions(redisEndpoint);
		RedisConnectionMultiplexerPool pool = new RedisConnectionMultiplexerPool(configurationOptions, clientOptions);
		await pool.ConnectAsync().ConfigureAwait(continueOnCapturedContext: false);
		return pool;
	}
}
