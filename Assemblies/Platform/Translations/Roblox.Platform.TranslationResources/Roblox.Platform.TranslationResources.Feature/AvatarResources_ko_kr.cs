using System;
using System.Collections.Generic;
namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides AvatarResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AvatarResources_ko_kr : AvatarResources_en_us, IAvatarResources, ITranslationResources
{

    public IReadOnlyDictionary<string, string> GetAllKeys()
    {
        return base.GetAllKeys();
    }

    public string GetFullContentNamespaceName()
    {
        return "Feature.Avatar";
    }

	/// <summary>
	/// Key: "Action.Advanced"
	/// Click Advanced to get the advanced options
	/// English String: "Advanced"
	/// </summary>
	public override string ActionAdvanced => "ÃªÂ³Â ÃªÂ¸â€°";

	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item to customize the user's avatar.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "ÃªÂµÂ¬Ã«Â§Â¤";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Ã¬Â·Â¨Ã¬â€ Å’";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Ã«â€¹Â«ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Action.CreateNewOutfit"
	/// Button to create new outfit
	/// English String: "Create"
	/// </summary>
	public override string ActionCreateNewOutfit => "Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Ã¬â€šÂ­Ã¬Â Å“";

	/// <summary>
	/// Key: "Action.Done"
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy get an item for free to customize the user's avatar.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "Ã­Å¡ÂÃ«â€œÂ";

	/// <summary>
	/// Key: "Action.GetMore"
	/// A call to action for the user to buy more clothes from the Catalog page. This could improve how their avatar looks.
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "Ã«Ââ€ Ã«Â³Â´ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Action.OpenRobloxApp"
	/// English String: "Open Roblox App"
	/// </summary>
	public override string ActionOpenRobloxApp => "Roblox Ã¬â€¢Â± Ã¬â€”Â´ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Action.Redraw"
	/// Redraw the avatar on the screen
	/// English String: "Redraw"
	/// </summary>
	public override string ActionRedraw => "Ã«â€¹Â¤Ã¬â€¹Å“ ÃªÂ·Â¸Ã«Â¦Â¬ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Action.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string ActionRename => "Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½";

	/// <summary>
	/// Key: "Action.RenameOutfit"
	/// Button to rename outfit
	/// English String: "Rename"
	/// </summary>
	public override string ActionRenameOutfit => "Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Ã¬Â â‚¬Ã¬Å¾Â¥";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// See all clothing that user can buy
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ã¬Â â€žÃ¬Â²Â´ Ã«Â³Â´ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Action.ThreeDimensions"
	/// This button allows the user to view their avatar in three dimensions.
	/// English String: "3D"
	/// </summary>
	public override string ActionThreeDimensions => "3D";

	/// <summary>
	/// Key: "Action.TwoDimensions"
	/// This button allows the user to view their avatar in two dimensions.
	/// English String: "2D"
	/// </summary>
	public override string ActionTwoDimensions => "2D";

	/// <summary>
	/// Key: "Action.Update"
	/// English String: "Update"
	/// </summary>
	public override string ActionUpdate => "Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸";

	/// <summary>
	/// Key: "Action.UserUnderstands"
	/// The user casually responds to the application saying that they understand how to navigate the menu.
	/// English String: "Got it"
	/// </summary>
	public override string ActionUserUnderstands => "Ã­â„¢â€¢Ã¬ÂÂ¸";

	/// <summary>
	/// Key: "Description.AvatarEditorUpsell"
	/// English String: "To change your look you will need to use the Avatar Editor on the App."
	/// </summary>
	public override string DescriptionAvatarEditorUpsell => "ÃªÂ²â€°Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž Ã«Â°â€ÃªÂ¾Â¸Ã«Â Â¤Ã«Â©Â´ Ã¬â€¢Â±Ã¬â€”Â Ã­ÂÂ¬Ã­â€¢Â¨Ã«ÂÅ“ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã­Å½Â¸Ã¬Â§â€˜ÃªÂ¸Â°Ã«Â¥Â¼ Ã¬â€šÂ¬Ã¬Å¡Â©Ã­â€¢Â´Ã¬â€¢Â¼ Ã­â€¢Â´Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Description.CreateNewCostume"
	/// A costume will be created from your avatar's current appearance.
	/// English String: "A costume will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Ââ‚¬ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž ÃªÂ¸Â°Ã«Â°ËœÃ¬Å“Â¼Ã«Â¡Å“ Ã«Â§Å’Ã«â€œÂ¤Ã¬â€“Â´Ã¬Â§â€˜Ã«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Description.CreateNewOutfit"
	/// An outfit will be created from your avatar's current appearance.
	/// English String: "An outfit will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Ââ‚¬ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž ÃªÂ¸Â°Ã«Â°ËœÃ¬Å“Â¼Ã«Â¡Å“ Ã«Â§Å’Ã«â€œÂ¤Ã¬â€“Â´Ã¬Â§â€˜Ã«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Description.RenameCostume"
	/// Choose a new name for your costume.
	/// English String: "Choose a new name for your costume."
	/// </summary>
	public override string DescriptionRenameCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬â€”Â Ã¬Æ’Ë† Ã¬ÂÂ´Ã«Â¦â€žÃ¬Ââ€ž Ã¬Â§â‚¬Ã¬â€“Â´Ã¬Â£Â¼Ã¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Description.RenameOutfit"
	/// Choose a new name for your outfit.
	/// English String: "Choose a new name for your outfit."
	/// </summary>
	public override string DescriptionRenameOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬â€”Â Ã¬Æ’Ë† Ã¬ÂÂ´Ã«Â¦â€žÃ¬Ââ€ž Ã¬Â§â‚¬Ã¬â€“Â´Ã¬Â£Â¼Ã¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Heading.Accessories"
	/// English String: "Accessories"
	/// </summary>
	public override string HeadingAccessories => "Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Heading.AccessoriesChange"
	/// English String: "Accessories Change"
	/// </summary>
	public override string HeadingAccessoriesChange => "Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬ Ã«Â³â‚¬ÃªÂ²Â½";

	/// <summary>
	/// Key: "Heading.AdvancedOptions"
	/// English String: "Advanced Options"
	/// </summary>
	public override string HeadingAdvancedOptions => "ÃªÂ³Â ÃªÂ¸â€° Ã¬ËœÂµÃ¬â€¦Ëœ";

	/// <summary>
	/// Key: "Heading.All"
	/// All avatar modification types
	/// English String: "All"
	/// </summary>
	public override string HeadingAll => "Ã¬Â â€žÃ¬Â²Â´";

	/// <summary>
	/// Key: "Heading.Animations"
	/// English String: "Animations"
	/// </summary>
	public override string HeadingAnimations => "Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";

	/// <summary>
	/// Key: "Heading.Appearance"
	/// English String: "Appearance"
	/// </summary>
	public override string HeadingAppearance => "Ã«ÂªÂ¨Ã¬Å Âµ";

	/// <summary>
	/// Key: "Heading.AvatarPageTitle"
	/// Page title for the Avatar page. On this page, the user can modify how they look.
	/// English String: "Avatar Editor"
	/// </summary>
	public override string HeadingAvatarPageTitle => "Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã­Å½Â¸Ã¬Â§â€˜ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Heading.Body"
	/// English String: "Body"
	/// </summary>
	public override string HeadingBody => "Ã¬â€¹Â Ã¬Â²Â´";

	/// <summary>
	/// Key: "Heading.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string HeadingBodyParts => "Ã¬â€¹Â Ã¬Â²Â´ Ã«Â¶â‚¬Ã¬Å“â€ž";

	/// <summary>
	/// Key: "Heading.Clothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingClothing => "Ã«Â³ÂµÃ¬Å¾Â¥";

	/// <summary>
	/// Key: "Heading.Costumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Costumes"
	/// </summary>
	public override string HeadingCostumes => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";

	/// <summary>
	/// Key: "Heading.CreateNewCostume"
	/// NOTE: Costume is a more whimsical word choice for outfit. Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Create New Costume"
	/// </summary>
	public override string HeadingCreateNewCostume => "Ã¬Æ’Ë† Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Heading.CreateNewOutfit"
	/// English String: "Create New Outfit"
	/// </summary>
	public override string HeadingCreateNewOutfit => "Ã¬Æ’Ë† Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Heading.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string HeadingDelete => "Ã¬â€šÂ­Ã¬Â Å“";

	/// <summary>
	/// Key: "Heading.DeleteCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Delete Costume"
	/// </summary>
	public override string HeadingDeleteCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“";

	/// <summary>
	/// Key: "Heading.DeleteOutfit"
	/// English String: "Delete Outfit"
	/// </summary>
	public override string HeadingDeleteOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“";

	/// <summary>
	/// Key: "Heading.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string HeadingEmotes => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";

	/// <summary>
	/// Key: "Heading.EquipEmotes"
	/// English String: "Equip Emotes"
	/// </summary>
	public override string HeadingEquipEmotes => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å¾Â¥Ã¬Â°Â©";

	/// <summary>
	/// Key: "Heading.Outfits"
	/// English String: "Outfits"
	/// </summary>
	public override string HeadingOutfits => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";

	/// <summary>
	/// Key: "Heading.Packages"
	/// English String: "Packages"
	/// </summary>
	public override string HeadingPackages => "Ã­Å’Â¨Ã­â€šÂ¤Ã¬Â§â‚¬";

	/// <summary>
	/// Key: "Heading.Recent"
	/// English String: "Recent"
	/// </summary>
	public override string HeadingRecent => "Ã¬ÂµÅ“ÃªÂ·Â¼";

	/// <summary>
	/// Key: "Heading.Recommended"
	/// See recommended clothing for your avatar
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommended => "Ã¬Â¶â€Ã¬Â²Å“";

	/// <summary>
	/// Key: "Heading.RenameCostume"
	/// English String: "Rename Costume"
	/// </summary>
	public override string HeadingRenameCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½";

	/// <summary>
	/// Key: "Heading.RenameOutfit"
	/// English String: "Rename Outfit"
	/// </summary>
	public override string HeadingRenameOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½";

	/// <summary>
	/// Key: "Heading.Scaling"
	/// English String: "Scaling"
	/// </summary>
	public override string HeadingScaling => "Ã­ÂÂ¬ÃªÂ¸Â° Ã«Â³â‚¬ÃªÂ²Â½";

	/// <summary>
	/// Key: "Heading.SkinToneBodyParts"
	/// English String: "Skin Tone by Body Parts"
	/// </summary>
	public override string HeadingSkinToneBodyParts => "Ã¬â€¹Â Ã¬Â²Â´ Ã«Â¶â‚¬Ã¬Å“â€žÃ«Â³â€ž Ã­â€Â¼Ã«Â¶â‚¬ Ã¬Æ’â€°ÃªÂ¹â€";

	/// <summary>
	/// Key: "Heading.Update"
	/// English String: "Update"
	/// </summary>
	public override string HeadingUpdate => "Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸";

	/// <summary>
	/// Key: "Heading.UpdateCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Update Costume"
	/// </summary>
	public override string HeadingUpdateCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸";

	/// <summary>
	/// Key: "Heading.UpdateOutfit"
	/// English String: "Update Outfit"
	/// </summary>
	public override string HeadingUpdateOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸";

	/// <summary>
	/// Key: "Label.All"
	/// All body parts. This label will allow for body parts to change color
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Ã¬Â â€žÃ¬Â²Â´";

	/// <summary>
	/// Key: "Label.AskIfLoadingCorrectly"
	/// Avatar isn't loading correctly?
	/// English String: "Avatar isn't loading correctly?"
	/// </summary>
	public override string LabelAskIfLoadingCorrectly => "Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã«Â¥Â¼ Ã¬Â Å“Ã«Å’â‚¬Ã«Â¡Å“ Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¬ Ã¬Ë†Ëœ Ã¬â€”â€ Ã«â€¹Â¤ÃªÂµÂ¬Ã¬Å¡â€?";

	/// <summary>
	/// Key: "Label.AssetIDPlaceholder"
	/// This refers to the Asset ID which is a technical word for the Identification Number of an item or asset.
	/// English String: "Asset ID"
	/// </summary>
	public override string LabelAssetIDPlaceholder => "Ã¬â€¢Â Ã¬â€¦â€¹ ID";

	/// <summary>
	/// Key: "Label.Back"
	/// English String: "Back"
	/// </summary>
	public override string LabelBack => "Ã«â€œÂ±";

	/// <summary>
	/// Key: "Label.BackAccessories"
	/// English String: "Back Accessories"
	/// </summary>
	public override string LabelBackAccessories => "Ã«â€œÂ± Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Label.BodyType"
	/// English String: "Body Type"
	/// </summary>
	public override string LabelBodyType => "Ã¬Â²Â´Ã­Ëœâ€¢";

	/// <summary>
	/// Key: "Label.Climb"
	/// English String: "Climb"
	/// </summary>
	public override string LabelClimb => "Ã¬ËœÂ¤Ã«Â¥Â´ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Label.ClimbAnimations"
	/// English String: "Climb Animations"
	/// </summary>
	public override string LabelClimbAnimations => "Ã¬ËœÂ¤Ã«Â¥Â´ÃªÂ¸Â° Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";

	/// <summary>
	/// Key: "Label.Clothes"
	/// English String: "Clothes"
	/// </summary>
	public override string LabelClothes => "Ã«Â³ÂµÃ¬Å¾Â¥";

	/// <summary>
	/// Key: "Label.Costume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Costume"
	/// </summary>
	public override string LabelCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";

	/// <summary>
	/// Key: "label.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string labelEmotes => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";

	/// <summary>
	/// Key: "Label.Equip"
	/// English String: "Equip"
	/// </summary>
	public override string LabelEquip => "Ã¬Å¾Â¥Ã¬Â°Â©";

	/// <summary>
	/// Key: "Label.ExploreCatalog"
	/// This text entices users to shop for more things to wear on their avatar
	/// English String: "Explore the catalog to find more clothes!"
	/// </summary>
	public override string LabelExploreCatalog => "Ã¬Â¹Â´Ã­Æ’Ë†Ã«Â¡Å“ÃªÂ·Â¸Ã¬â€”ÂÃ¬â€žÅ“ Ã«Ââ€ Ã«Â§Å½Ã¬Ââ‚¬ Ã«Â³ÂµÃ¬Å¾Â¥Ã¬Ââ€ž Ã¬Â°Â¾Ã¬â€¢â€žÃ«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€!";

	/// <summary>
	/// Key: "Label.Face"
	/// English String: "Face"
	/// </summary>
	public override string LabelFace => "Ã¬â€“Â¼ÃªÂµÂ´";

	/// <summary>
	/// Key: "Label.FaceAccessories"
	/// English String: "Face Accessories"
	/// </summary>
	public override string LabelFaceAccessories => "Ã¬â€“Â¼ÃªÂµÂ´ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Label.Faces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "Ã¬â€“Â¼ÃªÂµÂ´";

	/// <summary>
	/// Key: "Label.Fall"
	/// English String: "Fall"
	/// </summary>
	public override string LabelFall => "Ã«â€šâ„¢Ã­â€¢Ëœ";

	/// <summary>
	/// Key: "Label.FallAnimations"
	/// English String: "Fall Animations"
	/// </summary>
	public override string LabelFallAnimations => "Ã«â€šâ„¢Ã­â€¢Ëœ Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";

	/// <summary>
	/// Key: "Label.Free"
	/// Text label for recommended items
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "Ã«Â¬Â´Ã«Â£Å’";

	/// <summary>
	/// Key: "Label.Front"
	/// English String: "Front"
	/// </summary>
	public override string LabelFront => "ÃªÂ°â‚¬Ã¬Å Â´";

	/// <summary>
	/// Key: "Label.FrontAccessories"
	/// English String: "Front Accessories"
	/// </summary>
	public override string LabelFrontAccessories => "ÃªÂ°â‚¬Ã¬Å Â´ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Label.Gear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "Ã¬Å¾Â¥Ã«Â¹â€ž";

	/// <summary>
	/// Key: "Label.Hair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelHair => "Ã­â€”Â¤Ã¬â€“Â´";

	/// <summary>
	/// Key: "Label.HairAccessories"
	/// English String: "Hair Accessories"
	/// </summary>
	public override string LabelHairAccessories => "Ã­â€”Â¤Ã¬â€“Â´ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Label.Hat"
	/// English String: "Hat"
	/// </summary>
	public override string LabelHat => "Ã«ÂªÂ¨Ã¬Å¾Â";

	/// <summary>
	/// Key: "Label.HatAccessories"
	/// English String: "Hat Accessories"
	/// </summary>
	public override string LabelHatAccessories => "Ã«ÂªÂ¨Ã¬Å¾Â Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Label.Head"
	/// English String: "Head"
	/// </summary>
	public override string LabelHead => "Ã«Â¨Â¸Ã«Â¦Â¬";

	/// <summary>
	/// Key: "Label.Heads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "Ã«Â¨Â¸Ã«Â¦Â¬";

	/// <summary>
	/// Key: "Label.Height"
	/// English String: "Height"
	/// </summary>
	public override string LabelHeight => "Ã«â€ â€™Ã¬ÂÂ´";

	/// <summary>
	/// Key: "Label.Idle"
	/// English String: "Idle"
	/// </summary>
	public override string LabelIdle => "Ã«Å’â‚¬ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Label.IdleAnimations"
	/// English String: "Idle Animations"
	/// </summary>
	public override string LabelIdleAnimations => "Ã«Å’â‚¬ÃªÂ¸Â° Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";

	/// <summary>
	/// Key: "Label.Jump"
	/// English String: "Jump"
	/// </summary>
	public override string LabelJump => "Ã¬Â ÂÃ­â€â€ž";

	/// <summary>
	/// Key: "Label.JumpAnimations"
	/// English String: "Jump Animations"
	/// </summary>
	public override string LabelJumpAnimations => "Ã¬Â ÂÃ­â€â€ž Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";

	/// <summary>
	/// Key: "Label.LeftArm"
	/// English String: "Left Arm"
	/// </summary>
	public override string LabelLeftArm => "Ã¬â„¢Â¼Ã­Å’â€";

	/// <summary>
	/// Key: "Label.LeftArms"
	/// English String: "Left Arms"
	/// </summary>
	public override string LabelLeftArms => "Ã¬â„¢Â¼Ã­Å’â€";

	/// <summary>
	/// Key: "Label.LeftLeg"
	/// English String: "Left Leg"
	/// </summary>
	public override string LabelLeftLeg => "Ã¬â„¢Â¼ Ã«â€¹Â¤Ã«Â¦Â¬";

	/// <summary>
	/// Key: "Label.LeftLegs"
	/// English String: "Left Legs"
	/// </summary>
	public override string LabelLeftLegs => "Ã¬â„¢Â¼ Ã«â€¹Â¤Ã«Â¦Â¬";

	/// <summary>
	/// Key: "Label.MyCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "My Costumes"
	/// </summary>
	public override string LabelMyCostumes => "Ã«â€šÂ´ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";

	/// <summary>
	/// Key: "Label.NamePlaceholderCostume"
	/// English String: "Name your costume"
	/// </summary>
	public override string LabelNamePlaceholderCostume => "Ã¬Æ’Ë† Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã¬Å¾â€¦Ã«Â Â¥";

	/// <summary>
	/// Key: "Label.NamePlaceholderOutfit"
	/// English String: "Name your outfit"
	/// </summary>
	public override string LabelNamePlaceholderOutfit => "Ã¬Æ’Ë† Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã¬Å¾â€¦Ã«Â Â¥";

	/// <summary>
	/// Key: "Label.Neck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelNeck => "Ã«ÂªÂ©";

	/// <summary>
	/// Key: "Label.NeckAccessories"
	/// English String: "Neck Accessories"
	/// </summary>
	public override string LabelNeckAccessories => "Ã«ÂªÂ© Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Label.NoResellers"
	/// Text label for recommended items
	/// English String: "No resellers"
	/// </summary>
	public override string LabelNoResellers => "Ã¬Å¾Â¬Ã­Å’ÂÃ«Â§Â¤Ã¬Å¾Â Ã¬â€”â€ Ã¬ÂÅ’";

	/// <summary>
	/// Key: "Label.OffSale"
	/// Text label for recommended items
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "Ã­Å’ÂÃ«Â§Â¤ Ã¬Â¤â€˜Ã«â€¹Â¨";

	/// <summary>
	/// Key: "Label.Outfit"
	/// English String: "Outfit"
	/// </summary>
	public override string LabelOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";

	/// <summary>
	/// Key: "Label.Pants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "Ã«Â°â€Ã¬Â§â‚¬";

	/// <summary>
	/// Key: "Label.Parts"
	/// English String: "Parts"
	/// </summary>
	public override string LabelParts => "Ã«Â¶â‚¬Ã¬Å“â€ž";

	/// <summary>
	/// Key: "Label.PresetCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Preset Costumes"
	/// </summary>
	public override string LabelPresetCostumes => "ÃªÂ¸Â°Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";

	/// <summary>
	/// Key: "Label.Proportions"
	/// English String: "Proportions"
	/// </summary>
	public override string LabelProportions => "Ã«Â¹â€žÃ¬Å“Â¨";

	/// <summary>
	/// Key: "Label.RedrawUnavailable"
	/// Avatar redraw is unavailable
	/// English String: "Avatar redraw is unavailable."
	/// </summary>
	public override string LabelRedrawUnavailable => "Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã«â€¹Â¤Ã¬â€¹Å“ ÃªÂ·Â¸Ã«Â¦Â¬ÃªÂ¸Â°Ã«Â¥Â¼ Ã¬â€šÂ¬Ã¬Å¡Â©Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Label.RightArm"
	/// English String: "Right Arm"
	/// </summary>
	public override string LabelRightArm => "Ã¬ËœÂ¤Ã«Â¥Â¸Ã­Å’â€";

	/// <summary>
	/// Key: "Label.RightArms"
	/// English String: "Right Arms"
	/// </summary>
	public override string LabelRightArms => "Ã¬ËœÂ¤Ã«Â¥Â¸Ã­Å’â€";

	/// <summary>
	/// Key: "Label.RightLeg"
	/// English String: "Right Leg"
	/// </summary>
	public override string LabelRightLeg => "Ã¬ËœÂ¤Ã«Â¥Â¸ Ã«â€¹Â¤Ã«Â¦Â¬";

	/// <summary>
	/// Key: "Label.RightLegs"
	/// English String: "Right Legs"
	/// </summary>
	public override string LabelRightLegs => "Ã¬ËœÂ¤Ã«Â¥Â¸ Ã«â€¹Â¤Ã«Â¦Â¬";

	/// <summary>
	/// Key: "Label.Run"
	/// English String: "Run"
	/// </summary>
	public override string LabelRun => "Ã«â€¹Â¬Ã«Â¦Â¬ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Label.RunAnimations"
	/// English String: "Run Animations"
	/// </summary>
	public override string LabelRunAnimations => "Ã«â€¹Â¬Ã«Â¦Â¬ÃªÂ¸Â° Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";

	/// <summary>
	/// Key: "Label.Scale"
	/// English String: "Scale"
	/// </summary>
	public override string LabelScale => "Ã­ÂÂ¬ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Label.Shirts"
	/// English String: "Shirts"
	/// </summary>
	public override string LabelShirts => "Ã¬â€¦â€Ã¬Â¸Â ";

	/// <summary>
	/// Key: "Label.ShoulderAccessories"
	/// English String: "Shoulder Accessories"
	/// </summary>
	public override string LabelShoulderAccessories => "Ã¬â€“Â´ÃªÂ¹Â¨ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Label.Shoulders"
	/// English String: "Shoulders"
	/// </summary>
	public override string LabelShoulders => "Ã¬â€“Â´ÃªÂ¹Â¨";

	/// <summary>
	/// Key: "Label.SkinTone"
	/// English String: "Skin Tone"
	/// </summary>
	public override string LabelSkinTone => "Ã­â€Â¼Ã«Â¶â‚¬ Ã¬Æ’â€°ÃªÂ¹â€";

	/// <summary>
	/// Key: "Label.Swim"
	/// English String: "Swim"
	/// </summary>
	public override string LabelSwim => "Ã¬Ë†ËœÃ¬ËœÂ";

	/// <summary>
	/// Key: "Label.SwimAnimations"
	/// English String: "Swim Animations"
	/// </summary>
	public override string LabelSwimAnimations => "Ã¬Ë†ËœÃ¬ËœÂ Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";

	/// <summary>
	/// Key: "Label.SwitchAvatarType"
	/// User is able to increase the number of joints in their avatar from 6 to 15. R15 moves better. See http://roblox.wikia.com/wiki/R15
	/// English String: "Switch between classic R6 avatar and more expressive next generation R15 avatar"
	/// </summary>
	public override string LabelSwitchAvatarType => "ÃªÂ¸Â°Ã¬Â¡Â´ R6 Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬â„¢â‚¬ Ã«Ââ€Ã¬Å¡Â± Ã¬Â â€¢ÃªÂµÂÃ­â€¢Å“ Ã¬Â°Â¨Ã¬â€žÂ¸Ã«Å’â‚¬ R15 Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ÃªÂ°â€ž Ã¬Â â€žÃ­â„¢ËœÃ¬ÂÂ´ ÃªÂ°â‚¬Ã«Å Â¥Ã­â€¢Â©Ã«â€¹Ë†Ã«â€¹Â¤";

	/// <summary>
	/// Key: "Label.Torso"
	/// English String: "Torso"
	/// </summary>
	public override string LabelTorso => "Ã«ÂªÂ¸Ã­â€ Âµ";

	/// <summary>
	/// Key: "Label.Torsos"
	/// English String: "Torsos"
	/// </summary>
	public override string LabelTorsos => "Ã«ÂªÂ¸Ã­â€ Âµ";

	/// <summary>
	/// Key: "Label.TShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "Ã­â€¹Â°Ã¬â€¦â€Ã¬Â¸Â ";

	/// <summary>
	/// Key: "Label.Waist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelWaist => "Ã­â€”Ë†Ã«Â¦Â¬";

	/// <summary>
	/// Key: "Label.WaistAccessories"
	/// English String: "Waist Accessories"
	/// </summary>
	public override string LabelWaistAccessories => "Ã­â€”Ë†Ã«Â¦Â¬ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Label.Walk"
	/// English String: "Walk"
	/// </summary>
	public override string LabelWalk => "ÃªÂ±Â·ÃªÂ¸Â°";

	/// <summary>
	/// Key: "Label.WalkAnimations"
	/// English String: "Walk Animations"
	/// </summary>
	public override string LabelWalkAnimations => "ÃªÂ±Â·ÃªÂ¸Â° Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";

	/// <summary>
	/// Key: "Label.Width"
	/// English String: "Width"
	/// </summary>
	public override string LabelWidth => "Ã«â€žâ€œÃ¬ÂÂ´";

	/// <summary>
	/// Key: "Label.YourEmotes"
	/// English String: "Your Emotes"
	/// </summary>
	public override string LabelYourEmotes => "Ã­â€Å’Ã«Â Ë†Ã¬ÂÂ´Ã¬â€“Â´Ã¬ÂËœ ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";

	/// <summary>
	/// Key: "Message.AccessoriesChange"
	/// English String: "Are you sure you want to override your current look?"
	/// </summary>
	public override string MessageAccessoriesChange => "Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž Ã«ÂÂ®Ã¬â€“Â´Ã¬â€œÂ¸ÃªÂ¹Å’Ã¬Å¡â€?";

	/// <summary>
	/// Key: "Message.ChooseEmote"
	/// English String: "Choose an Emote"
	/// </summary>
	public override string MessageChooseEmote => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlot"
	/// English String: "Choose a slot"
	/// </summary>
	public override string MessageChooseEmoteSlot => "Ã¬Å Â¬Ã«Â¡Â¯Ã¬Ââ€ž Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlotOrEmote"
	/// English String: "Choose a slot or an Emote"
	/// </summary>
	public override string MessageChooseEmoteSlotOrEmote => "Ã¬Å Â¬Ã«Â¡Â¯Ã¬ÂÂ´Ã«â€šËœ ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€";

	/// <summary>
	/// Key: "Message.DefaultClothing"
	/// Encourage user to choose their own clothes.
	/// English String: "Default clothing has been applied to your avatar - wear something from your clothing."
	/// </summary>
	public override string MessageDefaultClothing => "ÃªÂ¸Â°Ã«Â³Â¸ Ã«Â³ÂµÃ¬Å¾Â¥Ã¬ÂÂ´ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬â€”Â Ã¬Â ÂÃ¬Å¡Â©Ã«ÂËœÃ¬â€”Ë†Ã¬â€“Â´Ã¬Å¡â€. Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã«Â³ÂµÃ¬Å¾Â¥Ã¬â€”ÂÃ¬â€žÅ“ Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€”Â¬ Ã¬Â°Â©Ã¬Å¡Â©Ã­â€¢Â´Ã«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.DeleteThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Are you sure you want to delete this costume?"
	/// </summary>
	public override string MessageDeleteThisCostume => "Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Ââ€ž Ã¬Â â€¢Ã«Â§Â Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬Å ÂµÃ«â€¹Ë†ÃªÂ¹Å’?";

	/// <summary>
	/// Key: "Message.DeleteThisOutfit"
	/// English String: "Are you sure you want to delete this outfit?"
	/// </summary>
	public override string MessageDeleteThisOutfit => "Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Ââ€ž Ã¬Â â€¢Ã«Â§Â Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬Å ÂµÃ«â€¹Ë†ÃªÂ¹Å’?";

	/// <summary>
	/// Key: "Message.EmotesInstructions"
	/// The instructions describe the navigation flow within the Avatar Editor to equip an emote.
	/// English String: "Go to \"Animations\" &gt; \"Emotes\" &gt; \"Equip Emotes\" to equip an emote."
	/// </summary>
	public override string MessageEmotesInstructions => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬Å¾Â¥Ã¬Â°Â©Ã­â€¢ËœÃ«Â Â¤Ã«Â©Â´ Ã«â€¹Â¤Ã¬ÂÅ’Ã¬Å“Â¼Ã«Â¡Å“ Ã¬ÂÂ´Ã«Ââ„¢Ã­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€. 'Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ > ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž > ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å¾Â¥Ã¬Â°Â©'";

	/// <summary>
	/// Key: "Message.EmptyAssetList"
	/// User is seeing no assets on this page because they don't have any.
	/// English String: "You don't have any."
	/// </summary>
	public override string MessageEmptyAssetList => "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬â€¢Â Ã¬â€¦â€¹Ã¬ÂÂ´ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Message.EmptyListOfCostumes"
	/// The user is viewing an empty list of costumes to choose from. The application tells the user that they can create an costume.
	/// English String: "You don't have any costumes. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfCostumes => "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬ÂÂ´ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤. Ã¬Â§ÂÃ¬Â â€˜ Ã«Â§Å’Ã«â€œÂ¤Ã¬â€“Â´Ã«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€!";

	/// <summary>
	/// Key: "Message.EmptyListOfOutfits"
	/// The user is viewing an empty list of outfits to choose from. The application tells the user that they can create an outfit.
	/// English String: "You don't have any outfits. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfOutfits => "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€ Ã¬ÂÅ’. Ã¬Æ’Ë†Ã«Â¡Å“ Ã«Â§Å’Ã«â€œÂ¤Ã¬â€“Â´Ã«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€!";

	/// <summary>
	/// Key: "Message.EmptyRecentItems"
	/// English String: "You don't have any recent items."
	/// </summary>
	public override string MessageEmptyRecentItems => "Ã¬ÂµÅ“ÃªÂ·Â¼ Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“Ã¬ÂÂ´ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Message.ErrorCreateCostume"
	/// English String: "Unable to create costume, try again later."
	/// </summary>
	public override string MessageErrorCreateCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorCreateOutfit"
	/// English String: "Unable to create outfit, try again later."
	/// </summary>
	public override string MessageErrorCreateOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â° Ã«Â¶Ë†ÃªÂ°â‚¬. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageErrorDeleteEmote => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬Â§â‚¬ Ã«ÂªÂ»Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorEquipEmote"
	/// English String: "Failed to equip emote, please try again later."
	/// </summary>
	public override string MessageErrorEquipEmote => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å¾Â¥Ã¬Â°Â© Ã¬â€¹Â¤Ã­Å’Â¨. Ã¬Å¾Â Ã¬â€¹Å“ Ã­â€ºâ€ž Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorLoadCostume"
	/// English String: "Failed to load costume."
	/// </summary>
	public override string MessageErrorLoadCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.ErrorLoadEmotes"
	/// English String: "Failed to load emotes."
	/// </summary>
	public override string MessageErrorLoadEmotes => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤Ã¬Â§â‚¬ Ã«ÂªÂ»Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorLoadOutfits"
	/// English String: "Failed to load outfits."
	/// </summary>
	public override string MessageErrorLoadOutfits => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.ErrorOutfitName"
	/// English String: "Name can contain letters, numbers, and spaces."
	/// </summary>
	public override string MessageErrorOutfitName => "Ã¬ÂÂ´Ã«Â¦â€žÃ¬Ââ‚¬ Ã¬â€¢Å’Ã­Å’Å’Ã«Â²Â³, Ã¬Ë†Â«Ã¬Å¾Â, Ã«Â¹Ë† Ã¬Â¹Â¸Ã¬Ââ€ž Ã¬Â¡Â°Ã­â€¢Â©Ã­â€¢ËœÃ¬â€”Â¬ Ã«Â§Å’Ã«â€œÂ¤ Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬â€“Â´Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorRenameCostume"
	/// English String: "Failed to rename costume."
	/// </summary>
	public override string MessageErrorRenameCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½ Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.ErrorRenameOutfit"
	/// English String: "Failed to rename outfit."
	/// </summary>
	public override string MessageErrorRenameOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½ Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.ErrorUnequipEmote"
	/// English String: "Failed to unequip emote."
	/// </summary>
	public override string MessageErrorUnequipEmote => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å¾Â¥Ã¬Â°Â© Ã­â€¢Â´Ã¬Â Å“Ã¬â€”Â Ã¬â€¹Â¤Ã­Å’Â¨Ã­â€“Ë†Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Message.ErrorUpdateCostume"
	/// English String: "Costume update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorUpdateEmote"
	/// English String: "Updating emote slot failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateEmote => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å Â¬Ã«Â¡Â¯ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨. Ã¬Å¾Â Ã¬â€¹Å“ Ã­â€ºâ€ž Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorUpdateOutfit"
	/// English String: "Outfit update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorUpdateWorn"
	/// There was an error updating items that the user is already wearing.
	/// English String: "Error while updating worn items."
	/// </summary>
	public override string MessageErrorUpdateWorn => "Ã¬Â°Â©Ã¬Å¡Â© Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬Â¤â€˜ Ã¬ËœÂ¤Ã«Â¥ËœÃªÂ°â‚¬ Ã«Â°Å“Ã¬Æ’ÂÃ­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ErrorWearCostume"
	/// English String: "Failed to wear costume."
	/// </summary>
	public override string MessageErrorWearCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.ErrorWearOutfit"
	/// English String: "Failed to wear outfit."
	/// </summary>
	public override string MessageErrorWearOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.FailedDeleteCostume"
	/// English String: "Failed to delete costume."
	/// </summary>
	public override string MessageFailedDeleteCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“ Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.FailedDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageFailedDeleteEmote => "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬Â§â‚¬ Ã«ÂªÂ»Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.FailedDeleteOutfit"
	/// English String: "Failed to delete outfit."
	/// </summary>
	public override string MessageFailedDeleteOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“ Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.FailedLoadAssets"
	/// English String: "Failed to load assets list."
	/// </summary>
	public override string MessageFailedLoadAssets => "Ã¬â€¢Â Ã¬â€¦â€¹ Ã«ÂªÂ©Ã«Â¡Â Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.FailedLoadRecent"
	/// English String: "Failed to load recent items."
	/// </summary>
	public override string MessageFailedLoadRecent => "Ã¬ÂµÅ“ÃªÂ·Â¼ Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“ Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.FailedUpdateBodyColor"
	/// English String: "Failed to update skin tone."
	/// </summary>
	public override string MessageFailedUpdateBodyColor => "Ã­â€Â¼Ã«Â¶â‚¬ Ã¬Æ’â€°ÃªÂ¹â€ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedCostume"
	/// The user tried to update a deleted costume.
	/// English String: "The costume you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedCostume => "Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ«Â Â¤Ã«Å â€ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬ÂÂ´ Ã«Ââ€ Ã¬ÂÂ´Ã¬Æ’Â Ã¬Â¡Â´Ã¬Å¾Â¬Ã­â€¢ËœÃ¬Â§â‚¬ Ã¬â€¢Å Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedOutfit"
	/// The user tried to update a deleted outfit.
	/// English String: "The outfit you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedOutfit => "Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ«Â Â¤Ã«Å â€ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬ÂÂ´ Ã«Ââ€ Ã¬ÂÂ´Ã¬Æ’Â Ã¬Â¡Â´Ã¬Å¾Â¬Ã­â€¢ËœÃ¬Â§â‚¬ Ã¬â€¢Å Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Message.FailedUpdateScales"
	/// English String: "Failed to update scales."
	/// </summary>
	public override string MessageFailedUpdateScales => "Ã­ÂÂ¬ÃªÂ¸Â° Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.FailedUpdateType"
	/// Failed to update the way the user's avatar is rendered.
	/// English String: "Failed to update avatar type."
	/// </summary>
	public override string MessageFailedUpdateType => "Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã¬Å“Â Ã­Ëœâ€¢ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.FailedWearPackage"
	/// English String: "Failed to wear package."
	/// </summary>
	public override string MessageFailedWearPackage => "Ã­Å’Â¨Ã­â€šÂ¤Ã¬Â§â‚¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.HatLimitTooltip"
	/// English String: "You can wear up to 3 hats"
	/// </summary>
	public override string MessageHatLimitTooltip => "Ã«ÂªÂ¨Ã¬Å¾ÂÃ«Å â€ Ã¬ÂµÅ“Ã«Å’â‚¬ 3ÃªÂ°Å“ÃªÂ¹Å’Ã¬Â§â‚¬ Ã¬Â°Â©Ã¬Å¡Â©Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬â€“Â´Ã¬Å¡â€";

	/// <summary>
	/// Key: "Message.InvalidOutfitName"
	/// English String: "Name must be appropriate and less than 200 characters."
	/// </summary>
	public override string MessageInvalidOutfitName => "Ã¬ÂÂ´Ã«Â¦â€žÃ¬Ââ‚¬ Ã¬Â ÂÃ¬Â Ë†Ã­â€¢Å“ Ã¬Å¡Â©Ã¬â€“Â´Ã«Â¥Â¼ Ã¬â€šÂ¬Ã¬Å¡Â©Ã­â€¢ËœÃ¬â€”Â¬Ã¬â€¢Â¼ Ã­â€¢ËœÃ«Â©Â° 200Ã¬Å¾Â Ã¬ÂÂ´Ã«â€šÂ´Ã«Â¡Å“ Ã¬Å¾â€¦Ã«Â Â¥Ã­â€¢ËœÃ¬â€¦â€Ã¬â€¢Â¼ Ã­â€¢Â©Ã«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Message.Loading"
	/// The user's avatar is loading
	/// English String: "Loading..."
	/// </summary>
	public override string MessageLoading => "Ã«Â¡Å“Ã«â€œÅ“ Ã¬Â¤â€˜...";

	/// <summary>
	/// Key: "Message.PageUnavailable"
	/// English String: "The avatar page is temporarily unavailable."
	/// </summary>
	public override string MessagePageUnavailable => "Ã¬Â§â‚¬ÃªÂ¸Ë†Ã¬Ââ‚¬ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã­Å½ËœÃ¬ÂÂ´Ã¬Â§â‚¬Ã«Â¥Â¼ Ã¬ÂÂ´Ã¬Å¡Â©Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Message.PresetCostumesDelay"
	/// One-time message that appears to the user first time they visit the Preset Costumes tab. The delay is caused by initial migration.
	/// English String: "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!"
	/// </summary>
	public override string MessagePresetCostumesDelay => "Ã¬â€¢Å’Ã«Â¦Â¼: Ã¬Â ÂÃªÂ²â‚¬ Ã¬Â¤â€˜. Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬ÂÂ´ Ã«â€šËœÃ­Æ’â‚¬Ã«â€šËœÃ«Å â€ Ã«ÂÂ° Ã«Âªâ€¡ Ã«Â¶â€ž Ã¬Â â€¢Ã«Ââ€ž Ã¬â€ Å’Ã¬Å¡â€Ã«ÂÂ  Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤. Ã¬Å¾Â Ã¬â€¹Å“ Ã­â€ºâ€ž Ã«â€¹Â¤Ã¬â€¹Å“ Ã­â„¢â€¢Ã¬ÂÂ¸Ã­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ReachedMaxCostumes"
	/// English String: "You have reached the maximum number of costumes."
	/// </summary>
	public override string MessageReachedMaxCostumes => "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Ë†ËœÃªÂ°â‚¬ Ã­â€¢Å“Ã«Ââ€žÃ¬â€”Â Ã«Ââ€žÃ«â€¹Â¬Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.ReachedMaxOutfits"
	/// English String: "You have reached the maximum number of outfits."
	/// </summary>
	public override string MessageReachedMaxOutfits => "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Ë†ËœÃªÂ°â‚¬ Ã­â€¢Å“Ã«Ââ€žÃ¬â€”Â Ã«Ââ€žÃ«â€¹Â¬Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.RedirectAvatarSettings"
	/// English String: "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home &gt; Game Settings &gt; Avatar"
	/// </summary>
	public override string MessageRedirectAvatarSettings => "Roblox Studio Ã­â€â€žÃ«Â¡Å“Ã¬Â ÂÃ­Å Â¸Ã¬â€”ÂÃ¬â€žÅ“ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã¬â€žÂ¤Ã¬Â â€¢Ã¬Ââ€ž Ã¬Â§â‚¬Ã¬Â â€¢Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬â€“Â´Ã¬Å¡â€. Roblox StudioÃ¬â€”ÂÃ¬â€žÅ“ Ã­â„¢Ë† > ÃªÂ²Å’Ã¬Å¾â€ž Ã¬â€žÂ¤Ã¬Â â€¢ > Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã«Â¡Å“ Ã¬ÂÂ´Ã«Ââ„¢Ã­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.RedrawFloodchecked"
	/// English String: "You have redrawn your avatar too many times, please try again later."
	/// </summary>
	public override string MessageRedrawFloodchecked => "Ã­â€”Ë†Ã¬Å¡Â©Ã«ÂÅ“ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã«â€¹Â¤Ã¬â€¹Å“ ÃªÂ·Â¸Ã«Â¦Â¬ÃªÂ¸Â°Ã«Â¥Â¼ Ã­Å¡Å¸Ã¬Ë†ËœÃ«Â¥Â¼ Ã¬Â´Ë†ÃªÂ³Â¼Ã­â€“Ë†Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.RedrawThumbnailFailed"
	/// English String: "Failed to redraw thumbnail."
	/// </summary>
	public override string MessageRedrawThumbnailFailed => "Ã¬â€žÂ¬Ã«â€žÂ¤Ã¬ÂÂ¼ Ã«â€¹Â¤Ã¬â€¹Å“ ÃªÂ·Â¸Ã«Â¦Â¬ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";

	/// <summary>
	/// Key: "Message.SelectEnableScaling"
	/// R15 is a proper noun
	/// English String: "Select R15 to enable scaling."
	/// </summary>
	public override string MessageSelectEnableScaling => "Ã­ÂÂ¬ÃªÂ¸Â°Ã«Â¥Â¼ Ã«Â³â‚¬ÃªÂ²Â½Ã­â€¢ËœÃ«Â Â¤Ã«Â©Â´ R15Ã«Â¥Â¼ Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessCreateCostume"
	/// English String: "Created costume"
	/// </summary>
	public override string MessageSuccessCreateCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â° Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessCreateOutfit"
	/// English String: "Created outfit"
	/// </summary>
	public override string MessageSuccessCreateOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â° Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessDeleteCostume"
	/// Deleted costume
	/// English String: "Deleted costume"
	/// </summary>
	public override string MessageSuccessDeleteCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“ Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessDeleteOutfit"
	/// English String: "Deleted outfit"
	/// </summary>
	public override string MessageSuccessDeleteOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“ Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessEquipEmote"
	/// English String: "Equipped Emote"
	/// </summary>
	public override string MessageSuccessEquipEmote => "Ã¬Å¾Â¥Ã¬Â°Â©Ã«ÂÅ“ ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";

	/// <summary>
	/// Key: "Message.SuccessRenameCostume"
	/// English String: "Renamed costume"
	/// </summary>
	public override string MessageSuccessRenameCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½ Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessRenameOutfit"
	/// English String: "Renamed outfit"
	/// </summary>
	public override string MessageSuccessRenameOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½ Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessSavedAccessories"
	/// English String: "Saved accessories"
	/// </summary>
	public override string MessageSuccessSavedAccessories => "Ã¬Â â‚¬Ã¬Å¾Â¥Ã­â€¢Å“ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";

	/// <summary>
	/// Key: "Message.SuccessUnequipEmote"
	/// English String: "Unequipped emote"
	/// </summary>
	public override string MessageSuccessUnequipEmote => "Ã¬Å¾Â¥Ã¬Â°Â© Ã­â€¢Â´Ã¬Â Å“Ã«ÂÅ“ ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";

	/// <summary>
	/// Key: "Message.SuccessUpdatedCostume"
	/// English String: "Updated costume"
	/// </summary>
	public override string MessageSuccessUpdatedCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessUpdatedOutfit"
	/// English String: "Updated outfit"
	/// </summary>
	public override string MessageSuccessUpdatedOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessWoreCostume"
	/// English String: "Successfully wore costume"
	/// </summary>
	public override string MessageSuccessWoreCostume => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.SuccessWoreOutfit"
	/// English String: "Successfully wore outfit"
	/// </summary>
	public override string MessageSuccessWoreOutfit => "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â„¢â€žÃ«Â£Å’";

	/// <summary>
	/// Key: "Message.UpdateThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisCostume => "Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Å“Â¼Ã«Â¡Å“ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬â€“Â´Ã¬Å¡â€? Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž Ã«ÂÂ®Ã¬â€“Â´Ã¬â€œÂ°ÃªÂ²Å’ Ã«ÂÂ©Ã«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Message.UpdateThisOutfit"
	/// English String: "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisOutfit => "Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Å“Â¼Ã«Â¡Å“ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬â€“Â´Ã¬Å¡â€? Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž Ã«ÂÂ®Ã¬â€“Â´Ã¬â€œÂ°ÃªÂ²Å’ Ã«ÂÂ©Ã«â€¹Ë†Ã«â€¹Â¤.";

	/// <summary>
	/// Key: "Message.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string MessageWarning => "Ã¬Â£Â¼Ã¬ÂËœ";

	public AvatarResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvanced()
	{
		return "ÃªÂ³Â ÃªÂ¸â€°";
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "ÃªÂµÂ¬Ã«Â§Â¤";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Ã¬Â·Â¨Ã¬â€ Å’";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Ã«â€¹Â«ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForActionCreateNewOutfit()
	{
		return "Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Ã¬â€šÂ­Ã¬Â Å“";
	}

	protected override string _GetTemplateForActionDone()
	{
		return "Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "Ã­Å¡ÂÃ«â€œÂ";
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "Ã«Ââ€ Ã«Â³Â´ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForActionOpenRobloxApp()
	{
		return "Roblox Ã¬â€¢Â± Ã¬â€”Â´ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForActionRedraw()
	{
		return "Ã«â€¹Â¤Ã¬â€¹Å“ ÃªÂ·Â¸Ã«Â¦Â¬ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForActionRename()
	{
		return "Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½";
	}

	protected override string _GetTemplateForActionRenameOutfit()
	{
		return "Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Ã¬Â â‚¬Ã¬Å¾Â¥";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ã¬Â â€žÃ¬Â²Â´ Ã«Â³Â´ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForActionThreeDimensions()
	{
		return "3D";
	}

	protected override string _GetTemplateForActionTwoDimensions()
	{
		return "2D";
	}

	protected override string _GetTemplateForActionUpdate()
	{
		return "Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸";
	}

	protected override string _GetTemplateForActionUserUnderstands()
	{
		return "Ã­â„¢â€¢Ã¬ÂÂ¸";
	}

	protected override string _GetTemplateForDescriptionAvatarEditorUpsell()
	{
		return "ÃªÂ²â€°Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž Ã«Â°â€ÃªÂ¾Â¸Ã«Â Â¤Ã«Â©Â´ Ã¬â€¢Â±Ã¬â€”Â Ã­ÂÂ¬Ã­â€¢Â¨Ã«ÂÅ“ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã­Å½Â¸Ã¬Â§â€˜ÃªÂ¸Â°Ã«Â¥Â¼ Ã¬â€šÂ¬Ã¬Å¡Â©Ã­â€¢Â´Ã¬â€¢Â¼ Ã­â€¢Â´Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForDescriptionCreateNewCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Ââ‚¬ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž ÃªÂ¸Â°Ã«Â°ËœÃ¬Å“Â¼Ã«Â¡Å“ Ã«Â§Å’Ã«â€œÂ¤Ã¬â€“Â´Ã¬Â§â€˜Ã«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForDescriptionCreateNewOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Ââ‚¬ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž ÃªÂ¸Â°Ã«Â°ËœÃ¬Å“Â¼Ã«Â¡Å“ Ã«Â§Å’Ã«â€œÂ¤Ã¬â€“Â´Ã¬Â§â€˜Ã«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForDescriptionRenameCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬â€”Â Ã¬Æ’Ë† Ã¬ÂÂ´Ã«Â¦â€žÃ¬Ââ€ž Ã¬Â§â‚¬Ã¬â€“Â´Ã¬Â£Â¼Ã¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForDescriptionRenameOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬â€”Â Ã¬Æ’Ë† Ã¬ÂÂ´Ã«Â¦â€žÃ¬Ââ€ž Ã¬Â§â‚¬Ã¬â€“Â´Ã¬Â£Â¼Ã¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForHeadingAccessories()
	{
		return "Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForHeadingAccessoriesChange()
	{
		return "Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬ Ã«Â³â‚¬ÃªÂ²Â½";
	}

	protected override string _GetTemplateForHeadingAdvancedOptions()
	{
		return "ÃªÂ³Â ÃªÂ¸â€° Ã¬ËœÂµÃ¬â€¦Ëœ";
	}

	protected override string _GetTemplateForHeadingAll()
	{
		return "Ã¬Â â€žÃ¬Â²Â´";
	}

	protected override string _GetTemplateForHeadingAnimations()
	{
		return "Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";
	}

	protected override string _GetTemplateForHeadingAppearance()
	{
		return "Ã«ÂªÂ¨Ã¬Å Âµ";
	}

	protected override string _GetTemplateForHeadingAvatarPageTitle()
	{
		return "Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã­Å½Â¸Ã¬Â§â€˜ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForHeadingBody()
	{
		return "Ã¬â€¹Â Ã¬Â²Â´";
	}

	protected override string _GetTemplateForHeadingBodyParts()
	{
		return "Ã¬â€¹Â Ã¬Â²Â´ Ã«Â¶â‚¬Ã¬Å“â€ž";
	}

	protected override string _GetTemplateForHeadingClothing()
	{
		return "Ã«Â³ÂµÃ¬Å¾Â¥";
	}

	protected override string _GetTemplateForHeadingCostumes()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";
	}

	protected override string _GetTemplateForHeadingCreateNewCostume()
	{
		return "Ã¬Æ’Ë† Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForHeadingCreateNewOutfit()
	{
		return "Ã¬Æ’Ë† Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForHeadingDelete()
	{
		return "Ã¬â€šÂ­Ã¬Â Å“";
	}

	protected override string _GetTemplateForHeadingDeleteCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“";
	}

	protected override string _GetTemplateForHeadingDeleteOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“";
	}

	protected override string _GetTemplateForHeadingEmotes()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";
	}

	protected override string _GetTemplateForHeadingEquipEmotes()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å¾Â¥Ã¬Â°Â©";
	}

	protected override string _GetTemplateForHeadingOutfits()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";
	}

	protected override string _GetTemplateForHeadingPackages()
	{
		return "Ã­Å’Â¨Ã­â€šÂ¤Ã¬Â§â‚¬";
	}

	protected override string _GetTemplateForHeadingRecent()
	{
		return "Ã¬ÂµÅ“ÃªÂ·Â¼";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "Ã¬Â¶â€Ã¬Â²Å“";
	}

	protected override string _GetTemplateForHeadingRenameCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½";
	}

	protected override string _GetTemplateForHeadingRenameOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½";
	}

	protected override string _GetTemplateForHeadingScaling()
	{
		return "Ã­ÂÂ¬ÃªÂ¸Â° Ã«Â³â‚¬ÃªÂ²Â½";
	}

	protected override string _GetTemplateForHeadingSkinToneBodyParts()
	{
		return "Ã¬â€¹Â Ã¬Â²Â´ Ã«Â¶â‚¬Ã¬Å“â€žÃ«Â³â€ž Ã­â€Â¼Ã«Â¶â‚¬ Ã¬Æ’â€°ÃªÂ¹â€";
	}

	protected override string _GetTemplateForHeadingUpdate()
	{
		return "Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸";
	}

	protected override string _GetTemplateForHeadingUpdateCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸";
	}

	protected override string _GetTemplateForHeadingUpdateOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Ã¬Â â€žÃ¬Â²Â´";
	}

	protected override string _GetTemplateForLabelAskIfLoadingCorrectly()
	{
		return "Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã«Â¥Â¼ Ã¬Â Å“Ã«Å’â‚¬Ã«Â¡Å“ Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¬ Ã¬Ë†Ëœ Ã¬â€”â€ Ã«â€¹Â¤ÃªÂµÂ¬Ã¬Å¡â€?";
	}

	protected override string _GetTemplateForLabelAssetIDPlaceholder()
	{
		return "Ã¬â€¢Â Ã¬â€¦â€¹ ID";
	}

	protected override string _GetTemplateForLabelBack()
	{
		return "Ã«â€œÂ±";
	}

	protected override string _GetTemplateForLabelBackAccessories()
	{
		return "Ã«â€œÂ± Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForLabelBodyType()
	{
		return "Ã¬Â²Â´Ã­Ëœâ€¢";
	}

	protected override string _GetTemplateForLabelClimb()
	{
		return "Ã¬ËœÂ¤Ã«Â¥Â´ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForLabelClimbAnimations()
	{
		return "Ã¬ËœÂ¤Ã«Â¥Â´ÃªÂ¸Â° Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";
	}

	protected override string _GetTemplateForLabelClothes()
	{
		return "Ã«Â³ÂµÃ¬Å¾Â¥";
	}

	protected override string _GetTemplateForLabelCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";
	}

	/// <summary>
	/// Key: "Label.DirectionsForPackagePlacement"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}"
	/// </summary>
	public override string LabelDirectionsForPackagePlacement(string startBold, string rightArrow, string endBold)
	{
		return $"Ã­Å’Â¨Ã­â€šÂ¤Ã¬Â§â‚¬ÃªÂ°â‚¬ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Å“Â¼Ã«Â¡Å“ Ã¬ÂÂ´Ã«Ââ„¢Ã­â€“Ë†Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤. {startBold}Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬{rightArrow}ÃªÂ¸Â°Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬{endBold}Ã¬Ââ€ž Ã­â„¢â€¢Ã¬ÂÂ¸Ã­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForLabelDirectionsForPackagePlacement()
	{
		return "Ã­Å’Â¨Ã­â€šÂ¤Ã¬Â§â‚¬ÃªÂ°â‚¬ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Å“Â¼Ã«Â¡Å“ Ã¬ÂÂ´Ã«Ââ„¢Ã­â€“Ë†Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤. {startBold}Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬{rightArrow}ÃªÂ¸Â°Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬{endBold}Ã¬Ââ€ž Ã­â„¢â€¢Ã¬ÂÂ¸Ã­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	/// <summary>
	/// Key: "Label.DirectionsForScalingOptions"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}"
	/// </summary>
	public override string LabelDirectionsForScalingOptions(string startBold, string rightArrow, string endBold)
	{
		return $"Ã¬â€¹Â Ã¬Â²Â´ Ã¬Â¹Â´Ã­â€¦Å’ÃªÂ³Â Ã«Â¦Â¬Ã¬â€”Â Ã¬Å¾Ë†Ã«Å â€ Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“Ã¬Ââ‚¬ Ã­ÂÂ¬ÃªÂ¸Â°Ã«Â¥Â¼ Ã¬Â¡Â°Ã¬Â Ë†Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬â€“Â´Ã¬Å¡â€. {startBold}Ã¬â€¹Â Ã¬Â²Â´{rightArrow}Ã­ÂÂ¬ÃªÂ¸Â°{endBold}Ã«Â¥Â¼ Ã­â„¢â€¢Ã¬ÂÂ¸Ã­â€¢Â´Ã«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForLabelDirectionsForScalingOptions()
	{
		return "Ã¬â€¹Â Ã¬Â²Â´ Ã¬Â¹Â´Ã­â€¦Å’ÃªÂ³Â Ã«Â¦Â¬Ã¬â€”Â Ã¬Å¾Ë†Ã«Å â€ Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“Ã¬Ââ‚¬ Ã­ÂÂ¬ÃªÂ¸Â°Ã«Â¥Â¼ Ã¬Â¡Â°Ã¬Â Ë†Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬â€“Â´Ã¬Å¡â€. {startBold}Ã¬â€¹Â Ã¬Â²Â´{rightArrow}Ã­ÂÂ¬ÃªÂ¸Â°{endBold}Ã«Â¥Â¼ Ã­â„¢â€¢Ã¬ÂÂ¸Ã­â€¢Â´Ã«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForlabelEmotes()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";
	}

	protected override string _GetTemplateForLabelEquip()
	{
		return "Ã¬Å¾Â¥Ã¬Â°Â©";
	}

	protected override string _GetTemplateForLabelExploreCatalog()
	{
		return "Ã¬Â¹Â´Ã­Æ’Ë†Ã«Â¡Å“ÃªÂ·Â¸Ã¬â€”ÂÃ¬â€žÅ“ Ã«Ââ€ Ã«Â§Å½Ã¬Ââ‚¬ Ã«Â³ÂµÃ¬Å¾Â¥Ã¬Ââ€ž Ã¬Â°Â¾Ã¬â€¢â€žÃ«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€!";
	}

	protected override string _GetTemplateForLabelFace()
	{
		return "Ã¬â€“Â¼ÃªÂµÂ´";
	}

	protected override string _GetTemplateForLabelFaceAccessories()
	{
		return "Ã¬â€“Â¼ÃªÂµÂ´ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "Ã¬â€“Â¼ÃªÂµÂ´";
	}

	protected override string _GetTemplateForLabelFall()
	{
		return "Ã«â€šâ„¢Ã­â€¢Ëœ";
	}

	protected override string _GetTemplateForLabelFallAnimations()
	{
		return "Ã«â€šâ„¢Ã­â€¢Ëœ Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "Ã«Â¬Â´Ã«Â£Å’";
	}

	protected override string _GetTemplateForLabelFront()
	{
		return "ÃªÂ°â‚¬Ã¬Å Â´";
	}

	protected override string _GetTemplateForLabelFrontAccessories()
	{
		return "ÃªÂ°â‚¬Ã¬Å Â´ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "Ã¬Å¾Â¥Ã«Â¹â€ž";
	}

	protected override string _GetTemplateForLabelHair()
	{
		return "Ã­â€”Â¤Ã¬â€“Â´";
	}

	protected override string _GetTemplateForLabelHairAccessories()
	{
		return "Ã­â€”Â¤Ã¬â€“Â´ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForLabelHat()
	{
		return "Ã«ÂªÂ¨Ã¬Å¾Â";
	}

	protected override string _GetTemplateForLabelHatAccessories()
	{
		return "Ã«ÂªÂ¨Ã¬Å¾Â Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForLabelHead()
	{
		return "Ã«Â¨Â¸Ã«Â¦Â¬";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "Ã«Â¨Â¸Ã«Â¦Â¬";
	}

	protected override string _GetTemplateForLabelHeight()
	{
		return "Ã«â€ â€™Ã¬ÂÂ´";
	}

	protected override string _GetTemplateForLabelIdle()
	{
		return "Ã«Å’â‚¬ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForLabelIdleAnimations()
	{
		return "Ã«Å’â‚¬ÃªÂ¸Â° Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";
	}

	protected override string _GetTemplateForLabelJump()
	{
		return "Ã¬Â ÂÃ­â€â€ž";
	}

	protected override string _GetTemplateForLabelJumpAnimations()
	{
		return "Ã¬Â ÂÃ­â€â€ž Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";
	}

	protected override string _GetTemplateForLabelLeftArm()
	{
		return "Ã¬â„¢Â¼Ã­Å’â€";
	}

	protected override string _GetTemplateForLabelLeftArms()
	{
		return "Ã¬â„¢Â¼Ã­Å’â€";
	}

	protected override string _GetTemplateForLabelLeftLeg()
	{
		return "Ã¬â„¢Â¼ Ã«â€¹Â¤Ã«Â¦Â¬";
	}

	protected override string _GetTemplateForLabelLeftLegs()
	{
		return "Ã¬â„¢Â¼ Ã«â€¹Â¤Ã«Â¦Â¬";
	}

	protected override string _GetTemplateForLabelMyCostumes()
	{
		return "Ã«â€šÂ´ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";
	}

	protected override string _GetTemplateForLabelNamePlaceholderCostume()
	{
		return "Ã¬Æ’Ë† Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã¬Å¾â€¦Ã«Â Â¥";
	}

	protected override string _GetTemplateForLabelNamePlaceholderOutfit()
	{
		return "Ã¬Æ’Ë† Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã¬Å¾â€¦Ã«Â Â¥";
	}

	protected override string _GetTemplateForLabelNeck()
	{
		return "Ã«ÂªÂ©";
	}

	protected override string _GetTemplateForLabelNeckAccessories()
	{
		return "Ã«ÂªÂ© Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "Ã¬Å¾Â¬Ã­Å’ÂÃ«Â§Â¤Ã¬Å¾Â Ã¬â€”â€ Ã¬ÂÅ’";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "Ã­Å’ÂÃ«Â§Â¤ Ã¬Â¤â€˜Ã«â€¹Â¨";
	}

	protected override string _GetTemplateForLabelOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "Ã«Â°â€Ã¬Â§â‚¬";
	}

	protected override string _GetTemplateForLabelParts()
	{
		return "Ã«Â¶â‚¬Ã¬Å“â€ž";
	}

	protected override string _GetTemplateForLabelPresetCostumes()
	{
		return "ÃªÂ¸Â°Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬";
	}

	protected override string _GetTemplateForLabelProportions()
	{
		return "Ã«Â¹â€žÃ¬Å“Â¨";
	}

	protected override string _GetTemplateForLabelRedrawUnavailable()
	{
		return "Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã«â€¹Â¤Ã¬â€¹Å“ ÃªÂ·Â¸Ã«Â¦Â¬ÃªÂ¸Â°Ã«Â¥Â¼ Ã¬â€šÂ¬Ã¬Å¡Â©Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForLabelRightArm()
	{
		return "Ã¬ËœÂ¤Ã«Â¥Â¸Ã­Å’â€";
	}

	protected override string _GetTemplateForLabelRightArms()
	{
		return "Ã¬ËœÂ¤Ã«Â¥Â¸Ã­Å’â€";
	}

	protected override string _GetTemplateForLabelRightLeg()
	{
		return "Ã¬ËœÂ¤Ã«Â¥Â¸ Ã«â€¹Â¤Ã«Â¦Â¬";
	}

	protected override string _GetTemplateForLabelRightLegs()
	{
		return "Ã¬ËœÂ¤Ã«Â¥Â¸ Ã«â€¹Â¤Ã«Â¦Â¬";
	}

	protected override string _GetTemplateForLabelRun()
	{
		return "Ã«â€¹Â¬Ã«Â¦Â¬ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForLabelRunAnimations()
	{
		return "Ã«â€¹Â¬Ã«Â¦Â¬ÃªÂ¸Â° Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";
	}

	protected override string _GetTemplateForLabelScale()
	{
		return "Ã­ÂÂ¬ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForLabelShirts()
	{
		return "Ã¬â€¦â€Ã¬Â¸Â ";
	}

	protected override string _GetTemplateForLabelShoulderAccessories()
	{
		return "Ã¬â€“Â´ÃªÂ¹Â¨ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForLabelShoulders()
	{
		return "Ã¬â€“Â´ÃªÂ¹Â¨";
	}

	protected override string _GetTemplateForLabelSkinTone()
	{
		return "Ã­â€Â¼Ã«Â¶â‚¬ Ã¬Æ’â€°ÃªÂ¹â€";
	}

	protected override string _GetTemplateForLabelSwim()
	{
		return "Ã¬Ë†ËœÃ¬ËœÂ";
	}

	protected override string _GetTemplateForLabelSwimAnimations()
	{
		return "Ã¬Ë†ËœÃ¬ËœÂ Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";
	}

	protected override string _GetTemplateForLabelSwitchAvatarType()
	{
		return "ÃªÂ¸Â°Ã¬Â¡Â´ R6 Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬â„¢â‚¬ Ã«Ââ€Ã¬Å¡Â± Ã¬Â â€¢ÃªÂµÂÃ­â€¢Å“ Ã¬Â°Â¨Ã¬â€žÂ¸Ã«Å’â‚¬ R15 Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ÃªÂ°â€ž Ã¬Â â€žÃ­â„¢ËœÃ¬ÂÂ´ ÃªÂ°â‚¬Ã«Å Â¥Ã­â€¢Â©Ã«â€¹Ë†Ã«â€¹Â¤";
	}

	protected override string _GetTemplateForLabelTorso()
	{
		return "Ã«ÂªÂ¸Ã­â€ Âµ";
	}

	protected override string _GetTemplateForLabelTorsos()
	{
		return "Ã«ÂªÂ¸Ã­â€ Âµ";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "Ã­â€¹Â°Ã¬â€¦â€Ã¬Â¸Â ";
	}

	protected override string _GetTemplateForLabelWaist()
	{
		return "Ã­â€”Ë†Ã«Â¦Â¬";
	}

	protected override string _GetTemplateForLabelWaistAccessories()
	{
		return "Ã­â€”Ë†Ã«Â¦Â¬ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForLabelWalk()
	{
		return "ÃªÂ±Â·ÃªÂ¸Â°";
	}

	protected override string _GetTemplateForLabelWalkAnimations()
	{
		return "ÃªÂ±Â·ÃªÂ¸Â° Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ";
	}

	protected override string _GetTemplateForLabelWidth()
	{
		return "Ã«â€žâ€œÃ¬ÂÂ´";
	}

	protected override string _GetTemplateForLabelYourEmotes()
	{
		return "Ã­â€Å’Ã«Â Ë†Ã¬ÂÂ´Ã¬â€“Â´Ã¬ÂËœ ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";
	}

	protected override string _GetTemplateForMessageAccessoriesChange()
	{
		return "Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž Ã«ÂÂ®Ã¬â€“Â´Ã¬â€œÂ¸ÃªÂ¹Å’Ã¬Å¡â€?";
	}

	protected override string _GetTemplateForMessageChooseEmote()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlot()
	{
		return "Ã¬Å Â¬Ã«Â¡Â¯Ã¬Ââ€ž Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlotOrEmote()
	{
		return "Ã¬Å Â¬Ã«Â¡Â¯Ã¬ÂÂ´Ã«â€šËœ ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€";
	}

	protected override string _GetTemplateForMessageDefaultClothing()
	{
		return "ÃªÂ¸Â°Ã«Â³Â¸ Ã«Â³ÂµÃ¬Å¾Â¥Ã¬ÂÂ´ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬â€”Â Ã¬Â ÂÃ¬Å¡Â©Ã«ÂËœÃ¬â€”Ë†Ã¬â€“Â´Ã¬Å¡â€. Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã«Â³ÂµÃ¬Å¾Â¥Ã¬â€”ÂÃ¬â€žÅ“ Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€”Â¬ Ã¬Â°Â©Ã¬Å¡Â©Ã­â€¢Â´Ã«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€.";
	}

	/// <summary>
	/// Key: "Message.DeleteOutfit"
	/// English String: "Are you sure you want to delete this {outfitType}?"
	/// </summary>
	public override string MessageDeleteOutfit(string outfitType)
	{
		return $"Ã«Â³Â¸ {outfitType}Ã¬Ââ€ž(Ã«Â¥Â¼) Ã¬Â â€¢Ã«Â§Â Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬Å ÂµÃ«â€¹Ë†ÃªÂ¹Å’?";
	}

	protected override string _GetTemplateForMessageDeleteOutfit()
	{
		return "Ã«Â³Â¸ {outfitType}Ã¬Ââ€ž(Ã«Â¥Â¼) Ã¬Â â€¢Ã«Â§Â Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬Å ÂµÃ«â€¹Ë†ÃªÂ¹Å’?";
	}

	protected override string _GetTemplateForMessageDeleteThisCostume()
	{
		return "Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Ââ€ž Ã¬Â â€¢Ã«Â§Â Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬Å ÂµÃ«â€¹Ë†ÃªÂ¹Å’?";
	}

	protected override string _GetTemplateForMessageDeleteThisOutfit()
	{
		return "Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Ââ€ž Ã¬Â â€¢Ã«Â§Â Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬Å ÂµÃ«â€¹Ë†ÃªÂ¹Å’?";
	}

	protected override string _GetTemplateForMessageEmotesInstructions()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬Å¾Â¥Ã¬Â°Â©Ã­â€¢ËœÃ«Â Â¤Ã«Â©Â´ Ã«â€¹Â¤Ã¬ÂÅ’Ã¬Å“Â¼Ã«Â¡Å“ Ã¬ÂÂ´Ã«Ââ„¢Ã­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€. 'Ã¬â€¢Â Ã«â€¹Ë†Ã«Â©â€Ã¬ÂÂ´Ã¬â€¦Ëœ > ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž > ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å¾Â¥Ã¬Â°Â©'";
	}

	protected override string _GetTemplateForMessageEmptyAssetList()
	{
		return "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬â€¢Â Ã¬â€¦â€¹Ã¬ÂÂ´ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";
	}

	/// <summary>
	/// Key: "Message.EmptyListForItem"
	/// The user tries to load a list of some item but they see nothing because they don't own anything of that type.
	/// English String: "You don't have this item: {itemType}"
	/// </summary>
	public override string MessageEmptyListForItem(string itemType)
	{
		return $"Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ {itemType}Ã¬ÂÂ´(ÃªÂ°â‚¬) Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤";
	}

	protected override string _GetTemplateForMessageEmptyListForItem()
	{
		return "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ {itemType}Ã¬ÂÂ´(ÃªÂ°â‚¬) Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤";
	}

	protected override string _GetTemplateForMessageEmptyListOfCostumes()
	{
		return "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬ÂÂ´ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤. Ã¬Â§ÂÃ¬Â â€˜ Ã«Â§Å’Ã«â€œÂ¤Ã¬â€“Â´Ã«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€!";
	}

	protected override string _GetTemplateForMessageEmptyListOfOutfits()
	{
		return "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€ Ã¬ÂÅ’. Ã¬Æ’Ë†Ã«Â¡Å“ Ã«Â§Å’Ã«â€œÂ¤Ã¬â€“Â´Ã«Â³Â´Ã¬â€žÂ¸Ã¬Å¡â€!";
	}

	protected override string _GetTemplateForMessageEmptyRecentItems()
	{
		return "Ã¬ÂµÅ“ÃªÂ·Â¼ Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“Ã¬ÂÂ´ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessageErrorCreateCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorCreateOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â° Ã«Â¶Ë†ÃªÂ°â‚¬. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorDeleteEmote()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬Â§â‚¬ Ã«ÂªÂ»Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorEquipEmote()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å¾Â¥Ã¬Â°Â© Ã¬â€¹Â¤Ã­Å’Â¨. Ã¬Å¾Â Ã¬â€¹Å“ Ã­â€ºâ€ž Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorLoadCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageErrorLoadEmotes()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤Ã¬Â§â‚¬ Ã«ÂªÂ»Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorLoadOutfits()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageErrorOutfitName()
	{
		return "Ã¬ÂÂ´Ã«Â¦â€žÃ¬Ââ‚¬ Ã¬â€¢Å’Ã­Å’Å’Ã«Â²Â³, Ã¬Ë†Â«Ã¬Å¾Â, Ã«Â¹Ë† Ã¬Â¹Â¸Ã¬Ââ€ž Ã¬Â¡Â°Ã­â€¢Â©Ã­â€¢ËœÃ¬â€”Â¬ Ã«Â§Å’Ã«â€œÂ¤ Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬â€“Â´Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorRenameCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½ Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageErrorRenameOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½ Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageErrorUnequipEmote()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å¾Â¥Ã¬Â°Â© Ã­â€¢Â´Ã¬Â Å“Ã¬â€”Â Ã¬â€¹Â¤Ã­Å’Â¨Ã­â€“Ë†Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessageErrorUpdateCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorUpdateEmote()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž Ã¬Å Â¬Ã«Â¡Â¯ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨. Ã¬Å¾Â Ã¬â€¹Å“ Ã­â€ºâ€ž Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorUpdateOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorUpdateWorn()
	{
		return "Ã¬Â°Â©Ã¬Å¡Â© Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬Â¤â€˜ Ã¬ËœÂ¤Ã«Â¥ËœÃªÂ°â‚¬ Ã«Â°Å“Ã¬Æ’ÂÃ­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageErrorWearCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageErrorWearOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageFailedDeleteCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“ Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageFailedDeleteEmote()
	{
		return "ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€žÃ¬Ââ€ž Ã¬â€šÂ­Ã¬Â Å“Ã­â€¢ËœÃ¬Â§â‚¬ Ã«ÂªÂ»Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageFailedDeleteOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“ Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageFailedLoadAssets()
	{
		return "Ã¬â€¢Â Ã¬â€¦â€¹ Ã«ÂªÂ©Ã«Â¡Â Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageFailedLoadRecent()
	{
		return "Ã¬ÂµÅ“ÃªÂ·Â¼ Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“ Ã«Â¶Ë†Ã«Å¸Â¬Ã¬ËœÂ¤ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageFailedUpdateBodyColor()
	{
		return "Ã­â€Â¼Ã«Â¶â‚¬ Ã¬Æ’â€°ÃªÂ¹â€ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedCostume()
	{
		return "Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ«Â Â¤Ã«Å â€ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬ÂÂ´ Ã«Ââ€ Ã¬ÂÂ´Ã¬Æ’Â Ã¬Â¡Â´Ã¬Å¾Â¬Ã­â€¢ËœÃ¬Â§â‚¬ Ã¬â€¢Å Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedOutfit()
	{
		return "Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ«Â Â¤Ã«Å â€ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬ÂÂ´ Ã«Ââ€ Ã¬ÂÂ´Ã¬Æ’Â Ã¬Â¡Â´Ã¬Å¾Â¬Ã­â€¢ËœÃ¬Â§â‚¬ Ã¬â€¢Å Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessageFailedUpdateScales()
	{
		return "Ã­ÂÂ¬ÃªÂ¸Â° Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageFailedUpdateType()
	{
		return "Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã¬Å“Â Ã­Ëœâ€¢ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageFailedWearPackage()
	{
		return "Ã­Å’Â¨Ã­â€šÂ¤Ã¬Â§â‚¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageHatLimitTooltip()
	{
		return "Ã«ÂªÂ¨Ã¬Å¾ÂÃ«Å â€ Ã¬ÂµÅ“Ã«Å’â‚¬ 3ÃªÂ°Å“ÃªÂ¹Å’Ã¬Â§â‚¬ Ã¬Â°Â©Ã¬Å¡Â©Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬â€“Â´Ã¬Å¡â€";
	}

	protected override string _GetTemplateForMessageInvalidOutfitName()
	{
		return "Ã¬ÂÂ´Ã«Â¦â€žÃ¬Ââ‚¬ Ã¬Â ÂÃ¬Â Ë†Ã­â€¢Å“ Ã¬Å¡Â©Ã¬â€“Â´Ã«Â¥Â¼ Ã¬â€šÂ¬Ã¬Å¡Â©Ã­â€¢ËœÃ¬â€”Â¬Ã¬â€¢Â¼ Ã­â€¢ËœÃ«Â©Â° 200Ã¬Å¾Â Ã¬ÂÂ´Ã«â€šÂ´Ã«Â¡Å“ Ã¬Å¾â€¦Ã«Â Â¥Ã­â€¢ËœÃ¬â€¦â€Ã¬â€¢Â¼ Ã­â€¢Â©Ã«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "Ã«Â¡Å“Ã«â€œÅ“ Ã¬Â¤â€˜...";
	}

	/// <summary>
	/// Key: "Message.MissingItemsFromOutfit"
	/// User cannot wear an outfit because they are missing or have deleted some of the items that were part of that outfit.
	/// English String: "Number of items that you don't own in this outfit: {number}"
	/// </summary>
	public override string MessageMissingItemsFromOutfit(string number)
	{
		return $"Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬â€”ÂÃ¬â€žÅ“ Ã¬â€ Å’Ã¬Å“Â Ã­â€¢ËœÃ¬Â§â‚¬ Ã¬â€¢Å Ã¬Ââ‚¬ Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“ Ã¬Ë†Ëœ: {number}";
	}

	protected override string _GetTemplateForMessageMissingItemsFromOutfit()
	{
		return "Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬â€”ÂÃ¬â€žÅ“ Ã¬â€ Å’Ã¬Å“Â Ã­â€¢ËœÃ¬Â§â‚¬ Ã¬â€¢Å Ã¬Ââ‚¬ Ã¬â€¢â€žÃ¬ÂÂ´Ã­â€¦Å“ Ã¬Ë†Ëœ: {number}";
	}

	protected override string _GetTemplateForMessagePageUnavailable()
	{
		return "Ã¬Â§â‚¬ÃªÂ¸Ë†Ã¬Ââ‚¬ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã­Å½ËœÃ¬ÂÂ´Ã¬Â§â‚¬Ã«Â¥Â¼ Ã¬ÂÂ´Ã¬Å¡Â©Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬â€”â€ Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessagePresetCostumesDelay()
	{
		return "Ã¬â€¢Å’Ã«Â¦Â¼: Ã¬Â ÂÃªÂ²â‚¬ Ã¬Â¤â€˜. Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬ÂÂ´ Ã«â€šËœÃ­Æ’â‚¬Ã«â€šËœÃ«Å â€ Ã«ÂÂ° Ã«Âªâ€¡ Ã«Â¶â€ž Ã¬Â â€¢Ã«Ââ€ž Ã¬â€ Å’Ã¬Å¡â€Ã«ÂÂ  Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤. Ã¬Å¾Â Ã¬â€¹Å“ Ã­â€ºâ€ž Ã«â€¹Â¤Ã¬â€¹Å“ Ã­â„¢â€¢Ã¬ÂÂ¸Ã­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageReachedMaxCostumes()
	{
		return "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Ë†ËœÃªÂ°â‚¬ Ã­â€¢Å“Ã«Ââ€žÃ¬â€”Â Ã«Ââ€žÃ«â€¹Â¬Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageReachedMaxOutfits()
	{
		return "Ã«Â³Â´Ã¬Å“Â Ã­â€¢Å“ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Ë†ËœÃªÂ°â‚¬ Ã­â€¢Å“Ã«Ââ€žÃ¬â€”Â Ã«Ââ€žÃ«â€¹Â¬Ã­â€“Ë†Ã¬â€“Â´Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageRedirectAvatarSettings()
	{
		return "Roblox Studio Ã­â€â€žÃ«Â¡Å“Ã¬Â ÂÃ­Å Â¸Ã¬â€”ÂÃ¬â€žÅ“ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã¬â€žÂ¤Ã¬Â â€¢Ã¬Ââ€ž Ã¬Â§â‚¬Ã¬Â â€¢Ã­â€¢Â  Ã¬Ë†Ëœ Ã¬Å¾Ë†Ã¬â€“Â´Ã¬Å¡â€. Roblox StudioÃ¬â€”ÂÃ¬â€žÅ“ Ã­â„¢Ë† > ÃªÂ²Å’Ã¬Å¾â€ž Ã¬â€žÂ¤Ã¬Â â€¢ > Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã«Â¡Å“ Ã¬ÂÂ´Ã«Ââ„¢Ã­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageRedrawFloodchecked()
	{
		return "Ã­â€”Ë†Ã¬Å¡Â©Ã«ÂÅ“ Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬ Ã«â€¹Â¤Ã¬â€¹Å“ ÃªÂ·Â¸Ã«Â¦Â¬ÃªÂ¸Â°Ã«Â¥Â¼ Ã­Å¡Å¸Ã¬Ë†ËœÃ«Â¥Â¼ Ã¬Â´Ë†ÃªÂ³Â¼Ã­â€“Ë†Ã¬Å ÂµÃ«â€¹Ë†Ã«â€¹Â¤. Ã«â€šËœÃ¬Â¤â€˜Ã¬â€”Â Ã«â€¹Â¤Ã¬â€¹Å“ Ã¬â€¹Å“Ã«Ââ€žÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageRedrawThumbnailFailed()
	{
		return "Ã¬â€žÂ¬Ã«â€žÂ¤Ã¬ÂÂ¼ Ã«â€¹Â¤Ã¬â€¹Å“ ÃªÂ·Â¸Ã«Â¦Â¬ÃªÂ¸Â° Ã¬â€¹Â¤Ã­Å’Â¨.";
	}

	protected override string _GetTemplateForMessageSelectEnableScaling()
	{
		return "Ã­ÂÂ¬ÃªÂ¸Â°Ã«Â¥Â¼ Ã«Â³â‚¬ÃªÂ²Â½Ã­â€¢ËœÃ«Â Â¤Ã«Â©Â´ R15Ã«Â¥Â¼ Ã¬â€žÂ Ã­Æ’ÂÃ­â€¢ËœÃ¬â€žÂ¸Ã¬Å¡â€.";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessCreateCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â° Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessCreateOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã«Â§Å’Ã«â€œÂ¤ÃªÂ¸Â° Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessDeleteCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“ Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessDeleteOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€šÂ­Ã¬Â Å“ Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessEquipEmote()
	{
		return "Ã¬Å¾Â¥Ã¬Â°Â©Ã«ÂÅ“ ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";
	}

	protected override string _GetTemplateForMessageSuccessRenameCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½ Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessRenameOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬ÂÂ´Ã«Â¦â€ž Ã«Â³â‚¬ÃªÂ²Â½ Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessSavedAccessories()
	{
		return "Ã¬Â â‚¬Ã¬Å¾Â¥Ã­â€¢Å“ Ã¬Å¾Â¥Ã¬â€¹Â ÃªÂµÂ¬";
	}

	protected override string _GetTemplateForMessageSuccessUnequipEmote()
	{
		return "Ã¬Å¾Â¥Ã¬Â°Â© Ã­â€¢Â´Ã¬Â Å“Ã«ÂÅ“ ÃªÂ°ÂÃ¬Â â€¢ Ã­â€˜Å“Ã­Ëœâ€ž";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸ Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessWoreCostume()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â„¢â€žÃ«Â£Å’";
	}

	protected override string _GetTemplateForMessageSuccessWoreOutfit()
	{
		return "Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬ Ã¬Â°Â©Ã¬Å¡Â© Ã¬â„¢â€žÃ«Â£Å’";
	}

	/// <summary>
	/// Key: "Message.UpdateOutfit"
	/// English String: "Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateOutfit(string outfitType1, string outfitType2)
	{
		return $"Ã«Â³Â¸ {outfitType1}(Ã¬Å“Â¼)Ã«Â¡Å“ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬â€“Â´Ã¬Å¡â€? Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬â€”Â Ã¬Â ÂÃ¬Å¡Â©Ã«ÂÅ“ {outfitType2}Ã¬Ââ€ž(Ã«Â¥Â¼) Ã«ÂÂ®Ã¬â€“Â´Ã¬â€œÂ°ÃªÂ²Å’ Ã«ÂÂ©Ã«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessageUpdateOutfit()
	{
		return "Ã«Â³Â¸ {outfitType1}(Ã¬Å“Â¼)Ã«Â¡Å“ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬â€“Â´Ã¬Å¡â€? Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬â€”Â Ã¬Â ÂÃ¬Å¡Â©Ã«ÂÅ“ {outfitType2}Ã¬Ââ€ž(Ã«Â¥Â¼) Ã«ÂÂ®Ã¬â€“Â´Ã¬â€œÂ°ÃªÂ²Å’ Ã«ÂÂ©Ã«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessageUpdateThisCostume()
	{
		return "Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Å“Â¼Ã«Â¡Å“ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬â€“Â´Ã¬Å¡â€? Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž Ã«ÂÂ®Ã¬â€“Â´Ã¬â€œÂ°ÃªÂ²Å’ Ã«ÂÂ©Ã«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessageUpdateThisOutfit()
	{
		return "Ã«Â³Â¸ Ã¬Â½â€Ã¬Å Â¤Ã­Å Â¬Ã¬Å“Â¼Ã«Â¡Å“ Ã¬â€”â€¦Ã«ÂÂ°Ã¬ÂÂ´Ã­Å Â¸Ã­â€¢ËœÃ¬â€¹Å“ÃªÂ²Â Ã¬â€“Â´Ã¬Å¡â€? Ã¬â€¢â€žÃ«Â°â€Ã­Æ’â‚¬Ã¬ÂËœ Ã­Ëœâ€žÃ¬Å¾Â¬ Ã«ÂªÂ¨Ã¬Å ÂµÃ¬Ââ€ž Ã«ÂÂ®Ã¬â€“Â´Ã¬â€œÂ°ÃªÂ²Å’ Ã«ÂÂ©Ã«â€¹Ë†Ã«â€¹Â¤.";
	}

	protected override string _GetTemplateForMessageWarning()
	{
		return "Ã¬Â£Â¼Ã¬ÂËœ";
	}
}


}

