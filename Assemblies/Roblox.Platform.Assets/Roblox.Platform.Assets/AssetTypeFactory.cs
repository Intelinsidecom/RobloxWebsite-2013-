using System;
using System.Collections.Generic;
using Roblox.Assets.Client;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

internal class AssetTypeFactory : IAssetTypeFactory
{
	private static AssetTypeFactory _Singleton;

	private static readonly HashSet<AssetType> _ArchivalAllowedAssetTypes = new HashSet<AssetType>
	{
		AssetType.Audio,
		AssetType.Decal,
		AssetType.MeshPart
	};

	private static HashSet<AssetType> CatalogCategoryAssetTypeIds = new HashSet<AssetType>
	{
		AssetType.Arms,
		AssetType.BackAccessory,
		AssetType.Face,
		AssetType.FaceAccessory,
		AssetType.FrontAccessory,
		AssetType.Gear,
		AssetType.HairAccessory,
		AssetType.Hat,
		AssetType.Head,
		AssetType.LeftArm,
		AssetType.LeftLeg,
		AssetType.Legs,
		AssetType.NeckAccessory,
		AssetType.Package,
		AssetType.Pants,
		AssetType.RightArm,
		AssetType.RightLeg,
		AssetType.Shirt,
		AssetType.ShoulderAccessory,
		AssetType.Torso,
		AssetType.TShirt,
		AssetType.WaistAccessory,
		AssetType.ClimbAnimation,
		AssetType.DeathAnimation,
		AssetType.FallAnimation,
		AssetType.IdleAnimation,
		AssetType.JumpAnimation,
		AssetType.RunAnimation,
		AssetType.SwimAnimation,
		AssetType.WalkAnimation,
		AssetType.PoseAnimation,
		AssetType.EmoteAnimation
	};

	private static HashSet<AssetType> LibraryCategoryAssetTypeIds = new HashSet<AssetType>
	{
		AssetType.Animation,
		AssetType.Audio,
		AssetType.Badge,
		AssetType.Code,
		AssetType.Decal,
		AssetType.GamePass,
		AssetType.HTML,
		AssetType.Image,
		AssetType.LocalizationTableManifest,
		AssetType.LocalizationTableTranslation,
		AssetType.Lua,
		AssetType.Mesh,
		AssetType.MeshPart,
		AssetType.Model,
		AssetType.Plugin,
		AssetType.SolidModel,
		AssetType.Text,
		AssetType.TexturePack
	};

	internal static AssetTypeFactory Singleton
	{
		get
		{
			if (_Singleton == null)
			{
				_Singleton = Factories.DomainFactories.AssetTypeFactoryInternal;
			}
			return _Singleton;
		}
		set
		{
			_Singleton = value;
		}
	}

	/// <inheritdoc />
	public AssetType? GetAssetType(int id)
	{
		Roblox.AssetType type = Roblox.AssetType.Get(id);
		if (type == null)
		{
			return null;
		}
		return GetAssetTypeByValue(type.Value);
	}

	/// <inheritdoc />
	public bool IsArchivalEnabledForType(AssetType assetType)
	{
		return _ArchivalAllowedAssetTypes.Contains(assetType);
	}

	/// <inheritdoc />
	public IEnumerable<AssetType> GetArchivalEnabledTypes()
	{
		return _ArchivalAllowedAssetTypes;
	}

