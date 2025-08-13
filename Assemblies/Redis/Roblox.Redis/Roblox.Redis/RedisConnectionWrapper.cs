using StackExchange.Redis;

namespace Roblox.Redis;

internal class RedisConnectionWrapper : ConsistentHashConnectionWrapperBase
{
	private readonly IConnectionMultiplexer _ConnectionMultiplexer;

	public override IDatabase Database => _ConnectionMultiplexer.GetDatabase();

	public override ISubscriber Subscriber => _ConnectionMultiplexer.GetSubscriber();

	public override IServer Server { get; }

	internal RedisConnectionWrapper(IConnectionMultiplexer connectionMultiplexer, ConfigurationOptions configuration)
		: base(configuration)
	{
		_ConnectionMultiplexer = connectionMultiplexer;
		Server = RedisClientBase<RedisClientOptions>.GetServerFromMultiplexer(connectionMultiplexer);
	}
}
