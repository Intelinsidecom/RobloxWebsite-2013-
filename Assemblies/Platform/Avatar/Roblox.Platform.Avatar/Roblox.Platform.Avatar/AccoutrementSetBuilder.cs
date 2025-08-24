using System.Collections.Generic;
using System.Linq;
using Roblox.Data;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Represents a set of assets worn by a user.
/// Has methods to add items, remove items, and validate business rules.
/// Should preserve order of assets.
/// </summary>
public class AccoutrementSetBuilder
{
	private List<Roblox.Platform.Assets.IAsset> _Assets;

	private List<Roblox.Platform.Assets.IAsset> _OriginalAssets;

	private readonly IUser _User;

	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private IAvatarOwnershipFactory AvatarOwnershipFactory => _AvatarDomainFactories.AvatarOwnershipFactory;

	private IAssetFactoryBase<IPackage> PackageFactory => _AvatarDomainFactories.PackageFactory;

	private IAccoutrementPackageItemFactory AccoutrementPackageItemFactory => _AvatarDomainFactories.AccoutrementPackageItemFactory;

	private IAssetTypeFactory AssetTypeFactory => _AvatarDomainFactories.AssetTypeFactory;

	private IAssetFactory AssetFactory => _AvatarDomainFactories.AssetFactory;

	private AccoutrementRulesAuthority AccoutrementRulesAuthority => _AvatarDomainFactories.AccoutrementRulesAuthority;

	private IAccoutrementFactory AccoutrementFactory => _AvatarDomainFactories.AccoutrementFactory;

	private ISettings Settings => _AvatarDomainFactories.Settings;

	public AccoutrementSetBuilder(IUser user, AvatarDomainFactories avatarDomainFactories)
	{
		_AvatarDomainFactories = avatarDomainFactories ?? throw new PlatformArgumentNullException("avatarDomainFactories");
		_User = user ?? throw new PlatformArgumentNullException("user");
		_Assets = new List<Roblox.Platform.Assets.IAsset>();
		_OriginalAssets = new List<Roblox.Platform.Assets.IAsset>();
	}

	/// <summary>
	/// Loads accoutrements for the user.
	/// </summary>
	public void LoadAccoutrements()
	{
		List<IAccoutrement> accoutrements = AccoutrementFactory.GetUserAccoutrementsNoFilter(_User.Id).ToList();
		IList<IUserAsset> userAssets;
		if (_User.Id % 100 < Settings.GetUserAssetByIdUseMultiGetRolloutPercentage)
		{
			HashSet<long> accoutrementUserAssetIds = new HashSet<long>(accoutrements.Select((IAccoutrement a) => a.UserAssetID));
			userAssets = (from ua in AvatarOwnershipFactory.GetUserAssetsByUserAssetIds(accoutrementUserAssetIds)
				select ua.Value).ToList();
		}
		else
		{
			userAssets = accoutrements.Select((IAccoutrement a) => AvatarOwnershipFactory.GetUserAssetByUserAssetId(a.UserAssetID)).ToList();
		}
		_OriginalAssets = (from ua in userAssets
			where ua != null
			select AssetFactory.CheckedGetAsset(ua.AssetId)).ToList();
		foreach (IUserAsset userAsset in userAssets)
		{
			AddExisting(userAsset);
		}
	}

	/// <summary>
	/// Returns true if there are any changes between the original set of loaded accoutrements, and the modified set.
	/// </summary>
	public bool HasPendingChanges()
	{
		if (_OriginalAssets.Count != _Assets.Count)
		{
			return true;
		}
		_OriginalAssets.Sort((Roblox.Platform.Assets.IAsset a, Roblox.Platform.Assets.IAsset b) => a.Id.CompareTo(b.Id));
		_Assets.Sort((Roblox.Platform.Assets.IAsset a, Roblox.Platform.Assets.IAsset b) => a.Id.CompareTo(b.Id));
		for (int i = 0; i < _OriginalAssets.Count; i++)
		{
			if (_OriginalAssets[i].Id != _Assets[i].Id)
			{
				return true;
			}
		}
		return false;
	}

	/// <summary>
	/// Attempts to add an item to the accoutrement set
	/// </summary>
	public bool Add(Roblox.Platform.Assets.IAsset asset, bool checkOwnership = true)
	{
		if (asset == null)
		{
			return false;
		}
		if (_Assets.FirstOrDefault((Roblox.Platform.Assets.IAsset a) => a.Id == asset.Id) != null)
		{
			return false;
		}
		if (!IsWearableAsset(asset))
		{
			return false;
		}
		if (checkOwnership && !OwnsAsset(asset))
		{
			return false;
		}
		if (IsPackage(asset))
		{
			IPackage package = PackageFactory.Get(asset.Id);
			foreach (IAccoutrementPackageItem packageItem in AccoutrementPackageItemFactory.GetPackageItems(package))
			{
				Roblox.Platform.Assets.IAsset packageItemAsset = AssetFactory.CheckedGetAsset(packageItem.AssetId);
				if (IsPackage(packageItemAsset))
				{
					throw new DataIntegrityException($"Package ID={asset.Id} contains another package ID={packageItemAsset.Id}");
				}
				Add(packageItemAsset);
			}
			return true;
		}
		_Assets.Add(asset);
		return true;
	}

