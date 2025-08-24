using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetsAuditMetadataEntity : IAssetsAuditMetadataEntity, IAuditMetadata, IEntity<long>
{
	public Guid ForeignPublicId => AssetsAuditEntryPublicId;

	public long Id { get; set; }

	public Guid AssetsAuditEntryPublicId { get; set; }

	public long AssetId { get; set; }

	public long? ActorUserId { get; set; }

	public byte AssetChangeTypeId { get; set; }

	public bool IsLegacyValue { get; set; }

	public DateTime Created { get; set; }

	public long? GetActorUserId()
	{
		if (!ActorUserId.HasValue)
		{
			return null;
		}
		try
		{
			return ActorUserId;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public void Delete()
	{
		(AssetsAuditMetadataCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
