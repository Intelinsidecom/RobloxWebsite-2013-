using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Membership.Entities;

namespace Roblox.Platform.Membership.Commands.Audit;

[ExcludeFromCodeCoverage]
internal class AccountsAuditEntryEntityFactory : IAccountsAuditEntryEntityFactory
{
	public IAccountsAuditEntryEntity Get(long id)
	{
		return CalToCachedMssql(AccountsAuditEntryCAL.Get(id));
	}

	public IAccountsAuditEntryEntity GetByPublicId(Guid publicId)
	{
		return CalToCachedMssql(AccountsAuditEntryCAL.GetByPublicID(publicId));
	}

	public ICollection<IAccountsAuditEntryEntity> SingleGetsByPublicIds(IEnumerable<Guid> publicIds)
	{
		return AccountsAuditEntryCAL.SingleGetsByPublicIds(publicIds).Select(CalToCachedMssql).ToArray();
	}

	public IAccountsAuditEntryEntity Create(IAccountEntity entity)
	{
		AccountsAuditEntryCAL accountsAuditEntryCAL = new AccountsAuditEntryCAL();
		accountsAuditEntryCAL.Audit_ID = entity.Id;
		accountsAuditEntryCAL.Audit_Name = entity.Name;
		accountsAuditEntryCAL.Audit_AccountStatusID = entity.AccountStatus.GetId();
		accountsAuditEntryCAL.Audit_RoleSetID = entity.GetHighestRoleSetEntity().Id;
		accountsAuditEntryCAL.Audit_Description = entity.Description;
		accountsAuditEntryCAL.Audit_Created = entity.Created;
		accountsAuditEntryCAL.Audit_Updated = entity.Updated;
		accountsAuditEntryCAL.Save();
		return CalToCachedMssql(accountsAuditEntryCAL);
	}

	private static IAccountsAuditEntryEntity CalToCachedMssql(AccountsAuditEntryCAL cal)
	{
		if (cal != null)
		{
			return new AccountsAuditEntryCachedMssqlEntity
			{
				Id = cal.ID,
				PublicId = cal.PublicID,
				Audit_Id = cal.Audit_ID,
				Audit_Name = cal.Audit_Name,
				Audit_AccountStatusId = cal.Audit_AccountStatusID,
				Audit_RoleSetId = cal.Audit_RoleSetID,
				Audit_Description = cal.Audit_Description,
				Audit_Created = cal.Audit_Created,
				Audit_Updated = cal.Audit_Updated,
				Created = cal.Created
			};
		}
		return null;
	}
}
