using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Platform.Assets;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Default Clothing
/// https://confluence.roblox.com/pages/viewpage.action?pageId=11897659
/// </summary>
public class DefaultClothingEnforcer
{
	internal Dictionary<long, Asset> _DefaultShirtAssets = new Dictionary<long, Asset>();

	internal Dictionary<long, Asset> _DefaultPantsAssets = new Dictionary<long, Asset>();

	/// <summary>
	/// Load all default assets every time the settings changes
	/// </summary>
	private void HandleDefaultClothingSetting(string csv, DefaultClothingType type)
	{
		long[] assetIds = Converters.ConvertCSVToLongs(csv);
		Dictionary<long, Asset> target = type switch
		{
			DefaultClothingType.Shirt => _DefaultShirtAssets, 
			DefaultClothingType.Pants => _DefaultPantsAssets, 
			_ => throw new Exception("Invalid DefaultClothingType"), 
		};
		target.Clear();
		for (int ii = 0; ii < assetIds.Length; ii++)
		{
			Asset asset = Asset.Get(assetIds[ii]);
			target[ii] = asset;
		}
	}

	public Dictionary<DefaultClothingType, List<long>> GetDefaultClothingAssetLists()
	{
		return new Dictionary<DefaultClothingType, List<long>>
		{
			{
				DefaultClothingType.Shirt,
				_DefaultShirtAssets.Values.Select((Asset asset) => asset.ID).ToList()
			},
			{
				DefaultClothingType.Pants,
				_DefaultPantsAssets.Values.Select((Asset asset) => asset.ID).ToList()
			}
		};
	}

	public Asset GetDefaultClothingAssignment(long userId, DefaultClothingType type)
	{
		Dictionary<long, Asset> target = type switch
		{
			DefaultClothingType.Shirt => _DefaultShirtAssets, 
			DefaultClothingType.Pants => _DefaultPantsAssets, 
			_ => throw new Exception("Invalid DefaultClothingType"), 
		};
		long index = userId % target.Count;
		return target[index];
	}

