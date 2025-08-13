using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarAssetOverrideCachedMssqlEntity : IUniverseAvatarAssetOverrideEntity, IEntity<long>
{
	public long Id { get; set; }

	public long UniverseId { get; set; }

	public long AssetId { get; set; }

	public int AssetTypeId { get; set; }

	public bool IsPlayerChoice { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Delete()
	{
		(UniverseAvatarAssetOverrideEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
