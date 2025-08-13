namespace Roblox.Platform.Social;

/// <summary>
/// Represents the status of a friendship between users.
/// </summary>
/// <remarks>These values only contain statuses that one user can know. For example
/// there is no value for me being another user's best friend because that
/// information is not presented to me.</remarks>
public enum FriendshipStatus
{
	/// <summary>
	/// There is no friendship among the users.
	/// </summary>
	NoFriendship,
	/// <summary>
	/// The current user has sent a friend request and the request is pending.
	/// </summary>
	PendingOnOtherUser,
	/// <summary>
	/// The other user has sent a friend request and the request is pending.
	/// </summary>
	PendingOnCurrentUser,
	/// <summary>
	/// The users are friends with each other.
	/// </summary>
	Friends
}
