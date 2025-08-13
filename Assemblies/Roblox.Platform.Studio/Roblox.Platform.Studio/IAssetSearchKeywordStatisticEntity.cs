using Roblox.Entities;

namespace Roblox.Platform.Studio;

internal interface IAssetSearchKeywordStatisticEntity : IUpdateableEntity<long>, IEntity<long>
{
	long AssetId { get; set; }

	string Value { get; set; }
}
