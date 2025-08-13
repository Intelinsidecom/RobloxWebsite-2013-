using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Social;

namespace Roblox.Platform.Permissions;

internal class IsFollowedByPermissionTest : FollowerPermissionTest
{
	internal IsFollowedByPermissionTest(long? authenticatedUserId, long? targetId, IFriendshipFactory friendshipFactory)
		: base(authenticatedUserId, targetId, friendshipFactory)
	{
		base.PermissionType = PermissionType.IsFollowedBy;
	}

	protected override bool CheckFollowing(long authenticatedUserId, long checkUserId)
	{
		try
		{
			return GetFriendshipFactory().HasFollower(authenticatedUserId, checkUserId);
		}
		catch (FriendshipOperationUnavailableException)
		{
			return false;
		}
	}
}
