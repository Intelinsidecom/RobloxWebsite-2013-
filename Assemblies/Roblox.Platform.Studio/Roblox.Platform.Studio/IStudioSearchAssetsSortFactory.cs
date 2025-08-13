using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Math.Statistics;

namespace Roblox.Platform.Studio;

/// <summary>
/// Provide a common interface for sorting business logic for assets.
/// </summary>
public interface IStudioSearchAssetsSortFactory : IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	/// <summary>
	/// This method merges the list of assets from elsticsearh default sort and sort by 
	/// wilso socre and apply beta destribution on merged list.
	/// </summary>
	/// <param name="assetsFromDefaultSearch"></param>
	/// <param name="assetsFromWilsonScoreSearch"></param>
	/// <param name="betaDistribution"></param>
	/// <param name="assetSearchKeywordStatisticFactory"></param>
	/// <param name="keyword"></param>
	ICollection<IAsset> GetSortedAssets(ICollection<IAsset> assetsFromDefaultSearch, ICollection<IAsset> assetsFromWilsonScoreSearch, BetaDistribution betaDistribution, IAssetSearchKeywordStatisticFactory assetSearchKeywordStatisticFactory, string keyword);

	/// <summary>
	/// This method merges the list of assets from elasticsearch default sort and sort by 
	/// wilson score to generate merged list.
	/// </summary>
	/// <param name="assetsFromDefaultSearch"></param>
	/// <param name="assetsFromWilsonScoreSearch"></param>
	/// <param name="wilsonScoreQueryCount"></param>
	/// <param name="defaultQueryCount"></param>
	/// <param name="assetSearchKeywordStatisticFactory"></param>
	/// <param name="keyword"></param>
	ICollection<IAsset> GetSortedAssets(ICollection<IAsset> assetsFromDefaultSearch, ICollection<IAsset> assetsFromWilsonScoreSearch, int wilsonScoreQueryCount, int defaultQueryCount, IAssetSearchKeywordStatisticFactory assetSearchKeywordStatisticFactory, string keyword, int maxResults);
}
