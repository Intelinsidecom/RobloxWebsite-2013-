namespace Roblox.Platform.Throttling;

internal class GameServerRateLimit : IGameServerRateLimit
{
	public IRateLimit BaseRateLimit { get; private set; }

	public IRateLimit PerPlayerRateLimit { get; private set; }

	public GameServerRateLimit(IRateLimit baseRateLimit, IRateLimit perPlayerRateLimit)
	{
		PerPlayerRateLimit = perPlayerRateLimit;
		BaseRateLimit = baseRateLimit;
	}
}
