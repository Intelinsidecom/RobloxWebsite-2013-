using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Social;

namespace Roblox.Platform.Permissions;

internal abstract class FollowerPermissionTest : UserPermissionTest
{
	private readonly IFriendshipFactory _FriendshipFactory;

	internal FollowerPermissionTest(long? authenticatedUserId, long? targetId, IFriendshipFactory friendshipFactory)
		: base(authenticatedUserId, targetId)
	{
		_FriendshipFactory = friendshipFactory;
	}

	public override bool Test()
	{
		if (base.AuthenticatedUserId.HasValue)
		{
			User authenticatedUser = User.Get(base.AuthenticatedUserId.Value);
			if (authenticatedUser == null || !base.PermissionTargetId.HasValue)
			{
				return false;
			}
			User user = User.Get(base.PermissionTargetId.Value);
			if (user == null)
			{
				return false;
			}
			return CheckFollowing(authenticatedUser.ID, user.ID);
		}
		base.PermissionType = PermissionType.UserIsAuthenticated;
		return false;
	}

	protected IFriendshipFactory GetFriendshipFactory()
	{
		return _FriendshipFactory;
	}

	protected abstract bool CheckFollowing(long authenticatedUserId, long checkUserId);
}
