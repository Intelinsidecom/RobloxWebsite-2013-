namespace Roblox.Platform.AccountPins.Entities;

/// <summary>
/// A platform factory for creating and getting Pin Entries.
/// </summary>
internal interface IPinEntryEntityFactory
{
	/// <summary>
	/// Creates the new <see cref="T:Roblox.Platform.AccountPins.Entities.IPinEntryEntity" />.
	/// </summary>
	/// <param name="accountId">The account identifier.</param>
	/// <param name="sessionString">The session string.</param>
	/// <param name="pinHashId">The pin hash identifier.</param>
	/// <returns>IPinEntryEntity.</returns>
	IPinEntryEntity CreateNew(long accountId, string sessionString, long pinHashId);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.AccountPins.Entities.IPinEntryEntity" /> associated with current accountId and session string.
	/// </summary>
	/// <param name="accountId">The account identifier.</param>
	/// <param name="sessionString">The session string.</param>
	/// <returns>
	/// A <see cref="T:Roblox.Platform.AccountPins.Entities.IPinEntryEntity" /> if it exists else null.
	/// </returns>
	IPinEntryEntity Get(long accountId, string sessionString);
}
