using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Responsible for all rules around wearing/removing accoutrements
/// </summary>
public class AccoutrementRulesAuthority
{
	private const int _MaxAccessoriesInTenTotalAccessoriesMode = 10;

	private readonly IReadOnlyList<AssetTypeRule> _AssetTypeRules;

	private readonly IReadOnlyDictionary<int, AssetTypeRule> _RuleDictionary;

	private readonly IReadOnlyList<Roblox.Platform.Assets.AssetType> _AccessoryTypes;

	private readonly IReadOnlyList<Roblox.Platform.Assets.AssetType> _AnimationTypes;

	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private readonly IAvatarOwnershipFactory _AvatarOwnershipFactory;

	private readonly IAssetTypeFactory _AssetTypeFactory;

	private readonly ISettings _Settings;

	public int TotalMaxWearable { get; }

	public Dictionary<Roblox.Platform.Assets.AssetType, int> AssetTypeLimits { get; }

	internal AccoutrementRulesAuthority(AvatarDomainFactories avatarDomainFactories)
	{
		_AvatarDomainFactories = avatarDomainFactories ?? throw new PlatformArgumentNullException("avatarDomainFactories");
		_AssetTypeFactory = avatarDomainFactories.AssetTypeFactory ?? throw new PlatformArgumentNullException("_AssetTypeFactory");
		_AvatarOwnershipFactory = avatarDomainFactories.AvatarOwnershipFactory ?? throw new PlatformArgumentNullException("_AvatarOwnershipFactory");
		_Settings = avatarDomainFactories.Settings ?? throw new PlatformArgumentNullException("_Settings");
		_AssetTypeRules = new List<AssetTypeRule>
		{
			Rule(Roblox.Platform.Assets.AssetType.Hat, 3),
			Rule(Roblox.Platform.Assets.AssetType.HairAccessory, 1),
			Rule(Roblox.Platform.Assets.AssetType.FaceAccessory, 1),
			Rule(Roblox.Platform.Assets.AssetType.NeckAccessory, 1),
			Rule(Roblox.Platform.Assets.AssetType.ShoulderAccessory, 1),
			Rule(Roblox.Platform.Assets.AssetType.FrontAccessory, 1),
			Rule(Roblox.Platform.Assets.AssetType.BackAccessory, 1),
			Rule(Roblox.Platform.Assets.AssetType.WaistAccessory, 1),
			Rule(Roblox.Platform.Assets.AssetType.Face, 1),
			Rule(Roblox.Platform.Assets.AssetType.Gear, 1),
			Rule(Roblox.Platform.Assets.AssetType.Head, 1),
			Rule(Roblox.Platform.Assets.AssetType.LeftArm, 1),
			Rule(Roblox.Platform.Assets.AssetType.LeftLeg, 1),
			Rule(Roblox.Platform.Assets.AssetType.Pants, 1),
			Rule(Roblox.Platform.Assets.AssetType.RightArm, 1),
			Rule(Roblox.Platform.Assets.AssetType.RightLeg, 1),
			Rule(Roblox.Platform.Assets.AssetType.Shirt, 1),
			Rule(Roblox.Platform.Assets.AssetType.TShirt, 1),
			Rule(Roblox.Platform.Assets.AssetType.Torso, 1),
			Rule(Roblox.Platform.Assets.AssetType.ClimbAnimation, 1),
			Rule(Roblox.Platform.Assets.AssetType.DeathAnimation, 1),
			Rule(Roblox.Platform.Assets.AssetType.FallAnimation, 1),
			Rule(Roblox.Platform.Assets.AssetType.IdleAnimation, 1),
			Rule(Roblox.Platform.Assets.AssetType.JumpAnimation, 1),
			Rule(Roblox.Platform.Assets.AssetType.RunAnimation, 1),
			Rule(Roblox.Platform.Assets.AssetType.SwimAnimation, 1),
			Rule(Roblox.Platform.Assets.AssetType.WalkAnimation, 1),
			Rule(Roblox.Platform.Assets.AssetType.PoseAnimation, 1),
			Rule(Roblox.Platform.Assets.AssetType.EmoteAnimation, 0)
		};
		_AnimationTypes = new List<Roblox.Platform.Assets.AssetType>
		{
			Roblox.Platform.Assets.AssetType.RunAnimation,
			Roblox.Platform.Assets.AssetType.WalkAnimation,
			Roblox.Platform.Assets.AssetType.FallAnimation,
			Roblox.Platform.Assets.AssetType.JumpAnimation,
			Roblox.Platform.Assets.AssetType.IdleAnimation,
			Roblox.Platform.Assets.AssetType.SwimAnimation,
			Roblox.Platform.Assets.AssetType.ClimbAnimation,
			Roblox.Platform.Assets.AssetType.EmoteAnimation
		};
		_AccessoryTypes = new List<Roblox.Platform.Assets.AssetType>
		{
			Roblox.Platform.Assets.AssetType.Hat,
			Roblox.Platform.Assets.AssetType.HairAccessory,
			Roblox.Platform.Assets.AssetType.FaceAccessory,
			Roblox.Platform.Assets.AssetType.NeckAccessory,
			Roblox.Platform.Assets.AssetType.ShoulderAccessory,
			Roblox.Platform.Assets.AssetType.FrontAccessory,
			Roblox.Platform.Assets.AssetType.BackAccessory,
			Roblox.Platform.Assets.AssetType.WaistAccessory
		};
		_RuleDictionary = _AssetTypeRules.ToDictionary((AssetTypeRule r) => r.AssetTypeId);
		TotalMaxWearable = _AssetTypeRules.Sum((AssetTypeRule rule) => rule.Limit);
		AssetTypeLimits = GetWearableTypes().ToDictionary((AssetTypeRule r) => _AssetTypeFactory.GetAssetType(r.AssetTypeId).Value, (AssetTypeRule r) => r.Limit);
	}

