namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPageResources_zh_cn : BuildersClubPageResources_en_us, IBuildersClubPageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public override string DescriptionSigningBonusDesclaimer => "*额外注册奖励仅限首次会员购买。";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "升级至 Roblox Builders Club";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "每年";

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
	public override string LabelBenefitTypeAdFree => "无广告";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "BC Beta 版功能";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "额外奖励装备";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "创建群组";

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
	public override string LabelBenefitTypeJoinGroups => "加入群组";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "付费通行证";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "出售物品";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "注册额外奖励*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "交易系统";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "虚拟帽子";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "每 6 个月";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "终身";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "会员资格：";

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
	public override string LabelNo => "否";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "无";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "你的当前方案";

	public BuildersClubPageResources_zh_cn(TranslationResourceState state)
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
		return $"此购买会将你当前剩余的 {currentRenewalDays} 天会员资格转换为 {daysCreditCount} 天的新会员资格。这些天数将被添加至你的新会员资格中。";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "此购买会将你当前剩余的 {currentRenewalDays} 天会员资格转换为 {daysCreditCount} 天的新会员资格。这些天数将被添加至你的新会员资格中。";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "*额外注册奖励仅限首次会员购买。";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "升级至 Roblox Builders Club";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "每年";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "每年";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "无广告";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "BC Beta 版功能";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "额外奖励装备";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "创建群组";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "每日 Robux";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "加入群组";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "付费通行证";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "出售物品";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "注册额外奖励*";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "交易系统";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "虚拟帽子";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"当前会员资格：{currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "当前会员资格：{currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "每 6 个月";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"失效日期：{expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "失效日期：{expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "终身";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "会员资格：";
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
		return $"新会员资格：{newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "新会员资格：{newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "否";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "无";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"续订日期：{renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "续订日期：{renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "你的当前方案";
	}
}
