namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides AvatarResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AvatarResources_ja_jp : AvatarResources_en_us, IAvatarResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Advanced"
	/// Click Advanced to get the advanced options
	/// English String: "Advanced"
	/// </summary>
	public override string ActionAdvanced => "詳細";

	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item to customize the user's avatar.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "買う";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "閉じる";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "作成";

	/// <summary>
	/// Key: "Action.CreateNewOutfit"
	/// Button to create new outfit
	/// English String: "Create"
	/// </summary>
	public override string ActionCreateNewOutfit => "作成";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "削除";

	/// <summary>
	/// Key: "Action.Done"
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "完了";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy get an item for free to customize the user's avatar.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "ゲットする";

	/// <summary>
	/// Key: "Action.GetMore"
	/// A call to action for the user to buy more clothes from the Catalog page. This could improve how their avatar looks.
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "さらにゲット";

	/// <summary>
	/// Key: "Action.OpenRobloxApp"
	/// English String: "Open Roblox App"
	/// </summary>
	public override string ActionOpenRobloxApp => "Robloxアプリを起動する";

	/// <summary>
	/// Key: "Action.Redraw"
	/// Redraw the avatar on the screen
	/// English String: "Redraw"
	/// </summary>
	public override string ActionRedraw => "リドローする";

	/// <summary>
	/// Key: "Action.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string ActionRename => "名前を変更する";

	/// <summary>
	/// Key: "Action.RenameOutfit"
	/// Button to rename outfit
	/// English String: "Rename"
	/// </summary>
	public override string ActionRenameOutfit => "名前を変更する";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// See all clothing that user can buy
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "すべて見る";

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
	public override string ActionUpdate => "アップデート";

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
	public override string DescriptionAvatarEditorUpsell => "外見を変更するには、アプリのアバターエディタを使用する必要があります。";

	/// <summary>
	/// Key: "Description.CreateNewCostume"
	/// A costume will be created from your avatar's current appearance.
	/// English String: "A costume will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewCostume => "コスチュームは、アバターの現在の外見から作れます。";

	/// <summary>
	/// Key: "Description.CreateNewOutfit"
	/// An outfit will be created from your avatar's current appearance.
	/// English String: "An outfit will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewOutfit => "服装は、アバターの現在の外見から作成できます。";

	/// <summary>
	/// Key: "Description.RenameCostume"
	/// Choose a new name for your costume.
	/// English String: "Choose a new name for your costume."
	/// </summary>
	public override string DescriptionRenameCostume => "コスチュームの新しい名前を選んでください。";

	/// <summary>
	/// Key: "Description.RenameOutfit"
	/// Choose a new name for your outfit.
	/// English String: "Choose a new name for your outfit."
	/// </summary>
	public override string DescriptionRenameOutfit => "服装の新しい名前を選んでください。";

	/// <summary>
	/// Key: "Heading.Accessories"
	/// English String: "Accessories"
	/// </summary>
	public override string HeadingAccessories => "アクセサリ";

	/// <summary>
	/// Key: "Heading.AccessoriesChange"
	/// English String: "Accessories Change"
	/// </summary>
	public override string HeadingAccessoriesChange => "アクセサリ変更";

	/// <summary>
	/// Key: "Heading.AdvancedOptions"
	/// English String: "Advanced Options"
	/// </summary>
	public override string HeadingAdvancedOptions => "詳細オプション";

	/// <summary>
	/// Key: "Heading.All"
	/// All avatar modification types
	/// English String: "All"
	/// </summary>
	public override string HeadingAll => "すべて";

	/// <summary>
	/// Key: "Heading.Animations"
	/// English String: "Animations"
	/// </summary>
	public override string HeadingAnimations => "アニメーション";

	/// <summary>
	/// Key: "Heading.Appearance"
	/// English String: "Appearance"
	/// </summary>
	public override string HeadingAppearance => "外見";

	/// <summary>
	/// Key: "Heading.AvatarPageTitle"
	/// Page title for the Avatar page. On this page, the user can modify how they look.
	/// English String: "Avatar Editor"
	/// </summary>
	public override string HeadingAvatarPageTitle => "アバターエディタ";

	/// <summary>
	/// Key: "Heading.Body"
	/// English String: "Body"
	/// </summary>
	public override string HeadingBody => "ボディ";

	/// <summary>
	/// Key: "Heading.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string HeadingBodyParts => "ボディパーツ";

	/// <summary>
	/// Key: "Heading.Clothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingClothing => "コスチューム";

	/// <summary>
	/// Key: "Heading.Costumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Costumes"
	/// </summary>
	public override string HeadingCostumes => "コスチューム";

	/// <summary>
	/// Key: "Heading.CreateNewCostume"
	/// NOTE: Costume is a more whimsical word choice for outfit. Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Create New Costume"
	/// </summary>
	public override string HeadingCreateNewCostume => "コスチュームを新規作成する";

	/// <summary>
	/// Key: "Heading.CreateNewOutfit"
	/// English String: "Create New Outfit"
	/// </summary>
	public override string HeadingCreateNewOutfit => "新しい服装を作成する";

	/// <summary>
	/// Key: "Heading.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string HeadingDelete => "削除";

	/// <summary>
	/// Key: "Heading.DeleteCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Delete Costume"
	/// </summary>
	public override string HeadingDeleteCostume => "コスチュームの削除";

	/// <summary>
	/// Key: "Heading.DeleteOutfit"
	/// English String: "Delete Outfit"
	/// </summary>
	public override string HeadingDeleteOutfit => "服装の削除";

	/// <summary>
	/// Key: "Heading.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string HeadingEmotes => "エモート";

	/// <summary>
	/// Key: "Heading.EquipEmotes"
	/// English String: "Equip Emotes"
	/// </summary>
	public override string HeadingEquipEmotes => "エモートを装備";

	/// <summary>
	/// Key: "Heading.Outfits"
	/// English String: "Outfits"
	/// </summary>
	public override string HeadingOutfits => "服装";

	/// <summary>
	/// Key: "Heading.Packages"
	/// English String: "Packages"
	/// </summary>
	public override string HeadingPackages => "パッケージ";

	/// <summary>
	/// Key: "Heading.Recent"
	/// English String: "Recent"
	/// </summary>
	public override string HeadingRecent => "最近";

	/// <summary>
	/// Key: "Heading.Recommended"
	/// See recommended clothing for your avatar
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommended => "おすすめ";

	/// <summary>
	/// Key: "Heading.RenameCostume"
	/// English String: "Rename Costume"
	/// </summary>
	public override string HeadingRenameCostume => "コスチューム名を変更";

	/// <summary>
	/// Key: "Heading.RenameOutfit"
	/// English String: "Rename Outfit"
	/// </summary>
	public override string HeadingRenameOutfit => "服装名を変更する";

	/// <summary>
	/// Key: "Heading.Scaling"
	/// English String: "Scaling"
	/// </summary>
	public override string HeadingScaling => "スケールする";

	/// <summary>
	/// Key: "Heading.SkinToneBodyParts"
	/// English String: "Skin Tone by Body Parts"
	/// </summary>
	public override string HeadingSkinToneBodyParts => "ボディパーツごとのスキンのトーン";

	/// <summary>
	/// Key: "Heading.Update"
	/// English String: "Update"
	/// </summary>
	public override string HeadingUpdate => "アップデート";

	/// <summary>
	/// Key: "Heading.UpdateCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Update Costume"
	/// </summary>
	public override string HeadingUpdateCostume => "コスチュームのアップデート";

	/// <summary>
	/// Key: "Heading.UpdateOutfit"
	/// English String: "Update Outfit"
	/// </summary>
	public override string HeadingUpdateOutfit => "服装のアップデート";

	/// <summary>
	/// Key: "Label.All"
	/// All body parts. This label will allow for body parts to change color
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "すべて";

	/// <summary>
	/// Key: "Label.AskIfLoadingCorrectly"
	/// Avatar isn't loading correctly?
	/// English String: "Avatar isn't loading correctly?"
	/// </summary>
	public override string LabelAskIfLoadingCorrectly => "アバターが正常に読み込まれていません。";

	/// <summary>
	/// Key: "Label.AssetIDPlaceholder"
	/// This refers to the Asset ID which is a technical word for the Identification Number of an item or asset.
	/// English String: "Asset ID"
	/// </summary>
	public override string LabelAssetIDPlaceholder => "アセットID";

	/// <summary>
	/// Key: "Label.Back"
	/// English String: "Back"
	/// </summary>
	public override string LabelBack => "背面";

	/// <summary>
	/// Key: "Label.BackAccessories"
	/// English String: "Back Accessories"
	/// </summary>
	public override string LabelBackAccessories => "背面用アクセサリ";

	/// <summary>
	/// Key: "Label.BodyType"
	/// English String: "Body Type"
	/// </summary>
	public override string LabelBodyType => "ボディタイプ";

	/// <summary>
	/// Key: "Label.Climb"
	/// English String: "Climb"
	/// </summary>
	public override string LabelClimb => "登る";

	/// <summary>
	/// Key: "Label.ClimbAnimations"
	/// English String: "Climb Animations"
	/// </summary>
	public override string LabelClimbAnimations => "登るアニメーション";

	/// <summary>
	/// Key: "Label.Clothes"
	/// English String: "Clothes"
	/// </summary>
	public override string LabelClothes => "洋服";

	/// <summary>
	/// Key: "Label.Costume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Costume"
	/// </summary>
	public override string LabelCostume => "コスチューム";

	/// <summary>
	/// Key: "label.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string labelEmotes => "エモート";

	/// <summary>
	/// Key: "Label.Equip"
	/// English String: "Equip"
	/// </summary>
	public override string LabelEquip => "装備";

	/// <summary>
	/// Key: "Label.ExploreCatalog"
	/// This text entices users to shop for more things to wear on their avatar
	/// English String: "Explore the catalog to find more clothes!"
	/// </summary>
	public override string LabelExploreCatalog => "カタログをチェックして、洋服を見つけよう！";

	/// <summary>
	/// Key: "Label.Face"
	/// English String: "Face"
	/// </summary>
	public override string LabelFace => "顔";

	/// <summary>
	/// Key: "Label.FaceAccessories"
	/// English String: "Face Accessories"
	/// </summary>
	public override string LabelFaceAccessories => "顔用アクセサリ";

	/// <summary>
	/// Key: "Label.Faces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "顔";

	/// <summary>
	/// Key: "Label.Fall"
	/// English String: "Fall"
	/// </summary>
	public override string LabelFall => "落下";

	/// <summary>
	/// Key: "Label.FallAnimations"
	/// English String: "Fall Animations"
	/// </summary>
	public override string LabelFallAnimations => "落下アニメーション";

	/// <summary>
	/// Key: "Label.Free"
	/// Text label for recommended items
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "無料";

	/// <summary>
	/// Key: "Label.Front"
	/// English String: "Front"
	/// </summary>
	public override string LabelFront => "正面";

	/// <summary>
	/// Key: "Label.FrontAccessories"
	/// English String: "Front Accessories"
	/// </summary>
	public override string LabelFrontAccessories => "正面用アクセサリ";

	/// <summary>
	/// Key: "Label.Gear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "ギア";

	/// <summary>
	/// Key: "Label.Hair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelHair => "髪";

	/// <summary>
	/// Key: "Label.HairAccessories"
	/// English String: "Hair Accessories"
	/// </summary>
	public override string LabelHairAccessories => "髪用アクセサリ";

	/// <summary>
	/// Key: "Label.Hat"
	/// English String: "Hat"
	/// </summary>
	public override string LabelHat => "帽子";

	/// <summary>
	/// Key: "Label.HatAccessories"
	/// English String: "Hat Accessories"
	/// </summary>
	public override string LabelHatAccessories => "帽子用アクセサリ";

	/// <summary>
	/// Key: "Label.Head"
	/// English String: "Head"
	/// </summary>
	public override string LabelHead => "頭";

	/// <summary>
	/// Key: "Label.Heads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "頭";

	/// <summary>
	/// Key: "Label.Height"
	/// English String: "Height"
	/// </summary>
	public override string LabelHeight => "身長";

	/// <summary>
	/// Key: "Label.Idle"
	/// English String: "Idle"
	/// </summary>
	public override string LabelIdle => "待機";

	/// <summary>
	/// Key: "Label.IdleAnimations"
	/// English String: "Idle Animations"
	/// </summary>
	public override string LabelIdleAnimations => "待機アニメーション";

	/// <summary>
	/// Key: "Label.Jump"
	/// English String: "Jump"
	/// </summary>
	public override string LabelJump => "ジャンプ";

	/// <summary>
	/// Key: "Label.JumpAnimations"
	/// English String: "Jump Animations"
	/// </summary>
	public override string LabelJumpAnimations => "ジャンプアニメーション";

	/// <summary>
	/// Key: "Label.LeftArm"
	/// English String: "Left Arm"
	/// </summary>
	public override string LabelLeftArm => "左腕";

	/// <summary>
	/// Key: "Label.LeftArms"
	/// English String: "Left Arms"
	/// </summary>
	public override string LabelLeftArms => "左腕";

	/// <summary>
	/// Key: "Label.LeftLeg"
	/// English String: "Left Leg"
	/// </summary>
	public override string LabelLeftLeg => "左脚";

	/// <summary>
	/// Key: "Label.LeftLegs"
	/// English String: "Left Legs"
	/// </summary>
	public override string LabelLeftLegs => "左脚";

	/// <summary>
	/// Key: "Label.MyCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "My Costumes"
	/// </summary>
	public override string LabelMyCostumes => "マイコスチューム";

	/// <summary>
	/// Key: "Label.NamePlaceholderCostume"
	/// English String: "Name your costume"
	/// </summary>
	public override string LabelNamePlaceholderCostume => "コスチュームに名前を付ける";

	/// <summary>
	/// Key: "Label.NamePlaceholderOutfit"
	/// English String: "Name your outfit"
	/// </summary>
	public override string LabelNamePlaceholderOutfit => "服装に名前を付ける";

	/// <summary>
	/// Key: "Label.Neck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelNeck => "首";

	/// <summary>
	/// Key: "Label.NeckAccessories"
	/// English String: "Neck Accessories"
	/// </summary>
	public override string LabelNeckAccessories => "首用アクセサリ";

	/// <summary>
	/// Key: "Label.NoResellers"
	/// Text label for recommended items
	/// English String: "No resellers"
	/// </summary>
	public override string LabelNoResellers => "再販者なし";

	/// <summary>
	/// Key: "Label.OffSale"
	/// Text label for recommended items
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "非売品";

	/// <summary>
	/// Key: "Label.Outfit"
	/// English String: "Outfit"
	/// </summary>
	public override string LabelOutfit => "服装";

	/// <summary>
	/// Key: "Label.Pants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "パンツ";

	/// <summary>
	/// Key: "Label.Parts"
	/// English String: "Parts"
	/// </summary>
	public override string LabelParts => "パーツ";

	/// <summary>
	/// Key: "Label.PresetCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Preset Costumes"
	/// </summary>
	public override string LabelPresetCostumes => "プリセットコスチューム";

	/// <summary>
	/// Key: "Label.Proportions"
	/// English String: "Proportions"
	/// </summary>
	public override string LabelProportions => "プロポーション";

	/// <summary>
	/// Key: "Label.RedrawUnavailable"
	/// Avatar redraw is unavailable
	/// English String: "Avatar redraw is unavailable."
	/// </summary>
	public override string LabelRedrawUnavailable => "アバターのリドローは利用できません。";

	/// <summary>
	/// Key: "Label.RightArm"
	/// English String: "Right Arm"
	/// </summary>
	public override string LabelRightArm => "右腕";

	/// <summary>
	/// Key: "Label.RightArms"
	/// English String: "Right Arms"
	/// </summary>
	public override string LabelRightArms => "右腕";

	/// <summary>
	/// Key: "Label.RightLeg"
	/// English String: "Right Leg"
	/// </summary>
	public override string LabelRightLeg => "右脚";

	/// <summary>
	/// Key: "Label.RightLegs"
	/// English String: "Right Legs"
	/// </summary>
	public override string LabelRightLegs => "右脚";

	/// <summary>
	/// Key: "Label.Run"
	/// English String: "Run"
	/// </summary>
	public override string LabelRun => "走る";

	/// <summary>
	/// Key: "Label.RunAnimations"
	/// English String: "Run Animations"
	/// </summary>
	public override string LabelRunAnimations => "走るアニメーション";

	/// <summary>
	/// Key: "Label.Scale"
	/// English String: "Scale"
	/// </summary>
	public override string LabelScale => "スケール";

	/// <summary>
	/// Key: "Label.Shirts"
	/// English String: "Shirts"
	/// </summary>
	public override string LabelShirts => "シャツ";

	/// <summary>
	/// Key: "Label.ShoulderAccessories"
	/// English String: "Shoulder Accessories"
	/// </summary>
	public override string LabelShoulderAccessories => "肩用アクセサリ";

	/// <summary>
	/// Key: "Label.Shoulders"
	/// English String: "Shoulders"
	/// </summary>
	public override string LabelShoulders => "肩";

	/// <summary>
	/// Key: "Label.SkinTone"
	/// English String: "Skin Tone"
	/// </summary>
	public override string LabelSkinTone => "スキンのトーン";

	/// <summary>
	/// Key: "Label.Swim"
	/// English String: "Swim"
	/// </summary>
	public override string LabelSwim => "泳ぐ";

	/// <summary>
	/// Key: "Label.SwimAnimations"
	/// English String: "Swim Animations"
	/// </summary>
	public override string LabelSwimAnimations => "泳ぐアニメーション";

	/// <summary>
	/// Key: "Label.SwitchAvatarType"
	/// User is able to increase the number of joints in their avatar from 6 to 15. R15 moves better. See http://roblox.wikia.com/wiki/R15
	/// English String: "Switch between classic R6 avatar and more expressive next generation R15 avatar"
	/// </summary>
	public override string LabelSwitchAvatarType => "クラシックR6アバターから次世代のR15アバターまで、自由に切り替えよう。";

	/// <summary>
	/// Key: "Label.Torso"
	/// English String: "Torso"
	/// </summary>
	public override string LabelTorso => "胴体";

	/// <summary>
	/// Key: "Label.Torsos"
	/// English String: "Torsos"
	/// </summary>
	public override string LabelTorsos => "胴体";

	/// <summary>
	/// Key: "Label.TShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "Tシャツ";

	/// <summary>
	/// Key: "Label.Waist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelWaist => "腰";

	/// <summary>
	/// Key: "Label.WaistAccessories"
	/// English String: "Waist Accessories"
	/// </summary>
	public override string LabelWaistAccessories => "腰用アクセサリ";

	/// <summary>
	/// Key: "Label.Walk"
	/// English String: "Walk"
	/// </summary>
	public override string LabelWalk => "歩く";

	/// <summary>
	/// Key: "Label.WalkAnimations"
	/// English String: "Walk Animations"
	/// </summary>
	public override string LabelWalkAnimations => "歩くアニメーション";

	/// <summary>
	/// Key: "Label.Width"
	/// English String: "Width"
	/// </summary>
	public override string LabelWidth => "横幅";

	/// <summary>
	/// Key: "Label.YourEmotes"
	/// English String: "Your Emotes"
	/// </summary>
	public override string LabelYourEmotes => "自分のエモート";

	/// <summary>
	/// Key: "Message.AccessoriesChange"
	/// English String: "Are you sure you want to override your current look?"
	/// </summary>
	public override string MessageAccessoriesChange => "現在の外見を上書きしてよろしいですか？";

	/// <summary>
	/// Key: "Message.ChooseEmote"
	/// English String: "Choose an Emote"
	/// </summary>
	public override string MessageChooseEmote => "エモートを選ぶ";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlot"
	/// English String: "Choose a slot"
	/// </summary>
	public override string MessageChooseEmoteSlot => "スロットを選ぶ";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlotOrEmote"
	/// English String: "Choose a slot or an Emote"
	/// </summary>
	public override string MessageChooseEmoteSlotOrEmote => "スロットかエモートを選ぶ";

	/// <summary>
	/// Key: "Message.DefaultClothing"
	/// Encourage user to choose their own clothes.
	/// English String: "Default clothing has been applied to your avatar - wear something from your clothing."
	/// </summary>
	public override string MessageDefaultClothing => "アバターにデフォルトのコスチュームが適用されています - 持っているコスチュームを装備してみましょう。";

	/// <summary>
	/// Key: "Message.DeleteThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Are you sure you want to delete this costume?"
	/// </summary>
	public override string MessageDeleteThisCostume => "このコスチュームを削除してよろしいですか？";

	/// <summary>
	/// Key: "Message.DeleteThisOutfit"
	/// English String: "Are you sure you want to delete this outfit?"
	/// </summary>
	public override string MessageDeleteThisOutfit => "この服装を削除してよろしいですか？";

	/// <summary>
	/// Key: "Message.EmotesInstructions"
	/// The instructions describe the navigation flow within the Avatar Editor to equip an emote.
	/// English String: "Go to \"Animations\" &gt; \"Emotes\" &gt; \"Equip Emotes\" to equip an emote."
	/// </summary>
	public override string MessageEmotesInstructions => "エモートをつけるには、 「アニメーション」 > 「エモート」> 「エモートを装備」 へ行って下さい。";

	/// <summary>
	/// Key: "Message.EmptyAssetList"
	/// User is seeing no assets on this page because they don't have any.
	/// English String: "You don't have any."
	/// </summary>
	public override string MessageEmptyAssetList => "持っていません。";

	/// <summary>
	/// Key: "Message.EmptyListOfCostumes"
	/// The user is viewing an empty list of costumes to choose from. The application tells the user that they can create an costume.
	/// English String: "You don't have any costumes. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfCostumes => "コスチュームがありません。作ってみましょう！";

	/// <summary>
	/// Key: "Message.EmptyListOfOutfits"
	/// The user is viewing an empty list of outfits to choose from. The application tells the user that they can create an outfit.
	/// English String: "You don't have any outfits. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfOutfits => "服装がありません。作ってみましょう！";

	/// <summary>
	/// Key: "Message.EmptyRecentItems"
	/// English String: "You don't have any recent items."
	/// </summary>
	public override string MessageEmptyRecentItems => "最近のアイテムがありません。";

	/// <summary>
	/// Key: "Message.ErrorCreateCostume"
	/// English String: "Unable to create costume, try again later."
	/// </summary>
	public override string MessageErrorCreateCostume => "コスチュームを作れません。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.ErrorCreateOutfit"
	/// English String: "Unable to create outfit, try again later."
	/// </summary>
	public override string MessageErrorCreateOutfit => "服装を作成できません。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.ErrorDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageErrorDeleteEmote => "エモートを削除できませんでした。";

	/// <summary>
	/// Key: "Message.ErrorEquipEmote"
	/// English String: "Failed to equip emote, please try again later."
	/// </summary>
	public override string MessageErrorEquipEmote => "エモートを装備できませんでした。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.ErrorLoadCostume"
	/// English String: "Failed to load costume."
	/// </summary>
	public override string MessageErrorLoadCostume => "コスチュームを読み込めませんでした。";

	/// <summary>
	/// Key: "Message.ErrorLoadEmotes"
	/// English String: "Failed to load emotes."
	/// </summary>
	public override string MessageErrorLoadEmotes => "エモートを読み込めませんでした。";

	/// <summary>
	/// Key: "Message.ErrorLoadOutfits"
	/// English String: "Failed to load outfits."
	/// </summary>
	public override string MessageErrorLoadOutfits => "服装を読み込めませんでした。";

	/// <summary>
	/// Key: "Message.ErrorOutfitName"
	/// English String: "Name can contain letters, numbers, and spaces."
	/// </summary>
	public override string MessageErrorOutfitName => "名前に使用できるのは、大小アルファベット、半角英数字、およびスペースだけです。";

	/// <summary>
	/// Key: "Message.ErrorRenameCostume"
	/// English String: "Failed to rename costume."
	/// </summary>
	public override string MessageErrorRenameCostume => "コスチューム名を変更できませんでした。";

	/// <summary>
	/// Key: "Message.ErrorRenameOutfit"
	/// English String: "Failed to rename outfit."
	/// </summary>
	public override string MessageErrorRenameOutfit => "服装名を変更できませんでした。";

	/// <summary>
	/// Key: "Message.ErrorUnequipEmote"
	/// English String: "Failed to unequip emote."
	/// </summary>
	public override string MessageErrorUnequipEmote => "エモートを外せませんでした。";

	/// <summary>
	/// Key: "Message.ErrorUpdateCostume"
	/// English String: "Costume update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateCostume => "コスチュームをアップデートできませんでした。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.ErrorUpdateEmote"
	/// English String: "Updating emote slot failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateEmote => "エモートスロットのアップデートができませんでした。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.ErrorUpdateOutfit"
	/// English String: "Outfit update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateOutfit => "服装をアップデートできません。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.ErrorUpdateWorn"
	/// There was an error updating items that the user is already wearing.
	/// English String: "Error while updating worn items."
	/// </summary>
	public override string MessageErrorUpdateWorn => "装備中のアイテムを更新中にエラーが発生しました。";

	/// <summary>
	/// Key: "Message.ErrorWearCostume"
	/// English String: "Failed to wear costume."
	/// </summary>
	public override string MessageErrorWearCostume => "コスチュームを装備できませんでした。";

	/// <summary>
	/// Key: "Message.ErrorWearOutfit"
	/// English String: "Failed to wear outfit."
	/// </summary>
	public override string MessageErrorWearOutfit => "服装を装備できませんでした。";

	/// <summary>
	/// Key: "Message.FailedDeleteCostume"
	/// English String: "Failed to delete costume."
	/// </summary>
	public override string MessageFailedDeleteCostume => "コスチュームを削除できませんでした。";

	/// <summary>
	/// Key: "Message.FailedDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageFailedDeleteEmote => "エモートを削除できませんでした。";

	/// <summary>
	/// Key: "Message.FailedDeleteOutfit"
	/// English String: "Failed to delete outfit."
	/// </summary>
	public override string MessageFailedDeleteOutfit => "服装を削除できませんでした。";

	/// <summary>
	/// Key: "Message.FailedLoadAssets"
	/// English String: "Failed to load assets list."
	/// </summary>
	public override string MessageFailedLoadAssets => "アセットリストを読み込めませんでした。";

	/// <summary>
	/// Key: "Message.FailedLoadRecent"
	/// English String: "Failed to load recent items."
	/// </summary>
	public override string MessageFailedLoadRecent => "最近のアイテムを読み込めませんでした。";

	/// <summary>
	/// Key: "Message.FailedUpdateBodyColor"
	/// English String: "Failed to update skin tone."
	/// </summary>
	public override string MessageFailedUpdateBodyColor => "スキンのトーンをアップデートできませんでした。";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedCostume"
	/// The user tried to update a deleted costume.
	/// English String: "The costume you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedCostume => "アップデートしようとしているコスチュームは、もう存在しません。";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedOutfit"
	/// The user tried to update a deleted outfit.
	/// English String: "The outfit you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedOutfit => "アップデートしようとしている服装は、もう存在しません。";

	/// <summary>
	/// Key: "Message.FailedUpdateScales"
	/// English String: "Failed to update scales."
	/// </summary>
	public override string MessageFailedUpdateScales => "スケールをアップデートできませんでした。";

	/// <summary>
	/// Key: "Message.FailedUpdateType"
	/// Failed to update the way the user's avatar is rendered.
	/// English String: "Failed to update avatar type."
	/// </summary>
	public override string MessageFailedUpdateType => "アバタータイプをアップデートできませんでした。";

	/// <summary>
	/// Key: "Message.FailedWearPackage"
	/// English String: "Failed to wear package."
	/// </summary>
	public override string MessageFailedWearPackage => "パッケージを装備できませんでした。";

	/// <summary>
	/// Key: "Message.HatLimitTooltip"
	/// English String: "You can wear up to 3 hats"
	/// </summary>
	public override string MessageHatLimitTooltip => "帽子は3つまで装備できます";

	/// <summary>
	/// Key: "Message.InvalidOutfitName"
	/// English String: "Name must be appropriate and less than 200 characters."
	/// </summary>
	public override string MessageInvalidOutfitName => "名前は、不適切な言葉が使用されておらず、200文字未満である必要があります。";

	/// <summary>
	/// Key: "Message.Loading"
	/// The user's avatar is loading
	/// English String: "Loading..."
	/// </summary>
	public override string MessageLoading => "読み込み中...";

	/// <summary>
	/// Key: "Message.PageUnavailable"
	/// English String: "The avatar page is temporarily unavailable."
	/// </summary>
	public override string MessagePageUnavailable => "アバターページは現在利用できません。";

	/// <summary>
	/// Key: "Message.PresetCostumesDelay"
	/// One-time message that appears to the user first time they visit the Preset Costumes tab. The delay is caused by initial migration.
	/// English String: "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!"
	/// </summary>
	public override string MessagePresetCostumesDelay => "ご注意: 現在ハウスキーピング作業を行っているため、すべてのコスチュームが表示されるまで数分かかる場合があります。しばらくしてからチェックしてみてください！";

	/// <summary>
	/// Key: "Message.ReachedMaxCostumes"
	/// English String: "You have reached the maximum number of costumes."
	/// </summary>
	public override string MessageReachedMaxCostumes => "コスチュームが最大数に到達しました。";

	/// <summary>
	/// Key: "Message.ReachedMaxOutfits"
	/// English String: "You have reached the maximum number of outfits."
	/// </summary>
	public override string MessageReachedMaxOutfits => "服装の最大数に到達しました。";

	/// <summary>
	/// Key: "Message.RedirectAvatarSettings"
	/// English String: "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home &gt; Game Settings &gt; Avatar"
	/// </summary>
	public override string MessageRedirectAvatarSettings => "Roblox Studioのプロジェクトからアバターの設定を変更できます。「ホーム」>「ゲーム設定」>「アバター」にアクセスしてください";

	/// <summary>
	/// Key: "Message.RedrawFloodchecked"
	/// English String: "You have redrawn your avatar too many times, please try again later."
	/// </summary>
	public override string MessageRedrawFloodchecked => "アバターのリドロー回数が多すぎます。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.RedrawThumbnailFailed"
	/// English String: "Failed to redraw thumbnail."
	/// </summary>
	public override string MessageRedrawThumbnailFailed => "サムネイルを変更できません。";

	/// <summary>
	/// Key: "Message.SelectEnableScaling"
	/// R15 is a proper noun
	/// English String: "Select R15 to enable scaling."
	/// </summary>
	public override string MessageSelectEnableScaling => "スケールを有効にするには、R15を選択しよう。";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "成功";

	/// <summary>
	/// Key: "Message.SuccessCreateCostume"
	/// English String: "Created costume"
	/// </summary>
	public override string MessageSuccessCreateCostume => "コスチュームを作成しました";

	/// <summary>
	/// Key: "Message.SuccessCreateOutfit"
	/// English String: "Created outfit"
	/// </summary>
	public override string MessageSuccessCreateOutfit => "服装を作成しました";

	/// <summary>
	/// Key: "Message.SuccessDeleteCostume"
	/// Deleted costume
	/// English String: "Deleted costume"
	/// </summary>
	public override string MessageSuccessDeleteCostume => "コスチュームを削除しました";

	/// <summary>
	/// Key: "Message.SuccessDeleteOutfit"
	/// English String: "Deleted outfit"
	/// </summary>
	public override string MessageSuccessDeleteOutfit => "服装を削除しました";

	/// <summary>
	/// Key: "Message.SuccessEquipEmote"
	/// English String: "Equipped Emote"
	/// </summary>
	public override string MessageSuccessEquipEmote => "エモートを装備しました";

	/// <summary>
	/// Key: "Message.SuccessRenameCostume"
	/// English String: "Renamed costume"
	/// </summary>
	public override string MessageSuccessRenameCostume => "コスチューム名を変更しました";

	/// <summary>
	/// Key: "Message.SuccessRenameOutfit"
	/// English String: "Renamed outfit"
	/// </summary>
	public override string MessageSuccessRenameOutfit => "服装名を変更しました";

	/// <summary>
	/// Key: "Message.SuccessSavedAccessories"
	/// English String: "Saved accessories"
	/// </summary>
	public override string MessageSuccessSavedAccessories => "アクセサリを保存しました";

	/// <summary>
	/// Key: "Message.SuccessUnequipEmote"
	/// English String: "Unequipped emote"
	/// </summary>
	public override string MessageSuccessUnequipEmote => "エモートを外しました。";

	/// <summary>
	/// Key: "Message.SuccessUpdatedCostume"
	/// English String: "Updated costume"
	/// </summary>
	public override string MessageSuccessUpdatedCostume => "コスチュームをアップデートしました";

	/// <summary>
	/// Key: "Message.SuccessUpdatedOutfit"
	/// English String: "Updated outfit"
	/// </summary>
	public override string MessageSuccessUpdatedOutfit => "服装をアップデートしました";

	/// <summary>
	/// Key: "Message.SuccessWoreCostume"
	/// English String: "Successfully wore costume"
	/// </summary>
	public override string MessageSuccessWoreCostume => "コスチュームをつけました";

	/// <summary>
	/// Key: "Message.SuccessWoreOutfit"
	/// English String: "Successfully wore outfit"
	/// </summary>
	public override string MessageSuccessWoreOutfit => "服をつけました";

	/// <summary>
	/// Key: "Message.UpdateThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisCostume => "このコスチュームをアップデートしますか？アップデートするとコスチュームがアバターの現在の外見で上書きされます。";

	/// <summary>
	/// Key: "Message.UpdateThisOutfit"
	/// English String: "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisOutfit => "この服装をアップデートしますか？アップデートすると服装がアバターの現在の外見で上書きされます。";

	/// <summary>
	/// Key: "Message.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string MessageWarning => "警告";

	public AvatarResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvanced()
	{
		return "詳細";
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "買う";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "閉じる";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "作成";
	}

	protected override string _GetTemplateForActionCreateNewOutfit()
	{
		return "作成";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "削除";
	}

	protected override string _GetTemplateForActionDone()
	{
		return "完了";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "ゲットする";
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "さらにゲット";
	}

	protected override string _GetTemplateForActionOpenRobloxApp()
	{
		return "Robloxアプリを起動する";
	}

	protected override string _GetTemplateForActionRedraw()
	{
		return "リドローする";
	}

	protected override string _GetTemplateForActionRename()
	{
		return "名前を変更する";
	}

	protected override string _GetTemplateForActionRenameOutfit()
	{
		return "名前を変更する";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "すべて見る";
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
		return "アップデート";
	}

	protected override string _GetTemplateForActionUserUnderstands()
	{
		return "OK";
	}

	protected override string _GetTemplateForDescriptionAvatarEditorUpsell()
	{
		return "外見を変更するには、アプリのアバターエディタを使用する必要があります。";
	}

	protected override string _GetTemplateForDescriptionCreateNewCostume()
	{
		return "コスチュームは、アバターの現在の外見から作れます。";
	}

	protected override string _GetTemplateForDescriptionCreateNewOutfit()
	{
		return "服装は、アバターの現在の外見から作成できます。";
	}

	protected override string _GetTemplateForDescriptionRenameCostume()
	{
		return "コスチュームの新しい名前を選んでください。";
	}

	protected override string _GetTemplateForDescriptionRenameOutfit()
	{
		return "服装の新しい名前を選んでください。";
	}

	protected override string _GetTemplateForHeadingAccessories()
	{
		return "アクセサリ";
	}

	protected override string _GetTemplateForHeadingAccessoriesChange()
	{
		return "アクセサリ変更";
	}

	protected override string _GetTemplateForHeadingAdvancedOptions()
	{
		return "詳細オプション";
	}

	protected override string _GetTemplateForHeadingAll()
	{
		return "すべて";
	}

	protected override string _GetTemplateForHeadingAnimations()
	{
		return "アニメーション";
	}

	protected override string _GetTemplateForHeadingAppearance()
	{
		return "外見";
	}

	protected override string _GetTemplateForHeadingAvatarPageTitle()
	{
		return "アバターエディタ";
	}

	protected override string _GetTemplateForHeadingBody()
	{
		return "ボディ";
	}

	protected override string _GetTemplateForHeadingBodyParts()
	{
		return "ボディパーツ";
	}

	protected override string _GetTemplateForHeadingClothing()
	{
		return "コスチューム";
	}

	protected override string _GetTemplateForHeadingCostumes()
	{
		return "コスチューム";
	}

	protected override string _GetTemplateForHeadingCreateNewCostume()
	{
		return "コスチュームを新規作成する";
	}

	protected override string _GetTemplateForHeadingCreateNewOutfit()
	{
		return "新しい服装を作成する";
	}

	protected override string _GetTemplateForHeadingDelete()
	{
		return "削除";
	}

	protected override string _GetTemplateForHeadingDeleteCostume()
	{
		return "コスチュームの削除";
	}

	protected override string _GetTemplateForHeadingDeleteOutfit()
	{
		return "服装の削除";
	}

	protected override string _GetTemplateForHeadingEmotes()
	{
		return "エモート";
	}

	protected override string _GetTemplateForHeadingEquipEmotes()
	{
		return "エモートを装備";
	}

	protected override string _GetTemplateForHeadingOutfits()
	{
		return "服装";
	}

	protected override string _GetTemplateForHeadingPackages()
	{
		return "パッケージ";
	}

	protected override string _GetTemplateForHeadingRecent()
	{
		return "最近";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "おすすめ";
	}

	protected override string _GetTemplateForHeadingRenameCostume()
	{
		return "コスチューム名を変更";
	}

	protected override string _GetTemplateForHeadingRenameOutfit()
	{
		return "服装名を変更する";
	}

	protected override string _GetTemplateForHeadingScaling()
	{
		return "スケールする";
	}

	protected override string _GetTemplateForHeadingSkinToneBodyParts()
	{
		return "ボディパーツごとのスキンのトーン";
	}

	protected override string _GetTemplateForHeadingUpdate()
	{
		return "アップデート";
	}

	protected override string _GetTemplateForHeadingUpdateCostume()
	{
		return "コスチュームのアップデート";
	}

	protected override string _GetTemplateForHeadingUpdateOutfit()
	{
		return "服装のアップデート";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "すべて";
	}

	protected override string _GetTemplateForLabelAskIfLoadingCorrectly()
	{
		return "アバターが正常に読み込まれていません。";
	}

	protected override string _GetTemplateForLabelAssetIDPlaceholder()
	{
		return "アセットID";
	}

	protected override string _GetTemplateForLabelBack()
	{
		return "背面";
	}

	protected override string _GetTemplateForLabelBackAccessories()
	{
		return "背面用アクセサリ";
	}

	protected override string _GetTemplateForLabelBodyType()
	{
		return "ボディタイプ";
	}

	protected override string _GetTemplateForLabelClimb()
	{
		return "登る";
	}

	protected override string _GetTemplateForLabelClimbAnimations()
	{
		return "登るアニメーション";
	}

	protected override string _GetTemplateForLabelClothes()
	{
		return "洋服";
	}

	protected override string _GetTemplateForLabelCostume()
	{
		return "コスチューム";
	}

	/// <summary>
	/// Key: "Label.DirectionsForPackagePlacement"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}"
	/// </summary>
	public override string LabelDirectionsForPackagePlacement(string startBold, string rightArrow, string endBold)
	{
		return $"パッケージはコスチュームに移動しました。{startBold}コスチューム{rightArrow}プリセットコスチューム{endBold}をチェックしてください";
	}

	protected override string _GetTemplateForLabelDirectionsForPackagePlacement()
	{
		return "パッケージはコスチュームに移動しました。{startBold}コスチューム{rightArrow}プリセットコスチューム{endBold}をチェックしてください";
	}

	/// <summary>
	/// Key: "Label.DirectionsForScalingOptions"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}"
	/// </summary>
	public override string LabelDirectionsForScalingOptions(string startBold, string rightArrow, string endBold)
	{
		return $"スケールオプションは、ボディのカテゴリで使用できます。{startBold}ボディ{rightArrow}スケール{endBold}でチェックしてください。";
	}

	protected override string _GetTemplateForLabelDirectionsForScalingOptions()
	{
		return "スケールオプションは、ボディのカテゴリで使用できます。{startBold}ボディ{rightArrow}スケール{endBold}でチェックしてください。";
	}

	protected override string _GetTemplateForlabelEmotes()
	{
		return "エモート";
	}

	protected override string _GetTemplateForLabelEquip()
	{
		return "装備";
	}

	protected override string _GetTemplateForLabelExploreCatalog()
	{
		return "カタログをチェックして、洋服を見つけよう！";
	}

	protected override string _GetTemplateForLabelFace()
	{
		return "顔";
	}

	protected override string _GetTemplateForLabelFaceAccessories()
	{
		return "顔用アクセサリ";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "顔";
	}

	protected override string _GetTemplateForLabelFall()
	{
		return "落下";
	}

	protected override string _GetTemplateForLabelFallAnimations()
	{
		return "落下アニメーション";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "無料";
	}

	protected override string _GetTemplateForLabelFront()
	{
		return "正面";
	}

	protected override string _GetTemplateForLabelFrontAccessories()
	{
		return "正面用アクセサリ";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "ギア";
	}

	protected override string _GetTemplateForLabelHair()
	{
		return "髪";
	}

	protected override string _GetTemplateForLabelHairAccessories()
	{
		return "髪用アクセサリ";
	}

	protected override string _GetTemplateForLabelHat()
	{
		return "帽子";
	}

	protected override string _GetTemplateForLabelHatAccessories()
	{
		return "帽子用アクセサリ";
	}

	protected override string _GetTemplateForLabelHead()
	{
		return "頭";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "頭";
	}

	protected override string _GetTemplateForLabelHeight()
	{
		return "身長";
	}

	protected override string _GetTemplateForLabelIdle()
	{
		return "待機";
	}

	protected override string _GetTemplateForLabelIdleAnimations()
	{
		return "待機アニメーション";
	}

	protected override string _GetTemplateForLabelJump()
	{
		return "ジャンプ";
	}

	protected override string _GetTemplateForLabelJumpAnimations()
	{
		return "ジャンプアニメーション";
	}

	protected override string _GetTemplateForLabelLeftArm()
	{
		return "左腕";
	}

	protected override string _GetTemplateForLabelLeftArms()
	{
		return "左腕";
	}

	protected override string _GetTemplateForLabelLeftLeg()
	{
		return "左脚";
	}

	protected override string _GetTemplateForLabelLeftLegs()
	{
		return "左脚";
	}

	protected override string _GetTemplateForLabelMyCostumes()
	{
		return "マイコスチューム";
	}

	protected override string _GetTemplateForLabelNamePlaceholderCostume()
	{
		return "コスチュームに名前を付ける";
	}

	protected override string _GetTemplateForLabelNamePlaceholderOutfit()
	{
		return "服装に名前を付ける";
	}

	protected override string _GetTemplateForLabelNeck()
	{
		return "首";
	}

	protected override string _GetTemplateForLabelNeckAccessories()
	{
		return "首用アクセサリ";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "再販者なし";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "非売品";
	}

	protected override string _GetTemplateForLabelOutfit()
	{
		return "服装";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "パンツ";
	}

	protected override string _GetTemplateForLabelParts()
	{
		return "パーツ";
	}

	protected override string _GetTemplateForLabelPresetCostumes()
	{
		return "プリセットコスチューム";
	}

	protected override string _GetTemplateForLabelProportions()
	{
		return "プロポーション";
	}

	protected override string _GetTemplateForLabelRedrawUnavailable()
	{
		return "アバターのリドローは利用できません。";
	}

	protected override string _GetTemplateForLabelRightArm()
	{
		return "右腕";
	}

	protected override string _GetTemplateForLabelRightArms()
	{
		return "右腕";
	}

	protected override string _GetTemplateForLabelRightLeg()
	{
		return "右脚";
	}

	protected override string _GetTemplateForLabelRightLegs()
	{
		return "右脚";
	}

	protected override string _GetTemplateForLabelRun()
	{
		return "走る";
	}

	protected override string _GetTemplateForLabelRunAnimations()
	{
		return "走るアニメーション";
	}

	protected override string _GetTemplateForLabelScale()
	{
		return "スケール";
	}

	protected override string _GetTemplateForLabelShirts()
	{
		return "シャツ";
	}

	protected override string _GetTemplateForLabelShoulderAccessories()
	{
		return "肩用アクセサリ";
	}

	protected override string _GetTemplateForLabelShoulders()
	{
		return "肩";
	}

	protected override string _GetTemplateForLabelSkinTone()
	{
		return "スキンのトーン";
	}

	protected override string _GetTemplateForLabelSwim()
	{
		return "泳ぐ";
	}

	protected override string _GetTemplateForLabelSwimAnimations()
	{
		return "泳ぐアニメーション";
	}

	protected override string _GetTemplateForLabelSwitchAvatarType()
	{
		return "クラシックR6アバターから次世代のR15アバターまで、自由に切り替えよう。";
	}

	protected override string _GetTemplateForLabelTorso()
	{
		return "胴体";
	}

	protected override string _GetTemplateForLabelTorsos()
	{
		return "胴体";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "Tシャツ";
	}

	protected override string _GetTemplateForLabelWaist()
	{
		return "腰";
	}

	protected override string _GetTemplateForLabelWaistAccessories()
	{
		return "腰用アクセサリ";
	}

	protected override string _GetTemplateForLabelWalk()
	{
		return "歩く";
	}

	protected override string _GetTemplateForLabelWalkAnimations()
	{
		return "歩くアニメーション";
	}

	protected override string _GetTemplateForLabelWidth()
	{
		return "横幅";
	}

	protected override string _GetTemplateForLabelYourEmotes()
	{
		return "自分のエモート";
	}

	protected override string _GetTemplateForMessageAccessoriesChange()
	{
		return "現在の外見を上書きしてよろしいですか？";
	}

	protected override string _GetTemplateForMessageChooseEmote()
	{
		return "エモートを選ぶ";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlot()
	{
		return "スロットを選ぶ";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlotOrEmote()
	{
		return "スロットかエモートを選ぶ";
	}

	protected override string _GetTemplateForMessageDefaultClothing()
	{
		return "アバターにデフォルトのコスチュームが適用されています - 持っているコスチュームを装備してみましょう。";
	}

	/// <summary>
	/// Key: "Message.DeleteOutfit"
	/// English String: "Are you sure you want to delete this {outfitType}?"
	/// </summary>
	public override string MessageDeleteOutfit(string outfitType)
	{
		return $"この{outfitType}を削除してよろしいですか？";
	}

	protected override string _GetTemplateForMessageDeleteOutfit()
	{
		return "この{outfitType}を削除してよろしいですか？";
	}

	protected override string _GetTemplateForMessageDeleteThisCostume()
	{
		return "このコスチュームを削除してよろしいですか？";
	}

	protected override string _GetTemplateForMessageDeleteThisOutfit()
	{
		return "この服装を削除してよろしいですか？";
	}

	protected override string _GetTemplateForMessageEmotesInstructions()
	{
		return "エモートをつけるには、 「アニメーション」 > 「エモート」> 「エモートを装備」 へ行って下さい。";
	}

	protected override string _GetTemplateForMessageEmptyAssetList()
	{
		return "持っていません。";
	}

	/// <summary>
	/// Key: "Message.EmptyListForItem"
	/// The user tries to load a list of some item but they see nothing because they don't own anything of that type.
	/// English String: "You don't have this item: {itemType}"
	/// </summary>
	public override string MessageEmptyListForItem(string itemType)
	{
		return $"このアイテムを持っていません: {itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListForItem()
	{
		return "このアイテムを持っていません: {itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListOfCostumes()
	{
		return "コスチュームがありません。作ってみましょう！";
	}

	protected override string _GetTemplateForMessageEmptyListOfOutfits()
	{
		return "服装がありません。作ってみましょう！";
	}

	protected override string _GetTemplateForMessageEmptyRecentItems()
	{
		return "最近のアイテムがありません。";
	}

	protected override string _GetTemplateForMessageErrorCreateCostume()
	{
		return "コスチュームを作れません。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageErrorCreateOutfit()
	{
		return "服装を作成できません。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageErrorDeleteEmote()
	{
		return "エモートを削除できませんでした。";
	}

	protected override string _GetTemplateForMessageErrorEquipEmote()
	{
		return "エモートを装備できませんでした。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageErrorLoadCostume()
	{
		return "コスチュームを読み込めませんでした。";
	}

	protected override string _GetTemplateForMessageErrorLoadEmotes()
	{
		return "エモートを読み込めませんでした。";
	}

	protected override string _GetTemplateForMessageErrorLoadOutfits()
	{
		return "服装を読み込めませんでした。";
	}

	protected override string _GetTemplateForMessageErrorOutfitName()
	{
		return "名前に使用できるのは、大小アルファベット、半角英数字、およびスペースだけです。";
	}

	protected override string _GetTemplateForMessageErrorRenameCostume()
	{
		return "コスチューム名を変更できませんでした。";
	}

	protected override string _GetTemplateForMessageErrorRenameOutfit()
	{
		return "服装名を変更できませんでした。";
	}

	protected override string _GetTemplateForMessageErrorUnequipEmote()
	{
		return "エモートを外せませんでした。";
	}

	protected override string _GetTemplateForMessageErrorUpdateCostume()
	{
		return "コスチュームをアップデートできませんでした。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageErrorUpdateEmote()
	{
		return "エモートスロットのアップデートができませんでした。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageErrorUpdateOutfit()
	{
		return "服装をアップデートできません。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageErrorUpdateWorn()
	{
		return "装備中のアイテムを更新中にエラーが発生しました。";
	}

	protected override string _GetTemplateForMessageErrorWearCostume()
	{
		return "コスチュームを装備できませんでした。";
	}

	protected override string _GetTemplateForMessageErrorWearOutfit()
	{
		return "服装を装備できませんでした。";
	}

	protected override string _GetTemplateForMessageFailedDeleteCostume()
	{
		return "コスチュームを削除できませんでした。";
	}

	protected override string _GetTemplateForMessageFailedDeleteEmote()
	{
		return "エモートを削除できませんでした。";
	}

	protected override string _GetTemplateForMessageFailedDeleteOutfit()
	{
		return "服装を削除できませんでした。";
	}

	protected override string _GetTemplateForMessageFailedLoadAssets()
	{
		return "アセットリストを読み込めませんでした。";
	}

	protected override string _GetTemplateForMessageFailedLoadRecent()
	{
		return "最近のアイテムを読み込めませんでした。";
	}

	protected override string _GetTemplateForMessageFailedUpdateBodyColor()
	{
		return "スキンのトーンをアップデートできませんでした。";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedCostume()
	{
		return "アップデートしようとしているコスチュームは、もう存在しません。";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedOutfit()
	{
		return "アップデートしようとしている服装は、もう存在しません。";
	}

	protected override string _GetTemplateForMessageFailedUpdateScales()
	{
		return "スケールをアップデートできませんでした。";
	}

	protected override string _GetTemplateForMessageFailedUpdateType()
	{
		return "アバタータイプをアップデートできませんでした。";
	}

	protected override string _GetTemplateForMessageFailedWearPackage()
	{
		return "パッケージを装備できませんでした。";
	}

	protected override string _GetTemplateForMessageHatLimitTooltip()
	{
		return "帽子は3つまで装備できます";
	}

	protected override string _GetTemplateForMessageInvalidOutfitName()
	{
		return "名前は、不適切な言葉が使用されておらず、200文字未満である必要があります。";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "読み込み中...";
	}

	/// <summary>
	/// Key: "Message.MissingItemsFromOutfit"
	/// User cannot wear an outfit because they are missing or have deleted some of the items that were part of that outfit.
	/// English String: "Number of items that you don't own in this outfit: {number}"
	/// </summary>
	public override string MessageMissingItemsFromOutfit(string number)
	{
		return $"この服装で所有していないアイテム数: {number}";
	}

	protected override string _GetTemplateForMessageMissingItemsFromOutfit()
	{
		return "この服装で所有していないアイテム数: {number}";
	}

	protected override string _GetTemplateForMessagePageUnavailable()
	{
		return "アバターページは現在利用できません。";
	}

	protected override string _GetTemplateForMessagePresetCostumesDelay()
	{
		return "ご注意: 現在ハウスキーピング作業を行っているため、すべてのコスチュームが表示されるまで数分かかる場合があります。しばらくしてからチェックしてみてください！";
	}

	protected override string _GetTemplateForMessageReachedMaxCostumes()
	{
		return "コスチュームが最大数に到達しました。";
	}

	protected override string _GetTemplateForMessageReachedMaxOutfits()
	{
		return "服装の最大数に到達しました。";
	}

	protected override string _GetTemplateForMessageRedirectAvatarSettings()
	{
		return "Roblox Studioのプロジェクトからアバターの設定を変更できます。「ホーム」>「ゲーム設定」>「アバター」にアクセスしてください";
	}

	protected override string _GetTemplateForMessageRedrawFloodchecked()
	{
		return "アバターのリドロー回数が多すぎます。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageRedrawThumbnailFailed()
	{
		return "サムネイルを変更できません。";
	}

	protected override string _GetTemplateForMessageSelectEnableScaling()
	{
		return "スケールを有効にするには、R15を選択しよう。";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "成功";
	}

	protected override string _GetTemplateForMessageSuccessCreateCostume()
	{
		return "コスチュームを作成しました";
	}

	protected override string _GetTemplateForMessageSuccessCreateOutfit()
	{
		return "服装を作成しました";
	}

	protected override string _GetTemplateForMessageSuccessDeleteCostume()
	{
		return "コスチュームを削除しました";
	}

	protected override string _GetTemplateForMessageSuccessDeleteOutfit()
	{
		return "服装を削除しました";
	}

	protected override string _GetTemplateForMessageSuccessEquipEmote()
	{
		return "エモートを装備しました";
	}

	protected override string _GetTemplateForMessageSuccessRenameCostume()
	{
		return "コスチューム名を変更しました";
	}

	protected override string _GetTemplateForMessageSuccessRenameOutfit()
	{
		return "服装名を変更しました";
	}

	protected override string _GetTemplateForMessageSuccessSavedAccessories()
	{
		return "アクセサリを保存しました";
	}

	protected override string _GetTemplateForMessageSuccessUnequipEmote()
	{
		return "エモートを外しました。";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedCostume()
	{
		return "コスチュームをアップデートしました";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedOutfit()
	{
		return "服装をアップデートしました";
	}

	protected override string _GetTemplateForMessageSuccessWoreCostume()
	{
		return "コスチュームをつけました";
	}

	protected override string _GetTemplateForMessageSuccessWoreOutfit()
	{
		return "服をつけました";
	}

	/// <summary>
	/// Key: "Message.UpdateOutfit"
	/// English String: "Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateOutfit(string outfitType1, string outfitType2)
	{
		return $"この{outfitType1} をアップデートしますか？アップデートすると{outfitType2} がアバターの現在の外見で上書きされます。";
	}

	protected override string _GetTemplateForMessageUpdateOutfit()
	{
		return "この{outfitType1} をアップデートしますか？アップデートすると{outfitType2} がアバターの現在の外見で上書きされます。";
	}

	protected override string _GetTemplateForMessageUpdateThisCostume()
	{
		return "このコスチュームをアップデートしますか？アップデートするとコスチュームがアバターの現在の外見で上書きされます。";
	}

	protected override string _GetTemplateForMessageUpdateThisOutfit()
	{
		return "この服装をアップデートしますか？アップデートすると服装がアバターの現在の外見で上書きされます。";
	}

	protected override string _GetTemplateForMessageWarning()
	{
		return "警告";
	}
}
