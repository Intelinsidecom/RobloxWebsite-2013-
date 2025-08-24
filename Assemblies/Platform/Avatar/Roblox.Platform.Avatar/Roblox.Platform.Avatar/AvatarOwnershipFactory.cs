using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.Avatar;

/// <summary>
/// All avatar ownership calls should go through this class.
/// </summary>
public class AvatarOwnershipFactory : IAvatarOwnershipFactory
{
	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;

	private readonly LegacyUserAssetExpirationAuthority _LegacyUserAssetExpirationAuthority;

	public IReadOnlyCollection<int> AllowedPageSizes => _AssetOwnershipAuthority.AllowedPageSizes;

	public int MaxAllowedPageSize => _AssetOwnershipAuthority.MaxAllowedPageSize;

	public AvatarOwnershipFactory(IAssetOwnershipAuthority assetOwnershipAuthority)
	{
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new PlatformArgumentNullException("assetOwnershipAuthority");
		_LegacyUserAssetExpirationAuthority = new LegacyUserAssetExpirationAuthority();
	}

	/// <inheritdoc />
	public bool IsExpired(IUserAsset userAsset)
	{
		if (userAsset == null)
		{
			throw new PlatformArgumentNullException("userAsset");
		}
		if (!AssetOption.GetOrCreate(userAsset.AssetId).IsExpireable)
		{
			return false;
		}
		IUserAssetExpiration userAssetExpiration = _LegacyUserAssetExpirationAuthority.GetUserAssetExpirationByUserAssetId(userAsset.Id);
		if (userAssetExpiration == null || !userAssetExpiration.Expiration.HasValue)
		{
			return false;
		}
		return userAssetExpiration.Expiration.Value <= DateTime.Now;
	}

	public IUserAsset GetUserAssetByUserAssetId(long userAssetId)
	{
		return _AssetOwnershipAuthority.GetUserAssetByUserAssetId(userAssetId);
	}

	public IDictionary<long, IUserAsset> GetUserAssetsByUserAssetIds(ISet<long> userAssetIds)
	{
		if (userAssetIds == null || userAssetIds.Count == 0)
		{
			return new Dictionary<long, IUserAsset>();
		}
		return _AssetOwnershipAuthority.MultiGetUserAssetsByIds(userAssetIds);
	}

	public IReadOnlyCollection<IUserAsset> GetOwnedUserAssetsByAssetId(long userId, long assetId)
	{
		return _AssetOwnershipAuthority.GetOwnedUserAssetsByAssetId(userId, assetId);
	}

	public bool UserOwnsAsset(long userId, long assetId)
	{
		return _AssetOwnershipAuthority.AgentOwnsAsset(userId, assetId);
	}

	public bool UserOwnsUnexpiredAsset(long userId, long assetId)
	{
		return _AssetOwnershipAuthority.AgentOwnsUnexpiredAsset(userId, assetId);
	}

	public IReadOnlyCollection<IUserAsset> GetUserAssetsByUserIdAndAssetTypeId(long userId, int assetTypeId, long exclusiveStartId, int count, SortOrder sortOrder)
	{
		return _AssetOwnershipAuthority.GetUserAssetsByUserIdAndAssetTypeId(userId, assetTypeId, exclusiveStartId, count, sortOrder);
	}

	public IPlatformPageResponse<long, IUserAsset> GetOwnedUserAssetsByAssetTypeIdPaged(long userId, int assetTypeId, IExclusiveStartKeyInfo<long> exclusiveStartDetails)
	{
		return _AssetOwnershipAuthority.GetUserAssetsByUserIdAndAssetTypeIdPaged(userId, assetTypeId, exclusiveStartDetails);
	}

	public ICollection<IUserAsset> GetUserAssetsByUserIdAndAssetId(long userId, long assetId)
	{
		return _AssetOwnershipAuthority.GetUserAssetsByUserIdAndAssetId(userId, assetId).ToList();
	}
}
