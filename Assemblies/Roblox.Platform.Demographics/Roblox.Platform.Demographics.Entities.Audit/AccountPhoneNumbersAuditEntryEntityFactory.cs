using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Demographics.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumbersAuditEntryEntityFactory : IAccountPhoneNumbersAuditEntryEntityFactory, IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>, IAuditEntryEntityFactory<IAccountPhoneNumbersAuditEntryEntity>
{
	public DemographicsDomainFactories DomainFactories { get; }

	public AccountPhoneNumbersAuditEntryEntityFactory(DemographicsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountPhoneNumbersAuditEntryEntity Get(long id)
	{
		return CalToCachedMssql(AccountPhoneNumbersAuditEntry.Get(id));
	}

	public IAccountPhoneNumbersAuditEntryEntity GetByPublicId(Guid publicId)
	{
		return CalToCachedMssql(AccountPhoneNumbersAuditEntry.GetByPublicID(publicId));
	}

	private static IAccountPhoneNumbersAuditEntryEntity CalToCachedMssql(AccountPhoneNumbersAuditEntry cal)
	{
		if (cal != null)
		{
			return new AccountPhoneNumbersAuditEntryCachedMssqlEntity
			{
				Id = cal.ID,
				PublicId = cal.PublicID,
				Audit_Id = cal.Audit_ID,
				Audit_AccountId = cal.Audit_AccountID,
				Audit_PhoneNumberId = cal.Audit_PhoneNumberID,
				Audit_IsVerified = cal.Audit_IsVerified,
				Audit_Phone = cal.Audit_Phone,
				Audit_Created = cal.Audit_Created,
				Audit_Updated = cal.Audit_Updated,
				Created = cal.Created
			};
		}
		return null;
	}

	public IAccountPhoneNumbersAuditEntryEntity CreateNew(IAccountPhoneNumberEntity entity)
	{
		AccountPhoneNumbersAuditEntry accountPhoneNumbersAuditEntry = new AccountPhoneNumbersAuditEntry();
		accountPhoneNumbersAuditEntry.PublicID = Guid.NewGuid();
		accountPhoneNumbersAuditEntry.Audit_ID = entity.Id;
		accountPhoneNumbersAuditEntry.Audit_AccountID = entity.AccountId;
		accountPhoneNumbersAuditEntry.Audit_IsVerified = entity.IsVerified;
		accountPhoneNumbersAuditEntry.Audit_Phone = entity.Phone;
		accountPhoneNumbersAuditEntry.Audit_PhoneNumberID = entity.PhoneNumberId;
		accountPhoneNumbersAuditEntry.Audit_Created = entity.Created;
		accountPhoneNumbersAuditEntry.Audit_Updated = entity.Updated;
		accountPhoneNumbersAuditEntry.Save();
		return CalToCachedMssql(accountPhoneNumbersAuditEntry);
	}

	public ICollection<IAccountPhoneNumbersAuditEntryEntity> GetByPublicIds(ICollection<Guid> publicIds)
	{
		return publicIds.Select(AccountPhoneNumbersAuditEntry.GetByPublicID).Select(CalToCachedMssql).ToArray();
	}
}
