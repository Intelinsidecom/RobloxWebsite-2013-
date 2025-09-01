using System;
using System.Collections.Generic;
namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides AvatarResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AvatarResources_ja_jp : AvatarResources_en_us, IAvatarResources, ITranslationResources
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
	public override string ActionAdvanced => "Ã¨Â©Â³Ã§Â´Â°";

	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item to customize the user's avatar.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "Ã¨Â²Â·Ã£Ââ€ ";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Ã£â€šÂ­Ã£Æ’Â£Ã£Æ’Â³Ã£â€šÂ»Ã£Æ’Â«";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Ã©â€“â€°Ã£ÂËœÃ£â€šâ€¹";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "Ã¤Â½Å“Ã¦Ë†Â";

	/// <summary>
	/// Key: "Action.CreateNewOutfit"
	/// Button to create new outfit
	/// English String: "Create"
	/// </summary>
	public override string ActionCreateNewOutfit => "Ã¤Â½Å“Ã¦Ë†Â";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Ã¥â€°Å Ã©â„¢Â¤";

	/// <summary>
	/// Key: "Action.Done"
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "Ã¥Â®Å’Ã¤Âºâ€ ";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy get an item for free to customize the user's avatar.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "Ã£â€šÂ²Ã£Æ’Æ’Ã£Æ’Ë†Ã£Ââ„¢Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Action.GetMore"
	/// A call to action for the user to buy more clothes from the Catalog page. This could improve how their avatar looks.
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "Ã£Ââ€¢Ã£â€šâ€°Ã£ÂÂ«Ã£â€šÂ²Ã£Æ’Æ’Ã£Æ’Ë†";

	/// <summary>
	/// Key: "Action.OpenRobloxApp"
	/// English String: "Open Roblox App"
	/// </summary>
	public override string ActionOpenRobloxApp => "RobloxÃ£â€šÂ¢Ã£Æ’â€”Ã£Æ’ÂªÃ£â€šâ€™Ã¨ÂµÂ·Ã¥â€¹â€¢Ã£Ââ„¢Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Action.Redraw"
	/// Redraw the avatar on the screen
	/// English String: "Redraw"
	/// </summary>
	public override string ActionRedraw => "Ã£Æ’ÂªÃ£Æ’â€°Ã£Æ’Â­Ã£Æ’Â¼Ã£Ââ„¢Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Action.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string ActionRename => "Ã¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ„¢Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Action.RenameOutfit"
	/// Button to rename outfit
	/// English String: "Rename"
	/// </summary>
	public override string ActionRenameOutfit => "Ã¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ„¢Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Ã¤Â¿ÂÃ¥Â­Ëœ";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// See all clothing that user can buy
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ã£Ââ„¢Ã£ÂÂ¹Ã£ÂÂ¦Ã¨Â¦â€¹Ã£â€šâ€¹";

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
	public override string ActionUpdate => "Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†";

	/// <summary>
	/// Key: "Action.UserUnderstands"
	/// The user casually responds to the application saying that they understand how to navigate the menu.
	/// English String: "Got it"
	/// </summary>
	public override string ActionUserUnderstands => "OK";

	/// <summary>
	/// Key: "Description.AvatarEditorUpsell"
	/// English String: "To change your look you will need to use the Avatar Editor on the App."
	/// </summary>
	public override string DescriptionAvatarEditorUpsell => "Ã¥Â¤â€“Ã¨Â¦â€¹Ã£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ«Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šÂ¢Ã£Æ’â€”Ã£Æ’ÂªÃ£ÂÂ®Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£â€šÂ¨Ã£Æ’â€¡Ã£â€šÂ£Ã£â€šÂ¿Ã£â€šâ€™Ã¤Â½Â¿Ã§â€Â¨Ã£Ââ„¢Ã£â€šâ€¹Ã¥Â¿â€¦Ã¨Â¦ÂÃ£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Description.CreateNewCostume"
	/// A costume will be created from your avatar's current appearance.
	/// English String: "A costume will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£Ââ€¹Ã£â€šâ€°Ã¤Â½Å“Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Description.CreateNewOutfit"
	/// An outfit will be created from your avatar's current appearance.
	/// English String: "An outfit will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£Ââ€¹Ã£â€šâ€°Ã¤Â½Å“Ã¦Ë†ÂÃ£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Description.RenameCostume"
	/// Choose a new name for your costume.
	/// English String: "Choose a new name for your costume."
	/// </summary>
	public override string DescriptionRenameCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ®Ã¦â€“Â°Ã£Ââ€”Ã£Ââ€žÃ¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã©ÂÂ¸Ã£â€šâ€œÃ£ÂÂ§Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Description.RenameOutfit"
	/// Choose a new name for your outfit.
	/// English String: "Choose a new name for your outfit."
	/// </summary>
	public override string DescriptionRenameOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ®Ã¦â€“Â°Ã£Ââ€”Ã£Ââ€žÃ¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã©ÂÂ¸Ã£â€šâ€œÃ£ÂÂ§Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Heading.Accessories"
	/// English String: "Accessories"
	/// </summary>
	public override string HeadingAccessories => "Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";

	/// <summary>
	/// Key: "Heading.AccessoriesChange"
	/// English String: "Accessories Change"
	/// </summary>
	public override string HeadingAccessoriesChange => "Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’ÂªÃ¥Â¤â€°Ã¦â€ºÂ´";

	/// <summary>
	/// Key: "Heading.AdvancedOptions"
	/// English String: "Advanced Options"
	/// </summary>
	public override string HeadingAdvancedOptions => "Ã¨Â©Â³Ã§Â´Â°Ã£â€šÂªÃ£Æ’â€”Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Heading.All"
	/// All avatar modification types
	/// English String: "All"
	/// </summary>
	public override string HeadingAll => "Ã£Ââ„¢Ã£ÂÂ¹Ã£ÂÂ¦";

	/// <summary>
	/// Key: "Heading.Animations"
	/// English String: "Animations"
	/// </summary>
	public override string HeadingAnimations => "Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Heading.Appearance"
	/// English String: "Appearance"
	/// </summary>
	public override string HeadingAppearance => "Ã¥Â¤â€“Ã¨Â¦â€¹";

	/// <summary>
	/// Key: "Heading.AvatarPageTitle"
	/// Page title for the Avatar page. On this page, the user can modify how they look.
	/// English String: "Avatar Editor"
	/// </summary>
	public override string HeadingAvatarPageTitle => "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£â€šÂ¨Ã£Æ’â€¡Ã£â€šÂ£Ã£â€šÂ¿";

	/// <summary>
	/// Key: "Heading.Body"
	/// English String: "Body"
	/// </summary>
	public override string HeadingBody => "Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£";

	/// <summary>
	/// Key: "Heading.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string HeadingBodyParts => "Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£Ã£Æ’â€˜Ã£Æ’Â¼Ã£Æ’â€ž";

	/// <summary>
	/// Key: "Heading.Clothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingClothing => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";

	/// <summary>
	/// Key: "Heading.Costumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Costumes"
	/// </summary>
	public override string HeadingCostumes => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";

	/// <summary>
	/// Key: "Heading.CreateNewCostume"
	/// NOTE: Costume is a more whimsical word choice for outfit. Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Create New Costume"
	/// </summary>
	public override string HeadingCreateNewCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¦â€“Â°Ã¨Â¦ÂÃ¤Â½Å“Ã¦Ë†ÂÃ£Ââ„¢Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Heading.CreateNewOutfit"
	/// English String: "Create New Outfit"
	/// </summary>
	public override string HeadingCreateNewOutfit => "Ã¦â€“Â°Ã£Ââ€”Ã£Ââ€žÃ¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¤Â½Å“Ã¦Ë†ÂÃ£Ââ„¢Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Heading.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string HeadingDelete => "Ã¥â€°Å Ã©â„¢Â¤";

	/// <summary>
	/// Key: "Heading.DeleteCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Delete Costume"
	/// </summary>
	public override string HeadingDeleteCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ®Ã¥â€°Å Ã©â„¢Â¤";

	/// <summary>
	/// Key: "Heading.DeleteOutfit"
	/// English String: "Delete Outfit"
	/// </summary>
	public override string HeadingDeleteOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ®Ã¥â€°Å Ã©â„¢Â¤";

	/// <summary>
	/// Key: "Heading.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string HeadingEmotes => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†";

	/// <summary>
	/// Key: "Heading.EquipEmotes"
	/// English String: "Equip Emotes"
	/// </summary>
	public override string HeadingEquipEmotes => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢";

	/// <summary>
	/// Key: "Heading.Outfits"
	/// English String: "Outfits"
	/// </summary>
	public override string HeadingOutfits => "Ã¦Å“ÂÃ¨Â£â€¦";

	/// <summary>
	/// Key: "Heading.Packages"
	/// English String: "Packages"
	/// </summary>
	public override string HeadingPackages => "Ã£Æ’â€˜Ã£Æ’Æ’Ã£â€šÂ±Ã£Æ’Â¼Ã£â€šÂ¸";

	/// <summary>
	/// Key: "Heading.Recent"
	/// English String: "Recent"
	/// </summary>
	public override string HeadingRecent => "Ã¦Å“â‚¬Ã¨Â¿â€˜";

	/// <summary>
	/// Key: "Heading.Recommended"
	/// See recommended clothing for your avatar
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommended => "Ã£ÂÅ Ã£Ââ„¢Ã£Ââ„¢Ã£â€šÂ";

	/// <summary>
	/// Key: "Heading.RenameCostume"
	/// English String: "Rename Costume"
	/// </summary>
	public override string HeadingRenameCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´";

	/// <summary>
	/// Key: "Heading.RenameOutfit"
	/// English String: "Rename Outfit"
	/// </summary>
	public override string HeadingRenameOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ„¢Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Heading.Scaling"
	/// English String: "Scaling"
	/// </summary>
	public override string HeadingScaling => "Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«Ã£Ââ„¢Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Heading.SkinToneBodyParts"
	/// English String: "Skin Tone by Body Parts"
	/// </summary>
	public override string HeadingSkinToneBodyParts => "Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£Ã£Æ’â€˜Ã£Æ’Â¼Ã£Æ’â€žÃ£Ââ€Ã£ÂÂ¨Ã£ÂÂ®Ã£â€šÂ¹Ã£â€šÂ­Ã£Æ’Â³Ã£ÂÂ®Ã£Æ’Ë†Ã£Æ’Â¼Ã£Æ’Â³";

	/// <summary>
	/// Key: "Heading.Update"
	/// English String: "Update"
	/// </summary>
	public override string HeadingUpdate => "Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†";

	/// <summary>
	/// Key: "Heading.UpdateCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Update Costume"
	/// </summary>
	public override string HeadingUpdateCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ®Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†";

	/// <summary>
	/// Key: "Heading.UpdateOutfit"
	/// English String: "Update Outfit"
	/// </summary>
	public override string HeadingUpdateOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ®Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†";

	/// <summary>
	/// Key: "Label.All"
	/// All body parts. This label will allow for body parts to change color
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Ã£Ââ„¢Ã£ÂÂ¹Ã£ÂÂ¦";

	/// <summary>
	/// Key: "Label.AskIfLoadingCorrectly"
	/// Avatar isn't loading correctly?
	/// English String: "Avatar isn't loading correctly?"
	/// </summary>
	public override string LabelAskIfLoadingCorrectly => "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÅ’Ã¦Â­Â£Ã¥Â¸Â¸Ã£ÂÂ«Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£ÂÂ¾Ã£â€šÅ’Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Label.AssetIDPlaceholder"
	/// This refers to the Asset ID which is a technical word for the Identification Number of an item or asset.
	/// English String: "Asset ID"
	/// </summary>
	public override string LabelAssetIDPlaceholder => "Ã£â€šÂ¢Ã£â€šÂ»Ã£Æ’Æ’Ã£Æ’Ë†ID";

	/// <summary>
	/// Key: "Label.Back"
	/// English String: "Back"
	/// </summary>
	public override string LabelBack => "Ã¨Æ’Å’Ã©ÂÂ¢";

	/// <summary>
	/// Key: "Label.BackAccessories"
	/// English String: "Back Accessories"
	/// </summary>
	public override string LabelBackAccessories => "Ã¨Æ’Å’Ã©ÂÂ¢Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";

	/// <summary>
	/// Key: "Label.BodyType"
	/// English String: "Body Type"
	/// </summary>
	public override string LabelBodyType => "Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£Ã£â€šÂ¿Ã£â€šÂ¤Ã£Æ’â€”";

	/// <summary>
	/// Key: "Label.Climb"
	/// English String: "Climb"
	/// </summary>
	public override string LabelClimb => "Ã§â„¢Â»Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Label.ClimbAnimations"
	/// English String: "Climb Animations"
	/// </summary>
	public override string LabelClimbAnimations => "Ã§â„¢Â»Ã£â€šâ€¹Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Label.Clothes"
	/// English String: "Clothes"
	/// </summary>
	public override string LabelClothes => "Ã¦Â´â€¹Ã¦Å“Â";

	/// <summary>
	/// Key: "Label.Costume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Costume"
	/// </summary>
	public override string LabelCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";

	/// <summary>
	/// Key: "label.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string labelEmotes => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†";

	/// <summary>
	/// Key: "Label.Equip"
	/// English String: "Equip"
	/// </summary>
	public override string LabelEquip => "Ã¨Â£â€¦Ã¥â€šâ„¢";

	/// <summary>
	/// Key: "Label.ExploreCatalog"
	/// This text entices users to shop for more things to wear on their avatar
	/// English String: "Explore the catalog to find more clothes!"
	/// </summary>
	public override string LabelExploreCatalog => "Ã£â€šÂ«Ã£â€šÂ¿Ã£Æ’Â­Ã£â€šÂ°Ã£â€šâ€™Ã£Æ’ÂÃ£â€šÂ§Ã£Æ’Æ’Ã£â€šÂ¯Ã£Ââ€”Ã£ÂÂ¦Ã£â‚¬ÂÃ¦Â´â€¹Ã¦Å“ÂÃ£â€šâ€™Ã¨Â¦â€¹Ã£ÂÂ¤Ã£Ââ€˜Ã£â€šË†Ã£Ââ€ Ã¯Â¼Â";

	/// <summary>
	/// Key: "Label.Face"
	/// English String: "Face"
	/// </summary>
	public override string LabelFace => "Ã©Â¡â€";

	/// <summary>
	/// Key: "Label.FaceAccessories"
	/// English String: "Face Accessories"
	/// </summary>
	public override string LabelFaceAccessories => "Ã©Â¡â€Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";

	/// <summary>
	/// Key: "Label.Faces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "Ã©Â¡â€";

	/// <summary>
	/// Key: "Label.Fall"
	/// English String: "Fall"
	/// </summary>
	public override string LabelFall => "Ã¨ÂÂ½Ã¤Â¸â€¹";

	/// <summary>
	/// Key: "Label.FallAnimations"
	/// English String: "Fall Animations"
	/// </summary>
	public override string LabelFallAnimations => "Ã¨ÂÂ½Ã¤Â¸â€¹Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Label.Free"
	/// Text label for recommended items
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "Ã§â€žÂ¡Ã¦â€“â„¢";

	/// <summary>
	/// Key: "Label.Front"
	/// English String: "Front"
	/// </summary>
	public override string LabelFront => "Ã¦Â­Â£Ã©ÂÂ¢";

	/// <summary>
	/// Key: "Label.FrontAccessories"
	/// English String: "Front Accessories"
	/// </summary>
	public override string LabelFrontAccessories => "Ã¦Â­Â£Ã©ÂÂ¢Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";

	/// <summary>
	/// Key: "Label.Gear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "Ã£â€šÂ®Ã£â€šÂ¢";

	/// <summary>
	/// Key: "Label.Hair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelHair => "Ã©Â«Âª";

	/// <summary>
	/// Key: "Label.HairAccessories"
	/// English String: "Hair Accessories"
	/// </summary>
	public override string LabelHairAccessories => "Ã©Â«ÂªÃ§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";

	/// <summary>
	/// Key: "Label.Hat"
	/// English String: "Hat"
	/// </summary>
	public override string LabelHat => "Ã¥Â¸Â½Ã¥Â­Â";

	/// <summary>
	/// Key: "Label.HatAccessories"
	/// English String: "Hat Accessories"
	/// </summary>
	public override string LabelHatAccessories => "Ã¥Â¸Â½Ã¥Â­ÂÃ§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";

	/// <summary>
	/// Key: "Label.Head"
	/// English String: "Head"
	/// </summary>
	public override string LabelHead => "Ã©Â Â­";

	/// <summary>
	/// Key: "Label.Heads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "Ã©Â Â­";

	/// <summary>
	/// Key: "Label.Height"
	/// English String: "Height"
	/// </summary>
	public override string LabelHeight => "Ã¨ÂºÂ«Ã©â€¢Â·";

	/// <summary>
	/// Key: "Label.Idle"
	/// English String: "Idle"
	/// </summary>
	public override string LabelIdle => "Ã¥Â¾â€¦Ã¦Â©Å¸";

	/// <summary>
	/// Key: "Label.IdleAnimations"
	/// English String: "Idle Animations"
	/// </summary>
	public override string LabelIdleAnimations => "Ã¥Â¾â€¦Ã¦Â©Å¸Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Label.Jump"
	/// English String: "Jump"
	/// </summary>
	public override string LabelJump => "Ã£â€šÂ¸Ã£Æ’Â£Ã£Æ’Â³Ã£Æ’â€”";

	/// <summary>
	/// Key: "Label.JumpAnimations"
	/// English String: "Jump Animations"
	/// </summary>
	public override string LabelJumpAnimations => "Ã£â€šÂ¸Ã£Æ’Â£Ã£Æ’Â³Ã£Æ’â€”Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Label.LeftArm"
	/// English String: "Left Arm"
	/// </summary>
	public override string LabelLeftArm => "Ã¥Â·Â¦Ã¨â€¦â€¢";

	/// <summary>
	/// Key: "Label.LeftArms"
	/// English String: "Left Arms"
	/// </summary>
	public override string LabelLeftArms => "Ã¥Â·Â¦Ã¨â€¦â€¢";

	/// <summary>
	/// Key: "Label.LeftLeg"
	/// English String: "Left Leg"
	/// </summary>
	public override string LabelLeftLeg => "Ã¥Â·Â¦Ã¨â€žÅ¡";

	/// <summary>
	/// Key: "Label.LeftLegs"
	/// English String: "Left Legs"
	/// </summary>
	public override string LabelLeftLegs => "Ã¥Â·Â¦Ã¨â€žÅ¡";

	/// <summary>
	/// Key: "Label.MyCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "My Costumes"
	/// </summary>
	public override string LabelMyCostumes => "Ã£Æ’Å¾Ã£â€šÂ¤Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";

	/// <summary>
	/// Key: "Label.NamePlaceholderCostume"
	/// English String: "Name your costume"
	/// </summary>
	public override string LabelNamePlaceholderCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ«Ã¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã¤Â»ËœÃ£Ââ€˜Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Label.NamePlaceholderOutfit"
	/// English String: "Name your outfit"
	/// </summary>
	public override string LabelNamePlaceholderOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ«Ã¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã¤Â»ËœÃ£Ââ€˜Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Label.Neck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelNeck => "Ã©Â¦â€“";

	/// <summary>
	/// Key: "Label.NeckAccessories"
	/// English String: "Neck Accessories"
	/// </summary>
	public override string LabelNeckAccessories => "Ã©Â¦â€“Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";

	/// <summary>
	/// Key: "Label.NoResellers"
	/// Text label for recommended items
	/// English String: "No resellers"
	/// </summary>
	public override string LabelNoResellers => "Ã¥â€ ÂÃ¨Â²Â©Ã¨â‚¬â€¦Ã£ÂÂªÃ£Ââ€”";

	/// <summary>
	/// Key: "Label.OffSale"
	/// Text label for recommended items
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "Ã©ÂÅ¾Ã¥Â£Â²Ã¥â€œÂ";

	/// <summary>
	/// Key: "Label.Outfit"
	/// English String: "Outfit"
	/// </summary>
	public override string LabelOutfit => "Ã¦Å“ÂÃ¨Â£â€¦";

	/// <summary>
	/// Key: "Label.Pants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "Ã£Æ’â€˜Ã£Æ’Â³Ã£Æ’â€ž";

	/// <summary>
	/// Key: "Label.Parts"
	/// English String: "Parts"
	/// </summary>
	public override string LabelParts => "Ã£Æ’â€˜Ã£Æ’Â¼Ã£Æ’â€ž";

	/// <summary>
	/// Key: "Label.PresetCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Preset Costumes"
	/// </summary>
	public override string LabelPresetCostumes => "Ã£Æ’â€”Ã£Æ’ÂªÃ£â€šÂ»Ã£Æ’Æ’Ã£Æ’Ë†Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";

	/// <summary>
	/// Key: "Label.Proportions"
	/// English String: "Proportions"
	/// </summary>
	public override string LabelProportions => "Ã£Æ’â€”Ã£Æ’Â­Ã£Æ’ÂÃ£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Label.RedrawUnavailable"
	/// Avatar redraw is unavailable
	/// English String: "Avatar redraw is unavailable."
	/// </summary>
	public override string LabelRedrawUnavailable => "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã£Æ’ÂªÃ£Æ’â€°Ã£Æ’Â­Ã£Æ’Â¼Ã£ÂÂ¯Ã¥Ë†Â©Ã§â€Â¨Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Label.RightArm"
	/// English String: "Right Arm"
	/// </summary>
	public override string LabelRightArm => "Ã¥ÂÂ³Ã¨â€¦â€¢";

	/// <summary>
	/// Key: "Label.RightArms"
	/// English String: "Right Arms"
	/// </summary>
	public override string LabelRightArms => "Ã¥ÂÂ³Ã¨â€¦â€¢";

	/// <summary>
	/// Key: "Label.RightLeg"
	/// English String: "Right Leg"
	/// </summary>
	public override string LabelRightLeg => "Ã¥ÂÂ³Ã¨â€žÅ¡";

	/// <summary>
	/// Key: "Label.RightLegs"
	/// English String: "Right Legs"
	/// </summary>
	public override string LabelRightLegs => "Ã¥ÂÂ³Ã¨â€žÅ¡";

	/// <summary>
	/// Key: "Label.Run"
	/// English String: "Run"
	/// </summary>
	public override string LabelRun => "Ã¨ÂµÂ°Ã£â€šâ€¹";

	/// <summary>
	/// Key: "Label.RunAnimations"
	/// English String: "Run Animations"
	/// </summary>
	public override string LabelRunAnimations => "Ã¨ÂµÂ°Ã£â€šâ€¹Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Label.Scale"
	/// English String: "Scale"
	/// </summary>
	public override string LabelScale => "Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«";

	/// <summary>
	/// Key: "Label.Shirts"
	/// English String: "Shirts"
	/// </summary>
	public override string LabelShirts => "Ã£â€šÂ·Ã£Æ’Â£Ã£Æ’â€ž";

	/// <summary>
	/// Key: "Label.ShoulderAccessories"
	/// English String: "Shoulder Accessories"
	/// </summary>
	public override string LabelShoulderAccessories => "Ã¨â€šÂ©Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";

	/// <summary>
	/// Key: "Label.Shoulders"
	/// English String: "Shoulders"
	/// </summary>
	public override string LabelShoulders => "Ã¨â€šÂ©";

	/// <summary>
	/// Key: "Label.SkinTone"
	/// English String: "Skin Tone"
	/// </summary>
	public override string LabelSkinTone => "Ã£â€šÂ¹Ã£â€šÂ­Ã£Æ’Â³Ã£ÂÂ®Ã£Æ’Ë†Ã£Æ’Â¼Ã£Æ’Â³";

	/// <summary>
	/// Key: "Label.Swim"
	/// English String: "Swim"
	/// </summary>
	public override string LabelSwim => "Ã¦Â³Â³Ã£ÂÂ";

	/// <summary>
	/// Key: "Label.SwimAnimations"
	/// English String: "Swim Animations"
	/// </summary>
	public override string LabelSwimAnimations => "Ã¦Â³Â³Ã£ÂÂÃ£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Label.SwitchAvatarType"
	/// User is able to increase the number of joints in their avatar from 6 to 15. R15 moves better. See http://roblox.wikia.com/wiki/R15
	/// English String: "Switch between classic R6 avatar and more expressive next generation R15 avatar"
	/// </summary>
	public override string LabelSwitchAvatarType => "Ã£â€šÂ¯Ã£Æ’Â©Ã£â€šÂ·Ã£Æ’Æ’Ã£â€šÂ¯R6Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£Ââ€¹Ã£â€šâ€°Ã¦Â¬Â¡Ã¤Â¸â€“Ã¤Â»Â£Ã£ÂÂ®R15Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ¾Ã£ÂÂ§Ã£â‚¬ÂÃ¨â€¡ÂªÃ§â€Â±Ã£ÂÂ«Ã¥Ë†â€¡Ã£â€šÅ Ã¦â€ºÂ¿Ã£ÂË†Ã£â€šË†Ã£Ââ€ Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Label.Torso"
	/// English String: "Torso"
	/// </summary>
	public override string LabelTorso => "Ã¨Æ’Â´Ã¤Â½â€œ";

	/// <summary>
	/// Key: "Label.Torsos"
	/// English String: "Torsos"
	/// </summary>
	public override string LabelTorsos => "Ã¨Æ’Â´Ã¤Â½â€œ";

	/// <summary>
	/// Key: "Label.TShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "TÃ£â€šÂ·Ã£Æ’Â£Ã£Æ’â€ž";

	/// <summary>
	/// Key: "Label.Waist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelWaist => "Ã¨â€¦Â°";

	/// <summary>
	/// Key: "Label.WaistAccessories"
	/// English String: "Waist Accessories"
	/// </summary>
	public override string LabelWaistAccessories => "Ã¨â€¦Â°Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";

	/// <summary>
	/// Key: "Label.Walk"
	/// English String: "Walk"
	/// </summary>
	public override string LabelWalk => "Ã¦Â­Â©Ã£ÂÂ";

	/// <summary>
	/// Key: "Label.WalkAnimations"
	/// English String: "Walk Animations"
	/// </summary>
	public override string LabelWalkAnimations => "Ã¦Â­Â©Ã£ÂÂÃ£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";

	/// <summary>
	/// Key: "Label.Width"
	/// English String: "Width"
	/// </summary>
	public override string LabelWidth => "Ã¦Â¨ÂªÃ¥Â¹â€¦";

	/// <summary>
	/// Key: "Label.YourEmotes"
	/// English String: "Your Emotes"
	/// </summary>
	public override string LabelYourEmotes => "Ã¨â€¡ÂªÃ¥Ë†â€ Ã£ÂÂ®Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†";

	/// <summary>
	/// Key: "Message.AccessoriesChange"
	/// English String: "Are you sure you want to override your current look?"
	/// </summary>
	public override string MessageAccessoriesChange => "Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£â€šâ€™Ã¤Â¸Å Ã¦â€ºÂ¸Ã£ÂÂÃ£Ââ€”Ã£ÂÂ¦Ã£â€šË†Ã£â€šÂÃ£Ââ€”Ã£Ââ€žÃ£ÂÂ§Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸";

	/// <summary>
	/// Key: "Message.ChooseEmote"
	/// English String: "Choose an Emote"
	/// </summary>
	public override string MessageChooseEmote => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã©ÂÂ¸Ã£ÂÂ¶";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlot"
	/// English String: "Choose a slot"
	/// </summary>
	public override string MessageChooseEmoteSlot => "Ã£â€šÂ¹Ã£Æ’Â­Ã£Æ’Æ’Ã£Æ’Ë†Ã£â€šâ€™Ã©ÂÂ¸Ã£ÂÂ¶";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlotOrEmote"
	/// English String: "Choose a slot or an Emote"
	/// </summary>
	public override string MessageChooseEmoteSlotOrEmote => "Ã£â€šÂ¹Ã£Æ’Â­Ã£Æ’Æ’Ã£Æ’Ë†Ã£Ââ€¹Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã©ÂÂ¸Ã£ÂÂ¶";

	/// <summary>
	/// Key: "Message.DefaultClothing"
	/// Encourage user to choose their own clothes.
	/// English String: "Default clothing has been applied to your avatar - wear something from your clothing."
	/// </summary>
	public override string MessageDefaultClothing => "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ«Ã£Æ’â€¡Ã£Æ’â€¢Ã£â€šÂ©Ã£Æ’Â«Ã£Æ’Ë†Ã£ÂÂ®Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã©ÂÂ©Ã§â€Â¨Ã£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂ¾Ã£Ââ„¢ - Ã¦Å’ÂÃ£ÂÂ£Ã£ÂÂ¦Ã£Ââ€žÃ£â€šâ€¹Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂ¿Ã£ÂÂ¾Ã£Ââ€”Ã£â€šâ€¡Ã£Ââ€ Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.DeleteThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Are you sure you want to delete this costume?"
	/// </summary>
	public override string MessageDeleteThisCostume => "Ã£Ââ€œÃ£ÂÂ®Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¦Ã£â€šË†Ã£â€šÂÃ£Ââ€”Ã£Ââ€žÃ£ÂÂ§Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸";

	/// <summary>
	/// Key: "Message.DeleteThisOutfit"
	/// English String: "Are you sure you want to delete this outfit?"
	/// </summary>
	public override string MessageDeleteThisOutfit => "Ã£Ââ€œÃ£ÂÂ®Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¦Ã£â€šË†Ã£â€šÂÃ£Ââ€”Ã£Ââ€žÃ£ÂÂ§Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸";

	/// <summary>
	/// Key: "Message.EmotesInstructions"
	/// The instructions describe the navigation flow within the Avatar Editor to equip an emote.
	/// English String: "Go to \"Animations\" &gt; \"Emotes\" &gt; \"Equip Emotes\" to equip an emote."
	/// </summary>
	public override string MessageEmotesInstructions => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã£ÂÂ¤Ã£Ââ€˜Ã£â€šâ€¹Ã£ÂÂ«Ã£ÂÂ¯Ã£â‚¬Â Ã£â‚¬Å’Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³Ã£â‚¬Â > Ã£â‚¬Å’Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â‚¬Â> Ã£â‚¬Å’Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£â‚¬Â Ã£ÂÂ¸Ã¨Â¡Å’Ã£ÂÂ£Ã£ÂÂ¦Ã¤Â¸â€¹Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.EmptyAssetList"
	/// User is seeing no assets on this page because they don't have any.
	/// English String: "You don't have any."
	/// </summary>
	public override string MessageEmptyAssetList => "Ã¦Å’ÂÃ£ÂÂ£Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.EmptyListOfCostumes"
	/// The user is viewing an empty list of costumes to choose from. The application tells the user that they can create an costume.
	/// English String: "You don't have any costumes. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfCostumes => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¤Â½Å“Ã£ÂÂ£Ã£ÂÂ¦Ã£ÂÂ¿Ã£ÂÂ¾Ã£Ââ€”Ã£â€šâ€¡Ã£Ââ€ Ã¯Â¼Â";

	/// <summary>
	/// Key: "Message.EmptyListOfOutfits"
	/// The user is viewing an empty list of outfits to choose from. The application tells the user that they can create an outfit.
	/// English String: "You don't have any outfits. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfOutfits => "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¤Â½Å“Ã£ÂÂ£Ã£ÂÂ¦Ã£ÂÂ¿Ã£ÂÂ¾Ã£Ââ€”Ã£â€šâ€¡Ã£Ââ€ Ã¯Â¼Â";

	/// <summary>
	/// Key: "Message.EmptyRecentItems"
	/// English String: "You don't have any recent items."
	/// </summary>
	public override string MessageEmptyRecentItems => "Ã¦Å“â‚¬Ã¨Â¿â€˜Ã£ÂÂ®Ã£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorCreateCostume"
	/// English String: "Unable to create costume, try again later."
	/// </summary>
	public override string MessageErrorCreateCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¤Â½Å“Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorCreateOutfit"
	/// English String: "Unable to create outfit, try again later."
	/// </summary>
	public override string MessageErrorCreateOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¤Â½Å“Ã¦Ë†ÂÃ£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageErrorDeleteEmote => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorEquipEmote"
	/// English String: "Failed to equip emote, please try again later."
	/// </summary>
	public override string MessageErrorEquipEmote => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorLoadCostume"
	/// English String: "Failed to load costume."
	/// </summary>
	public override string MessageErrorLoadCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorLoadEmotes"
	/// English String: "Failed to load emotes."
	/// </summary>
	public override string MessageErrorLoadEmotes => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorLoadOutfits"
	/// English String: "Failed to load outfits."
	/// </summary>
	public override string MessageErrorLoadOutfits => "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorOutfitName"
	/// English String: "Name can contain letters, numbers, and spaces."
	/// </summary>
	public override string MessageErrorOutfitName => "Ã¥ÂÂÃ¥â€°ÂÃ£ÂÂ«Ã¤Â½Â¿Ã§â€Â¨Ã£ÂÂ§Ã£ÂÂÃ£â€šâ€¹Ã£ÂÂ®Ã£ÂÂ¯Ã£â‚¬ÂÃ¥Â¤Â§Ã¥Â°ÂÃ£â€šÂ¢Ã£Æ’Â«Ã£Æ’â€¢Ã£â€šÂ¡Ã£Æ’â„¢Ã£Æ’Æ’Ã£Æ’Ë†Ã£â‚¬ÂÃ¥ÂÅ Ã¨Â§â€™Ã¨â€¹Â±Ã¦â€¢Â°Ã¥Â­â€”Ã£â‚¬ÂÃ£ÂÅ Ã£â€šË†Ã£ÂÂ³Ã£â€šÂ¹Ã£Æ’Å¡Ã£Æ’Â¼Ã£â€šÂ¹Ã£ÂÂ Ã£Ââ€˜Ã£ÂÂ§Ã£Ââ„¢Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorRenameCostume"
	/// English String: "Failed to rename costume."
	/// </summary>
	public override string MessageErrorRenameCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorRenameOutfit"
	/// English String: "Failed to rename outfit."
	/// </summary>
	public override string MessageErrorRenameOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorUnequipEmote"
	/// English String: "Failed to unequip emote."
	/// </summary>
	public override string MessageErrorUnequipEmote => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¥Â¤â€“Ã£Ââ€ºÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorUpdateCostume"
	/// English String: "Costume update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorUpdateEmote"
	/// English String: "Updating emote slot failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateEmote => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šÂ¹Ã£Æ’Â­Ã£Æ’Æ’Ã£Æ’Ë†Ã£ÂÂ®Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÅ’Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorUpdateOutfit"
	/// English String: "Outfit update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorUpdateWorn"
	/// There was an error updating items that the user is already wearing.
	/// English String: "Error while updating worn items."
	/// </summary>
	public override string MessageErrorUpdateWorn => "Ã¨Â£â€¦Ã¥â€šâ„¢Ã¤Â¸Â­Ã£ÂÂ®Ã£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã£â€šâ€™Ã¦â€ºÂ´Ã¦â€“Â°Ã¤Â¸Â­Ã£ÂÂ«Ã£â€šÂ¨Ã£Æ’Â©Ã£Æ’Â¼Ã£ÂÅ’Ã§â„¢ÂºÃ§â€Å¸Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorWearCostume"
	/// English String: "Failed to wear costume."
	/// </summary>
	public override string MessageErrorWearCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ErrorWearOutfit"
	/// English String: "Failed to wear outfit."
	/// </summary>
	public override string MessageErrorWearOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedDeleteCostume"
	/// English String: "Failed to delete costume."
	/// </summary>
	public override string MessageFailedDeleteCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageFailedDeleteEmote => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedDeleteOutfit"
	/// English String: "Failed to delete outfit."
	/// </summary>
	public override string MessageFailedDeleteOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedLoadAssets"
	/// English String: "Failed to load assets list."
	/// </summary>
	public override string MessageFailedLoadAssets => "Ã£â€šÂ¢Ã£â€šÂ»Ã£Æ’Æ’Ã£Æ’Ë†Ã£Æ’ÂªÃ£â€šÂ¹Ã£Æ’Ë†Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedLoadRecent"
	/// English String: "Failed to load recent items."
	/// </summary>
	public override string MessageFailedLoadRecent => "Ã¦Å“â‚¬Ã¨Â¿â€˜Ã£ÂÂ®Ã£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedUpdateBodyColor"
	/// English String: "Failed to update skin tone."
	/// </summary>
	public override string MessageFailedUpdateBodyColor => "Ã£â€šÂ¹Ã£â€šÂ­Ã£Æ’Â³Ã£ÂÂ®Ã£Æ’Ë†Ã£Æ’Â¼Ã£Æ’Â³Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedCostume"
	/// The user tried to update a deleted costume.
	/// English String: "The costume you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedCostume => "Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£â€šË†Ã£Ââ€ Ã£ÂÂ¨Ã£Ââ€”Ã£ÂÂ¦Ã£Ââ€žÃ£â€šâ€¹Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šâ€šÃ£Ââ€ Ã¥Â­ËœÃ¥Å“Â¨Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedOutfit"
	/// The user tried to update a deleted outfit.
	/// English String: "The outfit you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedOutfit => "Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£â€šË†Ã£Ââ€ Ã£ÂÂ¨Ã£Ââ€”Ã£ÂÂ¦Ã£Ââ€žÃ£â€šâ€¹Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šâ€šÃ£Ââ€ Ã¥Â­ËœÃ¥Å“Â¨Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedUpdateScales"
	/// English String: "Failed to update scales."
	/// </summary>
	public override string MessageFailedUpdateScales => "Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedUpdateType"
	/// Failed to update the way the user's avatar is rendered.
	/// English String: "Failed to update avatar type."
	/// </summary>
	public override string MessageFailedUpdateType => "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£â€šÂ¿Ã£â€šÂ¤Ã£Æ’â€”Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.FailedWearPackage"
	/// English String: "Failed to wear package."
	/// </summary>
	public override string MessageFailedWearPackage => "Ã£Æ’â€˜Ã£Æ’Æ’Ã£â€šÂ±Ã£Æ’Â¼Ã£â€šÂ¸Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.HatLimitTooltip"
	/// English String: "You can wear up to 3 hats"
	/// </summary>
	public override string MessageHatLimitTooltip => "Ã¥Â¸Â½Ã¥Â­ÂÃ£ÂÂ¯3Ã£ÂÂ¤Ã£ÂÂ¾Ã£ÂÂ§Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ„¢";

	/// <summary>
	/// Key: "Message.InvalidOutfitName"
	/// English String: "Name must be appropriate and less than 200 characters."
	/// </summary>
	public override string MessageInvalidOutfitName => "Ã¥ÂÂÃ¥â€°ÂÃ£ÂÂ¯Ã£â‚¬ÂÃ¤Â¸ÂÃ©ÂÂ©Ã¥Ë†â€¡Ã£ÂÂªÃ¨Â¨â‚¬Ã¨â€˜â€°Ã£ÂÅ’Ã¤Â½Â¿Ã§â€Â¨Ã£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¦Ã£ÂÅ Ã£â€šâ€°Ã£ÂÅ¡Ã£â‚¬Â200Ã¦â€“â€¡Ã¥Â­â€”Ã¦Å“ÂªÃ¦Âºâ‚¬Ã£ÂÂ§Ã£Ââ€šÃ£â€šâ€¹Ã¥Â¿â€¦Ã¨Â¦ÂÃ£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.Loading"
	/// The user's avatar is loading
	/// English String: "Loading..."
	/// </summary>
	public override string MessageLoading => "Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£ÂÂ¿Ã¤Â¸Â­...";

	/// <summary>
	/// Key: "Message.PageUnavailable"
	/// English String: "The avatar page is temporarily unavailable."
	/// </summary>
	public override string MessagePageUnavailable => "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£Æ’Å¡Ã£Æ’Â¼Ã£â€šÂ¸Ã£ÂÂ¯Ã§ÂÂ¾Ã¥Å“Â¨Ã¥Ë†Â©Ã§â€Â¨Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.PresetCostumesDelay"
	/// One-time message that appears to the user first time they visit the Preset Costumes tab. The delay is caused by initial migration.
	/// English String: "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!"
	/// </summary>
	public override string MessagePresetCostumesDelay => "Ã£Ââ€Ã¦Â³Â¨Ã¦â€žÂ: Ã§ÂÂ¾Ã¥Å“Â¨Ã£Æ’ÂÃ£â€šÂ¦Ã£â€šÂ¹Ã£â€šÂ­Ã£Æ’Â¼Ã£Æ’â€Ã£Æ’Â³Ã£â€šÂ°Ã¤Â½Å“Ã¦Â¥Â­Ã£â€šâ€™Ã¨Â¡Å’Ã£ÂÂ£Ã£ÂÂ¦Ã£Ââ€žÃ£â€šâ€¹Ã£ÂÅ¸Ã£â€šÂÃ£â‚¬ÂÃ£Ââ„¢Ã£ÂÂ¹Ã£ÂÂ¦Ã£ÂÂ®Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã¨Â¡Â¨Ã§Â¤ÂºÃ£Ââ€¢Ã£â€šÅ’Ã£â€šâ€¹Ã£ÂÂ¾Ã£ÂÂ§Ã¦â€¢Â°Ã¥Ë†â€ Ã£Ââ€¹Ã£Ââ€¹Ã£â€šâ€¹Ã¥Â Â´Ã¥ÂË†Ã£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€šÃ£Ââ€”Ã£ÂÂ°Ã£â€šâ€°Ã£ÂÂÃ£Ââ€”Ã£ÂÂ¦Ã£Ââ€¹Ã£â€šâ€°Ã£Æ’ÂÃ£â€šÂ§Ã£Æ’Æ’Ã£â€šÂ¯Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂ¿Ã£ÂÂ¦Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ¯Â¼Â";

	/// <summary>
	/// Key: "Message.ReachedMaxCostumes"
	/// English String: "You have reached the maximum number of costumes."
	/// </summary>
	public override string MessageReachedMaxCostumes => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã¦Å“â‚¬Ã¥Â¤Â§Ã¦â€¢Â°Ã£ÂÂ«Ã¥Ë†Â°Ã©Ââ€Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.ReachedMaxOutfits"
	/// English String: "You have reached the maximum number of outfits."
	/// </summary>
	public override string MessageReachedMaxOutfits => "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ®Ã¦Å“â‚¬Ã¥Â¤Â§Ã¦â€¢Â°Ã£ÂÂ«Ã¥Ë†Â°Ã©Ââ€Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.RedirectAvatarSettings"
	/// English String: "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home &gt; Game Settings &gt; Avatar"
	/// </summary>
	public override string MessageRedirectAvatarSettings => "Roblox StudioÃ£ÂÂ®Ã£Æ’â€”Ã£Æ’Â­Ã£â€šÂ¸Ã£â€šÂ§Ã£â€šÂ¯Ã£Æ’Ë†Ã£Ââ€¹Ã£â€šâ€°Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã¨Â¨Â­Ã¥Â®Å¡Ã£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€šÃ£â‚¬Å’Ã£Æ’â€ºÃ£Æ’Â¼Ã£Æ’Â Ã£â‚¬Â>Ã£â‚¬Å’Ã£â€šÂ²Ã£Æ’Â¼Ã£Æ’Â Ã¨Â¨Â­Ã¥Â®Å¡Ã£â‚¬Â>Ã£â‚¬Å’Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£â‚¬ÂÃ£ÂÂ«Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂ¹Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€ž";

	/// <summary>
	/// Key: "Message.RedrawFloodchecked"
	/// English String: "You have redrawn your avatar too many times, please try again later."
	/// </summary>
	public override string MessageRedrawFloodchecked => "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã£Æ’ÂªÃ£Æ’â€°Ã£Æ’Â­Ã£Æ’Â¼Ã¥â€ºÅ¾Ã¦â€¢Â°Ã£ÂÅ’Ã¥Â¤Å¡Ã£Ââ„¢Ã£ÂÅ½Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.RedrawThumbnailFailed"
	/// English String: "Failed to redraw thumbnail."
	/// </summary>
	public override string MessageRedrawThumbnailFailed => "Ã£â€šÂµÃ£Æ’Â Ã£Æ’ÂÃ£â€šÂ¤Ã£Æ’Â«Ã£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";

	/// <summary>
	/// Key: "Message.SelectEnableScaling"
	/// R15 is a proper noun
	/// English String: "Select R15 to enable scaling."
	/// </summary>
	public override string MessageSelectEnableScaling => "Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«Ã£â€šâ€™Ã¦Å“â€°Ã¥Å Â¹Ã£ÂÂ«Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ«Ã£ÂÂ¯Ã£â‚¬ÂR15Ã£â€šâ€™Ã©ÂÂ¸Ã¦Å Å¾Ã£Ââ€”Ã£â€šË†Ã£Ââ€ Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "Ã¦Ë†ÂÃ¥Å Å¸";

	/// <summary>
	/// Key: "Message.SuccessCreateCostume"
	/// English String: "Created costume"
	/// </summary>
	public override string MessageSuccessCreateCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¤Â½Å“Ã¦Ë†ÂÃ£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessCreateOutfit"
	/// English String: "Created outfit"
	/// </summary>
	public override string MessageSuccessCreateOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¤Â½Å“Ã¦Ë†ÂÃ£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessDeleteCostume"
	/// Deleted costume
	/// English String: "Deleted costume"
	/// </summary>
	public override string MessageSuccessDeleteCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessDeleteOutfit"
	/// English String: "Deleted outfit"
	/// </summary>
	public override string MessageSuccessDeleteOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessEquipEmote"
	/// English String: "Equipped Emote"
	/// </summary>
	public override string MessageSuccessEquipEmote => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessRenameCostume"
	/// English String: "Renamed costume"
	/// </summary>
	public override string MessageSuccessRenameCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessRenameOutfit"
	/// English String: "Renamed outfit"
	/// </summary>
	public override string MessageSuccessRenameOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessSavedAccessories"
	/// English String: "Saved accessories"
	/// </summary>
	public override string MessageSuccessSavedAccessories => "Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’ÂªÃ£â€šâ€™Ã¤Â¿ÂÃ¥Â­ËœÃ£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessUnequipEmote"
	/// English String: "Unequipped emote"
	/// </summary>
	public override string MessageSuccessUnequipEmote => "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¥Â¤â€“Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.SuccessUpdatedCostume"
	/// English String: "Updated costume"
	/// </summary>
	public override string MessageSuccessUpdatedCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessUpdatedOutfit"
	/// English String: "Updated outfit"
	/// </summary>
	public override string MessageSuccessUpdatedOutfit => "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessWoreCostume"
	/// English String: "Successfully wore costume"
	/// </summary>
	public override string MessageSuccessWoreCostume => "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã£ÂÂ¤Ã£Ââ€˜Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.SuccessWoreOutfit"
	/// English String: "Successfully wore outfit"
	/// </summary>
	public override string MessageSuccessWoreOutfit => "Ã¦Å“ÂÃ£â€šâ€™Ã£ÂÂ¤Ã£Ââ€˜Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";

	/// <summary>
	/// Key: "Message.UpdateThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisCostume => "Ã£Ââ€œÃ£ÂÂ®Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ¨Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£ÂÂ§Ã¤Â¸Å Ã¦â€ºÂ¸Ã£ÂÂÃ£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.UpdateThisOutfit"
	/// English String: "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisOutfit => "Ã£Ââ€œÃ£ÂÂ®Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ¨Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÅ’Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£ÂÂ§Ã¤Â¸Å Ã¦â€ºÂ¸Ã£ÂÂÃ£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";

	/// <summary>
	/// Key: "Message.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string MessageWarning => "Ã¨Â­Â¦Ã¥â€˜Å ";

	public AvatarResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvanced()
	{
		return "Ã¨Â©Â³Ã§Â´Â°";
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Ã¨Â²Â·Ã£Ââ€ ";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Ã£â€šÂ­Ã£Æ’Â£Ã£Æ’Â³Ã£â€šÂ»Ã£Æ’Â«";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Ã©â€“â€°Ã£ÂËœÃ£â€šâ€¹";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "Ã¤Â½Å“Ã¦Ë†Â";
	}

	protected override string _GetTemplateForActionCreateNewOutfit()
	{
		return "Ã¤Â½Å“Ã¦Ë†Â";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Ã¥â€°Å Ã©â„¢Â¤";
	}

	protected override string _GetTemplateForActionDone()
	{
		return "Ã¥Â®Å’Ã¤Âºâ€ ";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "Ã£â€šÂ²Ã£Æ’Æ’Ã£Æ’Ë†Ã£Ââ„¢Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "Ã£Ââ€¢Ã£â€šâ€°Ã£ÂÂ«Ã£â€šÂ²Ã£Æ’Æ’Ã£Æ’Ë†";
	}

	protected override string _GetTemplateForActionOpenRobloxApp()
	{
		return "RobloxÃ£â€šÂ¢Ã£Æ’â€”Ã£Æ’ÂªÃ£â€šâ€™Ã¨ÂµÂ·Ã¥â€¹â€¢Ã£Ââ„¢Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForActionRedraw()
	{
		return "Ã£Æ’ÂªÃ£Æ’â€°Ã£Æ’Â­Ã£Æ’Â¼Ã£Ââ„¢Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForActionRename()
	{
		return "Ã¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ„¢Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForActionRenameOutfit()
	{
		return "Ã¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ„¢Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Ã¤Â¿ÂÃ¥Â­Ëœ";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ã£Ââ„¢Ã£ÂÂ¹Ã£ÂÂ¦Ã¨Â¦â€¹Ã£â€šâ€¹";
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
		return "Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†";
	}

	protected override string _GetTemplateForActionUserUnderstands()
	{
		return "OK";
	}

	protected override string _GetTemplateForDescriptionAvatarEditorUpsell()
	{
		return "Ã¥Â¤â€“Ã¨Â¦â€¹Ã£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ«Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šÂ¢Ã£Æ’â€”Ã£Æ’ÂªÃ£ÂÂ®Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£â€šÂ¨Ã£Æ’â€¡Ã£â€šÂ£Ã£â€šÂ¿Ã£â€šâ€™Ã¤Â½Â¿Ã§â€Â¨Ã£Ââ„¢Ã£â€šâ€¹Ã¥Â¿â€¦Ã¨Â¦ÂÃ£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForDescriptionCreateNewCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£Ââ€¹Ã£â€šâ€°Ã¤Â½Å“Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForDescriptionCreateNewOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£Ââ€¹Ã£â€šâ€°Ã¤Â½Å“Ã¦Ë†ÂÃ£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForDescriptionRenameCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ®Ã¦â€“Â°Ã£Ââ€”Ã£Ââ€žÃ¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã©ÂÂ¸Ã£â€šâ€œÃ£ÂÂ§Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForDescriptionRenameOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ®Ã¦â€“Â°Ã£Ââ€”Ã£Ââ€žÃ¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã©ÂÂ¸Ã£â€šâ€œÃ£ÂÂ§Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForHeadingAccessories()
	{
		return "Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";
	}

	protected override string _GetTemplateForHeadingAccessoriesChange()
	{
		return "Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’ÂªÃ¥Â¤â€°Ã¦â€ºÂ´";
	}

	protected override string _GetTemplateForHeadingAdvancedOptions()
	{
		return "Ã¨Â©Â³Ã§Â´Â°Ã£â€šÂªÃ£Æ’â€”Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForHeadingAll()
	{
		return "Ã£Ââ„¢Ã£ÂÂ¹Ã£ÂÂ¦";
	}

	protected override string _GetTemplateForHeadingAnimations()
	{
		return "Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForHeadingAppearance()
	{
		return "Ã¥Â¤â€“Ã¨Â¦â€¹";
	}

	protected override string _GetTemplateForHeadingAvatarPageTitle()
	{
		return "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£â€šÂ¨Ã£Æ’â€¡Ã£â€šÂ£Ã£â€šÂ¿";
	}

	protected override string _GetTemplateForHeadingBody()
	{
		return "Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£";
	}

	protected override string _GetTemplateForHeadingBodyParts()
	{
		return "Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£Ã£Æ’â€˜Ã£Æ’Â¼Ã£Æ’â€ž";
	}

	protected override string _GetTemplateForHeadingClothing()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";
	}

	protected override string _GetTemplateForHeadingCostumes()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";
	}

	protected override string _GetTemplateForHeadingCreateNewCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¦â€“Â°Ã¨Â¦ÂÃ¤Â½Å“Ã¦Ë†ÂÃ£Ââ„¢Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForHeadingCreateNewOutfit()
	{
		return "Ã¦â€“Â°Ã£Ââ€”Ã£Ââ€žÃ¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¤Â½Å“Ã¦Ë†ÂÃ£Ââ„¢Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForHeadingDelete()
	{
		return "Ã¥â€°Å Ã©â„¢Â¤";
	}

	protected override string _GetTemplateForHeadingDeleteCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ®Ã¥â€°Å Ã©â„¢Â¤";
	}

	protected override string _GetTemplateForHeadingDeleteOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ®Ã¥â€°Å Ã©â„¢Â¤";
	}

	protected override string _GetTemplateForHeadingEmotes()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†";
	}

	protected override string _GetTemplateForHeadingEquipEmotes()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢";
	}

	protected override string _GetTemplateForHeadingOutfits()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦";
	}

	protected override string _GetTemplateForHeadingPackages()
	{
		return "Ã£Æ’â€˜Ã£Æ’Æ’Ã£â€šÂ±Ã£Æ’Â¼Ã£â€šÂ¸";
	}

	protected override string _GetTemplateForHeadingRecent()
	{
		return "Ã¦Å“â‚¬Ã¨Â¿â€˜";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "Ã£ÂÅ Ã£Ââ„¢Ã£Ââ„¢Ã£â€šÂ";
	}

	protected override string _GetTemplateForHeadingRenameCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´";
	}

	protected override string _GetTemplateForHeadingRenameOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ„¢Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForHeadingScaling()
	{
		return "Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«Ã£Ââ„¢Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForHeadingSkinToneBodyParts()
	{
		return "Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£Ã£Æ’â€˜Ã£Æ’Â¼Ã£Æ’â€žÃ£Ââ€Ã£ÂÂ¨Ã£ÂÂ®Ã£â€šÂ¹Ã£â€šÂ­Ã£Æ’Â³Ã£ÂÂ®Ã£Æ’Ë†Ã£Æ’Â¼Ã£Æ’Â³";
	}

	protected override string _GetTemplateForHeadingUpdate()
	{
		return "Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†";
	}

	protected override string _GetTemplateForHeadingUpdateCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ®Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†";
	}

	protected override string _GetTemplateForHeadingUpdateOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ®Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Ã£Ââ„¢Ã£ÂÂ¹Ã£ÂÂ¦";
	}

	protected override string _GetTemplateForLabelAskIfLoadingCorrectly()
	{
		return "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÅ’Ã¦Â­Â£Ã¥Â¸Â¸Ã£ÂÂ«Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£ÂÂ¾Ã£â€šÅ’Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForLabelAssetIDPlaceholder()
	{
		return "Ã£â€šÂ¢Ã£â€šÂ»Ã£Æ’Æ’Ã£Æ’Ë†ID";
	}

	protected override string _GetTemplateForLabelBack()
	{
		return "Ã¨Æ’Å’Ã©ÂÂ¢";
	}

	protected override string _GetTemplateForLabelBackAccessories()
	{
		return "Ã¨Æ’Å’Ã©ÂÂ¢Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";
	}

	protected override string _GetTemplateForLabelBodyType()
	{
		return "Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£Ã£â€šÂ¿Ã£â€šÂ¤Ã£Æ’â€”";
	}

	protected override string _GetTemplateForLabelClimb()
	{
		return "Ã§â„¢Â»Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForLabelClimbAnimations()
	{
		return "Ã§â„¢Â»Ã£â€šâ€¹Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForLabelClothes()
	{
		return "Ã¦Â´â€¹Ã¦Å“Â";
	}

	protected override string _GetTemplateForLabelCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";
	}

	/// <summary>
	/// Key: "Label.DirectionsForPackagePlacement"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}"
	/// </summary>
	public override string LabelDirectionsForPackagePlacement(string startBold, string rightArrow, string endBold)
	{
		return $"Ã£Æ’â€˜Ã£Æ’Æ’Ã£â€šÂ±Ã£Æ’Â¼Ã£â€šÂ¸Ã£ÂÂ¯Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ«Ã§Â§Â»Ã¥â€¹â€¢Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š{startBold}Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â {rightArrow}Ã£Æ’â€”Ã£Æ’ÂªÃ£â€šÂ»Ã£Æ’Æ’Ã£Æ’Ë†Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â {endBold}Ã£â€šâ€™Ã£Æ’ÂÃ£â€šÂ§Ã£Æ’Æ’Ã£â€šÂ¯Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€ž";
	}

	protected override string _GetTemplateForLabelDirectionsForPackagePlacement()
	{
		return "Ã£Æ’â€˜Ã£Æ’Æ’Ã£â€šÂ±Ã£Æ’Â¼Ã£â€šÂ¸Ã£ÂÂ¯Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ«Ã§Â§Â»Ã¥â€¹â€¢Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š{startBold}Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â {rightArrow}Ã£Æ’â€”Ã£Æ’ÂªÃ£â€šÂ»Ã£Æ’Æ’Ã£Æ’Ë†Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â {endBold}Ã£â€šâ€™Ã£Æ’ÂÃ£â€šÂ§Ã£Æ’Æ’Ã£â€šÂ¯Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€ž";
	}

	/// <summary>
	/// Key: "Label.DirectionsForScalingOptions"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}"
	/// </summary>
	public override string LabelDirectionsForScalingOptions(string startBold, string rightArrow, string endBold)
	{
		return $"Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«Ã£â€šÂªÃ£Æ’â€”Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³Ã£ÂÂ¯Ã£â‚¬ÂÃ£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£Ã£ÂÂ®Ã£â€šÂ«Ã£Æ’â€ Ã£â€šÂ´Ã£Æ’ÂªÃ£ÂÂ§Ã¤Â½Â¿Ã§â€Â¨Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š{startBold}Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£{rightArrow}Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«{endBold}Ã£ÂÂ§Ã£Æ’ÂÃ£â€šÂ§Ã£Æ’Æ’Ã£â€šÂ¯Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForLabelDirectionsForScalingOptions()
	{
		return "Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«Ã£â€šÂªÃ£Æ’â€”Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³Ã£ÂÂ¯Ã£â‚¬ÂÃ£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£Ã£ÂÂ®Ã£â€šÂ«Ã£Æ’â€ Ã£â€šÂ´Ã£Æ’ÂªÃ£ÂÂ§Ã¤Â½Â¿Ã§â€Â¨Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š{startBold}Ã£Æ’Å“Ã£Æ’â€¡Ã£â€šÂ£{rightArrow}Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«{endBold}Ã£ÂÂ§Ã£Æ’ÂÃ£â€šÂ§Ã£Æ’Æ’Ã£â€šÂ¯Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForlabelEmotes()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†";
	}

	protected override string _GetTemplateForLabelEquip()
	{
		return "Ã¨Â£â€¦Ã¥â€šâ„¢";
	}

	protected override string _GetTemplateForLabelExploreCatalog()
	{
		return "Ã£â€šÂ«Ã£â€šÂ¿Ã£Æ’Â­Ã£â€šÂ°Ã£â€šâ€™Ã£Æ’ÂÃ£â€šÂ§Ã£Æ’Æ’Ã£â€šÂ¯Ã£Ââ€”Ã£ÂÂ¦Ã£â‚¬ÂÃ¦Â´â€¹Ã¦Å“ÂÃ£â€šâ€™Ã¨Â¦â€¹Ã£ÂÂ¤Ã£Ââ€˜Ã£â€šË†Ã£Ââ€ Ã¯Â¼Â";
	}

	protected override string _GetTemplateForLabelFace()
	{
		return "Ã©Â¡â€";
	}

	protected override string _GetTemplateForLabelFaceAccessories()
	{
		return "Ã©Â¡â€Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "Ã©Â¡â€";
	}

	protected override string _GetTemplateForLabelFall()
	{
		return "Ã¨ÂÂ½Ã¤Â¸â€¹";
	}

	protected override string _GetTemplateForLabelFallAnimations()
	{
		return "Ã¨ÂÂ½Ã¤Â¸â€¹Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "Ã§â€žÂ¡Ã¦â€“â„¢";
	}

	protected override string _GetTemplateForLabelFront()
	{
		return "Ã¦Â­Â£Ã©ÂÂ¢";
	}

	protected override string _GetTemplateForLabelFrontAccessories()
	{
		return "Ã¦Â­Â£Ã©ÂÂ¢Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "Ã£â€šÂ®Ã£â€šÂ¢";
	}

	protected override string _GetTemplateForLabelHair()
	{
		return "Ã©Â«Âª";
	}

	protected override string _GetTemplateForLabelHairAccessories()
	{
		return "Ã©Â«ÂªÃ§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";
	}

	protected override string _GetTemplateForLabelHat()
	{
		return "Ã¥Â¸Â½Ã¥Â­Â";
	}

	protected override string _GetTemplateForLabelHatAccessories()
	{
		return "Ã¥Â¸Â½Ã¥Â­ÂÃ§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";
	}

	protected override string _GetTemplateForLabelHead()
	{
		return "Ã©Â Â­";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "Ã©Â Â­";
	}

	protected override string _GetTemplateForLabelHeight()
	{
		return "Ã¨ÂºÂ«Ã©â€¢Â·";
	}

	protected override string _GetTemplateForLabelIdle()
	{
		return "Ã¥Â¾â€¦Ã¦Â©Å¸";
	}

	protected override string _GetTemplateForLabelIdleAnimations()
	{
		return "Ã¥Â¾â€¦Ã¦Â©Å¸Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForLabelJump()
	{
		return "Ã£â€šÂ¸Ã£Æ’Â£Ã£Æ’Â³Ã£Æ’â€”";
	}

	protected override string _GetTemplateForLabelJumpAnimations()
	{
		return "Ã£â€šÂ¸Ã£Æ’Â£Ã£Æ’Â³Ã£Æ’â€”Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForLabelLeftArm()
	{
		return "Ã¥Â·Â¦Ã¨â€¦â€¢";
	}

	protected override string _GetTemplateForLabelLeftArms()
	{
		return "Ã¥Â·Â¦Ã¨â€¦â€¢";
	}

	protected override string _GetTemplateForLabelLeftLeg()
	{
		return "Ã¥Â·Â¦Ã¨â€žÅ¡";
	}

	protected override string _GetTemplateForLabelLeftLegs()
	{
		return "Ã¥Â·Â¦Ã¨â€žÅ¡";
	}

	protected override string _GetTemplateForLabelMyCostumes()
	{
		return "Ã£Æ’Å¾Ã£â€šÂ¤Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";
	}

	protected override string _GetTemplateForLabelNamePlaceholderCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ«Ã¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã¤Â»ËœÃ£Ââ€˜Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForLabelNamePlaceholderOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ«Ã¥ÂÂÃ¥â€°ÂÃ£â€šâ€™Ã¤Â»ËœÃ£Ââ€˜Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForLabelNeck()
	{
		return "Ã©Â¦â€“";
	}

	protected override string _GetTemplateForLabelNeckAccessories()
	{
		return "Ã©Â¦â€“Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "Ã¥â€ ÂÃ¨Â²Â©Ã¨â‚¬â€¦Ã£ÂÂªÃ£Ââ€”";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "Ã©ÂÅ¾Ã¥Â£Â²Ã¥â€œÂ";
	}

	protected override string _GetTemplateForLabelOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "Ã£Æ’â€˜Ã£Æ’Â³Ã£Æ’â€ž";
	}

	protected override string _GetTemplateForLabelParts()
	{
		return "Ã£Æ’â€˜Ã£Æ’Â¼Ã£Æ’â€ž";
	}

	protected override string _GetTemplateForLabelPresetCostumes()
	{
		return "Ã£Æ’â€”Ã£Æ’ÂªÃ£â€šÂ»Ã£Æ’Æ’Ã£Æ’Ë†Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â ";
	}

	protected override string _GetTemplateForLabelProportions()
	{
		return "Ã£Æ’â€”Ã£Æ’Â­Ã£Æ’ÂÃ£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForLabelRedrawUnavailable()
	{
		return "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã£Æ’ÂªÃ£Æ’â€°Ã£Æ’Â­Ã£Æ’Â¼Ã£ÂÂ¯Ã¥Ë†Â©Ã§â€Â¨Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForLabelRightArm()
	{
		return "Ã¥ÂÂ³Ã¨â€¦â€¢";
	}

	protected override string _GetTemplateForLabelRightArms()
	{
		return "Ã¥ÂÂ³Ã¨â€¦â€¢";
	}

	protected override string _GetTemplateForLabelRightLeg()
	{
		return "Ã¥ÂÂ³Ã¨â€žÅ¡";
	}

	protected override string _GetTemplateForLabelRightLegs()
	{
		return "Ã¥ÂÂ³Ã¨â€žÅ¡";
	}

	protected override string _GetTemplateForLabelRun()
	{
		return "Ã¨ÂµÂ°Ã£â€šâ€¹";
	}

	protected override string _GetTemplateForLabelRunAnimations()
	{
		return "Ã¨ÂµÂ°Ã£â€šâ€¹Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForLabelScale()
	{
		return "Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«";
	}

	protected override string _GetTemplateForLabelShirts()
	{
		return "Ã£â€šÂ·Ã£Æ’Â£Ã£Æ’â€ž";
	}

	protected override string _GetTemplateForLabelShoulderAccessories()
	{
		return "Ã¨â€šÂ©Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";
	}

	protected override string _GetTemplateForLabelShoulders()
	{
		return "Ã¨â€šÂ©";
	}

	protected override string _GetTemplateForLabelSkinTone()
	{
		return "Ã£â€šÂ¹Ã£â€šÂ­Ã£Æ’Â³Ã£ÂÂ®Ã£Æ’Ë†Ã£Æ’Â¼Ã£Æ’Â³";
	}

	protected override string _GetTemplateForLabelSwim()
	{
		return "Ã¦Â³Â³Ã£ÂÂ";
	}

	protected override string _GetTemplateForLabelSwimAnimations()
	{
		return "Ã¦Â³Â³Ã£ÂÂÃ£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForLabelSwitchAvatarType()
	{
		return "Ã£â€šÂ¯Ã£Æ’Â©Ã£â€šÂ·Ã£Æ’Æ’Ã£â€šÂ¯R6Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£Ââ€¹Ã£â€šâ€°Ã¦Â¬Â¡Ã¤Â¸â€“Ã¤Â»Â£Ã£ÂÂ®R15Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ¾Ã£ÂÂ§Ã£â‚¬ÂÃ¨â€¡ÂªÃ§â€Â±Ã£ÂÂ«Ã¥Ë†â€¡Ã£â€šÅ Ã¦â€ºÂ¿Ã£ÂË†Ã£â€šË†Ã£Ââ€ Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForLabelTorso()
	{
		return "Ã¨Æ’Â´Ã¤Â½â€œ";
	}

	protected override string _GetTemplateForLabelTorsos()
	{
		return "Ã¨Æ’Â´Ã¤Â½â€œ";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "TÃ£â€šÂ·Ã£Æ’Â£Ã£Æ’â€ž";
	}

	protected override string _GetTemplateForLabelWaist()
	{
		return "Ã¨â€¦Â°";
	}

	protected override string _GetTemplateForLabelWaistAccessories()
	{
		return "Ã¨â€¦Â°Ã§â€Â¨Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’Âª";
	}

	protected override string _GetTemplateForLabelWalk()
	{
		return "Ã¦Â­Â©Ã£ÂÂ";
	}

	protected override string _GetTemplateForLabelWalkAnimations()
	{
		return "Ã¦Â­Â©Ã£ÂÂÃ£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³";
	}

	protected override string _GetTemplateForLabelWidth()
	{
		return "Ã¦Â¨ÂªÃ¥Â¹â€¦";
	}

	protected override string _GetTemplateForLabelYourEmotes()
	{
		return "Ã¨â€¡ÂªÃ¥Ë†â€ Ã£ÂÂ®Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†";
	}

	protected override string _GetTemplateForMessageAccessoriesChange()
	{
		return "Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£â€šâ€™Ã¤Â¸Å Ã¦â€ºÂ¸Ã£ÂÂÃ£Ââ€”Ã£ÂÂ¦Ã£â€šË†Ã£â€šÂÃ£Ââ€”Ã£Ââ€žÃ£ÂÂ§Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸";
	}

	protected override string _GetTemplateForMessageChooseEmote()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã©ÂÂ¸Ã£ÂÂ¶";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlot()
	{
		return "Ã£â€šÂ¹Ã£Æ’Â­Ã£Æ’Æ’Ã£Æ’Ë†Ã£â€šâ€™Ã©ÂÂ¸Ã£ÂÂ¶";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlotOrEmote()
	{
		return "Ã£â€šÂ¹Ã£Æ’Â­Ã£Æ’Æ’Ã£Æ’Ë†Ã£Ââ€¹Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã©ÂÂ¸Ã£ÂÂ¶";
	}

	protected override string _GetTemplateForMessageDefaultClothing()
	{
		return "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ«Ã£Æ’â€¡Ã£Æ’â€¢Ã£â€šÂ©Ã£Æ’Â«Ã£Æ’Ë†Ã£ÂÂ®Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã©ÂÂ©Ã§â€Â¨Ã£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂ¾Ã£Ââ„¢ - Ã¦Å’ÂÃ£ÂÂ£Ã£ÂÂ¦Ã£Ââ€žÃ£â€šâ€¹Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂ¿Ã£ÂÂ¾Ã£Ââ€”Ã£â€šâ€¡Ã£Ââ€ Ã£â‚¬â€š";
	}

	/// <summary>
	/// Key: "Message.DeleteOutfit"
	/// English String: "Are you sure you want to delete this {outfitType}?"
	/// </summary>
	public override string MessageDeleteOutfit(string outfitType)
	{
		return $"Ã£Ââ€œÃ£ÂÂ®{outfitType}Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¦Ã£â€šË†Ã£â€šÂÃ£Ââ€”Ã£Ââ€žÃ£ÂÂ§Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸";
	}

	protected override string _GetTemplateForMessageDeleteOutfit()
	{
		return "Ã£Ââ€œÃ£ÂÂ®{outfitType}Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¦Ã£â€šË†Ã£â€šÂÃ£Ââ€”Ã£Ââ€žÃ£ÂÂ§Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸";
	}

	protected override string _GetTemplateForMessageDeleteThisCostume()
	{
		return "Ã£Ââ€œÃ£ÂÂ®Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¦Ã£â€šË†Ã£â€šÂÃ£Ââ€”Ã£Ââ€žÃ£ÂÂ§Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸";
	}

	protected override string _GetTemplateForMessageDeleteThisOutfit()
	{
		return "Ã£Ââ€œÃ£ÂÂ®Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¦Ã£â€šË†Ã£â€šÂÃ£Ââ€”Ã£Ââ€žÃ£ÂÂ§Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸";
	}

	protected override string _GetTemplateForMessageEmotesInstructions()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã£ÂÂ¤Ã£Ââ€˜Ã£â€šâ€¹Ã£ÂÂ«Ã£ÂÂ¯Ã£â‚¬Â Ã£â‚¬Å’Ã£â€šÂ¢Ã£Æ’â€¹Ã£Æ’Â¡Ã£Æ’Â¼Ã£â€šÂ·Ã£Æ’Â§Ã£Æ’Â³Ã£â‚¬Â > Ã£â‚¬Å’Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â‚¬Â> Ã£â‚¬Å’Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£â‚¬Â Ã£ÂÂ¸Ã¨Â¡Å’Ã£ÂÂ£Ã£ÂÂ¦Ã¤Â¸â€¹Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageEmptyAssetList()
	{
		return "Ã¦Å’ÂÃ£ÂÂ£Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";
	}

	/// <summary>
	/// Key: "Message.EmptyListForItem"
	/// The user tries to load a list of some item but they see nothing because they don't own anything of that type.
	/// English String: "You don't have this item: {itemType}"
	/// </summary>
	public override string MessageEmptyListForItem(string itemType)
	{
		return $"Ã£Ââ€œÃ£ÂÂ®Ã£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã£â€šâ€™Ã¦Å’ÂÃ£ÂÂ£Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œ: {itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListForItem()
	{
		return "Ã£Ââ€œÃ£ÂÂ®Ã£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã£â€šâ€™Ã¦Å’ÂÃ£ÂÂ£Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œ: {itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListOfCostumes()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¤Â½Å“Ã£ÂÂ£Ã£ÂÂ¦Ã£ÂÂ¿Ã£ÂÂ¾Ã£Ââ€”Ã£â€šâ€¡Ã£Ââ€ Ã¯Â¼Â";
	}

	protected override string _GetTemplateForMessageEmptyListOfOutfits()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¤Â½Å“Ã£ÂÂ£Ã£ÂÂ¦Ã£ÂÂ¿Ã£ÂÂ¾Ã£Ââ€”Ã£â€šâ€¡Ã£Ââ€ Ã¯Â¼Â";
	}

	protected override string _GetTemplateForMessageEmptyRecentItems()
	{
		return "Ã¦Å“â‚¬Ã¨Â¿â€˜Ã£ÂÂ®Ã£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorCreateCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¤Â½Å“Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorCreateOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¤Â½Å“Ã¦Ë†ÂÃ£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorDeleteEmote()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorEquipEmote()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorLoadCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorLoadEmotes()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorLoadOutfits()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorOutfitName()
	{
		return "Ã¥ÂÂÃ¥â€°ÂÃ£ÂÂ«Ã¤Â½Â¿Ã§â€Â¨Ã£ÂÂ§Ã£ÂÂÃ£â€šâ€¹Ã£ÂÂ®Ã£ÂÂ¯Ã£â‚¬ÂÃ¥Â¤Â§Ã¥Â°ÂÃ£â€šÂ¢Ã£Æ’Â«Ã£Æ’â€¢Ã£â€šÂ¡Ã£Æ’â„¢Ã£Æ’Æ’Ã£Æ’Ë†Ã£â‚¬ÂÃ¥ÂÅ Ã¨Â§â€™Ã¨â€¹Â±Ã¦â€¢Â°Ã¥Â­â€”Ã£â‚¬ÂÃ£ÂÅ Ã£â€šË†Ã£ÂÂ³Ã£â€šÂ¹Ã£Æ’Å¡Ã£Æ’Â¼Ã£â€šÂ¹Ã£ÂÂ Ã£Ââ€˜Ã£ÂÂ§Ã£Ââ„¢Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorRenameCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorRenameOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorUnequipEmote()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¥Â¤â€“Ã£Ââ€ºÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorUpdateCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorUpdateEmote()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šÂ¹Ã£Æ’Â­Ã£Æ’Æ’Ã£Æ’Ë†Ã£ÂÂ®Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÅ’Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorUpdateOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorUpdateWorn()
	{
		return "Ã¨Â£â€¦Ã¥â€šâ„¢Ã¤Â¸Â­Ã£ÂÂ®Ã£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã£â€šâ€™Ã¦â€ºÂ´Ã¦â€“Â°Ã¤Â¸Â­Ã£ÂÂ«Ã£â€šÂ¨Ã£Æ’Â©Ã£Æ’Â¼Ã£ÂÅ’Ã§â„¢ÂºÃ§â€Å¸Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorWearCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageErrorWearOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedDeleteCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedDeleteEmote()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedDeleteOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedLoadAssets()
	{
		return "Ã£â€šÂ¢Ã£â€šÂ»Ã£Æ’Æ’Ã£Æ’Ë†Ã£Æ’ÂªÃ£â€šÂ¹Ã£Æ’Ë†Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedLoadRecent()
	{
		return "Ã¦Å“â‚¬Ã¨Â¿â€˜Ã£ÂÂ®Ã£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã£â€šâ€™Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£â€šÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedUpdateBodyColor()
	{
		return "Ã£â€šÂ¹Ã£â€šÂ­Ã£Æ’Â³Ã£ÂÂ®Ã£Æ’Ë†Ã£Æ’Â¼Ã£Æ’Â³Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedCostume()
	{
		return "Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£â€šË†Ã£Ââ€ Ã£ÂÂ¨Ã£Ââ€”Ã£ÂÂ¦Ã£Ââ€žÃ£â€šâ€¹Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šâ€šÃ£Ââ€ Ã¥Â­ËœÃ¥Å“Â¨Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedOutfit()
	{
		return "Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£â€šË†Ã£Ââ€ Ã£ÂÂ¨Ã£Ââ€”Ã£ÂÂ¦Ã£Ââ€žÃ£â€šâ€¹Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ¯Ã£â‚¬ÂÃ£â€šâ€šÃ£Ââ€ Ã¥Â­ËœÃ¥Å“Â¨Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedUpdateScales()
	{
		return "Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedUpdateType()
	{
		return "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£â€šÂ¿Ã£â€šÂ¤Ã£Æ’â€”Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageFailedWearPackage()
	{
		return "Ã£Æ’â€˜Ã£Æ’Æ’Ã£â€šÂ±Ã£Æ’Â¼Ã£â€šÂ¸Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£ÂÂ§Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageHatLimitTooltip()
	{
		return "Ã¥Â¸Â½Ã¥Â­ÂÃ£ÂÂ¯3Ã£ÂÂ¤Ã£ÂÂ¾Ã£ÂÂ§Ã¨Â£â€¦Ã¥â€šâ„¢Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ„¢";
	}

	protected override string _GetTemplateForMessageInvalidOutfitName()
	{
		return "Ã¥ÂÂÃ¥â€°ÂÃ£ÂÂ¯Ã£â‚¬ÂÃ¤Â¸ÂÃ©ÂÂ©Ã¥Ë†â€¡Ã£ÂÂªÃ¨Â¨â‚¬Ã¨â€˜â€°Ã£ÂÅ’Ã¤Â½Â¿Ã§â€Â¨Ã£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¦Ã£ÂÅ Ã£â€šâ€°Ã£ÂÅ¡Ã£â‚¬Â200Ã¦â€“â€¡Ã¥Â­â€”Ã¦Å“ÂªÃ¦Âºâ‚¬Ã£ÂÂ§Ã£Ââ€šÃ£â€šâ€¹Ã¥Â¿â€¦Ã¨Â¦ÂÃ£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "Ã¨ÂªÂ­Ã£ÂÂ¿Ã¨Â¾Â¼Ã£ÂÂ¿Ã¤Â¸Â­...";
	}

	/// <summary>
	/// Key: "Message.MissingItemsFromOutfit"
	/// User cannot wear an outfit because they are missing or have deleted some of the items that were part of that outfit.
	/// English String: "Number of items that you don't own in this outfit: {number}"
	/// </summary>
	public override string MessageMissingItemsFromOutfit(string number)
	{
		return $"Ã£Ââ€œÃ£ÂÂ®Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ§Ã¦â€°â‚¬Ã¦Å“â€°Ã£Ââ€”Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂªÃ£Ââ€žÃ£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã¦â€¢Â°: {number}";
	}

	protected override string _GetTemplateForMessageMissingItemsFromOutfit()
	{
		return "Ã£Ââ€œÃ£ÂÂ®Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ§Ã¦â€°â‚¬Ã¦Å“â€°Ã£Ââ€”Ã£ÂÂ¦Ã£Ââ€žÃ£ÂÂªÃ£Ââ€žÃ£â€šÂ¢Ã£â€šÂ¤Ã£Æ’â€ Ã£Æ’Â Ã¦â€¢Â°: {number}";
	}

	protected override string _GetTemplateForMessagePageUnavailable()
	{
		return "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£Æ’Å¡Ã£Æ’Â¼Ã£â€šÂ¸Ã£ÂÂ¯Ã§ÂÂ¾Ã¥Å“Â¨Ã¥Ë†Â©Ã§â€Â¨Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessagePresetCostumesDelay()
	{
		return "Ã£Ââ€Ã¦Â³Â¨Ã¦â€žÂ: Ã§ÂÂ¾Ã¥Å“Â¨Ã£Æ’ÂÃ£â€šÂ¦Ã£â€šÂ¹Ã£â€šÂ­Ã£Æ’Â¼Ã£Æ’â€Ã£Æ’Â³Ã£â€šÂ°Ã¤Â½Å“Ã¦Â¥Â­Ã£â€šâ€™Ã¨Â¡Å’Ã£ÂÂ£Ã£ÂÂ¦Ã£Ââ€žÃ£â€šâ€¹Ã£ÂÅ¸Ã£â€šÂÃ£â‚¬ÂÃ£Ââ„¢Ã£ÂÂ¹Ã£ÂÂ¦Ã£ÂÂ®Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã¨Â¡Â¨Ã§Â¤ÂºÃ£Ââ€¢Ã£â€šÅ’Ã£â€šâ€¹Ã£ÂÂ¾Ã£ÂÂ§Ã¦â€¢Â°Ã¥Ë†â€ Ã£Ââ€¹Ã£Ââ€¹Ã£â€šâ€¹Ã¥Â Â´Ã¥ÂË†Ã£ÂÅ’Ã£Ââ€šÃ£â€šÅ Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€šÃ£Ââ€”Ã£ÂÂ°Ã£â€šâ€°Ã£ÂÂÃ£Ââ€”Ã£ÂÂ¦Ã£Ââ€¹Ã£â€šâ€°Ã£Æ’ÂÃ£â€šÂ§Ã£Æ’Æ’Ã£â€šÂ¯Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂ¿Ã£ÂÂ¦Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ¯Â¼Â";
	}

	protected override string _GetTemplateForMessageReachedMaxCostumes()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã¦Å“â‚¬Ã¥Â¤Â§Ã¦â€¢Â°Ã£ÂÂ«Ã¥Ë†Â°Ã©Ââ€Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageReachedMaxOutfits()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÂ®Ã¦Å“â‚¬Ã¥Â¤Â§Ã¦â€¢Â°Ã£ÂÂ«Ã¥Ë†Â°Ã©Ââ€Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageRedirectAvatarSettings()
	{
		return "Roblox StudioÃ£ÂÂ®Ã£Æ’â€”Ã£Æ’Â­Ã£â€šÂ¸Ã£â€šÂ§Ã£â€šÂ¯Ã£Æ’Ë†Ã£Ââ€¹Ã£â€šâ€°Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã¨Â¨Â­Ã¥Â®Å¡Ã£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€šÃ£â‚¬Å’Ã£Æ’â€ºÃ£Æ’Â¼Ã£Æ’Â Ã£â‚¬Â>Ã£â‚¬Å’Ã£â€šÂ²Ã£Æ’Â¼Ã£Æ’Â Ã¨Â¨Â­Ã¥Â®Å¡Ã£â‚¬Â>Ã£â‚¬Å’Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£â‚¬ÂÃ£ÂÂ«Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂ¹Ã£Ââ€”Ã£ÂÂ¦Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€ž";
	}

	protected override string _GetTemplateForMessageRedrawFloodchecked()
	{
		return "Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã£Æ’ÂªÃ£Æ’â€°Ã£Æ’Â­Ã£Æ’Â¼Ã¥â€ºÅ¾Ã¦â€¢Â°Ã£ÂÅ’Ã¥Â¤Å¡Ã£Ââ„¢Ã£ÂÅ½Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€šÃ¥Â¾Å’Ã£ÂÂ§Ã£â€šâ€šÃ£Ââ€ Ã¤Â¸â‚¬Ã¥ÂºÂ¦Ã£ÂÅ Ã¨Â©Â¦Ã£Ââ€”Ã£ÂÂÃ£ÂÂ Ã£Ââ€¢Ã£Ââ€žÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageRedrawThumbnailFailed()
	{
		return "Ã£â€šÂµÃ£Æ’Â Ã£Æ’ÂÃ£â€šÂ¤Ã£Æ’Â«Ã£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£ÂÂ§Ã£ÂÂÃ£ÂÂ¾Ã£Ââ€ºÃ£â€šâ€œÃ£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageSelectEnableScaling()
	{
		return "Ã£â€šÂ¹Ã£â€šÂ±Ã£Æ’Â¼Ã£Æ’Â«Ã£â€šâ€™Ã¦Å“â€°Ã¥Å Â¹Ã£ÂÂ«Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ«Ã£ÂÂ¯Ã£â‚¬ÂR15Ã£â€šâ€™Ã©ÂÂ¸Ã¦Å Å¾Ã£Ââ€”Ã£â€šË†Ã£Ââ€ Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "Ã¦Ë†ÂÃ¥Å Å¸";
	}

	protected override string _GetTemplateForMessageSuccessCreateCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¤Â½Å“Ã¦Ë†ÂÃ£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessCreateOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¤Â½Å“Ã¦Ë†ÂÃ£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessDeleteCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessDeleteOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã¥â€°Å Ã©â„¢Â¤Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessEquipEmote()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¨Â£â€¦Ã¥â€šâ„¢Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessRenameCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessRenameOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã¥ÂÂÃ£â€šâ€™Ã¥Â¤â€°Ã¦â€ºÂ´Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessSavedAccessories()
	{
		return "Ã£â€šÂ¢Ã£â€šÂ¯Ã£â€šÂ»Ã£â€šÂµÃ£Æ’ÂªÃ£â€šâ€™Ã¤Â¿ÂÃ¥Â­ËœÃ£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessUnequipEmote()
	{
		return "Ã£â€šÂ¨Ã£Æ’Â¢Ã£Æ’Â¼Ã£Æ’Ë†Ã£â€šâ€™Ã¥Â¤â€“Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedOutfit()
	{
		return "Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessWoreCostume()
	{
		return "Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã£ÂÂ¤Ã£Ââ€˜Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	protected override string _GetTemplateForMessageSuccessWoreOutfit()
	{
		return "Ã¦Å“ÂÃ£â€šâ€™Ã£ÂÂ¤Ã£Ââ€˜Ã£ÂÂ¾Ã£Ââ€”Ã£ÂÅ¸";
	}

	/// <summary>
	/// Key: "Message.UpdateOutfit"
	/// English String: "Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateOutfit(string outfitType1, string outfitType2)
	{
		return $"Ã£Ââ€œÃ£ÂÂ®{outfitType1} Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ¨{outfitType2} Ã£ÂÅ’Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£ÂÂ§Ã¤Â¸Å Ã¦â€ºÂ¸Ã£ÂÂÃ£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageUpdateOutfit()
	{
		return "Ã£Ââ€œÃ£ÂÂ®{outfitType1} Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ¨{outfitType2} Ã£ÂÅ’Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£ÂÂ§Ã¤Â¸Å Ã¦â€ºÂ¸Ã£ÂÂÃ£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageUpdateThisCostume()
	{
		return "Ã£Ââ€œÃ£ÂÂ®Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ¨Ã£â€šÂ³Ã£â€šÂ¹Ã£Æ’ÂÃ£Æ’Â¥Ã£Æ’Â¼Ã£Æ’Â Ã£ÂÅ’Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£ÂÂ§Ã¤Â¸Å Ã¦â€ºÂ¸Ã£ÂÂÃ£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageUpdateThisOutfit()
	{
		return "Ã£Ââ€œÃ£ÂÂ®Ã¦Å“ÂÃ¨Â£â€¦Ã£â€šâ€™Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ€”Ã£ÂÂ¾Ã£Ââ„¢Ã£Ââ€¹Ã¯Â¼Å¸Ã£â€šÂ¢Ã£Æ’Æ’Ã£Æ’â€”Ã£Æ’â€¡Ã£Æ’Â¼Ã£Æ’Ë†Ã£Ââ„¢Ã£â€šâ€¹Ã£ÂÂ¨Ã¦Å“ÂÃ¨Â£â€¦Ã£ÂÅ’Ã£â€šÂ¢Ã£Æ’ÂÃ£â€šÂ¿Ã£Æ’Â¼Ã£ÂÂ®Ã§ÂÂ¾Ã¥Å“Â¨Ã£ÂÂ®Ã¥Â¤â€“Ã¨Â¦â€¹Ã£ÂÂ§Ã¤Â¸Å Ã¦â€ºÂ¸Ã£ÂÂÃ£Ââ€¢Ã£â€šÅ’Ã£ÂÂ¾Ã£Ââ„¢Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForMessageWarning()
	{
		return "Ã¨Â­Â¦Ã¥â€˜Å ";
	}
}


}

