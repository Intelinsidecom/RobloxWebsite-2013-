namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PromotedProductResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedProductResources_pt_br : PromotedProductResources_en_us, IPromotedProductResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear for this game"
	/// </summary>
	public override string HeadingGearForThisGame => "Equipamento para este jogo";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "Adicionar equipamento";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "Comprar";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Erro";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "Ocorreu um erro. Tente novamente.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "Este item não está disponível para compra.";

	/// <summary>
	/// Key: "Label.NotForSaleShort"
	/// A shorter way to say an item is not for sale
	/// English String: "Not for sale"
	/// </summary>
	public override string LabelNotForSaleShort => "Não está à venda";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "Você possui este item";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "Aluguel";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "Aluguel";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "Infelizmente, não conseguimos remover o item do seu jogo. Tente novamente.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "Sucesso!";

	public PromotedProductResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "Equipamento para este jogo";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "Adicionar equipamento";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "Comprar";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Erro";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "Ocorreu um erro. Tente novamente.";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"Você adicionou {item} ao seu jogo.";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "Você adicionou {item} ao seu jogo.";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"Você removeu {item} do seu jogo.";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "Você removeu {item} do seu jogo.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "Este item não está disponível para compra.";
	}

	protected override string _GetTemplateForLabelNotForSaleShort()
	{
		return "Não está à venda";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "Você possui este item";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "Aluguel";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "Aluguel";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "Infelizmente, não conseguimos remover o item do seu jogo. Tente novamente.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "Sucesso!";
	}
}
