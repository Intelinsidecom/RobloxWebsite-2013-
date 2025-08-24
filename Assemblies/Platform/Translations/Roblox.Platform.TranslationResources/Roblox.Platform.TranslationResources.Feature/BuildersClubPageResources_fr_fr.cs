namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPageResources_fr_fr : BuildersClubPageResources_en_us, IBuildersClubPageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public override string DescriptionSigningBonusDesclaimer => "* Le bonus d'inscription n'est valable que pour le tout premier abonnement.";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "Passer au Roblox Builders Club";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "Annuel";

	/// <summary>
	/// Key: "Label.Annually"
	/// label
	/// English String: "Annually"
	/// </summary>
	public override string LabelAnnually => "Annuel";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public override string LabelBenefitTypeAdFree => "Sans publicité";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "Fonctionnalités bêta du BC";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "Équipement bonus";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "Créer des groupes";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public override string LabelBenefitTypeDailyRobux => "Robux quotidiens";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public override string LabelBenefitTypeJoinGroups => "Rejoindre des groupes";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "Accès payant";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "Vendre des articles";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "Bonus d'inscription*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "Système d'échange";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "Chapeau virtuel";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "Tous les 6\u00a0mois";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "À vie";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "Abonnement\u00a0:";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "Mensuel";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "Non";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "Aucun";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "Votre plan actuel";

	public BuildersClubPageResources_fr_fr(TranslationResourceState state)
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
		return $"Cet achat convertira les {currentRenewalDays}\u00a0jours restants de l'abonnement actuel en {daysCreditCount}\u00a0jours de nouvel abonnement. Ces jours seront ajoutés à votre nouvel abonnement.";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "Cet achat convertira les {currentRenewalDays}\u00a0jours restants de l'abonnement actuel en {daysCreditCount}\u00a0jours de nouvel abonnement. Ces jours seront ajoutés à votre nouvel abonnement.";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "* Le bonus d'inscription n'est valable que pour le tout premier abonnement.";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "Passer au Roblox Builders Club";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "Annuel";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "Annuel";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "Sans publicité";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "Fonctionnalités bêta du BC";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "Équipement bonus";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "Créer des groupes";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "Robux quotidiens";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "Rejoindre des groupes";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "Accès payant";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "Vendre des articles";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "Bonus d'inscription*";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "Système d'échange";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "Chapeau virtuel";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"Abonnement actuel\u00a0: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "Abonnement actuel\u00a0: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "Tous les 6\u00a0mois";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"Expiration\u00a0: {expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "Expiration\u00a0: {expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "À vie";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "Abonnement\u00a0:";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "Mensuel";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public override string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"Nouvel abonnement\u00a0: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "Nouvel abonnement\u00a0: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "Non";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "Aucun";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"Renouvellement\u00a0: {renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "Renouvellement\u00a0: {renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "Votre plan actuel";
	}
}
