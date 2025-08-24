namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides AvatarResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AvatarResources_de_de : AvatarResources_en_us, IAvatarResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Advanced"
	/// Click Advanced to get the advanced options
	/// English String: "Advanced"
	/// </summary>
	public override string ActionAdvanced => "Fortgeschritten";

	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item to customize the user's avatar.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "Kaufen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Schließen";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "Erstellen";

	/// <summary>
	/// Key: "Action.CreateNewOutfit"
	/// Button to create new outfit
	/// English String: "Create"
	/// </summary>
	public override string ActionCreateNewOutfit => "Erstellen";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Löschen";

	/// <summary>
	/// Key: "Action.Done"
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "Fertig";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy get an item for free to customize the user's avatar.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "Holen";

	/// <summary>
	/// Key: "Action.GetMore"
	/// A call to action for the user to buy more clothes from the Catalog page. This could improve how their avatar looks.
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "Mehr holen";

	/// <summary>
	/// Key: "Action.OpenRobloxApp"
	/// English String: "Open Roblox App"
	/// </summary>
	public override string ActionOpenRobloxApp => "Roblox-App öffnen";

	/// <summary>
	/// Key: "Action.Redraw"
	/// Redraw the avatar on the screen
	/// English String: "Redraw"
	/// </summary>
	public override string ActionRedraw => "Neu rendern";

	/// <summary>
	/// Key: "Action.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string ActionRename => "Umbenennen";

	/// <summary>
	/// Key: "Action.RenameOutfit"
	/// Button to rename outfit
	/// English String: "Rename"
	/// </summary>
	public override string ActionRenameOutfit => "Umbenennen";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Speichern";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// See all clothing that user can buy
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Alle ansehen";

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
	public override string ActionUpdate => "Aktualisieren";

	/// <summary>
	/// Key: "Action.UserUnderstands"
	/// The user casually responds to the application saying that they understand how to navigate the menu.
	/// English String: "Got it"
	/// </summary>
	public override string ActionUserUnderstands => "Verstanden";

	/// <summary>
	/// Key: "Description.AvatarEditorUpsell"
	/// English String: "To change your look you will need to use the Avatar Editor on the App."
	/// </summary>
	public override string DescriptionAvatarEditorUpsell => "Um dein Erscheinungsbild zu ändern, benötigst du den Avatar-Editor in der App.";

	/// <summary>
	/// Key: "Description.CreateNewCostume"
	/// A costume will be created from your avatar's current appearance.
	/// English String: "A costume will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewCostume => "Das Kostüm wird anhand des aktuellen Erscheinungsbilds deines Avatars erstellt.";

	/// <summary>
	/// Key: "Description.CreateNewOutfit"
	/// An outfit will be created from your avatar's current appearance.
	/// English String: "An outfit will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewOutfit => "Das Outfit wird anhand des aktuellen Erscheinungsbilds deines Avatars erstellt.";

	/// <summary>
	/// Key: "Description.RenameCostume"
	/// Choose a new name for your costume.
	/// English String: "Choose a new name for your costume."
	/// </summary>
	public override string DescriptionRenameCostume => "Gib deinem Kostüm einen neuen Namen.";

	/// <summary>
	/// Key: "Description.RenameOutfit"
	/// Choose a new name for your outfit.
	/// English String: "Choose a new name for your outfit."
	/// </summary>
	public override string DescriptionRenameOutfit => "Gib deinem Outfit einen neuen Namen.";

	/// <summary>
	/// Key: "Heading.Accessories"
	/// English String: "Accessories"
	/// </summary>
	public override string HeadingAccessories => "Accessoires";

	/// <summary>
	/// Key: "Heading.AccessoriesChange"
	/// English String: "Accessories Change"
	/// </summary>
	public override string HeadingAccessoriesChange => "Accessoires austauschen";

	/// <summary>
	/// Key: "Heading.AdvancedOptions"
	/// English String: "Advanced Options"
	/// </summary>
	public override string HeadingAdvancedOptions => "Fortgeschrittene Optionen";

	/// <summary>
	/// Key: "Heading.All"
	/// All avatar modification types
	/// English String: "All"
	/// </summary>
	public override string HeadingAll => "Alle";

	/// <summary>
	/// Key: "Heading.Animations"
	/// English String: "Animations"
	/// </summary>
	public override string HeadingAnimations => "Animationen";

	/// <summary>
	/// Key: "Heading.Appearance"
	/// English String: "Appearance"
	/// </summary>
	public override string HeadingAppearance => "Erscheinungsbild";

	/// <summary>
	/// Key: "Heading.AvatarPageTitle"
	/// Page title for the Avatar page. On this page, the user can modify how they look.
	/// English String: "Avatar Editor"
	/// </summary>
	public override string HeadingAvatarPageTitle => "Avatar-Editor";

	/// <summary>
	/// Key: "Heading.Body"
	/// English String: "Body"
	/// </summary>
	public override string HeadingBody => "Körper";

	/// <summary>
	/// Key: "Heading.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string HeadingBodyParts => "Körperteile";

	/// <summary>
	/// Key: "Heading.Clothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingClothing => "Kleidung";

	/// <summary>
	/// Key: "Heading.Costumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Costumes"
	/// </summary>
	public override string HeadingCostumes => "Kostüme";

	/// <summary>
	/// Key: "Heading.CreateNewCostume"
	/// NOTE: Costume is a more whimsical word choice for outfit. Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Create New Costume"
	/// </summary>
	public override string HeadingCreateNewCostume => "Neues Kostüm erstellen";

	/// <summary>
	/// Key: "Heading.CreateNewOutfit"
	/// English String: "Create New Outfit"
	/// </summary>
	public override string HeadingCreateNewOutfit => "Neues Outfit erstellen";

	/// <summary>
	/// Key: "Heading.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string HeadingDelete => "Löschen";

	/// <summary>
	/// Key: "Heading.DeleteCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Delete Costume"
	/// </summary>
	public override string HeadingDeleteCostume => "Kostüm löschen";

	/// <summary>
	/// Key: "Heading.DeleteOutfit"
	/// English String: "Delete Outfit"
	/// </summary>
	public override string HeadingDeleteOutfit => "Outfit löschen";

	/// <summary>
	/// Key: "Heading.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string HeadingEmotes => "Emotes";

	/// <summary>
	/// Key: "Heading.EquipEmotes"
	/// English String: "Equip Emotes"
	/// </summary>
	public override string HeadingEquipEmotes => "Emotes ausrüsten";

	/// <summary>
	/// Key: "Heading.Outfits"
	/// English String: "Outfits"
	/// </summary>
	public override string HeadingOutfits => "Outfits";

	/// <summary>
	/// Key: "Heading.Packages"
	/// English String: "Packages"
	/// </summary>
	public override string HeadingPackages => "Pakete";

	/// <summary>
	/// Key: "Heading.Recent"
	/// English String: "Recent"
	/// </summary>
	public override string HeadingRecent => "Vor Kurzem";

	/// <summary>
	/// Key: "Heading.Recommended"
	/// See recommended clothing for your avatar
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommended => "Empfohlen";

	/// <summary>
	/// Key: "Heading.RenameCostume"
	/// English String: "Rename Costume"
	/// </summary>
	public override string HeadingRenameCostume => "Kostüm umbenennen";

	/// <summary>
	/// Key: "Heading.RenameOutfit"
	/// English String: "Rename Outfit"
	/// </summary>
	public override string HeadingRenameOutfit => "Outfit umbenennen";

	/// <summary>
	/// Key: "Heading.Scaling"
	/// English String: "Scaling"
	/// </summary>
	public override string HeadingScaling => "Skalierung";

	/// <summary>
	/// Key: "Heading.SkinToneBodyParts"
	/// English String: "Skin Tone by Body Parts"
	/// </summary>
	public override string HeadingSkinToneBodyParts => "Hautfarbe nach Körperteilen";

	/// <summary>
	/// Key: "Heading.Update"
	/// English String: "Update"
	/// </summary>
	public override string HeadingUpdate => "Aktualisieren";

	/// <summary>
	/// Key: "Heading.UpdateCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Update Costume"
	/// </summary>
	public override string HeadingUpdateCostume => "Kostüm aktualisieren";

	/// <summary>
	/// Key: "Heading.UpdateOutfit"
	/// English String: "Update Outfit"
	/// </summary>
	public override string HeadingUpdateOutfit => "Outfit aktualisieren";

	/// <summary>
	/// Key: "Label.All"
	/// All body parts. This label will allow for body parts to change color
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Alle";

	/// <summary>
	/// Key: "Label.AskIfLoadingCorrectly"
	/// Avatar isn't loading correctly?
	/// English String: "Avatar isn't loading correctly?"
	/// </summary>
	public override string LabelAskIfLoadingCorrectly => "Dein Avatar wird nicht richtig geladen?";

	/// <summary>
	/// Key: "Label.AssetIDPlaceholder"
	/// This refers to the Asset ID which is a technical word for the Identification Number of an item or asset.
	/// English String: "Asset ID"
	/// </summary>
	public override string LabelAssetIDPlaceholder => "Objekt-ID";

	/// <summary>
	/// Key: "Label.Back"
	/// English String: "Back"
	/// </summary>
	public override string LabelBack => "Rückseite";

	/// <summary>
	/// Key: "Label.BackAccessories"
	/// English String: "Back Accessories"
	/// </summary>
	public override string LabelBackAccessories => "Rückseite-Accessoires";

	/// <summary>
	/// Key: "Label.BodyType"
	/// English String: "Body Type"
	/// </summary>
	public override string LabelBodyType => "Körpertyp";

	/// <summary>
	/// Key: "Label.Climb"
	/// English String: "Climb"
	/// </summary>
	public override string LabelClimb => "Klettern";

	/// <summary>
	/// Key: "Label.ClimbAnimations"
	/// English String: "Climb Animations"
	/// </summary>
	public override string LabelClimbAnimations => "Kletteranimationen";

	/// <summary>
	/// Key: "Label.Clothes"
	/// English String: "Clothes"
	/// </summary>
	public override string LabelClothes => "Kleidung";

	/// <summary>
	/// Key: "Label.Costume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Costume"
	/// </summary>
	public override string LabelCostume => "Kostüm";

	/// <summary>
	/// Key: "label.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string labelEmotes => "Emotes";

	/// <summary>
	/// Key: "Label.Equip"
	/// English String: "Equip"
	/// </summary>
	public override string LabelEquip => "Ausrüsten";

	/// <summary>
	/// Key: "Label.ExploreCatalog"
	/// This text entices users to shop for more things to wear on their avatar
	/// English String: "Explore the catalog to find more clothes!"
	/// </summary>
	public override string LabelExploreCatalog => "Durchsuche den Katalog, um mehr Kleidung zu finden!";

	/// <summary>
	/// Key: "Label.Face"
	/// English String: "Face"
	/// </summary>
	public override string LabelFace => "Gesicht";

	/// <summary>
	/// Key: "Label.FaceAccessories"
	/// English String: "Face Accessories"
	/// </summary>
	public override string LabelFaceAccessories => "Gesicht-Accessoires";

	/// <summary>
	/// Key: "Label.Faces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "Gesichter";

	/// <summary>
	/// Key: "Label.Fall"
	/// English String: "Fall"
	/// </summary>
	public override string LabelFall => "Fallen";

	/// <summary>
	/// Key: "Label.FallAnimations"
	/// English String: "Fall Animations"
	/// </summary>
	public override string LabelFallAnimations => "Fallanimationen";

	/// <summary>
	/// Key: "Label.Free"
	/// Text label for recommended items
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "Gratis";

	/// <summary>
	/// Key: "Label.Front"
	/// English String: "Front"
	/// </summary>
	public override string LabelFront => "Vorderseite";

	/// <summary>
	/// Key: "Label.FrontAccessories"
	/// English String: "Front Accessories"
	/// </summary>
	public override string LabelFrontAccessories => "Vorderseite-Accessoires";

	/// <summary>
	/// Key: "Label.Gear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "Ausrüstung";

	/// <summary>
	/// Key: "Label.Hair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelHair => "Haare";

	/// <summary>
	/// Key: "Label.HairAccessories"
	/// English String: "Hair Accessories"
	/// </summary>
	public override string LabelHairAccessories => "Haar-Accessoires";

	/// <summary>
	/// Key: "Label.Hat"
	/// English String: "Hat"
	/// </summary>
	public override string LabelHat => "Hut";

	/// <summary>
	/// Key: "Label.HatAccessories"
	/// English String: "Hat Accessories"
	/// </summary>
	public override string LabelHatAccessories => "Hut-Accessoires";

	/// <summary>
	/// Key: "Label.Head"
	/// English String: "Head"
	/// </summary>
	public override string LabelHead => "Kopf";

	/// <summary>
	/// Key: "Label.Heads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "Köpfe";

	/// <summary>
	/// Key: "Label.Height"
	/// English String: "Height"
	/// </summary>
	public override string LabelHeight => "Höhe";

	/// <summary>
	/// Key: "Label.Idle"
	/// English String: "Idle"
	/// </summary>
	public override string LabelIdle => "Untätig";

	/// <summary>
	/// Key: "Label.IdleAnimations"
	/// English String: "Idle Animations"
	/// </summary>
	public override string LabelIdleAnimations => "Untätige Animationen";

	/// <summary>
	/// Key: "Label.Jump"
	/// English String: "Jump"
	/// </summary>
	public override string LabelJump => "Springen";

	/// <summary>
	/// Key: "Label.JumpAnimations"
	/// English String: "Jump Animations"
	/// </summary>
	public override string LabelJumpAnimations => "Springanimationen";

	/// <summary>
	/// Key: "Label.LeftArm"
	/// English String: "Left Arm"
	/// </summary>
	public override string LabelLeftArm => "Linker Arm";

	/// <summary>
	/// Key: "Label.LeftArms"
	/// English String: "Left Arms"
	/// </summary>
	public override string LabelLeftArms => "Linke Arme";

	/// <summary>
	/// Key: "Label.LeftLeg"
	/// English String: "Left Leg"
	/// </summary>
	public override string LabelLeftLeg => "Linkes Bein";

	/// <summary>
	/// Key: "Label.LeftLegs"
	/// English String: "Left Legs"
	/// </summary>
	public override string LabelLeftLegs => "Linke Beine";

	/// <summary>
	/// Key: "Label.MyCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "My Costumes"
	/// </summary>
	public override string LabelMyCostumes => "Meine Kostüme";

	/// <summary>
	/// Key: "Label.NamePlaceholderCostume"
	/// English String: "Name your costume"
	/// </summary>
	public override string LabelNamePlaceholderCostume => "Benenne dein Kostüm";

	/// <summary>
	/// Key: "Label.NamePlaceholderOutfit"
	/// English String: "Name your outfit"
	/// </summary>
	public override string LabelNamePlaceholderOutfit => "Benenne dein Outfit";

	/// <summary>
	/// Key: "Label.Neck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelNeck => "Hals";

	/// <summary>
	/// Key: "Label.NeckAccessories"
	/// English String: "Neck Accessories"
	/// </summary>
	public override string LabelNeckAccessories => "Hals-Accessoires";

	/// <summary>
	/// Key: "Label.NoResellers"
	/// Text label for recommended items
	/// English String: "No resellers"
	/// </summary>
	public override string LabelNoResellers => "Keine Wiederverkäufer";

	/// <summary>
	/// Key: "Label.OffSale"
	/// Text label for recommended items
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "Nicht mehr im Angebot";

	/// <summary>
	/// Key: "Label.Outfit"
	/// English String: "Outfit"
	/// </summary>
	public override string LabelOutfit => "Outfit";

	/// <summary>
	/// Key: "Label.Pants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "Hosen";

	/// <summary>
	/// Key: "Label.Parts"
	/// English String: "Parts"
	/// </summary>
	public override string LabelParts => "Teile";

	/// <summary>
	/// Key: "Label.PresetCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Preset Costumes"
	/// </summary>
	public override string LabelPresetCostumes => "Vorgefertigte Kostüme";

	/// <summary>
	/// Key: "Label.Proportions"
	/// English String: "Proportions"
	/// </summary>
	public override string LabelProportions => "Proportionen";

	/// <summary>
	/// Key: "Label.RedrawUnavailable"
	/// Avatar redraw is unavailable
	/// English String: "Avatar redraw is unavailable."
	/// </summary>
	public override string LabelRedrawUnavailable => "Avatar kann nicht neu gerendert werden.";

	/// <summary>
	/// Key: "Label.RightArm"
	/// English String: "Right Arm"
	/// </summary>
	public override string LabelRightArm => "Rechter Arm";

	/// <summary>
	/// Key: "Label.RightArms"
	/// English String: "Right Arms"
	/// </summary>
	public override string LabelRightArms => "Rechte Arme";

	/// <summary>
	/// Key: "Label.RightLeg"
	/// English String: "Right Leg"
	/// </summary>
	public override string LabelRightLeg => "Rechtes Bein";

	/// <summary>
	/// Key: "Label.RightLegs"
	/// English String: "Right Legs"
	/// </summary>
	public override string LabelRightLegs => "Rechte Beine";

	/// <summary>
	/// Key: "Label.Run"
	/// English String: "Run"
	/// </summary>
	public override string LabelRun => "Laufen";

	/// <summary>
	/// Key: "Label.RunAnimations"
	/// English String: "Run Animations"
	/// </summary>
	public override string LabelRunAnimations => "Laufanimationen";

	/// <summary>
	/// Key: "Label.Scale"
	/// English String: "Scale"
	/// </summary>
	public override string LabelScale => "Größe";

	/// <summary>
	/// Key: "Label.Shirts"
	/// English String: "Shirts"
	/// </summary>
	public override string LabelShirts => "Hemden";

	/// <summary>
	/// Key: "Label.ShoulderAccessories"
	/// English String: "Shoulder Accessories"
	/// </summary>
	public override string LabelShoulderAccessories => "Schulter-Accessoires";

	/// <summary>
	/// Key: "Label.Shoulders"
	/// English String: "Shoulders"
	/// </summary>
	public override string LabelShoulders => "Schultern";

	/// <summary>
	/// Key: "Label.SkinTone"
	/// English String: "Skin Tone"
	/// </summary>
	public override string LabelSkinTone => "Hautfarbe";

	/// <summary>
	/// Key: "Label.Swim"
	/// English String: "Swim"
	/// </summary>
	public override string LabelSwim => "Schwimmen";

	/// <summary>
	/// Key: "Label.SwimAnimations"
	/// English String: "Swim Animations"
	/// </summary>
	public override string LabelSwimAnimations => "Schwimmanimationen";

	/// <summary>
	/// Key: "Label.SwitchAvatarType"
	/// User is able to increase the number of joints in their avatar from 6 to 15. R15 moves better. See http://roblox.wikia.com/wiki/R15
	/// English String: "Switch between classic R6 avatar and more expressive next generation R15 avatar"
	/// </summary>
	public override string LabelSwitchAvatarType => "Schalte zwischen dem klassischen R6-Avatar und dem ausdrucksstärkeren, modernen R15-Avatar um.";

	/// <summary>
	/// Key: "Label.Torso"
	/// English String: "Torso"
	/// </summary>
	public override string LabelTorso => "Torso";

	/// <summary>
	/// Key: "Label.Torsos"
	/// English String: "Torsos"
	/// </summary>
	public override string LabelTorsos => "Torsos";

	/// <summary>
	/// Key: "Label.TShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "T-Shirts";

	/// <summary>
	/// Key: "Label.Waist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelWaist => "Taille";

	/// <summary>
	/// Key: "Label.WaistAccessories"
	/// English String: "Waist Accessories"
	/// </summary>
	public override string LabelWaistAccessories => "Taille-Accessoires";

	/// <summary>
	/// Key: "Label.Walk"
	/// English String: "Walk"
	/// </summary>
	public override string LabelWalk => "Gehen";

	/// <summary>
	/// Key: "Label.WalkAnimations"
	/// English String: "Walk Animations"
	/// </summary>
	public override string LabelWalkAnimations => "Gehanimationen";

	/// <summary>
	/// Key: "Label.Width"
	/// English String: "Width"
	/// </summary>
	public override string LabelWidth => "Breite";

	/// <summary>
	/// Key: "Label.YourEmotes"
	/// English String: "Your Emotes"
	/// </summary>
	public override string LabelYourEmotes => "Deine Emotes";

	/// <summary>
	/// Key: "Message.AccessoriesChange"
	/// English String: "Are you sure you want to override your current look?"
	/// </summary>
	public override string MessageAccessoriesChange => "Möchtest du deinen aktuellen Look wirklich ersetzen?";

	/// <summary>
	/// Key: "Message.ChooseEmote"
	/// English String: "Choose an Emote"
	/// </summary>
	public override string MessageChooseEmote => "Emote auswählen";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlot"
	/// English String: "Choose a slot"
	/// </summary>
	public override string MessageChooseEmoteSlot => "Wähle einen Steckplatz";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlotOrEmote"
	/// English String: "Choose a slot or an Emote"
	/// </summary>
	public override string MessageChooseEmoteSlotOrEmote => "Wähle einen Steckplatz oder ein Emote aus";

	/// <summary>
	/// Key: "Message.DefaultClothing"
	/// Encourage user to choose their own clothes.
	/// English String: "Default clothing has been applied to your avatar - wear something from your clothing."
	/// </summary>
	public override string MessageDefaultClothing => "Dein Avatar trägt die Standardkleidung. Zieh doch etwas aus deiner Kleidungssammlung an.";

	/// <summary>
	/// Key: "Message.DeleteThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Are you sure you want to delete this costume?"
	/// </summary>
	public override string MessageDeleteThisCostume => "Möchtest du dieses Kostüm wirklich löschen?";

	/// <summary>
	/// Key: "Message.DeleteThisOutfit"
	/// English String: "Are you sure you want to delete this outfit?"
	/// </summary>
	public override string MessageDeleteThisOutfit => "Möchtest du dieses Outfit wirklich löschen?";

	/// <summary>
	/// Key: "Message.EmotesInstructions"
	/// The instructions describe the navigation flow within the Avatar Editor to equip an emote.
	/// English String: "Go to \"Animations\" &gt; \"Emotes\" &gt; \"Equip Emotes\" to equip an emote."
	/// </summary>
	public override string MessageEmotesInstructions => "Gehe zu „Animationen“> „Emotes“> „Emotes ausrüsten“, um ein Emote auszurüsten.";

	/// <summary>
	/// Key: "Message.EmptyAssetList"
	/// User is seeing no assets on this page because they don't have any.
	/// English String: "You don't have any."
	/// </summary>
	public override string MessageEmptyAssetList => "Du hast keine.";

	/// <summary>
	/// Key: "Message.EmptyListOfCostumes"
	/// The user is viewing an empty list of costumes to choose from. The application tells the user that they can create an costume.
	/// English String: "You don't have any costumes. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfCostumes => "Du hast keine Kostüme. Erstell doch eins!";

	/// <summary>
	/// Key: "Message.EmptyListOfOutfits"
	/// The user is viewing an empty list of outfits to choose from. The application tells the user that they can create an outfit.
	/// English String: "You don't have any outfits. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfOutfits => "Du hast keine Outfits. Erstell doch eins!";

	/// <summary>
	/// Key: "Message.EmptyRecentItems"
	/// English String: "You don't have any recent items."
	/// </summary>
	public override string MessageEmptyRecentItems => "Du hast keine kürzlich verwendeten Artikel.";

	/// <summary>
	/// Key: "Message.ErrorCreateCostume"
	/// English String: "Unable to create costume, try again later."
	/// </summary>
	public override string MessageErrorCreateCostume => "Kostüm kann nicht erstellt werden. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.ErrorCreateOutfit"
	/// English String: "Unable to create outfit, try again later."
	/// </summary>
	public override string MessageErrorCreateOutfit => "Outfit kann nicht erstellt werden. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.ErrorDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageErrorDeleteEmote => "Emote konnte nicht gelöscht werden.";

	/// <summary>
	/// Key: "Message.ErrorEquipEmote"
	/// English String: "Failed to equip emote, please try again later."
	/// </summary>
	public override string MessageErrorEquipEmote => "Emote konnte nicht ausgerüstet werden, bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.ErrorLoadCostume"
	/// English String: "Failed to load costume."
	/// </summary>
	public override string MessageErrorLoadCostume => "Kostüm konnte nicht geladen werden.";

	/// <summary>
	/// Key: "Message.ErrorLoadEmotes"
	/// English String: "Failed to load emotes."
	/// </summary>
	public override string MessageErrorLoadEmotes => "Emotes konnten nicht geladen werden.";

	/// <summary>
	/// Key: "Message.ErrorLoadOutfits"
	/// English String: "Failed to load outfits."
	/// </summary>
	public override string MessageErrorLoadOutfits => "Outfits konnten nicht geladen werden.";

	/// <summary>
	/// Key: "Message.ErrorOutfitName"
	/// English String: "Name can contain letters, numbers, and spaces."
	/// </summary>
	public override string MessageErrorOutfitName => "Namen können Buchstaben, Ziffern und Leerzeichen enthalten.";

	/// <summary>
	/// Key: "Message.ErrorRenameCostume"
	/// English String: "Failed to rename costume."
	/// </summary>
	public override string MessageErrorRenameCostume => "Kostüm konnte nicht umbenannt werden.";

	/// <summary>
	/// Key: "Message.ErrorRenameOutfit"
	/// English String: "Failed to rename outfit."
	/// </summary>
	public override string MessageErrorRenameOutfit => "Outfit konnte nicht umbenannt werden.";

	/// <summary>
	/// Key: "Message.ErrorUnequipEmote"
	/// English String: "Failed to unequip emote."
	/// </summary>
	public override string MessageErrorUnequipEmote => "Emote konnte nicht ausgerüstet werden.";

	/// <summary>
	/// Key: "Message.ErrorUpdateCostume"
	/// English String: "Costume update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateCostume => "Aktualisieren des Kostüms fehlgeschlagen. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.ErrorUpdateEmote"
	/// English String: "Updating emote slot failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateEmote => "Die Aktualisierung des Emote-Steckplatzes ist fehlgeschlagen, bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.ErrorUpdateOutfit"
	/// English String: "Outfit update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateOutfit => "Aktualisieren des Outfits fehlgeschlagen. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.ErrorUpdateWorn"
	/// There was an error updating items that the user is already wearing.
	/// English String: "Error while updating worn items."
	/// </summary>
	public override string MessageErrorUpdateWorn => "Fehler beim Aktualisieren der getragenen Artikel.";

	/// <summary>
	/// Key: "Message.ErrorWearCostume"
	/// English String: "Failed to wear costume."
	/// </summary>
	public override string MessageErrorWearCostume => "Kostüm konnte nicht getragen werden.";

	/// <summary>
	/// Key: "Message.ErrorWearOutfit"
	/// English String: "Failed to wear outfit."
	/// </summary>
	public override string MessageErrorWearOutfit => "Outfit konnte nicht getragen werden.";

	/// <summary>
	/// Key: "Message.FailedDeleteCostume"
	/// English String: "Failed to delete costume."
	/// </summary>
	public override string MessageFailedDeleteCostume => "Kostüm konnte nicht gelöscht werden.";

	/// <summary>
	/// Key: "Message.FailedDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageFailedDeleteEmote => "Emote konnte nicht gelöscht werden.";

	/// <summary>
	/// Key: "Message.FailedDeleteOutfit"
	/// English String: "Failed to delete outfit."
	/// </summary>
	public override string MessageFailedDeleteOutfit => "Outfit konnte nicht gelöscht werden.";

	/// <summary>
	/// Key: "Message.FailedLoadAssets"
	/// English String: "Failed to load assets list."
	/// </summary>
	public override string MessageFailedLoadAssets => "Objektliste konnte nicht geladen werden.";

	/// <summary>
	/// Key: "Message.FailedLoadRecent"
	/// English String: "Failed to load recent items."
	/// </summary>
	public override string MessageFailedLoadRecent => "Kürzlich verwendete Artikel konnten nicht geladen werden.";

	/// <summary>
	/// Key: "Message.FailedUpdateBodyColor"
	/// English String: "Failed to update skin tone."
	/// </summary>
	public override string MessageFailedUpdateBodyColor => "Hautfarbe konnte nicht aktualisiert werden.";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedCostume"
	/// The user tried to update a deleted costume.
	/// English String: "The costume you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedCostume => "Das Kostüm, das du aktualisieren wolltest, existiert nicht mehr.";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedOutfit"
	/// The user tried to update a deleted outfit.
	/// English String: "The outfit you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedOutfit => "Das Outfit, das du aktualisieren wolltest, existiert nicht mehr.";

	/// <summary>
	/// Key: "Message.FailedUpdateScales"
	/// English String: "Failed to update scales."
	/// </summary>
	public override string MessageFailedUpdateScales => "Größen konnten nicht aktualisiert werden.";

	/// <summary>
	/// Key: "Message.FailedUpdateType"
	/// Failed to update the way the user's avatar is rendered.
	/// English String: "Failed to update avatar type."
	/// </summary>
	public override string MessageFailedUpdateType => "Avatar-Art konnte nicht aktualisiert werden.";

	/// <summary>
	/// Key: "Message.FailedWearPackage"
	/// English String: "Failed to wear package."
	/// </summary>
	public override string MessageFailedWearPackage => "Paket konnte nicht getragen werden.";

	/// <summary>
	/// Key: "Message.HatLimitTooltip"
	/// English String: "You can wear up to 3 hats"
	/// </summary>
	public override string MessageHatLimitTooltip => "Du kannst bis zu 3 Hüte tragen.";

	/// <summary>
	/// Key: "Message.InvalidOutfitName"
	/// English String: "Name must be appropriate and less than 200 characters."
	/// </summary>
	public override string MessageInvalidOutfitName => "Name muss angemessen sein und aus weniger als 200 Zeichen bestehen.";

	/// <summary>
	/// Key: "Message.Loading"
	/// The user's avatar is loading
	/// English String: "Loading..."
	/// </summary>
	public override string MessageLoading => "Wird geladen\u00a0...";

	/// <summary>
	/// Key: "Message.PageUnavailable"
	/// English String: "The avatar page is temporarily unavailable."
	/// </summary>
	public override string MessagePageUnavailable => "Die Avatarseite ist vorübergehend nicht verfügbar.";

	/// <summary>
	/// Key: "Message.PresetCostumesDelay"
	/// One-time message that appears to the user first time they visit the Preset Costumes tab. The delay is caused by initial migration.
	/// English String: "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!"
	/// </summary>
	public override string MessagePresetCostumesDelay => "Hinweis: Wir räumen etwas auf, also kann es ein paar Minuten dauern, bis alle deine Kostüme erscheinen. Bitte sieh später wieder nach!";

	/// <summary>
	/// Key: "Message.ReachedMaxCostumes"
	/// English String: "You have reached the maximum number of costumes."
	/// </summary>
	public override string MessageReachedMaxCostumes => "Du hast die maximale Anzahl an Kostümen erreicht.";

	/// <summary>
	/// Key: "Message.ReachedMaxOutfits"
	/// English String: "You have reached the maximum number of outfits."
	/// </summary>
	public override string MessageReachedMaxOutfits => "Du hast die maximale Anzahl an Outfits erreicht.";

	/// <summary>
	/// Key: "Message.RedirectAvatarSettings"
	/// English String: "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home &gt; Game Settings &gt; Avatar"
	/// </summary>
	public override string MessageRedirectAvatarSettings => "Die Avatar-Einstellungen kannst du über dein Roblox-Studio-Projekt bearbeiten. Gehe dazu in Roblox Studio zu Hauptmenü > Spieleinstellungen > Avatar";

	/// <summary>
	/// Key: "Message.RedrawFloodchecked"
	/// English String: "You have redrawn your avatar too many times, please try again later."
	/// </summary>
	public override string MessageRedrawFloodchecked => "Du hast deinen Avatar zu oft neu gerendert. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.RedrawThumbnailFailed"
	/// English String: "Failed to redraw thumbnail."
	/// </summary>
	public override string MessageRedrawThumbnailFailed => "Miniaturansicht konnte nicht neu gerendert werden.";

	/// <summary>
	/// Key: "Message.SelectEnableScaling"
	/// R15 is a proper noun
	/// English String: "Select R15 to enable scaling."
	/// </summary>
	public override string MessageSelectEnableScaling => "Wähle R15, um Skalierung zu aktivieren.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "Erfolg";

	/// <summary>
	/// Key: "Message.SuccessCreateCostume"
	/// English String: "Created costume"
	/// </summary>
	public override string MessageSuccessCreateCostume => "Kostüm erstellt";

	/// <summary>
	/// Key: "Message.SuccessCreateOutfit"
	/// English String: "Created outfit"
	/// </summary>
	public override string MessageSuccessCreateOutfit => "Outfit erstellt";

	/// <summary>
	/// Key: "Message.SuccessDeleteCostume"
	/// Deleted costume
	/// English String: "Deleted costume"
	/// </summary>
	public override string MessageSuccessDeleteCostume => "Kostüm gelöscht";

	/// <summary>
	/// Key: "Message.SuccessDeleteOutfit"
	/// English String: "Deleted outfit"
	/// </summary>
	public override string MessageSuccessDeleteOutfit => "Outfit gelöscht";

	/// <summary>
	/// Key: "Message.SuccessEquipEmote"
	/// English String: "Equipped Emote"
	/// </summary>
	public override string MessageSuccessEquipEmote => "Emote wurde ausgerüstet";

	/// <summary>
	/// Key: "Message.SuccessRenameCostume"
	/// English String: "Renamed costume"
	/// </summary>
	public override string MessageSuccessRenameCostume => "Kostüm umbenannt";

	/// <summary>
	/// Key: "Message.SuccessRenameOutfit"
	/// English String: "Renamed outfit"
	/// </summary>
	public override string MessageSuccessRenameOutfit => "Outfit umbenannt";

	/// <summary>
	/// Key: "Message.SuccessSavedAccessories"
	/// English String: "Saved accessories"
	/// </summary>
	public override string MessageSuccessSavedAccessories => "Accessoires gespeichert";

	/// <summary>
	/// Key: "Message.SuccessUnequipEmote"
	/// English String: "Unequipped emote"
	/// </summary>
	public override string MessageSuccessUnequipEmote => "Emote nicht ausgerüstet";

	/// <summary>
	/// Key: "Message.SuccessUpdatedCostume"
	/// English String: "Updated costume"
	/// </summary>
	public override string MessageSuccessUpdatedCostume => "Kostüm aktualisiert";

	/// <summary>
	/// Key: "Message.SuccessUpdatedOutfit"
	/// English String: "Updated outfit"
	/// </summary>
	public override string MessageSuccessUpdatedOutfit => "Outfit aktualisiert";

	/// <summary>
	/// Key: "Message.SuccessWoreCostume"
	/// English String: "Successfully wore costume"
	/// </summary>
	public override string MessageSuccessWoreCostume => "Kostüm erfolgreich angelegt";

	/// <summary>
	/// Key: "Message.SuccessWoreOutfit"
	/// English String: "Successfully wore outfit"
	/// </summary>
	public override string MessageSuccessWoreOutfit => "Outfit erfolgreich angelegt";

	/// <summary>
	/// Key: "Message.UpdateThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisCostume => "Möchtest du dieses Kostüm aktualisieren? Dadurch wird das Kostüm mit dem aktuellen Erscheinungsbild deines Avatars ersetzt.";

	/// <summary>
	/// Key: "Message.UpdateThisOutfit"
	/// English String: "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisOutfit => "Möchtest du dieses Outfit aktualisieren? Dadurch wird das Outfit mit dem aktuellen Erscheinungsbild deines Avatars ersetzt.";

	/// <summary>
	/// Key: "Message.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string MessageWarning => "Warnung";

	public AvatarResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvanced()
	{
		return "Fortgeschritten";
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Kaufen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "Erstellen";
	}

	protected override string _GetTemplateForActionCreateNewOutfit()
	{
		return "Erstellen";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForActionDone()
	{
		return "Fertig";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "Holen";
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "Mehr holen";
	}

	protected override string _GetTemplateForActionOpenRobloxApp()
	{
		return "Roblox-App öffnen";
	}

	protected override string _GetTemplateForActionRedraw()
	{
		return "Neu rendern";
	}

	protected override string _GetTemplateForActionRename()
	{
		return "Umbenennen";
	}

	protected override string _GetTemplateForActionRenameOutfit()
	{
		return "Umbenennen";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Speichern";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Alle ansehen";
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
		return "Aktualisieren";
	}

	protected override string _GetTemplateForActionUserUnderstands()
	{
		return "Verstanden";
	}

	protected override string _GetTemplateForDescriptionAvatarEditorUpsell()
	{
		return "Um dein Erscheinungsbild zu ändern, benötigst du den Avatar-Editor in der App.";
	}

	protected override string _GetTemplateForDescriptionCreateNewCostume()
	{
		return "Das Kostüm wird anhand des aktuellen Erscheinungsbilds deines Avatars erstellt.";
	}

	protected override string _GetTemplateForDescriptionCreateNewOutfit()
	{
		return "Das Outfit wird anhand des aktuellen Erscheinungsbilds deines Avatars erstellt.";
	}

	protected override string _GetTemplateForDescriptionRenameCostume()
	{
		return "Gib deinem Kostüm einen neuen Namen.";
	}

	protected override string _GetTemplateForDescriptionRenameOutfit()
	{
		return "Gib deinem Outfit einen neuen Namen.";
	}

	protected override string _GetTemplateForHeadingAccessories()
	{
		return "Accessoires";
	}

	protected override string _GetTemplateForHeadingAccessoriesChange()
	{
		return "Accessoires austauschen";
	}

	protected override string _GetTemplateForHeadingAdvancedOptions()
	{
		return "Fortgeschrittene Optionen";
	}

	protected override string _GetTemplateForHeadingAll()
	{
		return "Alle";
	}

	protected override string _GetTemplateForHeadingAnimations()
	{
		return "Animationen";
	}

	protected override string _GetTemplateForHeadingAppearance()
	{
		return "Erscheinungsbild";
	}

	protected override string _GetTemplateForHeadingAvatarPageTitle()
	{
		return "Avatar-Editor";
	}

	protected override string _GetTemplateForHeadingBody()
	{
		return "Körper";
	}

	protected override string _GetTemplateForHeadingBodyParts()
	{
		return "Körperteile";
	}

	protected override string _GetTemplateForHeadingClothing()
	{
		return "Kleidung";
	}

	protected override string _GetTemplateForHeadingCostumes()
	{
		return "Kostüme";
	}

	protected override string _GetTemplateForHeadingCreateNewCostume()
	{
		return "Neues Kostüm erstellen";
	}

	protected override string _GetTemplateForHeadingCreateNewOutfit()
	{
		return "Neues Outfit erstellen";
	}

	protected override string _GetTemplateForHeadingDelete()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForHeadingDeleteCostume()
	{
		return "Kostüm löschen";
	}

	protected override string _GetTemplateForHeadingDeleteOutfit()
	{
		return "Outfit löschen";
	}

	protected override string _GetTemplateForHeadingEmotes()
	{
		return "Emotes";
	}

	protected override string _GetTemplateForHeadingEquipEmotes()
	{
		return "Emotes ausrüsten";
	}

	protected override string _GetTemplateForHeadingOutfits()
	{
		return "Outfits";
	}

	protected override string _GetTemplateForHeadingPackages()
	{
		return "Pakete";
	}

	protected override string _GetTemplateForHeadingRecent()
	{
		return "Vor Kurzem";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "Empfohlen";
	}

	protected override string _GetTemplateForHeadingRenameCostume()
	{
		return "Kostüm umbenennen";
	}

	protected override string _GetTemplateForHeadingRenameOutfit()
	{
		return "Outfit umbenennen";
	}

	protected override string _GetTemplateForHeadingScaling()
	{
		return "Skalierung";
	}

	protected override string _GetTemplateForHeadingSkinToneBodyParts()
	{
		return "Hautfarbe nach Körperteilen";
	}

	protected override string _GetTemplateForHeadingUpdate()
	{
		return "Aktualisieren";
	}

	protected override string _GetTemplateForHeadingUpdateCostume()
	{
		return "Kostüm aktualisieren";
	}

	protected override string _GetTemplateForHeadingUpdateOutfit()
	{
		return "Outfit aktualisieren";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Alle";
	}

	protected override string _GetTemplateForLabelAskIfLoadingCorrectly()
	{
		return "Dein Avatar wird nicht richtig geladen?";
	}

	protected override string _GetTemplateForLabelAssetIDPlaceholder()
	{
		return "Objekt-ID";
	}

	protected override string _GetTemplateForLabelBack()
	{
		return "Rückseite";
	}

	protected override string _GetTemplateForLabelBackAccessories()
	{
		return "Rückseite-Accessoires";
	}

	protected override string _GetTemplateForLabelBodyType()
	{
		return "Körpertyp";
	}

	protected override string _GetTemplateForLabelClimb()
	{
		return "Klettern";
	}

	protected override string _GetTemplateForLabelClimbAnimations()
	{
		return "Kletteranimationen";
	}

	protected override string _GetTemplateForLabelClothes()
	{
		return "Kleidung";
	}

	protected override string _GetTemplateForLabelCostume()
	{
		return "Kostüm";
	}

	/// <summary>
	/// Key: "Label.DirectionsForPackagePlacement"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}"
	/// </summary>
	public override string LabelDirectionsForPackagePlacement(string startBold, string rightArrow, string endBold)
	{
		return $"Pakete wurden zu Kostümen verschoben. Suche {startBold}Kostüme{rightArrow}Vorgefertigte Kostüme{endBold}";
	}

	protected override string _GetTemplateForLabelDirectionsForPackagePlacement()
	{
		return "Pakete wurden zu Kostümen verschoben. Suche {startBold}Kostüme{rightArrow}Vorgefertigte Kostüme{endBold}";
	}

	/// <summary>
	/// Key: "Label.DirectionsForScalingOptions"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}"
	/// </summary>
	public override string LabelDirectionsForScalingOptions(string startBold, string rightArrow, string endBold)
	{
		return $"Skalierungsoptionen findest du in der Körperkategorie. Sieh unter {startBold}Körper{rightArrow}Skalierung{endBold} nach.";
	}

	protected override string _GetTemplateForLabelDirectionsForScalingOptions()
	{
		return "Skalierungsoptionen findest du in der Körperkategorie. Sieh unter {startBold}Körper{rightArrow}Skalierung{endBold} nach.";
	}

	protected override string _GetTemplateForlabelEmotes()
	{
		return "Emotes";
	}

	protected override string _GetTemplateForLabelEquip()
	{
		return "Ausrüsten";
	}

	protected override string _GetTemplateForLabelExploreCatalog()
	{
		return "Durchsuche den Katalog, um mehr Kleidung zu finden!";
	}

	protected override string _GetTemplateForLabelFace()
	{
		return "Gesicht";
	}

	protected override string _GetTemplateForLabelFaceAccessories()
	{
		return "Gesicht-Accessoires";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "Gesichter";
	}

	protected override string _GetTemplateForLabelFall()
	{
		return "Fallen";
	}

	protected override string _GetTemplateForLabelFallAnimations()
	{
		return "Fallanimationen";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "Gratis";
	}

	protected override string _GetTemplateForLabelFront()
	{
		return "Vorderseite";
	}

	protected override string _GetTemplateForLabelFrontAccessories()
	{
		return "Vorderseite-Accessoires";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "Ausrüstung";
	}

	protected override string _GetTemplateForLabelHair()
	{
		return "Haare";
	}

	protected override string _GetTemplateForLabelHairAccessories()
	{
		return "Haar-Accessoires";
	}

	protected override string _GetTemplateForLabelHat()
	{
		return "Hut";
	}

	protected override string _GetTemplateForLabelHatAccessories()
	{
		return "Hut-Accessoires";
	}

	protected override string _GetTemplateForLabelHead()
	{
		return "Kopf";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "Köpfe";
	}

	protected override string _GetTemplateForLabelHeight()
	{
		return "Höhe";
	}

	protected override string _GetTemplateForLabelIdle()
	{
		return "Untätig";
	}

	protected override string _GetTemplateForLabelIdleAnimations()
	{
		return "Untätige Animationen";
	}

	protected override string _GetTemplateForLabelJump()
	{
		return "Springen";
	}

	protected override string _GetTemplateForLabelJumpAnimations()
	{
		return "Springanimationen";
	}

	protected override string _GetTemplateForLabelLeftArm()
	{
		return "Linker Arm";
	}

	protected override string _GetTemplateForLabelLeftArms()
	{
		return "Linke Arme";
	}

	protected override string _GetTemplateForLabelLeftLeg()
	{
		return "Linkes Bein";
	}

	protected override string _GetTemplateForLabelLeftLegs()
	{
		return "Linke Beine";
	}

	protected override string _GetTemplateForLabelMyCostumes()
	{
		return "Meine Kostüme";
	}

	protected override string _GetTemplateForLabelNamePlaceholderCostume()
	{
		return "Benenne dein Kostüm";
	}

	protected override string _GetTemplateForLabelNamePlaceholderOutfit()
	{
		return "Benenne dein Outfit";
	}

	protected override string _GetTemplateForLabelNeck()
	{
		return "Hals";
	}

	protected override string _GetTemplateForLabelNeckAccessories()
	{
		return "Hals-Accessoires";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "Keine Wiederverkäufer";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "Nicht mehr im Angebot";
	}

	protected override string _GetTemplateForLabelOutfit()
	{
		return "Outfit";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "Hosen";
	}

	protected override string _GetTemplateForLabelParts()
	{
		return "Teile";
	}

	protected override string _GetTemplateForLabelPresetCostumes()
	{
		return "Vorgefertigte Kostüme";
	}

	protected override string _GetTemplateForLabelProportions()
	{
		return "Proportionen";
	}

	protected override string _GetTemplateForLabelRedrawUnavailable()
	{
		return "Avatar kann nicht neu gerendert werden.";
	}

	protected override string _GetTemplateForLabelRightArm()
	{
		return "Rechter Arm";
	}

	protected override string _GetTemplateForLabelRightArms()
	{
		return "Rechte Arme";
	}

	protected override string _GetTemplateForLabelRightLeg()
	{
		return "Rechtes Bein";
	}

	protected override string _GetTemplateForLabelRightLegs()
	{
		return "Rechte Beine";
	}

	protected override string _GetTemplateForLabelRun()
	{
		return "Laufen";
	}

	protected override string _GetTemplateForLabelRunAnimations()
	{
		return "Laufanimationen";
	}

	protected override string _GetTemplateForLabelScale()
	{
		return "Größe";
	}

	protected override string _GetTemplateForLabelShirts()
	{
		return "Hemden";
	}

	protected override string _GetTemplateForLabelShoulderAccessories()
	{
		return "Schulter-Accessoires";
	}

	protected override string _GetTemplateForLabelShoulders()
	{
		return "Schultern";
	}

	protected override string _GetTemplateForLabelSkinTone()
	{
		return "Hautfarbe";
	}

	protected override string _GetTemplateForLabelSwim()
	{
		return "Schwimmen";
	}

	protected override string _GetTemplateForLabelSwimAnimations()
	{
		return "Schwimmanimationen";
	}

	protected override string _GetTemplateForLabelSwitchAvatarType()
	{
		return "Schalte zwischen dem klassischen R6-Avatar und dem ausdrucksstärkeren, modernen R15-Avatar um.";
	}

	protected override string _GetTemplateForLabelTorso()
	{
		return "Torso";
	}

	protected override string _GetTemplateForLabelTorsos()
	{
		return "Torsos";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "T-Shirts";
	}

	protected override string _GetTemplateForLabelWaist()
	{
		return "Taille";
	}

	protected override string _GetTemplateForLabelWaistAccessories()
	{
		return "Taille-Accessoires";
	}

	protected override string _GetTemplateForLabelWalk()
	{
		return "Gehen";
	}

	protected override string _GetTemplateForLabelWalkAnimations()
	{
		return "Gehanimationen";
	}

	protected override string _GetTemplateForLabelWidth()
	{
		return "Breite";
	}

	protected override string _GetTemplateForLabelYourEmotes()
	{
		return "Deine Emotes";
	}

	protected override string _GetTemplateForMessageAccessoriesChange()
	{
		return "Möchtest du deinen aktuellen Look wirklich ersetzen?";
	}

	protected override string _GetTemplateForMessageChooseEmote()
	{
		return "Emote auswählen";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlot()
	{
		return "Wähle einen Steckplatz";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlotOrEmote()
	{
		return "Wähle einen Steckplatz oder ein Emote aus";
	}

	protected override string _GetTemplateForMessageDefaultClothing()
	{
		return "Dein Avatar trägt die Standardkleidung. Zieh doch etwas aus deiner Kleidungssammlung an.";
	}

	/// <summary>
	/// Key: "Message.DeleteOutfit"
	/// English String: "Are you sure you want to delete this {outfitType}?"
	/// </summary>
	public override string MessageDeleteOutfit(string outfitType)
	{
		return $"Möchtest du „{outfitType}“ wirklich löschen?";
	}

	protected override string _GetTemplateForMessageDeleteOutfit()
	{
		return "Möchtest du „{outfitType}“ wirklich löschen?";
	}

	protected override string _GetTemplateForMessageDeleteThisCostume()
	{
		return "Möchtest du dieses Kostüm wirklich löschen?";
	}

	protected override string _GetTemplateForMessageDeleteThisOutfit()
	{
		return "Möchtest du dieses Outfit wirklich löschen?";
	}

	protected override string _GetTemplateForMessageEmotesInstructions()
	{
		return "Gehe zu „Animationen“> „Emotes“> „Emotes ausrüsten“, um ein Emote auszurüsten.";
	}

	protected override string _GetTemplateForMessageEmptyAssetList()
	{
		return "Du hast keine.";
	}

	/// <summary>
	/// Key: "Message.EmptyListForItem"
	/// The user tries to load a list of some item but they see nothing because they don't own anything of that type.
	/// English String: "You don't have this item: {itemType}"
	/// </summary>
	public override string MessageEmptyListForItem(string itemType)
	{
		return $"Du hast diesen Artikel nicht: {itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListForItem()
	{
		return "Du hast diesen Artikel nicht: {itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListOfCostumes()
	{
		return "Du hast keine Kostüme. Erstell doch eins!";
	}

	protected override string _GetTemplateForMessageEmptyListOfOutfits()
	{
		return "Du hast keine Outfits. Erstell doch eins!";
	}

	protected override string _GetTemplateForMessageEmptyRecentItems()
	{
		return "Du hast keine kürzlich verwendeten Artikel.";
	}

	protected override string _GetTemplateForMessageErrorCreateCostume()
	{
		return "Kostüm kann nicht erstellt werden. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageErrorCreateOutfit()
	{
		return "Outfit kann nicht erstellt werden. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageErrorDeleteEmote()
	{
		return "Emote konnte nicht gelöscht werden.";
	}

	protected override string _GetTemplateForMessageErrorEquipEmote()
	{
		return "Emote konnte nicht ausgerüstet werden, bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageErrorLoadCostume()
	{
		return "Kostüm konnte nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageErrorLoadEmotes()
	{
		return "Emotes konnten nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageErrorLoadOutfits()
	{
		return "Outfits konnten nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageErrorOutfitName()
	{
		return "Namen können Buchstaben, Ziffern und Leerzeichen enthalten.";
	}

	protected override string _GetTemplateForMessageErrorRenameCostume()
	{
		return "Kostüm konnte nicht umbenannt werden.";
	}

	protected override string _GetTemplateForMessageErrorRenameOutfit()
	{
		return "Outfit konnte nicht umbenannt werden.";
	}

	protected override string _GetTemplateForMessageErrorUnequipEmote()
	{
		return "Emote konnte nicht ausgerüstet werden.";
	}

	protected override string _GetTemplateForMessageErrorUpdateCostume()
	{
		return "Aktualisieren des Kostüms fehlgeschlagen. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageErrorUpdateEmote()
	{
		return "Die Aktualisierung des Emote-Steckplatzes ist fehlgeschlagen, bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageErrorUpdateOutfit()
	{
		return "Aktualisieren des Outfits fehlgeschlagen. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageErrorUpdateWorn()
	{
		return "Fehler beim Aktualisieren der getragenen Artikel.";
	}

	protected override string _GetTemplateForMessageErrorWearCostume()
	{
		return "Kostüm konnte nicht getragen werden.";
	}

	protected override string _GetTemplateForMessageErrorWearOutfit()
	{
		return "Outfit konnte nicht getragen werden.";
	}

	protected override string _GetTemplateForMessageFailedDeleteCostume()
	{
		return "Kostüm konnte nicht gelöscht werden.";
	}

	protected override string _GetTemplateForMessageFailedDeleteEmote()
	{
		return "Emote konnte nicht gelöscht werden.";
	}

	protected override string _GetTemplateForMessageFailedDeleteOutfit()
	{
		return "Outfit konnte nicht gelöscht werden.";
	}

	protected override string _GetTemplateForMessageFailedLoadAssets()
	{
		return "Objektliste konnte nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageFailedLoadRecent()
	{
		return "Kürzlich verwendete Artikel konnten nicht geladen werden.";
	}

	protected override string _GetTemplateForMessageFailedUpdateBodyColor()
	{
		return "Hautfarbe konnte nicht aktualisiert werden.";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedCostume()
	{
		return "Das Kostüm, das du aktualisieren wolltest, existiert nicht mehr.";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedOutfit()
	{
		return "Das Outfit, das du aktualisieren wolltest, existiert nicht mehr.";
	}

	protected override string _GetTemplateForMessageFailedUpdateScales()
	{
		return "Größen konnten nicht aktualisiert werden.";
	}

	protected override string _GetTemplateForMessageFailedUpdateType()
	{
		return "Avatar-Art konnte nicht aktualisiert werden.";
	}

	protected override string _GetTemplateForMessageFailedWearPackage()
	{
		return "Paket konnte nicht getragen werden.";
	}

	protected override string _GetTemplateForMessageHatLimitTooltip()
	{
		return "Du kannst bis zu 3 Hüte tragen.";
	}

	protected override string _GetTemplateForMessageInvalidOutfitName()
	{
		return "Name muss angemessen sein und aus weniger als 200 Zeichen bestehen.";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "Wird geladen\u00a0...";
	}

	/// <summary>
	/// Key: "Message.MissingItemsFromOutfit"
	/// User cannot wear an outfit because they are missing or have deleted some of the items that were part of that outfit.
	/// English String: "Number of items that you don't own in this outfit: {number}"
	/// </summary>
	public override string MessageMissingItemsFromOutfit(string number)
	{
		return $"Anzahl der Artikel in diesem Outfit, die du nicht besitzt: {number}";
	}

	protected override string _GetTemplateForMessageMissingItemsFromOutfit()
	{
		return "Anzahl der Artikel in diesem Outfit, die du nicht besitzt: {number}";
	}

	protected override string _GetTemplateForMessagePageUnavailable()
	{
		return "Die Avatarseite ist vorübergehend nicht verfügbar.";
	}

	protected override string _GetTemplateForMessagePresetCostumesDelay()
	{
		return "Hinweis: Wir räumen etwas auf, also kann es ein paar Minuten dauern, bis alle deine Kostüme erscheinen. Bitte sieh später wieder nach!";
	}

	protected override string _GetTemplateForMessageReachedMaxCostumes()
	{
		return "Du hast die maximale Anzahl an Kostümen erreicht.";
	}

	protected override string _GetTemplateForMessageReachedMaxOutfits()
	{
		return "Du hast die maximale Anzahl an Outfits erreicht.";
	}

	protected override string _GetTemplateForMessageRedirectAvatarSettings()
	{
		return "Die Avatar-Einstellungen kannst du über dein Roblox-Studio-Projekt bearbeiten. Gehe dazu in Roblox Studio zu Hauptmenü > Spieleinstellungen > Avatar";
	}

	protected override string _GetTemplateForMessageRedrawFloodchecked()
	{
		return "Du hast deinen Avatar zu oft neu gerendert. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageRedrawThumbnailFailed()
	{
		return "Miniaturansicht konnte nicht neu gerendert werden.";
	}

	protected override string _GetTemplateForMessageSelectEnableScaling()
	{
		return "Wähle R15, um Skalierung zu aktivieren.";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "Erfolg";
	}

	protected override string _GetTemplateForMessageSuccessCreateCostume()
	{
		return "Kostüm erstellt";
	}

	protected override string _GetTemplateForMessageSuccessCreateOutfit()
	{
		return "Outfit erstellt";
	}

	protected override string _GetTemplateForMessageSuccessDeleteCostume()
	{
		return "Kostüm gelöscht";
	}

	protected override string _GetTemplateForMessageSuccessDeleteOutfit()
	{
		return "Outfit gelöscht";
	}

	protected override string _GetTemplateForMessageSuccessEquipEmote()
	{
		return "Emote wurde ausgerüstet";
	}

	protected override string _GetTemplateForMessageSuccessRenameCostume()
	{
		return "Kostüm umbenannt";
	}

	protected override string _GetTemplateForMessageSuccessRenameOutfit()
	{
		return "Outfit umbenannt";
	}

	protected override string _GetTemplateForMessageSuccessSavedAccessories()
	{
		return "Accessoires gespeichert";
	}

	protected override string _GetTemplateForMessageSuccessUnequipEmote()
	{
		return "Emote nicht ausgerüstet";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedCostume()
	{
		return "Kostüm aktualisiert";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedOutfit()
	{
		return "Outfit aktualisiert";
	}

	protected override string _GetTemplateForMessageSuccessWoreCostume()
	{
		return "Kostüm erfolgreich angelegt";
	}

	protected override string _GetTemplateForMessageSuccessWoreOutfit()
	{
		return "Outfit erfolgreich angelegt";
	}

	/// <summary>
	/// Key: "Message.UpdateOutfit"
	/// English String: "Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateOutfit(string outfitType1, string outfitType2)
	{
		return $"Möchtest du „{outfitType1}“ aktualisieren? Dadurch wird „{outfitType2}“ mit dem aktuellen Erscheinungsbild deines Avatars ersetzt.";
	}

	protected override string _GetTemplateForMessageUpdateOutfit()
	{
		return "Möchtest du „{outfitType1}“ aktualisieren? Dadurch wird „{outfitType2}“ mit dem aktuellen Erscheinungsbild deines Avatars ersetzt.";
	}

	protected override string _GetTemplateForMessageUpdateThisCostume()
	{
		return "Möchtest du dieses Kostüm aktualisieren? Dadurch wird das Kostüm mit dem aktuellen Erscheinungsbild deines Avatars ersetzt.";
	}

	protected override string _GetTemplateForMessageUpdateThisOutfit()
	{
		return "Möchtest du dieses Outfit aktualisieren? Dadurch wird das Outfit mit dem aktuellen Erscheinungsbild deines Avatars ersetzt.";
	}

	protected override string _GetTemplateForMessageWarning()
	{
		return "Warnung";
	}
}
