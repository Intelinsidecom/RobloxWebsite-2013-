namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides AvatarResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AvatarResources_zh_tw : AvatarResources_en_us, IAvatarResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Advanced"
	/// Click Advanced to get the advanced options
	/// English String: "Advanced"
	/// </summary>
	public override string ActionAdvanced => "進階";

	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item to customize the user's avatar.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "購買";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "關閉";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "創作";

	/// <summary>
	/// Key: "Action.CreateNewOutfit"
	/// Button to create new outfit
	/// English String: "Create"
	/// </summary>
	public override string ActionCreateNewOutfit => "創作";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "刪除";

	/// <summary>
	/// Key: "Action.Done"
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "完成";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy get an item for free to customize the user's avatar.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "領取";

	/// <summary>
	/// Key: "Action.GetMore"
	/// A call to action for the user to buy more clothes from the Catalog page. This could improve how their avatar looks.
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "前往型錄";

	/// <summary>
	/// Key: "Action.OpenRobloxApp"
	/// English String: "Open Roblox App"
	/// </summary>
	public override string ActionOpenRobloxApp => "開啟 Roblox App";

	/// <summary>
	/// Key: "Action.Redraw"
	/// Redraw the avatar on the screen
	/// English String: "Redraw"
	/// </summary>
	public override string ActionRedraw => "重繪";

	/// <summary>
	/// Key: "Action.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string ActionRename => "更名";

	/// <summary>
	/// Key: "Action.RenameOutfit"
	/// Button to rename outfit
	/// English String: "Rename"
	/// </summary>
	public override string ActionRenameOutfit => "更名";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "儲存";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// See all clothing that user can buy
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "查看全部";

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
	public override string ActionUpdate => "更新";

	/// <summary>
	/// Key: "Action.UserUnderstands"
	/// The user casually responds to the application saying that they understand how to navigate the menu.
	/// English String: "Got it"
	/// </summary>
	public override string ActionUserUnderstands => "了解";

	/// <summary>
	/// Key: "Description.AvatarEditorUpsell"
	/// English String: "To change your look you will need to use the Avatar Editor on the App."
	/// </summary>
	public override string DescriptionAvatarEditorUpsell => "若要變更您的外觀，您需要使用 App 上的虛擬人偶編輯器。";

	/// <summary>
	/// Key: "Description.CreateNewCostume"
	/// A costume will be created from your avatar's current appearance.
	/// English String: "A costume will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewCostume => "將依照您的虛擬人偶目前的外觀創作一套裝扮。";

	/// <summary>
	/// Key: "Description.CreateNewOutfit"
	/// An outfit will be created from your avatar's current appearance.
	/// English String: "An outfit will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewOutfit => "將依照您的虛擬人偶目前的外觀創作一套服飾。";

	/// <summary>
	/// Key: "Description.RenameCostume"
	/// Choose a new name for your costume.
	/// English String: "Choose a new name for your costume."
	/// </summary>
	public override string DescriptionRenameCostume => "為您的裝扮命名。";

	/// <summary>
	/// Key: "Description.RenameOutfit"
	/// Choose a new name for your outfit.
	/// English String: "Choose a new name for your outfit."
	/// </summary>
	public override string DescriptionRenameOutfit => "為您的服飾命名。";

	/// <summary>
	/// Key: "Heading.Accessories"
	/// English String: "Accessories"
	/// </summary>
	public override string HeadingAccessories => "飾品";

	/// <summary>
	/// Key: "Heading.AccessoriesChange"
	/// English String: "Accessories Change"
	/// </summary>
	public override string HeadingAccessoriesChange => "飾品變更";

	/// <summary>
	/// Key: "Heading.AdvancedOptions"
	/// English String: "Advanced Options"
	/// </summary>
	public override string HeadingAdvancedOptions => "進階選項";

	/// <summary>
	/// Key: "Heading.All"
	/// All avatar modification types
	/// English String: "All"
	/// </summary>
	public override string HeadingAll => "全部";

	/// <summary>
	/// Key: "Heading.Animations"
	/// English String: "Animations"
	/// </summary>
	public override string HeadingAnimations => "動畫";

	/// <summary>
	/// Key: "Heading.Appearance"
	/// English String: "Appearance"
	/// </summary>
	public override string HeadingAppearance => "外觀";

	/// <summary>
	/// Key: "Heading.AvatarPageTitle"
	/// Page title for the Avatar page. On this page, the user can modify how they look.
	/// English String: "Avatar Editor"
	/// </summary>
	public override string HeadingAvatarPageTitle => "虛擬人偶編輯器";

	/// <summary>
	/// Key: "Heading.Body"
	/// English String: "Body"
	/// </summary>
	public override string HeadingBody => "身體";

	/// <summary>
	/// Key: "Heading.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string HeadingBodyParts => "身體部位";

	/// <summary>
	/// Key: "Heading.Clothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingClothing => "服裝";

	/// <summary>
	/// Key: "Heading.Costumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Costumes"
	/// </summary>
	public override string HeadingCostumes => "裝扮";

	/// <summary>
	/// Key: "Heading.CreateNewCostume"
	/// NOTE: Costume is a more whimsical word choice for outfit. Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Create New Costume"
	/// </summary>
	public override string HeadingCreateNewCostume => "創作新裝扮";

	/// <summary>
	/// Key: "Heading.CreateNewOutfit"
	/// English String: "Create New Outfit"
	/// </summary>
	public override string HeadingCreateNewOutfit => "創作新服飾";

	/// <summary>
	/// Key: "Heading.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string HeadingDelete => "刪除";

	/// <summary>
	/// Key: "Heading.DeleteCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Delete Costume"
	/// </summary>
	public override string HeadingDeleteCostume => "刪除裝扮";

	/// <summary>
	/// Key: "Heading.DeleteOutfit"
	/// English String: "Delete Outfit"
	/// </summary>
	public override string HeadingDeleteOutfit => "刪除服飾";

	/// <summary>
	/// Key: "Heading.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string HeadingEmotes => "動作";

	/// <summary>
	/// Key: "Heading.EquipEmotes"
	/// English String: "Equip Emotes"
	/// </summary>
	public override string HeadingEquipEmotes => "裝上動作";

	/// <summary>
	/// Key: "Heading.Outfits"
	/// English String: "Outfits"
	/// </summary>
	public override string HeadingOutfits => "服飾";

	/// <summary>
	/// Key: "Heading.Packages"
	/// English String: "Packages"
	/// </summary>
	public override string HeadingPackages => "套裝";

	/// <summary>
	/// Key: "Heading.Recent"
	/// English String: "Recent"
	/// </summary>
	public override string HeadingRecent => "最近使用";

	/// <summary>
	/// Key: "Heading.Recommended"
	/// See recommended clothing for your avatar
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommended => "推薦";

	/// <summary>
	/// Key: "Heading.RenameCostume"
	/// English String: "Rename Costume"
	/// </summary>
	public override string HeadingRenameCostume => "為裝扮更名";

	/// <summary>
	/// Key: "Heading.RenameOutfit"
	/// English String: "Rename Outfit"
	/// </summary>
	public override string HeadingRenameOutfit => "為服飾更名";

	/// <summary>
	/// Key: "Heading.Scaling"
	/// English String: "Scaling"
	/// </summary>
	public override string HeadingScaling => "縮放";

	/// <summary>
	/// Key: "Heading.SkinToneBodyParts"
	/// English String: "Skin Tone by Body Parts"
	/// </summary>
	public override string HeadingSkinToneBodyParts => "膚色（按身體部位）";

	/// <summary>
	/// Key: "Heading.Update"
	/// English String: "Update"
	/// </summary>
	public override string HeadingUpdate => "更新";

	/// <summary>
	/// Key: "Heading.UpdateCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Update Costume"
	/// </summary>
	public override string HeadingUpdateCostume => "更新裝扮";

	/// <summary>
	/// Key: "Heading.UpdateOutfit"
	/// English String: "Update Outfit"
	/// </summary>
	public override string HeadingUpdateOutfit => "更新服飾";

	/// <summary>
	/// Key: "Label.All"
	/// All body parts. This label will allow for body parts to change color
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "全部";

	/// <summary>
	/// Key: "Label.AskIfLoadingCorrectly"
	/// Avatar isn't loading correctly?
	/// English String: "Avatar isn't loading correctly?"
	/// </summary>
	public override string LabelAskIfLoadingCorrectly => "虛擬人偶未正確載入？";

	/// <summary>
	/// Key: "Label.AssetIDPlaceholder"
	/// This refers to the Asset ID which is a technical word for the Identification Number of an item or asset.
	/// English String: "Asset ID"
	/// </summary>
	public override string LabelAssetIDPlaceholder => "素材 ID";

	/// <summary>
	/// Key: "Label.Back"
	/// English String: "Back"
	/// </summary>
	public override string LabelBack => "背面";

	/// <summary>
	/// Key: "Label.BackAccessories"
	/// English String: "Back Accessories"
	/// </summary>
	public override string LabelBackAccessories => "背面飾品";

	/// <summary>
	/// Key: "Label.BodyType"
	/// English String: "Body Type"
	/// </summary>
	public override string LabelBodyType => "體型";

	/// <summary>
	/// Key: "Label.Climb"
	/// English String: "Climb"
	/// </summary>
	public override string LabelClimb => "攀爬";

	/// <summary>
	/// Key: "Label.ClimbAnimations"
	/// English String: "Climb Animations"
	/// </summary>
	public override string LabelClimbAnimations => "攀爬動畫";

	/// <summary>
	/// Key: "Label.Clothes"
	/// English String: "Clothes"
	/// </summary>
	public override string LabelClothes => "衣物";

	/// <summary>
	/// Key: "Label.Costume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Costume"
	/// </summary>
	public override string LabelCostume => "裝扮";

	/// <summary>
	/// Key: "label.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string labelEmotes => "動作";

	/// <summary>
	/// Key: "Label.Equip"
	/// English String: "Equip"
	/// </summary>
	public override string LabelEquip => "裝備";

	/// <summary>
	/// Key: "Label.ExploreCatalog"
	/// This text entices users to shop for more things to wear on their avatar
	/// English String: "Explore the catalog to find more clothes!"
	/// </summary>
	public override string LabelExploreCatalog => "瀏覽型錄，尋找更多服裝！";

	/// <summary>
	/// Key: "Label.Face"
	/// English String: "Face"
	/// </summary>
	public override string LabelFace => "臉部";

	/// <summary>
	/// Key: "Label.FaceAccessories"
	/// English String: "Face Accessories"
	/// </summary>
	public override string LabelFaceAccessories => "臉部飾品";

	/// <summary>
	/// Key: "Label.Faces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "臉部";

	/// <summary>
	/// Key: "Label.Fall"
	/// English String: "Fall"
	/// </summary>
	public override string LabelFall => "跌落";

	/// <summary>
	/// Key: "Label.FallAnimations"
	/// English String: "Fall Animations"
	/// </summary>
	public override string LabelFallAnimations => "跌落動畫";

	/// <summary>
	/// Key: "Label.Free"
	/// Text label for recommended items
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "免費";

	/// <summary>
	/// Key: "Label.Front"
	/// English String: "Front"
	/// </summary>
	public override string LabelFront => "正面";

	/// <summary>
	/// Key: "Label.FrontAccessories"
	/// English String: "Front Accessories"
	/// </summary>
	public override string LabelFrontAccessories => "正面飾品";

	/// <summary>
	/// Key: "Label.Gear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "裝備";

	/// <summary>
	/// Key: "Label.Hair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelHair => "髮型";

	/// <summary>
	/// Key: "Label.HairAccessories"
	/// English String: "Hair Accessories"
	/// </summary>
	public override string LabelHairAccessories => "髮型飾品";

	/// <summary>
	/// Key: "Label.Hat"
	/// English String: "Hat"
	/// </summary>
	public override string LabelHat => "帽子";

	/// <summary>
	/// Key: "Label.HatAccessories"
	/// English String: "Hat Accessories"
	/// </summary>
	public override string LabelHatAccessories => "帽子飾品";

	/// <summary>
	/// Key: "Label.Head"
	/// English String: "Head"
	/// </summary>
	public override string LabelHead => "頭部";

	/// <summary>
	/// Key: "Label.Heads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "頭部";

	/// <summary>
	/// Key: "Label.Height"
	/// English String: "Height"
	/// </summary>
	public override string LabelHeight => "高度";

	/// <summary>
	/// Key: "Label.Idle"
	/// English String: "Idle"
	/// </summary>
	public override string LabelIdle => "閒置";

	/// <summary>
	/// Key: "Label.IdleAnimations"
	/// English String: "Idle Animations"
	/// </summary>
	public override string LabelIdleAnimations => "閒置動畫";

	/// <summary>
	/// Key: "Label.Jump"
	/// English String: "Jump"
	/// </summary>
	public override string LabelJump => "跳躍";

	/// <summary>
	/// Key: "Label.JumpAnimations"
	/// English String: "Jump Animations"
	/// </summary>
	public override string LabelJumpAnimations => "跳躍動畫";

	/// <summary>
	/// Key: "Label.LeftArm"
	/// English String: "Left Arm"
	/// </summary>
	public override string LabelLeftArm => "左臂";

	/// <summary>
	/// Key: "Label.LeftArms"
	/// English String: "Left Arms"
	/// </summary>
	public override string LabelLeftArms => "左臂";

	/// <summary>
	/// Key: "Label.LeftLeg"
	/// English String: "Left Leg"
	/// </summary>
	public override string LabelLeftLeg => "左腿";

	/// <summary>
	/// Key: "Label.LeftLegs"
	/// English String: "Left Legs"
	/// </summary>
	public override string LabelLeftLegs => "左腿";

	/// <summary>
	/// Key: "Label.MyCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "My Costumes"
	/// </summary>
	public override string LabelMyCostumes => "我的裝扮";

	/// <summary>
	/// Key: "Label.NamePlaceholderCostume"
	/// English String: "Name your costume"
	/// </summary>
	public override string LabelNamePlaceholderCostume => "為您的裝扮命名";

	/// <summary>
	/// Key: "Label.NamePlaceholderOutfit"
	/// English String: "Name your outfit"
	/// </summary>
	public override string LabelNamePlaceholderOutfit => "命名服飾";

	/// <summary>
	/// Key: "Label.Neck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelNeck => "頸部";

	/// <summary>
	/// Key: "Label.NeckAccessories"
	/// English String: "Neck Accessories"
	/// </summary>
	public override string LabelNeckAccessories => "頸部飾品";

	/// <summary>
	/// Key: "Label.NoResellers"
	/// Text label for recommended items
	/// English String: "No resellers"
	/// </summary>
	public override string LabelNoResellers => "沒有人轉賣";

	/// <summary>
	/// Key: "Label.OffSale"
	/// Text label for recommended items
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "下架";

	/// <summary>
	/// Key: "Label.Outfit"
	/// English String: "Outfit"
	/// </summary>
	public override string LabelOutfit => "服飾";

	/// <summary>
	/// Key: "Label.Pants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "褲子";

	/// <summary>
	/// Key: "Label.Parts"
	/// English String: "Parts"
	/// </summary>
	public override string LabelParts => "部位";

	/// <summary>
	/// Key: "Label.PresetCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Preset Costumes"
	/// </summary>
	public override string LabelPresetCostumes => "預設裝扮";

	/// <summary>
	/// Key: "Label.Proportions"
	/// English String: "Proportions"
	/// </summary>
	public override string LabelProportions => "身材";

	/// <summary>
	/// Key: "Label.RedrawUnavailable"
	/// Avatar redraw is unavailable
	/// English String: "Avatar redraw is unavailable."
	/// </summary>
	public override string LabelRedrawUnavailable => "無法使用虛擬人偶重繪。";

	/// <summary>
	/// Key: "Label.RightArm"
	/// English String: "Right Arm"
	/// </summary>
	public override string LabelRightArm => "右臂";

	/// <summary>
	/// Key: "Label.RightArms"
	/// English String: "Right Arms"
	/// </summary>
	public override string LabelRightArms => "右臂";

	/// <summary>
	/// Key: "Label.RightLeg"
	/// English String: "Right Leg"
	/// </summary>
	public override string LabelRightLeg => "右腿";

	/// <summary>
	/// Key: "Label.RightLegs"
	/// English String: "Right Legs"
	/// </summary>
	public override string LabelRightLegs => "右腿";

	/// <summary>
	/// Key: "Label.Run"
	/// English String: "Run"
	/// </summary>
	public override string LabelRun => "奔跑";

	/// <summary>
	/// Key: "Label.RunAnimations"
	/// English String: "Run Animations"
	/// </summary>
	public override string LabelRunAnimations => "奔跑動畫";

	/// <summary>
	/// Key: "Label.Scale"
	/// English String: "Scale"
	/// </summary>
	public override string LabelScale => "比例";

	/// <summary>
	/// Key: "Label.Shirts"
	/// English String: "Shirts"
	/// </summary>
	public override string LabelShirts => "襯衫";

	/// <summary>
	/// Key: "Label.ShoulderAccessories"
	/// English String: "Shoulder Accessories"
	/// </summary>
	public override string LabelShoulderAccessories => "肩膀飾品";

	/// <summary>
	/// Key: "Label.Shoulders"
	/// English String: "Shoulders"
	/// </summary>
	public override string LabelShoulders => "肩膀";

	/// <summary>
	/// Key: "Label.SkinTone"
	/// English String: "Skin Tone"
	/// </summary>
	public override string LabelSkinTone => "膚色";

	/// <summary>
	/// Key: "Label.Swim"
	/// English String: "Swim"
	/// </summary>
	public override string LabelSwim => "游泳";

	/// <summary>
	/// Key: "Label.SwimAnimations"
	/// English String: "Swim Animations"
	/// </summary>
	public override string LabelSwimAnimations => "游泳動畫";

	/// <summary>
	/// Key: "Label.SwitchAvatarType"
	/// User is able to increase the number of joints in their avatar from 6 to 15. R15 moves better. See http://roblox.wikia.com/wiki/R15
	/// English String: "Switch between classic R6 avatar and more expressive next generation R15 avatar"
	/// </summary>
	public override string LabelSwitchAvatarType => "在經典 R6 虛擬人偶與更有表現力的新一代 R15 虛擬人偶之間切換";

	/// <summary>
	/// Key: "Label.Torso"
	/// English String: "Torso"
	/// </summary>
	public override string LabelTorso => "軀幹";

	/// <summary>
	/// Key: "Label.Torsos"
	/// English String: "Torsos"
	/// </summary>
	public override string LabelTorsos => "軀幹";

	/// <summary>
	/// Key: "Label.TShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "T 恤";

	/// <summary>
	/// Key: "Label.Waist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelWaist => "腰部";

	/// <summary>
	/// Key: "Label.WaistAccessories"
	/// English String: "Waist Accessories"
	/// </summary>
	public override string LabelWaistAccessories => "腰部飾品";

	/// <summary>
	/// Key: "Label.Walk"
	/// English String: "Walk"
	/// </summary>
	public override string LabelWalk => "步行";

	/// <summary>
	/// Key: "Label.WalkAnimations"
	/// English String: "Walk Animations"
	/// </summary>
	public override string LabelWalkAnimations => "步行動畫";

	/// <summary>
	/// Key: "Label.Width"
	/// English String: "Width"
	/// </summary>
	public override string LabelWidth => "寬度";

	/// <summary>
	/// Key: "Label.YourEmotes"
	/// English String: "Your Emotes"
	/// </summary>
	public override string LabelYourEmotes => "您的動作";

	/// <summary>
	/// Key: "Message.AccessoriesChange"
	/// English String: "Are you sure you want to override your current look?"
	/// </summary>
	public override string MessageAccessoriesChange => "確定覆蓋目前的外觀？";

	/// <summary>
	/// Key: "Message.ChooseEmote"
	/// English String: "Choose an Emote"
	/// </summary>
	public override string MessageChooseEmote => "選擇動作";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlot"
	/// English String: "Choose a slot"
	/// </summary>
	public override string MessageChooseEmoteSlot => "選擇欄位";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlotOrEmote"
	/// English String: "Choose a slot or an Emote"
	/// </summary>
	public override string MessageChooseEmoteSlotOrEmote => "選擇欄位或動作";

	/// <summary>
	/// Key: "Message.DefaultClothing"
	/// Encourage user to choose their own clothes.
	/// English String: "Default clothing has been applied to your avatar - wear something from your clothing."
	/// </summary>
	public override string MessageDefaultClothing => "已在您的虛擬人偶套用預設服裝，請自行選擇要穿上的服裝。";

	/// <summary>
	/// Key: "Message.DeleteThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Are you sure you want to delete this costume?"
	/// </summary>
	public override string MessageDeleteThisCostume => "確定刪除此裝扮？";

	/// <summary>
	/// Key: "Message.DeleteThisOutfit"
	/// English String: "Are you sure you want to delete this outfit?"
	/// </summary>
	public override string MessageDeleteThisOutfit => "確定刪除此服飾？";

	/// <summary>
	/// Key: "Message.EmotesInstructions"
	/// The instructions describe the navigation flow within the Avatar Editor to equip an emote.
	/// English String: "Go to \"Animations\" &gt; \"Emotes\" &gt; \"Equip Emotes\" to equip an emote."
	/// </summary>
	public override string MessageEmotesInstructions => "前往「動畫」>「動作」>「裝備動作」來裝備動作。";

	/// <summary>
	/// Key: "Message.EmptyAssetList"
	/// User is seeing no assets on this page because they don't have any.
	/// English String: "You don't have any."
	/// </summary>
	public override string MessageEmptyAssetList => "您沒有素材。";

	/// <summary>
	/// Key: "Message.EmptyListOfCostumes"
	/// The user is viewing an empty list of costumes to choose from. The application tells the user that they can create an costume.
	/// English String: "You don't have any costumes. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfCostumes => "您沒有任何裝扮。請試著創作一些吧！";

	/// <summary>
	/// Key: "Message.EmptyListOfOutfits"
	/// The user is viewing an empty list of outfits to choose from. The application tells the user that they can create an outfit.
	/// English String: "You don't have any outfits. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfOutfits => "您沒有任何服飾，請嘗試創作服飾吧！";

	/// <summary>
	/// Key: "Message.EmptyRecentItems"
	/// English String: "You don't have any recent items."
	/// </summary>
	public override string MessageEmptyRecentItems => "沒有最近使用的道具。";

	/// <summary>
	/// Key: "Message.ErrorCreateCostume"
	/// English String: "Unable to create costume, try again later."
	/// </summary>
	public override string MessageErrorCreateCostume => "無法創作裝扮，請稍後再試。";

	/// <summary>
	/// Key: "Message.ErrorCreateOutfit"
	/// English String: "Unable to create outfit, try again later."
	/// </summary>
	public override string MessageErrorCreateOutfit => "無法創作服飾，請稍後再試。";

	/// <summary>
	/// Key: "Message.ErrorDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageErrorDeleteEmote => "無法刪除動作。";

	/// <summary>
	/// Key: "Message.ErrorEquipEmote"
	/// English String: "Failed to equip emote, please try again later."
	/// </summary>
	public override string MessageErrorEquipEmote => "無法裝上動作，請稍後再試。";

	/// <summary>
	/// Key: "Message.ErrorLoadCostume"
	/// English String: "Failed to load costume."
	/// </summary>
	public override string MessageErrorLoadCostume => "無法載入裝扮。";

	/// <summary>
	/// Key: "Message.ErrorLoadEmotes"
	/// English String: "Failed to load emotes."
	/// </summary>
	public override string MessageErrorLoadEmotes => "無法載入動作。";

	/// <summary>
	/// Key: "Message.ErrorLoadOutfits"
	/// English String: "Failed to load outfits."
	/// </summary>
	public override string MessageErrorLoadOutfits => "無法載入服飾。";

	/// <summary>
	/// Key: "Message.ErrorOutfitName"
	/// English String: "Name can contain letters, numbers, and spaces."
	/// </summary>
	public override string MessageErrorOutfitName => "名稱可含有字母、數字和空格。";

	/// <summary>
	/// Key: "Message.ErrorRenameCostume"
	/// English String: "Failed to rename costume."
	/// </summary>
	public override string MessageErrorRenameCostume => "無法為裝扮更名。";

	/// <summary>
	/// Key: "Message.ErrorRenameOutfit"
	/// English String: "Failed to rename outfit."
	/// </summary>
	public override string MessageErrorRenameOutfit => "無法為服飾更名。";

	/// <summary>
	/// Key: "Message.ErrorUnequipEmote"
	/// English String: "Failed to unequip emote."
	/// </summary>
	public override string MessageErrorUnequipEmote => "無法卸下動作。";

	/// <summary>
	/// Key: "Message.ErrorUpdateCostume"
	/// English String: "Costume update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateCostume => "無法更新裝扮，請稍後再試。";

	/// <summary>
	/// Key: "Message.ErrorUpdateEmote"
	/// English String: "Updating emote slot failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateEmote => "更新動作欄位失敗，請稍後再試。";

	/// <summary>
	/// Key: "Message.ErrorUpdateOutfit"
	/// English String: "Outfit update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateOutfit => "無法更新服飾，請稍後再試。";

	/// <summary>
	/// Key: "Message.ErrorUpdateWorn"
	/// There was an error updating items that the user is already wearing.
	/// English String: "Error while updating worn items."
	/// </summary>
	public override string MessageErrorUpdateWorn => "更新已穿戴道具時發生錯誤。";

	/// <summary>
	/// Key: "Message.ErrorWearCostume"
	/// English String: "Failed to wear costume."
	/// </summary>
	public override string MessageErrorWearCostume => "無法穿上此裝扮。";

	/// <summary>
	/// Key: "Message.ErrorWearOutfit"
	/// English String: "Failed to wear outfit."
	/// </summary>
	public override string MessageErrorWearOutfit => "無法穿上此服飾。";

	/// <summary>
	/// Key: "Message.FailedDeleteCostume"
	/// English String: "Failed to delete costume."
	/// </summary>
	public override string MessageFailedDeleteCostume => "無法刪除此裝扮。";

	/// <summary>
	/// Key: "Message.FailedDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageFailedDeleteEmote => "無法刪除動作。";

	/// <summary>
	/// Key: "Message.FailedDeleteOutfit"
	/// English String: "Failed to delete outfit."
	/// </summary>
	public override string MessageFailedDeleteOutfit => "無法刪除此服飾。";

	/// <summary>
	/// Key: "Message.FailedLoadAssets"
	/// English String: "Failed to load assets list."
	/// </summary>
	public override string MessageFailedLoadAssets => "無法載入素材清單。";

	/// <summary>
	/// Key: "Message.FailedLoadRecent"
	/// English String: "Failed to load recent items."
	/// </summary>
	public override string MessageFailedLoadRecent => "無法載入最近使用過的道具。";

	/// <summary>
	/// Key: "Message.FailedUpdateBodyColor"
	/// English String: "Failed to update skin tone."
	/// </summary>
	public override string MessageFailedUpdateBodyColor => "無法更新膚色。";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedCostume"
	/// The user tried to update a deleted costume.
	/// English String: "The costume you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedCostume => "您嘗試更新的裝扮已不存在。";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedOutfit"
	/// The user tried to update a deleted outfit.
	/// English String: "The outfit you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedOutfit => "您嘗試更新的服裝已不存在。";

	/// <summary>
	/// Key: "Message.FailedUpdateScales"
	/// English String: "Failed to update scales."
	/// </summary>
	public override string MessageFailedUpdateScales => "無法更新比例。";

	/// <summary>
	/// Key: "Message.FailedUpdateType"
	/// Failed to update the way the user's avatar is rendered.
	/// English String: "Failed to update avatar type."
	/// </summary>
	public override string MessageFailedUpdateType => "無法更新虛擬人偶類型。";

	/// <summary>
	/// Key: "Message.FailedWearPackage"
	/// English String: "Failed to wear package."
	/// </summary>
	public override string MessageFailedWearPackage => "無法穿戴套裝。";

	/// <summary>
	/// Key: "Message.HatLimitTooltip"
	/// English String: "You can wear up to 3 hats"
	/// </summary>
	public override string MessageHatLimitTooltip => "您最多可以戴上 3 頂帽子";

	/// <summary>
	/// Key: "Message.InvalidOutfitName"
	/// English String: "Name must be appropriate and less than 200 characters."
	/// </summary>
	public override string MessageInvalidOutfitName => "名稱必須適當，並少於 200 個字元。";

	/// <summary>
	/// Key: "Message.Loading"
	/// The user's avatar is loading
	/// English String: "Loading..."
	/// </summary>
	public override string MessageLoading => "正在載入…";

	/// <summary>
	/// Key: "Message.PageUnavailable"
	/// English String: "The avatar page is temporarily unavailable."
	/// </summary>
	public override string MessagePageUnavailable => "暫時無法使用虛擬人偶頁面。";

	/// <summary>
	/// Key: "Message.PresetCostumesDelay"
	/// One-time message that appears to the user first time they visit the Preset Costumes tab. The delay is caused by initial migration.
	/// English String: "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!"
	/// </summary>
	public override string MessagePresetCostumesDelay => "注意：我們正在進行更新，所以您的裝扮可能幾分鐘後才會出現。請稍後再回來！";

	/// <summary>
	/// Key: "Message.ReachedMaxCostumes"
	/// English String: "You have reached the maximum number of costumes."
	/// </summary>
	public override string MessageReachedMaxCostumes => "您的裝扮數量已達上限。";

	/// <summary>
	/// Key: "Message.ReachedMaxOutfits"
	/// English String: "You have reached the maximum number of outfits."
	/// </summary>
	public override string MessageReachedMaxOutfits => "您的服飾數量已達上限。";

	/// <summary>
	/// Key: "Message.RedirectAvatarSettings"
	/// English String: "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home &gt; Game Settings &gt; Avatar"
	/// </summary>
	public override string MessageRedirectAvatarSettings => "您可以從 Roblox Studio 專案變更虛擬人偶設定，請在 Roblox Studio 前往首頁 > 遊戲設定 > 虛擬人偶";

	/// <summary>
	/// Key: "Message.RedrawFloodchecked"
	/// English String: "You have redrawn your avatar too many times, please try again later."
	/// </summary>
	public override string MessageRedrawFloodchecked => "您重繪虛擬人偶次數過多，請稍後再試。";

	/// <summary>
	/// Key: "Message.RedrawThumbnailFailed"
	/// English String: "Failed to redraw thumbnail."
	/// </summary>
	public override string MessageRedrawThumbnailFailed => "無法重繪縮圖。";

	/// <summary>
	/// Key: "Message.SelectEnableScaling"
	/// R15 is a proper noun
	/// English String: "Select R15 to enable scaling."
	/// </summary>
	public override string MessageSelectEnableScaling => "縮放僅適用於 R15 虛擬人偶";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "成功";

	/// <summary>
	/// Key: "Message.SuccessCreateCostume"
	/// English String: "Created costume"
	/// </summary>
	public override string MessageSuccessCreateCostume => "已創作裝扮";

	/// <summary>
	/// Key: "Message.SuccessCreateOutfit"
	/// English String: "Created outfit"
	/// </summary>
	public override string MessageSuccessCreateOutfit => "已創作服飾";

	/// <summary>
	/// Key: "Message.SuccessDeleteCostume"
	/// Deleted costume
	/// English String: "Deleted costume"
	/// </summary>
	public override string MessageSuccessDeleteCostume => "裝扮已刪除";

	/// <summary>
	/// Key: "Message.SuccessDeleteOutfit"
	/// English String: "Deleted outfit"
	/// </summary>
	public override string MessageSuccessDeleteOutfit => "已刪除此服飾";

	/// <summary>
	/// Key: "Message.SuccessEquipEmote"
	/// English String: "Equipped Emote"
	/// </summary>
	public override string MessageSuccessEquipEmote => "已裝上動作";

	/// <summary>
	/// Key: "Message.SuccessRenameCostume"
	/// English String: "Renamed costume"
	/// </summary>
	public override string MessageSuccessRenameCostume => "已為裝扮更名";

	/// <summary>
	/// Key: "Message.SuccessRenameOutfit"
	/// English String: "Renamed outfit"
	/// </summary>
	public override string MessageSuccessRenameOutfit => "已為服飾更名";

	/// <summary>
	/// Key: "Message.SuccessSavedAccessories"
	/// English String: "Saved accessories"
	/// </summary>
	public override string MessageSuccessSavedAccessories => "已儲存飾品";

	/// <summary>
	/// Key: "Message.SuccessUnequipEmote"
	/// English String: "Unequipped emote"
	/// </summary>
	public override string MessageSuccessUnequipEmote => "已卸下動作";

	/// <summary>
	/// Key: "Message.SuccessUpdatedCostume"
	/// English String: "Updated costume"
	/// </summary>
	public override string MessageSuccessUpdatedCostume => "裝扮已更新";

	/// <summary>
	/// Key: "Message.SuccessUpdatedOutfit"
	/// English String: "Updated outfit"
	/// </summary>
	public override string MessageSuccessUpdatedOutfit => "已更新服飾";

	/// <summary>
	/// Key: "Message.SuccessWoreCostume"
	/// English String: "Successfully wore costume"
	/// </summary>
	public override string MessageSuccessWoreCostume => "已成功穿戴裝扮";

	/// <summary>
	/// Key: "Message.SuccessWoreOutfit"
	/// English String: "Successfully wore outfit"
	/// </summary>
	public override string MessageSuccessWoreOutfit => "已成功穿戴服飾";

	/// <summary>
	/// Key: "Message.UpdateThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisCostume => "您要更新此裝扮嗎？此動作會將裝扮覆蓋成您的虛擬人偶目前的外觀。";

	/// <summary>
	/// Key: "Message.UpdateThisOutfit"
	/// English String: "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisOutfit => "您要更新此服飾嗎？此動作會將服飾覆蓋成您的虛擬人偶目前的外觀。";

	/// <summary>
	/// Key: "Message.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string MessageWarning => "警告";

	public AvatarResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvanced()
	{
		return "進階";
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "購買";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "關閉";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "創作";
	}

	protected override string _GetTemplateForActionCreateNewOutfit()
	{
		return "創作";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "刪除";
	}

	protected override string _GetTemplateForActionDone()
	{
		return "完成";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "領取";
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "前往型錄";
	}

	protected override string _GetTemplateForActionOpenRobloxApp()
	{
		return "開啟 Roblox App";
	}

	protected override string _GetTemplateForActionRedraw()
	{
		return "重繪";
	}

	protected override string _GetTemplateForActionRename()
	{
		return "更名";
	}

	protected override string _GetTemplateForActionRenameOutfit()
	{
		return "更名";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "儲存";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "查看全部";
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
		return "更新";
	}

	protected override string _GetTemplateForActionUserUnderstands()
	{
		return "了解";
	}

	protected override string _GetTemplateForDescriptionAvatarEditorUpsell()
	{
		return "若要變更您的外觀，您需要使用 App 上的虛擬人偶編輯器。";
	}

	protected override string _GetTemplateForDescriptionCreateNewCostume()
	{
		return "將依照您的虛擬人偶目前的外觀創作一套裝扮。";
	}

	protected override string _GetTemplateForDescriptionCreateNewOutfit()
	{
		return "將依照您的虛擬人偶目前的外觀創作一套服飾。";
	}

	protected override string _GetTemplateForDescriptionRenameCostume()
	{
		return "為您的裝扮命名。";
	}

	protected override string _GetTemplateForDescriptionRenameOutfit()
	{
		return "為您的服飾命名。";
	}

	protected override string _GetTemplateForHeadingAccessories()
	{
		return "飾品";
	}

	protected override string _GetTemplateForHeadingAccessoriesChange()
	{
		return "飾品變更";
	}

	protected override string _GetTemplateForHeadingAdvancedOptions()
	{
		return "進階選項";
	}

	protected override string _GetTemplateForHeadingAll()
	{
		return "全部";
	}

	protected override string _GetTemplateForHeadingAnimations()
	{
		return "動畫";
	}

	protected override string _GetTemplateForHeadingAppearance()
	{
		return "外觀";
	}

	protected override string _GetTemplateForHeadingAvatarPageTitle()
	{
		return "虛擬人偶編輯器";
	}

	protected override string _GetTemplateForHeadingBody()
	{
		return "身體";
	}

	protected override string _GetTemplateForHeadingBodyParts()
	{
		return "身體部位";
	}

	protected override string _GetTemplateForHeadingClothing()
	{
		return "服裝";
	}

	protected override string _GetTemplateForHeadingCostumes()
	{
		return "裝扮";
	}

	protected override string _GetTemplateForHeadingCreateNewCostume()
	{
		return "創作新裝扮";
	}

	protected override string _GetTemplateForHeadingCreateNewOutfit()
	{
		return "創作新服飾";
	}

	protected override string _GetTemplateForHeadingDelete()
	{
		return "刪除";
	}

	protected override string _GetTemplateForHeadingDeleteCostume()
	{
		return "刪除裝扮";
	}

	protected override string _GetTemplateForHeadingDeleteOutfit()
	{
		return "刪除服飾";
	}

	protected override string _GetTemplateForHeadingEmotes()
	{
		return "動作";
	}

	protected override string _GetTemplateForHeadingEquipEmotes()
	{
		return "裝上動作";
	}

	protected override string _GetTemplateForHeadingOutfits()
	{
		return "服飾";
	}

	protected override string _GetTemplateForHeadingPackages()
	{
		return "套裝";
	}

	protected override string _GetTemplateForHeadingRecent()
	{
		return "最近使用";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "推薦";
	}

	protected override string _GetTemplateForHeadingRenameCostume()
	{
		return "為裝扮更名";
	}

	protected override string _GetTemplateForHeadingRenameOutfit()
	{
		return "為服飾更名";
	}

	protected override string _GetTemplateForHeadingScaling()
	{
		return "縮放";
	}

	protected override string _GetTemplateForHeadingSkinToneBodyParts()
	{
		return "膚色（按身體部位）";
	}

	protected override string _GetTemplateForHeadingUpdate()
	{
		return "更新";
	}

	protected override string _GetTemplateForHeadingUpdateCostume()
	{
		return "更新裝扮";
	}

	protected override string _GetTemplateForHeadingUpdateOutfit()
	{
		return "更新服飾";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "全部";
	}

	protected override string _GetTemplateForLabelAskIfLoadingCorrectly()
	{
		return "虛擬人偶未正確載入？";
	}

	protected override string _GetTemplateForLabelAssetIDPlaceholder()
	{
		return "素材 ID";
	}

	protected override string _GetTemplateForLabelBack()
	{
		return "背面";
	}

	protected override string _GetTemplateForLabelBackAccessories()
	{
		return "背面飾品";
	}

	protected override string _GetTemplateForLabelBodyType()
	{
		return "體型";
	}

	protected override string _GetTemplateForLabelClimb()
	{
		return "攀爬";
	}

	protected override string _GetTemplateForLabelClimbAnimations()
	{
		return "攀爬動畫";
	}

	protected override string _GetTemplateForLabelClothes()
	{
		return "衣物";
	}

	protected override string _GetTemplateForLabelCostume()
	{
		return "裝扮";
	}

	/// <summary>
	/// Key: "Label.DirectionsForPackagePlacement"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}"
	/// </summary>
	public override string LabelDirectionsForPackagePlacement(string startBold, string rightArrow, string endBold)
	{
		return $"「套裝」已移到「裝扮」。請查看{startBold}裝扮{rightArrow}預設裝扮{endBold}";
	}

	protected override string _GetTemplateForLabelDirectionsForPackagePlacement()
	{
		return "「套裝」已移到「裝扮」。請查看{startBold}裝扮{rightArrow}預設裝扮{endBold}";
	}

	/// <summary>
	/// Key: "Label.DirectionsForScalingOptions"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}"
	/// </summary>
	public override string LabelDirectionsForScalingOptions(string startBold, string rightArrow, string endBold)
	{
		return $"「身體」類別中提供縮放選項。請查看{startBold}身體{rightArrow}比例{endBold}";
	}

	protected override string _GetTemplateForLabelDirectionsForScalingOptions()
	{
		return "「身體」類別中提供縮放選項。請查看{startBold}身體{rightArrow}比例{endBold}";
	}

	protected override string _GetTemplateForlabelEmotes()
	{
		return "動作";
	}

	protected override string _GetTemplateForLabelEquip()
	{
		return "裝備";
	}

	protected override string _GetTemplateForLabelExploreCatalog()
	{
		return "瀏覽型錄，尋找更多服裝！";
	}

	protected override string _GetTemplateForLabelFace()
	{
		return "臉部";
	}

	protected override string _GetTemplateForLabelFaceAccessories()
	{
		return "臉部飾品";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "臉部";
	}

	protected override string _GetTemplateForLabelFall()
	{
		return "跌落";
	}

	protected override string _GetTemplateForLabelFallAnimations()
	{
		return "跌落動畫";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "免費";
	}

	protected override string _GetTemplateForLabelFront()
	{
		return "正面";
	}

	protected override string _GetTemplateForLabelFrontAccessories()
	{
		return "正面飾品";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "裝備";
	}

	protected override string _GetTemplateForLabelHair()
	{
		return "髮型";
	}

	protected override string _GetTemplateForLabelHairAccessories()
	{
		return "髮型飾品";
	}

	protected override string _GetTemplateForLabelHat()
	{
		return "帽子";
	}

	protected override string _GetTemplateForLabelHatAccessories()
	{
		return "帽子飾品";
	}

	protected override string _GetTemplateForLabelHead()
	{
		return "頭部";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "頭部";
	}

	protected override string _GetTemplateForLabelHeight()
	{
		return "高度";
	}

	protected override string _GetTemplateForLabelIdle()
	{
		return "閒置";
	}

	protected override string _GetTemplateForLabelIdleAnimations()
	{
		return "閒置動畫";
	}

	protected override string _GetTemplateForLabelJump()
	{
		return "跳躍";
	}

	protected override string _GetTemplateForLabelJumpAnimations()
	{
		return "跳躍動畫";
	}

	protected override string _GetTemplateForLabelLeftArm()
	{
		return "左臂";
	}

	protected override string _GetTemplateForLabelLeftArms()
	{
		return "左臂";
	}

	protected override string _GetTemplateForLabelLeftLeg()
	{
		return "左腿";
	}

	protected override string _GetTemplateForLabelLeftLegs()
	{
		return "左腿";
	}

	protected override string _GetTemplateForLabelMyCostumes()
	{
		return "我的裝扮";
	}

	protected override string _GetTemplateForLabelNamePlaceholderCostume()
	{
		return "為您的裝扮命名";
	}

	protected override string _GetTemplateForLabelNamePlaceholderOutfit()
	{
		return "命名服飾";
	}

	protected override string _GetTemplateForLabelNeck()
	{
		return "頸部";
	}

	protected override string _GetTemplateForLabelNeckAccessories()
	{
		return "頸部飾品";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "沒有人轉賣";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "下架";
	}

	protected override string _GetTemplateForLabelOutfit()
	{
		return "服飾";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "褲子";
	}

	protected override string _GetTemplateForLabelParts()
	{
		return "部位";
	}

	protected override string _GetTemplateForLabelPresetCostumes()
	{
		return "預設裝扮";
	}

	protected override string _GetTemplateForLabelProportions()
	{
		return "身材";
	}

	protected override string _GetTemplateForLabelRedrawUnavailable()
	{
		return "無法使用虛擬人偶重繪。";
	}

	protected override string _GetTemplateForLabelRightArm()
	{
		return "右臂";
	}

	protected override string _GetTemplateForLabelRightArms()
	{
		return "右臂";
	}

	protected override string _GetTemplateForLabelRightLeg()
	{
		return "右腿";
	}

	protected override string _GetTemplateForLabelRightLegs()
	{
		return "右腿";
	}

	protected override string _GetTemplateForLabelRun()
	{
		return "奔跑";
	}

	protected override string _GetTemplateForLabelRunAnimations()
	{
		return "奔跑動畫";
	}

	protected override string _GetTemplateForLabelScale()
	{
		return "比例";
	}

	protected override string _GetTemplateForLabelShirts()
	{
		return "襯衫";
	}

	protected override string _GetTemplateForLabelShoulderAccessories()
	{
		return "肩膀飾品";
	}

	protected override string _GetTemplateForLabelShoulders()
	{
		return "肩膀";
	}

	protected override string _GetTemplateForLabelSkinTone()
	{
		return "膚色";
	}

	protected override string _GetTemplateForLabelSwim()
	{
		return "游泳";
	}

	protected override string _GetTemplateForLabelSwimAnimations()
	{
		return "游泳動畫";
	}

	protected override string _GetTemplateForLabelSwitchAvatarType()
	{
		return "在經典 R6 虛擬人偶與更有表現力的新一代 R15 虛擬人偶之間切換";
	}

	protected override string _GetTemplateForLabelTorso()
	{
		return "軀幹";
	}

	protected override string _GetTemplateForLabelTorsos()
	{
		return "軀幹";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "T 恤";
	}

	protected override string _GetTemplateForLabelWaist()
	{
		return "腰部";
	}

	protected override string _GetTemplateForLabelWaistAccessories()
	{
		return "腰部飾品";
	}

	protected override string _GetTemplateForLabelWalk()
	{
		return "步行";
	}

	protected override string _GetTemplateForLabelWalkAnimations()
	{
		return "步行動畫";
	}

	protected override string _GetTemplateForLabelWidth()
	{
		return "寬度";
	}

	protected override string _GetTemplateForLabelYourEmotes()
	{
		return "您的動作";
	}

	protected override string _GetTemplateForMessageAccessoriesChange()
	{
		return "確定覆蓋目前的外觀？";
	}

	protected override string _GetTemplateForMessageChooseEmote()
	{
		return "選擇動作";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlot()
	{
		return "選擇欄位";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlotOrEmote()
	{
		return "選擇欄位或動作";
	}

	protected override string _GetTemplateForMessageDefaultClothing()
	{
		return "已在您的虛擬人偶套用預設服裝，請自行選擇要穿上的服裝。";
	}

	/// <summary>
	/// Key: "Message.DeleteOutfit"
	/// English String: "Are you sure you want to delete this {outfitType}?"
	/// </summary>
	public override string MessageDeleteOutfit(string outfitType)
	{
		return $"確定刪除此{outfitType}？";
	}

	protected override string _GetTemplateForMessageDeleteOutfit()
	{
		return "確定刪除此{outfitType}？";
	}

	protected override string _GetTemplateForMessageDeleteThisCostume()
	{
		return "確定刪除此裝扮？";
	}

	protected override string _GetTemplateForMessageDeleteThisOutfit()
	{
		return "確定刪除此服飾？";
	}

	protected override string _GetTemplateForMessageEmotesInstructions()
	{
		return "前往「動畫」>「動作」>「裝備動作」來裝備動作。";
	}

	protected override string _GetTemplateForMessageEmptyAssetList()
	{
		return "您沒有素材。";
	}

	/// <summary>
	/// Key: "Message.EmptyListForItem"
	/// The user tries to load a list of some item but they see nothing because they don't own anything of that type.
	/// English String: "You don't have this item: {itemType}"
	/// </summary>
	public override string MessageEmptyListForItem(string itemType)
	{
		return $"您沒有{itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListForItem()
	{
		return "您沒有{itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListOfCostumes()
	{
		return "您沒有任何裝扮。請試著創作一些吧！";
	}

	protected override string _GetTemplateForMessageEmptyListOfOutfits()
	{
		return "您沒有任何服飾，請嘗試創作服飾吧！";
	}

	protected override string _GetTemplateForMessageEmptyRecentItems()
	{
		return "沒有最近使用的道具。";
	}

	protected override string _GetTemplateForMessageErrorCreateCostume()
	{
		return "無法創作裝扮，請稍後再試。";
	}

	protected override string _GetTemplateForMessageErrorCreateOutfit()
	{
		return "無法創作服飾，請稍後再試。";
	}

	protected override string _GetTemplateForMessageErrorDeleteEmote()
	{
		return "無法刪除動作。";
	}

	protected override string _GetTemplateForMessageErrorEquipEmote()
	{
		return "無法裝上動作，請稍後再試。";
	}

	protected override string _GetTemplateForMessageErrorLoadCostume()
	{
		return "無法載入裝扮。";
	}

	protected override string _GetTemplateForMessageErrorLoadEmotes()
	{
		return "無法載入動作。";
	}

	protected override string _GetTemplateForMessageErrorLoadOutfits()
	{
		return "無法載入服飾。";
	}

	protected override string _GetTemplateForMessageErrorOutfitName()
	{
		return "名稱可含有字母、數字和空格。";
	}

	protected override string _GetTemplateForMessageErrorRenameCostume()
	{
		return "無法為裝扮更名。";
	}

	protected override string _GetTemplateForMessageErrorRenameOutfit()
	{
		return "無法為服飾更名。";
	}

	protected override string _GetTemplateForMessageErrorUnequipEmote()
	{
		return "無法卸下動作。";
	}

	protected override string _GetTemplateForMessageErrorUpdateCostume()
	{
		return "無法更新裝扮，請稍後再試。";
	}

	protected override string _GetTemplateForMessageErrorUpdateEmote()
	{
		return "更新動作欄位失敗，請稍後再試。";
	}

	protected override string _GetTemplateForMessageErrorUpdateOutfit()
	{
		return "無法更新服飾，請稍後再試。";
	}

	protected override string _GetTemplateForMessageErrorUpdateWorn()
	{
		return "更新已穿戴道具時發生錯誤。";
	}

	protected override string _GetTemplateForMessageErrorWearCostume()
	{
		return "無法穿上此裝扮。";
	}

	protected override string _GetTemplateForMessageErrorWearOutfit()
	{
		return "無法穿上此服飾。";
	}

	protected override string _GetTemplateForMessageFailedDeleteCostume()
	{
		return "無法刪除此裝扮。";
	}

	protected override string _GetTemplateForMessageFailedDeleteEmote()
	{
		return "無法刪除動作。";
	}

	protected override string _GetTemplateForMessageFailedDeleteOutfit()
	{
		return "無法刪除此服飾。";
	}

	protected override string _GetTemplateForMessageFailedLoadAssets()
	{
		return "無法載入素材清單。";
	}

	protected override string _GetTemplateForMessageFailedLoadRecent()
	{
		return "無法載入最近使用過的道具。";
	}

	protected override string _GetTemplateForMessageFailedUpdateBodyColor()
	{
		return "無法更新膚色。";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedCostume()
	{
		return "您嘗試更新的裝扮已不存在。";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedOutfit()
	{
		return "您嘗試更新的服裝已不存在。";
	}

	protected override string _GetTemplateForMessageFailedUpdateScales()
	{
		return "無法更新比例。";
	}

	protected override string _GetTemplateForMessageFailedUpdateType()
	{
		return "無法更新虛擬人偶類型。";
	}

	protected override string _GetTemplateForMessageFailedWearPackage()
	{
		return "無法穿戴套裝。";
	}

	protected override string _GetTemplateForMessageHatLimitTooltip()
	{
		return "您最多可以戴上 3 頂帽子";
	}

	protected override string _GetTemplateForMessageInvalidOutfitName()
	{
		return "名稱必須適當，並少於 200 個字元。";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "正在載入…";
	}

	/// <summary>
	/// Key: "Message.MissingItemsFromOutfit"
	/// User cannot wear an outfit because they are missing or have deleted some of the items that were part of that outfit.
	/// English String: "Number of items that you don't own in this outfit: {number}"
	/// </summary>
	public override string MessageMissingItemsFromOutfit(string number)
	{
		return $"您在此服飾缺少的道具數量：{number}";
	}

	protected override string _GetTemplateForMessageMissingItemsFromOutfit()
	{
		return "您在此服飾缺少的道具數量：{number}";
	}

	protected override string _GetTemplateForMessagePageUnavailable()
	{
		return "暫時無法使用虛擬人偶頁面。";
	}

	protected override string _GetTemplateForMessagePresetCostumesDelay()
	{
		return "注意：我們正在進行更新，所以您的裝扮可能幾分鐘後才會出現。請稍後再回來！";
	}

	protected override string _GetTemplateForMessageReachedMaxCostumes()
	{
		return "您的裝扮數量已達上限。";
	}

	protected override string _GetTemplateForMessageReachedMaxOutfits()
	{
		return "您的服飾數量已達上限。";
	}

	protected override string _GetTemplateForMessageRedirectAvatarSettings()
	{
		return "您可以從 Roblox Studio 專案變更虛擬人偶設定，請在 Roblox Studio 前往首頁 > 遊戲設定 > 虛擬人偶";
	}

	protected override string _GetTemplateForMessageRedrawFloodchecked()
	{
		return "您重繪虛擬人偶次數過多，請稍後再試。";
	}

	protected override string _GetTemplateForMessageRedrawThumbnailFailed()
	{
		return "無法重繪縮圖。";
	}

	protected override string _GetTemplateForMessageSelectEnableScaling()
	{
		return "縮放僅適用於 R15 虛擬人偶";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForMessageSuccessCreateCostume()
	{
		return "已創作裝扮";
	}

	protected override string _GetTemplateForMessageSuccessCreateOutfit()
	{
		return "已創作服飾";
	}

	protected override string _GetTemplateForMessageSuccessDeleteCostume()
	{
		return "裝扮已刪除";
	}

	protected override string _GetTemplateForMessageSuccessDeleteOutfit()
	{
		return "已刪除此服飾";
	}

	protected override string _GetTemplateForMessageSuccessEquipEmote()
	{
		return "已裝上動作";
	}

	protected override string _GetTemplateForMessageSuccessRenameCostume()
	{
		return "已為裝扮更名";
	}

	protected override string _GetTemplateForMessageSuccessRenameOutfit()
	{
		return "已為服飾更名";
	}

	protected override string _GetTemplateForMessageSuccessSavedAccessories()
	{
		return "已儲存飾品";
	}

	protected override string _GetTemplateForMessageSuccessUnequipEmote()
	{
		return "已卸下動作";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedCostume()
	{
		return "裝扮已更新";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedOutfit()
	{
		return "已更新服飾";
	}

	protected override string _GetTemplateForMessageSuccessWoreCostume()
	{
		return "已成功穿戴裝扮";
	}

	protected override string _GetTemplateForMessageSuccessWoreOutfit()
	{
		return "已成功穿戴服飾";
	}

	/// <summary>
	/// Key: "Message.UpdateOutfit"
	/// English String: "Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateOutfit(string outfitType1, string outfitType2)
	{
		return $"您要更新此{outfitType1}嗎？此動作會將{outfitType2}覆蓋成您的虛擬人偶目前的外觀。";
	}

	protected override string _GetTemplateForMessageUpdateOutfit()
	{
		return "您要更新此{outfitType1}嗎？此動作會將{outfitType2}覆蓋成您的虛擬人偶目前的外觀。";
	}

	protected override string _GetTemplateForMessageUpdateThisCostume()
	{
		return "您要更新此裝扮嗎？此動作會將裝扮覆蓋成您的虛擬人偶目前的外觀。";
	}

	protected override string _GetTemplateForMessageUpdateThisOutfit()
	{
		return "您要更新此服飾嗎？此動作會將服飾覆蓋成您的虛擬人偶目前的外觀。";
	}

	protected override string _GetTemplateForMessageWarning()
	{
		return "警告";
	}
}