	/// <inheritdoc />
	public AssetType? GetAssetTypeByValue(string assetTypeValue)
	{
		return assetTypeValue switch
		{
			"Image" => AssetType.Image, 
			"T-Shirt" => AssetType.TShirt, 
			"Audio" => AssetType.Audio, 
			"Mesh" => AssetType.Mesh, 
			"Lua" => AssetType.Lua, 
			"MeshPart" => AssetType.MeshPart, 
			"HTML" => AssetType.HTML, 
			"Text" => AssetType.Text, 
			"Hat" => AssetType.Hat, 
			"Hair Accessory" => AssetType.HairAccessory, 
			"Face Accessory" => AssetType.FaceAccessory, 
			"Neck Accessory" => AssetType.NeckAccessory, 
			"Shoulder Accessory" => AssetType.ShoulderAccessory, 
			"Front Accessory" => AssetType.FrontAccessory, 
			"Back Accessory" => AssetType.BackAccessory, 
			"Waist Accessory" => AssetType.WaistAccessory, 
			"Place" => AssetType.Place, 
			"Model" => AssetType.Model, 
			"Shirt" => AssetType.Shirt, 
			"Pants" => AssetType.Pants, 
			"Decal" => AssetType.Decal, 
			"Avatar" => AssetType.Avatar, 
			"Head" => AssetType.Head, 
			"Face" => AssetType.Face, 
			"Gear" => AssetType.Gear, 
			"Badge" => AssetType.Badge, 
			"Animation" => AssetType.Animation, 
			"Arms" => AssetType.Arms, 
			"Legs" => AssetType.Legs, 
			"Torso" => AssetType.Torso, 
			"Right Arm" => AssetType.RightArm, 
			"Left Arm" => AssetType.LeftArm, 
			"Left Leg" => AssetType.LeftLeg, 
			"Right Leg" => AssetType.RightLeg, 
			"Package" => AssetType.Package, 
			"YouTubeVideo" => AssetType.YouTubeVideo, 
			"Game Pass" => AssetType.GamePass, 
			"App" => AssetType.App, 
			"Code" => AssetType.Code, 
			"Plugin" => AssetType.Plugin, 
			"SolidModel" => AssetType.SolidModel, 
			"Climb Animation" => AssetType.ClimbAnimation, 
			"Death Animation" => AssetType.DeathAnimation, 
			"Fall Animation" => AssetType.FallAnimation, 
			"Idle Animation" => AssetType.IdleAnimation, 
			"Jump Animation" => AssetType.JumpAnimation, 
			"Run Animation" => AssetType.RunAnimation, 
			"Swim Animation" => AssetType.SwimAnimation, 
			"Walk Animation" => AssetType.WalkAnimation, 
			"Pose Animation" => AssetType.PoseAnimation, 
			"LocalizationTableManifest" => AssetType.LocalizationTableManifest, 
			"LocalizationTableTranslation" => AssetType.LocalizationTableTranslation, 
			"Emote Animation" => AssetType.EmoteAnimation, 
			"Video" => AssetType.Video, 
			"TexturePack" => AssetType.TexturePack, 
			_ => null, 
		};
	}

	/// <inheritdoc />
	public int ToId(AssetType assetType)
	{
		return ToLegacyAssetType(assetType).ID;
	}

	/// <inheritdoc />
	public string ToLegacyValue(AssetType assetType)
	{
		return ToLegacyAssetType(assetType).Value;
	}

	/// <inheritdoc />
	public AssetCategory GetAssetTypeCategory(AssetType assetType)
	{
		if (CatalogCategoryAssetTypeIds.Contains(assetType))
		{
			return AssetCategory.Catalog;
		}
		if (LibraryCategoryAssetTypeIds.Contains(assetType))
		{
			return AssetCategory.Library;
		}
		throw new PlatformDataIntegrityException("AssetType " + assetType.ToString() + " could not be found");
	}

