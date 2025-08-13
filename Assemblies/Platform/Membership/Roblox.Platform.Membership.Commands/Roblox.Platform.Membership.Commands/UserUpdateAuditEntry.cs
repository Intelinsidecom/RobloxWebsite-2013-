using Roblox.Platform.Membership.Audit;
using Roblox.Platform.Membership.Commands.Audit;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Account and user are the same thing to the user service
/// </summary>
internal sealed class UserUpdateAuditEntry
{
	public readonly IUsersAuditEntryEntity UsersAuditEntryEntity;

	public readonly IAccountsAuditEntryEntity AccountsAuditEntryEntity;

	/// <summary>
	/// Default Constructor
	/// </summary>
	/// <param name="usersAuditEntryEntity"></param>
	/// <param name="accountsAuditEntryEntity"></param>
	public UserUpdateAuditEntry(IUsersAuditEntryEntity usersAuditEntryEntity, IAccountsAuditEntryEntity accountsAuditEntryEntity)
	{
		UsersAuditEntryEntity = usersAuditEntryEntity;
		AccountsAuditEntryEntity = accountsAuditEntryEntity;
	}
}
