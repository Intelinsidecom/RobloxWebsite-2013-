using System;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.UserDataAuditCore;
using Roblox.Platform.TwoStepVerification.Entities.Audit;

namespace Roblox.Platform.TwoStepVerification;

internal class TwoStepVerificationSettingsAuditCompositeEntry : ITwoStepVerificationSettingsAuditCompositeEntry, IAuditCompositeEntry
{
	private readonly ITwoSVSettingsAuditMetadataEntity _Metadata;

	private readonly ITwoStepVerificationSettingsAuditEntryEntity _AuditEntry;

	public long Id => _Metadata.Id;

	public long UserId => _Metadata.UserId;

	public TwoStepVerificationChangeType Type => (TwoStepVerificationChangeType)_Metadata.TwoStepVerificationChangeTypeId;

	public long? ActorUserId => _Metadata.ActorUserId;

	public string ActorName { get; set; }

	public bool IsLegacyValue => _Metadata.IsLegacyValue;

	public long? Audit_Id => _AuditEntry?.Audit_Id;

	public bool? Audit_IsEnabled => _AuditEntry?.Audit_IsEnabled;

	public long? Audit_UserID => _AuditEntry?.Audit_UserId;

	public DateTime? Audit_Created => _AuditEntry?.Audit_Created;

	public DateTime? Audit_Updated => _AuditEntry?.Audit_Updated;

	public byte? Audit_TwoStepVerificationMediaTypeID => _AuditEntry?.Audit_TwoStepVerificationMediaTypeId;

	public TwoStepVerificationMediaType? Audit_TwoStepVerificationMediaType { get; private set; }

	public TwoStepVerificationSettingsAuditCompositeEntry(ITwoStepVerificationMediaTypeFactory mediaTypeFactory, ITwoSVSettingsAuditMetadataEntity metadata, ITwoStepVerificationSettingsAuditEntryEntity auditEntry)
	{
		if (mediaTypeFactory == null)
		{
			throw new PlatformArgumentNullException("mediaTypeFactory");
		}
		_Metadata = metadata.AssignOrThrowIfNull("metadata");
		_AuditEntry = auditEntry;
		Audit_TwoStepVerificationMediaType = null;
		if (auditEntry != null && auditEntry.Audit_TwoStepVerificationMediaTypeId.HasValue)
		{
			Audit_TwoStepVerificationMediaType = mediaTypeFactory.GetValueById(auditEntry.Audit_TwoStepVerificationMediaTypeId.Value);
		}
	}
}
