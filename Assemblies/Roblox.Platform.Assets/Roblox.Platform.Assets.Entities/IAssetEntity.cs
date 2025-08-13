using System;
using Roblox.DataAccess;
using Roblox.Entities;
using Roblox.Platform.Assets.Entities.Audit;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Entities;

internal interface IAssetEntity : IEntity<long>
{
	int TypeId { get; }

	string Name { get; set; }

	string Description { get; set; }

	DateTime Updated { get; }

	ulong AssetGenres { get; set; }

	ulong AssetCategories { get; set; }

	bool? IsArchived { get; set; }

	/// <summary>
	/// The AgentId of the creator
	/// </summary>
	long CreatorId { get; set; }

	/// <summary>
	/// This is a hack to audit the records of the Assets table directly, because Roblox.Asset does not have the exact same data type/values as the underlying database table.
	/// </summary>
	AssetDAL _EntityDAL { get; }

	/// <exception cref="T:System.InvalidOperationException">If the data entity is not found.</exception>
	DataUpdateResult<IAssetEntity, IAssetsAuditEntryEntity> Update(bool isDelayedRelease = false);
}
