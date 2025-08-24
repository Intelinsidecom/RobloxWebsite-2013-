using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAuditEntryEntityFactory : IAccountCountriesAuditEntryEntityFactory
{
	public IAccountCountriesAuditEntryEntity GetById(long id)
	{
		AccountCountriesAuditEntry cal = AccountCountriesAuditEntry.Get(id);
		return CalToCachedMssql(cal);
	}

	public IAccountCountriesAuditEntryEntity GetByPublicId(Guid publicId)
	{
		if (publicId == Guid.Empty)
		{
			return null;
		}
		AccountCountriesAuditEntry cal = AccountCountriesAuditEntry.GetByPublicId(publicId);
		return CalToCachedMssql(cal);
	}

	public IReadOnlyCollection<IAccountCountriesAuditEntryEntity> SingleGetsByPublicIds(IEnumerable<Guid> publicIds)
	{
		return (IReadOnlyCollection<IAccountCountriesAuditEntryEntity>)(object)AccountCountriesAuditEntry.SingleGetByPublicIds(publicIds).Select(CalToCachedMssql).ToArray();
	}

	public IReadOnlyCollection<IAccountCountriesAuditEntryEntity> GetByAuditIdEnumerative(long auditId, int count, long? exclusiveStartId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "count"));
		}
		return (IReadOnlyCollection<IAccountCountriesAuditEntryEntity>)(object)AccountCountriesAuditEntry.GetAccountCountriesAuditEntriesByAuditId(auditId, count, exclusiveStartId).Select(CalToCachedMssql).ToArray();
	}

	public IAccountCountriesAuditEntryEntity Create(IAccountCountryEntity entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		AccountCountriesAuditEntry cal = new AccountCountriesAuditEntry
		{
			PublicId = Guid.NewGuid(),
			AuditId = entity.Id,
			AuditAccountId = entity.AccountId,
			AuditCountryId = entity.CountryId,
			AuditIsVerified = entity.IsVerified,
			AuditCreated = entity.Created,
			AuditUpdated = entity.Updated
		};
		cal.Save();
		return CalToCachedMssql(cal);
	}

	private IAccountCountriesAuditEntryEntity CalToCachedMssql(AccountCountriesAuditEntry cal)
	{
		if (cal != null)
		{
			return new AccountCountriesAuditEntryCachedMssqlEntity
			{
				Id = cal.ID,
				PublicId = cal.PublicId,
				AuditId = cal.AuditId,
				AuditAccountId = cal.AuditAccountId,
				AuditCountryId = cal.AuditCountryId,
				AuditIsVerified = cal.AuditIsVerified,
				AuditCreated = cal.AuditCreated,
				AuditUpdated = cal.AuditUpdated,
				Created = cal.Created
			};
		}
		return null;
	}
}
