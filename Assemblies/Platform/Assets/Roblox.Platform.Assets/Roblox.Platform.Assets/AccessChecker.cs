using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets.Properties;
using Roblox.Users.Properties;

namespace Roblox.Platform.Assets;

/// <summary>
/// For checking if an asset can be loaded by a user.
/// </summary>
public class AccessChecker : IAccessChecker
{
	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;

	public AccessChecker(IAssetOwnershipAuthority assetOwnershipAuthority)
	{
		_AssetOwnershipAuthority = assetOwnershipAuthority;
	}

	/// <summary>
	/// Most asset types allow unlimited access but some are restricted.
	/// </summary>
	/// <remarks>
	/// Any content that a user can bring with her into game (via avatar)
	/// must be available without an ownership check.  The reason is: all other users in the
	/// game must be able to request it so they can render the avatar correctly.
	/// Therefore, only check the ownership on content that cannot migrate with a user (Places,
	/// Models).  Grid servers can skip the ownership check through presentation of a "secret"
	/// key.  
	/// Note 2018: the above is 7+ years old.
	/// </remarks>
	public bool HasAccess(IAsset asset, User user)
	{
		bool num = asset.TypeId == 5;
		bool isModel = asset.TypeId == 10;
		bool isPlace = asset.TypeId == 9;
		bool isPlugin = asset.TypeId == 38;
		bool isAssetTypeWhichHasAnyRestrictionsAtAll = num || isModel || isPlace;
		if (Roblox.Platform.Assets.Properties.Settings.Default.IsFetchPluginOwnershipCheckingEnabled)
		{
			isAssetTypeWhichHasAnyRestrictionsAtAll = isAssetTypeWhichHasAnyRestrictionsAtAll || isPlugin;
		}
		if (!isAssetTypeWhichHasAnyRestrictionsAtAll)
		{
			return true;
		}
		if (user != null)
		{
			if (asset.CreatorType == CreatorType.User && asset.CreatorTargetId == user.ID)
			{
				return true;
			}
			if (asset.TypeId != 9 && _AssetOwnershipAuthority.AgentOwnsAsset(user.ID, asset.Id))
			{
				return true;
			}
			if (user.TestIsContentCreator())
			{
				return true;
			}
		}
		if (HasAccessBecauseNotCopyLocked(asset.Id, asset.TypeId))
		{
			return true;
		}
		if (HasAccessBecauseLegacyScript(asset))
		{
			return true;
		}
		return false;
	}

	private bool HasAccessBecauseNotCopyLocked(long assetId, int assetTypeId)
	{
		if (assetTypeId == 9 && !Roblox.AssetOption.GetOrCreate(assetId).IsCopyLocked)
		{
			return true;
		}
		return false;
	}

	private bool HasAccessBecauseLegacyScript(IAsset asset)
	{
		if (asset.TypeId == 5 && asset.CreatorType == CreatorType.User && asset.CreatorTargetId == Roblox.Users.Properties.Settings.Default.RobloxUserId)
		{
			return true;
		}
		return false;
	}
}
