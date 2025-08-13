namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPageResources_pt_br : BuildersClubPageResources_en_us, IBuildersClubPageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public override string DescriptionSigningBonusDesclaimer => "* O bônus é válido apenas para a primeira compra.";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "Faça o upgrade para Roblox Builders Club";

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
	public override string LabelAnnually => "Anualmente";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public override string LabelBenefitTypeAdFree => "Sem propagandas";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "Funcionalidade do BC Beta";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "Equipamentos bônus";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "Criar grupos";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public override string LabelBenefitTypeDailyRobux => "Robux diário";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public override string LabelBenefitTypeJoinGroups => "Entrar em grupos";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "Acesso pago";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "Venda de itens";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "Bônus de assinatura*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "Sistema de trocas";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "Chapéu virtual";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "A cada 6 meses";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "Vitalícia";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "Assinatura:";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "Mensalmente";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "Não";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "Nenhum";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "Seu plano atual";

	public BuildersClubPageResources_pt_br(TranslationResourceState state)
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
		return $"Esta compra converterá seus {currentRenewalDays} dias restantes de assinatura atual em {daysCreditCount} dias na nova assinatura. Esses dias serão adicionados à sua nova assinatura.";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "Esta compra converterá seus {currentRenewalDays} dias restantes de assinatura atual em {daysCreditCount} dias na nova assinatura. Esses dias serão adicionados à sua nova assinatura.";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "* O bônus é válido apenas para a primeira compra.";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "Faça o upgrade para Roblox Builders Club";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "Anual";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "Anualmente";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "Sem propagandas";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "Funcionalidade do BC Beta";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "Equipamentos bônus";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "Criar grupos";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "Robux diário";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "Entrar em grupos";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "Acesso pago";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "Venda de itens";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "Bônus de assinatura*";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "Sistema de trocas";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "Chapéu virtual";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"Assinatura atual: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "Assinatura atual: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "A cada 6 meses";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"Expira: {expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "Expira: {expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "Vitalícia";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "Assinatura:";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "Mensalmente";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public override string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"Nova assinatura: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "Nova assinatura: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "Não";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "Nenhum";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"Renova: {renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "Renova: {renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "Seu plano atual";
	}
}