	public DefaultClothingEnforcer()
	{
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.DefaultClothingShirtAssetIDsCSV, delegate(string value)
		{
			HandleDefaultClothingSetting(value, DefaultClothingType.Shirt);
		});
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.DefaultClothingPantsAssetIDsCSV, delegate(string value)
		{
			HandleDefaultClothingSetting(value, DefaultClothingType.Pants);
		});
	}

	/// <summary>
	/// This avatar actually has had default clothing applied to them.
	/// </summary>
	/// <returns></returns> 
	public bool GetDefaultClothingState(IAvatar avatar, out bool shirt, out bool pants, IBrickBodyColorSet brickBodyColorSet = null)
	{
		shirt = false;
		pants = false;
		brickBodyColorSet = brickBodyColorSet ?? avatar.GetBodyColors();
		if (brickBodyColorSet.LowerBodySameBodyColor() && !avatar.IsWearingApprovedAssetType(AssetType.PantsID, out var _))
		{
			pants = true;
			if (!avatar.IsWearingApprovedAssetType(AssetType.ShirtID, out var _))
			{
				shirt = true;
			}
		}
		return pants | shirt;
	}

	/// <summary>
	/// Check release state and business rules for wearing items for this user,
	/// and if necessary create wornAssets of the default clothing items for them.
	/// Rules: If user is wearing pants, (add default pants and check shirt)
	/// check shirt: if user is not wearing shirt, wear shirt.
	/// Acceptable clothing states, if feature is enabled for the user:
	///   *just pants
	///   *pants and shirt
	/// </summary>
	/// <param name="wornAssets"></param>
	/// <param name="avatar"></param>
	internal void TryAddDefaultClothing(IList<WornAsset> wornAssets, IAvatar avatar)
	{
		if (!avatar.GetBodyColors().LowerBodySameBodyColor() || avatar.IsWearingApprovedAssetType(AssetType.PantsID, out var isPantAssetModerated))
		{
			return;
		}
		if (isPantAssetModerated)
		{
			RemoveWornAssetType(AssetType.PantsID, wornAssets);
		}
		WornAsset pantsState = new WornAsset(AssetType.PantsID, GetDefaultClothingAssignment(avatar.UserId, DefaultClothingType.Pants).ID, isEquippedGear: false, isGear: false, isAnimation: false);
		wornAssets.Add(pantsState);
		if (!avatar.IsWearingApprovedAssetType(AssetType.ShirtID, out var isShirtAssetModerated))
		{
			if (isShirtAssetModerated)
			{
				RemoveWornAssetType(AssetType.ShirtID, wornAssets);
			}
			WornAsset shirtState = new WornAsset(AssetType.ShirtID, GetDefaultClothingAssignment(avatar.UserId, DefaultClothingType.Shirt).ID, isEquippedGear: false, isGear: false, isAnimation: false);
			wornAssets.Add(shirtState);
		}
	}

	/// <summary>
	/// Check release state and business rules for wearing items for this temporary outfit,
	/// and if necessary, add default clothing items for them.
	/// Rules: If user is wearing pants, (add default pants and check shirt)
	/// check shirt: if user is not wearing shirt, wear shirt.
	/// Acceptable clothing states, if feature is enabled for the user:
	///   *just pants
	///   *pants and shirt
	/// </summary>
	/// <param name="user">The user for which the outfit is being created</param>
	/// <param name="outfitAssets">The assets in the outfit.</param>
	/// <param name="brickBodyColorSet">The brick body color set of the outfit.</param>
	/// <param name="assetFactory">The Roblox.Platform AssetFactory to get the Roblox.Platform.Assets.IAsset from the Asset entity.</param>
	internal IList<Roblox.Platform.Assets.IAsset> TryAddDefaultClothing(IUser user, IList<Roblox.Platform.Assets.IAsset> outfitAssets, IBrickBodyColorSet brickBodyColorSet, IAssetFactory assetFactory)
	{
		if (brickBodyColorSet.LowerBodySameBodyColor() && !IsWearingApprovedAssetType(AssetType.PantsID, outfitAssets, out var isPantAssetModerated))
		{
			if (isPantAssetModerated)
			{
				outfitAssets = outfitAssets.Where((Roblox.Platform.Assets.IAsset x) => x.TypeId != AssetType.PantsID).ToList();
			}
			Roblox.Platform.Assets.IAsset defaultPants = assetFactory.GetAsset(GetDefaultClothingAssignment(user.Id, DefaultClothingType.Pants).ID);
			outfitAssets.Add(defaultPants);
			if (!IsWearingApprovedAssetType(AssetType.ShirtID, outfitAssets, out var isShirtAssetModerated))
			{
				if (isShirtAssetModerated)
				{
					outfitAssets = outfitAssets.Where((Roblox.Platform.Assets.IAsset x) => x.TypeId != AssetType.ShirtID).ToList();
				}
				Roblox.Platform.Assets.IAsset defaultShirt = assetFactory.GetAsset(GetDefaultClothingAssignment(user.Id, DefaultClothingType.Shirt).ID);
				outfitAssets.Add(defaultShirt);
			}
		}
		return outfitAssets;
	}

	/// <summary>
	/// For default clothing; does the outfit assets contain an (approved) item of the given assetType?
	/// </summary>
	public bool IsWearingApprovedAssetType(int assetTypeId, IList<Roblox.Platform.Assets.IAsset> outfitAssets, out bool wearingUnapprovedAsset)
	{
		wearingUnapprovedAsset = false;
		foreach (Roblox.Platform.Assets.IAsset asset in outfitAssets)
		{
			if (asset != null && asset.TypeId == assetTypeId)
			{
				Asset asset2 = Asset.Get(asset.Id);
				if (asset2 != null && asset2.IsApproved)
				{
					return true;
				}
				wearingUnapprovedAsset = true;
				return false;
			}
		}
		return false;
	}

	/// <summary>
	/// Private method to remove moderated pant and shirt assets from the list of worn assets so users don't appear to be wearing two of either of those when default clothing is applied. 
	/// We cannot do this with LinQ since we NEED to modify the existing collection as that is what is returned by the method calling TryAddDefaultClothing
	/// </summary>
	private void RemoveWornAssetType(int excludedAssetTypeId, IList<WornAsset> wornAssets)
	{
		IList<int> wornAssetIndexesToRemove = new List<int>();
		for (int index = wornAssets.Count - 1; index >= 0; index--)
		{
			if (wornAssets[index].AssetTypeId == excludedAssetTypeId)
			{
				wornAssetIndexesToRemove.Add(index);
			}
		}
		if (wornAssetIndexesToRemove.Count != 1)
		{
			throw new PlatformDataIntegrityException($"Trying to remove {wornAssetIndexesToRemove.Count} assets of type {excludedAssetTypeId}. The user can only be wearing one such asset as this method is only to be used for shirts and pants.");
		}
		wornAssets.RemoveAt(wornAssetIndexesToRemove[0]);
	}
}
