using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

/// <summary>
/// Provides methods for creating and geting json corresponding to assetId.
/// </summary>
public interface IAssetSearchKeywordStatisticFactory : IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	/// <summary>
	/// Method for Inserting or updating AssetSearchKeywordStatistic object. 
	/// </summary>
	/// <param name="assetId"></param>
	/// <param name="json"></param>
	IAssetSearchKeywordStatistic CreateOrUpdate(long assetId, string json);

	/// <summary>
	/// Method for getting AssetSearchKeywordStatistic by assetId. 
	/// </summary>
	/// <param name="assetId"></param>
	IAssetSearchKeywordStatistic Get(long assetId);

	/// <summary>
	/// Method for getting paged collection of <seealso cref="T:Roblox.Platform.Studio.IAssetSearchKeywordStatistic" />
	/// </summary>
	/// <param name="exclusiveStartId"></param>
	/// <param name="count"></param>
	IEnumerable<IAssetSearchKeywordStatistic> GetAllPaged(long exclusiveStartId, int count);
}
