namespace Roblox.TranslationResources.Feature;

public interface IAvatarResources : ITranslationResources
{
	/// <summary>
	/// Key: "Action.Advanced"
	/// Click Advanced to get the advanced options
	/// English String: "Advanced"
	/// </summary>
	string ActionAdvanced { get; }

	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item to customize the user's avatar.
	/// English String: "Buy"
	/// </summary>
	string ActionBuy { get; }

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	string ActionCancel { get; }

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	string ActionClose { get; }

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	string ActionCreate { get; }

	/// <summary>
	/// Key: "Action.CreateNewOutfit"
	/// Button to create new outfit
	/// English String: "Create"
	/// </summary>
	string ActionCreateNewOutfit { get; }

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	string ActionDelete { get; }

	/// <summary>
	/// Key: "Action.Done"
	/// English String: "Done"
	/// </summary>
	string ActionDone { get; }

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy get an item for free to customize the user's avatar.
	/// English String: "Get"
	/// </summary>
	string ActionGet { get; }

	/// <summary>
	/// Key: "Action.GetMore"
	/// A call to action for the user to buy more clothes from the Catalog page. This could improve how their avatar looks.
	/// English String: "Get More"
	/// </summary>
	string ActionGetMore { get; }

	/// <summary>
	/// Key: "Action.OpenRobloxApp"
	/// English String: "Open Roblox App"
	/// </summary>
	string ActionOpenRobloxApp { get; }

	/// <summary>
	/// Key: "Action.Redraw"
	/// Redraw the avatar on the screen
	/// English String: "Redraw"
	/// </summary>
	string ActionRedraw { get; }

	/// <summary>
	/// Key: "Action.Rename"
	/// English String: "Rename"
	/// </summary>
	string ActionRename { get; }

	/// <summary>
	/// Key: "Action.RenameOutfit"
	/// Button to rename outfit
	/// English String: "Rename"
	/// </summary>
	string ActionRenameOutfit { get; }

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	string ActionSave { get; }

	/// <summary>
	/// Key: "Action.SeeAll"
	/// See all clothing that user can buy
	/// English String: "See All"
	/// </summary>
	string ActionSeeAll { get; }

	/// <summary>
	/// Key: "Action.ThreeDimensions"
	/// This button allows the user to view their avatar in three dimensions.
	/// English String: "3D"
	/// </summary>
	string ActionThreeDimensions { get; }

	/// <summary>
	/// Key: "Action.TwoDimensions"
	/// This button allows the user to view their avatar in two dimensions.
	/// English String: "2D"
	/// </summary>
	string ActionTwoDimensions { get; }

	/// <summary>
	/// Key: "Action.Update"
	/// English String: "Update"
	/// </summary>
	string ActionUpdate { get; }

	/// <summary>
	/// Key: "Action.UserUnderstands"
	/// The user casually responds to the application saying that they understand how to navigate the menu.
	/// English String: "Got it"
	/// </summary>
	string ActionUserUnderstands { get; }

	/// <summary>
	/// Key: "Description.AvatarEditorUpsell"
	/// English String: "To change your look you will need to use the Avatar Editor on the App."
	/// </summary>
	string DescriptionAvatarEditorUpsell { get; }

	/// <summary>
	/// Key: "Description.CreateNewCostume"
	/// A costume will be created from your avatar's current appearance.
	/// English String: "A costume will be created from your avatar's current appearance."
	/// </summary>
	string DescriptionCreateNewCostume { get; }

	/// <summary>
	/// Key: "Description.CreateNewOutfit"
	/// An outfit will be created from your avatar's current appearance.
	/// English String: "An outfit will be created from your avatar's current appearance."
	/// </summary>
	string DescriptionCreateNewOutfit { get; }

	/// <summary>
	/// Key: "Description.RenameCostume"
	/// Choose a new name for your costume.
	/// English String: "Choose a new name for your costume."
	/// </summary>
	string DescriptionRenameCostume { get; }

	/// <summary>
	/// Key: "Description.RenameOutfit"
	/// Choose a new name for your outfit.
	/// English String: "Choose a new name for your outfit."
	/// </summary>
	string DescriptionRenameOutfit { get; }

	/// <summary>
	/// Key: "Heading.Accessories"
	/// English String: "Accessories"
	/// </summary>
	string HeadingAccessories { get; }

	/// <summary>
	/// Key: "Heading.AccessoriesChange"
	/// English String: "Accessories Change"
	/// </summary>
	string HeadingAccessoriesChange { get; }

