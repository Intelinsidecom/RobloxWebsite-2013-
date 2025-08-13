using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class TwoSVSettingsAuditMetadataCachedMssqlEntity : ITwoSVSettingsAuditMetadataEntity, IEntity<long>, IAuditMetadata
{
	public long Id { get; set; }

	public Guid TwoStepVerificationSettingsAuditEntriesPublicId { get; set; }

	public long UserId { get; set; }

	public long? ActorUserId { get; set; }

	public byte TwoStepVerificationChangeTypeId { get; set; }

	public bool IsLegacyValue { get; set; }

	public DateTime Created { get; set; }

	public Guid ForeignPublicId => TwoStepVerificationSettingsAuditEntriesPublicId;

	public void Delete()
	{
		(TwoSVSettingsAuditMetadata.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}

	public long? GetActorUserId()
	{
		if (!ActorUserId.HasValue)
		{
			return null;
		}
		try
		{
			return ActorUserId;
		}
		catch (Exception)
		{
			return null;
		}
	}
}
