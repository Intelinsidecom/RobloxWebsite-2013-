namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameGearResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearResources_de_de : GameGearResources_en_us, IGameGearResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear"
	/// </summary>
	public override string HeadingGearForThisGame => "Ausrüstung";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "Ausrüstung hinzufügen";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "Kaufen";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Fehler";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "Ein Fehler ist aufgetreten. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "Dieser Artikel steht nicht zum Verkauf.";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "Okay";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "In Besitz";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "Mieten";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "Mieten";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "Wir konnten den Artikel leider nicht aus deinem Spiel entfernen. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "Erfolg!";

	public GameGearResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "Ausrüstung";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "Ausrüstung hinzufügen";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "Kaufen";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Fehler";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "Ein Fehler ist aufgetreten. Bitte versuche es erneut.";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"Du hast „{item}“ zu deinem Spiel hinzugefügt.";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "Du hast „{item}“ zu deinem Spiel hinzugefügt.";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"Du hast „{item}“ aus deinem Spiel entfernt.";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "Du hast „{item}“ aus deinem Spiel entfernt.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "Dieser Artikel steht nicht zum Verkauf.";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "In Besitz";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "Mieten";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "Mieten";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "Wir konnten den Artikel leider nicht aus deinem Spiel entfernen. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "Erfolg!";
	}
}
