using System;
using Roblox.Locking;
using Roblox.Platform.Authentication;
using Roblox.Platform.Membership;

namespace Roblox.Platform.XboxLive;

/// <summary>
/// An interface for management of Xbox live user and Roblox user.
/// </summary>
public interface IXboxLiveUserManager
{
	event Action<IXboxLiveAccount> OnXboxLiveAccountDisconnected;

	/// <summary>
	/// Links the existing user to xbox user.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="pairwiseId">The pairwise identifier.</param>
	/// <param name="gamerTag">The gamer tag.</param>
	/// <param name="ageGroup">The age group.</param>
	void LinkExistingUser(IUser user, string pairwiseId, string gamerTag, string ageGroup);

	/// <summary>
	/// Sets the roblox username and password.
	/// </summary>
	/// <param name="pairwiseId">The pairwise identifier.</param>
	/// <param name="username">The username.</param>
	/// <param name="password">The password.</param>
	/// <param name="mustUsePiiFiltersForU13Usernames">if set to <c>true</c> [must use pii filters for u13 usernames].</param>
	/// TODO: Delete once we no longer support /xboxlive/set-roblox-username-password
	[Obsolete]
	void SetRobloxUsernameAndPassword(string pairwiseId, string username, string password, bool mustUsePiiFiltersForU13Usernames);

	/// <summary>
	/// Unlinks the xbox live account from roblox account.
	/// </summary>
	/// <param name="pairwiseId">The pairwise identifier.</param>
	void UnlinkXboxLiveAccountFromRobloxAccount(string pairwiseId);

	/// <summary>
	/// Unlinks the roblox account from xbox live account.
	/// </summary>
	/// <param name="accountId">The account identifier.</param>
	void UnlinkRobloxAccountFromXboxLiveAccount(long accountId);

	/// <summary>
	/// Synchronizes the gamer tag hash.
	/// </summary>
	/// <param name="pairwiseId">The pairwise identifier.</param>
	/// <param name="gamerTag">The gamer tag.</param>
	/// <returns></returns>
	bool SynchronizeGamerTagHash(string pairwiseId, string gamerTag);

	/// <summary>
	/// Xbox Login Consecutive Days for Achievments
	/// </summary>
	/// <param name="user"></param>
	/// <param name="clientLastSeen">TimeStamp from the client. Not from server</param>
	/// <returns>true: if incremented or changed, false: no change (login within the same day)</returns>
	bool TryIncrementXboxUserLoginConsecutiveDayCount(IUser user, DateTime clientLastSeen);

	/// <summary>
	/// Gets the login consecutive day count.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <returns></returns>
	int GetLoginConsecutiveDayCount(IUser user);

	/// <summary>
	/// Determines whether [the specified user] [is xbox live user].
	/// </summary>
	/// <param name="user">The user.</param>
	/// <returns>
	///   <c>true</c> if [the specified user] [is xbox live user]; otherwise, <c>false</c>.
	/// </returns>
	bool IsXboxLiveUser(IUser user);

	/// <summary>
	/// Determines whether users XboxGamerTag is valid.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="gamerTag">The gamer tag.</param>
	/// <returns>
	///   <c>true</c> if [is xbox gamer tag valid] [the specified user]; otherwise, <c>false</c>.
	/// </returns>
	bool IsXboxGamerTagValid(IUser user, string gamerTag);

	/// <summary>
	/// Gets a leased lock for managing an Xbox account via pairwise Id.
	/// </summary>
	/// <param name="pairwiseId">The pairwise Id.</param>
	/// <returns>The <see cref="T:Roblox.Locking.ILeasedLock" />.</returns>
	ILeasedLock GetLeasedLock(string pairwiseId);
}
