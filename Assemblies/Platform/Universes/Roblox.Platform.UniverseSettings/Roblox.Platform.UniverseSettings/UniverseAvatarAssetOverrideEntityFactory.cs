using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarAssetOverrideEntityFactory : IUniverseAvatarAssetOverrideEntityFactory, IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	public UniverseSettingsDomainFactories DomainFactories { get; }

	public UniverseAvatarAssetOverrideEntityFactory(UniverseSettingsDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IUniverseAvatarAssetOverrideEntity Get(long id)
	{
		return CalToCachedMssql(UniverseAvatarAssetOverrideEntity.Get(id));
	}

	public UniverseAvatarAssetOverrideEntity Create(long universeId, long assetId, int assetTypeId, bool isPlayerChoice)
	{
		return UniverseAvatarAssetOverrideEntity.Create(universeId, assetId, assetTypeId, isPlayerChoice);
	}

	public ICollection<UniverseAvatarAssetOverrideEntity> GetUniverseAvatarAssetOverridesPaged(long universeId, int count, long exclusiveStartUniverseInstanceId)
	{
		return (from o in UniverseAvatarAssetOverrideEntity.GetUniverseAvatarAssetOverridesByUniverseIDPaged(universeId, count, exclusiveStartUniverseInstanceId)
			select UniverseAvatarAssetOverrideEntity.Get(o.ID)).ToList();
	}

	private static IUniverseAvatarAssetOverrideEntity CalToCachedMssql(UniverseAvatarAssetOverrideEntity cal)
	{
		if (cal != null)
		{
			return new UniverseAvatarAssetOverrideCachedMssqlEntity
			{
				Id = cal.ID,
				UniverseId = cal.UniverseID,
				AssetId = cal.AssetID,
				AssetTypeId = cal.AssetTypeID,
				IsPlayerChoice = cal.IsPlayerChoice,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
