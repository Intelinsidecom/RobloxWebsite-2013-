using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Membership.Commands.Audit;

[ExcludeFromCodeCoverage]
internal class AccountsAuditMetadataEntityFactory : IAccountsAuditMetadataEntityFactory
{
	public IAccountsAuditMetadataEntity Get(long id)
	{
		return CalToCachedMssql(AccountsAuditMetadataCAL.Get(id));
	}

	public ICollection<IAccountsAuditMetadataEntity> GetByAccountsChangeTypeIdAndUserIdEnumerative(byte accountsChangeTypeId, long userId, int count, long? exclusiveStartId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountsAuditMetadataCAL.GetAccountsAuditMetadataByAccountsChangeTypeIDAndUserID(accountsChangeTypeId, userId, count, exclusiveStartId).Select(CalToCachedMssql).ToArray();
	}

	public IAccountsAuditMetadataEntity Create(IUser targetUser, Guid auditEntryPublicId, AccountsAuditChangeType typeId, long? actorUserId)
	{
		AccountsAuditMetadataCAL accountsAuditMetadataCAL = new AccountsAuditMetadataCAL();
		accountsAuditMetadataCAL.AccountsAuditEntriesPublicID = auditEntryPublicId;
		accountsAuditMetadataCAL.AccountsChangeTypeID = (byte)typeId;
		accountsAuditMetadataCAL.ActorUserID = actorUserId;
		accountsAuditMetadataCAL.UserID = targetUser.Id;
		accountsAuditMetadataCAL.Save();
		return CalToCachedMssql(accountsAuditMetadataCAL);
	}

	private static IAccountsAuditMetadataEntity CalToCachedMssql(AccountsAuditMetadataCAL cal)
	{
		if (cal != null)
		{
			return new AccountsAuditMetadataCachedMssqlEntity
			{
				Id = cal.ID,
				AccountsAuditEntriesPublicId = cal.AccountsAuditEntriesPublicID,
				AccountsChangeTypeId = cal.AccountsChangeTypeID,
				ActorUserId = cal.ActorUserID,
				UserId = cal.UserID,
				Created = cal.Created
			};
		}
		return null;
	}
}
