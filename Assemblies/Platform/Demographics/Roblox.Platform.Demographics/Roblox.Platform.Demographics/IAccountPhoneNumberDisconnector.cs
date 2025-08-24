using Roblox.Platform.Membership;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides method to disconnect accounts and phone numbers.
/// </summary>
public interface IAccountPhoneNumberDisconnector
{
	/// <summary>
	/// Disconnects phone numbers from the given <see cref="T:Roblox.Platform.Membership.IUser" />. 
	/// </summary>
	/// <remarks>
	/// It is risky to use this method outside of the processors as this method will try to disconnect all the possible
	/// entries.
	/// Anyone else using this account's phone numbers would still be using them.
	/// Disconnects phone number from phone audits and removes values.
	/// This won't create account security ticket.
	/// Typical use case for this method is COPPA or GDPR (privacy) related concerns.
	/// This method won't delete phone number entries.
	///
	/// After this is executed we might have some orphans left in the phone numbers table but since someone else might
	/// still use phone numbers we cannot perform phone number removal.
	/// </remarks>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="reason">Reason for disconnect <see cref="T:Roblox.Platform.Demographics.DisconnectAccountPhoneNumbersReasons" />.</param>
	void DisconnectPhoneNumbersFromAccount(IUser user, DisconnectAccountPhoneNumbersReasons reason);
}
