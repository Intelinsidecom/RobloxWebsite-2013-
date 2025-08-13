namespace Roblox.Platform.Social;

internal class UsersFriendshipStatus : IUsersFriendshipStatus
{
	public long InitiatingUserId { get; }

	public long OtherUserId { get; }

	public FriendshipStatus FriendshipStatus { get; }

	public UsersFriendshipStatus(long initiatingUserId, long otherUserId, FriendshipStatus friendshipStatus)
	{
		InitiatingUserId = initiatingUserId;
		OtherUserId = otherUserId;
		FriendshipStatus = friendshipStatus;
	}
}
