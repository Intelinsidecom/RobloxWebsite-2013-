using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.GameLocalization.Authorization;

public class UserActor : IActor
{
	private readonly IUser _Actor;

	public dynamic Actor => _Actor;

	public ActorType Type => ActorType.User;

	public UserActor(IUser user)
	{
		_Actor = user ?? throw new PlatformArgumentNullException("user");
	}
}
