using Roblox.Platform.Core;

namespace Roblox.Platform.GameLocalization.Authorization;

public class RobloxProcessorActor : IActor
{
	private readonly IRobloxComponent _Actor;

	public dynamic Actor => _Actor;

	public ActorType Type => ActorType.RobloxProcessor;

	public RobloxProcessorActor(IRobloxComponent robloxProcessor)
	{
		_Actor = robloxProcessor.AssignOrThrowIfNull("robloxProcessor");
	}
}