	/// <summary>
	/// Key: "Heading.AdvancedOptions"
	/// English String: "Advanced Options"
	/// </summary>
	string HeadingAdvancedOptions { get; }

	/// <summary>
	/// Key: "Heading.All"
	/// All avatar modification types
	/// English String: "All"
	/// </summary>
	string HeadingAll { get; }

	/// <summary>
	/// Key: "Heading.Animations"
	/// English String: "Animations"
	/// </summary>
	string HeadingAnimations { get; }

	/// <summary>
	/// Key: "Heading.Appearance"
	/// English String: "Appearance"
	/// </summary>
	string HeadingAppearance { get; }

	/// <summary>
	/// Key: "Heading.AvatarPageTitle"
	/// Page title for the Avatar page. On this page, the user can modify how they look.
	/// English String: "Avatar Editor"
	/// </summary>
	string HeadingAvatarPageTitle { get; }

	/// <summary>
	/// Key: "Heading.Body"
	/// English String: "Body"
	/// </summary>
	string HeadingBody { get; }

	/// <summary>
	/// Key: "Heading.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	string HeadingBodyParts { get; }

	/// <summary>
	/// Key: "Heading.Clothing"
	/// English String: "Clothing"
	/// </summary>
	string HeadingClothing { get; }

	/// <summary>
	/// Key: "Heading.Costumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Costumes"
	/// </summary>
	string HeadingCostumes { get; }

	/// <summary>
	/// Key: "Heading.CreateNewCostume"
	/// NOTE: Costume is a more whimsical word choice for outfit. Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Create New Costume"
	/// </summary>
	string HeadingCreateNewCostume { get; }

	/// <summary>
	/// Key: "Heading.CreateNewOutfit"
	/// English String: "Create New Outfit"
	/// </summary>
	string HeadingCreateNewOutfit { get; }

	/// <summary>
	/// Key: "Heading.Delete"
	/// English String: "Delete"
	/// </summary>
	string HeadingDelete { get; }

	/// <summary>
	/// Key: "Heading.DeleteCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Delete Costume"
	/// </summary>
	string HeadingDeleteCostume { get; }

	/// <summary>
	/// Key: "Heading.DeleteOutfit"
	/// English String: "Delete Outfit"
	/// </summary>
	string HeadingDeleteOutfit { get; }

	/// <summary>
	/// Key: "Heading.Emotes"
	/// English String: "Emotes"
	/// </summary>
	string HeadingEmotes { get; }

	/// <summary>
	/// Key: "Heading.EquipEmotes"
	/// English String: "Equip Emotes"
	/// </summary>
	string HeadingEquipEmotes { get; }

	/// <summary>
	/// Key: "Heading.Outfits"
	/// English String: "Outfits"
	/// </summary>
	string HeadingOutfits { get; }

	/// <summary>
	/// Key: "Heading.Packages"
	/// English String: "Packages"
	/// </summary>
	string HeadingPackages { get; }

	/// <summary>
	/// Key: "Heading.Recent"
	/// English String: "Recent"
	/// </summary>
	string HeadingRecent { get; }

	/// <summary>
	/// Key: "Heading.Recommended"
	/// See recommended clothing for your avatar
	/// English String: "Recommended"
	/// </summary>
	string HeadingRecommended { get; }

	/// <summary>
	/// Key: "Heading.RenameCostume"
	/// English String: "Rename Costume"
	/// </summary>
	string HeadingRenameCostume { get; }

	/// <summary>
	/// Key: "Heading.RenameOutfit"
	/// English String: "Rename Outfit"
	/// </summary>
	string HeadingRenameOutfit { get; }

	/// <summary>
	/// Key: "Heading.Scaling"
	/// English String: "Scaling"
	/// </summary>
	string HeadingScaling { get; }

	/// <summary>
	/// Key: "Heading.SkinToneBodyParts"
	/// English String: "Skin Tone by Body Parts"
	/// </summary>
	string HeadingSkinToneBodyParts { get; }

	/// <summary>
	/// Key: "Heading.Update"
	/// English String: "Update"
	/// </summary>
	string HeadingUpdate { get; }

	/// <summary>
	/// Key: "Heading.UpdateCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Update Costume"
	/// </summary>
	string HeadingUpdateCostume { get; }

	/// <summary>
	/// Key: "Heading.UpdateOutfit"
	/// English String: "Update Outfit"
	/// </summary>
	string HeadingUpdateOutfit { get; }