	/// <summary>
	/// Is this something the user can click "wear" on on the website?
	/// *not* something that they can "be wearing".  (due to packages)
	/// </summary>
	public bool IsWearableAssetType(int assetTypeId)
	{
		if (!_RuleDictionary.ContainsKey(assetTypeId))
		{
			return assetTypeId == Roblox.Platform.Assets.AssetType.Package.ToId(_AssetTypeFactory);
		}
		return true;
	}

	/// <summary>
	/// Gets if the user can try on the assetType. For wearable items.
	/// </summary>
	public bool CanTryOn(int assetTypeId)
	{
		if (IsWearableAssetType(assetTypeId) && !IsAnimation(assetTypeId))
		{
			return !IsPackage(assetTypeId);
		}
		return false;
	}

	/// <summary>
	/// Gets the total number
	/// </summary>
	/// <param name="assetTypeId"></param>
	/// <param name="accessoryLimitMode"></param>
	/// <returns></returns>
	public int GetWearingLimitForBucket(int assetTypeId, AccessoryLimitModeEnum accessoryLimitMode)
	{
		if (accessoryLimitMode == AccessoryLimitModeEnum.TenTotalAccessories && IsAccessory(assetTypeId))
		{
			return 10;
		}
		return _RuleDictionary[assetTypeId].Limit;
	}

	/// <summary>
	/// Returns a key that indicates which wearing limit the assetType should be included under
	/// </summary>
	public string GetWearingLimitBucket(int assetTypeId, AccessoryLimitModeEnum accessoryLimitMode)
	{
		if (accessoryLimitMode == AccessoryLimitModeEnum.TenTotalAccessories && IsAccessory(assetTypeId))
		{
			return "Accessory";
		}
		return assetTypeId.ToString();
	}

	/// <summary>
	/// Gets a list of wearable asset types
	/// </summary>
	/// <returns></returns>
	public IReadOnlyCollection<AssetTypeRule> GetWearableTypes()
	{
		return _AssetTypeRules;
	}

	public bool UserMayWearUserAsset(long userId, IUserAsset userAsset)
	{
		if (userAsset != null && userId == userAsset.UserId && IsWearableAssetType(userAsset.AssetTypeId))
		{
			return !_AvatarOwnershipFactory.IsExpired(userAsset);
		}
		return false;
	}

	public bool UserMayRemoveAsset(long userId, long assetId)
	{
		if (userId % 100 < _Settings.UserMayRemoveAssetCheckV2RolloutPercentage)
		{
			return _AvatarOwnershipFactory.UserOwnsAsset(userId, assetId);
		}
		IUserAsset userAsset = _AvatarOwnershipFactory.GetOwnedUserAssetsByAssetId(userId, assetId).FirstOrDefault();
		return UserMayRemoveUserAsset(userId, userAsset);
	}

	public bool UserMayRemoveUserAsset(long userId, IUserAsset userAsset)
	{
		if (userAsset != null)
		{
			return userAsset.UserId == userId;
		}
		return false;
	}

