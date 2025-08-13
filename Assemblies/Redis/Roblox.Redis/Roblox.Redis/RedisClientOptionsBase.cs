using System;
using StackExchange.Redis;

namespace Roblox.Redis;

public abstract class RedisClientOptionsBase
{
	public IReconnectRetryPolicy ReconnectRetryPolicy { get; }

	public TimeSpan? SyncTimeout { get; }

	public IConnectionBuilder ConnectionBuilder { get; }

	public bool DisableSubscriptions { get; }

	public Func<TimeSpan> ConnectTimeout { get; }

	public Func<TimeSpan> ResponseTimeout { get; }

	protected RedisClientOptionsBase(IConnectionBuilder connectionBuilder = null, IReconnectRetryPolicy reconnectRetryPolicy = null, TimeSpan? syncTimeout = null, bool disableSubscriptions = false, Func<TimeSpan> connectTimeoutGetter = null, Func<TimeSpan> responseTimeoutGetter = null)
	{
		ConnectionBuilder = connectionBuilder;
		ReconnectRetryPolicy = reconnectRetryPolicy;
		SyncTimeout = syncTimeout;
		DisableSubscriptions = disableSubscriptions;
		ConnectTimeout = connectTimeoutGetter ?? ((Func<TimeSpan>)(() => new TimeSpan(0, 0, 0, 1, 0)));
		ResponseTimeout = responseTimeoutGetter ?? ((Func<TimeSpan>)(() => new TimeSpan(0, 0, 0, 1, 0)));
	}
}
