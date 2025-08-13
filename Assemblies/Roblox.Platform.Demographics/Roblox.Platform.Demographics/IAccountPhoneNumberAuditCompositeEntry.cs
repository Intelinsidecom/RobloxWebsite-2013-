using System;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Audit information on the AccountPhoneNumbers data entity, comprising of the raw data (prefixed with "Audit_") and additional meta data.
/// </summary>
public interface IAccountPhoneNumberAuditCompositeEntry : IAuditCompositeEntry
{
	/// <summary>
	/// [Metadata] The id of the user this record is associated with
	/// </summary>
	long UserId { get; }

	/// <summary>
	/// [Metadata] The cause triggering the audit event
	/// </summary>
	AccountPhoneNumberChangeTypes Type { get; }

	/// <summary>
	/// [Metadata] The id of the user triggering the audit event, such as an ordinary user or a CS agent.
	/// </summary>
	long? ActorUserId { get; }

	/// <summary>
	/// [Metadata] Indicating if the record represents data originally produced when auditing was not available, and is later being backfilled to provide comparison with other audit records.
	/// </summary>
	bool IsLegacyValue { get; }

	/// <summary>
	/// The value of Id of the record being audited
	/// </summary>
	long? Audit_Id { get; }

	/// <summary>
	/// The value of AccountId of the record being audited
	/// </summary>
	long? Audit_AccountId { get; }

	/// <summary>
	/// The value of PhoneNumberId of the record being audited
	/// </summary>
	long? Audit_PhoneNumberId { get; }

	/// <summary>
	/// The value of IsVerified of the record being audited
	/// </summary>
	bool? Audit_IsVerified { get; }

	/// <summary>
	/// The value of Phone of the record being audited
	/// </summary>
	string Audit_Phone { get; }

	/// <summary>
	/// The value of Created of the record being audited
	/// </summary>
	DateTime? Audit_Created { get; }

	/// <summary>
	/// The value of Updated of the record being audited
	/// </summary>
	DateTime? Audit_Updated { get; }

	/// <summary>
	/// The id of the <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" />associated with the record
	/// </summary>
	int? PhoneNumberId { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> associated with the record
	/// </summary>
	IPhoneNumber PhoneNumber { get; set; }
}
