namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPageResources_de_de : BuildersClubPageResources_en_us, IBuildersClubPageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public override string DescriptionSigningBonusDesclaimer => "* Anmeldungsbonus gilt nur für den ersten Erwerb einer Mitgliedschaft.";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "Aufwertung zum Roblox Builders Club";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "Jährlich";

	/// <summary>
	/// Key: "Label.Annually"
	/// label
	/// English String: "Annually"
	/// </summary>
	public override string LabelAnnually => "Jährlich";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public override string LabelBenefitTypeAdFree => "Keine Werbung";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "BC-Beta-Features";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "Bonus-Ausrüstung";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "Erstelle Gruppen";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public override string LabelBenefitTypeDailyRobux => "Tägliche Robux";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public override string LabelBenefitTypeJoinGroups => "Tritt Gruppen bei";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "Bezahlter Zugang";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "Verkaufe Objekte";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "Anmeldungsbonus*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "Handelssystem";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "Virtueller Hut";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "Alle 6 Monate";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "Auf Lebenszeit";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "Mitgliedschaft:";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "Monatlich";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "Nein";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "Keine Auswahl";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "Dein aktuelles Abo";

	public BuildersClubPageResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.DowngradeWarning"
	/// description
	/// English String: "This purchase will convert your remaining {currentRenewalDays} days of current membership to {daysCreditCount} days of new membership. These days will be added to your new membership."
	/// </summary>
	public override string DescriptionDowngradeWarning(string currentRenewalDays, string daysCreditCount)
	{
		return $"Dieser Kauf wandelt die verbleibenden {currentRenewalDays} Tage deiner aktuellen Mitgliedschaft in {daysCreditCount} Tage deiner neuen Mitgliedschaft um. Diese Tage werden zu deiner neuen Mitgliedschaft hinzugefügt.";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "Dieser Kauf wandelt die verbleibenden {currentRenewalDays} Tage deiner aktuellen Mitgliedschaft in {daysCreditCount} Tage deiner neuen Mitgliedschaft um. Diese Tage werden zu deiner neuen Mitgliedschaft hinzugefügt.";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "* Anmeldungsbonus gilt nur für den ersten Erwerb einer Mitgliedschaft.";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "Aufwertung zum Roblox Builders Club";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "Jährlich";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "Jährlich";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "Keine Werbung";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "BC-Beta-Features";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "Bonus-Ausrüstung";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "Erstelle Gruppen";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "Tägliche Robux";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "Tritt Gruppen bei";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "Bezahlter Zugang";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "Verkaufe Objekte";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "Anmeldungsbonus*";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "Handelssystem";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "Virtueller Hut";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"Aktuelle Mitgliedschaft: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "Aktuelle Mitgliedschaft: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "Alle 6 Monate";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"Läuft ab: {expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "Läuft ab: {expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "Auf Lebenszeit";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "Mitgliedschaft:";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "Monatlich";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public override string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"Neue Mitgliedschaft: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "Neue Mitgliedschaft: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "Nein";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "Keine Auswahl";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"Wird verlängert: {renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "Wird verlängert: {renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "Dein aktuelles Abo";
	}
}
