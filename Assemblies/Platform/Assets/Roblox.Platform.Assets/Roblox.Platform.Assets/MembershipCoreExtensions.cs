using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public static class MembershipCoreExtensions
{
	private static LegacyUserAssetExpirationAuthority _LegacyUserAssetExpirationAuthority { get; } = new LegacyUserAssetExpirationAuthority();


	public static IEnumerable<IAssetVersion> GetVersions(this IUserIdentifier user, IAsset asset, long offset, long count)
	{
		user.VerifyIsNotNull();
		user.VerifyIsCreator(asset);
		return asset.GetVersions(offset, count);
	}

	public static bool IsCreator(this IUserIdentifier user, IAsset asset)
	{
		user.VerifyIsNotNull();
		asset.VerifyIsNotNull();
		if (asset.CreatorType != CreatorType.User)
		{
			return false;
		}
		return user.Id == asset.CreatorTargetId;
	}

	public static void VerifyIsCreator(this IUserIdentifier user, IAsset asset)
	{
		if (!user.IsCreator(asset))
		{
			throw new InvalidCreatorException(asset, user);
		}
	}

	public static bool IsItemCurrentlyRented(this IUserIdentifier user, IAsset asset, Lazy<IUserAssetExpiration> userAssetExpiration, IAssetOwnershipAuthority assetOwnershipAuthority)
	{
		if (user == null || asset == null)
		{
			return false;
		}
		if (assetOwnershipAuthority == null)
		{
			throw new ArgumentNullException("assetOwnershipAuthority");
		}
		Roblox.AssetOption assetOption = Roblox.AssetOption.GetOrCreate(asset.Id);
		if (assetOption != null && !assetOption.IsExpireable)
		{
			return false;
		}
		if (assetOwnershipAuthority.GetUserAssets(user.Id, asset.Id).FirstOrDefault() != null && userAssetExpiration.Value != null && userAssetExpiration.Value.Expiration.HasValue && _LegacyUserAssetExpirationAuthority.GetUserAssetExpireTimeSpan(userAssetExpiration).HasValue && !_LegacyUserAssetExpirationAuthority.UserAssetIsExpired(userAssetExpiration))
		{
			return true;
		}
		return false;
	}
}
