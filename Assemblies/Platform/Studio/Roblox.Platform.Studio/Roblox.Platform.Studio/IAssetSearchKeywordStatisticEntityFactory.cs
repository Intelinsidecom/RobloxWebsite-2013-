using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

internal interface IAssetSearchKeywordStatisticEntityFactory : IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Studio.IAssetSearchKeywordStatisticEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Studio.IAssetSearchKeywordStatisticEntity" /> with the given ID, or null if none existed.</returns>
	IAssetSearchKeywordStatisticEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Studio.IAssetSearchKeywordStatisticEntity" /> with the given assetId.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Studio.IAssetSearchKeywordStatisticEntity" /> with the given assetId, or null if none existed.</returns>
	IAssetSearchKeywordStatisticEntity GetByAssetId(long assetId);

	/// <summary>
	/// Saves
	/// </summary>
	/// <param name="assetId"></param>
	/// <param name="json"></param>
	IAssetSearchKeywordStatisticEntity Create(long assetId, string json);

	/// <summary>
	/// Gets paged collection of <see cref="T:Roblox.Platform.Studio.IAssetSearchKeywordStatisticEntity" />.
	/// </summary>
	/// <param name="exclusiveStartId"></param>
	/// <param name="count"></param>
	IEnumerable<IAssetSearchKeywordStatisticEntity> GetAssetSearchKeywordStatistics(long exclusiveStartId, int count);
}
