namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_fr_fr : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "Ajouter au jeu";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Annuler";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Erreur";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "Une erreur est survenue. Veuillez rÃ©essayer.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "Cet objet n'est pas en vente.";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "Promouvoir dans ton jeu";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "Louer";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "SÃ©lectionner le groupe";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "Aucun";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "SÃ©lectionne ton jeu";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "SÃ©lectionne ton jeu\u00a0:";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "DÃ©solÃ©, l'objet n'a pas pu Ãªtre retirÃ© de ton jeu. RÃ©essaye.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "SuccÃ¨s\u00a0!";

	public CreatePlaceProductPromotionResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "Ajouter au jeu";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Erreur";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "Une erreur est survenue. Veuillez rÃ©essayer.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "Cet objet n'est pas en vente.";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "Promouvoir dans ton jeu";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "Louer";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "SÃ©lectionner le groupe";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "Aucun";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "SÃ©lectionne ton jeu";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "SÃ©lectionne ton jeu\u00a0:";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "DÃ©solÃ©, l'objet n'a pas pu Ãªtre retirÃ© de ton jeu. RÃ©essaye.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "SuccÃ¨s\u00a0!";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public override string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"En quoi consiste l'ajout d'Ã©quipement dans un jeu\u00a0? L'objet est affichÃ© sur la page de ton jeu et automatiquement autorisÃ© dans le jeu. Si un utilisateur achÃ¨te cet objet depuis ta page, tu gagnes {affiliateSaleTotal}\u00a0Robux\u00a0!";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "En quoi consiste l'ajout d'Ã©quipement dans un jeu\u00a0? L'objet est affichÃ© sur la page de ton jeu et automatiquement autorisÃ© dans le jeu. Si un utilisateur achÃ¨te cet objet depuis ta page, tu gagnes {affiliateSaleTotal}\u00a0Robux\u00a0!";
	}
}


}
