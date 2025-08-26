namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionSigningBonusDesclaimer => "ï¼Šè¨»å†ŠçŽå‹µä»¥ç¬¬ä¸€æ¬¡è³¼è²·æœƒå“¡è³‡æ ¼ç‚ºé™ã€‚";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "å‡ç´šåˆ° Roblox Builders Club";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "å¹´è²»åˆ¶";

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
	public override string LabelBenefitTypeAdFree => "ç„¡å»£å‘Š";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "BC æ¸¬è©¦åŠŸèƒ½";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "çŽå‹µè£å‚™";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "å¯å»ºç«‹ç¾¤çµ„æ•¸é‡";

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
	public override string LabelBenefitTypeJoinGroups => "å¯åŠ å…¥ç¾¤çµ„æ•¸é‡";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "é€šè¡Œè²»æŠ½æˆ";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "è²©è³£é“å…·";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "è¨»å†ŠçŽå‹µï¼Š";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "äº¤æ˜“ç³»çµ±";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "è™›æ“¬å¸½å­";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "æ¯ 6 å€‹æœˆ";

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
	public override string LabelMembership => "æœƒå“¡è³‡æ ¼ï¼š";

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
	public override string LabelNo => "ç„¡";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "ç„¡";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "æ‚¨ç›®å‰çš„æ–¹æ¡ˆ";

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
		return $"æ­¤è³¼è²·æœƒå°‡æ‚¨ç›®å‰å‰©é¤˜ {currentRenewalDays} å¤©çš„æœƒå“¡è³‡æ ¼è½‰æ›æˆ {daysCreditCount} å¤©çš„æ–°æœƒå“¡è³‡æ ¼ã€‚é€™äº›å¤©æ•¸å°‡æœƒåŠ åˆ°æ‚¨çš„æ–°æœƒå“¡è³‡æ ¼ä¸­ã€‚";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "æ­¤è³¼è²·æœƒå°‡æ‚¨ç›®å‰å‰©é¤˜ {currentRenewalDays} å¤©çš„æœƒå“¡è³‡æ ¼è½‰æ›æˆ {daysCreditCount} å¤©çš„æ–°æœƒå“¡è³‡æ ¼ã€‚é€™äº›å¤©æ•¸å°‡æœƒåŠ åˆ°æ‚¨çš„æ–°æœƒå“¡è³‡æ ¼ä¸­ã€‚";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "ï¼Šè¨»å†ŠçŽå‹µä»¥ç¬¬ä¸€æ¬¡è³¼è²·æœƒå“¡è³‡æ ¼ç‚ºé™ã€‚";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "å‡ç´šåˆ° Roblox Builders Club";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "å¹´è²»åˆ¶";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "æ¯å¹´";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "ç„¡å»£å‘Š";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "BC æ¸¬è©¦åŠŸèƒ½";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "çŽå‹µè£å‚™";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "å¯å»ºç«‹ç¾¤çµ„æ•¸é‡";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "æ¯æ—¥ Robux";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "å¯åŠ å…¥ç¾¤çµ„æ•¸é‡";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "é€šè¡Œè²»æŠ½æˆ";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "è²©è³£é“å…·";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "è¨»å†ŠçŽå‹µï¼Š";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "äº¤æ˜“ç³»çµ±";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "è™›æ“¬å¸½å­";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"ç›®å‰æœƒå“¡è³‡æ ¼ï¼š{currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "ç›®å‰æœƒå“¡è³‡æ ¼ï¼š{currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "æ¯ 6 å€‹æœˆ";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"æœŸé™ï¼š{expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "æœŸé™ï¼š{expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "Lifetime";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "æœƒå“¡è³‡æ ¼ï¼š";
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
		return $"æ–°æœƒå“¡è³‡æ ¼ï¼š{newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "æ–°æœƒå“¡è³‡æ ¼ï¼š{newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "ç„¡";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "ç„¡";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"çºŒç´„ï¼š{renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "çºŒç´„ï¼š{renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "æ‚¨ç›®å‰çš„æ–¹æ¡ˆ";
	}
}


}
