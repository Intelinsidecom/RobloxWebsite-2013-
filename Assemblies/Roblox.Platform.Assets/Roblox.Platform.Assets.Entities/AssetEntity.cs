using System;
using Roblox.DataAccess;
using Roblox.Entities;
using Roblox.Platform.Assets.Entities.Audit;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Entities;

internal class AssetEntity : IAssetEntity, IEntity<long>
{
	public long Id { get; set; }

	public int TypeId { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public long AssetHashId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public ulong AssetGenres { get; set; }

	public ulong AssetCategories { get; set; }

	public long CreatorId { get; set; }

	public bool? IsArchived { get; set; }

	public AssetDAL _EntityDAL { get; set; }

	internal AssetDomainFactories DomainFactories { get; set; }

	internal virtual bool IsAuditingEnabled => Settings.Default.IsAssetsTableAuditingEnabled;

	public DataUpdateResult<IAssetEntity, IAssetsAuditEntryEntity> Update(bool isDelayedRelease = false)
	{
		Roblox.Asset cal = Roblox.Asset.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Name = Name;
		cal.Description = Description;
		cal.AssetGenres = AssetGenres;
		cal.AssetCategories = AssetCategories;
		cal.CreatorID = CreatorId;
		cal.IsArchived = IsArchived;
		if (isDelayedRelease)
		{
			cal.DelayedReleaseAssetSave();
		}
		else
		{
			cal.Save();
		}
		Updated = cal.Updated;
		IAssetsAuditEntryEntity auditEntryEntity = null;
		if (IsAuditingEnabled)
		{
			auditEntryEntity = DomainFactories.AssetsAuditEntriesEntityFactory.Create(_EntityDAL);
		}
		return new DataUpdateResult<IAssetEntity, IAssetsAuditEntryEntity>(this, auditEntryEntity);
	}

	public void Delete()
	{
		(Roblox.Asset.Get(Id) ?? throw new InvalidOperationException("Attempted update on unpersisted entity.")).Delete();
	}
}
