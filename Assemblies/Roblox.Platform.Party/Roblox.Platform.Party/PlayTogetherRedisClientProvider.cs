using System;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Party.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Party;

public static class PlayTogetherRedisClientProvider
{
	private const string _PlayTogetherPerformanceCategory = "Roblox.Platform.Party.PlayTogether.Redis";

	private static readonly RedisClientFactory _RedisClientFactoryForPlayTogether = (Settings.Default.PlayTogetherRedisEnabled ? new RedisClientFactory(StaticCounterRegistry.Instance) : null);

	public static IRedisClient GetRedisClient(ILogger logger)
	{
		if (_RedisClientFactoryForPlayTogether != null)
		{
			return _RedisClientFactoryForPlayTogether.GetRedisClient(Settings.Default.PlayTogetherRedisEndpoints, delegate(Action<RedisEndpoints> refresh)
			{
				Settings.Default.MonitorChanges((Settings s) => s.PlayTogetherRedisEndpoints, refresh);
			}, "Roblox.Platform.Party.PlayTogether.Redis", logger.Error);
		}
		return PartyRedisClientProvider.GetRedisClient(logger);
	}
}
