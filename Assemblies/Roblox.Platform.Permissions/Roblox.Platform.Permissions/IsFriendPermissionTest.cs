using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Social;

namespace Roblox.Platform.Permissions;

internal class IsFriendPermissionTest : UserPermissionTest
{
	private readonly IFriendshipFactory _FriendshipFactory;

	internal IsFriendPermissionTest(long? authenticatedUserId, long? targetId, IFriendshipFactory friendshipFactory)
		: base(authenticatedUserId, targetId)
	{
		base.PermissionType = PermissionType.IsFriend;
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
			try
			{
				return _FriendshipFactory.AreFriends(authenticatedUser.ID, user.ID);
			}
			catch (FriendshipOperationUnavailableException)
			{
				return false;
			}
		}
		base.PermissionType = PermissionType.UserIsAuthenticated;
		return false;
	}
}
