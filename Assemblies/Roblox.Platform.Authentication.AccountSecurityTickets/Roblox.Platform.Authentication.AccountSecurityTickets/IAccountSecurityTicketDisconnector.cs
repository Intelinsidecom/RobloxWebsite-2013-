namespace Roblox.Platform.Authentication.AccountSecurityTickets;

/// <summary>
///     Provides methods to disconnect account security tickets with various information.
/// </summary>
public interface IAccountSecurityTicketDisconnector
{
	/// <summary>
	///     Disconnects security tickets and all their ticket items that are targeting phones.
	/// </summary>
	/// <remarks>
	///     It is not safe to use this method outside of the processors.
	///     Where is this used? When phone number is purged or disconnected from the user, due to privacy
	///     (COPPA or GDPR), we would need to remove all security tickets that keep user -&gt; phone connection.
	/// </remarks>
	/// <param name="accountId">Account whose security tickets should be removed.</param>
	void DisconnectSecurityTicketsWithPhoneNumber(long accountId);

	/// <summary>
	///     Disconnects security tickets and all ticket items that are targeting emails for provided accountId.
	/// </summary>
	/// <remarks>
	///     It is not safe to use this method outside of the processors.
	///     Where is this used? When email is purged or disconnected from the user, due to privacy
	///     (COPPA or GDPR), we would need to remove all security tickets that keep user -&gt; email connection.
	/// </remarks>
	/// <param name="accountId">Account whose security tickets should be removed.</param>
	void DisconnectSecurityTicketsWithEmail(long accountId);
}
