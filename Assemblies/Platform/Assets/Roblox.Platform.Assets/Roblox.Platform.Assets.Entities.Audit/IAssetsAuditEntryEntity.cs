using System;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Assets.Entities.Audit;

internal interface IAssetsAuditEntryEntity : IAuditEntry, IEntity<long>
{
	new Guid PublicId { get; }

	long Audit_Id { get; }

	int Audit_AssetTypeId { get; }

	string Audit_Hash { get; }

	string Audit_Name { get; }

	string Audit_Description { get; }

	DateTime Audit_Created { get; }

	DateTime Audit_Updated { get; }

	long Audit_CreatorId { get; }

	long Audit_CurrentVersionId { get; }

	long? Audit_AssetHashId { get; }

	long Audit_AssetGenres { get; }

	long Audit_AssetCategories { get; }

	bool? Audit_IsArchived { get; }
}