	private Roblox.AssetType ToLegacyAssetType(AssetType assetType)
	{
		return assetType switch
		{
			AssetType.Animation => Roblox.AssetType.GetAnimation(), 
			AssetType.App => Roblox.AssetType.GetApp(), 
			AssetType.Arms => Roblox.AssetType.GetArms(), 
			AssetType.TShirt => Roblox.AssetType.GetTeeShirt(), 
			AssetType.Image => Roblox.AssetType.GetImage(), 
			AssetType.Audio => Roblox.AssetType.GetAudio(), 
			AssetType.Mesh => Roblox.AssetType.GetMesh(), 
			AssetType.Lua => Roblox.AssetType.GetLua(), 
			AssetType.MeshPart => Roblox.AssetType.GetMeshPart(), 
			AssetType.HTML => Roblox.AssetType.GetHtml(), 
			AssetType.Text => Roblox.AssetType.GetText(), 
			AssetType.Hat => Roblox.AssetType.GetHat(), 
			AssetType.HairAccessory => Roblox.AssetType.GetHairAccessory(), 
			AssetType.FaceAccessory => Roblox.AssetType.GetFaceAccessory(), 
			AssetType.NeckAccessory => Roblox.AssetType.GetNeckAccessory(), 
			AssetType.ShoulderAccessory => Roblox.AssetType.GetShoulderAccessory(), 
			AssetType.FrontAccessory => Roblox.AssetType.GetFrontAccessory(), 
			AssetType.BackAccessory => Roblox.AssetType.GetBackAccessory(), 
			AssetType.WaistAccessory => Roblox.AssetType.GetWaistAccessory(), 
			AssetType.Place => Roblox.AssetType.GetPlace(), 
			AssetType.Model => Roblox.AssetType.GetModel(), 
			AssetType.Shirt => Roblox.AssetType.GetShirt(), 
			AssetType.Pants => Roblox.AssetType.GetPants(), 
			AssetType.Decal => Roblox.AssetType.GetDecal(), 
			AssetType.Avatar => Roblox.AssetType.GetAvatar(), 
			AssetType.Head => Roblox.AssetType.GetHead(), 
			AssetType.Face => Roblox.AssetType.GetFace(), 
			AssetType.Gear => Roblox.AssetType.GetGear(), 
			AssetType.Badge => Roblox.AssetType.GetBadge(), 
			AssetType.Legs => Roblox.AssetType.GetLegs(), 
			AssetType.Torso => Roblox.AssetType.GetTorso(), 
			AssetType.RightArm => Roblox.AssetType.GetRightArm(), 
			AssetType.LeftArm => Roblox.AssetType.GetLeftArm(), 
			AssetType.RightLeg => Roblox.AssetType.GetRightLeg(), 
			AssetType.LeftLeg => Roblox.AssetType.GetLeftLeg(), 
			AssetType.Package => Roblox.AssetType.GetPackage(), 
			AssetType.YouTubeVideo => Roblox.AssetType.GetYouTubeVideo(), 
			AssetType.GamePass => Roblox.AssetType.GetGamePass(), 
			AssetType.Code => Roblox.AssetType.GetCode(), 
			AssetType.Plugin => Roblox.AssetType.GetPlugin(), 
			AssetType.SolidModel => Roblox.AssetType.GetSolidModel(), 
			AssetType.ClimbAnimation => Roblox.AssetType.GetClimbAnimation(), 
			AssetType.DeathAnimation => Roblox.AssetType.GetDeathAnimation(), 
			AssetType.FallAnimation => Roblox.AssetType.GetFallAnimation(), 
			AssetType.IdleAnimation => Roblox.AssetType.GetIdleAnimation(), 
			AssetType.JumpAnimation => Roblox.AssetType.GetJumpAnimation(), 
			AssetType.RunAnimation => Roblox.AssetType.GetRunAnimation(), 
			AssetType.SwimAnimation => Roblox.AssetType.GetSwimAnimation(), 
			AssetType.WalkAnimation => Roblox.AssetType.GetWalkAnimation(), 
			AssetType.PoseAnimation => Roblox.AssetType.GetPoseAnimation(), 
			AssetType.LocalizationTableManifest => Roblox.AssetType.GetLocalizationTableManifest(), 
			AssetType.LocalizationTableTranslation => Roblox.AssetType.GetLocalizationTableTranslation(), 
			AssetType.EmoteAnimation => Roblox.AssetType.GetEmoteAnimation(), 
			AssetType.Video => Roblox.AssetType.GetVideo(), 
			AssetType.TexturePack => Roblox.AssetType.GetTexturePack(), 
			_ => throw new PlatformDataIntegrityException("AssetType " + assetType.ToString() + " could not be found"), 
		};
	}

	/// <inheritdoc />
	public bool DoesAssetTypeRequireReview(AssetType assetType)
	{
		return ToLegacyAssetType(assetType).RequiresReview;
	}

	/// <inheritdoc />
	public AssetType ToAssetsClientAssetType(AssetType platformAssetType)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (!Enum.TryParse<AssetType>(platformAssetType.ToString(), out AssetType clientAssetType))
		{
			throw new ApplicationException($"Cannot translate platform asset type enum {platformAssetType} to Assets service client's asset type enum.");
		}
		return clientAssetType;
	}

	/// <inheritdoc />
	public bool IsAssetTypeVersioningEnabled(AssetType assetType)
	{
		if (assetType != AssetType.Plugin && assetType != AssetType.Model && assetType != AssetType.Place)
		{
			return assetType == AssetType.Animation;
		}
		return true;
	}

	/// <inheritdoc />
	public bool IsAssetTypeOnMarketplace(AssetType assetType)
	{
		if (assetType != AssetType.Model && assetType != AssetType.Decal && assetType != AssetType.MeshPart && assetType != AssetType.Audio)
		{
			return assetType == AssetType.Plugin;
		}
		return true;
	}

	/// <inheritdoc />
	public bool CanAssetTypeHaveThumbnail(AssetType assetType)
	{
		if (assetType != AssetType.Place)
		{
			return assetType == AssetType.Plugin;
		}
		return true;
	}
}