	/// <summary>
	/// Key: "Label.All"
	/// All body parts. This label will allow for body parts to change color
	/// English String: "All"
	/// </summary>
	string LabelAll { get; }

	/// <summary>
	/// Key: "Label.AskIfLoadingCorrectly"
	/// Avatar isn't loading correctly?
	/// English String: "Avatar isn't loading correctly?"
	/// </summary>
	string LabelAskIfLoadingCorrectly { get; }

	/// <summary>
	/// Key: "Label.AssetIDPlaceholder"
	/// This refers to the Asset ID which is a technical word for the Identification Number of an item or asset.
	/// English String: "Asset ID"
	/// </summary>
	string LabelAssetIDPlaceholder { get; }

	/// <summary>
	/// Key: "Label.Back"
	/// English String: "Back"
	/// </summary>
	string LabelBack { get; }

	/// <summary>
	/// Key: "Label.BackAccessories"
	/// English String: "Back Accessories"
	/// </summary>
	string LabelBackAccessories { get; }

	/// <summary>
	/// Key: "Label.BodyType"
	/// English String: "Body Type"
	/// </summary>
	string LabelBodyType { get; }

	/// <summary>
	/// Key: "Label.Climb"
	/// English String: "Climb"
	/// </summary>
	string LabelClimb { get; }

	/// <summary>
	/// Key: "Label.ClimbAnimations"
	/// English String: "Climb Animations"
	/// </summary>
	string LabelClimbAnimations { get; }

	/// <summary>
	/// Key: "Label.Clothes"
	/// English String: "Clothes"
	/// </summary>
	string LabelClothes { get; }

	/// <summary>
	/// Key: "Label.Costume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Costume"
	/// </summary>
	string LabelCostume { get; }

	/// <summary>
	/// Key: "label.Emotes"
	/// English String: "Emotes"
	/// </summary>
	string labelEmotes { get; }

	/// <summary>
	/// Key: "Label.Equip"
	/// English String: "Equip"
	/// </summary>
	string LabelEquip { get; }

	/// <summary>
	/// Key: "Label.ExploreCatalog"
	/// This text entices users to shop for more things to wear on their avatar
	/// English String: "Explore the catalog to find more clothes!"
	/// </summary>
	string LabelExploreCatalog { get; }

	/// <summary>
	/// Key: "Label.Face"
	/// English String: "Face"
	/// </summary>
	string LabelFace { get; }

	/// <summary>
	/// Key: "Label.FaceAccessories"
	/// English String: "Face Accessories"
	/// </summary>
	string LabelFaceAccessories { get; }

	/// <summary>
	/// Key: "Label.Faces"
	/// English String: "Faces"
	/// </summary>
	string LabelFaces { get; }

	/// <summary>
	/// Key: "Label.Fall"
	/// English String: "Fall"
	/// </summary>
	string LabelFall { get; }

	/// <summary>
	/// Key: "Label.FallAnimations"
	/// English String: "Fall Animations"
	/// </summary>
	string LabelFallAnimations { get; }

	/// <summary>
	/// Key: "Label.Free"
	/// Text label for recommended items
	/// English String: "Free"
	/// </summary>
	string LabelFree { get; }

	/// <summary>
	/// Key: "Label.Front"
	/// English String: "Front"
	/// </summary>
	string LabelFront { get; }

	/// <summary>
	/// Key: "Label.FrontAccessories"
	/// English String: "Front Accessories"
	/// </summary>
	string LabelFrontAccessories { get; }

	/// <summary>
	/// Key: "Label.Gear"
	/// English String: "Gear"
	/// </summary>
	string LabelGear { get; }

	/// <summary>
	/// Key: "Label.Hair"
	/// English String: "Hair"
	/// </summary>
	string LabelHair { get; }

	/// <summary>
	/// Key: "Label.HairAccessories"
	/// English String: "Hair Accessories"
	/// </summary>
	string LabelHairAccessories { get; }

	/// <summary>
	/// Key: "Label.Hat"
	/// English String: "Hat"
	/// </summary>
	string LabelHat { get; }

	/// <summary>
	/// Key: "Label.HatAccessories"
	/// English String: "Hat Accessories"
	/// </summary>
	string LabelHatAccessories { get; }

	/// <summary>
	/// Key: "Label.Head"
	/// English String: "Head"
	/// </summary>
	string LabelHead { get; }

