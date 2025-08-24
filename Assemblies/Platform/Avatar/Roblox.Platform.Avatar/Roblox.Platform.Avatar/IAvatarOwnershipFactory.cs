using System.Collections.Generic;
using Roblox.DataV2.Core;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.Avatar;

public interface IAvatarOwnershipFactory
{
	int MaxAllowedPageSize { get; }

	IReadOnlyCollection<int> AllowedPageSizes { get; }

	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown when userAsset is null</exception>
	bool IsExpired(IUserAsset userAsset);

	bool UserOwnsAsset(long userId, long assetId);

	bool UserOwnsUnexpiredAsset(long userId, long assetId);

	IUserAsset GetUserAssetByUserAssetId(long userAssetId);

	/// <summary>
	/// Returns a dictionary of userAssetId -&gt; UserAsset object. All keys in the dictionary will have values. The implementation guarantees that no keys will exist in the dictionary with null values.
	/// </summary>
	IDictionary<long, IUserAsset> GetUserAssetsByUserAssetIds(ISet<long> userAssetIds);

	IReadOnlyCollection<IUserAsset> GetOwnedUserAssetsByAssetId(long userId, long assetId);

	IPlatformPageResponse<long, IUserAsset> GetOwnedUserAssetsByAssetTypeIdPaged(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartDetails);

	IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder);
}
