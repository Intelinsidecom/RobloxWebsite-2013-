using Roblox.Friends.Client;

namespace Roblox.Platform.Social;

/// <summary>
/// Interface for friendship creation-related APIs.
/// </summary>
public interface IFriendshipCreator
{
	/// <summary>
	/// Event raised when friendship request is sent.
	/// </summary>
	event FriendRequestSent OnFriendRequestSent;

	/// <summary>
	/// Sends a friend request from <paramref name="userId" /> to <paramref name="recipientId" />.
	/// </summary>
	/// <param name="userId">The user sending the friend request ("sending user").</param>
	/// <param name="recipientId">The target of the friend request.</param>
	/// <param name="antiAbuseFlags"> The <see cref="T:Roblox.Platform.Social.AntiAbuseFlags" /> that accompany this friend request.</param>
	/// <param name="message">Message accompanying friend request. (Default: Empty string.)</param>
	/// <param name="friendshipOriginSourceType">Enum value describing origin of friendship. (Default: Unknown.)</param>
	void SendFriendRequest(long userId, long recipientId, AntiAbuseFlags antiAbuseFlags, string message = "", FriendshipOriginSourceType friendshipOriginSourceType = 0);
}