	/// <summary>
	/// Key: "Label.Heads"
	/// English String: "Heads"
	/// </summary>
	string LabelHeads { get; }

	/// <summary>
	/// Key: "Label.Height"
	/// English String: "Height"
	/// </summary>
	string LabelHeight { get; }

	/// <summary>
	/// Key: "Label.Idle"
	/// English String: "Idle"
	/// </summary>
	string LabelIdle { get; }

	/// <summary>
	/// Key: "Label.IdleAnimations"
	/// English String: "Idle Animations"
	/// </summary>
	string LabelIdleAnimations { get; }

	/// <summary>
	/// Key: "Label.Jump"
	/// English String: "Jump"
	/// </summary>
	string LabelJump { get; }

	/// <summary>
	/// Key: "Label.JumpAnimations"
	/// English String: "Jump Animations"
	/// </summary>
	string LabelJumpAnimations { get; }

	/// <summary>
	/// Key: "Label.LeftArm"
	/// English String: "Left Arm"
	/// </summary>
	string LabelLeftArm { get; }

	/// <summary>
	/// Key: "Label.LeftArms"
	/// English String: "Left Arms"
	/// </summary>
	string LabelLeftArms { get; }

	/// <summary>
	/// Key: "Label.LeftLeg"
	/// English String: "Left Leg"
	/// </summary>
	string LabelLeftLeg { get; }

	/// <summary>
	/// Key: "Label.LeftLegs"
	/// English String: "Left Legs"
	/// </summary>
	string LabelLeftLegs { get; }

	/// <summary>
	/// Key: "Label.MyCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "My Costumes"
	/// </summary>
	string LabelMyCostumes { get; }

	/// <summary>
	/// Key: "Label.NamePlaceholderCostume"
	/// English String: "Name your costume"
	/// </summary>
	string LabelNamePlaceholderCostume { get; }

	/// <summary>
	/// Key: "Label.NamePlaceholderOutfit"
	/// English String: "Name your outfit"
	/// </summary>
	string LabelNamePlaceholderOutfit { get; }

	/// <summary>
	/// Key: "Label.Neck"
	/// English String: "Neck"
	/// </summary>
	string LabelNeck { get; }

	/// <summary>
	/// Key: "Label.NeckAccessories"
	/// English String: "Neck Accessories"
	/// </summary>
	string LabelNeckAccessories { get; }

	/// <summary>
	/// Key: "Label.NoResellers"
	/// Text label for recommended items
	/// English String: "No resellers"
	/// </summary>
	string LabelNoResellers { get; }

	/// <summary>
	/// Key: "Label.OffSale"
	/// Text label for recommended items
	/// English String: "Off sale"
	/// </summary>
	string LabelOffSale { get; }

	/// <summary>
	/// Key: "Label.Outfit"
	/// English String: "Outfit"
	/// </summary>
	string LabelOutfit { get; }

	/// <summary>
	/// Key: "Label.Pants"
	/// English String: "Pants"
	/// </summary>
	string LabelPants { get; }

	/// <summary>
	/// Key: "Label.Parts"
	/// English String: "Parts"
	/// </summary>
	string LabelParts { get; }

	/// <summary>
	/// Key: "Label.PresetCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Preset Costumes"
	/// </summary>
	string LabelPresetCostumes { get; }

	/// <summary>
	/// Key: "Label.Proportions"
	/// English String: "Proportions"
	/// </summary>
	string LabelProportions { get; }

	/// <summary>
	/// Key: "Label.RedrawUnavailable"
	/// Avatar redraw is unavailable
	/// English String: "Avatar redraw is unavailable."
	/// </summary>
	string LabelRedrawUnavailable { get; }

	/// <summary>
	/// Key: "Label.RightArm"
	/// English String: "Right Arm"
	/// </summary>
	string LabelRightArm { get; }

	/// <summary>
	/// Key: "Label.RightArms"
	/// English String: "Right Arms"
	/// </summary>
	string LabelRightArms { get; }

	/// <summary>
	/// Key: "Label.RightLeg"
	/// English String: "Right Leg"
	/// </summary>
	string LabelRightLeg { get; }

	/// <summary>
	/// Key: "Label.RightLegs"
	/// English String: "Right Legs"
	/// </summary>
	string LabelRightLegs { get; }

	/// <summary>
	/// Key: "Label.Run"
	/// English String: "Run"
	/// </summary>
	string LabelRun { get; }

