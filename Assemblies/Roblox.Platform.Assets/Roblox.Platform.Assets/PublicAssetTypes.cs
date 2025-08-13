using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.TranslationResources.Common;

namespace Roblox.Platform.Assets;

public class PublicAssetTypes
{
	/// <summary>
	/// This returns an IEnumerable of public asset types
	/// Public asset types are the asset types that are visible to our users 
	/// </summary>
	internal static IEnumerable<AssetType> GetPublicAssetTypes()
	{
		yield return AssetType.Head;
		yield return AssetType.Face;
		yield return AssetType.Gear;
		yield return AssetType.Hat;
		yield return AssetType.HairAccessory;
		yield return AssetType.FaceAccessory;
		yield return AssetType.NeckAccessory;
		yield return AssetType.ShoulderAccessory;
		yield return AssetType.FrontAccessory;
		yield return AssetType.BackAccessory;
		yield return AssetType.WaistAccessory;
		yield return AssetType.TShirt;
		yield return AssetType.Shirt;
		yield return AssetType.Pants;
		yield return AssetType.Decal;
		yield return AssetType.Model;
		yield return AssetType.Plugin;
		yield return AssetType.Animation;
		yield return AssetType.MeshPart;
		yield return AssetType.Place;
		yield return AssetType.GamePass;
		yield return AssetType.Audio;
		yield return AssetType.Badge;
		yield return AssetType.LeftArm;
		yield return AssetType.RightArm;
		yield return AssetType.LeftLeg;
		yield return AssetType.RightLeg;
		yield return AssetType.Torso;
		yield return AssetType.Package;
		yield return AssetType.ClimbAnimation;
		yield return AssetType.DeathAnimation;
		yield return AssetType.FallAnimation;
		yield return AssetType.IdleAnimation;
		yield return AssetType.JumpAnimation;
		yield return AssetType.RunAnimation;
		yield return AssetType.SwimAnimation;
		yield return AssetType.WalkAnimation;
		yield return AssetType.PoseAnimation;
		yield return AssetType.EmoteAnimation;
	}

	public static string GetLocalizedNameWithGroup(int assetTypeId, bool plural, IAssetTypesResources assetTypesResources = null)
	{
		string name = GetLocalizedNameMinusGroupName(assetTypeId, plural, assetTypesResources);
		string groupName = GetLocalizedGroupName(assetTypeId, plural: false, assetTypesResources);
		if (!string.IsNullOrEmpty(groupName))
		{
			return $"{groupName} | {name}";
		}
		return name;
	}

	public static string GetNameWithGroup(int assetTypeId, bool plural)
	{
		return GetLocalizedNameWithGroup(assetTypeId, plural);
	}

	public static string GetLocalizedGroupName(int assetTypeId, bool plural, IAssetTypesResources assetTypesResources = null)
	{
		if (AccessoryAssetTypes.GetAccessoryAssetTypeIds.Contains(assetTypeId))
		{
			if (assetTypesResources != null)
			{
				if (!plural)
				{
					return assetTypesResources.LabelAccessory;
				}
				return assetTypesResources.LabelAccessories;
			}
			if (!plural)
			{
				return "Accessory";
			}
			return "Accessories";
		}
		if (AvatarAnimationAssetTypes.GetAvatarAnimationAssetTypeIds.Contains(assetTypeId))
		{
			if (assetTypesResources != null)
			{
				if (!plural)
				{
					return assetTypesResources.LabelAnimation;
				}
				return assetTypesResources.LabelAnimations;
			}
			if (!plural)
			{
				return "Animation";
			}
			return "Animations";
		}
		return string.Empty;
	}

	public static string GetGroupName(int assetTypeId, bool plural)
	{
		return GetLocalizedGroupName(assetTypeId, plural);
	}

