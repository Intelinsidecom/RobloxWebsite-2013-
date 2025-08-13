using Roblox.Passwords.Client;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public static class Extensions
{
	internal static void VerifyIsNotNull(this ISessionToken sessionToken)
	{
		if (sessionToken == null)
		{
			throw new InvalidSessionTokenException();
		}
	}

	public static void DeleteAllSessions(this IUser user)
	{
		user.VerifyIsNotNull();
		SessionTokenFactory.DeleteAll(user);
	}

	/// <summary>
	/// This method tells us whether this user has setup a password for their Roblox Account or not
	/// </summary>
	/// <param name="authenticatedUser">Authenticated Roblox User object</param>
	/// <returns>A boolean that tells whether the user has set a password or not</returns>
	public static bool HasValidPasswordSet(this IUser authenticatedUser)
	{
		PasswordStatusResult passwordStatus = AccountPasswordHash.PasswordsClient.GetPasswordStatus(PasswordOwnerType.Account, authenticatedUser.AccountId);
		if (passwordStatus.SetStatus != PasswordSetStatus.ValidPasswordSet)
		{
			return passwordStatus.SetStatus == PasswordSetStatus.PasswordNeedsReset;
		}
		return true;
	}

	public static void InvalidateAllAccountSecurityTickets(this IUser user)
	{
		user.VerifyIsNotNull();
		AccountSecurityTicket.InvalidateAllAccountSecurityTickets(Account.Get(user.AccountId));
	}
}
