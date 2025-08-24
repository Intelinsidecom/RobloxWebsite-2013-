namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubPanelResources_ko_kr : BuildersClubPanelResources_en_us, IBuildersClubPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux 구매";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public override string ActionRedeemCard => "카드 사용";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public override string ActionUpdateCreditCard => "신용카드 정보 업데이트";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public override string ActionWhereToBuy => "구매 장소";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public override string DescriptionBuyRobux => "Robux는 수많은 Roblox 온라인 게임에서 사용되는 가상 통화입니다. 아바타 꾸미기 및 멀티플레이어 장비 구입 뿐 아니라 한정판 아이템 판매 및 거래에도 사용할 수 있죠. 지금 구입하세요!";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robux 구매";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public override string HeadingCancellations => "취소";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public override string HeadingGameCards => "게임카드";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public override string HeadingParents => "보호자 가이드";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public override string LabelBuyRobuxWith => "Robux 구매 수단";

	/// <summary>
	/// Key: "Label.Itunes"
	/// image alt tag text
	/// English String: "iTunes"
	/// </summary>
	public override string LabelItunes => "iTunes";

	/// <summary>
	/// Key: "Label.Rixty"
	/// image alt tag text
	/// English String: "Rixty"
	/// </summary>
	public override string LabelRixty => "Rixty";

	/// <summary>
	/// Key: "Label.RobloxGameCards"
	/// label
	/// English String: "Roblox Gamecards"
	/// </summary>
	public override string LabelRobloxGameCards => "Roblox 게임카드";

	public BuildersClubPanelResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux 구매";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionRedeemCard()
	{
		return "카드 사용";
	}

	protected override string _GetTemplateForActionUpdateCreditCard()
	{
		return "신용카드 정보 업데이트";
	}

	protected override string _GetTemplateForActionWhereToBuy()
	{
		return "구매 장소";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public override string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"청구 및 결제 관련 질문: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "청구 및 결제 관련 질문: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robux는 수많은 Roblox 온라인 게임에서 사용되는 가상 통화입니다. 아바타 꾸미기 및 멀티플레이어 장비 구입 뿐 아니라 한정판 아이템 판매 및 거래에도 사용할 수 있죠. 지금 구입하세요!";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"갱신일 이전이라면 언제든지 멤버십 자동 갱신을 취소할 수 있습니다. 자동 갱신을 취소하더라도 이미 지불하신 기간 동안 계속 Builders Club 혜택을 누리실 수 있어요. 멤버십 자동 갱신을 취소하려면 설정 페이지의 {linkStartTag}청구{linkEndTag} 탭에서 ‘멤버십 갱신 취소' 버튼을 클릭한 다음 취소를 확인하세요.";
	}

	protected override string _GetTemplateForDescriptionCancellations()
	{
		return "갱신일 이전이라면 언제든지 멤버십 자동 갱신을 취소할 수 있습니다. 자동 갱신을 취소하더라도 이미 지불하신 기간 동안 계속 Builders Club 혜택을 누리실 수 있어요. 멤버십 자동 갱신을 취소하려면 설정 페이지의 {linkStartTag}청구{linkEndTag} 탭에서 ‘멤버십 갱신 취소' 버튼을 클릭한 다음 취소를 확인하세요.";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public override string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"갱신일 이전이라면 언제든지 멤버십 자동 갱신을 취소할 수 있습니다. 자동 갱신을 취소하더라도 이미 지불하신 기간 동안 계속 Premium 혜택을 누리실 수 있어요. 멤버십 자동 갱신을 취소하려면 설정 페이지의 {linkStartTag}청구{linkEndTag} 탭에서 ‘멤버십 갱신 취소' 버튼을 클릭한 다음 취소를 확인하세요.";
	}

	protected override string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "갱신일 이전이라면 언제든지 멤버십 자동 갱신을 취소할 수 있습니다. 자동 갱신을 취소하더라도 이미 지불하신 기간 동안 계속 Premium 혜택을 누리실 수 있어요. 멤버십 자동 갱신을 취소하려면 설정 페이지의 {linkStartTag}청구{linkEndTag} 탭에서 ‘멤버십 갱신 취소' 버튼을 클릭한 다음 취소를 확인하세요.";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"Builders Club 및 Roblox의 {startLinkTag}자녀 보호 방안{endLinkTag}에 대해 알아보세요.";
	}

	protected override string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "Builders Club 및 Roblox의 {startLinkTag}자녀 보호 방안{endLinkTag}에 대해 알아보세요.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public override string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"Roblox Premium 및 {startLinkTag}자녀 보호 방안{endLinkTag}에 대해 알아보세요.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "Roblox Premium 및 {startLinkTag}자녀 보호 방안{endLinkTag}에 대해 알아보세요.";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robux 구매";
	}

	protected override string _GetTemplateForHeadingCancellations()
	{
		return "취소";
	}

	protected override string _GetTemplateForHeadingGameCards()
	{
		return "게임카드";
	}

	protected override string _GetTemplateForHeadingParents()
	{
		return "보호자 가이드";
	}

	protected override string _GetTemplateForLabelBuyRobuxWith()
	{
		return "Robux 구매 수단";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public override string LabelCreditBalance(string amount)
	{
		return $"크레딧 잔액: {amount}";
	}

	protected override string _GetTemplateForLabelCreditBalance()
	{
		return "크레딧 잔액: {amount}";
	}

	protected override string _GetTemplateForLabelItunes()
	{
		return "iTunes";
	}

	protected override string _GetTemplateForLabelRixty()
	{
		return "Rixty";
	}

	protected override string _GetTemplateForLabelRobloxGameCards()
	{
		return "Roblox 게임카드";
	}
}
