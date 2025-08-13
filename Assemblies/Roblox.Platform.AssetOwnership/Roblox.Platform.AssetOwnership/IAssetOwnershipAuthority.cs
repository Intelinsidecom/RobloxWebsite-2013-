using System;
using System.Collections.Generic;
using Roblox.DataV2.Core;
using Roblox.Ownership.Client;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.AssetOwnership;

public interface IAssetOwnershipAuthority
{
	IReadOnlyCollection<int> AllowedPageSizes { get; }

	int MaxAllowedPageSize { get; }

	int MinAllowedPageSize { get; }

	IReadOnlyCollection<IUserAsset> GetOwnedUserAssetsByAssetId(long userId, long assetId);

	int GetTotalNumberOfUserAssets(long userId, int assetTypeId, string keyword = "");

	IUserAsset GetUserAssetByUserAssetId(long userAssetId);

	IDictionary<long, IUserAsset> MultiGetUserAssetsByIds(ISet<long> userAssetIds);

	IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, int startRowIndex, int maximumRows);

	IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, int assetTypeId, string keyword, string sortExpression, int startRowIndex, int maximumRows);

	IReadOnlyCollection<IUserAsset> GetUserAssets(long userId, long assetId);

	IReadOnlyCollection<IUserAsset> GetUserAssetsByAssetId(long assetId, long exclusiveStartId, int count, SortOrder sortOrder = SortOrder.Asc);

	IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetId(long userId, long assetId);

	IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder = SortOrder.Asc);

	DateTime? GetCollectibleUpdatedDateByUserAssetId(long userAssetId);

	IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	IPlatformPageResponse<long, IUserAsset> GetCollectibleUserAssetsByUserId(long userId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	bool AgentOwnsAsset(long userId, long assetId);

	bool AgentOwnsUnexpiredAsset(long userId, long assetId);

	long AwardAsset(long assetId, long userId);

	long AwardAsset(long assetId, long userId, out bool awardedNewAsset);

	void AwardAssets(IReadOnlyCollection<long> assetIds, long userId);

	void AwardAssets(IReadOnlyCollection<long> assetIds, long userId, out bool awardedNewAsset);

	/// <summary>
	/// Just transfer.  This locks, does ov1 and ov2 transferWithExistingLock, then unlocks.
	/// </summary>
	bool Transfer(long userAssetId, long oldUserId, long newUserId, out string message);

	bool TransferWithExistingLock(long userAssetId, long oldOwnerId, long newOwnerId, Guid guid);

	ILockResult Lock(long userAssetId);

	bool Unlock(Guid guid);

	bool AgentOwnsUserAsset(long agentId, long assetId, long userAssetId);

	/// <summary>
	/// Aka Revoke.  The caller has responsibility to delete accoutrement if user was wearing it. (and clear thumbnail if so)
	/// </summary>
	IAssetOwnershipResult DeleteUserAsset(long userAssetId, long assetId, long userId);

	/// <summary>
	/// Attempts to award asset allowing a given userId to own multiple of the same assetId.
	/// Returns the UserAssetId of the newly created item.
	/// </summary>
	/// <returns>The UserAssetId of the awarded asset.</returns>
	long AwardAssetAllowingDuplicates(long assetId, long userId);

	IPlatformPageResponse<long, IUserAsset> GetUserAssetsByAssetIdPaged(long assetId, IExclusiveStartKeyInfo<long> exclusiveStartDetails);

	IPlatformPageResponse<long, IUserAsset> GetUserAssetsByUserIdAndAssetTypeIdPaged(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	IReadOnlyCollection<long> GetUserAssetIDsByUserIdAndAssetId(long userId, long assetId);
}
