using Roblox.Paging;
using Roblox.Platform.AssetOwnership;

namespace Roblox.Platform.Games;

public interface IUserPurchasedPlacesPagedResult : IKeyedPagedResult<IUserAsset, int>
{
	long TotalCount { get; }
}
