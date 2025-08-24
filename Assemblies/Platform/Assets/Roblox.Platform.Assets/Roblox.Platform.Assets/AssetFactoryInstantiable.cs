using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Roblox.Agents;
using Roblox.Platform.Assets.Entities;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

internal class AssetFactoryInstantiable : IAssetFactory
{
	private delegate IAsset CreateAssetFromRawContent(IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentifier);

	private delegate IAsset CreateAssetFromStream(IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentifier);

	internal readonly AssetDomainFactories DomainFactories;

	private readonly Dictionary<AssetType, CreateAssetFromRawContent> _Creators = new Dictionary<AssetType, CreateAssetFromRawContent>();

	private readonly Dictionary<AssetType, CreateAssetFromStream> _CreatorsFromStream = new Dictionary<AssetType, CreateAssetFromStream>();

	private readonly Dictionary<AssetType, Func<IAsset, IAsset>> _Getters = new Dictionary<AssetType, Func<IAsset, IAsset>>();

	internal virtual void InitializeCreatorsAndFactories()
	{
		_Creators.Add(AssetType.Animation, DomainFactories.AnimationFactory.Create);
		_Creators.Add(AssetType.Arms, DomainFactories.ArmsFactory.Create);
		_Creators.Add(AssetType.Audio, DomainFactories.AudioFactory.Create);
		_Creators.Add(AssetType.BackAccessory, DomainFactories.BackAccessoryFactory.Create);
		_Creators.Add(AssetType.Badge, DomainFactories.BadgeFactory.Create);
		_Creators.Add(AssetType.FaceAccessory, DomainFactories.FaceAccessoryFactory.Create);
		_Creators.Add(AssetType.Face, DomainFactories.FaceFactory.Create);
		_Creators.Add(AssetType.FrontAccessory, DomainFactories.FrontAccessoryFactory.Create);
		_Creators.Add(AssetType.Gear, DomainFactories.GearFactory.Create);
		_Creators.Add(AssetType.HairAccessory, DomainFactories.HairAccessoryFactory.Create);
		_Creators.Add(AssetType.Hat, DomainFactories.HatFactory.Create);
		_Creators.Add(AssetType.Head, DomainFactories.HeadFactory.Create);
		_Creators.Add(AssetType.HTML, DomainFactories.HtmlFactory.Create);
		_Creators.Add(AssetType.Image, DomainFactories.ImageFactory.Create);
		_Creators.Add(AssetType.LeftArm, DomainFactories.LeftArmFactory.Create);
		_Creators.Add(AssetType.LeftLeg, DomainFactories.LeftLegFactory.Create);
		_Creators.Add(AssetType.Legs, DomainFactories.LegsFactory.Create);
		_Creators.Add(AssetType.Lua, DomainFactories.LuaFactory.Create);
		_Creators.Add(AssetType.Mesh, DomainFactories.MeshFactory.Create);
		_Creators.Add(AssetType.MeshPart, DomainFactories.MeshPartFactory.Create);
		_Creators.Add(AssetType.Model, DomainFactories.ModelFactory.Create);
		_Creators.Add(AssetType.NeckAccessory, DomainFactories.NeckAccessoryFactory.Create);
		_Creators.Add(AssetType.Package, DomainFactories.PackageFactory.Create);
		_Creators.Add(AssetType.TexturePack, DomainFactories.TexturePackFactory.Create);
		_Creators.Add(AssetType.Place, DomainFactories.PlaceFactory.Create);
		_Creators.Add(AssetType.Plugin, DomainFactories.PluginFactory.Create);
		_Creators.Add(AssetType.RightArm, DomainFactories.RightArmFactory.Create);
		_Creators.Add(AssetType.RightLeg, DomainFactories.RightLegFactory.Create);
		_Creators.Add(AssetType.ShoulderAccessory, DomainFactories.ShoulderAccessoryFactory.Create);
		_Creators.Add(AssetType.SolidModel, DomainFactories.SolidModelFactory.Create);
		_Creators.Add(AssetType.Text, DomainFactories.TextFactory.Create);
		_Creators.Add(AssetType.Torso, DomainFactories.TorsoFactory.Create);
		_Creators.Add(AssetType.Video, DomainFactories.VideoFactory.Create);
		_Creators.Add(AssetType.WaistAccessory, DomainFactories.WaistAccessoryFactory.Create);
		_Creators.Add(AssetType.ClimbAnimation, DomainFactories.ClimbAnimationFactory.Create);
		_Creators.Add(AssetType.DeathAnimation, DomainFactories.DeathAnimationFactory.Create);
		_Creators.Add(AssetType.FallAnimation, DomainFactories.FallAnimationFactory.Create);
		_Creators.Add(AssetType.IdleAnimation, DomainFactories.IdleAnimationFactory.Create);
		_Creators.Add(AssetType.JumpAnimation, DomainFactories.JumpAnimationFactory.Create);
		_Creators.Add(AssetType.RunAnimation, DomainFactories.RunAnimationFactory.Create);
		_Creators.Add(AssetType.SwimAnimation, DomainFactories.SwimAnimationFactory.Create);
		_Creators.Add(AssetType.WalkAnimation, DomainFactories.WalkAnimationFactory.Create);
		_Creators.Add(AssetType.PoseAnimation, DomainFactories.PoseAnimationFactory.Create);
		_Creators.Add(AssetType.EmoteAnimation, DomainFactories.EmoteAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.Animation, DomainFactories.AnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.Arms, DomainFactories.ArmsFactory.Create);
		_CreatorsFromStream.Add(AssetType.Audio, DomainFactories.AudioFactory.Create);
		_CreatorsFromStream.Add(AssetType.BackAccessory, DomainFactories.BackAccessoryFactory.Create);
		_CreatorsFromStream.Add(AssetType.Badge, DomainFactories.BadgeFactory.Create);
		_CreatorsFromStream.Add(AssetType.Face, DomainFactories.FaceFactory.Create);
		_CreatorsFromStream.Add(AssetType.FaceAccessory, DomainFactories.FaceAccessoryFactory.Create);
		_CreatorsFromStream.Add(AssetType.FrontAccessory, DomainFactories.FrontAccessoryFactory.Create);
		_CreatorsFromStream.Add(AssetType.Gear, DomainFactories.GearFactory.Create);
		_CreatorsFromStream.Add(AssetType.HairAccessory, DomainFactories.HairAccessoryFactory.Create);
		_CreatorsFromStream.Add(AssetType.Hat, DomainFactories.HatFactory.Create);
		_CreatorsFromStream.Add(AssetType.Head, DomainFactories.HeadFactory.Create);
		_CreatorsFromStream.Add(AssetType.HTML, DomainFactories.HtmlFactory.Create);
		_CreatorsFromStream.Add(AssetType.Image, DomainFactories.ImageFactory.Create);
		_CreatorsFromStream.Add(AssetType.LeftArm, DomainFactories.LeftArmFactory.Create);
		_CreatorsFromStream.Add(AssetType.LeftLeg, DomainFactories.LeftLegFactory.Create);
		_CreatorsFromStream.Add(AssetType.Legs, DomainFactories.LegsFactory.Create);
		_CreatorsFromStream.Add(AssetType.Lua, DomainFactories.LuaFactory.Create);
		_CreatorsFromStream.Add(AssetType.Mesh, DomainFactories.MeshFactory.Create);
		_CreatorsFromStream.Add(AssetType.MeshPart, DomainFactories.MeshPartFactory.Create);
		_CreatorsFromStream.Add(AssetType.Model, DomainFactories.ModelFactory.Create);
		_CreatorsFromStream.Add(AssetType.NeckAccessory, DomainFactories.NeckAccessoryFactory.Create);
		_CreatorsFromStream.Add(AssetType.Package, DomainFactories.PackageFactory.Create);
		_CreatorsFromStream.Add(AssetType.TexturePack, DomainFactories.TexturePackFactory.Create);
		_CreatorsFromStream.Add(AssetType.Place, DomainFactories.PlaceFactory.Create);
		_CreatorsFromStream.Add(AssetType.Plugin, DomainFactories.PluginFactory.Create);
		_CreatorsFromStream.Add(AssetType.RightArm, DomainFactories.RightArmFactory.Create);
		_CreatorsFromStream.Add(AssetType.RightLeg, DomainFactories.RightLegFactory.Create);
		_CreatorsFromStream.Add(AssetType.ShoulderAccessory, DomainFactories.ShoulderAccessoryFactory.Create);
		_CreatorsFromStream.Add(AssetType.Text, DomainFactories.TextFactory.Create);
		_CreatorsFromStream.Add(AssetType.Torso, DomainFactories.TorsoFactory.Create);
		_CreatorsFromStream.Add(AssetType.SolidModel, DomainFactories.SolidModelFactory.Create);
		_CreatorsFromStream.Add(AssetType.Video, DomainFactories.VideoFactory.Create);
		_CreatorsFromStream.Add(AssetType.WaistAccessory, DomainFactories.WaistAccessoryFactory.Create);
		_CreatorsFromStream.Add(AssetType.ClimbAnimation, DomainFactories.ClimbAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.DeathAnimation, DomainFactories.DeathAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.FallAnimation, DomainFactories.FallAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.IdleAnimation, DomainFactories.IdleAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.JumpAnimation, DomainFactories.JumpAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.RunAnimation, DomainFactories.RunAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.SwimAnimation, DomainFactories.SwimAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.WalkAnimation, DomainFactories.WalkAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.PoseAnimation, DomainFactories.PoseAnimationFactory.Create);
		_CreatorsFromStream.Add(AssetType.EmoteAnimation, DomainFactories.EmoteAnimationFactory.Create);
		_Getters.Add(AssetType.Animation, DomainFactories.AnimationFactory.GetAnimation);
		_Getters.Add(AssetType.Arms, DomainFactories.ArmsFactory.GetArms);
		_Getters.Add(AssetType.Audio, DomainFactories.AudioFactory.GetAudio);
		_Getters.Add(AssetType.BackAccessory, DomainFactories.BackAccessoryFactory.GetBackAccessory);
		_Getters.Add(AssetType.Badge, DomainFactories.BadgeFactory.GetBadge);
		_Getters.Add(AssetType.Decal, DomainFactories.DecalFactory.GetDecal);
		_Getters.Add(AssetType.Face, DomainFactories.FaceFactory.GetFace);
		_Getters.Add(AssetType.FaceAccessory, DomainFactories.FaceAccessoryFactory.GetFaceAccessory);
		_Getters.Add(AssetType.FrontAccessory, DomainFactories.FrontAccessoryFactory.GetFrontAccessory);
		_Getters.Add(AssetType.GamePass, DomainFactories.GamePassFactory.GetGamePass);
		_Getters.Add(AssetType.Gear, DomainFactories.GearFactory.GetGear);
		_Getters.Add(AssetType.HairAccessory, DomainFactories.HairAccessoryFactory.GetHairAccessory);
		_Getters.Add(AssetType.Hat, DomainFactories.HatFactory.GetHat);
		_Getters.Add(AssetType.Head, DomainFactories.HeadFactory.GetHead);
		_Getters.Add(AssetType.HTML, DomainFactories.HtmlFactory.GetHtml);
		_Getters.Add(AssetType.Image, DomainFactories.ImageFactory.GetImage);
		_Getters.Add(AssetType.LeftArm, DomainFactories.LeftArmFactory.GetLeftArm);
		_Getters.Add(AssetType.LeftLeg, DomainFactories.LeftLegFactory.GetLeftLeg);
		_Getters.Add(AssetType.Legs, DomainFactories.LegsFactory.GetLegs);
		_Getters.Add(AssetType.Lua, DomainFactories.LuaFactory.GetLua);
		_Getters.Add(AssetType.Mesh, DomainFactories.MeshFactory.GetMesh);
		_Getters.Add(AssetType.MeshPart, DomainFactories.MeshPartFactory.GetMeshPart);
		_Getters.Add(AssetType.Model, DomainFactories.ModelFactory.GetModel);
		_Getters.Add(AssetType.NeckAccessory, DomainFactories.NeckAccessoryFactory.GetNeckAccessory);
		_Getters.Add(AssetType.Package, DomainFactories.PackageFactory.GetPackage);
		_Getters.Add(AssetType.Pants, DomainFactories.PantsFactory.GetPants);
		_Getters.Add(AssetType.Place, DomainFactories.PlaceFactory.GetPlace);
		_Getters.Add(AssetType.Plugin, DomainFactories.PluginFactory.GetPlugin);
		_Getters.Add(AssetType.RightArm, DomainFactories.RightArmFactory.GetRightArm);
		_Getters.Add(AssetType.RightLeg, DomainFactories.RightLegFactory.GetRightLeg);
		_Getters.Add(AssetType.Shirt, DomainFactories.ShirtFactory.GetShirt);
		_Getters.Add(AssetType.ShoulderAccessory, DomainFactories.ShoulderAccessoryFactory.GetShoulderAccessory);
		_Getters.Add(AssetType.TShirt, DomainFactories.TeeShirtFactory.GetTeeShirt);
		_Getters.Add(AssetType.Text, DomainFactories.TextFactory.GetText);
		_Getters.Add(AssetType.Torso, DomainFactories.TorsoFactory.GetTorso);
		_Getters.Add(AssetType.SolidModel, DomainFactories.SolidModelFactory.GetSolidModel);
		_Getters.Add(AssetType.WaistAccessory, DomainFactories.WaistAccessoryFactory.GetWaistAccessory);
		_Getters.Add(AssetType.YouTubeVideo, DomainFactories.YouTubeVideoFactory.GetYouTubeVideo);
		_Getters.Add(AssetType.ClimbAnimation, DomainFactories.ClimbAnimationFactory.GetClimbAnimation);
		_Getters.Add(AssetType.DeathAnimation, DomainFactories.DeathAnimationFactory.GetDeathAnimation);
		_Getters.Add(AssetType.FallAnimation, DomainFactories.FallAnimationFactory.GetFallAnimation);
		_Getters.Add(AssetType.IdleAnimation, DomainFactories.IdleAnimationFactory.GetIdleAnimation);
		_Getters.Add(AssetType.JumpAnimation, DomainFactories.JumpAnimationFactory.GetJumpAnimation);
		_Getters.Add(AssetType.RunAnimation, DomainFactories.RunAnimationFactory.GetRunAnimation);
		_Getters.Add(AssetType.SwimAnimation, DomainFactories.SwimAnimationFactory.GetSwimAnimation);
		_Getters.Add(AssetType.WalkAnimation, DomainFactories.WalkAnimationFactory.GetWalkAnimation);
		_Getters.Add(AssetType.PoseAnimation, DomainFactories.PoseAnimationFactory.GetPoseAnimation);
		_Getters.Add(AssetType.LocalizationTableManifest, DomainFactories.LocalizationTableManifestFactory.GetLocalizationTableManifest);
		_Getters.Add(AssetType.LocalizationTableTranslation, DomainFactories.LocalizationTableTranslationFactory.GetLocalizationTableTranslation);
		_Getters.Add(AssetType.EmoteAnimation, DomainFactories.EmoteAnimationFactory.GetEmoteAnimation);
		_Getters.Add(AssetType.Video, DomainFactories.VideoFactory.GetVideo);
		_Getters.Add(AssetType.TexturePack, DomainFactories.TexturePackFactory.GetTexturePack);
	}

