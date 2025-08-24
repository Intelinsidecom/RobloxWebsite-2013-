using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Demographics.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumbersAuditMetadataEntityFactory : IAccountPhoneNumbersAuditMetadataEntityFactory, IDomainFactory<DemographicsDomainFactories>, IDomainObject<DemographicsDomainFactories>
{
	public DemographicsDomainFactories DomainFactories { get; }

	public AccountPhoneNumbersAuditMetadataEntityFactory(DemographicsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountPhoneNumbersAuditMetadataEntity Get(long id)
	{
		return CalToCachedMssql(AccountPhoneNumbersAuditMetadata.Get(id));
	}

	public IEnumerable<IAccountPhoneNumbersAuditMetadataEntity> GetByUserIdEnumerative(long userId, int count, long? exclusiveStartAccountPhoneNumbersAuditMetadataId)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountPhoneNumbersAuditMetadata.GetAccountPhoneNumbersAuditMetadataByUserID(userId, count, exclusiveStartAccountPhoneNumbersAuditMetadataId).Select(CalToCachedMssql);
	}

	public IEnumerable<IAccountPhoneNumbersAuditMetadataEntity> GetByUserIdAndAccountPhoneNumbersChangeTypeIdEnumerative(long userId, byte accountPhoneNumbersChangeTypeId, int count, long? exclusiveStartAccountPhoneNumbersAuditMetadataId)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountPhoneNumbersAuditMetadata.GetAccountPhoneNumbersAuditMetadataByUserIDAndAccountPhoneNumbersChangeTypeID(userId, accountPhoneNumbersChangeTypeId, count, exclusiveStartAccountPhoneNumbersAuditMetadataId).Select(CalToCachedMssql);
	}

	private static IAccountPhoneNumbersAuditMetadataEntity CalToCachedMssql(AccountPhoneNumbersAuditMetadata cal)
	{
		if (cal != null)
		{
			return new AccountPhoneNumbersAuditMetadataCachedMssqlEntity
			{
				Id = cal.ID,
				AccountPhoneNumbersAuditEntriesPublicId = cal.AccountPhoneNumbersAuditEntriesPublicID,
				UserId = cal.UserID,
				ActorUserId = cal.ActorUserID,
				AccountPhoneNumbersChangeTypeId = cal.AccountPhoneNumbersChangeTypeID,
				IsLegacyValue = cal.IsLegacyValue,
				Created = cal.Created
			};
		}
		return null;
	}

	public IAccountPhoneNumbersAuditMetadataEntity CreateNew(IUserIdentifier targetUser, Guid auditEntryPublicId, AccountPhoneNumberChangeTypes changeType, IUserIdentifier actorUser)
	{
		AccountPhoneNumbersAuditMetadata accountPhoneNumbersAuditMetadata = new AccountPhoneNumbersAuditMetadata();
		accountPhoneNumbersAuditMetadata.UserID = targetUser.Id;
		accountPhoneNumbersAuditMetadata.AccountPhoneNumbersChangeTypeID = (byte)changeType;
		accountPhoneNumbersAuditMetadata.AccountPhoneNumbersAuditEntriesPublicID = auditEntryPublicId;
		accountPhoneNumbersAuditMetadata.ActorUserID = actorUser?.Id;
		accountPhoneNumbersAuditMetadata.IsLegacyValue = false;
		accountPhoneNumbersAuditMetadata.Save();
		return CalToCachedMssql(accountPhoneNumbersAuditMetadata);
	}
}
