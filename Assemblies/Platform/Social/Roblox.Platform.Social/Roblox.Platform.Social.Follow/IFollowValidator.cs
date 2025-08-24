using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Follow;

/// <summary>
/// Validates a user's ability to follow another user into game 
/// </summary>
public interface IFollowValidator
{
	/// <summary>
	/// Checks whether a user can follow another user into game
	/// </summary>
	bool CanFollow(IUser follower, IUser followed);

	/// <summary>
	/// Provided for specific cases where we don't want to use the FriendshipFactory for determining user relationships (because of performance considerations).
	/// Most times we should be using the other CanFollow function.
	/// </summary>
	bool CanFollow(IUser follower, IUser followed, Func<long, long, bool> areFriendsFunc, Func<long, long, bool> hasFollowerFunc);
}