	/// <summary>
	/// Key: "Label.RunAnimations"
	/// English String: "Run Animations"
	/// </summary>
	string LabelRunAnimations { get; }

	/// <summary>
	/// Key: "Label.Scale"
	/// English String: "Scale"
	/// </summary>
	string LabelScale { get; }

	/// <summary>
	/// Key: "Label.Shirts"
	/// English String: "Shirts"
	/// </summary>
	string LabelShirts { get; }

	/// <summary>
	/// Key: "Label.ShoulderAccessories"
	/// English String: "Shoulder Accessories"
	/// </summary>
	string LabelShoulderAccessories { get; }

	/// <summary>
	/// Key: "Label.Shoulders"
	/// English String: "Shoulders"
	/// </summary>
	string LabelShoulders { get; }

	/// <summary>
	/// Key: "Label.SkinTone"
	/// English String: "Skin Tone"
	/// </summary>
	string LabelSkinTone { get; }

	/// <summary>
	/// Key: "Label.Swim"
	/// English String: "Swim"
	/// </summary>
	string LabelSwim { get; }

	/// <summary>
	/// Key: "Label.SwimAnimations"
	/// English String: "Swim Animations"
	/// </summary>
	string LabelSwimAnimations { get; }

	/// <summary>
	/// Key: "Label.SwitchAvatarType"
	/// User is able to increase the number of joints in their avatar from 6 to 15. R15 moves better. See http://roblox.wikia.com/wiki/R15
	/// English String: "Switch between classic R6 avatar and more expressive next generation R15 avatar"
	/// </summary>
	string LabelSwitchAvatarType { get; }

	/// <summary>
	/// Key: "Label.Torso"
	/// English String: "Torso"
	/// </summary>
	string LabelTorso { get; }

	/// <summary>
	/// Key: "Label.Torsos"
	/// English String: "Torsos"
	/// </summary>
	string LabelTorsos { get; }

	/// <summary>
	/// Key: "Label.TShirts"
	/// English String: "T-Shirts"
	/// </summary>
	string LabelTShirts { get; }

	/// <summary>
	/// Key: "Label.Waist"
	/// English String: "Waist"
	/// </summary>
	string LabelWaist { get; }

	/// <summary>
	/// Key: "Label.WaistAccessories"
	/// English String: "Waist Accessories"
	/// </summary>
	string LabelWaistAccessories { get; }

	/// <summary>
	/// Key: "Label.Walk"
	/// English String: "Walk"
	/// </summary>
	string LabelWalk { get; }

	/// <summary>
	/// Key: "Label.WalkAnimations"
	/// English String: "Walk Animations"
	/// </summary>
	string LabelWalkAnimations { get; }

	/// <summary>
	/// Key: "Label.Width"
	/// English String: "Width"
	/// </summary>
	string LabelWidth { get; }

	/// <summary>
	/// Key: "Label.YourEmotes"
	/// English String: "Your Emotes"
	/// </summary>
	string LabelYourEmotes { get; }

	/// <summary>
	/// Key: "Message.AccessoriesChange"
	/// English String: "Are you sure you want to override your current look?"
	/// </summary>
	string MessageAccessoriesChange { get; }

	/// <summary>
	/// Key: "Message.ChooseEmote"
	/// English String: "Choose an Emote"
	/// </summary>
	string MessageChooseEmote { get; }

	/// <summary>
	/// Key: "Message.ChooseEmoteSlot"
	/// English String: "Choose a slot"
	/// </summary>
	string MessageChooseEmoteSlot { get; }

	/// <summary>
	/// Key: "Message.ChooseEmoteSlotOrEmote"
	/// English String: "Choose a slot or an Emote"
	/// </summary>
	string MessageChooseEmoteSlotOrEmote { get; }

	/// <summary>
	/// Key: "Message.DefaultClothing"
	/// Encourage user to choose their own clothes.
	/// English String: "Default clothing has been applied to your avatar - wear something from your clothing."
	/// </summary>
	string MessageDefaultClothing { get; }

	/// <summary>
	/// Key: "Message.DeleteThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Are you sure you want to delete this costume?"
	/// </summary>
	string MessageDeleteThisCostume { get; }

	/// <summary>
	/// Key: "Message.DeleteThisOutfit"
	/// English String: "Are you sure you want to delete this outfit?"
	/// </summary>
	string MessageDeleteThisOutfit { get; }

