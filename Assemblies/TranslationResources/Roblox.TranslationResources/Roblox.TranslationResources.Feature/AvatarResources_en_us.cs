using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class AvatarResources_en_us : TranslationResourcesBase, IAvatarResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Advanced"
	/// Click Advanced to get the advanced options
	/// English String: "Advanced"
	/// </summary>
	public virtual string ActionAdvanced => "Advanced";

	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item to customize the user's avatar.
	/// English String: "Buy"
	/// </summary>
	public virtual string ActionBuy => "Buy";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public virtual string ActionClose => "Close";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public virtual string ActionCreate => "Create";

	/// <summary>
	/// Key: "Action.CreateNewOutfit"
	/// Button to create new outfit
	/// English String: "Create"
	/// </summary>
	public virtual string ActionCreateNewOutfit => "Create";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public virtual string ActionDelete => "Delete";

	/// <summary>
	/// Key: "Action.Done"
	/// English String: "Done"
	/// </summary>
	public virtual string ActionDone => "Done";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy get an item for free to customize the user's avatar.
	/// English String: "Get"
	/// </summary>
	public virtual string ActionGet => "Get";

	/// <summary>
	/// Key: "Action.GetMore"
	/// A call to action for the user to buy more clothes from the Catalog page. This could improve how their avatar looks.
	/// English String: "Get More"
	/// </summary>
	public virtual string ActionGetMore => "Get More";

	/// <summary>
	/// Key: "Action.OpenRobloxApp"
	/// English String: "Open Roblox App"
	/// </summary>
	public virtual string ActionOpenRobloxApp => "Open Roblox App";

	/// <summary>
	/// Key: "Action.Redraw"
	/// Redraw the avatar on the screen
	/// English String: "Redraw"
	/// </summary>
	public virtual string ActionRedraw => "Redraw";

	/// <summary>
	/// Key: "Action.Rename"
	/// English String: "Rename"
	/// </summary>
	public virtual string ActionRename => "Rename";

	/// <summary>
	/// Key: "Action.RenameOutfit"
	/// Button to rename outfit
	/// English String: "Rename"
	/// </summary>
	public virtual string ActionRenameOutfit => "Rename";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public virtual string ActionSave => "Save";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// See all clothing that user can buy
	/// English String: "See All"
	/// </summary>
	public virtual string ActionSeeAll => "See All";

	/// <summary>
	/// Key: "Action.ThreeDimensions"
	/// This button allows the user to view their avatar in three dimensions.
	/// English String: "3D"
	/// </summary>
	public virtual string ActionThreeDimensions => "3D";

	/// <summary>
	/// Key: "Action.TwoDimensions"
	/// This button allows the user to view their avatar in two dimensions.
	/// English String: "2D"
	/// </summary>
	public virtual string ActionTwoDimensions => "2D";

	/// <summary>
	/// Key: "Action.Update"
	/// English String: "Update"
	/// </summary>
	public virtual string ActionUpdate => "Update";

	/// <summary>
	/// Key: "Action.UserUnderstands"
	/// The user casually responds to the application saying that they understand how to navigate the menu.
	/// English String: "Got it"
	/// </summary>
	public virtual string ActionUserUnderstands => "Got it";

	/// <summary>
	/// Key: "Description.AvatarEditorUpsell"
	/// English String: "To change your look you will need to use the Avatar Editor on the App."
	/// </summary>
	public virtual string DescriptionAvatarEditorUpsell => "To change your look you will need to use the Avatar Editor on the App.";

	/// <summary>
	/// Key: "Description.CreateNewCostume"
	/// A costume will be created from your avatar's current appearance.
	/// English String: "A costume will be created from your avatar's current appearance."
	/// </summary>
	public virtual string DescriptionCreateNewCostume => "A costume will be created from your avatar's current appearance.";

	/// <summary>
	/// Key: "Description.CreateNewOutfit"
	/// An outfit will be created from your avatar's current appearance.
	/// English String: "An outfit will be created from your avatar's current appearance."
	/// </summary>
	public virtual string DescriptionCreateNewOutfit => "An outfit will be created from your avatar's current appearance.";

	/// <summary>
	/// Key: "Description.RenameCostume"
	/// Choose a new name for your costume.
	/// English String: "Choose a new name for your costume."
	/// </summary>
	public virtual string DescriptionRenameCostume => "Choose a new name for your costume.";

	/// <summary>
	/// Key: "Description.RenameOutfit"
	/// Choose a new name for your outfit.
	/// English String: "Choose a new name for your outfit."
	/// </summary>
	public virtual string DescriptionRenameOutfit => "Choose a new name for your outfit.";

	/// <summary>
	/// Key: "Heading.Accessories"
	/// English String: "Accessories"
	/// </summary>
	public virtual string HeadingAccessories => "Accessories";

	/// <summary>
	/// Key: "Heading.AccessoriesChange"
	/// English String: "Accessories Change"
	/// </summary>
	public virtual string HeadingAccessoriesChange => "Accessories Change";

	/// <summary>
	/// Key: "Heading.AdvancedOptions"
	/// English String: "Advanced Options"
	/// </summary>
	public virtual string HeadingAdvancedOptions => "Advanced Options";

	/// <summary>
	/// Key: "Heading.All"
	/// All avatar modification types
	/// English String: "All"
	/// </summary>
	public virtual string HeadingAll => "All";

	/// <summary>
	/// Key: "Heading.Animations"
	/// English String: "Animations"
	/// </summary>
	public virtual string HeadingAnimations => "Animations";

	/// <summary>
	/// Key: "Heading.Appearance"
	/// English String: "Appearance"
	/// </summary>
	public virtual string HeadingAppearance => "Appearance";

	/// <summary>
	/// Key: "Heading.AvatarPageTitle"
	/// Page title for the Avatar page. On this page, the user can modify how they look.
	/// English String: "Avatar Editor"
	/// </summary>
	public virtual string HeadingAvatarPageTitle => "Avatar Editor";

	/// <summary>
	/// Key: "Heading.Body"
	/// English String: "Body"
	/// </summary>
	public virtual string HeadingBody => "Body";

	/// <summary>
	/// Key: "Heading.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public virtual string HeadingBodyParts => "Body Parts";

	/// <summary>
	/// Key: "Heading.Clothing"
	/// English String: "Clothing"
	/// </summary>
	public virtual string HeadingClothing => "Clothing";

	/// <summary>
	/// Key: "Heading.Costumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Costumes"
	/// </summary>
	public virtual string HeadingCostumes => "Costumes";

	/// <summary>
	/// Key: "Heading.CreateNewCostume"
	/// NOTE: Costume is a more whimsical word choice for outfit. Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Create New Costume"
	/// </summary>
	public virtual string HeadingCreateNewCostume => "Create New Costume";

	/// <summary>
	/// Key: "Heading.CreateNewOutfit"
	/// English String: "Create New Outfit"
	/// </summary>
	public virtual string HeadingCreateNewOutfit => "Create New Outfit";

	/// <summary>
	/// Key: "Heading.Delete"
	/// English String: "Delete"
	/// </summary>
	public virtual string HeadingDelete => "Delete";

	/// <summary>
	/// Key: "Heading.DeleteCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Delete Costume"
	/// </summary>
	public virtual string HeadingDeleteCostume => "Delete Costume";

	/// <summary>
	/// Key: "Heading.DeleteOutfit"
	/// English String: "Delete Outfit"
	/// </summary>
	public virtual string HeadingDeleteOutfit => "Delete Outfit";

	/// <summary>
	/// Key: "Heading.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public virtual string HeadingEmotes => "Emotes";

	/// <summary>
	/// Key: "Heading.EquipEmotes"
	/// English String: "Equip Emotes"
	/// </summary>
	public virtual string HeadingEquipEmotes => "Equip Emotes";

	/// <summary>
	/// Key: "Heading.Outfits"
	/// English String: "Outfits"
	/// </summary>
	public virtual string HeadingOutfits => "Outfits";

	/// <summary>
	/// Key: "Heading.Packages"
	/// English String: "Packages"
	/// </summary>
	public virtual string HeadingPackages => "Packages";

	/// <summary>
	/// Key: "Heading.Recent"
	/// English String: "Recent"
	/// </summary>
	public virtual string HeadingRecent => "Recent";

	/// <summary>
	/// Key: "Heading.Recommended"
	/// See recommended clothing for your avatar
	/// English String: "Recommended"
	/// </summary>
	public virtual string HeadingRecommended => "Recommended";

	/// <summary>
	/// Key: "Heading.RenameCostume"
	/// English String: "Rename Costume"
	/// </summary>
	public virtual string HeadingRenameCostume => "Rename Costume";

	/// <summary>
	/// Key: "Heading.RenameOutfit"
	/// English String: "Rename Outfit"
	/// </summary>
	public virtual string HeadingRenameOutfit => "Rename Outfit";

	/// <summary>
	/// Key: "Heading.Scaling"
	/// English String: "Scaling"
	/// </summary>
	public virtual string HeadingScaling => "Scaling";

	/// <summary>
	/// Key: "Heading.SkinToneBodyParts"
	/// English String: "Skin Tone by Body Parts"
	/// </summary>
	public virtual string HeadingSkinToneBodyParts => "Skin Tone by Body Parts";

	/// <summary>
	/// Key: "Heading.Update"
	/// English String: "Update"
	/// </summary>
	public virtual string HeadingUpdate => "Update";

	/// <summary>
	/// Key: "Heading.UpdateCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Update Costume"
	/// </summary>
	public virtual string HeadingUpdateCostume => "Update Costume";

	/// <summary>
	/// Key: "Heading.UpdateOutfit"
	/// English String: "Update Outfit"
	/// </summary>
	public virtual string HeadingUpdateOutfit => "Update Outfit";

	/// <summary>
	/// Key: "Label.All"
	/// All body parts. This label will allow for body parts to change color
	/// English String: "All"
	/// </summary>
	public virtual string LabelAll => "All";

	/// <summary>
	/// Key: "Label.AskIfLoadingCorrectly"
	/// Avatar isn't loading correctly?
	/// English String: "Avatar isn't loading correctly?"
	/// </summary>
	public virtual string LabelAskIfLoadingCorrectly => "Avatar isn't loading correctly?";

	/// <summary>
	/// Key: "Label.AssetIDPlaceholder"
	/// This refers to the Asset ID which is a technical word for the Identification Number of an item or asset.
	/// English String: "Asset ID"
	/// </summary>
	public virtual string LabelAssetIDPlaceholder => "Asset ID";

	/// <summary>
	/// Key: "Label.Back"
	/// English String: "Back"
	/// </summary>
	public virtual string LabelBack => "Back";

	/// <summary>
	/// Key: "Label.BackAccessories"
	/// English String: "Back Accessories"
	/// </summary>
	public virtual string LabelBackAccessories => "Back Accessories";

	/// <summary>
	/// Key: "Label.BodyType"
	/// English String: "Body Type"
	/// </summary>
	public virtual string LabelBodyType => "Body Type";

	/// <summary>
	/// Key: "Label.Climb"
	/// English String: "Climb"
	/// </summary>
	public virtual string LabelClimb => "Climb";

	/// <summary>
	/// Key: "Label.ClimbAnimations"
	/// English String: "Climb Animations"
	/// </summary>
	public virtual string LabelClimbAnimations => "Climb Animations";

	/// <summary>
	/// Key: "Label.Clothes"
	/// English String: "Clothes"
	/// </summary>
	public virtual string LabelClothes => "Clothes";

	/// <summary>
	/// Key: "Label.Costume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Costume"
	/// </summary>
	public virtual string LabelCostume => "Costume";

	/// <summary>
	/// Key: "label.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public virtual string labelEmotes => "Emotes";

	/// <summary>
	/// Key: "Label.Equip"
	/// English String: "Equip"
	/// </summary>
	public virtual string LabelEquip => "Equip";

	/// <summary>
	/// Key: "Label.ExploreCatalog"
	/// This text entices users to shop for more things to wear on their avatar
	/// English String: "Explore the catalog to find more clothes!"
	/// </summary>
	public virtual string LabelExploreCatalog => "Explore the catalog to find more clothes!";

	/// <summary>
	/// Key: "Label.Face"
	/// English String: "Face"
	/// </summary>
	public virtual string LabelFace => "Face";

	/// <summary>
	/// Key: "Label.FaceAccessories"
	/// English String: "Face Accessories"
	/// </summary>
	public virtual string LabelFaceAccessories => "Face Accessories";

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
	/// Key: "Label.FallAnimations"
	/// English String: "Fall Animations"
	/// </summary>
	public virtual string LabelFallAnimations => "Fall Animations";

	/// <summary>
	/// Key: "Label.Free"
	/// Text label for recommended items
	/// English String: "Free"
	/// </summary>
	public virtual string LabelFree => "Free";

	/// <summary>
	/// Key: "Label.Front"
	/// English String: "Front"
	/// </summary>
	public virtual string LabelFront => "Front";

	/// <summary>
	/// Key: "Label.FrontAccessories"
	/// English String: "Front Accessories"
	/// </summary>
	public virtual string LabelFrontAccessories => "Front Accessories";

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
	/// Key: "Label.HairAccessories"
	/// English String: "Hair Accessories"
	/// </summary>
	public virtual string LabelHairAccessories => "Hair Accessories";

	/// <summary>
	/// Key: "Label.Hat"
	/// English String: "Hat"
	/// </summary>
	public virtual string LabelHat => "Hat";

	/// <summary>
	/// Key: "Label.HatAccessories"
	/// English String: "Hat Accessories"
	/// </summary>
	public virtual string LabelHatAccessories => "Hat Accessories";

	/// <summary>
	/// Key: "Label.Head"
	/// English String: "Head"
	/// </summary>
	public virtual string LabelHead => "Head";

	/// <summary>
	/// Key: "Label.Heads"
	/// English String: "Heads"
	/// </summary>
	public virtual string LabelHeads => "Heads";

	/// <summary>
	/// Key: "Label.Height"
	/// English String: "Height"
	/// </summary>
	public virtual string LabelHeight => "Height";

	/// <summary>
	/// Key: "Label.Idle"
	/// English String: "Idle"
	/// </summary>
	public virtual string LabelIdle => "Idle";

	/// <summary>
	/// Key: "Label.IdleAnimations"
	/// English String: "Idle Animations"
	/// </summary>
	public virtual string LabelIdleAnimations => "Idle Animations";

	/// <summary>
	/// Key: "Label.Jump"
	/// English String: "Jump"
	/// </summary>
	public virtual string LabelJump => "Jump";

	/// <summary>
	/// Key: "Label.JumpAnimations"
	/// English String: "Jump Animations"
	/// </summary>
	public virtual string LabelJumpAnimations => "Jump Animations";

	/// <summary>
	/// Key: "Label.LeftArm"
	/// English String: "Left Arm"
	/// </summary>
	public virtual string LabelLeftArm => "Left Arm";

	/// <summary>
	/// Key: "Label.LeftArms"
	/// English String: "Left Arms"
	/// </summary>
	public virtual string LabelLeftArms => "Left Arms";

	/// <summary>
	/// Key: "Label.LeftLeg"
	/// English String: "Left Leg"
	/// </summary>
	public virtual string LabelLeftLeg => "Left Leg";

	/// <summary>
	/// Key: "Label.LeftLegs"
	/// English String: "Left Legs"
	/// </summary>
	public virtual string LabelLeftLegs => "Left Legs";

	/// <summary>
	/// Key: "Label.MyCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "My Costumes"
	/// </summary>
	public virtual string LabelMyCostumes => "My Costumes";

	/// <summary>
	/// Key: "Label.NamePlaceholderCostume"
	/// English String: "Name your costume"
	/// </summary>
	public virtual string LabelNamePlaceholderCostume => "Name your costume";

	/// <summary>
	/// Key: "Label.NamePlaceholderOutfit"
	/// English String: "Name your outfit"
	/// </summary>
	public virtual string LabelNamePlaceholderOutfit => "Name your outfit";

	/// <summary>
	/// Key: "Label.Neck"
	/// English String: "Neck"
	/// </summary>
	public virtual string LabelNeck => "Neck";

	/// <summary>
	/// Key: "Label.NeckAccessories"
	/// English String: "Neck Accessories"
	/// </summary>
	public virtual string LabelNeckAccessories => "Neck Accessories";

	/// <summary>
	/// Key: "Label.NoResellers"
	/// Text label for recommended items
	/// English String: "No resellers"
	/// </summary>
	public virtual string LabelNoResellers => "No resellers";

	/// <summary>
	/// Key: "Label.OffSale"
	/// Text label for recommended items
	/// English String: "Off sale"
	/// </summary>
	public virtual string LabelOffSale => "Off sale";

	/// <summary>
	/// Key: "Label.Outfit"
	/// English String: "Outfit"
	/// </summary>
	public virtual string LabelOutfit => "Outfit";

	/// <summary>
	/// Key: "Label.Pants"
	/// English String: "Pants"
	/// </summary>
	public virtual string LabelPants => "Pants";

	/// <summary>
	/// Key: "Label.Parts"
	/// English String: "Parts"
	/// </summary>
	public virtual string LabelParts => "Parts";

	/// <summary>
	/// Key: "Label.PresetCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Preset Costumes"
	/// </summary>
	public virtual string LabelPresetCostumes => "Preset Costumes";

	/// <summary>
	/// Key: "Label.Proportions"
	/// English String: "Proportions"
	/// </summary>
	public virtual string LabelProportions => "Proportions";

	/// <summary>
	/// Key: "Label.RedrawUnavailable"
	/// Avatar redraw is unavailable
	/// English String: "Avatar redraw is unavailable."
	/// </summary>
	public virtual string LabelRedrawUnavailable => "Avatar redraw is unavailable.";

	/// <summary>
	/// Key: "Label.RightArm"
	/// English String: "Right Arm"
	/// </summary>
	public virtual string LabelRightArm => "Right Arm";

	/// <summary>
	/// Key: "Label.RightArms"
	/// English String: "Right Arms"
	/// </summary>
	public virtual string LabelRightArms => "Right Arms";

	/// <summary>
	/// Key: "Label.RightLeg"
	/// English String: "Right Leg"
	/// </summary>
	public virtual string LabelRightLeg => "Right Leg";

	/// <summary>
	/// Key: "Label.RightLegs"
	/// English String: "Right Legs"
	/// </summary>
	public virtual string LabelRightLegs => "Right Legs";

	/// <summary>
	/// Key: "Label.Run"
	/// English String: "Run"
	/// </summary>
	public virtual string LabelRun => "Run";

	/// <summary>
	/// Key: "Label.RunAnimations"
	/// English String: "Run Animations"
	/// </summary>
	public virtual string LabelRunAnimations => "Run Animations";

	/// <summary>
	/// Key: "Label.Scale"
	/// English String: "Scale"
	/// </summary>
	public virtual string LabelScale => "Scale";

	/// <summary>
	/// Key: "Label.Shirts"
	/// English String: "Shirts"
	/// </summary>
	public virtual string LabelShirts => "Shirts";

	/// <summary>
	/// Key: "Label.ShoulderAccessories"
	/// English String: "Shoulder Accessories"
	/// </summary>
	public virtual string LabelShoulderAccessories => "Shoulder Accessories";

	/// <summary>
	/// Key: "Label.Shoulders"
	/// English String: "Shoulders"
	/// </summary>
	public virtual string LabelShoulders => "Shoulders";

	/// <summary>
	/// Key: "Label.SkinTone"
	/// English String: "Skin Tone"
	/// </summary>
	public virtual string LabelSkinTone => "Skin Tone";

	/// <summary>
	/// Key: "Label.Swim"
	/// English String: "Swim"
	/// </summary>
	public virtual string LabelSwim => "Swim";

	/// <summary>
	/// Key: "Label.SwimAnimations"
	/// English String: "Swim Animations"
	/// </summary>
	public virtual string LabelSwimAnimations => "Swim Animations";

	/// <summary>
	/// Key: "Label.SwitchAvatarType"
	/// User is able to increase the number of joints in their avatar from 6 to 15. R15 moves better. See http://roblox.wikia.com/wiki/R15
	/// English String: "Switch between classic R6 avatar and more expressive next generation R15 avatar"
	/// </summary>
	public virtual string LabelSwitchAvatarType => "Switch between classic R6 avatar and more expressive next generation R15 avatar";

	/// <summary>
	/// Key: "Label.Torso"
	/// English String: "Torso"
	/// </summary>
	public virtual string LabelTorso => "Torso";

	/// <summary>
	/// Key: "Label.Torsos"
	/// English String: "Torsos"
	/// </summary>
	public virtual string LabelTorsos => "Torsos";

	/// <summary>
	/// Key: "Label.TShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public virtual string LabelTShirts => "T-Shirts";

	/// <summary>
	/// Key: "Label.Waist"
	/// English String: "Waist"
	/// </summary>
	public virtual string LabelWaist => "Waist";

	/// <summary>
	/// Key: "Label.WaistAccessories"
	/// English String: "Waist Accessories"
	/// </summary>
	public virtual string LabelWaistAccessories => "Waist Accessories";

	/// <summary>
	/// Key: "Label.Walk"
	/// English String: "Walk"
	/// </summary>
	public virtual string LabelWalk => "Walk";

	/// <summary>
	/// Key: "Label.WalkAnimations"
	/// English String: "Walk Animations"
	/// </summary>
	public virtual string LabelWalkAnimations => "Walk Animations";

	/// <summary>
	/// Key: "Label.Width"
	/// English String: "Width"
	/// </summary>
	public virtual string LabelWidth => "Width";

	/// <summary>
	/// Key: "Label.YourEmotes"
	/// English String: "Your Emotes"
	/// </summary>
	public virtual string LabelYourEmotes => "Your Emotes";

	/// <summary>
	/// Key: "Message.AccessoriesChange"
	/// English String: "Are you sure you want to override your current look?"
	/// </summary>
	public virtual string MessageAccessoriesChange => "Are you sure you want to override your current look?";

	/// <summary>
	/// Key: "Message.ChooseEmote"
	/// English String: "Choose an Emote"
	/// </summary>
	public virtual string MessageChooseEmote => "Choose an Emote";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlot"
	/// English String: "Choose a slot"
	/// </summary>
	public virtual string MessageChooseEmoteSlot => "Choose a slot";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlotOrEmote"
	/// English String: "Choose a slot or an Emote"
	/// </summary>
	public virtual string MessageChooseEmoteSlotOrEmote => "Choose a slot or an Emote";

	/// <summary>
	/// Key: "Message.DefaultClothing"
	/// Encourage user to choose their own clothes.
	/// English String: "Default clothing has been applied to your avatar - wear something from your clothing."
	/// </summary>
	public virtual string MessageDefaultClothing => "Default clothing has been applied to your avatar - wear something from your clothing.";

	/// <summary>
	/// Key: "Message.DeleteThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Are you sure you want to delete this costume?"
	/// </summary>
	public virtual string MessageDeleteThisCostume => "Are you sure you want to delete this costume?";

	/// <summary>
	/// Key: "Message.DeleteThisOutfit"
	/// English String: "Are you sure you want to delete this outfit?"
	/// </summary>
	public virtual string MessageDeleteThisOutfit => "Are you sure you want to delete this outfit?";

	/// <summary>
	/// Key: "Message.EmotesInstructions"
	/// The instructions describe the navigation flow within the Avatar Editor to equip an emote.
	/// English String: "Go to \"Animations\" &gt; \"Emotes\" &gt; \"Equip Emotes\" to equip an emote."
	/// </summary>
	public virtual string MessageEmotesInstructions => "Go to \"Animations\" > \"Emotes\" > \"Equip Emotes\" to equip an emote.";

	/// <summary>
	/// Key: "Message.EmptyAssetList"
	/// User is seeing no assets on this page because they don't have any.
	/// English String: "You don't have any."
	/// </summary>
	public virtual string MessageEmptyAssetList => "You don't have any.";

	/// <summary>
	/// Key: "Message.EmptyListOfCostumes"
	/// The user is viewing an empty list of costumes to choose from. The application tells the user that they can create an costume.
	/// English String: "You don't have any costumes. Try creating some!"
	/// </summary>
	public virtual string MessageEmptyListOfCostumes => "You don't have any costumes. Try creating some!";

	/// <summary>
	/// Key: "Message.EmptyListOfOutfits"
	/// The user is viewing an empty list of outfits to choose from. The application tells the user that they can create an outfit.
	/// English String: "You don't have any outfits. Try creating some!"
	/// </summary>
	public virtual string MessageEmptyListOfOutfits => "You don't have any outfits. Try creating some!";

	/// <summary>
	/// Key: "Message.EmptyRecentItems"
	/// English String: "You don't have any recent items."
	/// </summary>
	public virtual string MessageEmptyRecentItems => "You don't have any recent items.";

	/// <summary>
	/// Key: "Message.ErrorCreateCostume"
	/// English String: "Unable to create costume, try again later."
	/// </summary>
	public virtual string MessageErrorCreateCostume => "Unable to create costume, try again later.";

	/// <summary>
	/// Key: "Message.ErrorCreateOutfit"
	/// English String: "Unable to create outfit, try again later."
	/// </summary>
	public virtual string MessageErrorCreateOutfit => "Unable to create outfit, try again later.";

	/// <summary>
	/// Key: "Message.ErrorDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public virtual string MessageErrorDeleteEmote => "Failed to delete emote.";

	/// <summary>
	/// Key: "Message.ErrorEquipEmote"
	/// English String: "Failed to equip emote, please try again later."
	/// </summary>
	public virtual string MessageErrorEquipEmote => "Failed to equip emote, please try again later.";

	/// <summary>
	/// Key: "Message.ErrorLoadCostume"
	/// English String: "Failed to load costume."
	/// </summary>
	public virtual string MessageErrorLoadCostume => "Failed to load costume.";

	/// <summary>
	/// Key: "Message.ErrorLoadEmotes"
	/// English String: "Failed to load emotes."
	/// </summary>
	public virtual string MessageErrorLoadEmotes => "Failed to load emotes.";

	/// <summary>
	/// Key: "Message.ErrorLoadOutfits"
	/// English String: "Failed to load outfits."
	/// </summary>
	public virtual string MessageErrorLoadOutfits => "Failed to load outfits.";

	/// <summary>
	/// Key: "Message.ErrorOutfitName"
	/// English String: "Name can contain letters, numbers, and spaces."
	/// </summary>
	public virtual string MessageErrorOutfitName => "Name can contain letters, numbers, and spaces.";

	/// <summary>
	/// Key: "Message.ErrorRenameCostume"
	/// English String: "Failed to rename costume."
	/// </summary>
	public virtual string MessageErrorRenameCostume => "Failed to rename costume.";

	/// <summary>
	/// Key: "Message.ErrorRenameOutfit"
	/// English String: "Failed to rename outfit."
	/// </summary>
	public virtual string MessageErrorRenameOutfit => "Failed to rename outfit.";

	/// <summary>
	/// Key: "Message.ErrorUnequipEmote"
	/// English String: "Failed to unequip emote."
	/// </summary>
	public virtual string MessageErrorUnequipEmote => "Failed to unequip emote.";

	/// <summary>
	/// Key: "Message.ErrorUpdateCostume"
	/// English String: "Costume update failed, please try again later."
	/// </summary>
	public virtual string MessageErrorUpdateCostume => "Costume update failed, please try again later.";

	/// <summary>
	/// Key: "Message.ErrorUpdateEmote"
	/// English String: "Updating emote slot failed, please try again later."
	/// </summary>
	public virtual string MessageErrorUpdateEmote => "Updating emote slot failed, please try again later.";

	/// <summary>
	/// Key: "Message.ErrorUpdateOutfit"
	/// English String: "Outfit update failed, please try again later."
	/// </summary>
	public virtual string MessageErrorUpdateOutfit => "Outfit update failed, please try again later.";

	/// <summary>
	/// Key: "Message.ErrorUpdateWorn"
	/// There was an error updating items that the user is already wearing.
	/// English String: "Error while updating worn items."
	/// </summary>
	public virtual string MessageErrorUpdateWorn => "Error while updating worn items.";

	/// <summary>
	/// Key: "Message.ErrorWearCostume"
	/// English String: "Failed to wear costume."
	/// </summary>
	public virtual string MessageErrorWearCostume => "Failed to wear costume.";

	/// <summary>
	/// Key: "Message.ErrorWearOutfit"
	/// English String: "Failed to wear outfit."
	/// </summary>
	public virtual string MessageErrorWearOutfit => "Failed to wear outfit.";

	/// <summary>
	/// Key: "Message.FailedDeleteCostume"
	/// English String: "Failed to delete costume."
	/// </summary>
	public virtual string MessageFailedDeleteCostume => "Failed to delete costume.";

	/// <summary>
	/// Key: "Message.FailedDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public virtual string MessageFailedDeleteEmote => "Failed to delete emote.";

	/// <summary>
	/// Key: "Message.FailedDeleteOutfit"
	/// English String: "Failed to delete outfit."
	/// </summary>
	public virtual string MessageFailedDeleteOutfit => "Failed to delete outfit.";

	/// <summary>
	/// Key: "Message.FailedLoadAssets"
	/// English String: "Failed to load assets list."
	/// </summary>
	public virtual string MessageFailedLoadAssets => "Failed to load assets list.";

	/// <summary>
	/// Key: "Message.FailedLoadRecent"
	/// English String: "Failed to load recent items."
	/// </summary>
	public virtual string MessageFailedLoadRecent => "Failed to load recent items.";

	/// <summary>
	/// Key: "Message.FailedUpdateBodyColor"
	/// English String: "Failed to update skin tone."
	/// </summary>
	public virtual string MessageFailedUpdateBodyColor => "Failed to update skin tone.";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedCostume"
	/// The user tried to update a deleted costume.
	/// English String: "The costume you tried to update no longer exists."
	/// </summary>
	public virtual string MessageFailedUpdateDeletedCostume => "The costume you tried to update no longer exists.";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedOutfit"
	/// The user tried to update a deleted outfit.
	/// English String: "The outfit you tried to update no longer exists."
	/// </summary>
	public virtual string MessageFailedUpdateDeletedOutfit => "The outfit you tried to update no longer exists.";

	/// <summary>
	/// Key: "Message.FailedUpdateScales"
	/// English String: "Failed to update scales."
	/// </summary>
	public virtual string MessageFailedUpdateScales => "Failed to update scales.";

	/// <summary>
	/// Key: "Message.FailedUpdateType"
	/// Failed to update the way the user's avatar is rendered.
	/// English String: "Failed to update avatar type."
	/// </summary>
	public virtual string MessageFailedUpdateType => "Failed to update avatar type.";

	/// <summary>
	/// Key: "Message.FailedWearPackage"
	/// English String: "Failed to wear package."
	/// </summary>
	public virtual string MessageFailedWearPackage => "Failed to wear package.";

	/// <summary>
	/// Key: "Message.HatLimitTooltip"
	/// English String: "You can wear up to 3 hats"
	/// </summary>
	public virtual string MessageHatLimitTooltip => "You can wear up to 3 hats";

	/// <summary>
	/// Key: "Message.InvalidOutfitName"
	/// English String: "Name must be appropriate and less than 200 characters."
	/// </summary>
	public virtual string MessageInvalidOutfitName => "Name must be appropriate and less than 200 characters.";

	/// <summary>
	/// Key: "Message.Loading"
	/// The user's avatar is loading
	/// English String: "Loading..."
	/// </summary>
	public virtual string MessageLoading => "Loading...";

	/// <summary>
	/// Key: "Message.PageUnavailable"
	/// English String: "The avatar page is temporarily unavailable."
	/// </summary>
	public virtual string MessagePageUnavailable => "The avatar page is temporarily unavailable.";

	/// <summary>
	/// Key: "Message.PresetCostumesDelay"
	/// One-time message that appears to the user first time they visit the Preset Costumes tab. The delay is caused by initial migration.
	/// English String: "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!"
	/// </summary>
	public virtual string MessagePresetCostumesDelay => "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!";

	/// <summary>
	/// Key: "Message.ReachedMaxCostumes"
	/// English String: "You have reached the maximum number of costumes."
	/// </summary>
	public virtual string MessageReachedMaxCostumes => "You have reached the maximum number of costumes.";

	/// <summary>
	/// Key: "Message.ReachedMaxOutfits"
	/// English String: "You have reached the maximum number of outfits."
	/// </summary>
	public virtual string MessageReachedMaxOutfits => "You have reached the maximum number of outfits.";

	/// <summary>
	/// Key: "Message.RedirectAvatarSettings"
	/// English String: "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home &gt; Game Settings &gt; Avatar"
	/// </summary>
	public virtual string MessageRedirectAvatarSettings => "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home > Game Settings > Avatar";

	/// <summary>
	/// Key: "Message.RedrawFloodchecked"
	/// English String: "You have redrawn your avatar too many times, please try again later."
	/// </summary>
	public virtual string MessageRedrawFloodchecked => "You have redrawn your avatar too many times, please try again later.";

	/// <summary>
	/// Key: "Message.RedrawThumbnailFailed"
	/// English String: "Failed to redraw thumbnail."
	/// </summary>
	public virtual string MessageRedrawThumbnailFailed => "Failed to redraw thumbnail.";

	/// <summary>
	/// Key: "Message.SelectEnableScaling"
	/// R15 is a proper noun
	/// English String: "Select R15 to enable scaling."
	/// </summary>
	public virtual string MessageSelectEnableScaling => "Select R15 to enable scaling.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public virtual string MessageSuccess => "Success";

	/// <summary>
	/// Key: "Message.SuccessCreateCostume"
	/// English String: "Created costume"
	/// </summary>
	public virtual string MessageSuccessCreateCostume => "Created costume";

	/// <summary>
	/// Key: "Message.SuccessCreateOutfit"
	/// English String: "Created outfit"
	/// </summary>
	public virtual string MessageSuccessCreateOutfit => "Created outfit";

	/// <summary>
	/// Key: "Message.SuccessDeleteCostume"
	/// Deleted costume
	/// English String: "Deleted costume"
	/// </summary>
	public virtual string MessageSuccessDeleteCostume => "Deleted costume";

	/// <summary>
	/// Key: "Message.SuccessDeleteOutfit"
	/// English String: "Deleted outfit"
	/// </summary>
	public virtual string MessageSuccessDeleteOutfit => "Deleted outfit";

	/// <summary>
	/// Key: "Message.SuccessEquipEmote"
	/// English String: "Equipped Emote"
	/// </summary>
	public virtual string MessageSuccessEquipEmote => "Equipped Emote";

	/// <summary>
	/// Key: "Message.SuccessRenameCostume"
	/// English String: "Renamed costume"
	/// </summary>
	public virtual string MessageSuccessRenameCostume => "Renamed costume";

	/// <summary>
	/// Key: "Message.SuccessRenameOutfit"
	/// English String: "Renamed outfit"
	/// </summary>
	public virtual string MessageSuccessRenameOutfit => "Renamed outfit";

	/// <summary>
	/// Key: "Message.SuccessSavedAccessories"
	/// English String: "Saved accessories"
	/// </summary>
	public virtual string MessageSuccessSavedAccessories => "Saved accessories";

	/// <summary>
	/// Key: "Message.SuccessUnequipEmote"
	/// English String: "Unequipped emote"
	/// </summary>
	public virtual string MessageSuccessUnequipEmote => "Unequipped emote";

	/// <summary>
	/// Key: "Message.SuccessUpdatedCostume"
	/// English String: "Updated costume"
	/// </summary>
	public virtual string MessageSuccessUpdatedCostume => "Updated costume";

	/// <summary>
	/// Key: "Message.SuccessUpdatedOutfit"
	/// English String: "Updated outfit"
	/// </summary>
	public virtual string MessageSuccessUpdatedOutfit => "Updated outfit";

	/// <summary>
	/// Key: "Message.SuccessWoreCostume"
	/// English String: "Successfully wore costume"
	/// </summary>
	public virtual string MessageSuccessWoreCostume => "Successfully wore costume";

	/// <summary>
	/// Key: "Message.SuccessWoreOutfit"
	/// English String: "Successfully wore outfit"
	/// </summary>
	public virtual string MessageSuccessWoreOutfit => "Successfully wore outfit";

	/// <summary>
	/// Key: "Message.UpdateThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance."
	/// </summary>
	public virtual string MessageUpdateThisCostume => "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance.";

	/// <summary>
	/// Key: "Message.UpdateThisOutfit"
	/// English String: "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance."
	/// </summary>
	public virtual string MessageUpdateThisOutfit => "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance.";

	/// <summary>
	/// Key: "Message.Warning"
	/// English String: "Warning"
	/// </summary>
	public virtual string MessageWarning => "Warning";

	public AvatarResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Advanced",
				_GetTemplateForActionAdvanced()
			},
			{
				"Action.Buy",
				_GetTemplateForActionBuy()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Close",
				_GetTemplateForActionClose()
			},
			{
				"Action.Create",
				_GetTemplateForActionCreate()
			},
			{
				"Action.CreateNewOutfit",
				_GetTemplateForActionCreateNewOutfit()
			},
			{
				"Action.Delete",
				_GetTemplateForActionDelete()
			},
			{
				"Action.Done",
				_GetTemplateForActionDone()
			},
			{
				"Action.Get",
				_GetTemplateForActionGet()
			},
			{
				"Action.GetMore",
				_GetTemplateForActionGetMore()
			},
			{
				"Action.OpenRobloxApp",
				_GetTemplateForActionOpenRobloxApp()
			},
			{
				"Action.Redraw",
				_GetTemplateForActionRedraw()
			},
			{
				"Action.Rename",
				_GetTemplateForActionRename()
			},
			{
				"Action.RenameOutfit",
				_GetTemplateForActionRenameOutfit()
			},
			{
				"Action.Save",
				_GetTemplateForActionSave()
			},
			{
				"Action.SeeAll",
				_GetTemplateForActionSeeAll()
			},
			{
				"Action.ThreeDimensions",
				_GetTemplateForActionThreeDimensions()
			},
			{
				"Action.TwoDimensions",
				_GetTemplateForActionTwoDimensions()
			},
			{
				"Action.Update",
				_GetTemplateForActionUpdate()
			},
			{
				"Action.UserUnderstands",
				_GetTemplateForActionUserUnderstands()
			},
			{
				"Description.AvatarEditorUpsell",
				_GetTemplateForDescriptionAvatarEditorUpsell()
			},
			{
				"Description.CreateNewCostume",
				_GetTemplateForDescriptionCreateNewCostume()
			},
			{
				"Description.CreateNewOutfit",
				_GetTemplateForDescriptionCreateNewOutfit()
			},
			{
				"Description.RenameCostume",
				_GetTemplateForDescriptionRenameCostume()
			},
			{
				"Description.RenameOutfit",
				_GetTemplateForDescriptionRenameOutfit()
			},
			{
				"Heading.Accessories",
				_GetTemplateForHeadingAccessories()
			},
			{
				"Heading.AccessoriesChange",
				_GetTemplateForHeadingAccessoriesChange()
			},
			{
				"Heading.AdvancedOptions",
				_GetTemplateForHeadingAdvancedOptions()
			},
			{
				"Heading.All",
				_GetTemplateForHeadingAll()
			},
			{
				"Heading.Animations",
				_GetTemplateForHeadingAnimations()
			},
			{
				"Heading.Appearance",
				_GetTemplateForHeadingAppearance()
			},
			{
				"Heading.AvatarPageTitle",
				_GetTemplateForHeadingAvatarPageTitle()
			},
			{
				"Heading.Body",
				_GetTemplateForHeadingBody()
			},
			{
				"Heading.BodyParts",
				_GetTemplateForHeadingBodyParts()
			},
			{
				"Heading.Clothing",
				_GetTemplateForHeadingClothing()
			},
			{
				"Heading.Costumes",
				_GetTemplateForHeadingCostumes()
			},
			{
				"Heading.CreateNewCostume",
				_GetTemplateForHeadingCreateNewCostume()
			},
			{
				"Heading.CreateNewOutfit",
				_GetTemplateForHeadingCreateNewOutfit()
			},
			{
				"Heading.Delete",
				_GetTemplateForHeadingDelete()
			},
			{
				"Heading.DeleteCostume",
				_GetTemplateForHeadingDeleteCostume()
			},
			{
				"Heading.DeleteOutfit",
				_GetTemplateForHeadingDeleteOutfit()
			},
			{
				"Heading.Emotes",
				_GetTemplateForHeadingEmotes()
			},
			{
				"Heading.EquipEmotes",
				_GetTemplateForHeadingEquipEmotes()
			},
			{
				"Heading.Outfits",
				_GetTemplateForHeadingOutfits()
			},
			{
				"Heading.Packages",
				_GetTemplateForHeadingPackages()
			},
			{
				"Heading.Recent",
				_GetTemplateForHeadingRecent()
			},
			{
				"Heading.Recommended",
				_GetTemplateForHeadingRecommended()
			},
			{
				"Heading.RenameCostume",
				_GetTemplateForHeadingRenameCostume()
			},
			{
				"Heading.RenameOutfit",
				_GetTemplateForHeadingRenameOutfit()
			},
			{
				"Heading.Scaling",
				_GetTemplateForHeadingScaling()
			},
			{
				"Heading.SkinToneBodyParts",
				_GetTemplateForHeadingSkinToneBodyParts()
			},
			{
				"Heading.Update",
				_GetTemplateForHeadingUpdate()
			},
			{
				"Heading.UpdateCostume",
				_GetTemplateForHeadingUpdateCostume()
			},
			{
				"Heading.UpdateOutfit",
				_GetTemplateForHeadingUpdateOutfit()
			},
			{
				"Label.All",
				_GetTemplateForLabelAll()
			},
			{
				"Label.AskIfLoadingCorrectly",
				_GetTemplateForLabelAskIfLoadingCorrectly()
			},
			{
				"Label.AssetIDPlaceholder",
				_GetTemplateForLabelAssetIDPlaceholder()
			},
			{
				"Label.Back",
				_GetTemplateForLabelBack()
			},
			{
				"Label.BackAccessories",
				_GetTemplateForLabelBackAccessories()
			},
			{
				"Label.BodyType",
				_GetTemplateForLabelBodyType()
			},
			{
				"Label.Climb",
				_GetTemplateForLabelClimb()
			},
			{
				"Label.ClimbAnimations",
				_GetTemplateForLabelClimbAnimations()
			},
			{
				"Label.Clothes",
				_GetTemplateForLabelClothes()
			},
			{
				"Label.Costume",
				_GetTemplateForLabelCostume()
			},
			{
				"Label.DirectionsForPackagePlacement",
				_GetTemplateForLabelDirectionsForPackagePlacement()
			},
			{
				"Label.DirectionsForScalingOptions",
				_GetTemplateForLabelDirectionsForScalingOptions()
			},
			{
				"label.Emotes",
				_GetTemplateForlabelEmotes()
			},
			{
				"Label.Equip",
				_GetTemplateForLabelEquip()
			},
			{
				"Label.ExploreCatalog",
				_GetTemplateForLabelExploreCatalog()
			},
			{
				"Label.Face",
				_GetTemplateForLabelFace()
			},
			{
				"Label.FaceAccessories",
				_GetTemplateForLabelFaceAccessories()
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
				"Label.FallAnimations",
				_GetTemplateForLabelFallAnimations()
			},
			{
				"Label.Free",
				_GetTemplateForLabelFree()
			},
			{
				"Label.Front",
				_GetTemplateForLabelFront()
			},
			{
				"Label.FrontAccessories",
				_GetTemplateForLabelFrontAccessories()
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
				"Label.HairAccessories",
				_GetTemplateForLabelHairAccessories()
			},
			{
				"Label.Hat",
				_GetTemplateForLabelHat()
			},
			{
				"Label.HatAccessories",
				_GetTemplateForLabelHatAccessories()
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
				"Label.Height",
				_GetTemplateForLabelHeight()
			},
			{
				"Label.Idle",
				_GetTemplateForLabelIdle()
			},
			{
				"Label.IdleAnimations",
				_GetTemplateForLabelIdleAnimations()
			},
			{
				"Label.Jump",
				_GetTemplateForLabelJump()
			},
			{
				"Label.JumpAnimations",
				_GetTemplateForLabelJumpAnimations()
			},
			{
				"Label.LeftArm",
				_GetTemplateForLabelLeftArm()
			},
			{
				"Label.LeftArms",
				_GetTemplateForLabelLeftArms()
			},
			{
				"Label.LeftLeg",
				_GetTemplateForLabelLeftLeg()
			},
			{
				"Label.LeftLegs",
				_GetTemplateForLabelLeftLegs()
			},
			{
				"Label.MyCostumes",
				_GetTemplateForLabelMyCostumes()
			},
			{
				"Label.NamePlaceholderCostume",
				_GetTemplateForLabelNamePlaceholderCostume()
			},
			{
				"Label.NamePlaceholderOutfit",
				_GetTemplateForLabelNamePlaceholderOutfit()
			},
			{
				"Label.Neck",
				_GetTemplateForLabelNeck()
			},
			{
				"Label.NeckAccessories",
				_GetTemplateForLabelNeckAccessories()
			},
			{
				"Label.NoResellers",
				_GetTemplateForLabelNoResellers()
			},
			{
				"Label.OffSale",
				_GetTemplateForLabelOffSale()
			},
			{
				"Label.Outfit",
				_GetTemplateForLabelOutfit()
			},
			{
				"Label.Pants",
				_GetTemplateForLabelPants()
			},
			{
				"Label.Parts",
				_GetTemplateForLabelParts()
			},
			{
				"Label.PresetCostumes",
				_GetTemplateForLabelPresetCostumes()
			},
			{
				"Label.Proportions",
				_GetTemplateForLabelProportions()
			},
			{
				"Label.RedrawUnavailable",
				_GetTemplateForLabelRedrawUnavailable()
			},
			{
				"Label.RightArm",
				_GetTemplateForLabelRightArm()
			},
			{
				"Label.RightArms",
				_GetTemplateForLabelRightArms()
			},
			{
				"Label.RightLeg",
				_GetTemplateForLabelRightLeg()
			},
			{
				"Label.RightLegs",
				_GetTemplateForLabelRightLegs()
			},
			{
				"Label.Run",
				_GetTemplateForLabelRun()
			},
			{
				"Label.RunAnimations",
				_GetTemplateForLabelRunAnimations()
			},
			{
				"Label.Scale",
				_GetTemplateForLabelScale()
			},
			{
				"Label.Shirts",
				_GetTemplateForLabelShirts()
			},
			{
				"Label.ShoulderAccessories",
				_GetTemplateForLabelShoulderAccessories()
			},
			{
				"Label.Shoulders",
				_GetTemplateForLabelShoulders()
			},
			{
				"Label.SkinTone",
				_GetTemplateForLabelSkinTone()
			},
			{
				"Label.Swim",
				_GetTemplateForLabelSwim()
			},
			{
				"Label.SwimAnimations",
				_GetTemplateForLabelSwimAnimations()
			},
			{
				"Label.SwitchAvatarType",
				_GetTemplateForLabelSwitchAvatarType()
			},
			{
				"Label.Torso",
				_GetTemplateForLabelTorso()
			},
			{
				"Label.Torsos",
				_GetTemplateForLabelTorsos()
			},
			{
				"Label.TShirts",
				_GetTemplateForLabelTShirts()
			},
			{
				"Label.Waist",
				_GetTemplateForLabelWaist()
			},
			{
				"Label.WaistAccessories",
				_GetTemplateForLabelWaistAccessories()
			},
			{
				"Label.Walk",
				_GetTemplateForLabelWalk()
			},
			{
				"Label.WalkAnimations",
				_GetTemplateForLabelWalkAnimations()
			},
			{
				"Label.Width",
				_GetTemplateForLabelWidth()
			},
			{
				"Label.YourEmotes",
				_GetTemplateForLabelYourEmotes()
			},
			{
				"Message.AccessoriesChange",
				_GetTemplateForMessageAccessoriesChange()
			},
			{
				"Message.ChooseEmote",
				_GetTemplateForMessageChooseEmote()
			},
			{
				"Message.ChooseEmoteSlot",
				_GetTemplateForMessageChooseEmoteSlot()
			},
			{
				"Message.ChooseEmoteSlotOrEmote",
				_GetTemplateForMessageChooseEmoteSlotOrEmote()
			},
			{
				"Message.DefaultClothing",
				_GetTemplateForMessageDefaultClothing()
			},
			{
				"Message.DeleteOutfit",
				_GetTemplateForMessageDeleteOutfit()
			},
			{
				"Message.DeleteThisCostume",
				_GetTemplateForMessageDeleteThisCostume()
			},
			{
				"Message.DeleteThisOutfit",
				_GetTemplateForMessageDeleteThisOutfit()
			},
			{
				"Message.EmotesInstructions",
				_GetTemplateForMessageEmotesInstructions()
			},
			{
				"Message.EmptyAssetList",
				_GetTemplateForMessageEmptyAssetList()
			},
			{
				"Message.EmptyListForItem",
				_GetTemplateForMessageEmptyListForItem()
			},
			{
				"Message.EmptyListOfCostumes",
				_GetTemplateForMessageEmptyListOfCostumes()
			},
			{
				"Message.EmptyListOfOutfits",
				_GetTemplateForMessageEmptyListOfOutfits()
			},
			{
				"Message.EmptyRecentItems",
				_GetTemplateForMessageEmptyRecentItems()
			},
			{
				"Message.ErrorCreateCostume",
				_GetTemplateForMessageErrorCreateCostume()
			},
			{
				"Message.ErrorCreateOutfit",
				_GetTemplateForMessageErrorCreateOutfit()
			},
			{
				"Message.ErrorDeleteEmote",
				_GetTemplateForMessageErrorDeleteEmote()
			},
			{
				"Message.ErrorEquipEmote",
				_GetTemplateForMessageErrorEquipEmote()
			},
			{
				"Message.ErrorLoadCostume",
				_GetTemplateForMessageErrorLoadCostume()
			},
			{
				"Message.ErrorLoadEmotes",
				_GetTemplateForMessageErrorLoadEmotes()
			},
			{
				"Message.ErrorLoadOutfits",
				_GetTemplateForMessageErrorLoadOutfits()
			},
			{
				"Message.ErrorOutfitName",
				_GetTemplateForMessageErrorOutfitName()
			},
			{
				"Message.ErrorRenameCostume",
				_GetTemplateForMessageErrorRenameCostume()
			},
			{
				"Message.ErrorRenameOutfit",
				_GetTemplateForMessageErrorRenameOutfit()
			},
			{
				"Message.ErrorUnequipEmote",
				_GetTemplateForMessageErrorUnequipEmote()
			},
			{
				"Message.ErrorUpdateCostume",
				_GetTemplateForMessageErrorUpdateCostume()
			},
			{
				"Message.ErrorUpdateEmote",
				_GetTemplateForMessageErrorUpdateEmote()
			},
			{
				"Message.ErrorUpdateOutfit",
				_GetTemplateForMessageErrorUpdateOutfit()
			},
			{
				"Message.ErrorUpdateWorn",
				_GetTemplateForMessageErrorUpdateWorn()
			},
			{
				"Message.ErrorWearCostume",
				_GetTemplateForMessageErrorWearCostume()
			},
			{
				"Message.ErrorWearOutfit",
				_GetTemplateForMessageErrorWearOutfit()
			},
			{
				"Message.FailedDeleteCostume",
				_GetTemplateForMessageFailedDeleteCostume()
			},
			{
				"Message.FailedDeleteEmote",
				_GetTemplateForMessageFailedDeleteEmote()
			},
			{
				"Message.FailedDeleteOutfit",
				_GetTemplateForMessageFailedDeleteOutfit()
			},
			{
				"Message.FailedLoadAssets",
				_GetTemplateForMessageFailedLoadAssets()
			},
			{
				"Message.FailedLoadRecent",
				_GetTemplateForMessageFailedLoadRecent()
			},
			{
				"Message.FailedUpdateBodyColor",
				_GetTemplateForMessageFailedUpdateBodyColor()
			},
			{
				"Message.FailedUpdateDeletedCostume",
				_GetTemplateForMessageFailedUpdateDeletedCostume()
			},
			{
				"Message.FailedUpdateDeletedOutfit",
				_GetTemplateForMessageFailedUpdateDeletedOutfit()
			},
			{
				"Message.FailedUpdateScales",
				_GetTemplateForMessageFailedUpdateScales()
			},
			{
				"Message.FailedUpdateType",
				_GetTemplateForMessageFailedUpdateType()
			},
			{
				"Message.FailedWearPackage",
				_GetTemplateForMessageFailedWearPackage()
			},
			{
				"Message.HatLimitTooltip",
				_GetTemplateForMessageHatLimitTooltip()
			},
			{
				"Message.InvalidOutfitName",
				_GetTemplateForMessageInvalidOutfitName()
			},
			{
				"Message.Loading",
				_GetTemplateForMessageLoading()
			},
			{
				"Message.MissingItemsFromOutfit",
				_GetTemplateForMessageMissingItemsFromOutfit()
			},
			{
				"Message.PageUnavailable",
				_GetTemplateForMessagePageUnavailable()
			},
			{
				"Message.PresetCostumesDelay",
				_GetTemplateForMessagePresetCostumesDelay()
			},
			{
				"Message.ReachedMaxCostumes",
				_GetTemplateForMessageReachedMaxCostumes()
			},
			{
				"Message.ReachedMaxOutfits",
				_GetTemplateForMessageReachedMaxOutfits()
			},
			{
				"Message.RedirectAvatarSettings",
				_GetTemplateForMessageRedirectAvatarSettings()
			},
			{
				"Message.RedrawFloodchecked",
				_GetTemplateForMessageRedrawFloodchecked()
			},
			{
				"Message.RedrawThumbnailFailed",
				_GetTemplateForMessageRedrawThumbnailFailed()
			},
			{
				"Message.SelectEnableScaling",
				_GetTemplateForMessageSelectEnableScaling()
			},
			{
				"Message.Success",
				_GetTemplateForMessageSuccess()
			},
			{
				"Message.SuccessCreateCostume",
				_GetTemplateForMessageSuccessCreateCostume()
			},
			{
				"Message.SuccessCreateOutfit",
				_GetTemplateForMessageSuccessCreateOutfit()
			},
			{
				"Message.SuccessDeleteCostume",
				_GetTemplateForMessageSuccessDeleteCostume()
			},
			{
				"Message.SuccessDeleteOutfit",
				_GetTemplateForMessageSuccessDeleteOutfit()
			},
			{
				"Message.SuccessEquipEmote",
				_GetTemplateForMessageSuccessEquipEmote()
			},
			{
				"Message.SuccessRenameCostume",
				_GetTemplateForMessageSuccessRenameCostume()
			},
			{
				"Message.SuccessRenameOutfit",
				_GetTemplateForMessageSuccessRenameOutfit()
			},
			{
				"Message.SuccessSavedAccessories",
				_GetTemplateForMessageSuccessSavedAccessories()
			},
			{
				"Message.SuccessUnequipEmote",
				_GetTemplateForMessageSuccessUnequipEmote()
			},
			{
				"Message.SuccessUpdatedCostume",
				_GetTemplateForMessageSuccessUpdatedCostume()
			},
			{
				"Message.SuccessUpdatedOutfit",
				_GetTemplateForMessageSuccessUpdatedOutfit()
			},
			{
				"Message.SuccessWoreCostume",
				_GetTemplateForMessageSuccessWoreCostume()
			},
			{
				"Message.SuccessWoreOutfit",
				_GetTemplateForMessageSuccessWoreOutfit()
			},
			{
				"Message.UpdateOutfit",
				_GetTemplateForMessageUpdateOutfit()
			},
			{
				"Message.UpdateThisCostume",
				_GetTemplateForMessageUpdateThisCostume()
			},
			{
				"Message.UpdateThisOutfit",
				_GetTemplateForMessageUpdateThisOutfit()
			},
			{
				"Message.Warning",
				_GetTemplateForMessageWarning()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Avatar";
	}

	protected virtual string _GetTemplateForActionAdvanced()
	{
		return "Advanced";
	}

	protected virtual string _GetTemplateForActionBuy()
	{
		return "Buy";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForActionCreate()
	{
		return "Create";
	}

	protected virtual string _GetTemplateForActionCreateNewOutfit()
	{
		return "Create";
	}

	protected virtual string _GetTemplateForActionDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForActionDone()
	{
		return "Done";
	}

	protected virtual string _GetTemplateForActionGet()
	{
		return "Get";
	}

	protected virtual string _GetTemplateForActionGetMore()
	{
		return "Get More";
	}

	protected virtual string _GetTemplateForActionOpenRobloxApp()
	{
		return "Open Roblox App";
	}

	protected virtual string _GetTemplateForActionRedraw()
	{
		return "Redraw";
	}

	protected virtual string _GetTemplateForActionRename()
	{
		return "Rename";
	}

	protected virtual string _GetTemplateForActionRenameOutfit()
	{
		return "Rename";
	}

	protected virtual string _GetTemplateForActionSave()
	{
		return "Save";
	}

	protected virtual string _GetTemplateForActionSeeAll()
	{
		return "See All";
	}

	protected virtual string _GetTemplateForActionThreeDimensions()
	{
		return "3D";
	}

	protected virtual string _GetTemplateForActionTwoDimensions()
	{
		return "2D";
	}

	protected virtual string _GetTemplateForActionUpdate()
	{
		return "Update";
	}

	protected virtual string _GetTemplateForActionUserUnderstands()
	{
		return "Got it";
	}

	protected virtual string _GetTemplateForDescriptionAvatarEditorUpsell()
	{
		return "To change your look you will need to use the Avatar Editor on the App.";
	}

	protected virtual string _GetTemplateForDescriptionCreateNewCostume()
	{
		return "A costume will be created from your avatar's current appearance.";
	}

	protected virtual string _GetTemplateForDescriptionCreateNewOutfit()
	{
		return "An outfit will be created from your avatar's current appearance.";
	}

	protected virtual string _GetTemplateForDescriptionRenameCostume()
	{
		return "Choose a new name for your costume.";
	}

	protected virtual string _GetTemplateForDescriptionRenameOutfit()
	{
		return "Choose a new name for your outfit.";
	}

	protected virtual string _GetTemplateForHeadingAccessories()
	{
		return "Accessories";
	}

	protected virtual string _GetTemplateForHeadingAccessoriesChange()
	{
		return "Accessories Change";
	}

	protected virtual string _GetTemplateForHeadingAdvancedOptions()
	{
		return "Advanced Options";
	}

	protected virtual string _GetTemplateForHeadingAll()
	{
		return "All";
	}

	protected virtual string _GetTemplateForHeadingAnimations()
	{
		return "Animations";
	}

	protected virtual string _GetTemplateForHeadingAppearance()
	{
		return "Appearance";
	}

	protected virtual string _GetTemplateForHeadingAvatarPageTitle()
	{
		return "Avatar Editor";
	}

	protected virtual string _GetTemplateForHeadingBody()
	{
		return "Body";
	}

	protected virtual string _GetTemplateForHeadingBodyParts()
	{
		return "Body Parts";
	}

	protected virtual string _GetTemplateForHeadingClothing()
	{
		return "Clothing";
	}

	protected virtual string _GetTemplateForHeadingCostumes()
	{
		return "Costumes";
	}

	protected virtual string _GetTemplateForHeadingCreateNewCostume()
	{
		return "Create New Costume";
	}

	protected virtual string _GetTemplateForHeadingCreateNewOutfit()
	{
		return "Create New Outfit";
	}

	protected virtual string _GetTemplateForHeadingDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForHeadingDeleteCostume()
	{
		return "Delete Costume";
	}

	protected virtual string _GetTemplateForHeadingDeleteOutfit()
	{
		return "Delete Outfit";
	}

	protected virtual string _GetTemplateForHeadingEmotes()
	{
		return "Emotes";
	}

	protected virtual string _GetTemplateForHeadingEquipEmotes()
	{
		return "Equip Emotes";
	}

	protected virtual string _GetTemplateForHeadingOutfits()
	{
		return "Outfits";
	}

	protected virtual string _GetTemplateForHeadingPackages()
	{
		return "Packages";
	}

	protected virtual string _GetTemplateForHeadingRecent()
	{
		return "Recent";
	}

	protected virtual string _GetTemplateForHeadingRecommended()
	{
		return "Recommended";
	}

	protected virtual string _GetTemplateForHeadingRenameCostume()
	{
		return "Rename Costume";
	}

	protected virtual string _GetTemplateForHeadingRenameOutfit()
	{
		return "Rename Outfit";
	}

	protected virtual string _GetTemplateForHeadingScaling()
	{
		return "Scaling";
	}

	protected virtual string _GetTemplateForHeadingSkinToneBodyParts()
	{
		return "Skin Tone by Body Parts";
	}

	protected virtual string _GetTemplateForHeadingUpdate()
	{
		return "Update";
	}

	protected virtual string _GetTemplateForHeadingUpdateCostume()
	{
		return "Update Costume";
	}

	protected virtual string _GetTemplateForHeadingUpdateOutfit()
	{
		return "Update Outfit";
	}

	protected virtual string _GetTemplateForLabelAll()
	{
		return "All";
	}

	protected virtual string _GetTemplateForLabelAskIfLoadingCorrectly()
	{
		return "Avatar isn't loading correctly?";
	}

	protected virtual string _GetTemplateForLabelAssetIDPlaceholder()
	{
		return "Asset ID";
	}

	protected virtual string _GetTemplateForLabelBack()
	{
		return "Back";
	}

	protected virtual string _GetTemplateForLabelBackAccessories()
	{
		return "Back Accessories";
	}

	protected virtual string _GetTemplateForLabelBodyType()
	{
		return "Body Type";
	}

	protected virtual string _GetTemplateForLabelClimb()
	{
		return "Climb";
	}

	protected virtual string _GetTemplateForLabelClimbAnimations()
	{
		return "Climb Animations";
	}

	protected virtual string _GetTemplateForLabelClothes()
	{
		return "Clothes";
	}

	protected virtual string _GetTemplateForLabelCostume()
	{
		return "Costume";
	}

	/// <summary>
	/// Key: "Label.DirectionsForPackagePlacement"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}"
	/// </summary>
	public virtual string LabelDirectionsForPackagePlacement(string startBold, string rightArrow, string endBold)
	{
		return $"Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}";
	}

	protected virtual string _GetTemplateForLabelDirectionsForPackagePlacement()
	{
		return "Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}";
	}

	/// <summary>
	/// Key: "Label.DirectionsForScalingOptions"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}"
	/// </summary>
	public virtual string LabelDirectionsForScalingOptions(string startBold, string rightArrow, string endBold)
	{
		return $"Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}";
	}

	protected virtual string _GetTemplateForLabelDirectionsForScalingOptions()
	{
		return "Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}";
	}

	protected virtual string _GetTemplateForlabelEmotes()
	{
		return "Emotes";
	}

	protected virtual string _GetTemplateForLabelEquip()
	{
		return "Equip";
	}

	protected virtual string _GetTemplateForLabelExploreCatalog()
	{
		return "Explore the catalog to find more clothes!";
	}

	protected virtual string _GetTemplateForLabelFace()
	{
		return "Face";
	}

	protected virtual string _GetTemplateForLabelFaceAccessories()
	{
		return "Face Accessories";
	}

	protected virtual string _GetTemplateForLabelFaces()
	{
		return "Faces";
	}

	protected virtual string _GetTemplateForLabelFall()
	{
		return "Fall";
	}

	protected virtual string _GetTemplateForLabelFallAnimations()
	{
		return "Fall Animations";
	}

	protected virtual string _GetTemplateForLabelFree()
	{
		return "Free";
	}

	protected virtual string _GetTemplateForLabelFront()
	{
		return "Front";
	}

	protected virtual string _GetTemplateForLabelFrontAccessories()
	{
		return "Front Accessories";
	}

	protected virtual string _GetTemplateForLabelGear()
	{
		return "Gear";
	}

	protected virtual string _GetTemplateForLabelHair()
	{
		return "Hair";
	}

	protected virtual string _GetTemplateForLabelHairAccessories()
	{
		return "Hair Accessories";
	}

	protected virtual string _GetTemplateForLabelHat()
	{
		return "Hat";
	}

	protected virtual string _GetTemplateForLabelHatAccessories()
	{
		return "Hat Accessories";
	}

	protected virtual string _GetTemplateForLabelHead()
	{
		return "Head";
	}

	protected virtual string _GetTemplateForLabelHeads()
	{
		return "Heads";
	}

	protected virtual string _GetTemplateForLabelHeight()
	{
		return "Height";
	}

	protected virtual string _GetTemplateForLabelIdle()
	{
		return "Idle";
	}

	protected virtual string _GetTemplateForLabelIdleAnimations()
	{
		return "Idle Animations";
	}

	protected virtual string _GetTemplateForLabelJump()
	{
		return "Jump";
	}

	protected virtual string _GetTemplateForLabelJumpAnimations()
	{
		return "Jump Animations";
	}

	protected virtual string _GetTemplateForLabelLeftArm()
	{
		return "Left Arm";
	}

	protected virtual string _GetTemplateForLabelLeftArms()
	{
		return "Left Arms";
	}

	protected virtual string _GetTemplateForLabelLeftLeg()
	{
		return "Left Leg";
	}

	protected virtual string _GetTemplateForLabelLeftLegs()
	{
		return "Left Legs";
	}

	protected virtual string _GetTemplateForLabelMyCostumes()
	{
		return "My Costumes";
	}

	protected virtual string _GetTemplateForLabelNamePlaceholderCostume()
	{
		return "Name your costume";
	}

	protected virtual string _GetTemplateForLabelNamePlaceholderOutfit()
	{
		return "Name your outfit";
	}

	protected virtual string _GetTemplateForLabelNeck()
	{
		return "Neck";
	}

	protected virtual string _GetTemplateForLabelNeckAccessories()
	{
		return "Neck Accessories";
	}

	protected virtual string _GetTemplateForLabelNoResellers()
	{
		return "No resellers";
	}

	protected virtual string _GetTemplateForLabelOffSale()
	{
		return "Off sale";
	}

	protected virtual string _GetTemplateForLabelOutfit()
	{
		return "Outfit";
	}

	protected virtual string _GetTemplateForLabelPants()
	{
		return "Pants";
	}

	protected virtual string _GetTemplateForLabelParts()
	{
		return "Parts";
	}

	protected virtual string _GetTemplateForLabelPresetCostumes()
	{
		return "Preset Costumes";
	}

	protected virtual string _GetTemplateForLabelProportions()
	{
		return "Proportions";
	}

	protected virtual string _GetTemplateForLabelRedrawUnavailable()
	{
		return "Avatar redraw is unavailable.";
	}

	protected virtual string _GetTemplateForLabelRightArm()
	{
		return "Right Arm";
	}

	protected virtual string _GetTemplateForLabelRightArms()
	{
		return "Right Arms";
	}

	protected virtual string _GetTemplateForLabelRightLeg()
	{
		return "Right Leg";
	}

	protected virtual string _GetTemplateForLabelRightLegs()
	{
		return "Right Legs";
	}

	protected virtual string _GetTemplateForLabelRun()
	{
		return "Run";
	}

	protected virtual string _GetTemplateForLabelRunAnimations()
	{
		return "Run Animations";
	}

	protected virtual string _GetTemplateForLabelScale()
	{
		return "Scale";
	}

	protected virtual string _GetTemplateForLabelShirts()
	{
		return "Shirts";
	}

	protected virtual string _GetTemplateForLabelShoulderAccessories()
	{
		return "Shoulder Accessories";
	}

	protected virtual string _GetTemplateForLabelShoulders()
	{
		return "Shoulders";
	}

	protected virtual string _GetTemplateForLabelSkinTone()
	{
		return "Skin Tone";
	}

	protected virtual string _GetTemplateForLabelSwim()
	{
		return "Swim";
	}

	protected virtual string _GetTemplateForLabelSwimAnimations()
	{
		return "Swim Animations";
	}

	protected virtual string _GetTemplateForLabelSwitchAvatarType()
	{
		return "Switch between classic R6 avatar and more expressive next generation R15 avatar";
	}

	protected virtual string _GetTemplateForLabelTorso()
	{
		return "Torso";
	}

	protected virtual string _GetTemplateForLabelTorsos()
	{
		return "Torsos";
	}

	protected virtual string _GetTemplateForLabelTShirts()
	{
		return "T-Shirts";
	}

	protected virtual string _GetTemplateForLabelWaist()
	{
		return "Waist";
	}

	protected virtual string _GetTemplateForLabelWaistAccessories()
	{
		return "Waist Accessories";
	}

	protected virtual string _GetTemplateForLabelWalk()
	{
		return "Walk";
	}

	protected virtual string _GetTemplateForLabelWalkAnimations()
	{
		return "Walk Animations";
	}

	protected virtual string _GetTemplateForLabelWidth()
	{
		return "Width";
	}

	protected virtual string _GetTemplateForLabelYourEmotes()
	{
		return "Your Emotes";
	}

	protected virtual string _GetTemplateForMessageAccessoriesChange()
	{
		return "Are you sure you want to override your current look?";
	}

	protected virtual string _GetTemplateForMessageChooseEmote()
	{
		return "Choose an Emote";
	}

	protected virtual string _GetTemplateForMessageChooseEmoteSlot()
	{
		return "Choose a slot";
	}

	protected virtual string _GetTemplateForMessageChooseEmoteSlotOrEmote()
	{
		return "Choose a slot or an Emote";
	}

	protected virtual string _GetTemplateForMessageDefaultClothing()
	{
		return "Default clothing has been applied to your avatar - wear something from your clothing.";
	}

	/// <summary>
	/// Key: "Message.DeleteOutfit"
	/// English String: "Are you sure you want to delete this {outfitType}?"
	/// </summary>
	public virtual string MessageDeleteOutfit(string outfitType)
	{
		return $"Are you sure you want to delete this {outfitType}?";
	}

	protected virtual string _GetTemplateForMessageDeleteOutfit()
	{
		return "Are you sure you want to delete this {outfitType}?";
	}

	protected virtual string _GetTemplateForMessageDeleteThisCostume()
	{
		return "Are you sure you want to delete this costume?";
	}

	protected virtual string _GetTemplateForMessageDeleteThisOutfit()
	{
		return "Are you sure you want to delete this outfit?";
	}

	protected virtual string _GetTemplateForMessageEmotesInstructions()
	{
		return "Go to \"Animations\" > \"Emotes\" > \"Equip Emotes\" to equip an emote.";
	}

	protected virtual string _GetTemplateForMessageEmptyAssetList()
	{
		return "You don't have any.";
	}

	/// <summary>
	/// Key: "Message.EmptyListForItem"
	/// The user tries to load a list of some item but they see nothing because they don't own anything of that type.
	/// English String: "You don't have this item: {itemType}"
	/// </summary>
	public virtual string MessageEmptyListForItem(string itemType)
	{
		return $"You don't have this item: {itemType}";
	}

	protected virtual string _GetTemplateForMessageEmptyListForItem()
	{
		return "You don't have this item: {itemType}";
	}

	protected virtual string _GetTemplateForMessageEmptyListOfCostumes()
	{
		return "You don't have any costumes. Try creating some!";
	}

	protected virtual string _GetTemplateForMessageEmptyListOfOutfits()
	{
		return "You don't have any outfits. Try creating some!";
	}

	protected virtual string _GetTemplateForMessageEmptyRecentItems()
	{
		return "You don't have any recent items.";
	}

	protected virtual string _GetTemplateForMessageErrorCreateCostume()
	{
		return "Unable to create costume, try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorCreateOutfit()
	{
		return "Unable to create outfit, try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorDeleteEmote()
	{
		return "Failed to delete emote.";
	}

	protected virtual string _GetTemplateForMessageErrorEquipEmote()
	{
		return "Failed to equip emote, please try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorLoadCostume()
	{
		return "Failed to load costume.";
	}

	protected virtual string _GetTemplateForMessageErrorLoadEmotes()
	{
		return "Failed to load emotes.";
	}

	protected virtual string _GetTemplateForMessageErrorLoadOutfits()
	{
		return "Failed to load outfits.";
	}

	protected virtual string _GetTemplateForMessageErrorOutfitName()
	{
		return "Name can contain letters, numbers, and spaces.";
	}

	protected virtual string _GetTemplateForMessageErrorRenameCostume()
	{
		return "Failed to rename costume.";
	}

	protected virtual string _GetTemplateForMessageErrorRenameOutfit()
	{
		return "Failed to rename outfit.";
	}

	protected virtual string _GetTemplateForMessageErrorUnequipEmote()
	{
		return "Failed to unequip emote.";
	}

	protected virtual string _GetTemplateForMessageErrorUpdateCostume()
	{
		return "Costume update failed, please try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorUpdateEmote()
	{
		return "Updating emote slot failed, please try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorUpdateOutfit()
	{
		return "Outfit update failed, please try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorUpdateWorn()
	{
		return "Error while updating worn items.";
	}

	protected virtual string _GetTemplateForMessageErrorWearCostume()
	{
		return "Failed to wear costume.";
	}

	protected virtual string _GetTemplateForMessageErrorWearOutfit()
	{
		return "Failed to wear outfit.";
	}

	protected virtual string _GetTemplateForMessageFailedDeleteCostume()
	{
		return "Failed to delete costume.";
	}

	protected virtual string _GetTemplateForMessageFailedDeleteEmote()
	{
		return "Failed to delete emote.";
	}

	protected virtual string _GetTemplateForMessageFailedDeleteOutfit()
	{
		return "Failed to delete outfit.";
	}

	protected virtual string _GetTemplateForMessageFailedLoadAssets()
	{
		return "Failed to load assets list.";
	}

	protected virtual string _GetTemplateForMessageFailedLoadRecent()
	{
		return "Failed to load recent items.";
	}

	protected virtual string _GetTemplateForMessageFailedUpdateBodyColor()
	{
		return "Failed to update skin tone.";
	}

	protected virtual string _GetTemplateForMessageFailedUpdateDeletedCostume()
	{
		return "The costume you tried to update no longer exists.";
	}

	protected virtual string _GetTemplateForMessageFailedUpdateDeletedOutfit()
	{
		return "The outfit you tried to update no longer exists.";
	}

	protected virtual string _GetTemplateForMessageFailedUpdateScales()
	{
		return "Failed to update scales.";
	}

	protected virtual string _GetTemplateForMessageFailedUpdateType()
	{
		return "Failed to update avatar type.";
	}

	protected virtual string _GetTemplateForMessageFailedWearPackage()
	{
		return "Failed to wear package.";
	}

	protected virtual string _GetTemplateForMessageHatLimitTooltip()
	{
		return "You can wear up to 3 hats";
	}

	protected virtual string _GetTemplateForMessageInvalidOutfitName()
	{
		return "Name must be appropriate and less than 200 characters.";
	}

	protected virtual string _GetTemplateForMessageLoading()
	{
		return "Loading...";
	}

	/// <summary>
	/// Key: "Message.MissingItemsFromOutfit"
	/// User cannot wear an outfit because they are missing or have deleted some of the items that were part of that outfit.
	/// English String: "Number of items that you don't own in this outfit: {number}"
	/// </summary>
	public virtual string MessageMissingItemsFromOutfit(string number)
	{
		return $"Number of items that you don't own in this outfit: {number}";
	}

	protected virtual string _GetTemplateForMessageMissingItemsFromOutfit()
	{
		return "Number of items that you don't own in this outfit: {number}";
	}

	protected virtual string _GetTemplateForMessagePageUnavailable()
	{
		return "The avatar page is temporarily unavailable.";
	}

	protected virtual string _GetTemplateForMessagePresetCostumesDelay()
	{
		return "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!";
	}

	protected virtual string _GetTemplateForMessageReachedMaxCostumes()
	{
		return "You have reached the maximum number of costumes.";
	}

	protected virtual string _GetTemplateForMessageReachedMaxOutfits()
	{
		return "You have reached the maximum number of outfits.";
	}

	protected virtual string _GetTemplateForMessageRedirectAvatarSettings()
	{
		return "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home > Game Settings > Avatar";
	}

	protected virtual string _GetTemplateForMessageRedrawFloodchecked()
	{
		return "You have redrawn your avatar too many times, please try again later.";
	}

	protected virtual string _GetTemplateForMessageRedrawThumbnailFailed()
	{
		return "Failed to redraw thumbnail.";
	}

	protected virtual string _GetTemplateForMessageSelectEnableScaling()
	{
		return "Select R15 to enable scaling.";
	}

	protected virtual string _GetTemplateForMessageSuccess()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForMessageSuccessCreateCostume()
	{
		return "Created costume";
	}

	protected virtual string _GetTemplateForMessageSuccessCreateOutfit()
	{
		return "Created outfit";
	}

	protected virtual string _GetTemplateForMessageSuccessDeleteCostume()
	{
		return "Deleted costume";
	}

	protected virtual string _GetTemplateForMessageSuccessDeleteOutfit()
	{
		return "Deleted outfit";
	}

	protected virtual string _GetTemplateForMessageSuccessEquipEmote()
	{
		return "Equipped Emote";
	}

	protected virtual string _GetTemplateForMessageSuccessRenameCostume()
	{
		return "Renamed costume";
	}

	protected virtual string _GetTemplateForMessageSuccessRenameOutfit()
	{
		return "Renamed outfit";
	}

	protected virtual string _GetTemplateForMessageSuccessSavedAccessories()
	{
		return "Saved accessories";
	}

	protected virtual string _GetTemplateForMessageSuccessUnequipEmote()
	{
		return "Unequipped emote";
	}

	protected virtual string _GetTemplateForMessageSuccessUpdatedCostume()
	{
		return "Updated costume";
	}

	protected virtual string _GetTemplateForMessageSuccessUpdatedOutfit()
	{
		return "Updated outfit";
	}

	protected virtual string _GetTemplateForMessageSuccessWoreCostume()
	{
		return "Successfully wore costume";
	}

	protected virtual string _GetTemplateForMessageSuccessWoreOutfit()
	{
		return "Successfully wore outfit";
	}

	/// <summary>
	/// Key: "Message.UpdateOutfit"
	/// English String: "Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance."
	/// </summary>
	public virtual string MessageUpdateOutfit(string outfitType1, string outfitType2)
	{
		return $"Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance.";
	}

	protected virtual string _GetTemplateForMessageUpdateOutfit()
	{
		return "Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance.";
	}

	protected virtual string _GetTemplateForMessageUpdateThisCostume()
	{
		return "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance.";
	}

	protected virtual string _GetTemplateForMessageUpdateThisOutfit()
	{
		return "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance.";
	}

	protected virtual string _GetTemplateForMessageWarning()
	{
		return "Warning";
	}
}
