using System.Collections.Generic;
using Roblox.Paging;
using Roblox.Platform.AssetOwnership;

namespace Roblox.Platform.Games;

internal class UserPurchasedPlacesPagedResult : IUserPurchasedPlacesPagedResult, IKeyedPagedResult<IUserAsset, int>
{
	public IReadOnlyCollection<IUserAsset> PageItems { get; }

	public PageKeyInfo<int> NextPageKey { get; }

	public long TotalCount { get; }

	internal UserPurchasedPlacesPagedResult(IReadOnlyCollection<IUserAsset> pageItems, PageKeyInfo<int> nextPageKey, long totalCount)
	{
		PageItems = pageItems;
		NextPageKey = nextPageKey;
		TotalCount = totalCount;
	}
}
