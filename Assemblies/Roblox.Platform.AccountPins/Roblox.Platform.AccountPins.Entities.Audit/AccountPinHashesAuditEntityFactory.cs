using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.AccountPins.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPinHashesAuditEntityFactory : IAccountPinHashesAuditEntityFactory, IDomainFactory<AccountPinsDomainFactories>, IDomainObject<AccountPinsDomainFactories>, IAuditEntryEntityFactory<IAccountPinHashesAuditEntity>
{
	public AccountPinsDomainFactories DomainFactories { get; }

	public AccountPinHashesAuditEntityFactory(AccountPinsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountPinHashesAuditEntity Get(long id)
	{
		return CalToCachedMssql(AccountPinHashesAuditCAL.Get(id));
	}

	public IAccountPinHashesAuditEntity GetByPublicId(Guid publicId)
	{
		return CalToCachedMssql(AccountPinHashesAuditCAL.GetByPublicID(publicId));
	}

	private static IAccountPinHashesAuditEntity CalToCachedMssql(AccountPinHashesAuditCAL cal)
	{
		if (cal != null)
		{
			return new AccountPinHashesAuditCachedMssqlEntity
			{
				Id = cal.ID,
				PublicId = cal.PublicID,
				Audit_Id = cal.Audit_ID,
				Audit_AccountId = cal.Audit_AccountID,
				Audit_PinHash = cal.Audit_PinHash,
				Audit_IsValid = cal.Audit_IsValid,
				Audit_Created = cal.Audit_Created,
				Audit_Updated = cal.Audit_Updated,
				Created = cal.Created
			};
		}
		return null;
	}

	public IAccountPinHashesAuditEntity CreateNew(IAccountPinHashEntity entity)
	{
		AccountPinHashesAuditCAL accountPinHashesAuditCAL = new AccountPinHashesAuditCAL();
		accountPinHashesAuditCAL.PublicID = Guid.NewGuid();
		accountPinHashesAuditCAL.Audit_ID = entity.Id;
		accountPinHashesAuditCAL.Audit_AccountID = entity.AccountId;
		accountPinHashesAuditCAL.Audit_PinHash = entity.PinHash;
		accountPinHashesAuditCAL.Audit_IsValid = entity.IsValid;
		accountPinHashesAuditCAL.Audit_Created = entity.Created;
		accountPinHashesAuditCAL.Audit_Updated = entity.Updated;
		accountPinHashesAuditCAL.Save();
		return CalToCachedMssql(accountPinHashesAuditCAL);
	}

	public ICollection<IAccountPinHashesAuditEntity> GetByPublicIds(ICollection<Guid> publicIds)
	{
		return publicIds.Select(AccountPinHashesAuditCAL.GetByPublicID).Select(CalToCachedMssql).ToArray();
	}
}
