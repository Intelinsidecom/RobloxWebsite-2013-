namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_pt_br : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "Adicionar ao jogo";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Cancelar";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Erro";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "Ocorreu um erro. Tente novamente.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "Este item não está disponível para compra.";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "Promova no seu jogo";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "Aluguel";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "Selecionar grupo";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "Nenhuma";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "Selecione o seu jogo";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "Selecione o seu jogo:";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "Infelizmente, não conseguimos remover o item do seu jogo. Tente novamente.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "Sucesso!";

	public CreatePlaceProductPromotionResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "Adicionar ao jogo";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Erro";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "Ocorreu um erro. Tente novamente.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "Este item não está disponível para compra.";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "Promova no seu jogo";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "Aluguel";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "Selecionar grupo";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "Nenhuma";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "Selecione o seu jogo";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "Selecione o seu jogo:";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "Infelizmente, não conseguimos remover o item do seu jogo. Tente novamente.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "Sucesso!";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public override string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"O que é a funcionalidade de adicionar equipamento a um jogo? Este item é exibido na página do jogo e permitido automaticamente no seu jogo. Se alguém comprar este item da sua página do jogo, você ganhará {affiliateSaleTotal} Robux!";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "O que é a funcionalidade de adicionar equipamento a um jogo? Este item é exibido na página do jogo e permitido automaticamente no seu jogo. Se alguém comprar este item da sua página do jogo, você ganhará {affiliateSaleTotal} Robux!";
	}
}
