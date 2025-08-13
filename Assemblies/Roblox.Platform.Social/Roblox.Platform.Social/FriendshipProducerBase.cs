using Roblox.Friends.Client;
using Roblox.Platform.Membership;
using Roblox.Platform.Social.Properties;
using Roblox.Platform.UserBlock.Core;

namespace Roblox.Platform.Social;

public abstract class FriendshipProducerBase
{
	protected const string FriendsServiceUnavailableExceptionMessage = "Friends Service Unavailable";

	private readonly IUserBlockAuthority _UserBlockAuthority;

	protected IFriendsClient Client { get; }

	protected FriendshipProducerBase(IFriendsClient client, IUserBlockAuthority userBlockAuthority)
	{
		Client = client;
		_UserBlockAuthority = userBlockAuthority;
	}

	protected bool BlockExistsBetweenUsers(IUser user, IUser targetUser)
	{
		if (Settings.Default.EnforceUserBlockWhenPerformingFriendshipOperations && (_UserBlockAuthority.IsBlocked(user, targetUser.Id) || _UserBlockAuthority.IsBlocked(targetUser, user.Id)))
		{
			return true;
		}
		return false;
	}
}
