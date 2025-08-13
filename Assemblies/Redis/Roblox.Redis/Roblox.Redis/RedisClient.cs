using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Hashing;
using Roblox.Instrumentation;
using StackExchange.Redis;

namespace Roblox.Redis;

public class RedisClient : RedisClientBase<RedisClientOptions>
{
	private IConnectionMultiplexer[] _Multiplexers;

	private ConsistentHash<ConsistentHashConnectionWrapperBase> _NodeProvider;

	public RedisClient(ICounterRegistry counterRegistry, IEnumerable<string> redisEndpoints, string performanceMonitorCategory, Action<Exception> exceptionHandler = null, RedisClientOptions redisClientOptions = null)
		: base(counterRegistry, performanceMonitorCategory, redisClientOptions ?? new RedisClientOptions(), exceptionHandler)
	{
		if (redisEndpoints == null)
		{
			throw new ArgumentNullException("redisEndpoints");
		}
		ChangeMultiplexers(redisEndpoints.ToArray());
	}

	public RedisClient(ICounterRegistry counterRegistry, RedisEndpoints redisEndpoints, string performanceMonitorCategory, Action<Exception> exceptionHandler = null, RedisClientOptions redisClientOptions = null)
		: this(counterRegistry, redisEndpoints?.Endpoints, performanceMonitorCategory, exceptionHandler, redisClientOptions)
	{
	}

	public override IDatabase GetDatabase(string partitionKey)
	{
		if (_Multiplexers.Length == 1)
		{
			return _Multiplexers[0].GetDatabase();
		}
		return _NodeProvider.GetNode(partitionKey).Database;
	}

	public override IServer GetServer(string partitionKey)
	{
		if (_Multiplexers.Length == 1)
		{
			return RedisClientBase<RedisClientOptions>.GetServerFromMultiplexer(_Multiplexers[0]);
		}
		return _NodeProvider.GetNode(partitionKey).Server;
	}

	public override ISubscriber GetSubscriber(string partitionKey)
	{
		if (_Multiplexers.Length == 1)
		{
			return _Multiplexers[0].GetSubscriber();
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
		return _Multiplexers.Select((IConnectionMultiplexer d) => d.GetDatabase()).ToList();
	}

	public override IReadOnlyCollection<ISubscriber> GetAllSubscribers()
	{
		return _Multiplexers.Select((IConnectionMultiplexer m) => m.GetSubscriber()).ToList();
	}

	public override IReadOnlyCollection<IServer> GetAllServers()
	{
		return _Multiplexers.Select(RedisClientBase<RedisClientOptions>.GetServerFromMultiplexer).ToList();
	}

	public override void Refresh(string[] redisEndpoints)
	{
		ChangeMultiplexers(redisEndpoints);
		OnRefreshed();
	}

	public override void Close()
	{
		Parallel.ForEach(_Multiplexers, delegate(IConnectionMultiplexer m)
		{
			m.Close(allowCommandsToComplete: false);
		});
	}

	private void ChangeMultiplexers(string[] redisEndpoints)
	{
		IConnectionMultiplexer[] oldPools = _Multiplexers ?? Array.Empty<ConnectionMultiplexer>();
		IConnectionMultiplexer[] array = oldPools.Where((IConnectionMultiplexer o) => redisEndpoints.Any((string re) => re == GetMultiplexerDescriptor(o))).ToArray();
		IEnumerable<IConnectionMultiplexer> enumerable = oldPools.Except(array);
		Task<IConnectionMultiplexer>[] array2 = redisEndpoints.Where((string re) => oldPools.All((IConnectionMultiplexer o) => GetMultiplexerDescriptor(o) != re)).Select(base.ConnectMultiplexerAsync).ToArray();
		Task[] tasks = array2;
		Task.WaitAll(tasks);
		_Multiplexers = array.Concat(array2.Select((Task<IConnectionMultiplexer> m) => m.Result)).ToArray();
		List<RedisConnectionWrapper> nodes = _Multiplexers.Select((IConnectionMultiplexer cm) => new RedisConnectionWrapper(cm, GetConfigurationFromMultiplexer(cm))).ToList();
		ConsistentHash<ConsistentHashConnectionWrapperBase> consistentHash = new ConsistentHash<ConsistentHashConnectionWrapperBase>();
		consistentHash.Init(nodes);
		Interlocked.Exchange(ref _NodeProvider, consistentHash);
		foreach (IConnectionMultiplexer item in enumerable)
		{
			item.Dispose();
		}
		static string GetMultiplexerDescriptor(IConnectionMultiplexer cm)
		{
			return cm.GetEndPoints()[0].ToString();
		}
	}

	private static ConfigurationOptions GetConfigurationFromMultiplexer(IConnectionMultiplexer multiplexer)
	{
		return ConfigurationOptions.Parse(multiplexer.Configuration);
	}
}
