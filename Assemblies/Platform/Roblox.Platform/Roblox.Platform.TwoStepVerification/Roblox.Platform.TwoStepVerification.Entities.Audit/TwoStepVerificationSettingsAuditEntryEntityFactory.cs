using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSettingsAuditEntryEntityFactory : ITwoStepVerificationSettingsAuditEntryEntityFactory, IAuditEntryEntityFactory<ITwoStepVerificationSettingsAuditEntryEntity>
{
	public TwoStepVerificationDomainProvider DomainFactories { get; }

	public TwoStepVerificationSettingsAuditEntryEntityFactory(TwoStepVerificationDomainProvider domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public ITwoStepVerificationSettingsAuditEntryEntity Get(long id)
	{
		return CalToCachedMssql(TwoStepVerificationSettingsAuditEntry.Get(id));
	}

	public ITwoStepVerificationSettingsAuditEntryEntity GetByPublicId(Guid publicId)
	{
		return CalToCachedMssql(TwoStepVerificationSettingsAuditEntry.GetByPublicID(publicId));
	}

	private static ITwoStepVerificationSettingsAuditEntryEntity CalToCachedMssql(TwoStepVerificationSettingsAuditEntry cal)
	{
		if (cal != null)
		{
			return new TwoStepVerificationSettingsAuditEntryCachedMssqlEntity
			{
				Id = cal.ID,
				PublicId = cal.PublicID,
				Audit_Id = cal.Audit_ID,
				Audit_UserId = cal.Audit_UserID,
				Audit_IsEnabled = cal.Audit_IsEnabled,
				Audit_TwoStepVerificationMediaTypeId = cal.Audit_TwoStepVerificationMediaTypeID,
				Audit_Created = cal.Audit_Created,
				Audit_Updated = cal.Audit_Updated,
				Created = cal.Created
			};
		}
		return null;
	}

	public ITwoStepVerificationSettingsAuditEntryEntity CreateNew(ITwoStepVerificationSettingEntity entity)
	{
		TwoStepVerificationSettingsAuditEntry twoStepVerificationSettingsAuditEntry = new TwoStepVerificationSettingsAuditEntry();
		twoStepVerificationSettingsAuditEntry.PublicID = Guid.NewGuid();
		twoStepVerificationSettingsAuditEntry.Audit_ID = entity.Id;
		twoStepVerificationSettingsAuditEntry.Audit_UserID = entity.UserId;
		twoStepVerificationSettingsAuditEntry.Audit_IsEnabled = entity.IsEnabled;
		twoStepVerificationSettingsAuditEntry.Audit_TwoStepVerificationMediaTypeID = entity.TwoStepVerificationMediaTypeId;
		twoStepVerificationSettingsAuditEntry.Audit_Created = entity.Created;
		twoStepVerificationSettingsAuditEntry.Audit_Updated = entity.Updated;
		twoStepVerificationSettingsAuditEntry.Save();
		return CalToCachedMssql(twoStepVerificationSettingsAuditEntry);
	}

	public ICollection<ITwoStepVerificationSettingsAuditEntryEntity> GetByPublicIds(ICollection<Guid> publicIds)
	{
		return publicIds.Select(TwoStepVerificationSettingsAuditEntry.GetByPublicID).Select(CalToCachedMssql).ToArray();
	}
}