	public void ValidateWearRequest(IEnumerable<Roblox.Platform.Assets.IAsset> assets)
	{
		ValidateWearRequest((from a in assets?.Where((Roblox.Platform.Assets.IAsset a) => a != null)
			select a.Id).ToList());
	}

	public void ValidateWearRequest(ICollection<long> ids)
	{
		if (ids != null && ids.Count() > TotalMaxWearable)
		{
			throw new PlatformException($"Request came in to wear too many ids at once.  ids.Count() = {ids.Count()}");
		}
	}

	public bool IsPackage(int assetTypeId)
	{
		return assetTypeId == Roblox.Platform.Assets.AssetType.Package.ToId(_AssetTypeFactory);
	}

	public bool IsAccessory(int assetTypeId)
	{
		Roblox.Platform.Assets.AssetType? assetType = _AssetTypeFactory.GetAssetType(assetTypeId);
		if (assetType.HasValue)
		{
			return _AccessoryTypes.Contains(assetType.Value);
		}
		return false;
	}

	public bool IsAnimation(int assetTypeId)
	{
		Roblox.Platform.Assets.AssetType? assetType = _AssetTypeFactory.GetAssetType(assetTypeId);
		if (assetType.HasValue)
		{
			return _AnimationTypes.Contains(assetType.Value);
		}
		return false;
	}

	internal AssetTypeRule Rule(Roblox.Platform.Assets.AssetType assetType, int limit)
	{
		return new AssetTypeRule(assetType.ToId(_AssetTypeFactory), limit);
	}

	/// <summary>
	/// For a given list of assets make sure the user can wear all of them.
	/// Example: used when trying to wear a costume
	/// </summary>
	/// <returns>The assetids which are wearable from the sent list.</returns>
	public List<long> GetWearableOwnedAssetIds(List<Asset> assets, IUser user, AccessoryLimitModeEnum accessoryLimitMode)
	{
		List<IUserAsset> userAssets = new List<IUserAsset>();
		foreach (Asset asset in assets)
		{
			if (asset != null)
			{
				IUserAsset userAsset = _AvatarOwnershipFactory.GetOwnedUserAssetsByAssetId(user.Id, asset.ID).FirstOrDefault();
				if (userAsset != null && UserMayWearUserAsset(user.Id, userAsset))
				{
					userAssets.Add(userAsset);
				}
			}
		}
		List<long> userAssetIdsExceedingWearingLimits = GetUserAssetIdsWhichViolateWearingLimits(userAssets, accessoryLimitMode);
		return (from ua in userAssets
			where !userAssetIdsExceedingWearingLimits.Contains(ua.Id)
			select ua into u
			select u.AssetId).ToList();
	}

	/// <summary>
	/// Given a list of data about userAssets
	/// Returns a new list of UserAssets that could not be worn because they are not within the max wearing limits
	/// e.g. you can only wear 1 gear at a time, so if you tried to wear 2 gear, it would discard one
	/// </summary>
	/// <remarks>The reason this doesn't just take userAssetDTOs is that some consumers don't have them - they only have accoutrements.</remarks>
	/// <returns>The userassetIds which violate wearing limits.</returns>
	public List<long> GetUserAssetIdsWhichViolateWearingLimits(List<IUserAsset> userAssets, AccessoryLimitModeEnum accessoryLimitMode)
	{
		if (Settings.Default.DisableAdvancedAccessoryMode)
		{
			accessoryLimitMode = AccessoryLimitModeEnum.ThreeHats;
		}
		List<long> extraUserAssetIds = new List<long>();
		Dictionary<string, int> wearingCounts = new Dictionary<string, int>();
		userAssets.Reverse();
		foreach (IUserAsset userAsset in userAssets)
		{
			if (!IsWearableAssetType(userAsset.AssetTypeId))
			{
				extraUserAssetIds.Add(userAsset.Id);
				continue;
			}
			int maxCount = GetWearingLimitForBucket(userAsset.AssetTypeId, accessoryLimitMode);
			string bucket = GetWearingLimitBucket(userAsset.AssetTypeId, accessoryLimitMode);
			if (!wearingCounts.TryGetValue(bucket, out var count))
			{
				wearingCounts[bucket] = 0;
			}
			if (count >= maxCount)
			{
				extraUserAssetIds.Add(userAsset.Id);
			}
			else
			{
				wearingCounts[bucket]++;
			}
		}
		return extraUserAssetIds;
	}
}
