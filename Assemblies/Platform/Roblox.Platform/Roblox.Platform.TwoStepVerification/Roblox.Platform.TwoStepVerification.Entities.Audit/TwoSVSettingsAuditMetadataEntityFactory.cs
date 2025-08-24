using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class TwoSVSettingsAuditMetadataEntityFactory : ITwoSVSettingsAuditMetadataEntityFactory
{
	public TwoStepVerificationDomainProvider DomainFactories { get; }

	public TwoSVSettingsAuditMetadataEntityFactory(TwoStepVerificationDomainProvider domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public ITwoSVSettingsAuditMetadataEntity Get(long id)
	{
		return CalToCachedMssql(TwoSVSettingsAuditMetadata.Get(id));
	}

	public IEnumerable<ITwoSVSettingsAuditMetadataEntity> GetByUserIdEnumerative(long userId, int count, long? exclusiveStartTwoSVSettingsAuditMetadataId)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return TwoSVSettingsAuditMetadata.GetTwoSVSettingsAuditMetadataByUserID(userId, count, exclusiveStartTwoSVSettingsAuditMetadataId).Select(CalToCachedMssql);
	}

	public IEnumerable<ITwoSVSettingsAuditMetadataEntity> GetByUserIdAndTwoStepVerificationChangeTypeIdEnumerative(long userId, byte twoStepVerificationChangeTypeId, int count, long? exclusiveStartTwoSVSettingsAuditMetadataId)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return TwoSVSettingsAuditMetadata.GetTwoSVSettingsAuditMetadataByUserIDAndTwoStepVerificationChangeTypeID(userId, twoStepVerificationChangeTypeId, count, exclusiveStartTwoSVSettingsAuditMetadataId).Select(CalToCachedMssql);
	}

	private static ITwoSVSettingsAuditMetadataEntity CalToCachedMssql(TwoSVSettingsAuditMetadata cal)
	{
		if (cal != null)
		{
			return new TwoSVSettingsAuditMetadataCachedMssqlEntity
			{
				Id = cal.ID,
				TwoStepVerificationSettingsAuditEntriesPublicId = cal.TwoStepVerificationSettingsAuditEntriesPublicID,
				UserId = cal.UserID,
				ActorUserId = cal.ActorUserID,
				TwoStepVerificationChangeTypeId = cal.TwoStepVerificationChangeTypeID,
				IsLegacyValue = cal.IsLegacyValue,
				Created = cal.Created
			};
		}
		return null;
	}

	public ITwoSVSettingsAuditMetadataEntity CreateNew(IUserIdentifier targetUser, Guid auditEntryPublicId, TwoStepVerificationChangeType changeType, IUserIdentifier actorUser)
	{
		TwoSVSettingsAuditMetadata twoSVSettingsAuditMetadata = new TwoSVSettingsAuditMetadata();
		twoSVSettingsAuditMetadata.UserID = targetUser.Id;
		twoSVSettingsAuditMetadata.TwoStepVerificationChangeTypeID = (byte)changeType;
		twoSVSettingsAuditMetadata.TwoStepVerificationSettingsAuditEntriesPublicID = auditEntryPublicId;
		twoSVSettingsAuditMetadata.ActorUserID = actorUser.Id;
		twoSVSettingsAuditMetadata.IsLegacyValue = false;
		twoSVSettingsAuditMetadata.Save();
		return CalToCachedMssql(twoSVSettingsAuditMetadata);
	}

	public ITwoSVSettingsAuditMetadataEntity CreateLegacyEntry(long targetUserId, Guid auditEntryPublicId, TwoStepVerificationChangeType changeType, int actorUserId)
	{
		TwoSVSettingsAuditMetadata twoSVSettingsAuditMetadata = new TwoSVSettingsAuditMetadata();
		twoSVSettingsAuditMetadata.UserID = targetUserId;
		twoSVSettingsAuditMetadata.TwoStepVerificationChangeTypeID = (byte)changeType;
		twoSVSettingsAuditMetadata.TwoStepVerificationSettingsAuditEntriesPublicID = auditEntryPublicId;
		twoSVSettingsAuditMetadata.ActorUserID = actorUserId;
		twoSVSettingsAuditMetadata.IsLegacyValue = false;
		twoSVSettingsAuditMetadata.Save();
		return CalToCachedMssql(twoSVSettingsAuditMetadata);
	}
}
