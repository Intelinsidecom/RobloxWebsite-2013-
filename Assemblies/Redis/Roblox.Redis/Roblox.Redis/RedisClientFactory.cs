using System;
using Roblox.Instrumentation;

namespace Roblox.Redis;

public class RedisClientFactory : IRedisClientFactory
{
	private readonly object _Lock = new object();

	private bool _MonitorStarted;

	private volatile IRedisClient _RedisClient;

	private RedisEndpoints _CurrentEndpoints;

	private readonly bool _UseConnectionPooling;

	private readonly RedisPooledClientOptions _RedisPooledClientOptions;

	private readonly RedisClientOptions _ClientOptions;

	private readonly ICounterRegistry _CounterRegistry;

	public RedisClientFactory(ICounterRegistry counterRegistry, bool useConnectionPooling = false, RedisClientOptions clientOptions = null, RedisPooledClientOptions pooledClientOptions = null)
	{
		_ClientOptions = clientOptions;
		_RedisPooledClientOptions = pooledClientOptions;
		_UseConnectionPooling = useConnectionPooling;
		_CounterRegistry = counterRegistry;
	}

	public IRedisClient GetRedisClient(RedisEndpoints endpoints, Action<Action<RedisEndpoints>> monitorWireup, string performanceMonitorCategory, Action<Exception> errorHandler)
	{
		if (_RedisClient != null)
		{
			return _RedisClient;
		}
		lock (_Lock)
		{
			if (_RedisClient != null)
			{
				return _RedisClient;
			}
			if (!_MonitorStarted)
			{
				monitorWireup(delegate(RedisEndpoints newEndpoints)
				{
					Refresh(newEndpoints, errorHandler);
				});
				_MonitorStarted = true;
			}
			try
			{
				_CurrentEndpoints = endpoints;
				if (_UseConnectionPooling)
				{
					_RedisClient = new RedisPooledClient(_CounterRegistry, _CurrentEndpoints, performanceMonitorCategory, null, _RedisPooledClientOptions);
				}
				else
				{
					_RedisClient = new RedisClient(_CounterRegistry, _CurrentEndpoints, performanceMonitorCategory, null, _ClientOptions);
				}
			}
			catch (Exception obj)
			{
				errorHandler(obj);
			}
			return _RedisClient;
		}
	}

	private void Refresh(RedisEndpoints redisEndpoints, Action<Exception> errorHandler)
	{
		try
		{
			lock (_Lock)
			{
				if (_RedisClient != null && !redisEndpoints.HasTheSameEndpoints(_CurrentEndpoints))
				{
					_CurrentEndpoints = redisEndpoints;
					_RedisClient.Refresh(_CurrentEndpoints);
				}
			}
		}
		catch (Exception obj)
		{
			errorHandler(obj);
		}
	}
}
