namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_fr_fr : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Acheter des Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public override string ActionRedeemCard => "Activer une carte";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "Mettre à jour la carte de crédit";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "Où en acheter";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Le Robux est la monnaie virtuelle utilisée dans bon nombre de nos jeux en ligne. Vous pouvez également les dépenser pour donner un look d'enfer à votre avatar, mais aussi obtenir un super équipement à emmener dans les batailles en multijoueur, acheter des objets en édition limitée pour les revendre ou les échanger, etc. Il vous faudra des Robux pour tout ça. Qu'attendez-vous\u00a0?";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Acheter des Robux";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public override string HeadingCancellations => "Annulation";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "Cartes de jeu";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "Parents";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "Acheter des Robux avec";

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
	public override string LabelRobloxGameCards => "Cartes de jeu Roblox";

	public BuildersClubPanelResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Acheter des Robux";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "Activer une carte";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "Mettre à jour la carte de crédit";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "Où en acheter";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"Pour toute question sur les paiements et la facturation\u00a0: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "Pour toute question sur les paiements et la facturation\u00a0: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Le Robux est la monnaie virtuelle utilisée dans bon nombre de nos jeux en ligne. Vous pouvez également les dépenser pour donner un look d'enfer à votre avatar, mais aussi obtenir un super équipement à emmener dans les batailles en multijoueur, acheter des objets en édition limitée pour les revendre ou les échanger, etc. Il vous faudra des Robux pour tout ça. Qu'attendez-vous\u00a0?";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"Vous pouvez désactiver le renouvellement automatique de l'abonnement à tout moment avant la date de renouvellement\u00a0; vous conserverez l'accès aux avantages du Builders Club pour le reste de la période entamée. Pour ce faire, cliquez sur le bouton Annuler le renouvellement de l'abonnement situé dans l'onglet {linkStartTag}Facturation{linkEndTag} de la page des paramètres, puis confirmez l'annulation.";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "Vous pouvez désactiver le renouvellement automatique de l'abonnement à tout moment avant la date de renouvellement\u00a0; vous conserverez l'accès aux avantages du Builders Club pour le reste de la période entamée. Pour ce faire, cliquez sur le bouton Annuler le renouvellement de l'abonnement situé dans l'onglet {linkStartTag}Facturation{linkEndTag} de la page des paramètres, puis confirmez l'annulation.";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"Vous pouvez désactiver le renouvellement automatique de l'abonnement à tout moment avant la date de renouvellement\u00a0; vous conserverez l'accès aux avantages du Builders Club pour le reste de la période entamée. Pour ce faire, cliquez sur le bouton Annuler le renouvellement de l'abonnement situé dans l'onglet {linkStartTag}Facturation{linkEndTag} de la page des paramètres, puis confirmez l'annulation.";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "Vous pouvez désactiver le renouvellement automatique de l'abonnement à tout moment avant la date de renouvellement\u00a0; vous conserverez l'accès aux avantages du Builders Club pour le reste de la période entamée. Pour ce faire, cliquez sur le bouton Annuler le renouvellement de l'abonnement situé dans l'onglet {linkStartTag}Facturation{linkEndTag} de la page des paramètres, puis confirmez l'annulation.";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"Apprenez-en davantage au sujet du Builders Club et sur la façon dont nous {startLinkTag}garantissons la sécurité des enfants{endLinkTag}.";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "Apprenez-en davantage au sujet du Builders Club et sur la façon dont nous {startLinkTag}garantissons la sécurité des enfants{endLinkTag}.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"Apprenez-en davantage au sujet de Premium et sur la façon dont nous {startLinkTag}garantissons la sécurité des enfants{endLinkTag}.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "Apprenez-en davantage au sujet de Premium et sur la façon dont nous {startLinkTag}garantissons la sécurité des enfants{endLinkTag}.";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Acheter des Robux";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "Annulation";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "Cartes de jeu";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "Parents";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "Acheter des Robux avec";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"Solde\u00a0: {amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "Solde\u00a0: {amount}";
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
		return "Cartes de jeu Roblox";
	}
}
