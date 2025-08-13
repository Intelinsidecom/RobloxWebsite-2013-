using System;
using StackExchange.Redis;

namespace Roblox.Redis;

public sealed class RedisClientOptions : RedisClientOptionsBase
{
	public RedisClientOptions(IConnectionBuilder connectionBuilder = null, IReconnectRetryPolicy reconnectRetryPolicy = null, TimeSpan? syncTimeout = null, bool disableSubscriptions = false, Func<TimeSpan> connectTimeoutGetter = null, Func<TimeSpan> responseTimeoutGetter = null)
		: base(connectionBuilder, reconnectRetryPolicy, syncTimeout, disableSubscriptions, connectTimeoutGetter, responseTimeoutGetter)
	{
	}
}
