using System;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Party.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Party;

public static class PartyRedisClientProvider
{
	private const string _PartyPerformanceCategory = "Roblox.Platform.Party.Redis.V2";

	private static readonly RedisClientFactory _RedisClientFactoryForParty = new RedisClientFactory(StaticCounterRegistry.Instance);

	public static IRedisClient GetRedisClient(ILogger logger)
	{
		return _RedisClientFactoryForParty.GetRedisClient(Settings.Default.RedisEndpointsV2, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.RedisEndpointsV2, refresh);
		}, "Roblox.Platform.Party.Redis.V2", logger.Error);
	}
}
