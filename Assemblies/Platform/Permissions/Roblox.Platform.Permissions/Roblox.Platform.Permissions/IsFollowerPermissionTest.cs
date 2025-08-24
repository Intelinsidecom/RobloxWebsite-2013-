using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Social;

namespace Roblox.Platform.Permissions;

internal class IsFollowerPermissionTest : FollowerPermissionTest
{
	internal IsFollowerPermissionTest(long? authenticatedUserId, long? targetId, IFriendshipFactory friendshipFactory)
		: base(authenticatedUserId, targetId, friendshipFactory)
	{
		base.PermissionType = PermissionType.IsFollower;
	}

	protected override bool CheckFollowing(long authenticatedUserId, long checkUserId)
	{
		try
		{
			return GetFriendshipFactory().HasFollower(checkUserId, authenticatedUserId);
		}
		catch (FriendshipOperationUnavailableException)
		{
			return false;
		}
	}
}
