using System.Collections.Generic;

namespace Roblox.Platform.Membership;

/// <summary>
/// A factory producing <see cref="T:Roblox.Platform.Membership.UsersAuditCompositeEntry">UsersAuditCompositeEntries</see>.
/// </summary>
public interface IUsersAuditCompositeEntryFactory
{
	/// <summary>
	/// Obtains audit information on a user's birthhdate changes.
	/// </summary>
	ICollection<IUsersAuditCompositeEntry> GetBirthdateHistory(long userId, byte count, long exclusiveStartId = 0L);

	/// <summary>
	/// Obtains audit information on a user's gender changes.
	/// </summary>
	ICollection<IUsersAuditCompositeEntry> GetGenderHistory(long userId, byte count, long exclusiveStartId = 0L);
}
