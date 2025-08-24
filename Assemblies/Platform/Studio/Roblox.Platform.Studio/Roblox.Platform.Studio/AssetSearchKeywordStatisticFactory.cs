using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

internal class AssetSearchKeywordStatisticFactory : IAssetSearchKeywordStatisticFactory, IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	public StudioDomainFactories DomainFactories { get; }

	public AssetSearchKeywordStatisticFactory(StudioDomainFactories studioDomainFactories)
	{
		if (studioDomainFactories == null)
		{
			throw new PlatformArgumentNullException("studioDomainFactories");
		}
		DomainFactories = studioDomainFactories;
	}

	public IAssetSearchKeywordStatistic CreateOrUpdate(long assetId, string json)
	{
		if (assetId <= 0)
		{
			throw new PlatformArgumentException("'assetId' cannot be negative or zero.");
		}
		IAssetSearchKeywordStatisticEntity obj = DomainFactories.AssetSearchKeywordStatisticEntityFactory.GetByAssetId(assetId);
		if (obj == null)
		{
			obj = DomainFactories.AssetSearchKeywordStatisticEntityFactory.Create(assetId, json);
			if (obj == null)
			{
				return null;
			}
		}
		else
		{
			obj.Value = json;
			obj.Update();
		}
		return new AssetSearchKeywordStatistic(obj.AssetId, obj.Id, obj.Value);
	}

	public IEnumerable<IAssetSearchKeywordStatistic> GetAllPaged(long exclusiveStartId, int count)
	{
		if (exclusiveStartId < 0)
		{
			throw new PlatformArgumentException("'exclusiveStartId' cannot be negative or zero.");
		}
		if (count < 0)
		{
			throw new PlatformArgumentException("'count' cannot be negative");
		}
		return from o in DomainFactories.AssetSearchKeywordStatisticEntityFactory.GetAssetSearchKeywordStatistics(exclusiveStartId, count)
			select new AssetSearchKeywordStatistic(o.AssetId, o.Id, o.Value);
	}

	public IAssetSearchKeywordStatistic Get(long assetId)
	{
		if (assetId == 0L)
		{
			throw new PlatformArgumentException("assetId");
		}
		IAssetSearchKeywordStatisticEntity obj = DomainFactories.AssetSearchKeywordStatisticEntityFactory.GetByAssetId(assetId);
		if (obj == null)
		{
			return null;
		}
		return new AssetSearchKeywordStatistic(obj.AssetId, obj.Id, obj.Value);
	}
}
