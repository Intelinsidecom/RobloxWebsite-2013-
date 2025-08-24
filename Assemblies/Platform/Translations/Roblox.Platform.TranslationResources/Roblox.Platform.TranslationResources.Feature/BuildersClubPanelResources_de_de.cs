namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_de_de : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux kaufen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public override string ActionRedeemCard => "Karte einlösen";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "Kreditkarte aktualisieren";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "Hier erhältlich";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robux ist die virtuelle Währung, die in vielen unserer Onlinespiele verwendet wird. Du kannst auch Robux ausgeben, um deinem Avatar einen tollen neuen Look zu verpassen. Oder hol dir coole Ausrüstung für Mehrspielerkämpfe. Oder kaufe limitierte Artikel, um sie weiterzuverkaufen oder mit ihnen zu handeln. Für all das brauchst du Robux. Worauf wartest du noch?";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robux kaufen";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public override string HeadingCancellations => "Kündigung";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "Spielkarten";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "Eltern";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "Kaufe Robux mit";

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
	public override string LabelRobloxGameCards => "Roblox-Spielkarten";

	public BuildersClubPanelResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux kaufen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "Karte einlösen";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "Kreditkarte aktualisieren";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "Hier erhältlich";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"Für Fragen zu Zahlungen: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "Für Fragen zu Zahlungen: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robux ist die virtuelle Währung, die in vielen unserer Onlinespiele verwendet wird. Du kannst auch Robux ausgeben, um deinem Avatar einen tollen neuen Look zu verpassen. Oder hol dir coole Ausrüstung für Mehrspielerkämpfe. Oder kaufe limitierte Artikel, um sie weiterzuverkaufen oder mit ihnen zu handeln. Für all das brauchst du Robux. Worauf wartest du noch?";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"Du kannst die automatische Verlängerung der Mitgliedschaft jederzeit vor dem Verlängerungsdatum deaktivieren und die Vorteile des Builders Club bis zum Ende der bereits bezahlten Abonnementlaufzeit nutzen. Um die automatische Verlängerung der Mitgliedschaft zu deaktivieren, klicke bitte im Reiter {linkStartTag}Zahlungen{linkEndTag} auf der Einstellungsseite die Schaltfläche zur Kündigung der Mitgliedschaftsverlängerung an und bestätige die Kündigung dann.";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "Du kannst die automatische Verlängerung der Mitgliedschaft jederzeit vor dem Verlängerungsdatum deaktivieren und die Vorteile des Builders Club bis zum Ende der bereits bezahlten Abonnementlaufzeit nutzen. Um die automatische Verlängerung der Mitgliedschaft zu deaktivieren, klicke bitte im Reiter {linkStartTag}Zahlungen{linkEndTag} auf der Einstellungsseite die Schaltfläche zur Kündigung der Mitgliedschaftsverlängerung an und bestätige die Kündigung dann.";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"Du kannst die automatische Verlängerung der Mitgliedschaft jederzeit vor dem Verlängerungsdatum deaktivieren und die Vorteile einer Premium-Mitgliedschaft bis zum Ende der bereits bezahlten Abonnementlaufzeit nutzen. Um die automatische Verlängerung der Mitgliedschaft zu deaktivieren, klicke bitte im Reiter {linkStartTag}Zahlungen{linkEndTag} auf der Einstellungsseite die Schaltfläche zur Kündigung der Mitgliedschaftsverlängerung an und bestätige die Kündigung dann.";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "Du kannst die automatische Verlängerung der Mitgliedschaft jederzeit vor dem Verlängerungsdatum deaktivieren und die Vorteile einer Premium-Mitgliedschaft bis zum Ende der bereits bezahlten Abonnementlaufzeit nutzen. Um die automatische Verlängerung der Mitgliedschaft zu deaktivieren, klicke bitte im Reiter {linkStartTag}Zahlungen{linkEndTag} auf der Einstellungsseite die Schaltfläche zur Kündigung der Mitgliedschaftsverlängerung an und bestätige die Kündigung dann.";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"Erfahren Sie mehr über den Builders Club und wie wir die {startLinkTag}Sicherheit von Kindern{endLinkTag} gewährleisten.";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "Erfahren Sie mehr über den Builders Club und wie wir die {startLinkTag}Sicherheit von Kindern{endLinkTag} gewährleisten.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"Erfahre mehr über Premium und wie wir die {startLinkTag}Sicherheit von Kindern{endLinkTag} gewährleisten.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "Erfahre mehr über Premium und wie wir die {startLinkTag}Sicherheit von Kindern{endLinkTag} gewährleisten.";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robux kaufen";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "Kündigung";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "Spielkarten";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "Eltern";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "Kaufe Robux mit";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"Credits-Guthaben: {amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "Credits-Guthaben: {amount}";
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
		return "Roblox-Spielkarten";
	}
}
