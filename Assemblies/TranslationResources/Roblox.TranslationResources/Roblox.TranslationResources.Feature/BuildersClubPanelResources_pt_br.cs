namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_pt_br : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Comprar Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public override string ActionRedeemCard => "Usar cartão";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "Atualizar cartão de crédito";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "Onde comprar";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robux é uma moeda virtual usada em muitos dos nossos jogos online. Por exemplo, você pode usar Robux para encontrar um ótimo visual para seu avatar, comprar equipamentos bacanas para usar em batalhas multijogador e adquirir itens limitados para vender e trocar. Você vai precisar de Robux para fazer tudo isso. O que está esperando?";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Comprar Robux";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public override string HeadingCancellations => "Cancelamento";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "Cartões do jogo";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "Responsáveis";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "Comprar Robux com";

	/// <summary>
	/// Key: "Label.Itunes"
	/// image alt tag text
	/// English String: "iTunes"
	/// </summary>
	public override string LabelItunes => "iTunes";

	/// <summary>
	/// Key: "Label.Rixty"
	/// image alt tag text
	/// English String: "Rixty"
	/// </summary>
	public override string LabelRixty => "Rixty";

	/// <summary>
	/// Key: "Label.RobloxGameCards"
	/// label
	/// English String: "Roblox Gamecards"
	/// </summary>
	public override string LabelRobloxGameCards => "Cartões do jogo do Roblox";

	public BuildersClubPanelResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Comprar Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "Usar cartão";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "Atualizar cartão de crédito";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "Onde comprar";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"Para dúvidas sobre cobrança e pagamento: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "Para dúvidas sobre cobrança e pagamento: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robux é uma moeda virtual usada em muitos dos nossos jogos online. Por exemplo, você pode usar Robux para encontrar um ótimo visual para seu avatar, comprar equipamentos bacanas para usar em batalhas multijogador e adquirir itens limitados para vender e trocar. Você vai precisar de Robux para fazer tudo isso. O que está esperando?";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"Você poderá cancelar a renovação automática da assinatura a qualquer momento antes da data de renovação e continuará a receber os privilégios do Builders Club até o fim do período do pagamento atual. Para desligar a renovação automática, clique no botão ‘Cancelar renovação de assinatura' na aba {linkStartTag}Cobrança{linkEndTag} da página de Configurações e confirme o cancelamento.";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "Você poderá cancelar a renovação automática da assinatura a qualquer momento antes da data de renovação e continuará a receber os privilégios do Builders Club até o fim do período do pagamento atual. Para desligar a renovação automática, clique no botão ‘Cancelar renovação de assinatura' na aba {linkStartTag}Cobrança{linkEndTag} da página de Configurações e confirme o cancelamento.";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"Você poderá cancelar a renovação automática da assinatura a qualquer momento antes da data de renovação e continuará a receber os privilégios do Premium até o fim do período do pagamento atual. Para desligar a renovação automática, clique no botão ‘Cancelar renovação de assinatura' na aba {linkStartTag}Cobrança{linkEndTag} da página de Configurações e confirme o cancelamento.";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "Você poderá cancelar a renovação automática da assinatura a qualquer momento antes da data de renovação e continuará a receber os privilégios do Premium até o fim do período do pagamento atual. Para desligar a renovação automática, clique no botão ‘Cancelar renovação de assinatura' na aba {linkStartTag}Cobrança{linkEndTag} da página de Configurações e confirme o cancelamento.";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"Saiba mais sobre o Builders Club e sobre como {startLinkTag}protegemos as crianças{endLinkTag}.";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "Saiba mais sobre o Builders Club e sobre como {startLinkTag}protegemos as crianças{endLinkTag}.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"Saiba mais sobre o Premium e sobre como {startLinkTag}protegemos as crianças{endLinkTag}.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "Saiba mais sobre o Premium e sobre como {startLinkTag}protegemos as crianças{endLinkTag}.";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Comprar Robux";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "Cancelamento";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "Cartões do jogo";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "Responsáveis";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "Comprar Robux com";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"Saldo de créditos: {amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "Saldo de créditos: {amount}";
	}

	protected override string _GetTemplateForLabelItunes()
	{
		return "iTunes";
	}

	protected override string _GetTemplateForLabelRixty()
	{
		return "Rixty";
	}

	protected override string _GetTemplateForLabelRobloxGameCards()
	{
		return "Cartões do jogo do Roblox";
	}
}
