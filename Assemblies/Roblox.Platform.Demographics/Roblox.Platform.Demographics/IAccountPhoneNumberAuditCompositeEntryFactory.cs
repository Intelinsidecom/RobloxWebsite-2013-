using System.Collections.Generic;

namespace Roblox.Platform.Demographics;

/// <summary>
/// A public interface producing <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberAuditCompositeEntry">IAccountPhoneNumberAuditCompositeEntries</see>
/// </summary>
public interface IAccountPhoneNumberAuditCompositeEntryFactory
{
	/// <summary>
	/// Obtains full audit information on a user's phone number history changes
	/// </summary>
	ICollection<IAccountPhoneNumberAuditCompositeEntry> GetFullPhoneNumberHistory(long userId, byte count, long? exclusiveStartId = null);

	/// <summary>
	/// Obtains audit information on unverified phone number being added for the user's account
	/// </summary>
	ICollection<IAccountPhoneNumberAuditCompositeEntry> GetAddingUnverifiedUserPhoneNumbersHistory(long userId, byte count, long? exclusiveStartId = null);

	/// <summary>
	/// Obtains audit information on a phone number being verified for the user's account
	/// </summary>
	ICollection<IAccountPhoneNumberAuditCompositeEntry> GetVerifiedUserPhoneNumbersHistory(long userId, byte count, long? exclusiveStartId = null);
}
