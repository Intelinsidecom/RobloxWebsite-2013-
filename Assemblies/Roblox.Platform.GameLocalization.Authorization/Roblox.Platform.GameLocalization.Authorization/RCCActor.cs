using Roblox.Platform.Core;

namespace Roblox.Platform.GameLocalization.Authorization;

public class RCCActor : IActor
{
	private readonly IRobloxComponent _Actor;

	public dynamic Actor => _Actor;

	public ActorType Type => ActorType.RCC;

	public RCCActor(IRobloxComponent robloxComponent)
	{
		_Actor = robloxComponent.AssignOrThrowIfNull("robloxComponent");
	}
}
