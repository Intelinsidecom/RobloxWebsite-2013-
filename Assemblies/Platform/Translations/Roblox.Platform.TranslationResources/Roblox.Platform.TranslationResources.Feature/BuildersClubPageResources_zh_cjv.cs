namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubPageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPageResources_zh_cjv : BuildersClubPageResources_en_us, IBuildersClubPageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public override string DescriptionSigningBonusDesclaimer => "*é¢å¤–æ³¨å†Œå¥–åŠ±ä»…é™é¦–æ¬¡ä¼šå‘˜è´­ä¹°ã€‚";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "å‡çº§è‡³ Roblox Builders Club";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "æ¯å¹´";

	/// <summary>
	/// Key: "Label.Annually"
	/// label
	/// English String: "Annually"
	/// </summary>
	public override string LabelAnnually => "æ¯å¹´";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public override string LabelBenefitTypeAdFree => "æ— å¹¿å‘Š";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "BC Beta ç‰ˆåŠŸèƒ½";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "é¢å¤–å¥–åŠ±è£…å¤‡";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "åˆ›å»ºç¾¤ç»„";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public override string LabelBenefitTypeDailyRobux => "æ¯æ—¥ Robux";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public override string LabelBenefitTypeJoinGroups => "åŠ å…¥ç¾¤ç»„";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "ä»˜è´¹é€šè¡Œè¯";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "å‡ºå”®ç‰©å“";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "æ³¨å†Œé¢å¤–å¥–åŠ±*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "äº¤æ˜“ç³»ç»Ÿ";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "è™šæ‹Ÿå¸½å­";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "æ¯ 6 ä¸ªæœˆ";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "ç»ˆèº«";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "ä¼šå‘˜èµ„æ ¼ï¼š";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "æ¯æœˆ";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "å¦";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "æ— ";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "ä½ çš„å½“å‰æ–¹æ¡ˆ";

	public BuildersClubPageResources_zh_cjv(TranslationResourceState state)
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
		return $"æ­¤è´­ä¹°ä¼šå°†ä½ å½“å‰å‰©ä½™çš„ {currentRenewalDays} å¤©ä¼šå‘˜èµ„æ ¼è½¬æ¢ä¸º {daysCreditCount} å¤©çš„æ–°ä¼šå‘˜èµ„æ ¼ã€‚è¿™äº›å¤©æ•°å°†è¢«æ·»åŠ è‡³ä½ çš„æ–°ä¼šå‘˜èµ„æ ¼ä¸­ã€‚";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "æ­¤è´­ä¹°ä¼šå°†ä½ å½“å‰å‰©ä½™çš„ {currentRenewalDays} å¤©ä¼šå‘˜èµ„æ ¼è½¬æ¢ä¸º {daysCreditCount} å¤©çš„æ–°ä¼šå‘˜èµ„æ ¼ã€‚è¿™äº›å¤©æ•°å°†è¢«æ·»åŠ è‡³ä½ çš„æ–°ä¼šå‘˜èµ„æ ¼ä¸­ã€‚";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "*é¢å¤–æ³¨å†Œå¥–åŠ±ä»…é™é¦–æ¬¡ä¼šå‘˜è´­ä¹°ã€‚";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "å‡çº§è‡³ Roblox Builders Club";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "æ¯å¹´";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "æ¯å¹´";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "æ— å¹¿å‘Š";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "BC Beta ç‰ˆåŠŸèƒ½";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "é¢å¤–å¥–åŠ±è£…å¤‡";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "åˆ›å»ºç¾¤ç»„";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "æ¯æ—¥ Robux";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "åŠ å…¥ç¾¤ç»„";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "ä»˜è´¹é€šè¡Œè¯";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "å‡ºå”®ç‰©å“";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "æ³¨å†Œé¢å¤–å¥–åŠ±*";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "äº¤æ˜“ç³»ç»Ÿ";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "è™šæ‹Ÿå¸½å­";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"å½“å‰ä¼šå‘˜èµ„æ ¼ï¼š{currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "å½“å‰ä¼šå‘˜èµ„æ ¼ï¼š{currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "æ¯ 6 ä¸ªæœˆ";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"å¤±æ•ˆæ—¥æœŸï¼š{expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "å¤±æ•ˆæ—¥æœŸï¼š{expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "ç»ˆèº«";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "ä¼šå‘˜èµ„æ ¼ï¼š";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "æ¯æœˆ";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public override string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"æ–°ä¼šå‘˜èµ„æ ¼ï¼š{newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "æ–°ä¼šå‘˜èµ„æ ¼ï¼š{newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "å¦";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "æ— ";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"ç»­è®¢æ—¥æœŸï¼š{renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "ç»­è®¢æ—¥æœŸï¼š{renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "ä½ çš„å½“å‰æ–¹æ¡ˆ";
	}
}


}
