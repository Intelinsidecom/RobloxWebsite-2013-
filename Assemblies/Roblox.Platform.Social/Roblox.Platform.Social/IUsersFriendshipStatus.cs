namespace Roblox.Platform.Social;

public interface IUsersFriendshipStatus
{
	long InitiatingUserId { get; }

	long OtherUserId { get; }

	FriendshipStatus FriendshipStatus { get; }
}
