namespace Roblox.TranslationResources.Feature;

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
	public override string DescriptionSigningBonusDesclaimer => "* 가입 보너스는 멤버십 최초 구매 시만 적용됩니다.";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public override string HeadingBuildersClubUpgrade => "Roblox Builders Club으로 업그레이드";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public override string LabelAnnual => "연간";

	/// <summary>
	/// Key: "Label.Annually"
	/// label
	/// English String: "Annually"
	/// </summary>
	public override string LabelAnnually => "연간";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public override string LabelBenefitTypeAdFree => "광고 제거";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public override string LabelBenefitTypeBCBetaFeatures => "BC 베타 기능";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public override string LabelBenefitTypeBonusGear => "보너스 장비";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public override string LabelBenefitTypeCreateGroups => "그룹 만들기";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public override string LabelBenefitTypeDailyRobux => "일일 Robux";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public override string LabelBenefitTypeJoinGroups => "그룹 가입";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public override string LabelBenefitTypePaidAccess => "유료 이용권";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public override string LabelBenefitTypeSellStuff => "아이템 판매";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public override string LabelBenefitTypeSigningBonus => "가입 보너스*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public override string LabelBenefitTypeTradeSystem => "거래 시스템";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public override string LabelBenefitTypeVirtualHat => "가상 모자";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public override string LabelEverySixMonths => "매 6개월";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "평생";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public override string LabelMembership => "멤버십:";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "월간";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "아니요";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "없음";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelYourCurrentPlan => "회원님의 현재 플랜";

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
		return $"본 구매로 현재 멤버십의 잔여 {currentRenewalDays}일이 새 멤버십의 {daysCreditCount}일로 전환되어 새 멤버십에 추가됩니다.";
	}

	protected override string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "본 구매로 현재 멤버십의 잔여 {currentRenewalDays}일이 새 멤버십의 {daysCreditCount}일로 전환되어 새 멤버십에 추가됩니다.";
	}

	protected override string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "* 가입 보너스는 멤버십 최초 구매 시만 적용됩니다.";
	}

	protected override string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "Roblox Builders Club으로 업그레이드";
	}

	protected override string _GetTemplateForLabelAnnual()
	{
		return "연간";
	}

	protected override string _GetTemplateForLabelAnnually()
	{
		return "연간";
	}

	protected override string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "광고 제거";
	}

	protected override string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "BC 베타 기능";
	}

	protected override string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "보너스 장비";
	}

	protected override string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "그룹 만들기";
	}

	protected override string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "일일 Robux";
	}

	protected override string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "그룹 가입";
	}

	protected override string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "유료 이용권";
	}

	protected override string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "아이템 판매";
	}

	protected override string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "가입 보너스*";
	}

	protected override string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "거래 시스템";
	}

	protected override string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "가상 모자";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public override string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"현재 멤버십: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelCurrentMembership()
	{
		return "현재 멤버십: {currentPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelEverySixMonths()
	{
		return "매 6개월";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public override string LabelExpiresDate(string expirationDate)
	{
		return $"만료: {expirationDate}";
	}

	protected override string _GetTemplateForLabelExpiresDate()
	{
		return "만료: {expirationDate}";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "평생";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "멤버십:";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "월간";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public override string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"새 멤버십: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNewMembership()
	{
		return "새 멤버십: {newPremiumFeatureName}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "아니요";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "없음";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public override string LabelRenewsDate(string renewalDate)
	{
		return $"갱신: {renewalDate}";
	}

	protected override string _GetTemplateForLabelRenewsDate()
	{
		return "갱신: {renewalDate}";
	}

	protected override string _GetTemplateForLabelYourCurrentPlan()
	{
		return "회원님의 현재 플랜";
	}
}
