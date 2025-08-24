namespace Roblox.Platform.Throttling;

public interface IGameServerRateLimit
{
	IRateLimit BaseRateLimit { get; }

	IRateLimit PerPlayerRateLimit { get; }
}
