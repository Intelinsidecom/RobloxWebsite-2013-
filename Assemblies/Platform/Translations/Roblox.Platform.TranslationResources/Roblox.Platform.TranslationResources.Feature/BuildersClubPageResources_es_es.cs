namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPageResources_es_es : BuildersClubPageResources_en_us, IBuildersClubPageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public override string DescriptionSigningBonusDesclaimer => "* El bonus se otorgará solamente con la compra de la primera suscripción.";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "Mejorar al Roblox Builders Club";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "Anual";

	/// <summary>
	/// Key: "Label.Annually"
	/// label
	/// English String: "Annually"
	/// </summary>
	public override string LabelAnnually => "Anual";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public override string LabelBenefitTypeAdFree => "Sin anuncios";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "Funciones beta del BC";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "Equipamiento extra";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "Crear grupos";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public override string LabelBenefitTypeDailyRobux => "Robux diarios";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public override string LabelBenefitTypeJoinGroups => "Unirse a grupos";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "Acceso de pago";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "Vender objetos";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "Bonus de suscripción*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "Sistema de intercambio";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "Sombrero virtual";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "Cada 6 meses";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "Vitalicio";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "Suscripción:";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "Mensual";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "No";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "Ninguno";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "Tu plan actual";

	public BuildersClubPageResources_es_es(TranslationResourceState state)
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
		return $"Esta compra convertirá los {currentRenewalDays} días restantes de tu suscripción actual en {daysCreditCount} días de la nueva suscripción. Esos días se añadirán a tu nueva suscripción.";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "Esta compra convertirá los {currentRenewalDays} días restantes de tu suscripción actual en {daysCreditCount} días de la nueva suscripción. Esos días se añadirán a tu nueva suscripción.";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "* El bonus se otorgará solamente con la compra de la primera suscripción.";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "Mejorar al Roblox Builders Club";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "Anual";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "Anual";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "Sin anuncios";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "Funciones beta del BC";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "Equipamiento extra";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "Crear grupos";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "Robux diarios";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "Unirse a grupos";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "Acceso de pago";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "Vender objetos";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "Bonus de suscripción*";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "Sistema de intercambio";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "Sombrero virtual";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"Suscripción actual: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "Suscripción actual: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "Cada 6 meses";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"Caducidad: {expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "Caducidad: {expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "Vitalicio";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "Suscripción:";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "Mensual";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public override string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"Nueva suscripción: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "Nueva suscripción: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "No";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "Ninguno";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"Renovación: {renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "Renovación: {renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "Tu plan actual";
	}
}
