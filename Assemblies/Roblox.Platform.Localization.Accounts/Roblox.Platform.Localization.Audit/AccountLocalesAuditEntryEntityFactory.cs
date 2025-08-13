using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditEntryEntityFactory : IAccountLocalesAuditEntryEntityFactory
{
	public IAccountLocalesAuditEntryEntity GetById(long id)
	{
		return CalToCachedMssql(AccountLocalesAuditEntry.Get(id));
	}

	public IAccountLocalesAuditEntryEntity GetByPublicId(Guid publicId)
	{
		return CalToCachedMssql(AccountLocalesAuditEntry.GetByPublicId(publicId));
	}

	public IReadOnlyCollection<IAccountLocalesAuditEntryEntity> MultiGetByPublicIds(IEnumerable<Guid> publicIds)
	{
		return (IReadOnlyCollection<IAccountLocalesAuditEntryEntity>)(object)AccountLocalesAuditEntry.SingleGetByPublicIds(publicIds).Select(CalToCachedMssql).ToArray();
	}

	public IReadOnlyCollection<IAccountLocalesAuditEntryEntity> MultiGetByAuditId(long auditId, int count, long? exclusiveStartId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return (IReadOnlyCollection<IAccountLocalesAuditEntryEntity>)(object)AccountLocalesAuditEntry.GetAccountLocalesAuditEntriesByAuditId(auditId, count, exclusiveStartId).Select(CalToCachedMssql).ToArray();
	}

	public IAccountLocalesAuditEntryEntity Create(IAccountLocaleEntity entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		AccountLocalesAuditEntry accountLocalesAuditEntry = new AccountLocalesAuditEntry();
		accountLocalesAuditEntry.PublicId = Guid.NewGuid();
		accountLocalesAuditEntry.AuditId = entity.Id;
		accountLocalesAuditEntry.AuditAccountId = entity.AccountId;
		accountLocalesAuditEntry.AuditObservedLocaleId = entity.ObservedLocaleId;
		accountLocalesAuditEntry.AuditSupportedLocaleId = entity.SupportedLocaleId;
		accountLocalesAuditEntry.AuditCreated = entity.Created;
		accountLocalesAuditEntry.AuditUpdated = entity.Updated;
		accountLocalesAuditEntry.Save();
		return CalToCachedMssql(accountLocalesAuditEntry);
	}

	private static IAccountLocalesAuditEntryEntity CalToCachedMssql(AccountLocalesAuditEntry cal)
	{
		if (cal != null)
		{
			return new AccountLocalesAuditEntryCachedMssqlEntity
			{
				Id = cal.ID,
				PublicId = cal.PublicId,
				AuditId = cal.AuditId,
				AuditAccountId = cal.AuditAccountId,
				AuditObservedLocaleId = cal.AuditObservedLocaleId,
				AuditSupportedLocaleId = cal.AuditSupportedLocaleId,
				AuditCreated = cal.AuditCreated,
				AuditUpdated = cal.AuditUpdated,
				Created = cal.Created
			};
		}
		return null;
	}
}
