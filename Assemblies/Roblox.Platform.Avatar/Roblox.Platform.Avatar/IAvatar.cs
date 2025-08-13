using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Avatar;

/// <summary>
/// An object which can be used to wear and remove things for a user.
/// </summary>
public interface IAvatar
{
	IUser User { get; }

	long UserId { get; }

	void WearAsset(long assetId, bool resetCurrentAppearance = false);

	/// <summary>
	/// Adds a list of assets to the avatar
	/// </summary>
	/// <param name="assetIds">The assetIds to wear</param>
	/// <param name="resetCurrentAppearance">If true, removes all other assets first</param>
	/// <param name="accessoryLimitMode">Whether to use the 10 accessory maximum, or the 3 hat max + 1 of each</param>
	void WearAssets(IEnumerable<long> assetIds, bool resetCurrentAppearance = false, AccessoryLimitModeEnum accessoryLimitMode = AccessoryLimitModeEnum.TenTotalAccessories);

	/// <summary>
	/// Sets the appearance of the avatar to the specified user outfit.
	/// Does not wear item that are no longer owned.
	/// </summary>
	/// <param name="userOutfit"></param>
	/// <returns></returns>
	ICollection<long> WearOutfit(IUserOutfit userOutfit);

	/// <summary>
	/// Given an Outfit entity, creates a user outfit
	/// </summary>
	/// <param name="outfit"></param>
	/// <param name="textFilterClientV2"></param>
	/// <param name="outfitName"></param>
	/// <returns></returns>
	IUserOutfit CreateUserOutfit(IOutfit outfit, ITextFilterClientV2 textFilterClientV2, string outfitName = null);

	/// <summary>
	/// Updates a user outfit to point to the given outfit
	/// </summary>
	/// <param name="userOutfit"></param>
	/// <param name="outfit"></param>
	void UpdateUserOutfit(IUserOutfit userOutfit, IOutfit outfit);

	void RemoveAsset(long assetId);

	bool IsWearingUserAsset(long userAssetId);

	bool IsWearingApprovedAssetType(int assetTypeId, out bool wearingUnapprovedAsset);

	PlayerAvatarType GetPlayerAvatarType();

	void SetPlayerAvatarType(PlayerAvatarType playerAvatarType);

	/// <summary>
	/// This should be the only way to access what the avatar is wearing.
	/// </summary>
	/// <param name="mustCheckWearingRules">If true, then we check the business rules for wearing slots &amp; types before returning.  This possibly removes some Accoutrements.</param>
	/// <param name="checkIfDefaultClothingNeeded">If true, then WornAsset objects for the default clothing will be created - even if the user doesn't actually own those types.
	/// (This is to prevent nude avatars when user isn't wearing shirt/pants on their own)</param>
	/// <returns></returns>
	IReadOnlyCollection<IWornAsset> GetWornAssets(bool checkIfDefaultClothingNeeded, bool mustCheckWearingRules = false);

	IReadOnlyDictionary<int, int> GetWornAssetTypeIdCounts();

	IReadOnlyCollection<Asset> GetGear(int startRowIndex, int maximumRows);

	IReadOnlyCollection<long> GetGearForPlacePaged(Asset placeAsset, int startIndex, int maximumRows, IReadOnlyCollection<long> equippedGearVersionIds);

	IBrickBodyColorSet GetBodyColors();

	long? GetBodyColorSetId();

	void SetBodyColors(IBrickBodyColorSet bodyColorSet);

	/// <summary>
	/// Gets the avatar's scale.
	/// Heals the value in the database if it's outside the valid max and min values.
	/// Returns a default scale if the user's scale is null or scales are globally overridden.
	/// Note that even though scales aren't applied to R6 avatars, this will return the scales set in the database.
	/// </summary>
	IAvatarScale GetScale();

	/// <summary>
	/// Gets the default scale for an avatar
	/// </summary>
	IAvatarScale GetDefaultScale();

	/// <summary>
	/// Sets the avatar's scale.
	/// Returns false and does not update if any of the scales are out of the valid range.
	/// Use <see cref="M:Roblox.Platform.Avatar.IAvatar.CheckScale(System.Decimal,System.Decimal,System.Nullable{System.Decimal},System.Nullable{System.Decimal},System.Nullable{System.Decimal})" /> beforehand.
	/// </summary>
	bool SetScale(decimal height, decimal width, decimal? head, decimal? proportion, decimal? bodyType);

	/// <summary>
	/// Checks the avatar scales and ensures they are within valid ranges
	/// </summary>
	/// <returns>A list of <see cref="T:Roblox.Platform.Outfits.ScaleRules" /> for each dimension of the scale that is out of range</returns>
	IList<ScaleRules> CheckScale(decimal height, decimal width, decimal? head, decimal? proportion, decimal? bodyType);
}
