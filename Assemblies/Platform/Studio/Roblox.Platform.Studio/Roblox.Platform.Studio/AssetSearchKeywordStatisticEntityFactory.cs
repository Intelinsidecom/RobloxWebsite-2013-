using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Studio.Entities;

namespace Roblox.Platform.Studio;

internal class AssetSearchKeywordStatisticEntityFactory : IAssetSearchKeywordStatisticEntityFactory, IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	public StudioDomainFactories DomainFactories { get; }

	public AssetSearchKeywordStatisticEntityFactory(StudioDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAssetSearchKeywordStatisticEntity Get(long id)
	{
		return CalToCachedMssql(Roblox.Platform.Studio.Entities.AssetSearchKeywordStatistic.Get(id));
	}

	public IAssetSearchKeywordStatisticEntity GetByAssetId(long assetId)
	{
		return CalToCachedMssql(Roblox.Platform.Studio.Entities.AssetSearchKeywordStatistic.GetByAssetID(assetId));
	}

	public IAssetSearchKeywordStatisticEntity Create(long assetId, string json)
	{
		Roblox.Platform.Studio.Entities.AssetSearchKeywordStatistic assetSearchKeywordStatistic = new Roblox.Platform.Studio.Entities.AssetSearchKeywordStatistic();
		assetSearchKeywordStatistic.AssetID = assetId;
		assetSearchKeywordStatistic.Value = json;
		assetSearchKeywordStatistic.Save();
		return CalToCachedMssql(assetSearchKeywordStatistic);
	}

	public IEnumerable<IAssetSearchKeywordStatisticEntity> GetAssetSearchKeywordStatistics(long exclusiveStartId, int count)
	{
		if (exclusiveStartId < 0)
		{
			throw new PlatformArgumentException("'exclusiveStartId' cannot be negative");
		}
		if (count < 0)
		{
			throw new PlatformArgumentException("'count' cannot be negative");
		}
		return Roblox.Platform.Studio.Entities.AssetSearchKeywordStatistic.GetAssetSearchKeywordStatistics(exclusiveStartId, count).Select(CalToCachedMssql);
	}

	private static IAssetSearchKeywordStatisticEntity CalToCachedMssql(Roblox.Platform.Studio.Entities.AssetSearchKeywordStatistic cal)
	{
		if (cal != null)
		{
			return new AssetSearchKeywordStatisticCachedMssqlEntity
			{
				Id = cal.ID,
				AssetId = cal.AssetID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
