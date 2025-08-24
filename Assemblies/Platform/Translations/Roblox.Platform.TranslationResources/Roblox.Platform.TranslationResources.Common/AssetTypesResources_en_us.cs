using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class AssetTypesResources_en_us : TranslationResourcesBase, IAssetTypesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.Accessories"
	/// English String: "Accessories"
	/// </summary>
	public virtual string LabelAccessories => "Accessories";

	/// <summary>
	/// Key: "Label.Accessory"
	/// Accessory asset group, in singular form
	/// English String: "Accessory"
	/// </summary>
	public virtual string LabelAccessory => "Accessory";

	/// <summary>
	/// Key: "Label.Animation"
	/// Asset type Animation, singular form
	/// English String: "Animation"
	/// </summary>
	public virtual string LabelAnimation => "Animation";

	/// <summary>
	/// Key: "Label.Animations"
	/// English String: "Animations"
	/// </summary>
	public virtual string LabelAnimations => "Animations";

	/// <summary>
	/// Key: "Label.Audio"
	/// English String: "Audio"
	/// </summary>
	public virtual string LabelAudio => "Audio";

	/// <summary>
	/// Key: "Label.AvatarAnimations"
	/// Avatar Animations allow the user to have their character or avatar move differently within the game.
	/// English String: "Avatar Animations"
	/// </summary>
	public virtual string LabelAvatarAnimations => "Avatar Animations";

	/// <summary>
	/// Key: "Label.Back"
	/// This is the back of a person. The user has an avatar which has a back.
	/// English String: "Back"
	/// </summary>
	public virtual string LabelBack => "Back";

	/// <summary>
	/// Key: "Label.BackAccessory"
	/// English String: "Back Accessory"
	/// </summary>
	public virtual string LabelBackAccessory => "Back Accessory";

	/// <summary>
	/// Key: "Label.Badge"
	/// Asset type Badge, singular form
	/// English String: "Badge"
	/// </summary>
	public virtual string LabelBadge => "Badge";

	/// <summary>
	/// Key: "Label.Badges"
	/// English String: "Badges"
	/// </summary>
	public virtual string LabelBadges => "Badges";

	/// <summary>
	/// Key: "Label.Climb"
	/// English String: "Climb"
	/// </summary>
	public virtual string LabelClimb => "Climb";

	/// <summary>
	/// Key: "Label.Death"
	/// English String: "Death"
	/// </summary>
	public virtual string LabelDeath => "Death";

	/// <summary>
	/// Key: "Label.Decal"
	/// Asset type Decal, singular form
	/// English String: "Decal"
	/// </summary>
	public virtual string LabelDecal => "Decal";

	/// <summary>
	/// Key: "Label.Decals"
	/// English String: "Decals"
	/// </summary>
	public virtual string LabelDecals => "Decals";

	/// <summary>
	/// Key: "Label.Emote"
	/// Asset type Emote, singular form
	/// English String: "Emote"
	/// </summary>
	public virtual string LabelEmote => "Emote";

	/// <summary>
	/// Key: "Label.Emotes"
	/// Asset type Emote, plural form
	/// English String: "Emotes"
	/// </summary>
	public virtual string LabelEmotes => "Emotes";

	/// <summary>
	/// Key: "Label.Face"
	/// English String: "Face"
	/// </summary>
	public virtual string LabelFace => "Face";

	/// <summary>
	/// Key: "Label.FaceAccessory"
	/// English String: "Face Accessory"
	/// </summary>
	public virtual string LabelFaceAccessory => "Face Accessory";

	/// <summary>
	/// Key: "Label.Faces"
	/// English String: "Faces"
	/// </summary>
	public virtual string LabelFaces => "Faces";

	/// <summary>
	/// Key: "Label.Fall"
	/// English String: "Fall"
	/// </summary>
	public virtual string LabelFall => "Fall";

	/// <summary>
	/// Key: "Label.Front"
	/// This is the front of a person. The user has an avatar which has a front.
	/// English String: "Front"
	/// </summary>
	public virtual string LabelFront => "Front";

	/// <summary>
	/// Key: "Label.FrontAccessory"
	/// English String: "Front Accessory"
	/// </summary>
	public virtual string LabelFrontAccessory => "Front Accessory";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public virtual string LabelGame => "Game";

	/// <summary>
	/// Key: "Label.GamePass"
	/// Asset type Game Pass, singular form
	/// English String: "Game Pass"
	/// </summary>
	public virtual string LabelGamePass => "Game Pass";

	/// <summary>
	/// Key: "Label.GamePasses"
	/// English String: "Game Passes"
	/// </summary>
	public virtual string LabelGamePasses => "Game Passes";

	/// <summary>
	/// Key: "Label.Gear"
	/// English String: "Gear"
	/// </summary>
	public virtual string LabelGear => "Gear";

	/// <summary>
	/// Key: "Label.Hair"
	/// English String: "Hair"
	/// </summary>
	public virtual string LabelHair => "Hair";

	/// <summary>
	/// Key: "Label.HairAccessory"
	/// English String: "Hair Accessory"
	/// </summary>
	public virtual string LabelHairAccessory => "Hair Accessory";

	/// <summary>
	/// Key: "Label.Hat"
	/// English String: "Hat"
	/// </summary>
	public virtual string LabelHat => "Hat";

	/// <summary>
	/// Key: "Label.Hats"
	/// English String: "Hats"
	/// </summary>
	public virtual string LabelHats => "Hats";

	/// <summary>
	/// Key: "Label.Head"
	/// Asset type Head, singular form
	/// English String: "Head"
	/// </summary>
	public virtual string LabelHead => "Head";

	/// <summary>
	/// Key: "Label.Heads"
	/// English String: "Heads"
	/// </summary>
	public virtual string LabelHeads => "Heads";

	/// <summary>
	/// Key: "Label.Idle"
	/// English String: "Idle"
	/// </summary>
	public virtual string LabelIdle => "Idle";

	/// <summary>
	/// Key: "Label.Image"
	/// Asset type Image, singular form
	/// English String: "Image"
	/// </summary>
	public virtual string LabelImage => "Image";

	/// <summary>
	/// Key: "Label.Jump"
	/// English String: "Jump"
	/// </summary>
	public virtual string LabelJump => "Jump";

	/// <summary>
	/// Key: "Label.LeftArm"
	/// Asset type Left Arm, singular form
	/// English String: "Left Arm"
	/// </summary>
	public virtual string LabelLeftArm => "Left Arm";

	/// <summary>
	/// Key: "Label.LeftLeg"
	/// Asset type Left Leg, singular form
	/// English String: "Left Leg"
	/// </summary>
	public virtual string LabelLeftLeg => "Left Leg";

	/// <summary>
	/// Key: "Label.Mesh"
	/// Asset type mesh, singular form
	/// English String: "Mesh"
	/// </summary>
	public virtual string LabelMesh => "Mesh";

	/// <summary>
	/// Key: "Label.Meshes"
	/// English String: "Meshes"
	/// </summary>
	public virtual string LabelMeshes => "Meshes";

	/// <summary>
	/// Key: "Label.MeshPart"
	/// Asset type Mesh Part, singular form
	/// English String: "Mesh Part"
	/// </summary>
	public virtual string LabelMeshPart => "Mesh Part";

	/// <summary>
	/// Key: "Label.Model"
	/// Asset type Model, singular form
	/// English String: "Model"
	/// </summary>
	public virtual string LabelModel => "Model";

	/// <summary>
	/// Key: "Label.Models"
	/// English String: "Models"
	/// </summary>
	public virtual string LabelModels => "Models";

	/// <summary>
	/// Key: "Label.Neck"
	/// English String: "Neck"
	/// </summary>
	public virtual string LabelNeck => "Neck";

	/// <summary>
	/// Key: "Label.NeckAccessory"
	/// English String: "Neck Accessory"
	/// </summary>
	public virtual string LabelNeckAccessory => "Neck Accessory";

	/// <summary>
	/// Key: "Label.Package"
	/// Asset type Package, singular form
	/// English String: "Package"
	/// </summary>
	public virtual string LabelPackage => "Package";

	/// <summary>
	/// Key: "Label.Packages"
	/// English String: "Packages"
	/// </summary>
	public virtual string LabelPackages => "Packages";

	/// <summary>
	/// Key: "Label.Pants"
	/// English String: "Pants"
	/// </summary>
	public virtual string LabelPants => "Pants";

	/// <summary>
	/// Key: "Label.Place"
	/// Asset type Place, singular form
	/// English String: "Place"
	/// </summary>
	public virtual string LabelPlace => "Place";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public virtual string LabelPlaces => "Places";

	/// <summary>
	/// Key: "Label.Plugin"
	/// Asset type Plugin, singular form
	/// English String: "Plugin"
	/// </summary>
	public virtual string LabelPlugin => "Plugin";

	/// <summary>
	/// Key: "Label.Plugins"
	/// English String: "Plugins"
	/// </summary>
	public virtual string LabelPlugins => "Plugins";

	/// <summary>
	/// Key: "Label.Pose"
	/// English String: "Pose"
	/// </summary>
	public virtual string LabelPose => "Pose";

	/// <summary>
	/// Key: "Label.RightArm"
	/// Asset type Right Arm, singular form
	/// English String: "Right Arm"
	/// </summary>
	public virtual string LabelRightArm => "Right Arm";

	/// <summary>
	/// Key: "Label.RightLeg"
	/// Asset type Right Leg, singular form
	/// English String: "Right Leg"
	/// </summary>
	public virtual string LabelRightLeg => "Right Leg";

	/// <summary>
	/// Key: "Label.Run"
	/// English String: "Run"
	/// </summary>
	public virtual string LabelRun => "Run";

	/// <summary>
	/// Key: "Label.Shirt"
	/// Asset type Shirt, singular form
	/// English String: "Shirt"
	/// </summary>
	public virtual string LabelShirt => "Shirt";

	/// <summary>
	/// Key: "Label.Shirts"
	/// English String: "Shirts"
	/// </summary>
	public virtual string LabelShirts => "Shirts";

	/// <summary>
	/// Key: "Label.Shoulder"
	/// English String: "Shoulder"
	/// </summary>
	public virtual string LabelShoulder => "Shoulder";

	/// <summary>
	/// Key: "Label.ShoulderAccessory"
	/// English String: "Shoulder Accessory"
	/// </summary>
	public virtual string LabelShoulderAccessory => "Shoulder Accessory";

	/// <summary>
	/// Key: "Label.Shoulders"
	/// English String: "Shoulders"
	/// </summary>
	public virtual string LabelShoulders => "Shoulders";

	/// <summary>
	/// Key: "Label.SolidModel"
	/// Asset type Solid Model, singular
	/// English String: "Solid Model"
	/// </summary>
	public virtual string LabelSolidModel => "Solid Model";

	/// <summary>
	/// Key: "Label.Swim"
	/// English String: "Swim"
	/// </summary>
	public virtual string LabelSwim => "Swim";

	/// <summary>
	/// Key: "Label.Torso"
	/// Asset type Torso, singular form
	/// English String: "Torso"
	/// </summary>
	public virtual string LabelTorso => "Torso";

	/// <summary>
	/// Key: "Label.TShirt"
	/// Asset type T-Shirt, singular form
	/// English String: "T-Shirt"
	/// </summary>
	public virtual string LabelTShirt => "T-Shirt";

	/// <summary>
	/// Key: "Label.TShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public virtual string LabelTShirts => "T-Shirts";

	/// <summary>
	/// Key: "Label.VipServers"
	/// VIP servers are private servers which users can create to play only with their friends instead of strangers.
	/// English String: "VIP Servers"
	/// </summary>
	public virtual string LabelVipServers => "VIP Servers";

	/// <summary>
	/// Key: "Label.Waist"
	/// English String: "Waist"
	/// </summary>
	public virtual string LabelWaist => "Waist";

	/// <summary>
	/// Key: "Label.WaistAccessory"
	/// English String: "Waist Accessory"
	/// </summary>
	public virtual string LabelWaistAccessory => "Waist Accessory";

	/// <summary>
	/// Key: "Label.Walk"
	/// English String: "Walk"
	/// </summary>
	public virtual string LabelWalk => "Walk";

	public AssetTypesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.Accessories",
				_GetTemplateForLabelAccessories()
			},
			{
				"Label.Accessory",
				_GetTemplateForLabelAccessory()
			},
			{
				"Label.Animation",
				_GetTemplateForLabelAnimation()
			},
			{
				"Label.Animations",
				_GetTemplateForLabelAnimations()
			},
			{
				"Label.Audio",
				_GetTemplateForLabelAudio()
			},
			{
				"Label.AvatarAnimations",
				_GetTemplateForLabelAvatarAnimations()
			},
			{
				"Label.Back",
				_GetTemplateForLabelBack()
			},
			{
				"Label.BackAccessory",
				_GetTemplateForLabelBackAccessory()
			},
			{
				"Label.Badge",
				_GetTemplateForLabelBadge()
			},
			{
				"Label.Badges",
				_GetTemplateForLabelBadges()
			},
			{
				"Label.Climb",
				_GetTemplateForLabelClimb()
			},
			{
				"Label.Death",
				_GetTemplateForLabelDeath()
			},
			{
				"Label.Decal",
				_GetTemplateForLabelDecal()
			},
			{
				"Label.Decals",
				_GetTemplateForLabelDecals()
			},
			{
				"Label.Emote",
				_GetTemplateForLabelEmote()
			},
			{
				"Label.Emotes",
				_GetTemplateForLabelEmotes()
			},
			{
				"Label.Face",
				_GetTemplateForLabelFace()
			},
			{
				"Label.FaceAccessory",
				_GetTemplateForLabelFaceAccessory()
			},
			{
				"Label.Faces",
				_GetTemplateForLabelFaces()
			},
			{
				"Label.Fall",
				_GetTemplateForLabelFall()
			},
			{
				"Label.Front",
				_GetTemplateForLabelFront()
			},
			{
				"Label.FrontAccessory",
				_GetTemplateForLabelFrontAccessory()
			},
			{
				"Label.Game",
				_GetTemplateForLabelGame()
			},
			{
				"Label.GamePass",
				_GetTemplateForLabelGamePass()
			},
			{
				"Label.GamePasses",
				_GetTemplateForLabelGamePasses()
			},
			{
				"Label.Gear",
				_GetTemplateForLabelGear()
			},
			{
				"Label.Hair",
				_GetTemplateForLabelHair()
			},
			{
				"Label.HairAccessory",
				_GetTemplateForLabelHairAccessory()
			},
			{
				"Label.Hat",
				_GetTemplateForLabelHat()
			},
			{
				"Label.Hats",
				_GetTemplateForLabelHats()
			},
			{
				"Label.Head",
				_GetTemplateForLabelHead()
			},
			{
				"Label.Heads",
				_GetTemplateForLabelHeads()
			},
			{
				"Label.Idle",
				_GetTemplateForLabelIdle()
			},
			{
				"Label.Image",
				_GetTemplateForLabelImage()
			},
			{
				"Label.Jump",
				_GetTemplateForLabelJump()
			},
			{
				"Label.LeftArm",
				_GetTemplateForLabelLeftArm()
			},
			{
				"Label.LeftLeg",
				_GetTemplateForLabelLeftLeg()
			},
			{
				"Label.Mesh",
				_GetTemplateForLabelMesh()
			},
			{
				"Label.Meshes",
				_GetTemplateForLabelMeshes()
			},
			{
				"Label.MeshPart",
				_GetTemplateForLabelMeshPart()
			},
			{
				"Label.Model",
				_GetTemplateForLabelModel()
			},
			{
				"Label.Models",
				_GetTemplateForLabelModels()
			},
			{
				"Label.Neck",
				_GetTemplateForLabelNeck()
			},
			{
				"Label.NeckAccessory",
				_GetTemplateForLabelNeckAccessory()
			},
			{
				"Label.Package",
				_GetTemplateForLabelPackage()
			},
			{
				"Label.Packages",
				_GetTemplateForLabelPackages()
			},
			{
				"Label.Pants",
				_GetTemplateForLabelPants()
			},
			{
				"Label.Place",
				_GetTemplateForLabelPlace()
			},
			{
				"Label.Places",
				_GetTemplateForLabelPlaces()
			},
			{
				"Label.Plugin",
				_GetTemplateForLabelPlugin()
			},
			{
				"Label.Plugins",
				_GetTemplateForLabelPlugins()
			},
			{
				"Label.Pose",
				_GetTemplateForLabelPose()
			},
			{
				"Label.RightArm",
				_GetTemplateForLabelRightArm()
			},
			{
				"Label.RightLeg",
				_GetTemplateForLabelRightLeg()
			},
			{
				"Label.Run",
				_GetTemplateForLabelRun()
			},
			{
				"Label.Shirt",
				_GetTemplateForLabelShirt()
			},
			{
				"Label.Shirts",
				_GetTemplateForLabelShirts()
			},
			{
				"Label.Shoulder",
				_GetTemplateForLabelShoulder()
			},
			{
				"Label.ShoulderAccessory",
				_GetTemplateForLabelShoulderAccessory()
			},
			{
				"Label.Shoulders",
				_GetTemplateForLabelShoulders()
			},
			{
				"Label.SolidModel",
				_GetTemplateForLabelSolidModel()
			},
			{
				"Label.Swim",
				_GetTemplateForLabelSwim()
			},
			{
				"Label.Torso",
				_GetTemplateForLabelTorso()
			},
			{
				"Label.TShirt",
				_GetTemplateForLabelTShirt()
			},
			{
				"Label.TShirts",
				_GetTemplateForLabelTShirts()
			},
			{
				"Label.VipServers",
				_GetTemplateForLabelVipServers()
			},
			{
				"Label.Waist",
				_GetTemplateForLabelWaist()
			},
			{
				"Label.WaistAccessory",
				_GetTemplateForLabelWaistAccessory()
			},
			{
				"Label.Walk",
				_GetTemplateForLabelWalk()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.AssetTypes";
	}

	protected virtual string _GetTemplateForLabelAccessories()
	{
		return "Accessories";
	}

	protected virtual string _GetTemplateForLabelAccessory()
	{
		return "Accessory";
	}

	protected virtual string _GetTemplateForLabelAnimation()
	{
		return "Animation";
	}

	protected virtual string _GetTemplateForLabelAnimations()
	{
		return "Animations";
	}

	protected virtual string _GetTemplateForLabelAudio()
	{
		return "Audio";
	}

	protected virtual string _GetTemplateForLabelAvatarAnimations()
	{
		return "Avatar Animations";
	}

	protected virtual string _GetTemplateForLabelBack()
	{
		return "Back";
	}

	protected virtual string _GetTemplateForLabelBackAccessory()
	{
		return "Back Accessory";
	}

	protected virtual string _GetTemplateForLabelBadge()
	{
		return "Badge";
	}

	protected virtual string _GetTemplateForLabelBadges()
	{
		return "Badges";
	}

	protected virtual string _GetTemplateForLabelClimb()
	{
		return "Climb";
	}

	protected virtual string _GetTemplateForLabelDeath()
	{
		return "Death";
	}

	protected virtual string _GetTemplateForLabelDecal()
	{
		return "Decal";
	}

	protected virtual string _GetTemplateForLabelDecals()
	{
		return "Decals";
	}

	protected virtual string _GetTemplateForLabelEmote()
	{
		return "Emote";
	}

	protected virtual string _GetTemplateForLabelEmotes()
	{
		return "Emotes";
	}

	protected virtual string _GetTemplateForLabelFace()
	{
		return "Face";
	}

	protected virtual string _GetTemplateForLabelFaceAccessory()
	{
		return "Face Accessory";
	}

	protected virtual string _GetTemplateForLabelFaces()
	{
		return "Faces";
	}

	protected virtual string _GetTemplateForLabelFall()
	{
		return "Fall";
	}

	protected virtual string _GetTemplateForLabelFront()
	{
		return "Front";
	}

	protected virtual string _GetTemplateForLabelFrontAccessory()
	{
		return "Front Accessory";
	}

	protected virtual string _GetTemplateForLabelGame()
	{
		return "Game";
	}

	protected virtual string _GetTemplateForLabelGamePass()
	{
		return "Game Pass";
	}

	protected virtual string _GetTemplateForLabelGamePasses()
	{
		return "Game Passes";
	}

	protected virtual string _GetTemplateForLabelGear()
	{
		return "Gear";
	}

	protected virtual string _GetTemplateForLabelHair()
	{
		return "Hair";
	}

	protected virtual string _GetTemplateForLabelHairAccessory()
	{
		return "Hair Accessory";
	}

	protected virtual string _GetTemplateForLabelHat()
	{
		return "Hat";
	}

	protected virtual string _GetTemplateForLabelHats()
	{
		return "Hats";
	}

	protected virtual string _GetTemplateForLabelHead()
	{
		return "Head";
	}

	protected virtual string _GetTemplateForLabelHeads()
	{
		return "Heads";
	}

	protected virtual string _GetTemplateForLabelIdle()
	{
		return "Idle";
	}

	protected virtual string _GetTemplateForLabelImage()
	{
		return "Image";
	}

	protected virtual string _GetTemplateForLabelJump()
	{
		return "Jump";
	}

	protected virtual string _GetTemplateForLabelLeftArm()
	{
		return "Left Arm";
	}

	protected virtual string _GetTemplateForLabelLeftLeg()
	{
		return "Left Leg";
	}

	protected virtual string _GetTemplateForLabelMesh()
	{
		return "Mesh";
	}

	protected virtual string _GetTemplateForLabelMeshes()
	{
		return "Meshes";
	}

	protected virtual string _GetTemplateForLabelMeshPart()
	{
		return "Mesh Part";
	}

	protected virtual string _GetTemplateForLabelModel()
	{
		return "Model";
	}

	protected virtual string _GetTemplateForLabelModels()
	{
		return "Models";
	}

	protected virtual string _GetTemplateForLabelNeck()
	{
		return "Neck";
	}

	protected virtual string _GetTemplateForLabelNeckAccessory()
	{
		return "Neck Accessory";
	}

	protected virtual string _GetTemplateForLabelPackage()
	{
		return "Package";
	}

	protected virtual string _GetTemplateForLabelPackages()
	{
		return "Packages";
	}

	protected virtual string _GetTemplateForLabelPants()
	{
		return "Pants";
	}

	protected virtual string _GetTemplateForLabelPlace()
	{
		return "Place";
	}

	protected virtual string _GetTemplateForLabelPlaces()
	{
		return "Places";
	}

	protected virtual string _GetTemplateForLabelPlugin()
	{
		return "Plugin";
	}

	protected virtual string _GetTemplateForLabelPlugins()
	{
		return "Plugins";
	}

	protected virtual string _GetTemplateForLabelPose()
	{
		return "Pose";
	}

	protected virtual string _GetTemplateForLabelRightArm()
	{
		return "Right Arm";
	}

	protected virtual string _GetTemplateForLabelRightLeg()
	{
		return "Right Leg";
	}

	protected virtual string _GetTemplateForLabelRun()
	{
		return "Run";
	}

	protected virtual string _GetTemplateForLabelShirt()
	{
		return "Shirt";
	}

	protected virtual string _GetTemplateForLabelShirts()
	{
		return "Shirts";
	}

	protected virtual string _GetTemplateForLabelShoulder()
	{
		return "Shoulder";
	}

	protected virtual string _GetTemplateForLabelShoulderAccessory()
	{
		return "Shoulder Accessory";
	}

	protected virtual string _GetTemplateForLabelShoulders()
	{
		return "Shoulders";
	}

	protected virtual string _GetTemplateForLabelSolidModel()
	{
		return "Solid Model";
	}

	protected virtual string _GetTemplateForLabelSwim()
	{
		return "Swim";
	}

	protected virtual string _GetTemplateForLabelTorso()
	{
		return "Torso";
	}

	protected virtual string _GetTemplateForLabelTShirt()
	{
		return "T-Shirt";
	}

	protected virtual string _GetTemplateForLabelTShirts()
	{
		return "T-Shirts";
	}

	protected virtual string _GetTemplateForLabelVipServers()
	{
		return "VIP Servers";
	}

	protected virtual string _GetTemplateForLabelWaist()
	{
		return "Waist";
	}

	protected virtual string _GetTemplateForLabelWaistAccessory()
	{
		return "Waist Accessory";
	}

	protected virtual string _GetTemplateForLabelWalk()
	{
		return "Walk";
	}
}
