namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPageResources_zh_tw : BuildersClubPageResources_en_us, IBuildersClubPageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public override string DescriptionSigningBonusDesclaimer => "＊註冊獎勵以第一次購買會員資格為限。";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "升級到 Roblox Builders Club";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "年費制";

	/// <summary>
	/// Key: "Label.Annually"
	/// label
	/// English String: "Annually"
	/// </summary>
	public override string LabelAnnually => "每年";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public override string LabelBenefitTypeAdFree => "無廣告";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "BC 測試功能";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "獎勵裝備";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "可建立群組數量";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public override string LabelBenefitTypeDailyRobux => "每日 Robux";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public override string LabelBenefitTypeJoinGroups => "可加入群組數量";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "通行費抽成";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "販賣道具";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "註冊獎勵＊";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "交易系統";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "虛擬帽子";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "每 6 個月";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "Lifetime";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "會員資格：";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "每月";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "無";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "無";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "您目前的方案";

	public BuildersClubPageResources_zh_tw(TranslationResourceState state)
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
		return $"此購買會將您目前剩餘 {currentRenewalDays} 天的會員資格轉換成 {daysCreditCount} 天的新會員資格。這些天數將會加到您的新會員資格中。";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "此購買會將您目前剩餘 {currentRenewalDays} 天的會員資格轉換成 {daysCreditCount} 天的新會員資格。這些天數將會加到您的新會員資格中。";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "＊註冊獎勵以第一次購買會員資格為限。";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "升級到 Roblox Builders Club";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "年費制";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "每年";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "無廣告";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "BC 測試功能";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "獎勵裝備";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "可建立群組數量";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "每日 Robux";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "可加入群組數量";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "通行費抽成";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "販賣道具";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "註冊獎勵＊";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "交易系統";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "虛擬帽子";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"目前會員資格：{currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "目前會員資格：{currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "每 6 個月";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"期限：{expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "期限：{expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "Lifetime";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "會員資格：";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "每月";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public override string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"新會員資格：{newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "新會員資格：{newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "無";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "無";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"續約：{renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "續約：{renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "您目前的方案";
	}
}
