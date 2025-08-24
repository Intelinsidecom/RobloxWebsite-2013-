using System;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Entities.Audit;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Demographics;

internal class AccountPhoneNumberAuditCompositeEntry : IAccountPhoneNumberAuditCompositeEntry, IAuditCompositeEntry
{
	private readonly IAccountPhoneNumbersAuditMetadataEntity _MetaData;

	private readonly IAccountPhoneNumbersAuditEntryEntity _AuditEntry;

	public long Id => _MetaData.Id;

	public long UserId => _MetaData.UserId;

	public AccountPhoneNumberChangeTypes Type => (AccountPhoneNumberChangeTypes)_MetaData.AccountPhoneNumbersChangeTypeId;

	public long? ActorUserId => _MetaData.ActorUserId;

	public string ActorName { get; set; }

	public bool IsLegacyValue => _MetaData.IsLegacyValue;

	public long? Audit_Id => _AuditEntry?.Audit_Id;

	public long? Audit_AccountId => _AuditEntry?.Audit_AccountId;

	public long? Audit_PhoneNumberId => _AuditEntry?.Audit_PhoneNumberId;

	public bool? Audit_IsVerified => _AuditEntry?.Audit_IsVerified;

	public string Audit_Phone => _AuditEntry?.Audit_Phone;

	public DateTime? Audit_Created => _AuditEntry?.Created;

	public DateTime? Audit_Updated => _AuditEntry?.Audit_Updated;

	public int? PhoneNumberId { get; }

	public IPhoneNumber PhoneNumber { get; set; }

	internal AccountPhoneNumberAuditCompositeEntry(IAccountPhoneNumbersAuditMetadataEntity metaData, IAccountPhoneNumbersAuditEntryEntity auditEntry)
	{
		if (metaData == null)
		{
			throw new PlatformArgumentNullException();
		}
		_MetaData = metaData;
		_AuditEntry = auditEntry;
		IAccountPhoneNumbersAuditEntryEntity auditEntry2 = _AuditEntry;
		if (auditEntry2 != null && auditEntry2.Audit_PhoneNumberId.HasValue)
		{
			PhoneNumberId = Convert.ToInt32(Audit_PhoneNumberId);
		}
	}
}