	/// <summary>
	/// Key: "Message.EmotesInstructions"
	/// The instructions describe the navigation flow within the Avatar Editor to equip an emote.
	/// English String: "Go to \"Animations\" &gt; \"Emotes\" &gt; \"Equip Emotes\" to equip an emote."
	/// </summary>
	string MessageEmotesInstructions { get; }

	/// <summary>
	/// Key: "Message.EmptyAssetList"
	/// User is seeing no assets on this page because they don't have any.
	/// English String: "You don't have any."
	/// </summary>
	string MessageEmptyAssetList { get; }

	/// <summary>
	/// Key: "Message.EmptyListOfCostumes"
	/// The user is viewing an empty list of costumes to choose from. The application tells the user that they can create an costume.
	/// English String: "You don't have any costumes. Try creating some!"
	/// </summary>
	string MessageEmptyListOfCostumes { get; }

	/// <summary>
	/// Key: "Message.EmptyListOfOutfits"
	/// The user is viewing an empty list of outfits to choose from. The application tells the user that they can create an outfit.
	/// English String: "You don't have any outfits. Try creating some!"
	/// </summary>
	string MessageEmptyListOfOutfits { get; }

	/// <summary>
	/// Key: "Message.EmptyRecentItems"
	/// English String: "You don't have any recent items."
	/// </summary>
	string MessageEmptyRecentItems { get; }

	/// <summary>
	/// Key: "Message.ErrorCreateCostume"
	/// English String: "Unable to create costume, try again later."
	/// </summary>
	string MessageErrorCreateCostume { get; }

	/// <summary>
	/// Key: "Message.ErrorCreateOutfit"
	/// English String: "Unable to create outfit, try again later."
	/// </summary>
	string MessageErrorCreateOutfit { get; }

	/// <summary>
	/// Key: "Message.ErrorDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	string MessageErrorDeleteEmote { get; }

	/// <summary>
	/// Key: "Message.ErrorEquipEmote"
	/// English String: "Failed to equip emote, please try again later."
	/// </summary>
	string MessageErrorEquipEmote { get; }

	/// <summary>
	/// Key: "Message.ErrorLoadCostume"
	/// English String: "Failed to load costume."
	/// </summary>
	string MessageErrorLoadCostume { get; }

	/// <summary>
	/// Key: "Message.ErrorLoadEmotes"
	/// English String: "Failed to load emotes."
	/// </summary>
	string MessageErrorLoadEmotes { get; }

	/// <summary>
	/// Key: "Message.ErrorLoadOutfits"
	/// English String: "Failed to load outfits."
	/// </summary>
	string MessageErrorLoadOutfits { get; }

	/// <summary>
	/// Key: "Message.ErrorOutfitName"
	/// English String: "Name can contain letters, numbers, and spaces."
	/// </summary>
	string MessageErrorOutfitName { get; }

	/// <summary>
	/// Key: "Message.ErrorRenameCostume"
	/// English String: "Failed to rename costume."
	/// </summary>
	string MessageErrorRenameCostume { get; }

	/// <summary>
	/// Key: "Message.ErrorRenameOutfit"
	/// English String: "Failed to rename outfit."
	/// </summary>
	string MessageErrorRenameOutfit { get; }

	/// <summary>
	/// Key: "Message.ErrorUnequipEmote"
	/// English String: "Failed to unequip emote."
	/// </summary>
	string MessageErrorUnequipEmote { get; }

	/// <summary>
	/// Key: "Message.ErrorUpdateCostume"
	/// English String: "Costume update failed, please try again later."
	/// </summary>
	string MessageErrorUpdateCostume { get; }

	/// <summary>
	/// Key: "Message.ErrorUpdateEmote"
	/// English String: "Updating emote slot failed, please try again later."
	/// </summary>
	string MessageErrorUpdateEmote { get; }

	/// <summary>
	/// Key: "Message.ErrorUpdateOutfit"
	/// English String: "Outfit update failed, please try again later."
	/// </summary>
	string MessageErrorUpdateOutfit { get; }

	/// <summary>
	/// Key: "Message.ErrorUpdateWorn"
	/// There was an error updating items that the user is already wearing.
	/// English String: "Error while updating worn items."
	/// </summary>
	string MessageErrorUpdateWorn { get; }

	/// <summary>
	/// Key: "Message.ErrorWearCostume"
	/// English String: "Failed to wear costume."
	/// </summary>
	string MessageErrorWearCostume { get; }

