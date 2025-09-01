using System;
using System.Collections.Generic;
namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides AvatarResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AvatarResources_pt_br : AvatarResources_en_us, IAvatarResources, ITranslationResources
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
	public override string ActionAdvanced => "AvanÃƒÂ§ado";

	/// <summary>
	/// Key: "Action.Buy"
	/// Button used to buy an item to customize the user's avatar.
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "Comprar";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fechar";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "Criar";

	/// <summary>
	/// Key: "Action.CreateNewOutfit"
	/// Button to create new outfit
	/// English String: "Create"
	/// </summary>
	public override string ActionCreateNewOutfit => "Criar";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Excluir";

	/// <summary>
	/// Key: "Action.Done"
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "Pronto";

	/// <summary>
	/// Key: "Action.Get"
	/// Button used to buy get an item for free to customize the user's avatar.
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "Obter";

	/// <summary>
	/// Key: "Action.GetMore"
	/// A call to action for the user to buy more clothes from the Catalog page. This could improve how their avatar looks.
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "Obter mais";

	/// <summary>
	/// Key: "Action.OpenRobloxApp"
	/// English String: "Open Roblox App"
	/// </summary>
	public override string ActionOpenRobloxApp => "Abrir o app do Roblox";

	/// <summary>
	/// Key: "Action.Redraw"
	/// Redraw the avatar on the screen
	/// English String: "Redraw"
	/// </summary>
	public override string ActionRedraw => "Redesenhar";

	/// <summary>
	/// Key: "Action.Rename"
	/// English String: "Rename"
	/// </summary>
	public override string ActionRename => "Renomear";

	/// <summary>
	/// Key: "Action.RenameOutfit"
	/// Button to rename outfit
	/// English String: "Rename"
	/// </summary>
	public override string ActionRenameOutfit => "Renomear";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Salvar";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// See all clothing that user can buy
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ver todos";

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
	public override string ActionUpdate => "AtualizaÃƒÂ§ÃƒÂ£o";

	/// <summary>
	/// Key: "Action.UserUnderstands"
	/// The user casually responds to the application saying that they understand how to navigate the menu.
	/// English String: "Got it"
	/// </summary>
	public override string ActionUserUnderstands => "Entendi";

	/// <summary>
	/// Key: "Description.AvatarEditorUpsell"
	/// English String: "To change your look you will need to use the Avatar Editor on the App."
	/// </summary>
	public override string DescriptionAvatarEditorUpsell => "Para mudar seu visual, vocÃƒÂª terÃƒÂ¡ que usar o Editor de Avatar do app.";

	/// <summary>
	/// Key: "Description.CreateNewCostume"
	/// A costume will be created from your avatar's current appearance.
	/// English String: "A costume will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewCostume => "Uma fantasia serÃƒÂ¡ criada a partir da aparÃƒÂªncia atual do seu avatar.";

	/// <summary>
	/// Key: "Description.CreateNewOutfit"
	/// An outfit will be created from your avatar's current appearance.
	/// English String: "An outfit will be created from your avatar's current appearance."
	/// </summary>
	public override string DescriptionCreateNewOutfit => "Um traje serÃƒÂ¡ criado a partir da aparÃƒÂªncia atual do seu avatar.";

	/// <summary>
	/// Key: "Description.RenameCostume"
	/// Choose a new name for your costume.
	/// English String: "Choose a new name for your costume."
	/// </summary>
	public override string DescriptionRenameCostume => "Escolha um novo nome para a sua fantasia.";

	/// <summary>
	/// Key: "Description.RenameOutfit"
	/// Choose a new name for your outfit.
	/// English String: "Choose a new name for your outfit."
	/// </summary>
	public override string DescriptionRenameOutfit => "Escolha um novo nome para o seu traje.";

	/// <summary>
	/// Key: "Heading.Accessories"
	/// English String: "Accessories"
	/// </summary>
	public override string HeadingAccessories => "AcessÃƒÂ³rios";

	/// <summary>
	/// Key: "Heading.AccessoriesChange"
	/// English String: "Accessories Change"
	/// </summary>
	public override string HeadingAccessoriesChange => "AlteraÃƒÂ§ÃƒÂ£o de acessÃƒÂ³rios";

	/// <summary>
	/// Key: "Heading.AdvancedOptions"
	/// English String: "Advanced Options"
	/// </summary>
	public override string HeadingAdvancedOptions => "OpÃƒÂ§ÃƒÂµes avanÃƒÂ§adas";

	/// <summary>
	/// Key: "Heading.All"
	/// All avatar modification types
	/// English String: "All"
	/// </summary>
	public override string HeadingAll => "Todas";

	/// <summary>
	/// Key: "Heading.Animations"
	/// English String: "Animations"
	/// </summary>
	public override string HeadingAnimations => "AnimaÃƒÂ§ÃƒÂµes";

	/// <summary>
	/// Key: "Heading.Appearance"
	/// English String: "Appearance"
	/// </summary>
	public override string HeadingAppearance => "AparÃƒÂªncia";

	/// <summary>
	/// Key: "Heading.AvatarPageTitle"
	/// Page title for the Avatar page. On this page, the user can modify how they look.
	/// English String: "Avatar Editor"
	/// </summary>
	public override string HeadingAvatarPageTitle => "Editor de avatar";

	/// <summary>
	/// Key: "Heading.Body"
	/// English String: "Body"
	/// </summary>
	public override string HeadingBody => "Corpo";

	/// <summary>
	/// Key: "Heading.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string HeadingBodyParts => "Parte do corpo";

	/// <summary>
	/// Key: "Heading.Clothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingClothing => "Roupas";

	/// <summary>
	/// Key: "Heading.Costumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Costumes"
	/// </summary>
	public override string HeadingCostumes => "Fantasias";

	/// <summary>
	/// Key: "Heading.CreateNewCostume"
	/// NOTE: Costume is a more whimsical word choice for outfit. Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Create New Costume"
	/// </summary>
	public override string HeadingCreateNewCostume => "Criar nova fantasia";

	/// <summary>
	/// Key: "Heading.CreateNewOutfit"
	/// English String: "Create New Outfit"
	/// </summary>
	public override string HeadingCreateNewOutfit => "Criar novo traje";

	/// <summary>
	/// Key: "Heading.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string HeadingDelete => "Excluir";

	/// <summary>
	/// Key: "Heading.DeleteCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Delete Costume"
	/// </summary>
	public override string HeadingDeleteCostume => "Excluir fantasia";

	/// <summary>
	/// Key: "Heading.DeleteOutfit"
	/// English String: "Delete Outfit"
	/// </summary>
	public override string HeadingDeleteOutfit => "Excluir traje";

	/// <summary>
	/// Key: "Heading.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string HeadingEmotes => "Emotes";

	/// <summary>
	/// Key: "Heading.EquipEmotes"
	/// English String: "Equip Emotes"
	/// </summary>
	public override string HeadingEquipEmotes => "Equipar emotes";

	/// <summary>
	/// Key: "Heading.Outfits"
	/// English String: "Outfits"
	/// </summary>
	public override string HeadingOutfits => "Trajes";

	/// <summary>
	/// Key: "Heading.Packages"
	/// English String: "Packages"
	/// </summary>
	public override string HeadingPackages => "Pacotes";

	/// <summary>
	/// Key: "Heading.Recent"
	/// English String: "Recent"
	/// </summary>
	public override string HeadingRecent => "Recentes";

	/// <summary>
	/// Key: "Heading.Recommended"
	/// See recommended clothing for your avatar
	/// English String: "Recommended"
	/// </summary>
	public override string HeadingRecommended => "Recomendados";

	/// <summary>
	/// Key: "Heading.RenameCostume"
	/// English String: "Rename Costume"
	/// </summary>
	public override string HeadingRenameCostume => "Renomear fantasia";

	/// <summary>
	/// Key: "Heading.RenameOutfit"
	/// English String: "Rename Outfit"
	/// </summary>
	public override string HeadingRenameOutfit => "Renomear traje";

	/// <summary>
	/// Key: "Heading.Scaling"
	/// English String: "Scaling"
	/// </summary>
	public override string HeadingScaling => "Dimensionamento";

	/// <summary>
	/// Key: "Heading.SkinToneBodyParts"
	/// English String: "Skin Tone by Body Parts"
	/// </summary>
	public override string HeadingSkinToneBodyParts => "Cor de pele por parte do corpo";

	/// <summary>
	/// Key: "Heading.Update"
	/// English String: "Update"
	/// </summary>
	public override string HeadingUpdate => "AtualizaÃƒÂ§ÃƒÂ£o";

	/// <summary>
	/// Key: "Heading.UpdateCostume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Update Costume"
	/// </summary>
	public override string HeadingUpdateCostume => "Atualizar fantasia";

	/// <summary>
	/// Key: "Heading.UpdateOutfit"
	/// English String: "Update Outfit"
	/// </summary>
	public override string HeadingUpdateOutfit => "Atualizar traje";

	/// <summary>
	/// Key: "Label.All"
	/// All body parts. This label will allow for body parts to change color
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Todas";

	/// <summary>
	/// Key: "Label.AskIfLoadingCorrectly"
	/// Avatar isn't loading correctly?
	/// English String: "Avatar isn't loading correctly?"
	/// </summary>
	public override string LabelAskIfLoadingCorrectly => "O avatar nÃƒÂ£o estÃƒÂ¡ carregando corretamente?";

	/// <summary>
	/// Key: "Label.AssetIDPlaceholder"
	/// This refers to the Asset ID which is a technical word for the Identification Number of an item or asset.
	/// English String: "Asset ID"
	/// </summary>
	public override string LabelAssetIDPlaceholder => "ID do elemento";

	/// <summary>
	/// Key: "Label.Back"
	/// English String: "Back"
	/// </summary>
	public override string LabelBack => "Costas";

	/// <summary>
	/// Key: "Label.BackAccessories"
	/// English String: "Back Accessories"
	/// </summary>
	public override string LabelBackAccessories => "AcessÃƒÂ³rios de trÃƒÂ¡s";

	/// <summary>
	/// Key: "Label.BodyType"
	/// English String: "Body Type"
	/// </summary>
	public override string LabelBodyType => "Tipo de corpo";

	/// <summary>
	/// Key: "Label.Climb"
	/// English String: "Climb"
	/// </summary>
	public override string LabelClimb => "Escalar";

	/// <summary>
	/// Key: "Label.ClimbAnimations"
	/// English String: "Climb Animations"
	/// </summary>
	public override string LabelClimbAnimations => "AnimaÃƒÂ§ÃƒÂµes de escalada";

	/// <summary>
	/// Key: "Label.Clothes"
	/// English String: "Clothes"
	/// </summary>
	public override string LabelClothes => "Roupas";

	/// <summary>
	/// Key: "Label.Costume"
	/// NOTE: Any instance of the word "Outfit" will eventually be swapped out for "Costume" This is not currently in the UI
	/// English String: "Costume"
	/// </summary>
	public override string LabelCostume => "Fantasia";

	/// <summary>
	/// Key: "label.Emotes"
	/// English String: "Emotes"
	/// </summary>
	public override string labelEmotes => "Emotes";

	/// <summary>
	/// Key: "Label.Equip"
	/// English String: "Equip"
	/// </summary>
	public override string LabelEquip => "Equipar";

	/// <summary>
	/// Key: "Label.ExploreCatalog"
	/// This text entices users to shop for more things to wear on their avatar
	/// English String: "Explore the catalog to find more clothes!"
	/// </summary>
	public override string LabelExploreCatalog => "Explore o catÃƒÂ¡logo para encontrar mais roupas!";

	/// <summary>
	/// Key: "Label.Face"
	/// English String: "Face"
	/// </summary>
	public override string LabelFace => "Rosto";

	/// <summary>
	/// Key: "Label.FaceAccessories"
	/// English String: "Face Accessories"
	/// </summary>
	public override string LabelFaceAccessories => "AcessÃƒÂ³rios de rosto";

	/// <summary>
	/// Key: "Label.Faces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "Rostos";

	/// <summary>
	/// Key: "Label.Fall"
	/// English String: "Fall"
	/// </summary>
	public override string LabelFall => "Cair";

	/// <summary>
	/// Key: "Label.FallAnimations"
	/// English String: "Fall Animations"
	/// </summary>
	public override string LabelFallAnimations => "AnimaÃƒÂ§ÃƒÂµes de queda";

	/// <summary>
	/// Key: "Label.Free"
	/// Text label for recommended items
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "GrÃƒÂ¡tis";

	/// <summary>
	/// Key: "Label.Front"
	/// English String: "Front"
	/// </summary>
	public override string LabelFront => "Frente";

	/// <summary>
	/// Key: "Label.FrontAccessories"
	/// English String: "Front Accessories"
	/// </summary>
	public override string LabelFrontAccessories => "AcessÃƒÂ³rios da frente";

	/// <summary>
	/// Key: "Label.Gear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "Equipamento";

	/// <summary>
	/// Key: "Label.Hair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelHair => "Cabelo";

	/// <summary>
	/// Key: "Label.HairAccessories"
	/// English String: "Hair Accessories"
	/// </summary>
	public override string LabelHairAccessories => "AcessÃƒÂ³rios de cabelo";

	/// <summary>
	/// Key: "Label.Hat"
	/// English String: "Hat"
	/// </summary>
	public override string LabelHat => "ChapÃƒÂ©u";

	/// <summary>
	/// Key: "Label.HatAccessories"
	/// English String: "Hat Accessories"
	/// </summary>
	public override string LabelHatAccessories => "AcessÃƒÂ³rios de chapÃƒÂ©u";

	/// <summary>
	/// Key: "Label.Head"
	/// English String: "Head"
	/// </summary>
	public override string LabelHead => "CabeÃƒÂ§a";

	/// <summary>
	/// Key: "Label.Heads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "CabeÃƒÂ§as";

	/// <summary>
	/// Key: "Label.Height"
	/// English String: "Height"
	/// </summary>
	public override string LabelHeight => "Altura";

	/// <summary>
	/// Key: "Label.Idle"
	/// English String: "Idle"
	/// </summary>
	public override string LabelIdle => "Inatividade";

	/// <summary>
	/// Key: "Label.IdleAnimations"
	/// English String: "Idle Animations"
	/// </summary>
	public override string LabelIdleAnimations => "AnimaÃƒÂ§ÃƒÂµes de inatividade";

	/// <summary>
	/// Key: "Label.Jump"
	/// English String: "Jump"
	/// </summary>
	public override string LabelJump => "Pular";

	/// <summary>
	/// Key: "Label.JumpAnimations"
	/// English String: "Jump Animations"
	/// </summary>
	public override string LabelJumpAnimations => "AnimaÃƒÂ§ÃƒÂµes de salto";

	/// <summary>
	/// Key: "Label.LeftArm"
	/// English String: "Left Arm"
	/// </summary>
	public override string LabelLeftArm => "BraÃƒÂ§o esquerdo";

	/// <summary>
	/// Key: "Label.LeftArms"
	/// English String: "Left Arms"
	/// </summary>
	public override string LabelLeftArms => "BraÃƒÂ§os esquerdos";

	/// <summary>
	/// Key: "Label.LeftLeg"
	/// English String: "Left Leg"
	/// </summary>
	public override string LabelLeftLeg => "Perna esquerda";

	/// <summary>
	/// Key: "Label.LeftLegs"
	/// English String: "Left Legs"
	/// </summary>
	public override string LabelLeftLegs => "Pernas esquerdas";

	/// <summary>
	/// Key: "Label.MyCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "My Costumes"
	/// </summary>
	public override string LabelMyCostumes => "Minhas fantasias";

	/// <summary>
	/// Key: "Label.NamePlaceholderCostume"
	/// English String: "Name your costume"
	/// </summary>
	public override string LabelNamePlaceholderCostume => "DÃƒÂª um nome a sua fantasia";

	/// <summary>
	/// Key: "Label.NamePlaceholderOutfit"
	/// English String: "Name your outfit"
	/// </summary>
	public override string LabelNamePlaceholderOutfit => "DÃƒÂª um nome ao seu traje";

	/// <summary>
	/// Key: "Label.Neck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelNeck => "PescoÃƒÂ§o";

	/// <summary>
	/// Key: "Label.NeckAccessories"
	/// English String: "Neck Accessories"
	/// </summary>
	public override string LabelNeckAccessories => "AcessÃƒÂ³rios de pescoÃƒÂ§o";

	/// <summary>
	/// Key: "Label.NoResellers"
	/// Text label for recommended items
	/// English String: "No resellers"
	/// </summary>
	public override string LabelNoResellers => "Nenhum revendedor";

	/// <summary>
	/// Key: "Label.OffSale"
	/// Text label for recommended items
	/// English String: "Off sale"
	/// </summary>
	public override string LabelOffSale => "IndisponÃƒÂ­vel";

	/// <summary>
	/// Key: "Label.Outfit"
	/// English String: "Outfit"
	/// </summary>
	public override string LabelOutfit => "Traje";

	/// <summary>
	/// Key: "Label.Pants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "CalÃƒÂ§as";

	/// <summary>
	/// Key: "Label.Parts"
	/// English String: "Parts"
	/// </summary>
	public override string LabelParts => "Partes";

	/// <summary>
	/// Key: "Label.PresetCostumes"
	/// NOTE: Any instance of the word "Outfits" will eventually be swapped out for "Costumes" This is not currently in the UI
	/// English String: "Preset Costumes"
	/// </summary>
	public override string LabelPresetCostumes => "Fantasias predefinidas";

	/// <summary>
	/// Key: "Label.Proportions"
	/// English String: "Proportions"
	/// </summary>
	public override string LabelProportions => "ProporÃƒÂ§ÃƒÂµes";

	/// <summary>
	/// Key: "Label.RedrawUnavailable"
	/// Avatar redraw is unavailable
	/// English String: "Avatar redraw is unavailable."
	/// </summary>
	public override string LabelRedrawUnavailable => "FunÃƒÂ§ÃƒÂ£o de redesenhar avatar nÃƒÂ£o disponÃƒÂ­vel.";

	/// <summary>
	/// Key: "Label.RightArm"
	/// English String: "Right Arm"
	/// </summary>
	public override string LabelRightArm => "BraÃƒÂ§o direito";

	/// <summary>
	/// Key: "Label.RightArms"
	/// English String: "Right Arms"
	/// </summary>
	public override string LabelRightArms => "BraÃƒÂ§os direitos";

	/// <summary>
	/// Key: "Label.RightLeg"
	/// English String: "Right Leg"
	/// </summary>
	public override string LabelRightLeg => "Perna direita";

	/// <summary>
	/// Key: "Label.RightLegs"
	/// English String: "Right Legs"
	/// </summary>
	public override string LabelRightLegs => "Pernas direitas";

	/// <summary>
	/// Key: "Label.Run"
	/// English String: "Run"
	/// </summary>
	public override string LabelRun => "Correr";

	/// <summary>
	/// Key: "Label.RunAnimations"
	/// English String: "Run Animations"
	/// </summary>
	public override string LabelRunAnimations => "AnimaÃƒÂ§ÃƒÂµes de corrida";

	/// <summary>
	/// Key: "Label.Scale"
	/// English String: "Scale"
	/// </summary>
	public override string LabelScale => "Dimensionar";

	/// <summary>
	/// Key: "Label.Shirts"
	/// English String: "Shirts"
	/// </summary>
	public override string LabelShirts => "Camisas";

	/// <summary>
	/// Key: "Label.ShoulderAccessories"
	/// English String: "Shoulder Accessories"
	/// </summary>
	public override string LabelShoulderAccessories => "AcessÃƒÂ³rios de ombro";

	/// <summary>
	/// Key: "Label.Shoulders"
	/// English String: "Shoulders"
	/// </summary>
	public override string LabelShoulders => "Ombros";

	/// <summary>
	/// Key: "Label.SkinTone"
	/// English String: "Skin Tone"
	/// </summary>
	public override string LabelSkinTone => "Cor de pele";

	/// <summary>
	/// Key: "Label.Swim"
	/// English String: "Swim"
	/// </summary>
	public override string LabelSwim => "Nadar";

	/// <summary>
	/// Key: "Label.SwimAnimations"
	/// English String: "Swim Animations"
	/// </summary>
	public override string LabelSwimAnimations => "AnimaÃƒÂ§ÃƒÂµes de nado";

	/// <summary>
	/// Key: "Label.SwitchAvatarType"
	/// User is able to increase the number of joints in their avatar from 6 to 15. R15 moves better. See http://roblox.wikia.com/wiki/R15
	/// English String: "Switch between classic R6 avatar and more expressive next generation R15 avatar"
	/// </summary>
	public override string LabelSwitchAvatarType => "Troque entre o avatar clÃƒÂ¡ssico R6 e o avatar de nova geraÃƒÂ§ÃƒÂ£o mais expressivo R15";

	/// <summary>
	/// Key: "Label.Torso"
	/// English String: "Torso"
	/// </summary>
	public override string LabelTorso => "Tronco";

	/// <summary>
	/// Key: "Label.Torsos"
	/// English String: "Torsos"
	/// </summary>
	public override string LabelTorsos => "Troncos";

	/// <summary>
	/// Key: "Label.TShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "Camisetas";

	/// <summary>
	/// Key: "Label.Waist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelWaist => "Cintura";

	/// <summary>
	/// Key: "Label.WaistAccessories"
	/// English String: "Waist Accessories"
	/// </summary>
	public override string LabelWaistAccessories => "AcessÃƒÂ³rios de cintura";

	/// <summary>
	/// Key: "Label.Walk"
	/// English String: "Walk"
	/// </summary>
	public override string LabelWalk => "Andar";

	/// <summary>
	/// Key: "Label.WalkAnimations"
	/// English String: "Walk Animations"
	/// </summary>
	public override string LabelWalkAnimations => "AnimaÃƒÂ§ÃƒÂµes de caminhada";

	/// <summary>
	/// Key: "Label.Width"
	/// English String: "Width"
	/// </summary>
	public override string LabelWidth => "Largura";

	/// <summary>
	/// Key: "Label.YourEmotes"
	/// English String: "Your Emotes"
	/// </summary>
	public override string LabelYourEmotes => "Seus emotes";

	/// <summary>
	/// Key: "Message.AccessoriesChange"
	/// English String: "Are you sure you want to override your current look?"
	/// </summary>
	public override string MessageAccessoriesChange => "Quer mesmo substituir seu visual atual?";

	/// <summary>
	/// Key: "Message.ChooseEmote"
	/// English String: "Choose an Emote"
	/// </summary>
	public override string MessageChooseEmote => "Escolha um emote";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlot"
	/// English String: "Choose a slot"
	/// </summary>
	public override string MessageChooseEmoteSlot => "Escolha um espaÃƒÂ§o";

	/// <summary>
	/// Key: "Message.ChooseEmoteSlotOrEmote"
	/// English String: "Choose a slot or an Emote"
	/// </summary>
	public override string MessageChooseEmoteSlotOrEmote => "Escolha um espaÃƒÂ§o ou um emote";

	/// <summary>
	/// Key: "Message.DefaultClothing"
	/// Encourage user to choose their own clothes.
	/// English String: "Default clothing has been applied to your avatar - wear something from your clothing."
	/// </summary>
	public override string MessageDefaultClothing => "Roupas padrÃƒÂ£o foram aplicadas ao avatar. Vista algumas das suas prÃƒÂ³prias roupas.";

	/// <summary>
	/// Key: "Message.DeleteThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Are you sure you want to delete this costume?"
	/// </summary>
	public override string MessageDeleteThisCostume => "Quer mesmo excluir esta fantasia?";

	/// <summary>
	/// Key: "Message.DeleteThisOutfit"
	/// English String: "Are you sure you want to delete this outfit?"
	/// </summary>
	public override string MessageDeleteThisOutfit => "Quer mesmo excluir este traje?";

	/// <summary>
	/// Key: "Message.EmotesInstructions"
	/// The instructions describe the navigation flow within the Avatar Editor to equip an emote.
	/// English String: "Go to \"Animations\" &gt; \"Emotes\" &gt; \"Equip Emotes\" to equip an emote."
	/// </summary>
	public override string MessageEmotesInstructions => "VÃƒÂ¡ para Ã¢â‚¬Å“AnimaÃƒÂ§ÃƒÂµes\" > \"Emotes\" > Ã¢â‚¬Å“Equipar emotes\" para equipar um emote.";

	/// <summary>
	/// Key: "Message.EmptyAssetList"
	/// User is seeing no assets on this page because they don't have any.
	/// English String: "You don't have any."
	/// </summary>
	public override string MessageEmptyAssetList => "VocÃƒÂª nÃƒÂ£o possui nenhum.";

	/// <summary>
	/// Key: "Message.EmptyListOfCostumes"
	/// The user is viewing an empty list of costumes to choose from. The application tells the user that they can create an costume.
	/// English String: "You don't have any costumes. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfCostumes => "VocÃƒÂª nÃƒÂ£o possui fantasias. Experimente criar algumas!";

	/// <summary>
	/// Key: "Message.EmptyListOfOutfits"
	/// The user is viewing an empty list of outfits to choose from. The application tells the user that they can create an outfit.
	/// English String: "You don't have any outfits. Try creating some!"
	/// </summary>
	public override string MessageEmptyListOfOutfits => "VocÃƒÂª nÃƒÂ£o possui trajes. Experimente criar alguns!";

	/// <summary>
	/// Key: "Message.EmptyRecentItems"
	/// English String: "You don't have any recent items."
	/// </summary>
	public override string MessageEmptyRecentItems => "VocÃƒÂª nÃƒÂ£o possui itens recentes suficientes.";

	/// <summary>
	/// Key: "Message.ErrorCreateCostume"
	/// English String: "Unable to create costume, try again later."
	/// </summary>
	public override string MessageErrorCreateCostume => "ImpossÃƒÂ­vel criar fantasia. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Message.ErrorCreateOutfit"
	/// English String: "Unable to create outfit, try again later."
	/// </summary>
	public override string MessageErrorCreateOutfit => "ImpossÃƒÂ­vel criar traje. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Message.ErrorDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageErrorDeleteEmote => "Falha ao excluir emote.";

	/// <summary>
	/// Key: "Message.ErrorEquipEmote"
	/// English String: "Failed to equip emote, please try again later."
	/// </summary>
	public override string MessageErrorEquipEmote => "Falha ao equipar emote. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Message.ErrorLoadCostume"
	/// English String: "Failed to load costume."
	/// </summary>
	public override string MessageErrorLoadCostume => "Falha ao carregar fantasia.";

	/// <summary>
	/// Key: "Message.ErrorLoadEmotes"
	/// English String: "Failed to load emotes."
	/// </summary>
	public override string MessageErrorLoadEmotes => "Falha ao carregar emotes.";

	/// <summary>
	/// Key: "Message.ErrorLoadOutfits"
	/// English String: "Failed to load outfits."
	/// </summary>
	public override string MessageErrorLoadOutfits => "Falha ao carregar trajes.";

	/// <summary>
	/// Key: "Message.ErrorOutfitName"
	/// English String: "Name can contain letters, numbers, and spaces."
	/// </summary>
	public override string MessageErrorOutfitName => "O nome pode conter letras, nÃƒÂºmeros e espaÃƒÂ§os.";

	/// <summary>
	/// Key: "Message.ErrorRenameCostume"
	/// English String: "Failed to rename costume."
	/// </summary>
	public override string MessageErrorRenameCostume => "Falha ao renomear fantasia.";

	/// <summary>
	/// Key: "Message.ErrorRenameOutfit"
	/// English String: "Failed to rename outfit."
	/// </summary>
	public override string MessageErrorRenameOutfit => "Falha ao renomear traje.";

	/// <summary>
	/// Key: "Message.ErrorUnequipEmote"
	/// English String: "Failed to unequip emote."
	/// </summary>
	public override string MessageErrorUnequipEmote => "Falha ao desequipar emote.";

	/// <summary>
	/// Key: "Message.ErrorUpdateCostume"
	/// English String: "Costume update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateCostume => "Falha ao atualizar fantasia. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Message.ErrorUpdateEmote"
	/// English String: "Updating emote slot failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateEmote => "Falha ao atualizar espaÃƒÂ§o. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Message.ErrorUpdateOutfit"
	/// English String: "Outfit update failed, please try again later."
	/// </summary>
	public override string MessageErrorUpdateOutfit => "Falha ao atualizar traje. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Message.ErrorUpdateWorn"
	/// There was an error updating items that the user is already wearing.
	/// English String: "Error while updating worn items."
	/// </summary>
	public override string MessageErrorUpdateWorn => "Erro ao atualizar itens vestidos.";

	/// <summary>
	/// Key: "Message.ErrorWearCostume"
	/// English String: "Failed to wear costume."
	/// </summary>
	public override string MessageErrorWearCostume => "Falha ao vestir fantasia.";

	/// <summary>
	/// Key: "Message.ErrorWearOutfit"
	/// English String: "Failed to wear outfit."
	/// </summary>
	public override string MessageErrorWearOutfit => "Falha ao vestir traje.";

	/// <summary>
	/// Key: "Message.FailedDeleteCostume"
	/// English String: "Failed to delete costume."
	/// </summary>
	public override string MessageFailedDeleteCostume => "Falha ao excluir fantasia.";

	/// <summary>
	/// Key: "Message.FailedDeleteEmote"
	/// English String: "Failed to delete emote."
	/// </summary>
	public override string MessageFailedDeleteEmote => "Falha ao excluir emote.";

	/// <summary>
	/// Key: "Message.FailedDeleteOutfit"
	/// English String: "Failed to delete outfit."
	/// </summary>
	public override string MessageFailedDeleteOutfit => "Falha ao excluir traje.";

	/// <summary>
	/// Key: "Message.FailedLoadAssets"
	/// English String: "Failed to load assets list."
	/// </summary>
	public override string MessageFailedLoadAssets => "Falha ao carregar lista de elementos.";

	/// <summary>
	/// Key: "Message.FailedLoadRecent"
	/// English String: "Failed to load recent items."
	/// </summary>
	public override string MessageFailedLoadRecent => "Falha ao carregar itens recentes.";

	/// <summary>
	/// Key: "Message.FailedUpdateBodyColor"
	/// English String: "Failed to update skin tone."
	/// </summary>
	public override string MessageFailedUpdateBodyColor => "Falha ao atualizar cor de pele.";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedCostume"
	/// The user tried to update a deleted costume.
	/// English String: "The costume you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedCostume => "A fantasia que vocÃƒÂª tentou atualizar nÃƒÂ£o existe mais.";

	/// <summary>
	/// Key: "Message.FailedUpdateDeletedOutfit"
	/// The user tried to update a deleted outfit.
	/// English String: "The outfit you tried to update no longer exists."
	/// </summary>
	public override string MessageFailedUpdateDeletedOutfit => "O traje que vocÃƒÂª tentou atualizar nÃƒÂ£o existe mais.";

	/// <summary>
	/// Key: "Message.FailedUpdateScales"
	/// English String: "Failed to update scales."
	/// </summary>
	public override string MessageFailedUpdateScales => "Falha ao atualizar dimensÃƒÂµes.";

	/// <summary>
	/// Key: "Message.FailedUpdateType"
	/// Failed to update the way the user's avatar is rendered.
	/// English String: "Failed to update avatar type."
	/// </summary>
	public override string MessageFailedUpdateType => "Falha ao atualizar tipo de avatar.";

	/// <summary>
	/// Key: "Message.FailedWearPackage"
	/// English String: "Failed to wear package."
	/// </summary>
	public override string MessageFailedWearPackage => "Falha ao vestir pacote.";

	/// <summary>
	/// Key: "Message.HatLimitTooltip"
	/// English String: "You can wear up to 3 hats"
	/// </summary>
	public override string MessageHatLimitTooltip => "VocÃƒÂª pode vestir atÃƒÂ© 3 chapÃƒÂ©us";

	/// <summary>
	/// Key: "Message.InvalidOutfitName"
	/// English String: "Name must be appropriate and less than 200 characters."
	/// </summary>
	public override string MessageInvalidOutfitName => "O nome deve ser apropriado e ter menos de 200 caracteres.";

	/// <summary>
	/// Key: "Message.Loading"
	/// The user's avatar is loading
	/// English String: "Loading..."
	/// </summary>
	public override string MessageLoading => "Carregando...";

	/// <summary>
	/// Key: "Message.PageUnavailable"
	/// English String: "The avatar page is temporarily unavailable."
	/// </summary>
	public override string MessagePageUnavailable => "A pÃƒÂ¡gina de Avatar estÃƒÂ¡ temporariamente indisponÃƒÂ­vel.";

	/// <summary>
	/// Key: "Message.PresetCostumesDelay"
	/// One-time message that appears to the user first time they visit the Preset Costumes tab. The delay is caused by initial migration.
	/// English String: "Note: We're doing some housekeeping, so it may take a few minutes for all your costumes to appear. Check again in a bit!"
	/// </summary>
	public override string MessagePresetCostumesDelay => "Aviso: Estamos colocando a casa em ordem, entÃƒÂ£o pode levar alguns minutos atÃƒÂ© que todas as suas fantasias apareÃƒÂ§am. Confira de novo daqui a pouco!";

	/// <summary>
	/// Key: "Message.ReachedMaxCostumes"
	/// English String: "You have reached the maximum number of costumes."
	/// </summary>
	public override string MessageReachedMaxCostumes => "VocÃƒÂª alcanÃƒÂ§ou o nÃƒÂºmero mÃƒÂ¡ximo de fantasias.";

	/// <summary>
	/// Key: "Message.ReachedMaxOutfits"
	/// English String: "You have reached the maximum number of outfits."
	/// </summary>
	public override string MessageReachedMaxOutfits => "VocÃƒÂª alcanÃƒÂ§ou o nÃƒÂºmero mÃƒÂ¡ximo de trajes.";

	/// <summary>
	/// Key: "Message.RedirectAvatarSettings"
	/// English String: "You can set Avatar Settings from your Roblox Studio project. In Roblox Studio, go to Home &gt; Game Settings &gt; Avatar"
	/// </summary>
	public override string MessageRedirectAvatarSettings => "VocÃƒÂª pode ajustar as ConfiguraÃƒÂ§ÃƒÂµes de Avatar do seu projeto do Roblox Studio. No Roblox Studio, vÃƒÂ¡ para InÃƒÂ­cio > ConfiguraÃƒÂ§ÃƒÂµes de Jogo > Avatar";

	/// <summary>
	/// Key: "Message.RedrawFloodchecked"
	/// English String: "You have redrawn your avatar too many times, please try again later."
	/// </summary>
	public override string MessageRedrawFloodchecked => "VocÃƒÂª redesenhou seu avatar muitas vezes. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Message.RedrawThumbnailFailed"
	/// English String: "Failed to redraw thumbnail."
	/// </summary>
	public override string MessageRedrawThumbnailFailed => "Falha ao redesenhar imagem miniatura.";

	/// <summary>
	/// Key: "Message.SelectEnableScaling"
	/// R15 is a proper noun
	/// English String: "Select R15 to enable scaling."
	/// </summary>
	public override string MessageSelectEnableScaling => "Selecione o R15 para habilitar o dimensionamento.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "Sucesso";

	/// <summary>
	/// Key: "Message.SuccessCreateCostume"
	/// English String: "Created costume"
	/// </summary>
	public override string MessageSuccessCreateCostume => "Fantasia criada";

	/// <summary>
	/// Key: "Message.SuccessCreateOutfit"
	/// English String: "Created outfit"
	/// </summary>
	public override string MessageSuccessCreateOutfit => "Traje criado";

	/// <summary>
	/// Key: "Message.SuccessDeleteCostume"
	/// Deleted costume
	/// English String: "Deleted costume"
	/// </summary>
	public override string MessageSuccessDeleteCostume => "Fantasia excluÃƒÂ­da";

	/// <summary>
	/// Key: "Message.SuccessDeleteOutfit"
	/// English String: "Deleted outfit"
	/// </summary>
	public override string MessageSuccessDeleteOutfit => "Traje excluÃƒÂ­do";

	/// <summary>
	/// Key: "Message.SuccessEquipEmote"
	/// English String: "Equipped Emote"
	/// </summary>
	public override string MessageSuccessEquipEmote => "Emote equipado";

	/// <summary>
	/// Key: "Message.SuccessRenameCostume"
	/// English String: "Renamed costume"
	/// </summary>
	public override string MessageSuccessRenameCostume => "Fantasia renomeada";

	/// <summary>
	/// Key: "Message.SuccessRenameOutfit"
	/// English String: "Renamed outfit"
	/// </summary>
	public override string MessageSuccessRenameOutfit => "Traje renomeado";

	/// <summary>
	/// Key: "Message.SuccessSavedAccessories"
	/// English String: "Saved accessories"
	/// </summary>
	public override string MessageSuccessSavedAccessories => "AcessÃƒÂ³rios salvos";

	/// <summary>
	/// Key: "Message.SuccessUnequipEmote"
	/// English String: "Unequipped emote"
	/// </summary>
	public override string MessageSuccessUnequipEmote => "Emote desequipado";

	/// <summary>
	/// Key: "Message.SuccessUpdatedCostume"
	/// English String: "Updated costume"
	/// </summary>
	public override string MessageSuccessUpdatedCostume => "Fantasia atualizada";

	/// <summary>
	/// Key: "Message.SuccessUpdatedOutfit"
	/// English String: "Updated outfit"
	/// </summary>
	public override string MessageSuccessUpdatedOutfit => "Traje atualizado";

	/// <summary>
	/// Key: "Message.SuccessWoreCostume"
	/// English String: "Successfully wore costume"
	/// </summary>
	public override string MessageSuccessWoreCostume => "Fantasia vestida com sucesso";

	/// <summary>
	/// Key: "Message.SuccessWoreOutfit"
	/// English String: "Successfully wore outfit"
	/// </summary>
	public override string MessageSuccessWoreOutfit => "Traje vestido com sucesso";

	/// <summary>
	/// Key: "Message.UpdateThisCostume"
	/// NOTE: Any instance of the word "outfit" will eventually be swapped out for "costume" This is not currently in the UI
	/// English String: "Do you want to update this costume? This will overwrite the costume with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisCostume => "Deseja atualizar esta fantasia? Isto substituirÃƒÂ¡ a fantasia pela aparÃƒÂªncia atual do seu avatar.";

	/// <summary>
	/// Key: "Message.UpdateThisOutfit"
	/// English String: "Do you want to update this outfit? This will overwrite the outfit with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateThisOutfit => "Deseja atualizar este traje? Isto substituirÃƒÂ¡ o traje pela aparÃƒÂªncia atual do seu avatar.";

	/// <summary>
	/// Key: "Message.Warning"
	/// English String: "Warning"
	/// </summary>
	public override string MessageWarning => "Aviso";

	public AvatarResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdvanced()
	{
		return "AvanÃƒÂ§ado";
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "Comprar";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fechar";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "Criar";
	}

	protected override string _GetTemplateForActionCreateNewOutfit()
	{
		return "Criar";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Excluir";
	}

	protected override string _GetTemplateForActionDone()
	{
		return "Pronto";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "Obter";
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "Obter mais";
	}

	protected override string _GetTemplateForActionOpenRobloxApp()
	{
		return "Abrir o app do Roblox";
	}

	protected override string _GetTemplateForActionRedraw()
	{
		return "Redesenhar";
	}

	protected override string _GetTemplateForActionRename()
	{
		return "Renomear";
	}

	protected override string _GetTemplateForActionRenameOutfit()
	{
		return "Renomear";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Salvar";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ver todos";
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
		return "AtualizaÃƒÂ§ÃƒÂ£o";
	}

	protected override string _GetTemplateForActionUserUnderstands()
	{
		return "Entendi";
	}

	protected override string _GetTemplateForDescriptionAvatarEditorUpsell()
	{
		return "Para mudar seu visual, vocÃƒÂª terÃƒÂ¡ que usar o Editor de Avatar do app.";
	}

	protected override string _GetTemplateForDescriptionCreateNewCostume()
	{
		return "Uma fantasia serÃƒÂ¡ criada a partir da aparÃƒÂªncia atual do seu avatar.";
	}

	protected override string _GetTemplateForDescriptionCreateNewOutfit()
	{
		return "Um traje serÃƒÂ¡ criado a partir da aparÃƒÂªncia atual do seu avatar.";
	}

	protected override string _GetTemplateForDescriptionRenameCostume()
	{
		return "Escolha um novo nome para a sua fantasia.";
	}

	protected override string _GetTemplateForDescriptionRenameOutfit()
	{
		return "Escolha um novo nome para o seu traje.";
	}

	protected override string _GetTemplateForHeadingAccessories()
	{
		return "AcessÃƒÂ³rios";
	}

	protected override string _GetTemplateForHeadingAccessoriesChange()
	{
		return "AlteraÃƒÂ§ÃƒÂ£o de acessÃƒÂ³rios";
	}

	protected override string _GetTemplateForHeadingAdvancedOptions()
	{
		return "OpÃƒÂ§ÃƒÂµes avanÃƒÂ§adas";
	}

	protected override string _GetTemplateForHeadingAll()
	{
		return "Todas";
	}

	protected override string _GetTemplateForHeadingAnimations()
	{
		return "AnimaÃƒÂ§ÃƒÂµes";
	}

	protected override string _GetTemplateForHeadingAppearance()
	{
		return "AparÃƒÂªncia";
	}

	protected override string _GetTemplateForHeadingAvatarPageTitle()
	{
		return "Editor de avatar";
	}

	protected override string _GetTemplateForHeadingBody()
	{
		return "Corpo";
	}

	protected override string _GetTemplateForHeadingBodyParts()
	{
		return "Parte do corpo";
	}

	protected override string _GetTemplateForHeadingClothing()
	{
		return "Roupas";
	}

	protected override string _GetTemplateForHeadingCostumes()
	{
		return "Fantasias";
	}

	protected override string _GetTemplateForHeadingCreateNewCostume()
	{
		return "Criar nova fantasia";
	}

	protected override string _GetTemplateForHeadingCreateNewOutfit()
	{
		return "Criar novo traje";
	}

	protected override string _GetTemplateForHeadingDelete()
	{
		return "Excluir";
	}

	protected override string _GetTemplateForHeadingDeleteCostume()
	{
		return "Excluir fantasia";
	}

	protected override string _GetTemplateForHeadingDeleteOutfit()
	{
		return "Excluir traje";
	}

	protected override string _GetTemplateForHeadingEmotes()
	{
		return "Emotes";
	}

	protected override string _GetTemplateForHeadingEquipEmotes()
	{
		return "Equipar emotes";
	}

	protected override string _GetTemplateForHeadingOutfits()
	{
		return "Trajes";
	}

	protected override string _GetTemplateForHeadingPackages()
	{
		return "Pacotes";
	}

	protected override string _GetTemplateForHeadingRecent()
	{
		return "Recentes";
	}

	protected override string _GetTemplateForHeadingRecommended()
	{
		return "Recomendados";
	}

	protected override string _GetTemplateForHeadingRenameCostume()
	{
		return "Renomear fantasia";
	}

	protected override string _GetTemplateForHeadingRenameOutfit()
	{
		return "Renomear traje";
	}

	protected override string _GetTemplateForHeadingScaling()
	{
		return "Dimensionamento";
	}

	protected override string _GetTemplateForHeadingSkinToneBodyParts()
	{
		return "Cor de pele por parte do corpo";
	}

	protected override string _GetTemplateForHeadingUpdate()
	{
		return "AtualizaÃƒÂ§ÃƒÂ£o";
	}

	protected override string _GetTemplateForHeadingUpdateCostume()
	{
		return "Atualizar fantasia";
	}

	protected override string _GetTemplateForHeadingUpdateOutfit()
	{
		return "Atualizar traje";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Todas";
	}

	protected override string _GetTemplateForLabelAskIfLoadingCorrectly()
	{
		return "O avatar nÃƒÂ£o estÃƒÂ¡ carregando corretamente?";
	}

	protected override string _GetTemplateForLabelAssetIDPlaceholder()
	{
		return "ID do elemento";
	}

	protected override string _GetTemplateForLabelBack()
	{
		return "Costas";
	}

	protected override string _GetTemplateForLabelBackAccessories()
	{
		return "AcessÃƒÂ³rios de trÃƒÂ¡s";
	}

	protected override string _GetTemplateForLabelBodyType()
	{
		return "Tipo de corpo";
	}

	protected override string _GetTemplateForLabelClimb()
	{
		return "Escalar";
	}

	protected override string _GetTemplateForLabelClimbAnimations()
	{
		return "AnimaÃƒÂ§ÃƒÂµes de escalada";
	}

	protected override string _GetTemplateForLabelClothes()
	{
		return "Roupas";
	}

	protected override string _GetTemplateForLabelCostume()
	{
		return "Fantasia";
	}

	/// <summary>
	/// Key: "Label.DirectionsForPackagePlacement"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Packages have been moved to Costumes. Check {startBold}Costumes{rightArrow}Preset Costumes{endBold}"
	/// </summary>
	public override string LabelDirectionsForPackagePlacement(string startBold, string rightArrow, string endBold)
	{
		return $"Pacotes colocados em Fantasias. Confira {startBold}Fantasias{rightArrow}Fantasias predefinidas{endBold}";
	}

	protected override string _GetTemplateForLabelDirectionsForPackagePlacement()
	{
		return "Pacotes colocados em Fantasias. Confira {startBold}Fantasias{rightArrow}Fantasias predefinidas{endBold}";
	}

	/// <summary>
	/// Key: "Label.DirectionsForScalingOptions"
	/// The arrow in this text has spacing built-in, so there's no space in the text here. These instructions tell the user where to click on the menu.
	/// English String: "Scaling options are available under Body category. Check {startBold}Body{rightArrow}Scale{endBold}"
	/// </summary>
	public override string LabelDirectionsForScalingOptions(string startBold, string rightArrow, string endBold)
	{
		return $"As opÃƒÂ§ÃƒÂµes de dimensionamento estÃƒÂ£o disponÃƒÂ­veis na categoria Corpo. Confira {startBold}Corpo{rightArrow}Dimensionar{endBold}";
	}

	protected override string _GetTemplateForLabelDirectionsForScalingOptions()
	{
		return "As opÃƒÂ§ÃƒÂµes de dimensionamento estÃƒÂ£o disponÃƒÂ­veis na categoria Corpo. Confira {startBold}Corpo{rightArrow}Dimensionar{endBold}";
	}

	protected override string _GetTemplateForlabelEmotes()
	{
		return "Emotes";
	}

	protected override string _GetTemplateForLabelEquip()
	{
		return "Equipar";
	}

	protected override string _GetTemplateForLabelExploreCatalog()
	{
		return "Explore o catÃƒÂ¡logo para encontrar mais roupas!";
	}

	protected override string _GetTemplateForLabelFace()
	{
		return "Rosto";
	}

	protected override string _GetTemplateForLabelFaceAccessories()
	{
		return "AcessÃƒÂ³rios de rosto";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "Rostos";
	}

	protected override string _GetTemplateForLabelFall()
	{
		return "Cair";
	}

	protected override string _GetTemplateForLabelFallAnimations()
	{
		return "AnimaÃƒÂ§ÃƒÂµes de queda";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "GrÃƒÂ¡tis";
	}

	protected override string _GetTemplateForLabelFront()
	{
		return "Frente";
	}

	protected override string _GetTemplateForLabelFrontAccessories()
	{
		return "AcessÃƒÂ³rios da frente";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "Equipamento";
	}

	protected override string _GetTemplateForLabelHair()
	{
		return "Cabelo";
	}

	protected override string _GetTemplateForLabelHairAccessories()
	{
		return "AcessÃƒÂ³rios de cabelo";
	}

	protected override string _GetTemplateForLabelHat()
	{
		return "ChapÃƒÂ©u";
	}

	protected override string _GetTemplateForLabelHatAccessories()
	{
		return "AcessÃƒÂ³rios de chapÃƒÂ©u";
	}

	protected override string _GetTemplateForLabelHead()
	{
		return "CabeÃƒÂ§a";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "CabeÃƒÂ§as";
	}

	protected override string _GetTemplateForLabelHeight()
	{
		return "Altura";
	}

	protected override string _GetTemplateForLabelIdle()
	{
		return "Inatividade";
	}

	protected override string _GetTemplateForLabelIdleAnimations()
	{
		return "AnimaÃƒÂ§ÃƒÂµes de inatividade";
	}

	protected override string _GetTemplateForLabelJump()
	{
		return "Pular";
	}

	protected override string _GetTemplateForLabelJumpAnimations()
	{
		return "AnimaÃƒÂ§ÃƒÂµes de salto";
	}

	protected override string _GetTemplateForLabelLeftArm()
	{
		return "BraÃƒÂ§o esquerdo";
	}

	protected override string _GetTemplateForLabelLeftArms()
	{
		return "BraÃƒÂ§os esquerdos";
	}

	protected override string _GetTemplateForLabelLeftLeg()
	{
		return "Perna esquerda";
	}

	protected override string _GetTemplateForLabelLeftLegs()
	{
		return "Pernas esquerdas";
	}

	protected override string _GetTemplateForLabelMyCostumes()
	{
		return "Minhas fantasias";
	}

	protected override string _GetTemplateForLabelNamePlaceholderCostume()
	{
		return "DÃƒÂª um nome a sua fantasia";
	}

	protected override string _GetTemplateForLabelNamePlaceholderOutfit()
	{
		return "DÃƒÂª um nome ao seu traje";
	}

	protected override string _GetTemplateForLabelNeck()
	{
		return "PescoÃƒÂ§o";
	}

	protected override string _GetTemplateForLabelNeckAccessories()
	{
		return "AcessÃƒÂ³rios de pescoÃƒÂ§o";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "Nenhum revendedor";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "IndisponÃƒÂ­vel";
	}

	protected override string _GetTemplateForLabelOutfit()
	{
		return "Traje";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "CalÃƒÂ§as";
	}

	protected override string _GetTemplateForLabelParts()
	{
		return "Partes";
	}

	protected override string _GetTemplateForLabelPresetCostumes()
	{
		return "Fantasias predefinidas";
	}

	protected override string _GetTemplateForLabelProportions()
	{
		return "ProporÃƒÂ§ÃƒÂµes";
	}

	protected override string _GetTemplateForLabelRedrawUnavailable()
	{
		return "FunÃƒÂ§ÃƒÂ£o de redesenhar avatar nÃƒÂ£o disponÃƒÂ­vel.";
	}

	protected override string _GetTemplateForLabelRightArm()
	{
		return "BraÃƒÂ§o direito";
	}

	protected override string _GetTemplateForLabelRightArms()
	{
		return "BraÃƒÂ§os direitos";
	}

	protected override string _GetTemplateForLabelRightLeg()
	{
		return "Perna direita";
	}

	protected override string _GetTemplateForLabelRightLegs()
	{
		return "Pernas direitas";
	}

	protected override string _GetTemplateForLabelRun()
	{
		return "Correr";
	}

	protected override string _GetTemplateForLabelRunAnimations()
	{
		return "AnimaÃƒÂ§ÃƒÂµes de corrida";
	}

	protected override string _GetTemplateForLabelScale()
	{
		return "Dimensionar";
	}

	protected override string _GetTemplateForLabelShirts()
	{
		return "Camisas";
	}

	protected override string _GetTemplateForLabelShoulderAccessories()
	{
		return "AcessÃƒÂ³rios de ombro";
	}

	protected override string _GetTemplateForLabelShoulders()
	{
		return "Ombros";
	}

	protected override string _GetTemplateForLabelSkinTone()
	{
		return "Cor de pele";
	}

	protected override string _GetTemplateForLabelSwim()
	{
		return "Nadar";
	}

	protected override string _GetTemplateForLabelSwimAnimations()
	{
		return "AnimaÃƒÂ§ÃƒÂµes de nado";
	}

	protected override string _GetTemplateForLabelSwitchAvatarType()
	{
		return "Troque entre o avatar clÃƒÂ¡ssico R6 e o avatar de nova geraÃƒÂ§ÃƒÂ£o mais expressivo R15";
	}

	protected override string _GetTemplateForLabelTorso()
	{
		return "Tronco";
	}

	protected override string _GetTemplateForLabelTorsos()
	{
		return "Troncos";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "Camisetas";
	}

	protected override string _GetTemplateForLabelWaist()
	{
		return "Cintura";
	}

	protected override string _GetTemplateForLabelWaistAccessories()
	{
		return "AcessÃƒÂ³rios de cintura";
	}

	protected override string _GetTemplateForLabelWalk()
	{
		return "Andar";
	}

	protected override string _GetTemplateForLabelWalkAnimations()
	{
		return "AnimaÃƒÂ§ÃƒÂµes de caminhada";
	}

	protected override string _GetTemplateForLabelWidth()
	{
		return "Largura";
	}

	protected override string _GetTemplateForLabelYourEmotes()
	{
		return "Seus emotes";
	}

	protected override string _GetTemplateForMessageAccessoriesChange()
	{
		return "Quer mesmo substituir seu visual atual?";
	}

	protected override string _GetTemplateForMessageChooseEmote()
	{
		return "Escolha um emote";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlot()
	{
		return "Escolha um espaÃƒÂ§o";
	}

	protected override string _GetTemplateForMessageChooseEmoteSlotOrEmote()
	{
		return "Escolha um espaÃƒÂ§o ou um emote";
	}

	protected override string _GetTemplateForMessageDefaultClothing()
	{
		return "Roupas padrÃƒÂ£o foram aplicadas ao avatar. Vista algumas das suas prÃƒÂ³prias roupas.";
	}

	/// <summary>
	/// Key: "Message.DeleteOutfit"
	/// English String: "Are you sure you want to delete this {outfitType}?"
	/// </summary>
	public override string MessageDeleteOutfit(string outfitType)
	{
		return $"Quer mesmo excluir este traje {outfitType}?";
	}

	protected override string _GetTemplateForMessageDeleteOutfit()
	{
		return "Quer mesmo excluir este traje {outfitType}?";
	}

	protected override string _GetTemplateForMessageDeleteThisCostume()
	{
		return "Quer mesmo excluir esta fantasia?";
	}

	protected override string _GetTemplateForMessageDeleteThisOutfit()
	{
		return "Quer mesmo excluir este traje?";
	}

	protected override string _GetTemplateForMessageEmotesInstructions()
	{
		return "VÃƒÂ¡ para Ã¢â‚¬Å“AnimaÃƒÂ§ÃƒÂµes\" > \"Emotes\" > Ã¢â‚¬Å“Equipar emotes\" para equipar um emote.";
	}

	protected override string _GetTemplateForMessageEmptyAssetList()
	{
		return "VocÃƒÂª nÃƒÂ£o possui nenhum.";
	}

	/// <summary>
	/// Key: "Message.EmptyListForItem"
	/// The user tries to load a list of some item but they see nothing because they don't own anything of that type.
	/// English String: "You don't have this item: {itemType}"
	/// </summary>
	public override string MessageEmptyListForItem(string itemType)
	{
		return $"VocÃƒÂª nÃƒÂ£o possui este item: {itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListForItem()
	{
		return "VocÃƒÂª nÃƒÂ£o possui este item: {itemType}";
	}

	protected override string _GetTemplateForMessageEmptyListOfCostumes()
	{
		return "VocÃƒÂª nÃƒÂ£o possui fantasias. Experimente criar algumas!";
	}

	protected override string _GetTemplateForMessageEmptyListOfOutfits()
	{
		return "VocÃƒÂª nÃƒÂ£o possui trajes. Experimente criar alguns!";
	}

	protected override string _GetTemplateForMessageEmptyRecentItems()
	{
		return "VocÃƒÂª nÃƒÂ£o possui itens recentes suficientes.";
	}

	protected override string _GetTemplateForMessageErrorCreateCostume()
	{
		return "ImpossÃƒÂ­vel criar fantasia. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageErrorCreateOutfit()
	{
		return "ImpossÃƒÂ­vel criar traje. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageErrorDeleteEmote()
	{
		return "Falha ao excluir emote.";
	}

	protected override string _GetTemplateForMessageErrorEquipEmote()
	{
		return "Falha ao equipar emote. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageErrorLoadCostume()
	{
		return "Falha ao carregar fantasia.";
	}

	protected override string _GetTemplateForMessageErrorLoadEmotes()
	{
		return "Falha ao carregar emotes.";
	}

	protected override string _GetTemplateForMessageErrorLoadOutfits()
	{
		return "Falha ao carregar trajes.";
	}

	protected override string _GetTemplateForMessageErrorOutfitName()
	{
		return "O nome pode conter letras, nÃƒÂºmeros e espaÃƒÂ§os.";
	}

	protected override string _GetTemplateForMessageErrorRenameCostume()
	{
		return "Falha ao renomear fantasia.";
	}

	protected override string _GetTemplateForMessageErrorRenameOutfit()
	{
		return "Falha ao renomear traje.";
	}

	protected override string _GetTemplateForMessageErrorUnequipEmote()
	{
		return "Falha ao desequipar emote.";
	}

	protected override string _GetTemplateForMessageErrorUpdateCostume()
	{
		return "Falha ao atualizar fantasia. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageErrorUpdateEmote()
	{
		return "Falha ao atualizar espaÃƒÂ§o. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageErrorUpdateOutfit()
	{
		return "Falha ao atualizar traje. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageErrorUpdateWorn()
	{
		return "Erro ao atualizar itens vestidos.";
	}

	protected override string _GetTemplateForMessageErrorWearCostume()
	{
		return "Falha ao vestir fantasia.";
	}

	protected override string _GetTemplateForMessageErrorWearOutfit()
	{
		return "Falha ao vestir traje.";
	}

	protected override string _GetTemplateForMessageFailedDeleteCostume()
	{
		return "Falha ao excluir fantasia.";
	}

	protected override string _GetTemplateForMessageFailedDeleteEmote()
	{
		return "Falha ao excluir emote.";
	}

	protected override string _GetTemplateForMessageFailedDeleteOutfit()
	{
		return "Falha ao excluir traje.";
	}

	protected override string _GetTemplateForMessageFailedLoadAssets()
	{
		return "Falha ao carregar lista de elementos.";
	}

	protected override string _GetTemplateForMessageFailedLoadRecent()
	{
		return "Falha ao carregar itens recentes.";
	}

	protected override string _GetTemplateForMessageFailedUpdateBodyColor()
	{
		return "Falha ao atualizar cor de pele.";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedCostume()
	{
		return "A fantasia que vocÃƒÂª tentou atualizar nÃƒÂ£o existe mais.";
	}

	protected override string _GetTemplateForMessageFailedUpdateDeletedOutfit()
	{
		return "O traje que vocÃƒÂª tentou atualizar nÃƒÂ£o existe mais.";
	}

	protected override string _GetTemplateForMessageFailedUpdateScales()
	{
		return "Falha ao atualizar dimensÃƒÂµes.";
	}

	protected override string _GetTemplateForMessageFailedUpdateType()
	{
		return "Falha ao atualizar tipo de avatar.";
	}

	protected override string _GetTemplateForMessageFailedWearPackage()
	{
		return "Falha ao vestir pacote.";
	}

	protected override string _GetTemplateForMessageHatLimitTooltip()
	{
		return "VocÃƒÂª pode vestir atÃƒÂ© 3 chapÃƒÂ©us";
	}

	protected override string _GetTemplateForMessageInvalidOutfitName()
	{
		return "O nome deve ser apropriado e ter menos de 200 caracteres.";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "Carregando...";
	}

	/// <summary>
	/// Key: "Message.MissingItemsFromOutfit"
	/// User cannot wear an outfit because they are missing or have deleted some of the items that were part of that outfit.
	/// English String: "Number of items that you don't own in this outfit: {number}"
	/// </summary>
	public override string MessageMissingItemsFromOutfit(string number)
	{
		return $"NÃƒÂºmero de itens que vocÃƒÂª nÃƒÂ£o possui deste traje: {number}";
	}

	protected override string _GetTemplateForMessageMissingItemsFromOutfit()
	{
		return "NÃƒÂºmero de itens que vocÃƒÂª nÃƒÂ£o possui deste traje: {number}";
	}

	protected override string _GetTemplateForMessagePageUnavailable()
	{
		return "A pÃƒÂ¡gina de Avatar estÃƒÂ¡ temporariamente indisponÃƒÂ­vel.";
	}

	protected override string _GetTemplateForMessagePresetCostumesDelay()
	{
		return "Aviso: Estamos colocando a casa em ordem, entÃƒÂ£o pode levar alguns minutos atÃƒÂ© que todas as suas fantasias apareÃƒÂ§am. Confira de novo daqui a pouco!";
	}

	protected override string _GetTemplateForMessageReachedMaxCostumes()
	{
		return "VocÃƒÂª alcanÃƒÂ§ou o nÃƒÂºmero mÃƒÂ¡ximo de fantasias.";
	}

	protected override string _GetTemplateForMessageReachedMaxOutfits()
	{
		return "VocÃƒÂª alcanÃƒÂ§ou o nÃƒÂºmero mÃƒÂ¡ximo de trajes.";
	}

	protected override string _GetTemplateForMessageRedirectAvatarSettings()
	{
		return "VocÃƒÂª pode ajustar as ConfiguraÃƒÂ§ÃƒÂµes de Avatar do seu projeto do Roblox Studio. No Roblox Studio, vÃƒÂ¡ para InÃƒÂ­cio > ConfiguraÃƒÂ§ÃƒÂµes de Jogo > Avatar";
	}

	protected override string _GetTemplateForMessageRedrawFloodchecked()
	{
		return "VocÃƒÂª redesenhou seu avatar muitas vezes. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessageRedrawThumbnailFailed()
	{
		return "Falha ao redesenhar imagem miniatura.";
	}

	protected override string _GetTemplateForMessageSelectEnableScaling()
	{
		return "Selecione o R15 para habilitar o dimensionamento.";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "Sucesso";
	}

	protected override string _GetTemplateForMessageSuccessCreateCostume()
	{
		return "Fantasia criada";
	}

	protected override string _GetTemplateForMessageSuccessCreateOutfit()
	{
		return "Traje criado";
	}

	protected override string _GetTemplateForMessageSuccessDeleteCostume()
	{
		return "Fantasia excluÃƒÂ­da";
	}

	protected override string _GetTemplateForMessageSuccessDeleteOutfit()
	{
		return "Traje excluÃƒÂ­do";
	}

	protected override string _GetTemplateForMessageSuccessEquipEmote()
	{
		return "Emote equipado";
	}

	protected override string _GetTemplateForMessageSuccessRenameCostume()
	{
		return "Fantasia renomeada";
	}

	protected override string _GetTemplateForMessageSuccessRenameOutfit()
	{
		return "Traje renomeado";
	}

	protected override string _GetTemplateForMessageSuccessSavedAccessories()
	{
		return "AcessÃƒÂ³rios salvos";
	}

	protected override string _GetTemplateForMessageSuccessUnequipEmote()
	{
		return "Emote desequipado";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedCostume()
	{
		return "Fantasia atualizada";
	}

	protected override string _GetTemplateForMessageSuccessUpdatedOutfit()
	{
		return "Traje atualizado";
	}

	protected override string _GetTemplateForMessageSuccessWoreCostume()
	{
		return "Fantasia vestida com sucesso";
	}

	protected override string _GetTemplateForMessageSuccessWoreOutfit()
	{
		return "Traje vestido com sucesso";
	}

	/// <summary>
	/// Key: "Message.UpdateOutfit"
	/// English String: "Do you want to update this {outfitType1}? This will overwrite the {outfitType2} with your avatar's current appearance."
	/// </summary>
	public override string MessageUpdateOutfit(string outfitType1, string outfitType2)
	{
		return $"Deseja atualizar este traje {outfitType1}? Isto substituirÃƒÂ¡ o traje {outfitType2} pela aparÃƒÂªncia atual do seu avatar.";
	}

	protected override string _GetTemplateForMessageUpdateOutfit()
	{
		return "Deseja atualizar este traje {outfitType1}? Isto substituirÃƒÂ¡ o traje {outfitType2} pela aparÃƒÂªncia atual do seu avatar.";
	}

	protected override string _GetTemplateForMessageUpdateThisCostume()
	{
		return "Deseja atualizar esta fantasia? Isto substituirÃƒÂ¡ a fantasia pela aparÃƒÂªncia atual do seu avatar.";
	}

	protected override string _GetTemplateForMessageUpdateThisOutfit()
	{
		return "Deseja atualizar este traje? Isto substituirÃƒÂ¡ o traje pela aparÃƒÂªncia atual do seu avatar.";
	}

	protected override string _GetTemplateForMessageWarning()
	{
		return "Aviso";
	}
}


}

