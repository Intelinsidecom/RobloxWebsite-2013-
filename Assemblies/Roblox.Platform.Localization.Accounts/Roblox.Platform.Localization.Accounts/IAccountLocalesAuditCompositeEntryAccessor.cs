using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// An accessor to obtain <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocalesAuditCompositeEntry" /> records.
/// </summary>
public interface IAccountLocalesAuditCompositeEntryAccessor
{
	/// <summary>
	/// Obtains audit information on a user's supported locale changes.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> we wish to audit.</param>
	/// <param name="count">The number of records to obtain, Must be equal or less than the setting AccountLocalesAuditCompositeEntryCountLimit.</param>
	/// <param name="exclusiveStartId">The exclusive start id of the query, default is <see cref="F:System.Int64.MaxValue" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"> if the <see cref="T:Roblox.Platform.Membership.IUser" /> is null.</exception>
	/// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> of <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocalesAuditCompositeEntry" />. It is possible this is empty if no audit records are found.</returns>
	ICollection<IAccountLocalesAuditCompositeEntry> GetSupportedLocaleHistory(IUser user, byte count, long exclusiveStartId = long.MaxValue);

	/// <summary>
	/// Obtains audit information on a user's observed locale changes.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> we wish to audit.</param>
	/// <param name="count">The number of records to obtain, Must be equal or less than the setting AccountLocalesAuditCompositeEntryCountLimit.</param>
	/// <param name="exclusiveStartId">The exclusive start id of the query, default is <see cref="F:System.Int64.MaxValue" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"> if the <see cref="T:Roblox.Platform.Membership.IUser" /> is null.</exception>
	/// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> of <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocalesAuditCompositeEntry" />. It is possible this is empty if no audit records are found.</returns>
	ICollection<IAccountLocalesAuditCompositeEntry> GetObservedLocaleHistory(IUser user, byte count, long exclusiveStartId = long.MaxValue);
}
