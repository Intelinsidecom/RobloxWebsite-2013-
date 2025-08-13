using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

[Serializable]
[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
public class AssetType : IRobloxEntity<int, AssetTypeDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private AssetTypeDAL _EntityDAL;

	public static readonly int AudioID;

	public const string AudioValue = "Audio";

	public static readonly int AvatarID;

	public const string AvatarValue = "Avatar";

	public static readonly int DecalID;

	public const string DecalValue = "Decal";

	public static readonly int HatID;

	public const string HatValue = "Hat";

	public static readonly int HairAccessoryID;

	public const string HairAccessoryValue = "Hair Accessory";

	public static readonly int FaceAccessoryID;

	public const string FaceAccessoryValue = "Face Accessory";

	public static readonly int NeckAccessoryID;

	public const string NeckAccessoryValue = "Neck Accessory";

	public static readonly int ShoulderAccessoryID;

	public const string ShoulderAccessoryValue = "Shoulder Accessory";

	public static readonly int FrontAccessoryID;

	public const string FrontAccessoryValue = "Front Accessory";

	public static readonly int BackAccessoryID;

	public const string BackAccessoryValue = "Back Accessory";

	public static readonly int WaistAccessoryID;

	public const string WaistAccessoryValue = "Waist Accessory";

	public static readonly int HtmlID;

	public const string HtmlValue = "HTML";

	public static readonly int ImageID;

	public const string ImageValue = "Image";

	public static readonly int LuaID;

	public const string LuaValue = "Lua";

	public static readonly int MeshID;

	public const string MeshValue = "Mesh";

	public static readonly int MeshPartID;

	public const string MeshPartValue = "MeshPart";

	public static readonly int ModelID;

	public const string ModelValue = "Model";

	public static readonly int PantsID;

	public const string PantsValue = "Pants";

	public static readonly int PlaceID;

	public const string PlaceValue = "Place";

	public static readonly int ShirtID;

	public const string ShirtValue = "Shirt";

	public static readonly int TeeShirtID;

	public const string TeeShirtValue = "T-Shirt";

	public static readonly int TextID;

	public const string TextValue = "Text";

	public static readonly int HeadID;

	public const string HeadValue = "Head";

	public static readonly int FaceID;

	public const string FaceValue = "Face";

	public static readonly int GearID;

	public const string GearValue = "Gear";

	public static readonly int BadgeID;

	public const string BadgeValue = "Badge";

	public static readonly int AnimationID;

	public const string AnimationValue = "Animation";

	public static readonly int ArmsID;

	public const string ArmsValue = "Arms";

	public static readonly int LeftArmID;

	public const string LeftArmValue = "Left Arm";

	public static readonly int RightArmID;

	public const string RightArmValue = "Right Arm";

	public static readonly int LegsID;

	public const string LegsValue = "Legs";

	public static readonly int LeftLegID;

	public const string LeftLegValue = "Left Leg";

	public static readonly int RightLegID;

	public const string RightLegValue = "Right Leg";

	public static readonly int TorsoID;

	public const string TorsoValue = "Torso";

	public static readonly int PackageID;

	public const string PackageValue = "Package";

	public static readonly int YouTubeVideoID;

	public const string YouTubeVideoValue = "YouTubeVideo";

	public static readonly int GamePassID;

	public const string GamePassValue = "Game Pass";

	public static readonly int AppID;

	public const string AppValue = "App";

	public static readonly int CodeID;

	public const string CodeValue = "Code";

	public static readonly int PluginID;

	public const string PluginValue = "Plugin";

	public static readonly int SolidModelID;

	public const string SolidModelValue = "SolidModel";

	public static readonly int ClimbAnimationID;

	public const string ClimbAnimationValue = "Climb Animation";

	public static readonly int DeathAnimationID;

	public const string DeathAnimationValue = "Death Animation";

	public static readonly int FallAnimationID;

	public const string FallAnimationValue = "Fall Animation";

	public static readonly int IdleAnimationID;

	public const string IdleAnimationValue = "Idle Animation";

	public static readonly int JumpAnimationID;

	public const string JumpAnimationValue = "Jump Animation";

	public static readonly int RunAnimationID;

	public const string RunAnimationValue = "Run Animation";

	public static readonly int SwimAnimationID;

	public const string SwimAnimationValue = "Swim Animation";

	public static readonly int WalkAnimationID;

	public const string WalkAnimationValue = "Walk Animation";

	public static readonly int PoseAnimationID;

	public const string PoseAnimationValue = "Pose Animation";

	public static readonly int LocalizationTableManifestID;

	public const string LocalizationTableManifestValue = "LocalizationTableManifest";

	public static readonly int LocalizationTableTranslationID;

	public const string LocalizationTableTranslationValue = "LocalizationTableTranslation";

	public static readonly int EmoteAnimationID;

	public const string EmoteAnimationValue = "Emote Animation";

	public static readonly int VideoID;

	public const string VideoValue = "Video";

	public static readonly int TexturePackID;

	public const string TexturePackValue = "TexturePack";

	public static readonly Dictionary<string, int> _AssetIdLookup;

	private static readonly HashSet<int> _PubliclyPurchasableAssetTypeIds;

	public static CacheInfo EntityCacheInfo;

	public int ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	public string ValuePlural => GetValuePluralized(Value);

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public string Abbreviation
	{
		get
		{
			return _EntityDAL.Abbreviation;
		}
		set
		{
			_EntityDAL.Abbreviation = value;
		}
	}

	public bool RequiresReview
	{
		get
		{
			return _EntityDAL.RequiresReview;
		}
		set
		{
			_EntityDAL.RequiresReview = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetType(AssetTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public AssetType()
	{
		_EntityDAL = new AssetTypeDAL();
	}

	static AssetType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "AssetType", isNullCacheable: true);
		AudioID = MustGet("Audio").ID;
		AvatarID = MustGet("Avatar").ID;
		DecalID = MustGet("Decal").ID;
		HatID = MustGet("Hat").ID;
		HairAccessoryID = MustGet("Hair Accessory").ID;
		FaceAccessoryID = MustGet("Face Accessory").ID;
		NeckAccessoryID = MustGet("Neck Accessory").ID;
		ShoulderAccessoryID = MustGet("Shoulder Accessory").ID;
		FrontAccessoryID = MustGet("Front Accessory").ID;
		BackAccessoryID = MustGet("Back Accessory").ID;
		WaistAccessoryID = MustGet("Waist Accessory").ID;
		HtmlID = MustGet("HTML").ID;
		ImageID = MustGet("Image").ID;
		LuaID = MustGet("Lua").ID;
		MeshID = MustGet("Mesh").ID;
		MeshPartID = MustGet("MeshPart").ID;
		ModelID = MustGet("Model").ID;
		PantsID = MustGet("Pants").ID;
		PlaceID = MustGet("Place").ID;
		ShirtID = MustGet("Shirt").ID;
		TeeShirtID = MustGet("T-Shirt").ID;
		TextID = MustGet("Text").ID;
		HeadID = MustGet("Head").ID;
		FaceID = MustGet("Face").ID;
		GearID = MustGet("Gear").ID;
		BadgeID = MustGet("Badge").ID;
		AnimationID = MustGet("Animation").ID;
		ArmsID = MustGet("Arms").ID;
		RightArmID = MustGet("Right Arm").ID;
		LeftArmID = MustGet("Left Arm").ID;
		LegsID = MustGet("Legs").ID;
		RightLegID = MustGet("Right Leg").ID;
		LeftLegID = MustGet("Left Leg").ID;
		TorsoID = MustGet("Torso").ID;
		PackageID = MustGet("Package").ID;
		YouTubeVideoID = MustGet("YouTubeVideo").ID;
		GamePassID = MustGet("Game Pass").ID;
		AppID = MustGet("App").ID;
		CodeID = MustGet("Code").ID;
		PluginID = MustGet("Plugin").ID;
		SolidModelID = MustGet("SolidModel").ID;
		ClimbAnimationID = MustGet("Climb Animation").ID;
		DeathAnimationID = MustGet("Death Animation").ID;
		FallAnimationID = MustGet("Fall Animation").ID;
		IdleAnimationID = MustGet("Idle Animation").ID;
		JumpAnimationID = MustGet("Jump Animation").ID;
		RunAnimationID = MustGet("Run Animation").ID;
		SwimAnimationID = MustGet("Swim Animation").ID;
		WalkAnimationID = MustGet("Walk Animation").ID;
		PoseAnimationID = MustGet("Pose Animation").ID;
		LocalizationTableManifestID = MustGet("LocalizationTableManifest").ID;
		LocalizationTableTranslationID = MustGet("LocalizationTableTranslation").ID;
		EmoteAnimationID = MustGet("Emote Animation").ID;
		VideoID = MustGet("Video").ID;
		TexturePackID = MustGet("TexturePack").ID;
		_AssetIdLookup = new Dictionary<string, int>
		{
			{ "Audio", AudioID },
			{ "Avatar", AvatarID },
			{ "Decal", DecalID },
			{ "Hat", HatID },
			{ "Hair Accessory", HairAccessoryID },
			{ "Face Accessory", FaceAccessoryID },
			{ "Neck Accessory", NeckAccessoryID },
			{ "Shoulder Accessory", ShoulderAccessoryID },
			{ "Front Accessory", FrontAccessoryID },
			{ "Back Accessory", BackAccessoryID },
			{ "Waist Accessory", WaistAccessoryID },
			{ "HTML", HtmlID },
			{ "Image", ImageID },
			{ "Lua", LuaID },
			{ "Mesh", MeshID },
			{ "MeshPart", MeshPartID },
			{ "Model", ModelID },
			{ "Pants", PantsID },
			{ "Place", PlaceID },
			{ "Shirt", ShirtID },
			{ "T-Shirt", TeeShirtID },
			{ "Text", TextID },
			{ "Head", HeadID },
			{ "Face", FaceID },
			{ "Gear", GearID },
			{ "Badge", BadgeID },
			{ "Animation", AnimationID },
			{ "Arms", ArmsID },
			{ "Right Arm", RightArmID },
			{ "Left Arm", LeftArmID },
			{ "Legs", LegsID },
			{ "Right Leg", RightLegID },
			{ "Left Leg", LeftLegID },
			{ "Torso", TorsoID },
			{ "Package", PackageID },
			{ "YouTubeVideo", YouTubeVideoID },
			{ "Game Pass", GamePassID },
			{ "App", AppID },
			{ "Code", CodeID },
			{ "Plugin", PluginID },
			{ "SolidModel", SolidModelID },
			{ "Climb Animation", ClimbAnimationID },
			{ "Death Animation", DeathAnimationID },
			{ "Fall Animation", FallAnimationID },
			{ "Idle Animation", IdleAnimationID },
			{ "Jump Animation", JumpAnimationID },
			{ "Run Animation", RunAnimationID },
			{ "Swim Animation", SwimAnimationID },
			{ "Walk Animation", WalkAnimationID },
			{ "Pose Animation", PoseAnimationID },
			{ "LocalizationTableManifest", LocalizationTableManifestID },
			{ "LocalizationTableTranslation", LocalizationTableTranslationID },
			{ "Emote Animation", EmoteAnimationID },
			{ "Video", VideoID },
			{ "TexturePack", TexturePackID }
		};
		_PubliclyPurchasableAssetTypeIds = new HashSet<int>
		{
			DecalID, ModelID, PlaceID, HeadID, FaceID, HatID, HairAccessoryID, FaceAccessoryID, NeckAccessoryID, ShoulderAccessoryID,
			FrontAccessoryID, BackAccessoryID, WaistAccessoryID, TeeShirtID, ShirtID, PantsID, GearID, GamePassID, PackageID, AudioID,
			ClimbAnimationID, DeathAnimationID, FallAnimationID, IdleAnimationID, JumpAnimationID, RunAnimationID, SwimAnimationID, WalkAnimationID, PoseAnimationID, EmoteAnimationID
		};
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	/// <summary>
	/// Return true if the Asset is publically purchaseable
	/// </summary>
	/// <returns></returns>
	public bool isPurchaseable()
	{
		return _PubliclyPurchasableAssetTypeIds.Contains(ID);
	}

	public bool isCreateable()
	{
		if (ID != PantsID && ID != ShirtID && ID != TeeShirtID && ID != GamePassID)
		{
			return ID == AudioID;
		}
		return true;
	}

	public bool IsPackageAssetType()
	{
		return ID == PackageID;
	}

	private static AssetType MustGet(string assetTypeValue)
	{
		AssetType assetType = Get(assetTypeValue);
		if (assetType != null)
		{
			return assetType;
		}
		throw new DataIntegrityException($"Failed to load AssetType {assetTypeValue}.");
	}

	public static AssetType Get(int id)
	{
		return EntityHelper.GetEntity<int, AssetTypeDAL, AssetType>(EntityCacheInfo, id, () => AssetTypeDAL.Get(id));
	}

	public static AssetType Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AssetType Get(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, AssetTypeDAL, AssetType>(EntityCacheInfo, "Value:" + value, () => AssetTypeDAL.Get(value));
	}

	public static IEnumerable<AssetType> GetAssetTypes()
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetAssetTypes", AssetTypeDAL.GetAssetTypeIDs, Get);
	}

	/// <summary>
	/// This converts the assetType.Value field to plural - not the enum value.
	/// </summary>
	public static string GetValuePluralized(string value)
	{
		switch (value)
		{
		case "Audio":
		case "HTML":
		case "Lua":
		case "Pants":
		case "Gear":
		case "Legs":
		case "Arms":
		case "Text":
			return value;
		case "Mesh":
		case "Game Pass":
			return value + "es";
		case "All":
			return "All";
		case "Hair Accessory":
			return "Hair Accessories";
		case "Face Accessory":
			return "Face Accessories";
		case "Neck Accessory":
			return "Neck Accessories";
		case "Shoulder Accessory":
			return "Shoulder Accessories";
		case "Front Accessory":
			return "Front Accessories";
		case "Back Accessory":
			return "Back Accessories";
		case "Waist Accessory":
			return "Waist Accessories";
		default:
			return value + "s";
		}
	}

	public static AssetType Register(string value, string description, bool requiresReview)
	{
		AssetType assetType;
		if (AssetTypeDAL.Get(value) != null)
		{
			assetType = Get(value);
		}
		else
		{
			assetType = new AssetType
			{
				Value = value,
				Description = description,
				RequiresReview = requiresReview
			};
			assetType.Save();
		}
		return assetType;
	}

	public static AssetType GetAssetType(string xml)
	{
		int endOfFirstTagIndex = xml.IndexOf('>');
		if (endOfFirstTagIndex == -1)
		{
			throw new ApplicationException("Invalid XML");
		}
		int indexOfAssetType = xml.Substring(0, endOfFirstTagIndex).ToLower().IndexOf("assettype=");
		if (indexOfAssetType == -1)
		{
			return null;
		}
		indexOfAssetType += 11;
		int endIndex = xml.IndexOf('"', indexOfAssetType);
		return Get(xml.Substring(indexOfAssetType, endIndex - indexOfAssetType));
	}

	public static bool IsPackageAssetType(int typeId)
	{
		return typeId == PackageID;
	}

	public static AssetType MustGet(int id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public static AssetType GetAnimation()
	{
		return MustGet(AnimationID);
	}

	public static AssetType GetApp()
	{
		return MustGet(AppID);
	}

	public static AssetType GetArms()
	{
		return MustGet(ArmsID);
	}

	public static AssetType GetAudio()
	{
		return MustGet(AudioID);
	}

	public static AssetType GetAvatar()
	{
		return MustGet(AvatarID);
	}

	public static AssetType GetBackAccessory()
	{
		return MustGet(BackAccessoryID);
	}

	public static AssetType GetBadge()
	{
		return MustGet(BadgeID);
	}

	public static AssetType GetCode()
	{
		return MustGet(CodeID);
	}

	public static AssetType GetDecal()
	{
		return MustGet(DecalID);
	}

	public static AssetType GetFace()
	{
		return MustGet(FaceID);
	}

	public static AssetType GetFaceAccessory()
	{
		return MustGet(FaceAccessoryID);
	}

	public static AssetType GetFrontAccessory()
	{
		return MustGet(FrontAccessoryID);
	}

	public static AssetType GetGamePass()
	{
		return MustGet(GamePassID);
	}

	public static AssetType GetGear()
	{
		return MustGet(GearID);
	}

	public static AssetType GetHairAccessory()
	{
		return MustGet(HairAccessoryID);
	}

	public static AssetType GetHat()
	{
		return MustGet(HatID);
	}

	public static AssetType GetHead()
	{
		return MustGet(HeadID);
	}

	public static AssetType GetHtml()
	{
		return MustGet(HtmlID);
	}

	public static AssetType GetImage()
	{
		return MustGet(ImageID);
	}

	public static AssetType GetLeftArm()
	{
		return MustGet(LeftArmID);
	}

	public static AssetType GetLeftLeg()
	{
		return MustGet(LeftLegID);
	}

	public static AssetType GetLegs()
	{
		return MustGet(LegsID);
	}

	public static AssetType GetLua()
	{
		return MustGet(LuaID);
	}

	public static AssetType GetMesh()
	{
		return MustGet(MeshID);
	}

	public static AssetType GetMeshPart()
	{
		return MustGet(MeshPartID);
	}

	public static AssetType GetModel()
	{
		return MustGet(ModelID);
	}

	public static AssetType GetNeckAccessory()
	{
		return MustGet(NeckAccessoryID);
	}

	public static AssetType GetPackage()
	{
		return MustGet(PackageID);
	}

	public static AssetType GetPants()
	{
		return MustGet(PantsID);
	}

	public static AssetType GetPlace()
	{
		return MustGet(PlaceID);
	}

	public static AssetType GetPlugin()
	{
		return MustGet(PluginID);
	}

	public static AssetType GetRightArm()
	{
		return MustGet(RightArmID);
	}

	public static AssetType GetRightLeg()
	{
		return MustGet(RightLegID);
	}

	public static AssetType GetShirt()
	{
		return MustGet(ShirtID);
	}

	public static AssetType GetShoulderAccessory()
	{
		return MustGet(ShoulderAccessoryID);
	}

	public static AssetType GetSolidModel()
	{
		return MustGet(SolidModelID);
	}

	public static AssetType GetTeeShirt()
	{
		return MustGet(TeeShirtID);
	}

	public static AssetType GetText()
	{
		return MustGet(TextID);
	}

	public static AssetType GetTorso()
	{
		return MustGet(TorsoID);
	}

	public static AssetType GetWaistAccessory()
	{
		return MustGet(WaistAccessoryID);
	}

	public static AssetType GetYouTubeVideo()
	{
		return MustGet(YouTubeVideoID);
	}

	public static AssetType GetClimbAnimation()
	{
		return MustGet(ClimbAnimationID);
	}

	public static AssetType GetDeathAnimation()
	{
		return MustGet(DeathAnimationID);
	}

	public static AssetType GetFallAnimation()
	{
		return MustGet(FallAnimationID);
	}

	public static AssetType GetIdleAnimation()
	{
		return MustGet(IdleAnimationID);
	}

	public static AssetType GetJumpAnimation()
	{
		return MustGet(JumpAnimationID);
	}

	public static AssetType GetRunAnimation()
	{
		return MustGet(RunAnimationID);
	}

	public static AssetType GetSwimAnimation()
	{
		return MustGet(SwimAnimationID);
	}

	public static AssetType GetWalkAnimation()
	{
		return MustGet(WalkAnimationID);
	}

	public static AssetType GetPoseAnimation()
	{
		return MustGet(PoseAnimationID);
	}

	public static AssetType GetLocalizationTableManifest()
	{
		return MustGet(LocalizationTableManifestID);
	}

	public static AssetType GetLocalizationTableTranslation()
	{
		return MustGet(LocalizationTableTranslationID);
	}

	public static AssetType GetEmoteAnimation()
	{
		return MustGet(EmoteAnimationID);
	}

	public static AssetType GetVideo()
	{
		return MustGet(VideoID);
	}

	public static AssetType GetTexturePack()
	{
		return MustGet(TexturePackID);
	}

	public static AssetType GetCatalogAll()
	{
		return new AssetType
		{
			ID = 0,
			Value = "All"
		};
	}

	public void Construct(AssetTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return "Value:" + Value;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
