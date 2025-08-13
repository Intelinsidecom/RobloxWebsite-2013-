namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CashOutResources_de_de : CashOutResources_en_us, ICashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "Auszahlen";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "Jetzt holen";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "Jetzt OBC holen";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "Mitgliedschaft aufwerten";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verifizieren";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "E-Mail-Adresse verifizieren";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "Jetzt verifizieren";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "DevEx besuchen";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "Developer Exchange: Erstelle Spiele, verdiene Geld.";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public override string HeadingYourUpdate => "Deine Aktualisierung";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "Du bist fast bereit!";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "Du musst „Outrageous Builders Club“-Mitglied sein, um Robux gegen echtes Geld eintauschen zu können.";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "Du musst „Outrageous Builders Club“-Mitglied sein, um Auszahlungen erhalten zu können.";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "Aktueller Kurs";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "Status: Abgeschlossen";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "Status: Ausstehend";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "Status: Abgelehnt";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "Für die Nutzung von DevEx benötigst du eine verifizierte E-Mail-Adresse.";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "Du bist derzeit nicht dazu berechtigt.";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "Du hast nicht genügend Robux für eine Auszahlung.";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "Du benötigst Roblox-Premium, um Robux gegen Bargeld einzutauschen.";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "Bald kannst du Robux gegen echtes Geld eintauschen!";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "Du hast es fast geschafft! Du kannst schon bald Robux gegen echtes Geld eintauschen!";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "Bevor du Auszahlungen erhalten kannst, musst du deine E-Mail-Adresse verifizieren.";

	public CashOutResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "Auszahlen";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "Jetzt holen";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "Jetzt OBC holen";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "Mitgliedschaft aufwerten";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verifizieren";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "E-Mail-Adresse verifizieren";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "Jetzt verifizieren";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "DevEx besuchen";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"Deine DevEx-Anfrage wurde abgeschlossen. Auf der Seite {startMoneyLink}Geld{endMoneyLink} findest du weitere Infos.";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "Deine DevEx-Anfrage wurde abgeschlossen. Auf der Seite {startMoneyLink}Geld{endMoneyLink} findest du weitere Infos.";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"Deine DevEx-Anfrage wurde am {requestDate} gesendet.";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "Deine DevEx-Anfrage wurde am {requestDate} gesendet.";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* Alte Robux werden eventuell zu einer anderen Rate ausbezahlt. Bitte klicke {helpLinkStart}hier{helpLinkEnd}, um weitere Informationen zu erhalten.";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* Alte Robux werden eventuell zu einer anderen Rate ausbezahlt. Bitte klicke {helpLinkStart}hier{helpLinkEnd}, um weitere Informationen zu erhalten.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Erfahre mehr{endDevExLink} über Developer Exchange.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "{startDevExLink}Erfahre mehr{endDevExLink} über Developer Exchange.";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Besuche{endDevExLink} Developer Exchange.";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "{startDevExLink}Besuche{endDevExLink} Developer Exchange.";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Developer Exchange: Erstelle Spiele, verdiene Geld.";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "Deine Aktualisierung";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "Du bist fast bereit!";
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
		return "Du musst „Outrageous Builders Club“-Mitglied sein, um Robux gegen echtes Geld eintauschen zu können.";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "Du musst „Outrageous Builders Club“-Mitglied sein, um Auszahlungen erhalten zu können.";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "Aktueller Kurs";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"Der aktuelle Kurs gilt für alle Beträge, die größer als {minimumDevexRobuxAmount} Robux sind";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "Der aktuelle Kurs gilt für alle Beträge, die größer als {minimumDevexRobuxAmount} Robux sind";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "Status: Abgeschlossen";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "Status: Ausstehend";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "Status: Abgelehnt";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "Für die Nutzung von DevEx benötigst du eine verifizierte E-Mail-Adresse.";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "Du bist derzeit nicht dazu berechtigt.";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "Du hast nicht genügend Robux für eine Auszahlung.";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "Du benötigst Roblox-Premium, um Robux gegen Bargeld einzutauschen.";
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
		return $"{robuxAmount} Robux für {usdAmount}";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "{robuxAmount} Robux für {usdAmount}";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "Bald kannst du Robux gegen echtes Geld eintauschen!";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "Du hast es fast geschafft! Du kannst schon bald Robux gegen echtes Geld eintauschen!";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "Bevor du Auszahlungen erhalten kannst, musst du deine E-Mail-Adresse verifizieren.";
	}
}
