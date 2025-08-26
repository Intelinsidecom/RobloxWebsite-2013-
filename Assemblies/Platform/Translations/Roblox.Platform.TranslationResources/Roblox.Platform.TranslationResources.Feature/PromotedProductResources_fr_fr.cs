namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PromotedProductResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedProductResources_fr_fr : PromotedProductResources_en_us, IPromotedProductResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear for this game"
	/// </summary>
	public override string HeadingGearForThisGame => "Ã‰quipement pour ce jeu";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "Ajouter Ã©quipement";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "Acheter";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Erreur";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "Une erreur est survenue. Veuillez rÃ©essayer.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "Cet objet n'est pas en vente.";

	/// <summary>
	/// Key: "Label.NotForSaleShort"
	/// A shorter way to say an item is not for sale
	/// English String: "Not for sale"
	/// </summary>
	public override string LabelNotForSaleShort => "Pas Ã  vendre";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "PossÃ©dÃ©";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "Louer";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "Louer";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "DÃ©solÃ©, l'objet n'a pas pu Ãªtre retirÃ© de ton jeu. RÃ©essaye.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "SuccÃ¨s\u00a0!";

	public PromotedProductResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "Ã‰quipement pour ce jeu";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "Ajouter Ã©quipement";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "Acheter";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Erreur";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "Une erreur est survenue. Veuillez rÃ©essayer.";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"Tu as ajoutÃ© l'objet {item} Ã  ton jeu.";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "Tu as ajoutÃ© l'objet {item} Ã  ton jeu.";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"Tu as retirÃ© l'objet {item} de ton jeu.";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "Tu as retirÃ© l'objet {item} de ton jeu.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "Cet objet n'est pas en vente.";
	}

	protected override string _GetTemplateForLabelNotForSaleShort()
	{
		return "Pas Ã  vendre";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "PossÃ©dÃ©";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "Louer";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "Louer";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "DÃ©solÃ©, l'objet n'a pas pu Ãªtre retirÃ© de ton jeu. RÃ©essaye.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "SuccÃ¨s\u00a0!";
	}
}


}
