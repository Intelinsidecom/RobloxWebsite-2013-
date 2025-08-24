using System;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Assets;

/// <summary>
/// Audit information on the Assets data entity, comprising of the raw data (prefixed with "Audit_") and additional meta data.
/// </summary>
public interface IAssetsAuditCompositeEntry : IAuditCompositeEntry
{
	/// <summary>
	/// [Metadata] The cause triggering the audit event
	/// </summary>
	AssetChangeType AssetChangeValue { get; }

	/// <summary>
	/// The value of Id of the record being audited
	/// </summary>
	long? Audit_Id { get; }

	/// <summary>
	/// The value of AssetType of the record being audited
	/// </summary>
	AssetType? Audit_AssetType { get; }

	/// <summary>
	/// The value of Hash of the record being audited
	/// </summary>
	string Audit_Hash { get; }

	/// <summary>
	/// The value of Name of the record being audited
	/// </summary>
	string Audit_Name { get; }

	/// <summary>
	/// The value of Description of the record being audited
	/// </summary>
	string Audit_Description { get; }

	/// <summary>
	/// The value of Created of the record being audited
	/// </summary>
	DateTime? Audit_Created { get; }

	/// <summary>
	/// The value of Updated of the record being audited
	/// </summary>
	DateTime? Audit_Updated { get; }

	/// <summary>
	/// The value of CreatorID of the record being audited
	/// </summary>
	long? Audit_CreatorId { get; }

	/// <summary>
	/// The value of CurrentVersionId of the record being audited
	/// </summary>
	long? Audit_CurrentVersionId { get; }

	/// <summary>
	/// The value of AssetHashId of the record being audited
	/// </summary>
	long? Audit_AssetHashId { get; }

	/// <summary>
	/// The value of AssetGenres of the record being audited
	/// </summary>
	long? Audit_AssetGenres { get; }

	/// <summary>
	/// The value of AssetCategories of the record being audited
	/// </summary>
	long? Audit_AssetCategories { get; }

	/// <summary>
	/// [Metadata] The id of the user triggering the audit event, such as an ordinary user or a CS agent.
	/// </summary>
	long? ActorUserId { get; }

	/// <summary>
	/// [Metadata] Indicating if the record represents data originally produced when auditing was not available, and is later being backfilled to provide comparison with other audit records.
	/// </summary>
	bool IsLegacyValue { get; }
}