	/// <summary>
	/// Attempts to remove an item from the accoutrement set
	/// </summary>
	public bool Remove(Roblox.Platform.Assets.IAsset asset)
	{
		if (_Assets.FirstOrDefault((Roblox.Platform.Assets.IAsset a) => a.Id == asset.Id) == null)
		{
			return false;
		}
		_Assets = _Assets.Where((Roblox.Platform.Assets.IAsset a) => a.Id != asset.Id).ToList();
		return true;
	}

	/// <summary>
	/// Check if the accoutrement set contains a specific asset
	/// </summary>
	public bool Contains(Roblox.Platform.Assets.IAsset asset)
	{
		return _Assets.FirstOrDefault((Roblox.Platform.Assets.IAsset a) => a.Id == asset.Id) != null;
	}

	/// <summary>
	/// Remove duplicate items from the accoutrement set
	/// </summary>
	public void FilterDuplicates()
	{
		_Assets = _Assets.DistinctBy((Roblox.Platform.Assets.IAsset a) => a.Id).ToList();
	}

	/// <summary>
	/// Removes all items from the accoutrement set
	/// </summary>
	public void Reset()
	{
		_Assets = new List<Roblox.Platform.Assets.IAsset>();
	}

	/// <summary>
	/// Enforces the maximum limit per assetType
	/// </summary>
	public void EnforceWearingLimits(AccessoryLimitModeEnum accessoryLimitMode)
	{
		if (Settings.DisableAdvancedAccessoryMode)
		{
			accessoryLimitMode = AccessoryLimitModeEnum.ThreeHats;
		}
		HashSet<long> assetIdsToRemove = new HashSet<long>();
		Dictionary<string, int> wearingCounts = new Dictionary<string, int>();
		for (int i = _Assets.Count - 1; i >= 0; i--)
		{
			Roblox.Platform.Assets.IAsset asset = _Assets[i];
			if (!IsWearableAsset(asset))
			{
				assetIdsToRemove.Add(asset.TypeId);
			}
			else
			{
				int maxCount = AccoutrementRulesAuthority.GetWearingLimitForBucket(asset.TypeId, accessoryLimitMode);
				string bucket = AccoutrementRulesAuthority.GetWearingLimitBucket(asset.TypeId, accessoryLimitMode);
				if (!wearingCounts.TryGetValue(bucket, out var count))
				{
					wearingCounts[bucket] = 0;
				}
				if (count >= maxCount)
				{
					assetIdsToRemove.Add(asset.Id);
				}
				else
				{
					wearingCounts[bucket]++;
				}
			}
		}
		_Assets = _Assets.Where((Roblox.Platform.Assets.IAsset a) => !assetIdsToRemove.Contains(a.Id)).ToList();
	}

	public IReadOnlyCollection<Roblox.Platform.Assets.IAsset> GetAssets()
	{
		return _Assets;
	}

	/// <summary>
	/// Checks if the asset is a wearable asset type
	/// </summary>
	private bool IsWearableAsset(Roblox.Platform.Assets.IAsset asset)
	{
		int assetTypeId = asset.TypeId;
		return AccoutrementRulesAuthority.IsWearableAssetType(assetTypeId);
	}

	/// <summary>
	/// Checks if the asset is a package
	/// </summary>
	private bool IsPackage(Roblox.Platform.Assets.IAsset asset)
	{
		return asset.GetAssetType(AssetTypeFactory) == Roblox.Platform.Assets.AssetType.Package;
	}

	/// <summary>
	/// Checks if the asset is owned and is not expired
	/// </summary>
	private bool OwnsAsset(Roblox.Platform.Assets.IAsset asset)
	{
		if (_User.Id % 100 < Settings.UserOwnsUnexpiredAssetCheckRolloutPercentage)
		{
			return AvatarOwnershipFactory.UserOwnsUnexpiredAsset(_User.Id, asset.Id);
		}
		IUserAsset userAsset = _AvatarDomainFactories.AvatarOwnershipFactory.GetOwnedUserAssetsByAssetId(_User.Id, asset.Id).FirstOrDefault();
		if (userAsset != null)
		{
			return !AvatarOwnershipFactory.IsExpired(userAsset);
		}
		return false;
	}

	/// <summary>
	/// Adds an accoutrement to the assets list that is already on the avatar.
	/// Doesn't do as many permission checks as Add()
	/// </summary>
	/// <param name="userAsset"></param>
	private void AddExisting(IUserAsset userAsset)
	{
		if (userAsset != null && _Assets.FirstOrDefault((Roblox.Platform.Assets.IAsset a) => a.Id == userAsset.AssetId) == null && !AvatarOwnershipFactory.IsExpired(userAsset))
		{
			Roblox.Platform.Assets.IAsset asset = AssetFactory.CheckedGetAsset(userAsset.AssetId);
			if (IsWearableAsset(asset))
			{
				_Assets.Add(asset);
			}
		}
	}
}
