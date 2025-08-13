using System;
using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Outfits;
using Roblox.Platform.Outfits.Properties;

namespace Roblox.Platform.Avatar;

public static class AvatarExtensions
{
	/// <summary>
	/// Determine which scaleDescription the user has on.
	/// https://confluence.roblox.com/display/PLATFORM/Avatar+Scaling+and+Scales
	/// </summary>
	/// <param name="avatar">The avatar for which we are requesting the scale</param>
	public static ScaleDescriptionEnum GetScaleDescription(this IAvatar avatar)
	{
		return avatar.GetScale().GetScaleDescription();
	}

	public static ScaleDescriptionEnum GetScaleDescription(this IAvatarScale scale)
	{
		if (scale.Height == ScaleRules.Height.Default && scale.Width == ScaleRules.Width.Default)
		{
			return ScaleDescriptionEnum.Standard;
		}
		if (scale.Height == ScaleRules.Height.Max && scale.Width == ScaleRules.Width.Max)
		{
			return ScaleDescriptionEnum.Biggest;
		}
		if (scale.Height == ScaleRules.Height.Min && scale.Width == ScaleRules.Width.Min)
		{
			return ScaleDescriptionEnum.Smallest;
		}
		decimal ratio = scale.Height / scale.Width;
		if (ratio == 1.0m)
		{
			return ScaleDescriptionEnum.Proportional;
		}
		if (ratio > 1.0m)
		{
			return ScaleDescriptionEnum.Narrower;
		}
		return ScaleDescriptionEnum.Wider;
	}

	public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		HashSet<TKey> knownKeys = new HashSet<TKey>();
		foreach (TSource element in source)
		{
			if (knownKeys.Add(keySelector(element)))
			{
				yield return element;
			}
		}
	}

	public static bool IsUsingAdvancedAccessories(this IAvatar avatar, AvatarDomainFactories avatarDomainFactories)
	{
		Dictionary<Roblox.Platform.Assets.AssetType, int> wearableTypes = avatarDomainFactories.AccoutrementRulesAuthority.AssetTypeLimits;
		foreach (KeyValuePair<int, int> kvp in avatar.GetWornAssetTypeIdCounts())
		{
			Roblox.Platform.Assets.AssetType assetType = avatarDomainFactories.AssetTypeFactory.GetAssetType(kvp.Value).Value;
			if (wearableTypes.ContainsKey(assetType) && kvp.Value > wearableTypes[assetType])
			{
				return true;
			}
		}
		return false;
	}

	/// <summary>
	/// Determines whether 2 body colors are similar enough to pass for "nudity".
	/// The Delta-E difference between two body colors is calculated using the CIE2000
	/// algorithm, and the minimum threshold value is determined by a setting.
	/// </summary>
	/// <param name="firstBrickColorId"></param>
	/// <param name="secondBrickColorId"></param>
	/// <returns>True if firstBodyColor and secondBodyColor are too similar</returns>
	private static bool BodyColorsTooSimilar(int firstBrickColorId, int secondBrickColorId)
	{
		IColor orCreate = Color.GetOrCreate(firstBrickColorId);
		IColor secondColorRgb = Color.GetOrCreate(secondBrickColorId);
		return ColorConverter.DeltaE(orCreate, secondColorRgb) < Roblox.Platform.Outfits.Properties.Settings.Default.MinimumDeltaEColorDifference;
	}

	internal static bool LowerBodySameBodyColor(this IBrickBodyColorSet bodyColors)
	{
		bool lowerBodySameColors = bodyColors.LeftLegBrickColorId == bodyColors.TorsoBrickColorId && bodyColors.RightLegBrickColorId == bodyColors.TorsoBrickColorId;
		if (Roblox.Platform.Avatar.Properties.Settings.Default.DefaultClothingForSimilarColorsEnabled)
		{
			if (!lowerBodySameColors && !BodyColorsTooSimilar(bodyColors.LeftLegBrickColorId, bodyColors.TorsoBrickColorId))
			{
				return BodyColorsTooSimilar(bodyColors.RightLegBrickColorId, bodyColors.TorsoBrickColorId);
			}
			return true;
		}
		return lowerBodySameColors;
	}
}