	/// <summary>
	/// Key: "Message.ErrorWearOutfit"
	/// English String: "Failed to wear outfit."
	/// </summary>
	string MessageErrorWearOutfit { get; }

	/// <summary>
	/// Key: "Message.FailedDeleteCostume"
	/// English String: "Failed to delete costume."
	/// </summary>
	string MessageFailedDeleteCostume { get; }

	/// <summary>
	/// Key: "Message.FailedDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	string MessageFailedDeleteEmote { get; }

	/// <summary>
	/// Key: "Message.FailedDeleteOutfit"
	/// English String: "Failed to delete outfit."
	/// </summary>
	string MessageFailedDeleteOutfit { get; }

	/// <summary>
	/// Key: "Message.FailedLoadAssets"
	/// English String: "Failed to load assets list."
	/// </summary>
	string MessageFailedLoadAssets { get; }

	/// <summary>
	/// Key: "Message.FailedLoadRecent"
	/// English String: "Failed to load recent items."
	/// </summary>
	string MessageFailedLoadRecent { get; }

	/// <summary>
	/// Key: "Message.FailedUpdateBodyColor"
	/// English String: "Failed to update skin tone."
	/// </summary>
	string MessageFailedUpdateBodyColor { get; }

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedCostume"
	/// The user tried to update a deleted costume.
	/// English String: "The costume you tried to update no longer exists."
	/// </summary>
	string MessageFailedUpdateDeletedCostume { get; }

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedOutfit"
	/// The user tried to update a deleted outfit.
	/// English String: "The outfit you tried to update no longer exists."
	/// </summary>
	string MessageFailedUpdateDeletedOutfit { get; }

	/// <summary>
	/// Key: "Message.FailedUpdateScales"
	/// English String: "Failed to update scales."
	/// </summary>
	string MessageFailedUpdateScales { get; }

	/// <summary>
	/// Key: "Message.FailedUpdateType"
	/// Failed to update the way the user's avatar is rendered.
	/// English String: "Failed to update avatar type."
	/// </summary>
	string MessageFailedUpdateType { get; }

	/// <summary>
	/// Key: "Message.FailedWearPackage"
	/// English String: "Failed to wear package."
	/// </summary>
	string MessageFailedWearPackage { get; }

	/// <summary>
	/// Key: "Message.HatLimitTooltip"
	/// English String: "You can wear up to 3 hats"
	/// </summary>
	string MessageHatLimitTooltip { get; }

	/// <summary>
	/// Key: "Message.InvalidOutfitName"
	/// English String: "Name must be appropriate and less than 200 characters."
	/// </summary>
	string MessageInvalidOutfitName { get; }

	/// <summary>
	/// Key: "Message.Loading"
	/// The user's avatar is loading
	/// English String: "Loading..."
	/// </summary>
	string MessageLoading { get; }

	/// <summary>
	/// Key: "Message.PageUnavailable"
	/// English String: "The avatar page is temporarily unavailable."
	/// </summary>
	string MessagePageUnavailable { get; }

	/// <summary>
	/// Key: "Message.PresetCostumesDelay"
	/// One-time message that appears to the user first time they visit the Preset Costumes tab. The delay is caused by initial migration.
	/// English String: "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!"
	/// </summary>
	string MessagePresetCostumesDelay { get; }

	/// <summary>
	/// Key: "Message.ReachedMaxCostumes"
	/// English String: "You have reached the maximum number of costumes."
	/// </summary>
	string MessageReachedMaxCostumes { get; }

	/// <summary>
	/// Key: "Message.ReachedMaxOutfits"
	/// English String: "You have reached the maximum number of outfits."
	/// </summary>
	string MessageReachedMaxOutfits { get; }

	/// <summary>
	/// Key: "Message.RedirectAvatarSettings"
	/// English String: "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home &gt; Game Settings &gt; Avatar"
	/// </summary>
	string MessageRedirectAvatarSettings { get; }

	/// <summary>
	/// Key: "Message.RedrawFloodchecked"
	/// English String: "You have redrawn your avatar too many times, please try again later."
	/// </summary>
	string MessageRedrawFloodchecked { get; }

	/// <summary>
	/// Key: "Message.RedrawThumbnailFailed"
	/// English String: "Failed to redraw thumbnail."
	/// </summary>
	string MessageRedrawThumbnailFailed { get; }

	/// <summary>
	/// Key: "Message.SelectEnableScaling"
	/// R15 is a proper noun
	/// English String: "Select R15 to enable scaling."
	/// </summary>
	string MessageSelectEnableScaling { get; }

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	string MessageSuccess { get; }