	public AssetFactoryInstantiable(AssetDomainFactories domainFactories)
	{
		DomainFactories = domainFactories;
		InitializeCreatorsAndFactories();
	}

	internal IAsset GetAsset(IAsset genericAsset)
	{
		if (genericAsset == null)
		{
			return null;
		}
		int assetTypeId = genericAsset.TypeId;
		AssetType assetType = MustGetAssetType(assetTypeId);
		return (_Getters[assetType] ?? throw new ApplicationException("Invalid AssetTypeId: " + assetTypeId))(genericAsset);
	}

	internal IAsset GetGenericAsset(long? id)
	{
		Roblox.Asset assetEntity = Roblox.Asset.Get(id);
		return GetGenericAsset(assetEntity);
	}

	internal IEnumerable<IAsset> GetGenericAssets(IReadOnlyCollection<long> ids)
	{
		return Roblox.Asset.MultiGet(ids).Select(GetGenericAsset);
	}

	internal IAsset GetGenericAsset(Roblox.Asset assetEntity)
	{
		if (assetEntity == null)
		{
			return null;
		}
		IAgent agent = AgentFactory.MustGet(assetEntity.CreatorID);
		CreatorType creatorType = agent.AgentType.ToCreatorType();
		long creatorTargetId = agent.AgentTargetId;
		return new GenericAsset(DomainFactories, assetEntity.ID, assetEntity.AssetTypeID, assetEntity.Name, assetEntity.Description, creatorType, creatorTargetId, assetEntity.AssetGenres, assetEntity.IsArchived, assetEntity.Created, assetEntity.Updated);
	}

