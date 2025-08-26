namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_es_es : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
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
	public override string ActionRedeemCard => "Canjear tarjeta";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "Actualizar tarjeta de crÃ©dito";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "DÃ³nde comprarlas";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. Youâ€™ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robux es la moneda virtual que se utiliza en muchos de nuestros juegos en lÃ­nea. La puedes usar para mejorar el aspecto de tu avatar; conseguir equipamiento increÃ­ble para lucirlo en las batallas multijugador; comprar objetos de ediciÃ³n limitada para venderlos e intercambiarlos, etc. Necesitas Robux para hacer todo esto. Â¿A quÃ© estÃ¡s esperando?";

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
	public override string HeadingCancellations => "CancelaciÃ³n";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "Tarjetas de juego";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "Padres";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "Comprar Robux con";

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
	public override string LabelRobloxGameCards => "Tarjetas de juego de Roblox";

	public BuildersClubPanelResources_es_es(TranslationResourceState state)
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
		return "Canjear tarjeta";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "Actualizar tarjeta de crÃ©dito";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "DÃ³nde comprarlas";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"Para preguntas de facturaciÃ³n y pagos: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "Para preguntas de facturaciÃ³n y pagos: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robux es la moneda virtual que se utiliza en muchos de nuestros juegos en lÃ­nea. La puedes usar para mejorar el aspecto de tu avatar; conseguir equipamiento increÃ­ble para lucirlo en las batallas multijugador; comprar objetos de ediciÃ³n limitada para venderlos e intercambiarlos, etc. Necesitas Robux para hacer todo esto. Â¿A quÃ© estÃ¡s esperando?";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"Puedes desactivar la renovaciÃ³n automÃ¡tica de tu suscripciÃ³n en cualquier momento antes de que se renueve y seguirÃ¡s recibiendo los beneficios del Builders Club durante el resto del periodo pagado. Para desactivarla, haz clic en el botÃ³n Cancelar renovaciÃ³n en la pestaÃ±a {linkStartTag}FacturaciÃ³n{linkEndTag} de la pÃ¡gina ConfiguraciÃ³n y confirma la cancelaciÃ³n.";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "Puedes desactivar la renovaciÃ³n automÃ¡tica de tu suscripciÃ³n en cualquier momento antes de que se renueve y seguirÃ¡s recibiendo los beneficios del Builders Club durante el resto del periodo pagado. Para desactivarla, haz clic en el botÃ³n Cancelar renovaciÃ³n en la pestaÃ±a {linkStartTag}FacturaciÃ³n{linkEndTag} de la pÃ¡gina ConfiguraciÃ³n y confirma la cancelaciÃ³n.";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"Puedes desactivar la renovaciÃ³n automÃ¡tica de tu suscripciÃ³n en cualquier momento antes de que se renueve y seguirÃ¡s recibiendo los beneficios de Premium durante el resto del periodo pagado. Para desactivarla, haz clic en el botÃ³n Cancelar renovaciÃ³n de la suscripciÃ³n en la pestaÃ±a {linkStartTag}FacturaciÃ³n{linkEndTag} de la pÃ¡gina ConfiguraciÃ³n y confirma la cancelaciÃ³n.";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "Puedes desactivar la renovaciÃ³n automÃ¡tica de tu suscripciÃ³n en cualquier momento antes de que se renueve y seguirÃ¡s recibiendo los beneficios de Premium durante el resto del periodo pagado. Para desactivarla, haz clic en el botÃ³n Cancelar renovaciÃ³n de la suscripciÃ³n en la pestaÃ±a {linkStartTag}FacturaciÃ³n{linkEndTag} de la pÃ¡gina ConfiguraciÃ³n y confirma la cancelaciÃ³n.";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"Obtenga mÃ¡s informaciÃ³n sobre el Builders Club y sobre cÃ³mo {startLinkTag}protegemos a los niÃ±os{endLinkTag}.";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "Obtenga mÃ¡s informaciÃ³n sobre el Builders Club y sobre cÃ³mo {startLinkTag}protegemos a los niÃ±os{endLinkTag}.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"Aprende mÃ¡s sobre Premium y cÃ³mo {startLinkTag}protegemos a los niÃ±os{endLinkTag}.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "Aprende mÃ¡s sobre Premium y cÃ³mo {startLinkTag}protegemos a los niÃ±os{endLinkTag}.";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Comprar Robux";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "CancelaciÃ³n";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "Tarjetas de juego";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "Padres";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "Comprar Robux con";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"Saldo: {amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "Saldo: {amount}";
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
		return "Tarjetas de juego de Roblox";
	}
}


}
