namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CashOutResources_pt_br : CashOutResources_en_us, ICashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "Retirada";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "Obter agora";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "Obter OBC agora";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "Upgrade de assinatura";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verificar";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "Verificar e-mail";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "Verificar agora";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "Visite DevEx";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "Central do desenvolvedor: Crie jogos, ganhe dinheiro.";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Central do desenvolvedor";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public override string HeadingYourUpdate => "Sua atualizaÃ§Ã£o";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "Quase pronto!";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "VocÃª precisa de Outrageous Builder's Club para trocar Robux por dinheiro.";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "VocÃª precisa do Outrageous Builder's Club para fazer uma retirada.";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "AvaliaÃ§Ã£o atual";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "Seu status Ã©: Completada";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "Seu status Ã©: Pendente";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "Seu status Ã©: Rejeitada";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "VocÃª precisa de um endereÃ§o de e-mail verificado para usar DevEx.";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "VocÃª nÃ£o Ã© elegÃ­vel no momento.";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "VocÃª nÃ£o tem Robux suficientes para fazer uma retirada.";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "VocÃª precisa de Roblox Premium para trocar Robux por dinheiro.";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "VocÃª estÃ¡ prestes a trocar Robux por dinheiro!";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "Quase lÃ¡! VocÃª estÃ¡ quase qualificado para trocar Robux por dinheiro!";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "VocÃª precisa validar o seu e-mail antes de poder fazer uma retirada.";

	public CashOutResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "Retirada";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "Obter agora";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "Obter OBC agora";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "Upgrade de assinatura";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verificar";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "Verificar e-mail";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "Verificar agora";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "Visite DevEx";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"Sua solicitaÃ§Ã£o DevEx foi completada. Confira sua pÃ¡gina de {startMoneyLink}Dinheiro{endMoneyLink} para mais detalhes.";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "Sua solicitaÃ§Ã£o DevEx foi completada. Confira sua pÃ¡gina de {startMoneyLink}Dinheiro{endMoneyLink} para mais detalhes.";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"Sua solicitaÃ§Ã£o de DevEX foi enviada em: {requestDate}";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "Sua solicitaÃ§Ã£o de DevEX foi enviada em: {requestDate}";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* Robux antigo pode ser retirado com uma taxa diferente. Clique {helpLinkStart}aqui{helpLinkEnd} para mais informaÃ§Ãµes.";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* Robux antigo pode ser retirado com uma taxa diferente. Clique {helpLinkStart}aqui{helpLinkEnd} para mais informaÃ§Ãµes.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Saiba mais{endDevExLink} sobre nossa Central do Desenvolvedor.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "{startDevExLink}Saiba mais{endDevExLink} sobre nossa Central do Desenvolvedor.";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Visite{endDevExLink} nossa Central do Desenvolvedor.";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "{startDevExLink}Visite{endDevExLink} nossa Central do Desenvolvedor.";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Central do desenvolvedor: Crie jogos, ganhe dinheiro.";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Central do desenvolvedor";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "Sua atualizaÃ§Ã£o";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "Quase pronto!";
	}

	/// <summary>
	/// Key: "Label.AmountRobux"
	/// label
	/// English String: "{amount} Robux"
	/// </summary>
	public override string LabelAmountRobux(string amount)
	{
		return $"{amount} Robux";
	}

	protected override string _GetTemplateForLabelAmountRobux()
	{
		return "{amount} Robux";
	}

	protected override string _GetTemplateForLabelBuilderClubForCash()
	{
		return "VocÃª precisa de Outrageous Builder's Club para trocar Robux por dinheiro.";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "VocÃª precisa do Outrageous Builder's Club para fazer uma retirada.";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "AvaliaÃ§Ã£o atual";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"A taxa atual se aplica a todos os valores acima de {minimumDevexRobuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "A taxa atual se aplica a todos os valores acima de {minimumDevexRobuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "Seu status Ã©: Completada";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "Seu status Ã©: Pendente";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "Seu status Ã©: Rejeitada";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "VocÃª precisa de um endereÃ§o de e-mail verificado para usar DevEx.";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "VocÃª nÃ£o Ã© elegÃ­vel no momento.";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "VocÃª nÃ£o tem Robux suficientes para fazer uma retirada.";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "VocÃª precisa de Roblox Premium para trocar Robux por dinheiro.";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	/// <summary>
	/// Key: "Label.RobuxToUSD"
	/// label
	/// English String: "{robuxAmount} Robux for {usdAmount}"
	/// </summary>
	public override string LabelRobuxToUSD(string robuxAmount, string usdAmount)
	{
		return $"{robuxAmount} Robux por {usdAmount}";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "{robuxAmount} Robux por {usdAmount}";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "VocÃª estÃ¡ prestes a trocar Robux por dinheiro!";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "Quase lÃ¡! VocÃª estÃ¡ quase qualificado para trocar Robux por dinheiro!";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "VocÃª precisa validar o seu e-mail antes de poder fazer uma retirada.";
	}
}


}
