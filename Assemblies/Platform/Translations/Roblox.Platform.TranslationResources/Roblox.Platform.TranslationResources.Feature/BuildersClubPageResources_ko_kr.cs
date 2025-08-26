namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubPageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPageResources_ko_kr : BuildersClubPageResources_en_us, IBuildersClubPageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public override string DescriptionSigningBonusDesclaimer => "* ê°€ìž… ë³´ë„ˆìŠ¤ëŠ” ë©¤ë²„ì‹­ ìµœì´ˆ êµ¬ë§¤ ì‹œë§Œ ì ìš©ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "Roblox Builders Clubìœ¼ë¡œ ì—…ê·¸ë ˆì´ë“œ";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "ì—°ê°„";

	/// <summary>
	/// Key: "Label.Annually"
	/// label
	/// English String: "Annually"
	/// </summary>
	public override string LabelAnnually => "ì—°ê°„";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public override string LabelBenefitTypeAdFree => "ê´‘ê³  ì œê±°";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "BC ë² íƒ€ ê¸°ëŠ¥";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "ë³´ë„ˆìŠ¤ ìž¥ë¹„";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "ê·¸ë£¹ ë§Œë“¤ê¸°";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public override string LabelBenefitTypeDailyRobux => "ì¼ì¼ Robux";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public override string LabelBenefitTypeJoinGroups => "ê·¸ë£¹ ê°€ìž…";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "ìœ ë£Œ ì´ìš©ê¶Œ";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "ì•„ì´í…œ íŒë§¤";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "ê°€ìž… ë³´ë„ˆìŠ¤*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "ê±°ëž˜ ì‹œìŠ¤í…œ";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "ê°€ìƒ ëª¨ìž";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "ë§¤ 6ê°œì›”";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "í‰ìƒ";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "ë©¤ë²„ì‹­:";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "ì›”ê°„";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "ì•„ë‹ˆìš”";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "ì—†ìŒ";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœ";

	public BuildersClubPageResources_ko_kr(TranslationResourceState state)
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
		return $"ë³¸ êµ¬ë§¤ë¡œ í˜„ìž¬ ë©¤ë²„ì‹­ì˜ ìž”ì—¬ {currentRenewalDays}ì¼ì´ ìƒˆ ë©¤ë²„ì‹­ì˜ {daysCreditCount}ì¼ë¡œ ì „í™˜ë˜ì–´ ìƒˆ ë©¤ë²„ì‹­ì— ì¶”ê°€ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "ë³¸ êµ¬ë§¤ë¡œ í˜„ìž¬ ë©¤ë²„ì‹­ì˜ ìž”ì—¬ {currentRenewalDays}ì¼ì´ ìƒˆ ë©¤ë²„ì‹­ì˜ {daysCreditCount}ì¼ë¡œ ì „í™˜ë˜ì–´ ìƒˆ ë©¤ë²„ì‹­ì— ì¶”ê°€ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "* ê°€ìž… ë³´ë„ˆìŠ¤ëŠ” ë©¤ë²„ì‹­ ìµœì´ˆ êµ¬ë§¤ ì‹œë§Œ ì ìš©ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "Roblox Builders Clubìœ¼ë¡œ ì—…ê·¸ë ˆì´ë“œ";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "ì—°ê°„";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "ì—°ê°„";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "ê´‘ê³  ì œê±°";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "BC ë² íƒ€ ê¸°ëŠ¥";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "ë³´ë„ˆìŠ¤ ìž¥ë¹„";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "ê·¸ë£¹ ë§Œë“¤ê¸°";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "ì¼ì¼ Robux";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "ê·¸ë£¹ ê°€ìž…";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "ìœ ë£Œ ì´ìš©ê¶Œ";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "ì•„ì´í…œ íŒë§¤";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "ê°€ìž… ë³´ë„ˆìŠ¤*";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "ê±°ëž˜ ì‹œìŠ¤í…œ";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "ê°€ìƒ ëª¨ìž";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"í˜„ìž¬ ë©¤ë²„ì‹­: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "í˜„ìž¬ ë©¤ë²„ì‹­: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "ë§¤ 6ê°œì›”";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"ë§Œë£Œ: {expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "ë§Œë£Œ: {expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "í‰ìƒ";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "ë©¤ë²„ì‹­:";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "ì›”ê°„";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public override string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"ìƒˆ ë©¤ë²„ì‹­: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "ìƒˆ ë©¤ë²„ì‹­: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "ì•„ë‹ˆìš”";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "ì—†ìŒ";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"ê°±ì‹ : {renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "ê°±ì‹ : {renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœ";
	}
}


}
