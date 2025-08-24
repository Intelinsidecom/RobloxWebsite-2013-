using System;
using Roblox.Platform.Assets.Entities.Audit;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Assets.Implementation;

internal class AssetsAuditCompositeEntry : IAssetsAuditCompositeEntry, IAuditCompositeEntry
{
	private readonly IAssetsAuditMetadataEntity _Metadata;

	private readonly IAssetsAuditEntryEntity _AuditEntry;

	public long Id => _Metadata.Id;

	public string ActorName { get; set; }

	public AssetChangeType AssetChangeValue => (AssetChangeType)_Metadata.AssetChangeTypeId;

	public long? Audit_Id => _AuditEntry?.Audit_Id;

	public AssetType? Audit_AssetType
	{
		get
		{
			IAssetsAuditEntryEntity auditEntry = _AuditEntry;
			if (auditEntry != null)
			{
				_ = auditEntry.Audit_AssetTypeId;
				if (true)
				{
					return (AssetType)(_AuditEntry?.Audit_AssetTypeId).Value;
				}
			}
			return null;
		}
	}

	public string Audit_Hash => _AuditEntry?.Audit_Hash;

	public string Audit_Name => _AuditEntry?.Audit_Name;

	public string Audit_Description => _AuditEntry?.Audit_Description;

	public DateTime? Audit_Created => _AuditEntry?.Audit_Created;

	public DateTime? Audit_Updated => _AuditEntry?.Audit_Updated;

	public long? Audit_CreatorId => _AuditEntry?.Audit_CreatorId;

	public long? Audit_CurrentVersionId => _AuditEntry?.Audit_CurrentVersionId;

	public long? Audit_AssetHashId => _AuditEntry?.Audit_AssetHashId;

	public long? Audit_AssetGenres => _AuditEntry?.Audit_AssetGenres;

	public long? Audit_AssetCategories => _AuditEntry?.Audit_AssetCategories;

	public long? ActorUserId => _Metadata.ActorUserId;

	public bool IsLegacyValue => _Metadata.IsLegacyValue;

	public AssetsAuditCompositeEntry(IAssetsAuditMetadataEntity metadata, IAssetsAuditEntryEntity auditEntry)
	{
		_Metadata = metadata.AssignOrThrowIfNull("metadata");
		_AuditEntry = auditEntry;
	}
}
