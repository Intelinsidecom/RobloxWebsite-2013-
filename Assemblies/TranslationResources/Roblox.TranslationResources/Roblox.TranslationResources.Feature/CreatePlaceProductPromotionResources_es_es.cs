namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_es_es : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "Añadir al juego";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Cancelar";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Error";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "Se ha producido un error. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "Este objeto no está en venta.";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "Aceptar";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "Publicitar en tu juego";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "Alquilar";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "Selecciona grupo";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "Ninguno";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "Selecciona tu juego";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "Selecciona tu juego:";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "No hemos podido eliminar el objeto de tu juego. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "¡Hecho!";

	public CreatePlaceProductPromotionResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "Añadir al juego";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Error";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "Se ha producido un error. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "Este objeto no está en venta.";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "Publicitar en tu juego";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "Alquilar";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "Selecciona grupo";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "Ninguno";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "Selecciona tu juego";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "Selecciona tu juego:";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "No hemos podido eliminar el objeto de tu juego. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "¡Hecho!";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public override string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"¿Qué es añadir equipamiento a un juego? Este objeto aparece en la página de tu juego y se permite automáticamente en él. Si alguien compra este objeto en la página de tu juego, ¡ganarás {affiliateSaleTotal} Robux!";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "¿Qué es añadir equipamiento a un juego? Este objeto aparece en la página de tu juego y se permite automáticamente en él. Si alguien compra este objeto en la página de tu juego, ¡ganarás {affiliateSaleTotal} Robux!";
	}
}
