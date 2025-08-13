using System;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.Audit;

namespace Roblox.Platform.Membership;

internal class UsersAuditCompositeEntry : IUsersAuditCompositeEntry
{
	private readonly IUsersAuditEntriesMetaDataEntity _MetaData;

	private readonly IUsersAuditEntryEntity _AuditEntry;

	public long Id => _MetaData.Id;

	public long UserId => _MetaData.UserId;

	public UsersAuditEntryMetaDataType Type => (UsersAuditEntryMetaDataType)_MetaData.UsersAuditEntriesMetaDataTypeId;

	public long ActorUserId => _MetaData.ActorUserId;

	public string ActorName { get; set; }

	public bool IsLegacyValue => _MetaData.IsLegacyValue;

	public DateTime? Audit_Updated => _AuditEntry?.Audit_Updated;

	public GenderType Audit_GenderType
	{
		get
		{
			if (!(_AuditEntry?.Audit_GenderTypeId).HasValue)
			{
				return GenderType.Unknown;
			}
			return (GenderType)_AuditEntry.Audit_GenderTypeId.Value;
		}
	}

	public DateTime? Audit_Birthdate => _AuditEntry?.Audit_BirthDate;

	public AgeBracket? Audit_AgeBracket
	{
		get
		{
			if ((_AuditEntry?.Audit_AgeBracket).HasValue)
			{
				return (AgeBracket)_AuditEntry.Audit_AgeBracket.Value;
			}
			return null;
		}
	}

	public bool? Audit_UseSuperSafeConversationMode => _AuditEntry?.Audit_UseSuperSafeConversationMode;

	public bool? Audit_UseSuperSafePrivacyMode => _AuditEntry?.Audit_UseSuperSafePrivacyMode;

	public DateTime? Audit_Created => _AuditEntry?.Audit_Created;

	public long? Audit_AccountId => _AuditEntry?.Audit_AccountId;

	internal UsersAuditCompositeEntry(IUsersAuditEntriesMetaDataEntity metaData, IUsersAuditEntryEntity auditEntry)
	{
		if (metaData == null)
		{
			throw new PlatformArgumentNullException();
		}
		_MetaData = metaData;
		_AuditEntry = auditEntry;
	}
}
