namespace Roblox.Platform.Membership;

/// <summary>
/// Provides functionality for handling placeholder usernames
/// </summary>
public interface IPlaceholderUsernameFactory
{
	/// <summary>
	/// Checks if the user has an active placeholder username
	/// </summary>
	/// <param name="accountId"><see cref="P:Roblox.Platform.Membership.IUser.AccountId" /></param>
	/// <returns>true if active placeholder username, false otherwise</returns>
	bool HasActivePlaceholderUsername(long accountId);
}
