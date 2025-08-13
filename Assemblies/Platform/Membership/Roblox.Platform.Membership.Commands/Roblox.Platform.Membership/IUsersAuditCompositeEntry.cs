using System;

namespace Roblox.Platform.Membership;

/// <summary>
/// Audit information on the User data entity, comprising of the raw data (prefixed with "Audit_") and additional meta data.
/// </summary>
public interface IUsersAuditCompositeEntry
{
	/// <summary>
	/// Primary identifier of the entry
	/// </summary>
	long Id { get; }

	/// <summary>
	/// [Metadata] The id of the user this record is associated with
	/// </summary>
	long UserId { get; }

	/// <summary>
	/// [Metadata] The cause triggering the audit event, such has change of birthhdate.
	/// </summary>
	UsersAuditEntryMetaDataType Type { get; }

	/// <summary>
	/// [Metadata] The id of the user triggering the audit event, such as an ordinary user or a CS agent.
	/// </summary>
	long ActorUserId { get; }

	/// <summary>
	/// [Metadata] The name of the user triggering the audit event.
	/// </summary>
	string ActorName { get; set; }

	/// <summary>
	/// [Metadata] Indicating if the record represents data originally produced when auditing was not available, and is later being backfilled to provide comparison with other audit records.
	/// </summary>
	bool IsLegacyValue { get; }

	/// <summary>
	/// Value of "Updated" field of the User record at the audit event.  <seealso cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	DateTime? Audit_Updated { get; }

	/// <summary>
	/// Value of "GenderType" field of the User record at the audit event.  <seealso cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	GenderType Audit_GenderType { get; }

	/// <summary>
	/// Value of "GenderType" field of the User record at the audit event.  <seealso cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	DateTime? Audit_Birthdate { get; }

	/// <summary>
	/// Value of "AgeBracket" field of the User record at the audit event.  <seealso cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	AgeBracket? Audit_AgeBracket { get; }

	/// <summary>
	/// Value of "UseSuperSafeConversationMode" field of the User record at the audit event.  <seealso cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	bool? Audit_UseSuperSafeConversationMode { get; }

	/// <summary>
	/// Value of "UseSuperSafePrivacyMode" field of the User record at the audit event.  <seealso cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	bool? Audit_UseSuperSafePrivacyMode { get; }

	/// <summary>
	/// Value of "Created" field of the User record at the audit event.  <seealso cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	DateTime? Audit_Created { get; }

	/// <summary>
	/// Value of "AccountId" field of the User record at the audit event.  <seealso cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	long? Audit_AccountId { get; }
}