	public static string GetLocalizedNameMinusGroupName(int assetTypeId, bool plural = false, IAssetTypesResources assetTypesResources = null)
	{
		AssetType? assetType = AssetTypeFactory.Singleton.GetAssetType(assetTypeId);
		if (!assetType.HasValue)
		{
			throw new PlatformArgumentException($"AssetType with ID does not exist: {assetTypeId}");
		}
		if (assetTypesResources != null)
		{
			switch (assetType)
			{
			case AssetType.Head:
				if (!plural)
				{
					return assetTypesResources.LabelHead;
				}
				return assetTypesResources.LabelHeads;
			case AssetType.Face:
				if (!plural)
				{
					return assetTypesResources.LabelFace;
				}
				return assetTypesResources.LabelFaces;
			case AssetType.Gear:
				return assetTypesResources.LabelGear;
			case AssetType.Hat:
				if (!plural)
				{
					return assetTypesResources.LabelHat;
				}
				return assetTypesResources.LabelHats;
			case AssetType.HairAccessory:
				return assetTypesResources.LabelHair;
			case AssetType.FaceAccessory:
				return assetTypesResources.LabelFace;
			case AssetType.NeckAccessory:
				return assetTypesResources.LabelNeck;
			case AssetType.ShoulderAccessory:
				if (!plural)
				{
					return assetTypesResources.LabelShoulder;
				}
				return assetTypesResources.LabelShoulders;
			case AssetType.FrontAccessory:
				return assetTypesResources.LabelFront;
			case AssetType.BackAccessory:
				return assetTypesResources.LabelBack;
			case AssetType.WaistAccessory:
				return assetTypesResources.LabelWaist;
			case AssetType.TShirt:
				if (!plural)
				{
					return assetTypesResources.LabelTShirt;
				}
				return assetTypesResources.LabelTShirts;
			case AssetType.Shirt:
				if (!plural)
				{
					return assetTypesResources.LabelShirt;
				}
				return assetTypesResources.LabelShirts;
			case AssetType.Pants:
				return assetTypesResources.LabelPants;
			case AssetType.Decal:
				if (!plural)
				{
					return assetTypesResources.LabelDecal;
				}
				return assetTypesResources.LabelDecals;
			case AssetType.Model:
				if (!plural)
				{
					return assetTypesResources.LabelModel;
				}
				return assetTypesResources.LabelModels;
			case AssetType.Plugin:
				if (!plural)
				{
					return assetTypesResources.LabelPlugin;
				}
				return assetTypesResources.LabelPlugins;
			case AssetType.Animation:
				if (!plural)
				{
					return assetTypesResources.LabelAnimation;
				}
				return assetTypesResources.LabelAnimations;
			case AssetType.MeshPart:
				return assetTypesResources.LabelMeshPart;
			case AssetType.Place:
				if (!plural)
				{
					return assetTypesResources.LabelPlace;
				}
				return assetTypesResources.LabelPlaces;
			case AssetType.GamePass:
				if (!plural)
				{
					return assetTypesResources.LabelGamePass;
				}
				return assetTypesResources.LabelGamePasses;
			case AssetType.Audio:
				return assetTypesResources.LabelAudio;
			case AssetType.Badge:
				if (!plural)
				{
					return assetTypesResources.LabelBadge;
				}
				return assetTypesResources.LabelBadges;
			case AssetType.LeftArm:
				return assetTypesResources.LabelLeftArm;
			case AssetType.LeftLeg:
				return assetTypesResources.LabelLeftLeg;
			case AssetType.RightArm:
				return assetTypesResources.LabelRightArm;
			case AssetType.RightLeg:
				return assetTypesResources.LabelRightLeg;
			case AssetType.Torso:
				return assetTypesResources.LabelTorso;
			case AssetType.Package:
				if (!plural)
				{
					return assetTypesResources.LabelPackage;
				}
				return assetTypesResources.LabelPackages;
			case AssetType.ClimbAnimation:
				return assetTypesResources.LabelClimb;
			case AssetType.DeathAnimation:
				return assetTypesResources.LabelDeath;
			case AssetType.FallAnimation:
				return assetTypesResources.LabelFall;
			case AssetType.IdleAnimation:
				return assetTypesResources.LabelIdle;
			case AssetType.JumpAnimation:
				return assetTypesResources.LabelJump;
			case AssetType.RunAnimation:
				return assetTypesResources.LabelRun;
			case AssetType.SwimAnimation:
				return assetTypesResources.LabelSwim;
			case AssetType.WalkAnimation:
				return assetTypesResources.LabelWalk;
			case AssetType.PoseAnimation:
				return assetTypesResources.LabelPose;
			case AssetType.EmoteAnimation:
				return assetTypesResources.LabelEmote;
			default:
			{
				Roblox.AssetType entityAssetType = Roblox.AssetType.Get(assetTypeId);
				if (!plural)
				{
					return entityAssetType.Value;
				}
				return entityAssetType.ValuePlural;
			}
			}
		}
		return GetNameMinusGroupName(assetTypeId, plural);
	}

	/// <summary>
	/// Gets the asset type's publicly visible name minus the group
	/// e.g. for Face Accessory it is Face
	/// </summary>
	/// <param name="assetTypeId">The asset type id</param>
	/// <param name="plural">Whether to return the name in plural form</param>
	/// <returns>The shortened name for the <see cref="T:Roblox.Platform.Assets.AssetType" /></returns>
	public static string GetNameMinusGroupName(int assetTypeId, bool plural = false)
	{
		AssetType? assetType = AssetTypeFactory.Singleton.GetAssetType(assetTypeId);
		if (!assetType.HasValue)
		{
			throw new PlatformArgumentException($"AssetType with ID does not exist: {assetTypeId}");
		}
		switch (assetType)
		{
		case AssetType.Hat:
			if (!plural)
			{
				return "Hat";
			}
			return "Hats";
		case AssetType.HairAccessory:
			return "Hair";
		case AssetType.FaceAccessory:
			return "Face";
		case AssetType.NeckAccessory:
			return "Neck";
		case AssetType.ShoulderAccessory:
			if (!plural)
			{
				return "Shoulder";
			}
			return "Shoulders";
		case AssetType.FrontAccessory:
			return "Front";
		case AssetType.BackAccessory:
			return "Back";
		case AssetType.WaistAccessory:
			return "Waist";
		case AssetType.ClimbAnimation:
			return "Climb";
		case AssetType.DeathAnimation:
			return "Death";
		case AssetType.FallAnimation:
			return "Fall";
		case AssetType.IdleAnimation:
			return "Idle";
		case AssetType.JumpAnimation:
			return "Jump";
		case AssetType.RunAnimation:
			return "Run";
		case AssetType.SwimAnimation:
			return "Swim";
		case AssetType.WalkAnimation:
			return "Walk";
		case AssetType.PoseAnimation:
			return "Pose";
		case AssetType.EmoteAnimation:
			return "Emote";
		default:
		{
			Roblox.AssetType entityAssetType = Roblox.AssetType.Get(assetTypeId);
			if (!plural)
			{
				return entityAssetType.Value;
			}
			return entityAssetType.ValuePlural;
		}
		}
	}
}
