namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPageResources_ja_jp : BuildersClubPageResources_en_us, IBuildersClubPageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public override string DescriptionSigningBonusDesclaimer => "* 加入ボーナスは、メンバーシップの初回購入時のみです。";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "Roblox Builders Clubにアップグレード";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "年間";

	/// <summary>
	/// Key: "Label.Annually"
	/// label
	/// English String: "Annually"
	/// </summary>
	public override string LabelAnnually => "年間";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public override string LabelBenefitTypeAdFree => "広告ブロック";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "BCベータ機能";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "ボーナスギア";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "作成できるグループ";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public override string LabelBenefitTypeDailyRobux => "1日のRobux";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public override string LabelBenefitTypeJoinGroups => "参加できるグループ";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "課金アクセス";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "アイテムの販売";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "加入ボーナス*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "取引システム";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "バーチャル帽子";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "6ヶ月ごと";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "永久";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "メンバーシップ:";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "月間";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "なし";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "なし";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "現在のプラン";

	public BuildersClubPageResources_ja_jp(TranslationResourceState state)
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
		return $"今回の購入で、現在のメンバーシップの残り日数が{currentRenewalDays}日から{daysCreditCount}日に変わります。この日数分が新しいメンバーシップに追加されます。";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "今回の購入で、現在のメンバーシップの残り日数が{currentRenewalDays}日から{daysCreditCount}日に変わります。この日数分が新しいメンバーシップに追加されます。";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "* 加入ボーナスは、メンバーシップの初回購入時のみです。";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "Roblox Builders Clubにアップグレード";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "年間";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "年間";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "広告ブロック";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "BCベータ機能";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "ボーナスギア";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "作成できるグループ";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "1日のRobux";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "参加できるグループ";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "課金アクセス";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "アイテムの販売";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "加入ボーナス*";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "取引システム";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "バーチャル帽子";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"現在のメンバーシップ: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "現在のメンバーシップ: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "6ヶ月ごと";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"期限: {expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "期限: {expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "永久";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "メンバーシップ:";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "月間";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public override string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"新しいメンバーシップ: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "新しいメンバーシップ: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "なし";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "なし";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"更新: {renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "更新: {renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "現在のプラン";
	}
}
