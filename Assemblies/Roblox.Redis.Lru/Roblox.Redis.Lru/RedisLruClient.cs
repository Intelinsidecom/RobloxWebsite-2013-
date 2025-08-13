using System;
using System.Linq.Expressions;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Redis.Lru.Properties;

namespace Roblox.Redis.Lru;

[Obsolete("Use your own cluster instead")]
internal static class RedisLruClient
{
	private static IRedisClient _RedisClient;

	private static string _RedisEndpointsCsv;

	static RedisLruClient()
	{
		_RedisEndpointsCsv = "";
		Settings.Default.ReadValueAndMonitorChanges<Settings, string>((Expression<Func<Settings, string>>)((Settings s) => s.SharedLruCacheRedisEndpointsCsv), (Action<string>)delegate(string endpointsCsv)
		{
			if (!_RedisEndpointsCsv.Equals(endpointsCsv))
			{
				_RedisEndpointsCsv = endpointsCsv;
				string[] redisEndpoints = endpointsCsv.Split(new char[1] { ',' });
				if (_RedisClient == null)
				{
					_RedisClient = new RedisClient(StaticCounterRegistry.Instance, redisEndpoints, "Roblox.Redis.Lru", null, new RedisClientOptions(null, null, null, disableSubscriptions: true));
				}
				else
				{
					_RedisClient.Refresh(redisEndpoints);
				}
			}
		});
	}

	[Obsolete("Use your own cluster instead")]
	public static IRedisClient GetInstance()
	{
		return _RedisClient;
	}
}
