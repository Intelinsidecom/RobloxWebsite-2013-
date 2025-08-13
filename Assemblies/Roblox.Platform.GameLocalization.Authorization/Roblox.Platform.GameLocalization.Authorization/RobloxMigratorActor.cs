using Roblox.Platform.Core;

namespace Roblox.Platform.GameLocalization.Authorization;

public class RobloxMigratorActor : IActor
{
	private readonly IRobloxComponent _Actor;

	public dynamic Actor => _Actor;

	public ActorType Type => ActorType.RobloxMigrator;

	public RobloxMigratorActor(IRobloxComponent robloxMigrator)
	{
		_Actor = robloxMigrator ?? throw new PlatformArgumentNullException("robloxMigrator");
	}
}
