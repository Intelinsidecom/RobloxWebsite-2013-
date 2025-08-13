namespace Roblox.Platform.GameLocalization.Authorization;

public interface IActor
{
	dynamic Actor { get; }

	ActorType Type { get; }
}
