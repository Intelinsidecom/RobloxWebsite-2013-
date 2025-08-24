namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CashOutResources_es_es : CashOutResources_en_us, ICashOutResources, ITranslationResources
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
	public override string ActionCashOut => "Convertir en efectivo";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "Obtener ahora";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "Consigue ya la suscripción al OBC";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "Mejorar suscripción";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verificar";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "Verificar correo electrónico";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "Verificar ahora";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "Visitar DevEx";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "Cambio para desarrolladores: crea juegos, gana dinero.";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Cambio para desarrolladores";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public override string HeadingYourUpdate => "Tu actualización";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "¡Ya casi lo tienes!";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "Necesitas ser miembro del Outrageous Builders Club para cambiar Robux por efectivo.";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "Necesitas ser miembro del Outrageous Builders Club para convertir en efectivo.";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "Tasa de cambio actual";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "La solicitud ha sido completada.";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "La solicitud está pendiente.";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "La solicitud ha sido rechazada.";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "Necesitas una dirección de correo electrónico verificada para usar DevEx.";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "En estos momentos no eres admisible.";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "No tienes suficientes Robux para convertir en efectivo.";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "Necesitas Roblox Premium para cambiar Robux por efectivo.";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "¡Estás a punto de poder cambiar Robux por efectivo!";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "¡Ya casi lo tienes! Estás a punto de poder cambiar tus Robux por efectivo.";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "Debes verificar tu correo electrónico antes de convertir en efectivo.";

	public CashOutResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "Convertir en efectivo";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "Obtener ahora";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "Consigue ya la suscripción al OBC";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "Mejorar suscripción";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verificar";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "Verificar correo electrónico";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "Verificar ahora";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "Visitar DevEx";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"Tu solicitud al DevEx ha sido completada. Comprueba tu página {startMoneyLink}Dinero{endMoneyLink} para más detalles.";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "Tu solicitud al DevEx ha sido completada. Comprueba tu página {startMoneyLink}Dinero{endMoneyLink} para más detalles.";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"Se presentó tu solicitud al DevEx el: {requestDate}";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "Se presentó tu solicitud al DevEx el: {requestDate}";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* Es posible que los viejos Robux se conviertan en efectivo a un tipo de cambio diferente. Haz clic {helpLinkStart}aquí{helpLinkEnd} para obtener más información.";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* Es posible que los viejos Robux se conviertan en efectivo a un tipo de cambio diferente. Haz clic {helpLinkStart}aquí{helpLinkEnd} para obtener más información.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Obtén más información{endDevExLink} sobre nuestro programa de cambio para desarrolladores.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "{startDevExLink}Obtén más información{endDevExLink} sobre nuestro programa de cambio para desarrolladores.";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Visita{endDevExLink} nuestro programa de cambio para desarrolladores.";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "{startDevExLink}Visita{endDevExLink} nuestro programa de cambio para desarrolladores.";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Cambio para desarrolladores: crea juegos, gana dinero.";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Cambio para desarrolladores";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "Tu actualización";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "¡Ya casi lo tienes!";
	}

	/// <summary>
	/// Key: "Label.AmountRobux"
	/// label
	/// English String: "{amount} Robux"
	/// </summary>
	public override string LabelAmountRobux(string amount)
	{
		return $"{amount}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelAmountRobux()
	{
		return "{amount}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelBuilderClubForCash()
	{
		return "Necesitas ser miembro del Outrageous Builders Club para cambiar Robux por efectivo.";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "Necesitas ser miembro del Outrageous Builders Club para convertir en efectivo.";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "Tasa de cambio actual";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"Las tasas de cambio actuales se aplican a todos los montos por arriba de los {minimumDevexRobuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "Las tasas de cambio actuales se aplican a todos los montos por arriba de los {minimumDevexRobuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "La solicitud ha sido completada.";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "La solicitud está pendiente.";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "La solicitud ha sido rechazada.";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "Necesitas una dirección de correo electrónico verificada para usar DevEx.";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "En estos momentos no eres admisible.";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "No tienes suficientes Robux para convertir en efectivo.";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "Necesitas Roblox Premium para cambiar Robux por efectivo.";
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
		return "¡Estás a punto de poder cambiar Robux por efectivo!";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "¡Ya casi lo tienes! Estás a punto de poder cambiar tus Robux por efectivo.";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "Debes verificar tu correo electrónico antes de convertir en efectivo.";
	}
}
