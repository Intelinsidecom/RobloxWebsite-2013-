using System;
using System.Linq.Expressions;
using Roblox.Configuration;
using Roblox.FloodCheckers.Redis.Properties;
using Roblox.Instrumentation;
using Roblox.Redis;

namespace Roblox.FloodCheckers.Redis;

public static class FloodCheckerRedisClient
{
	private static IRedisClient _RedisClient;

	private static string _RedisEndpointsCsv;

	static FloodCheckerRedisClient()
	{
		_RedisEndpointsCsv = "";
		Settings.Default.ReadValueAndMonitorChanges<Settings, string>((Expression<Func<Settings, string>>)((Settings s) => s.FloodCheckerRedisEndpointsCsv), (Action<string>)delegate(string endpointsCsv)
		{
			if (!_RedisEndpointsCsv.Equals(endpointsCsv))
			{
				_RedisEndpointsCsv = endpointsCsv;
				string[] redisEndpoints = endpointsCsv.Split(new char[1] { ',' });
				if (_RedisClient == null)
				{
					_RedisClient = new RedisClient(StaticCounterRegistry.Instance, redisEndpoints, "Roblox.FloodCheckers.Redis");
				}
				else
				{
					_RedisClient.Refresh(redisEndpoints);
				}
			}
		});
	}

	public static IRedisClient GetInstance()
	{
		return _RedisClient;
	}
}
