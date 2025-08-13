namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_de_de : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "Zu Spiel hinzufügen";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Abbrechen";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Fehler";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "Ein Fehler ist aufgetreten. Bitte versuche es erneut.";

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
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "Werbung für dein Spiel machen";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "Mieten";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "Gruppe wählen";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "Keine Auswahl";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "Wähle dein Spiel";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "Wähle dein Spiel:";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "Wir konnten den Artikel leider nicht aus deinem Spiel entfernen. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "Erfolg!";

	public CreatePlaceProductPromotionResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "Zu Spiel hinzufügen";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Fehler";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "Ein Fehler ist aufgetreten. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "Dieser Artikel steht nicht zum Verkauf.";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "Werbung für dein Spiel machen";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "Mieten";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "Gruppe wählen";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "Keine Auswahl";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "Wähle dein Spiel";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "Wähle dein Spiel:";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "Wir konnten den Artikel leider nicht aus deinem Spiel entfernen. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "Erfolg!";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public override string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"Was bedeutet es, Ausrüstung zu einem Spiel hinzuzufügen? Dieser Artikel wird auf deiner Spielseite angezeigt und automatisch in deinem Spiel zugelassen. Wenn jemand diesen Artikel von deiner Spielseite kauft, erhältst du {affiliateSaleTotal} Robux!";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "Was bedeutet es, Ausrüstung zu einem Spiel hinzuzufügen? Dieser Artikel wird auf deiner Spielseite angezeigt und automatisch in deinem Spiel zugelassen. Wenn jemand diesen Artikel von deiner Spielseite kauft, erhältst du {affiliateSaleTotal} Robux!";
	}
}
