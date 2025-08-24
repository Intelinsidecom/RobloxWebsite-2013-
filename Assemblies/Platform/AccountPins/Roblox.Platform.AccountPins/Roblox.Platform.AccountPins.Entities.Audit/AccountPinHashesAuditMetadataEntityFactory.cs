using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AccountPins.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPinHashesAuditMetadataEntityFactory : IAccountPinHashesAuditMetadataEntityFactory, IDomainFactory<AccountPinsDomainFactories>, IDomainObject<AccountPinsDomainFactories>
{
	public AccountPinsDomainFactories DomainFactories { get; }

	public AccountPinHashesAuditMetadataEntityFactory(AccountPinsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAccountPinHashesAuditMetadataEntity Get(long id)
	{
		return CalToCachedMssql(AccountPinHashesAuditMetadataCAL.Get(id));
	}

	public IEnumerable<IAccountPinHashesAuditMetadataEntity> GetByUserIdAndAccountPinChangeTypeIdEnumerative(long userId, byte accountPinChangeTypeId, int count, long? exclusiveStartId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountPinHashesAuditMetadataCAL.GetAccountPinHashesAuditMetadataByUserIDAndAccountPinChangeTypeID(userId, accountPinChangeTypeId, count, exclusiveStartId).Select(CalToCachedMssql);
	}

	public IEnumerable<IAccountPinHashesAuditMetadataEntity> GetByUserIdEnumerative(long userId, int count, long? exclusiveStartId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AccountPinHashesAuditMetadataCAL.GetAccountPinHashesAuditMetadataByUserID(userId, count, exclusiveStartId).Select(CalToCachedMssql);
	}

	private static IAccountPinHashesAuditMetadataEntity CalToCachedMssql(AccountPinHashesAuditMetadataCAL cal)
	{
		if (cal != null)
		{
			return new AccountPinHashesAuditMetadataCachedMssqlEntity
			{
				Id = cal.ID,
				AccountPinHashesAuditPublicId = cal.AccountPinHashesAuditPublicID,
				UserId = cal.UserID,
				ActorUserId = cal.ActorUserID,
				AccountPinChangeTypeId = cal.AccountPinChangeTypeID,
				Created = cal.Created
			};
		}
		return null;
	}

	public IAccountPinHashesAuditMetadataEntity CreateNew(IUserIdentifier targetUser, Guid auditEntryPublicId, AccountPinChangeType changeType, IUserIdentifier actorUser)
	{
		AccountPinHashesAuditMetadataCAL accountPinHashesAuditMetadataCAL = new AccountPinHashesAuditMetadataCAL();
		accountPinHashesAuditMetadataCAL.UserID = targetUser.Id;
		accountPinHashesAuditMetadataCAL.AccountPinChangeTypeID = (byte)changeType;
		accountPinHashesAuditMetadataCAL.AccountPinHashesAuditPublicID = auditEntryPublicId;
		accountPinHashesAuditMetadataCAL.ActorUserID = actorUser?.Id;
		accountPinHashesAuditMetadataCAL.Save();
		return CalToCachedMssql(accountPinHashesAuditMetadataCAL);
	}
}
