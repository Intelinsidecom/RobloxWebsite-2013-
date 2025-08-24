namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumResources_ko_kr : PremiumResources_en_us, IPremiumResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Bought"
	/// English String: "Bought"
	/// </summary>
	public override string ActionBought => "구매함";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "지금 구매하세요!";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux 구매";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "Robux 구매 시 10% 더 획득";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "Roblox Premium에 가입하면 매월 일정한 Robux를 지급받게 되며, Robux 구매 시 10% 보너스 혜택을 받을 수 있습니다. 또한 아이템 구입, 판매, 거래와 같은 Roblox 경제 기능을 사용할 수 있을 뿐 아니라, 게임 내 판매 시 보다 높은 비율로 수익을 얻을 수 있습니다.";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "아이템을 다시 판매하여 여러분의 작품에 대해 더 많은 Robux를 획득해보세요.";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "다른 Premium 멤버와 아이템 거래";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robux 구매";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "취소 확인";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "더 많은 기능";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "오류";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "Premium 회원이셔서, Robux 구매 시 할인받을 수 있어요!";

	/// <summary>
	/// Key: "Heading.RobloxPremium"
	/// The title of Subscription page
	/// English String: "Roblox Premium"
	/// </summary>
	public override string HeadingRobloxPremium => "Roblox Premium";

	/// <summary>
	/// Key: "Heading.ServerError"
	/// English String: "Server Error"
	/// </summary>
	public override string HeadingServerError => "서버 오류";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "가입 신청 불가";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "가입 업데이트 확인";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "Builders Club을 찾을 수 없습니다";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "Roblox Premium으로 업그레이드";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "업그레이드 이용 불가";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "Robux가 10% 더 추가됩니다";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "더 많이 받으세요!";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "가입 기반 추천!";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "1회 구매";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "Robux 구매";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "취소";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "확인";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "회원님의 현재 플랜";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "Robux 10% 할인 받기";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "더 많은 Robux 획득";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "Premium 가입을 관리하려면, 브라우저에서 청구 설정으로 이동하세요.";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "아니요";

	/// <summary>
	/// Key: "Label.PremiumClub2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelPremiumClub2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium"
	/// English String: "Roblox Premium"
	/// </summary>
	public override string LabelRobloxPremium => "Roblox Premium";

	/// <summary>
	/// Key: "Label.RobloxPremium1000"
	/// English String: "Roblox Premium 1000"
	/// </summary>
	public override string LabelRobloxPremium1000 => "Roblox Premium 1000";

	/// <summary>
	/// Key: "Label.RobloxPremium1000OneMonth"
	/// English String: "Roblox Premium 1000 One Month"
	/// </summary>
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 1개월";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 1개월";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 1개월";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "판매 금액 증가";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "가입하셨으니까요";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "가입";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "거래";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "밸류 팩";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public override string LabelWantMoreRobux => "더 많은 Robux를 원하시나요?";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "예";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageGeneralError => "가입 업데이트 중 오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "가입 정보가 없어요.";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "가입 업데이트 중 서버 오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "본 사용자의 Builders Club 정보를 찾을 수 없어요.";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "죄송합니다. 평생 Builders Club과 대등한 패키지가 존재하지 않아 플랜을 변경할 수 없어요.";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "가입 업데이트 확인";

	public PremiumResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "구매함";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "지금 구매하세요!";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux 구매";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robux를 구매하면 아바타 업그레이드 혹은 특수 능력을 구매할 수 있습니다.{lineBreak} Roblox Premium에 가입해 매월 추가 Robux 및 보너스 기능을 획득하세요. Premium 비용은 취소할 때까지 매달 부과됩니다. {learnMoreLinkStart}여기{learnMoreLinkEnd}에서 더 자세히 알아보세요.";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Robux를 구매하면 아바타 업그레이드 혹은 특수 능력을 구매할 수 있습니다.{lineBreak} Roblox Premium에 가입해 매월 추가 Robux 및 보너스 기능을 획득하세요. Premium 비용은 취소할 때까지 매달 부과됩니다. {learnMoreLinkStart}여기{learnMoreLinkEnd}에서 더 자세히 알아보세요.";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robux를 획득하여 아바타를 업그레이드하거나 게임 내 특수 기능을 구매해보세요! Robux 획득 방법에 대한 자세한 내용은 {helpLinkStart}Robux 도움말 페이지{helpLinkEnd}를 참조하시기 바랍니다. {paragraphBreaker}Roblox Premium을 구매하면 같은 가격에 더 많은 Robux를 얻으실 수 있어요. Roblox Premium은 취소할 때까지 매월 결제됩니다. {learnMoreLinkStart}여기에서 자세히 알아보세요{learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "Robux를 획득하여 아바타를 업그레이드하거나 게임 내 특수 기능을 구매해보세요! Robux 획득 방법에 대한 자세한 내용은 {helpLinkStart}Robux 도움말 페이지{helpLinkEnd}를 참조하시기 바랍니다. {paragraphBreaker}Roblox Premium을 구매하면 같은 가격에 더 많은 Robux를 얻으실 수 있어요. Roblox Premium은 취소할 때까지 매월 결제됩니다. {learnMoreLinkStart}여기에서 자세히 알아보세요{learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "Robux 구매 시 10% 더 획득";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premium은 매월 {costPrice}의 가입 서비스로, 구매 완료 시 iTunes 계정으로 비용이 청구됩니다. Roblox Premium은 매월 자동으로 갱신되며, 해지하고 싶을 경우 현재의 가입 만료일을 기준으로 최소 24시간 이전에 자동 갱신을 끄면 됩니다. 현재 가입 기간 종료 전 24시간 이내에 {renewalPrice}의 비용이 청구되며 가입이 갱신됩니다. 계정 설정 페이지에서 가입을 관리하고 자동 갱신을 끌 수 있습니다. 18세 미만의 사용자라면 구매하기 전에 부모 또는 법적 보호자의 허락을 받아야 하며, 허락 없이 구매하면 계정이 삭제될 수 있습니다.";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium은 매월 {costPrice}의 가입 서비스로, 구매 완료 시 iTunes 계정으로 비용이 청구됩니다. Roblox Premium은 매월 자동으로 갱신되며, 해지하고 싶을 경우 현재의 가입 만료일을 기준으로 최소 24시간 이전에 자동 갱신을 끄면 됩니다. 현재 가입 기간 종료 전 24시간 이내에 {renewalPrice}의 비용이 청구되며 가입이 갱신됩니다. 계정 설정 페이지에서 가입을 관리하고 자동 갱신을 끌 수 있습니다. 18세 미만의 사용자라면 구매하기 전에 부모 또는 법적 보호자의 허락을 받아야 하며, 허락 없이 구매하면 계정이 삭제될 수 있습니다.";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public override string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox Premium은 {durationType} {costPrice}의 가입 서비스로, 구매 완료 시 iTunes 계정으로 비용이 청구됩니다. Roblox Premium은 매월 자동으로 갱신되며, 해지하고 싶을 경우 현재의 가입 만료일을 기준으로 최소 24시간 이전에 자동 갱신을 끄면 됩니다. 현재 가입 기간 종료 전 24시간 이내에 {renewalPrice}의 비용이 청구되며 가입이 갱신됩니다. 계정 설정 페이지에서 가입을 관리하고 자동 갱신을 끌 수 있습니다.";
	}

	protected override string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox Premium은 {durationType} {costPrice}의 가입 서비스로, 구매 완료 시 iTunes 계정으로 비용이 청구됩니다. Roblox Premium은 매월 자동으로 갱신되며, 해지하고 싶을 경우 현재의 가입 만료일을 기준으로 최소 24시간 이전에 자동 갱신을 끄면 됩니다. 현재 가입 기간 종료 전 24시간 이내에 {renewalPrice}의 비용이 청구되며 가입이 갱신됩니다. 계정 설정 페이지에서 가입을 관리하고 자동 갱신을 끌 수 있습니다.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"Robux를 구매하면, 이를 사용하기 위해 제한적이고 환불 및 양도가 불가능하며, 철회 가능한 라이선스를 받게 됩니다. Robux에는 실제 통화 가치가 없습니다. 그 외 제한 사항은 {termsLinkStart}이용 약관{termsLinkEnd}에서 확인하세요. 18세 미만의 사용자라면 구매하기 전에 부모 또는 법적 보호자의 허락을 받아야 하며, 허락 없이 구매하면 계정이 삭제될 수 있습니다.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "Robux를 구매하면, 이를 사용하기 위해 제한적이고 환불 및 양도가 불가능하며, 철회 가능한 라이선스를 받게 됩니다. Robux에는 실제 통화 가치가 없습니다. 그 외 제한 사항은 {termsLinkStart}이용 약관{termsLinkEnd}에서 확인하세요. 18세 미만의 사용자라면 구매하기 전에 부모 또는 법적 보호자의 허락을 받아야 하며, 허락 없이 구매하면 계정이 삭제될 수 있습니다.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"18세 미만의 사용자라면 Premium을 구매하기 전에 부모 또는 법적 보호자의 허락을 받아야 하며, 허락 없이 구매하면 계정이 삭제될 수 있습니다. '주문 확인'을 클릭하면 회원님은 (1) 가입을 취소할 때까지 Roblox가 계정에 요금을 청구할 수 있는 권한을 부여하며, (2) {termsLinkStart}이용 약관{termsLinkEnd} 및 {privacyLinkStart}개인정보 처리방침{privatyLinkEnd}을 이해하고 이에 동의하는 것으로 간주됩니다. 설정 페이지의 {billingLinkStart}청구 탭{billingLinkEnd}에서 '멤버십 취소'를 클릭하면 언제든지 취소할 수 있습니다. 취소한 후에도 현재 청구 기간에 대한 비용은 그대로 유지됩니다.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "18세 미만의 사용자라면 Premium을 구매하기 전에 부모 또는 법적 보호자의 허락을 받아야 하며, 허락 없이 구매하면 계정이 삭제될 수 있습니다. '주문 확인'을 클릭하면 회원님은 (1) 가입을 취소할 때까지 Roblox가 계정에 요금을 청구할 수 있는 권한을 부여하며, (2) {termsLinkStart}이용 약관{termsLinkEnd} 및 {privacyLinkStart}개인정보 처리방침{privatyLinkEnd}을 이해하고 이에 동의하는 것으로 간주됩니다. 설정 페이지의 {billingLinkStart}청구 탭{billingLinkEnd}에서 '멤버십 취소'를 클릭하면 언제든지 취소할 수 있습니다. 취소한 후에도 현재 청구 기간에 대한 비용은 그대로 유지됩니다.";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"18세 미만의 사용자라면 Premium을 구매하기 전에 부모 또는 법적 보호자의 허락을 받아야 하며, 허락 없이 구매하면 계정이 삭제될 수 있습니다. '주문 확인'을 클릭하면 회원님은 (1) 가입을 취소할 때까지 Roblox가 계정에 요금을 청구할 수 있는 권한을 부여하며, (2) {teamOfUseLinkStart}이용 약관{teamOfUseLinkEnd} 및 {privacyPolicyLinkStart}개인정보 처리방침{privacyPolicyLinkEnd}을 이해하고 이에 동의하는 것으로 간주됩니다. 설정 페이지의 {billingTabLinkStart}청구 탭{billingTabLinkEnd}에서 '멤버십 취소'를 클릭하면 언제든지 취소할 수 있습니다. 취소한 후에도 현재 청구 기간에 대한 비용은 그대로 유지됩니다.";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "18세 미만의 사용자라면 Premium을 구매하기 전에 부모 또는 법적 보호자의 허락을 받아야 하며, 허락 없이 구매하면 계정이 삭제될 수 있습니다. '주문 확인'을 클릭하면 회원님은 (1) 가입을 취소할 때까지 Roblox가 계정에 요금을 청구할 수 있는 권한을 부여하며, (2) {teamOfUseLinkStart}이용 약관{teamOfUseLinkEnd} 및 {privacyPolicyLinkStart}개인정보 처리방침{privacyPolicyLinkEnd}을 이해하고 이에 동의하는 것으로 간주됩니다. 설정 페이지의 {billingTabLinkStart}청구 탭{billingTabLinkEnd}에서 '멤버십 취소'를 클릭하면 언제든지 취소할 수 있습니다. 취소한 후에도 현재 청구 기간에 대한 비용은 그대로 유지됩니다.";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "Roblox Premium에 가입하면 매월 일정한 Robux를 지급받게 되며, Robux 구매 시 10% 보너스 혜택을 받을 수 있습니다. 또한 아이템 구입, 판매, 거래와 같은 Roblox 경제 기능을 사용할 수 있을 뿐 아니라, 게임 내 판매 시 보다 높은 비율로 수익을 얻을 수 있습니다.";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "아이템을 다시 판매하여 여러분의 작품에 대해 더 많은 Robux를 획득해보세요.";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "다른 Premium 멤버와 아이템 거래";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robux 구매";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "취소 확인";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "더 많은 기능";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "오류";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "Premium 회원이셔서, Robux 구매 시 할인받을 수 있어요!";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "서버 오류";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "가입 신청 불가";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "가입 업데이트 확인";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "Builders Club을 찾을 수 없습니다";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "Roblox Premium으로 업그레이드";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "업그레이드 이용 불가";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "Robux가 10% 더 추가됩니다";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "더 많이 받으세요!";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "가입 기반 추천!";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "1회 구매";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "Robux 구매";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "회원님의 현재 플랜";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "Robux 10% 할인 받기";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "더 많은 Robux 획득";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "Premium 가입을 관리하려면, 브라우저에서 청구 설정으로 이동하세요.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"회원님의 현재 플랜은 {premiumSubscription}입니다. 종료일은 {expirationDate}입니다.";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "회원님의 현재 플랜은 {premiumSubscription}입니다. 종료일은 {expirationDate}입니다.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"회원님의 현재 플랜은 {premiumSubscription}이며, {expirationDate}에 종료됩니다. 멤버십 종료 이후 같은 플랜에 재가입할 수도 있고, 새로운 플랜을 선택하실 수도 있습니다.";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "회원님의 현재 플랜은 {premiumSubscription}이며, {expirationDate}에 종료됩니다. 멤버십 종료 이후 같은 플랜에 재가입할 수도 있고, 새로운 플랜을 선택하실 수도 있습니다.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"회원님의 현재 플랜은 {premiumSubscription}입니다. 갱신일은 {renewal}입니다.";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "회원님의 현재 플랜은 {premiumSubscription}입니다. 갱신일은 {renewal}입니다.";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "아니요";
	}

	protected override string _GetTemplateForLabelPremiumClub2200()
	{
		return "Roblox Premium 2200";
	}

	/// <summary>
	/// Key: "Label.PriceMonth"
	/// English String: "{robux}{subTextStart}/month{subTextEnd}"
	/// </summary>
	public override string LabelPriceMonth(string robux, string subTextStart, string subTextEnd)
	{
		return $"{robux}{subTextStart}/월{subTextEnd}";
	}

	protected override string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart}/월{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public override string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount}/월";
	}

	protected override string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount}/월";
	}

	protected override string _GetTemplateForLabelRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForLabelRobloxPremium1000()
	{
		return "Roblox Premium 1000";
	}

	protected override string _GetTemplateForLabelRobloxPremium1000OneMonth()
	{
		return "Roblox Premium 1000 1개월";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 1개월";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 1개월";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "판매 금액 증가";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "가입하셨으니까요";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "가입";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"{upsellLinkStart}에 가입해 더 자세히 알아보세요! {upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "{upsellLinkStart}에 가입해 더 자세히 알아보세요! {upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "거래";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "밸류 팩";
	}

	protected override string _GetTemplateForLabelWantMoreRobux()
	{
		return "더 많은 Robux를 원하시나요?";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "예";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public override string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"'확인'을 클릭하면 현 Builders Club 멤버십이 종료되어 Roblox Premium에 가입할 수 있어요.{newLine} 일시불로 {robuxAmount}이(가) 청구됩니다.";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "'확인'을 클릭하면 현 Builders Club 멤버십이 종료되어 Roblox Premium에 가입할 수 있어요.{newLine} 일시불로 {robuxAmount}이(가) 청구됩니다.";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "가입 업데이트 중 오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "가입 정보가 없어요.";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "가입 업데이트 중 서버 오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"죄송합니다. 취소한 현재 플랜의 만료일까지 가입 신청을 하실 수 없습니다. {expiredDate}에 다시 가입 신청하세요.";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "죄송합니다. 취소한 현재 플랜의 만료일까지 가입 신청을 하실 수 없습니다. {expiredDate}에 다시 가입 신청하세요.";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"'확인'을 클릭하면 가입을 취소하거나 전환하기 전까지 {renewalDate}부터 매월 {price}의 금액이 부과됩니다.";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "'확인'을 클릭하면 가입을 취소하거나 전환하기 전까지 {renewalDate}부터 매월 {price}의 금액이 부과됩니다.";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "본 사용자의 Builders Club 정보를 찾을 수 없어요.";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "죄송합니다. 평생 Builders Club과 대등한 패키지가 존재하지 않아 플랜을 변경할 수 없어요.";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "가입 업데이트 확인";
	}
}