	internal IAsset GetGenericAsset(IAssetEntity entity, AssetCreatorInfo assetCreatorInfo)
	{
		return new GenericAsset(DomainFactories, entity.Id, entity.TypeId, entity.Name, entity.Description, assetCreatorInfo.CreatorType, assetCreatorInfo.CreatorTargetId, entity.AssetGenres, entity.IsArchived, entity.Created, entity.Updated);
	}

	[Obsolete("Universal Asset creation is deprecated and can lead to runtime failures.  This function will throw for numerous AssetTypes, because more information is required.  Choose a type-specific creation method instead.")]
	public virtual IAsset Create(int assetTypeId, IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity)
	{
		CreateAssetFromStream createFunction = null;
		AssetType assetType = MustGetAssetType(assetTypeId);
		if (!_CreatorsFromStream.TryGetValue(assetType, out createFunction))
		{
			throw new PlatformException("Cannot generically create Assets of type: " + assetTypeId + ".  Generic Asset creation is deprecated.  Choose a type-specific creation method instead.");
		}
		return createFunction(assetNameAndDescription, assetCreatorInfo, stream, actorUserIdentity);
	}

	[Obsolete("Universal Asset creation is deprecated and can lead to runtime failures. This function will throw for numerous AssetTypes, because more information is required.  Choose a type-specific creation method instead.")]
	public virtual IAsset Create(int assetTypeId, IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentity)
	{
		CreateAssetFromRawContent createFunction = null;
		AssetType assetType = MustGetAssetType(assetTypeId);
		if (!_Creators.TryGetValue(assetType, out createFunction))
		{
			throw new PlatformException("Cannot generically create Assets of type: " + assetTypeId + ".  Generic Asset creation is deprecated.  Choose a type-specific creation method instead.");
		}
		return createFunction(assetNameAndDescription, assetCreatorInfo, rawContent, actorUserIdentity);
	}

