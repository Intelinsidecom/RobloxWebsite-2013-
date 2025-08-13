using System;
using StackExchange.Redis;

namespace Roblox.Redis;

public sealed class RedisPooledClientOptions : RedisClientOptionsBase
{
	public int PoolSize { get; }

	public int MaxReconnectTimeout { get; }

	public RedisPooledClientOptions(int poolSize = 1, int maxReconnectTimeout = 0, IConnectionBuilder connectionBuilder = null, IReconnectRetryPolicy reconnectRetryPolicy = null, TimeSpan? syncTimeout = null, bool disableSubcriptions = false, Func<TimeSpan> connectTimeoutGetter = null, Func<TimeSpan> responseTimeoutGetter = null)
		: base(connectionBuilder, reconnectRetryPolicy, syncTimeout, disableSubcriptions, connectTimeoutGetter, responseTimeoutGetter)
	{
		if (poolSize < 1)
		{
			throw new ArgumentOutOfRangeException("poolSize");
		}
		PoolSize = poolSize;
		MaxReconnectTimeout = maxReconnectTimeout;
	}
}
