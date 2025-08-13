using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.Paging;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Games.Properties;

namespace Roblox.Platform.Games;

public class PurchasedPlacesFactory : IPurchasedPlacesFactory
{
	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;

	private int _BatchSize => _AssetOwnershipAuthority.MaxAllowedPageSize;

	public PurchasedPlacesFactory(IAssetOwnershipAuthority assetOwnershipAuthority)
	{
		_AssetOwnershipAuthority = assetOwnershipAuthority;
	}

	public IUserPurchasedPlacesPagedResult GetUserPurchasedPlacesPaged(long userId, int startIndex, int itemsPerPage)
	{
		int total = _AssetOwnershipAuthority.GetTotalNumberOfUserAssets(userId, AssetType.PlaceID);
		if (Settings.Default.RestrictFilteredPurchasedGames && total >= Settings.Default.MaxFilteredPurchasedGames)
		{
			if (total > startIndex)
			{
				return new UserPurchasedPlacesPagedResult(nextPageKey: new PageKeyInfo<int>(startIndex + itemsPerPage), pageItems: _AssetOwnershipAuthority.GetUserAssets(userId, AssetType.PlaceID, string.Empty, string.Empty, startIndex, itemsPerPage).ToList(), totalCount: total);
			}
			return new UserPurchasedPlacesPagedResult((IReadOnlyCollection<IUserAsset>)(object)new IUserAsset[0], PageKeyInfo<int>.NoPage(), total);
		}
		List<IUserAsset> userAssets = new List<IUserAsset>();
		ExclusiveStartKeyInfo<long> exclusiveStartKeyInfo = new ExclusiveStartKeyInfo<long>(0L, SortOrder.Asc, PagingDirection.Forward, _BatchSize);
		do
		{
			IPlatformPageResponse<long, IUserAsset> userAssetsPlatformResponse = _AssetOwnershipAuthority.GetUserAssetsByUserIdAndAssetTypeIdPaged(userId, Roblox.Platform.Assets.AssetType.Place.ToId(), exclusiveStartKeyInfo);
			userAssets.AddRange(userAssetsPlatformResponse.Items);
			exclusiveStartKeyInfo = (userAssetsPlatformResponse.TryGetNextPageExclusiveStartKey(out var exclusiveStartId) ? new ExclusiveStartKeyInfo<long>(exclusiveStartId, SortOrder.Asc, PagingDirection.Forward, _BatchSize) : null);
		}
		while (exclusiveStartKeyInfo != null);
		int startRowIndex = 0;
		HashSet<long> assetIds = new HashSet<long>(from a in Asset.GetAssetsByTypeAndUserIDPaged(AssetType.PlaceID, userId, CreatorType.User, startRowIndex, _BatchSize)
			select a.ID);
		bool moreResultsAreExpected = assetIds.Count >= _BatchSize;
		while (moreResultsAreExpected)
		{
			startRowIndex += _BatchSize;
			HashSet<long> newAssetIds = new HashSet<long>(from a in Asset.GetAssetsByTypeAndUserIDPaged(AssetType.PlaceID, userId, CreatorType.User, startRowIndex, _BatchSize)
				select a.ID);
			assetIds.UnionWith(newAssetIds);
			moreResultsAreExpected = newAssetIds.Count >= _BatchSize;
		}
		return GetPageBySkipTake(userAssets.Where((IUserAsset ua) => !assetIds.Contains(ua.AssetId)).ToList(), startRowIndex, itemsPerPage);
	}

	/// <summary>
	/// Produces a Keyed Page Result from a collection of items by skipping and taking.
	/// </summary>
	internal static UserPurchasedPlacesPagedResult GetPageBySkipTake(IReadOnlyCollection<IUserAsset> items, int skip, int take)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		int totalCount = items.Count;
		IUserAsset[] pageItems = items.Skip(skip).Take(take).ToArray();
		PageKeyInfo<int> nextStartKey = ((totalCount < skip + take) ? PageKeyInfo<int>.NoPage() : new PageKeyInfo<int>(skip + take));
		return new UserPurchasedPlacesPagedResult((IReadOnlyCollection<IUserAsset>)(object)pageItems, nextStartKey, totalCount);
	}
}
