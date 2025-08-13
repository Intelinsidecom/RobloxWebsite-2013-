using System;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Audit information on the TwoStepVerificationSettings data entity, comprising of the raw data (prefixed with "Audit_") and additional meta data.
/// </summary>
public interface ITwoStepVerificationSettingsAuditCompositeEntry : IAuditCompositeEntry
{
	/// <summary>
	/// [Metadata] The id of the user this record is associated with
	/// </summary>
	long UserId { get; }

	/// <summary>
	/// [Metadata] The cause triggering the audit event
	/// </summary>
	TwoStepVerificationChangeType Type { get; }

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
	/// The value of IsEnabled of the record being audited
	/// </summary>
	bool? Audit_IsEnabled { get; }

	/// <summary>
	/// The value of UserID of the record being audited
	/// </summary>
	long? Audit_UserID { get; }

	/// <summary>
	/// The value of Created of the record being audited
	/// </summary>
	DateTime? Audit_Created { get; }

	/// <summary>
	/// The value of Updated of the record being audited
	/// </summary>
	DateTime? Audit_Updated { get; }

	/// <summary>
	/// The value of TwoStepVerificationMediaType of the record being audited.
	/// </summary>
	TwoStepVerificationMediaType? Audit_TwoStepVerificationMediaType { get; }
}
