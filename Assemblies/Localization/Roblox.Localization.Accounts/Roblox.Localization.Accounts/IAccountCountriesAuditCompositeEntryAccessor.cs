using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// An accessor to obtain <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesAuditCompositeEntry" /> records.
/// </summary>
public interface IAccountCountriesAuditCompositeEntryAccessor
{
	/// <summary>
	/// Obtains audit information on a user's country changes.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> we wish to audit.</param>
	/// <param name="count">The number of records to obtain. Must be eqaual or less than the setting.AccountCountriesAuditCompositeEntryCountLimit.</param>
	/// <param name="exclusiveStartId">The exclusive start id of the query. Default is 0.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"> If the <see cref="T:Roblox.Platform.Membership.IUser" /> is null.</exception>
	/// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> of <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesAuditCompositeEntry" />. It's possible this is empty if no audit records are found.</returns>
	ICollection<IAccountCountriesAuditCompositeEntry> GetCountryHistory(IUser user, byte count, long exclusiveStartId = 0L);
}
