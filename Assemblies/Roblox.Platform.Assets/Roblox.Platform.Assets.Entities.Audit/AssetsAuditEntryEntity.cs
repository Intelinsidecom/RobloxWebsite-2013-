using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetsAuditEntryEntity : IAssetsAuditEntryEntity, IAuditEntry, IEntity<long>
{
	public long Id { get; set; }

	public Guid PublicId { get; set; }

	public long Audit_Id { get; set; }

	public int Audit_AssetTypeId { get; set; }

	public string Audit_Hash { get; set; }

	public string Audit_Name { get; set; }

	public string Audit_Description { get; set; }

	public DateTime Audit_Created { get; set; }

	public DateTime Audit_Updated { get; set; }

	public long Audit_CreatorId { get; set; }

	public long Audit_CurrentVersionId { get; set; }

	public long? Audit_AssetHashId { get; set; }

	public long Audit_AssetGenres { get; set; }

	public long Audit_AssetCategories { get; set; }

	public bool? Audit_IsArchived { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(AssetsAuditEntryCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
