namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameGearResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearResources_es_es : GameGearResources_en_us, IGameGearResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear"
	/// </summary>
	public override string HeadingGearForThisGame => "Equipamiento";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "Añadir equipamiento";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "Comprar";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Error";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "Se ha producido un error. Inténtalo de nuevo.";

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
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "Tienes";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "Alquilar";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "Alquilar";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "No hemos podido eliminar el objeto de tu juego. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "¡Hecho!";

	public GameGearResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "Equipamiento";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "Añadir equipamiento";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "Comprar";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Error";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "Se ha producido un error. Inténtalo de nuevo.";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"Has añadido {item} a tu juego.";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "Has añadido {item} a tu juego.";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"Has eliminado {item} de tu juego.";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "Has eliminado {item} de tu juego.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "Este objeto no está en venta.";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "Tienes";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "Alquilar";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "Alquilar";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "No hemos podido eliminar el objeto de tu juego. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "¡Hecho!";
	}
}
