using System.Collections.Generic;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Factory for getting accounts audit-related information
/// </summary>
public interface IAccountsAuditFactory
{
	/// <summary>
	/// Obtains the audit history on a user's Account Status changes.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> of the user whose account status history is being retrieved.</param>
	/// <param name="count">The number of records to return.</param>
	/// <param name="exclusiveStartId">The exclusive start Id.</param>
	/// <param name="shouldReturnForgottenUser">Whether the records of a forgotten user should be returned, default to False (not returned).</param>
	/// <returns>A collection of <see cref="T:Roblox.Platform.Membership.Commands.IAccountsAuditCompositeEntry" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Throws when user is null.</exception>
	/// <exception cref="T:System.ArgumentException">Throws when count is not positive.</exception>
	ICollection<IAccountsAuditCompositeEntry> GetAccountStatusChangeHistory(IUserIdentifier user, int count, long? exclusiveStartId = null, bool shouldReturnForgottenUser = false);
}