	private AssetType MustGetAssetType(int assetTypeId)
	{
		AssetType? assetType = DomainFactories.AssetTypeFactory.GetAssetType(assetTypeId);
		if (!assetType.HasValue)
		{
			throw new PlatformException("Invalid AssetTypeId: " + assetTypeId);
		}
		return assetType.Value;
	}

	public virtual IAsset CheckedGetAsset(long? id)
	{
		IAsset asset = GetAsset(id);
		asset.VerifyIsNotNull();
		return asset;
	}

	internal IAsset GetAsset(long id)
	{
		IAsset genericAsset = GetGenericAsset(id);
		return GetAsset(genericAsset);
	}

	public virtual IAsset GetAsset(long? id)
	{
		if (!id.HasValue)
		{
			return null;
		}
		return GetAsset(id.Value);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Assets.IAssetFactory.GetAssets(System.Collections.Generic.IReadOnlyCollection{System.Int64})" />
	public IEnumerable<IAsset> GetAssets(IReadOnlyCollection<long> ids)
	{
		if (ids == null)
		{
			throw new ArgumentNullException("ids");
		}
		if (!ids.Any())
		{
			throw new ArgumentException(string.Format("{0} is empty.", "ids"), "ids");
		}
		return GetGenericAssets(ids).Select(GetAsset);
	}

	public virtual IEnumerable<IAsset> GetAssetsByCreationScope(ICreationScope creationScope, long? creatingUniverseId, long offset, long count)
	{
		CreationContext creationContextEntity = CreationContext.GetByContextTypeIdCreatorTypeIdCreatorTargetIdAssetTypeIdAndUniverseId((byte)creationScope.CreationContextType, (byte)creationScope.CreatorType, creationScope.CreatorTargetId, creationScope.AssetTypeId, creatingUniverseId);
		if (creationContextEntity == null)
		{
			yield break;
		}
		IEnumerable<IAsset> createdAssets = (from ce in Creation.GetCreationsByCreationContextIdPaged(creationContextEntity.ID, offset, count)
			select ce.AssetId).Select(GetAsset);
		foreach (IAsset item in createdAssets)
		{
			yield return item;
		}
	}

	public Roblox.IAsset GetAssociatedImageAsset(Roblox.IAsset asset)
	{
		if (asset == null)
		{
			return null;
		}
		if (asset.Type.ID == Roblox.AssetType.ImageID)
		{
			return asset;
		}
		if (asset.Type.ID == Roblox.AssetType.BadgeID)
		{
			throw new NotImplementedException("Badges as assets are obsolete. Please do not add a lookup here for legacy badge assets.");
		}
		if (asset.Type.ID == Roblox.AssetType.GamePassID)
		{
			return Roblox.Asset.Get(PlaceGamePass.GetPlaceGamePassesByPassID(asset.CurrentVersion.AssetID, 1, 1).First().ImageID);
		}
		try
		{
			return GetDecalOrClothesImageAsset(asset);
		}
		catch (XmlException)
		{
			return asset;
		}
	}

	public long? GetDecalOrClothingImageAssetId(string assetHash)
	{
		XmlDocument fileXml = FilesManager.Singleton.GetFileXml(assetHash);
		return GetDecalOrClothingImageAssetId(fileXml);
	}

	internal long? GetDecalOrClothingImageAssetId(XmlDocument fileXml)
	{
		XmlNode node = null;
		foreach (XmlNode child in fileXml.ChildNodes)
		{
			if (child.Name != "roblox")
			{
				continue;
			}
			foreach (XmlNode item in child.ChildNodes)
			{
				if (!(item.Name != "Item") && (item.Attributes["class"].Value == "Decal" || item.Attributes["class"].Value == "Shirt" || item.Attributes["class"].Value == "ShirtGraphic" || item.Attributes["class"].Value == "Pants"))
				{
					node = item;
				}
			}
		}
		if (node != null)
		{
			foreach (XmlNode props in node.ChildNodes)
			{
				if (props.Name != "Properties")
				{
					continue;
				}
				foreach (XmlNode prop in props.ChildNodes)
				{
					if (prop.Attributes["name"].Value == "ShirtTemplate" || prop.Attributes["name"].Value == "Texture" || prop.Attributes["name"].Value == "Graphic" || prop.Attributes["name"].Value == "PantsTemplate")
					{
						node = prop;
					}
				}
			}
		}
		if (node == null || !node.HasChildNodes)
		{
			return null;
		}
		node = node.ChildNodes[0];
		if (!(node.Name == "url"))
		{
			return null;
		}
		return QueryStringAssetParameterParser.ParseAssetIdFromQueryString(new Uri(node.InnerText), throwIfBadUrl: true);
	}

	private Roblox.IAsset GetDecalOrClothesImageAsset(Roblox.IAsset asset)
	{
		XmlDocument fileXml = FilesManager.Singleton.GetFileXml(asset.Hash);
		XmlNode node = null;
		foreach (XmlNode child in fileXml.ChildNodes)
		{
			if (child.Name != "roblox")
			{
				continue;
			}
			foreach (XmlNode item in child.ChildNodes)
			{
				if (!(item.Name != "Item") && (item.Attributes["class"].Value == "Decal" || item.Attributes["class"].Value == "Shirt" || item.Attributes["class"].Value == "ShirtGraphic" || item.Attributes["class"].Value == "Pants"))
				{
					node = item;
				}
			}
		}
		if (node != null)
		{
			foreach (XmlNode props in node.ChildNodes)
			{
				if (props.Name != "Properties")
				{
					continue;
				}
				foreach (XmlNode prop in props.ChildNodes)
				{
					if (prop.Attributes["name"].Value == "Texture" || prop.Attributes["name"].Value == "Graphic" || prop.Attributes["name"].Value == "PantsTemplate" || prop.Attributes["name"].Value == "ShirtTemplate")
					{
						node = prop;
					}
				}
			}
		}
		if (node == null || !node.HasChildNodes)
		{
			return null;
		}
		node = node.ChildNodes[0];
		if (!(node.Name == "url"))
		{
			return null;
		}
		return QueryStringAssetParameterParser.ParseAssetFromQuerystring(new Uri(node.InnerText), throwIfBadUrl: false);
	}
}