	/// <summary>
	/// Key: "Message.SuccessCreateCostume"
	/// English String: "Created costume"
	/// </summary>
	string MessageSuccessCreateCostume { get; }

	/// <summary>
	/// Key: "Message.SuccessCreateOutfit"
	/// English String: "Created outfit"
	/// </summary>
	string MessageSuccessCreateOutfit { get; }

	/// <summary>
	/// Key: "Message.SuccessDeleteCostume"
	/// Deleted costume
	/// English String: "Deleted costume"
	/// </summary>
	string MessageSuccessDeleteCostume { get; }

	/// <summary>
	/// Key: "Message.SuccessDeleteOutfit"
	/// English String: "Deleted outfit"
	/// </summary>
	string MessageSuccessDeleteOutfit { get; }

	/// <summary>
	/// Key: "Message.SuccessEquipEmote"
	/// English String: "Equipped Emote"
	/// </summary>
	string MessageSuccessEquipEmote { get; }

	/// <summary>
	/// Key: "Message.SuccessRenameCostume"
	/// English String: "Renamed costume"
	/// </summary>
	string MessageSuccessRenameCostume { get; }

	/// <summary>
	/// Key: "Message.SuccessRenameOutfit"
	/// English String: "Renamed outfit"
	/// </summary>
	string MessageSuccessRenameOutfit { get; }

	/// <summary>
	/// Key: "Message.SuccessSavedAccessories"
	/// English String: "Saved accessories"
	/// </summary>
	string MessageSuccessSavedAccessories { get; }

	/// <summary>
	/// Key: "Message.SuccessUnequipEmote"
	/// English String: "Unequipped emote"
	/// </summary>
	string MessageSuccessUnequipEmote { get; }

	/// <summary>
	/// Key: "Message.SuccessUpdatedCostume"
	/// English String: "Updated costume"
	/// </summary>
	string MessageSuccessUpdatedCostume { get; }

	/// <summary>
	/// Key: "Message.SuccessUpdatedOutfit"
	/// English String: "Updated outfit"
	/// </summary>
	string MessageSuccessUpdatedOutfit { get; }

	/// <summary>
	/// Key: "Message.SuccessWoreCostume"
	/// English String: "Successfully wore costume"
	/// </summary>
	string MessageSuccessWoreCostume { get; }

	/// <summary>
	/// Key: "Message.SuccessWoreOutfit"
	/// English String: "Successfully wore outfit"
	/// </summary>
	string MessageSuccessWoreOutfit { get; }

	/// <summary>
	/// Key: "Message.UpdateThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance."
	/// </summary>
	string MessageUpdateThisCostume { get; }

	/// <summary>
	/// Key: "Message.UpdateThisOutfit"
	/// English String: "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance."
	/// </summary>
	string MessageUpdateThisOutfit { get; }

	/// <summary>
	/// Key: "Message.Warning"
	/// English String: "Warning"
	/// </summary>
	string MessageWarning { get; }

	/// <summary>
	/// Key: "Label.DirectionsForPackagePlacement"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}"
	/// </summary>
	string LabelDirectionsForPackagePlacement(string startBold, string rightArrow, string endBold);

	/// <summary>
	/// Key: "Label.DirectionsForScalingOptions"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}"
	/// </summary>
	string LabelDirectionsForScalingOptions(string startBold, string rightArrow, string endBold);

	/// <summary>
	/// Key: "Message.DeleteOutfit"
	/// English String: "Are you sure you want to delete this {outfitType}?"
	/// </summary>
	string MessageDeleteOutfit(string outfitType);

	/// <summary>
	/// Key: "Message.EmptyListForItem"
	/// The user tries to load a list of some item but they see nothing because they don't own anything of that type.
	/// English String: "You don't have this item: {itemType}"
	/// </summary>
	string MessageEmptyListForItem(string itemType);

	/// <summary>
	/// Key: "Message.MissingItemsFromOutfit"
	/// User cannot wear an outfit because they are missing or have deleted some of the items that were part of that outfit.
	/// English String: "Number of items that you don't own in this outfit: {number}"
	/// </summary>
	string MessageMissingItemsFromOutfit(string number);

	/// <summary>
	/// Key: "Message.UpdateOutfit"
	/// English String: "Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance."
	/// </summary>
	string MessageUpdateOutfit(string outfitType1, string outfitType2);
}
