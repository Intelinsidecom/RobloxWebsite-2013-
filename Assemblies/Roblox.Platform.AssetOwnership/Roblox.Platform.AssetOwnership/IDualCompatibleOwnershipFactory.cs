using System;
using System.Collections.Generic;
using Roblox.DataV2.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.AssetOwnership;

/// <summary>
/// This is for the two ownershipFactories.
/// </summary>
internal interface IDualCompatibleOwnershipFactory
{
	bool AgentOwnsAsset(long userId, long assetId);

	long AwardAsset(long assetId, long userId, out bool awardedNewAsset);

	long AwardAssetAllowingDuplicates(long assetId, long userId);

	long AwardAsset(long assetId, long userId);

	void AwardAssets(IReadOnlyCollection<long> assetIds, long userId);

	void AwardAssets(IReadOnlyCollection<long> assetIds, long userId, out bool awardedNewAsset);

	/// <summary>
	/// This provides guid so that ov1 can revoke it.
	/// This provides userId, assetId for ov2, which assumes its already locked.
	/// both sides need the guid to ensure it's still locked.
	/// </summary>
	IAssetOwnershipResult RevokeWithExistingLock(Guid guid, long userAssetId, long userId, long assetId);

	/// <summary>
	/// This provides guid so that ov1 can unlock it.
	/// This provides userId, assetId for ov2, which assumes its already locked.
	/// </summary>
	bool TransferWithExistingLock(long assetId, long userAssetId, long oldOwnerId, long newOwnerId, Guid token, out string message);

	IReadOnlyCollection<IUserAsset> GetOwnedUserAssetsByAssetId(long userId, long assetId);

	IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserId(long userId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	IUserAsset GetUserAssetByUserAssetId(long userAssetId);

	IDictionary<long, IUserAsset> MultiGetUserAssetsByIds(ISet<long> userAssetIds);

	IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetId(long userId, long assetId);

	IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder);

	IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, long assetId);

	IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, string keyword, string sortExpression, int startRowIndex, int maximumRows);

	IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, int startRowIndex, int maximumRows);

	IReadOnlyCollection<IUserAsset> GetUserAssetsByAssetId(long assetId, long exclusiveStartId, int count, SortOrder sortOrder);

	bool AgentOwnsUserAsset(long agentId, long assetId, long userAssetId);

	IReadOnlyCollection<long> GetUserAssetIDsByUserIdAndAssetId(long userId, long assetId);

	IPlatformPageResponse<long, IUserAsset> GetUserAssetsByUserIdAndAssetTypeIdPaged(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	IPlatformPageResponse<long, IUserAsset> GetUserAssetsByAssetIdPaged(long assetId, IExclusiveStartKeyInfo<long> exclusiveStartDetails);

	int GetTotalNumberOfUserAssets(long userId, int assetTypeId, string keyword = "");
}
