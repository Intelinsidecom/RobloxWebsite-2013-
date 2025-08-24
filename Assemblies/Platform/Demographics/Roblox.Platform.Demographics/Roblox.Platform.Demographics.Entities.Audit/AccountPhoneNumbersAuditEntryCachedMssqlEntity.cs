using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Demographics.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumbersAuditEntryCachedMssqlEntity : IAccountPhoneNumbersAuditEntryEntity, IUpdateableEntity<long>, IEntity<long>, IAuditEntry
{
	public long Id { get; set; }

	public Guid PublicId { get; set; }

	public long Audit_Id { get; set; }

	public long Audit_AccountId { get; set; }

	public long? Audit_PhoneNumberId { get; set; }

	public bool? Audit_IsVerified { get; set; }

	public string Audit_Phone { get; set; }

	public DateTime Audit_Created { get; set; }

	public DateTime Audit_Updated { get; set; }

	public DateTime Created { get; set; }

	/// <summary>
	/// Set to now as we don't really track updated value in this table.
	/// </summary>
	public DateTime Updated => DateTime.Now;

	public void Delete()
	{
		(AccountPhoneNumbersAuditEntry.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}

	public void Update()
	{
		AccountPhoneNumbersAuditEntry obj = AccountPhoneNumbersAuditEntry.Get(Id) ?? throw new InvalidOperationException("Attempted update on unpersisted entity.");
		obj.Audit_AccountID = Audit_AccountId;
		obj.Audit_Created = Audit_Created;
		obj.Audit_ID = Audit_Id;
		obj.Audit_IsVerified = Audit_IsVerified;
		obj.Audit_Phone = Audit_Phone;
		obj.Audit_PhoneNumberID = Audit_PhoneNumberId;
		obj.Audit_Updated = Audit_Updated;
		obj.Save();
	}
}
