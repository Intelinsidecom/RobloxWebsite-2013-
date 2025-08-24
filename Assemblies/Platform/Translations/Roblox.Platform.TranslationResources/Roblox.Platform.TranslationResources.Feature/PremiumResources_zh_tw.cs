namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumResources_zh_tw : PremiumResources_en_us, IPremiumResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Bought"
	/// English String: "Bought"
	/// </summary>
	public override string ActionBought => "已購買";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "現在購買！";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "購買 Robux";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "購買 Robux 時獲得額外 10%";

	/// <summary>
	/// Key: "Description.GooglePlayMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that is charged to your Google Play account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Google Play account settings. If you’re under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionGooglePlayMonthlySubscriptionDisclosure => "Roblox Premium 是月費制的訂閱制度。完成購買時，我們會向您的 Google Play 帳號收費。Roblox Premium 會自動續訂，但若您目前的訂閱還剩超過 24 小時，您可以關閉自動更新。在您的訂閱結束的前 24 小時以內，我們將會向您的帳號收費。您可以在 Google Play 帳號設定頁面管理訂閱與自動更新選項。若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "加入 Roblox Premium 之後，您將可以每個月領取 Robux，購買 Robux 時也將獲得 10% 獎勵。除此之外，您還能享用更多 Roblox 功能，包括購買、販賣和交易道具，和增加遊戲中買賣抽成。";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "轉賣道具和販賣您的作品，獲得更多 Robux";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "與其他 Premium 會員交換道具";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "購買 Robux";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "確認取消";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "更多功能";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "錯誤";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "您為 Premium 使用者，購買 Robux 時可享有折扣！";

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
	public override string HeadingServerError => "伺服器錯誤";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "無法訂閱";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "確認訂閱更新";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "找不到 Builders Club";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "升級到 Roblox Premium";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "無法升級";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "因為您已訂閱，";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "取得更多！";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "訂閱後優惠價格";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "購買 1 次";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "購買 Robux";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "確認";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "您目前的方案";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "以 9 折優惠價購買 Robux";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "取得更多 Robux";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "若要管理 Premium 訂閱，請在瀏覽器前往帳務設定。";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "否";

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
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 1 個月";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 1 個月";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 1 個月";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "販賣更多";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "您會獲得 10% 額外 Robux";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "訂閱";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "交易";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "超值配套";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public override string LabelWantMoreRobux => "想要更多 Robux？";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "是";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageGeneralError => "更新您的訂閱時發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "沒有訂閱資訊。";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "更新您的訂閱時伺服器發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "找不到此使用者的 Builders Club 資訊。";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "對不起，目前沒有與 Lifetime Builders Club 相等的配套，無法變更您的訂閱。";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "確認訂閱更新";

	public PremiumResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "已購買";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "現在購買！";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "購買 Robux";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robux 可以用來購買虛擬人偶強化貨遊戲內的特殊能力。若要了解如何取得 Robux，{lineBreak}訂閱 Roblox Premium 可以每一個月獲得更多 Robux，並使用額外功能。Roblox Premium 採月費制，直到取消為止。{learnMoreLinkStart}前往此處了解更多{learnMoreLinkEnd}。";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Robux 可以用來購買虛擬人偶強化貨遊戲內的特殊能力。若要了解如何取得 Robux，{lineBreak}訂閱 Roblox Premium 可以每一個月獲得更多 Robux，並使用額外功能。Roblox Premium 採月費制，直到取消為止。{learnMoreLinkStart}前往此處了解更多{learnMoreLinkEnd}。";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"取得 Robux 強化您的虛擬人偶及購買遊戲內的特殊能力。若要了解如何取得 Robux，請前往 {helpLinkStart}Robux 說明頁面{helpLinkEnd}。{paragraphBreaker}購買 Roblox Premium 就能以相同價格取得更多 Robux。Roblox Premium 採月費制，直到取消為止。{learnMoreLinkStart}前往此處了解更多{learnMoreLinkEnd}。";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "取得 Robux 強化您的虛擬人偶及購買遊戲內的特殊能力。若要了解如何取得 Robux，請前往 {helpLinkStart}Robux 說明頁面{helpLinkEnd}。{paragraphBreaker}購買 Roblox Premium 就能以相同價格取得更多 Robux。Roblox Premium 採月費制，直到取消為止。{learnMoreLinkStart}前往此處了解更多{learnMoreLinkEnd}。";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "購買 Robux 時獲得額外 10%";
	}

	protected override string _GetTemplateForDescriptionGooglePlayMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium 是月費制的訂閱制度。完成購買時，我們會向您的 Google Play 帳號收費。Roblox Premium 會自動續訂，但若您目前的訂閱還剩超過 24 小時，您可以關閉自動更新。在您的訂閱結束的前 24 小時以內，我們將會向您的帳號收費。您可以在 Google Play 帳號設定頁面管理訂閱與自動更新選項。若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premium 是每個月費用 {costPrice} 的訂閱制度。完成購買時，我們會向您的 iTunes 帳號收費。Roblox Premium 會自動續訂，但若您目前的訂閱還剩超過 24 小時，您可以關閉自動更新。在您的訂閱結束的前 24 小時以內，我們將會向您的帳號收取 {renewalPrice}。您可以在帳號設定頁面管理訂閱與自動更新選項。若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium 是每個月費用 {costPrice} 的訂閱制度。完成購買時，我們會向您的 iTunes 帳號收費。Roblox Premium 會自動續訂，但若您目前的訂閱還剩超過 24 小時，您可以關閉自動更新。在您的訂閱結束的前 24 小時以內，我們將會向您的帳號收取 {renewalPrice}。您可以在帳號設定頁面管理訂閱與自動更新選項。若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public override string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox Premium 是{durationType}費用 {costPrice} 的訂閱制度。完成購買時，我們會向您的 iTunes 帳號收費。Roblox Premium 會自動續訂，但若您目前的訂閱還剩超過 24 小時，您可以關閉自動更新。在您的訂閱結束的前 24 小時以內，我們將會向您的帳號收取 {renewalPrice}。您可以在帳號設定頁面管理訂閱與自動更新選項。";
	}

	protected override string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox Premium 是{durationType}費用 {costPrice} 的訂閱制度。完成購買時，我們會向您的 iTunes 帳號收費。Roblox Premium 會自動續訂，但若您目前的訂閱還剩超過 24 小時，您可以關閉自動更新。在您的訂閱結束的前 24 小時以內，我們將會向您的帳號收取 {renewalPrice}。您可以在帳號設定頁面管理訂閱與自動更新選項。";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"您購買 Robux 時只會獲得使用 Robux 的授權。該授權具有限制性、無法退款、無法轉讓、可被收回，並且沒有金錢價值。若要了解其它限制，請前往{termsLinkStart}使用條款{termsLinkEnd}。若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "您購買 Robux 時只會獲得使用 Robux 的授權。該授權具有限制性、無法退款、無法轉讓、可被收回，並且沒有金錢價值。若要了解其它限制，請前往{termsLinkStart}使用條款{termsLinkEnd}。若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。按下「提交訂單」即表示 (1) 您授權我們每個月向您的帳號扣款，直到你取消訂閱為止；(2) 您了解並同意{termsLinkStart}使用條款{termsLinkEnd}與{privacyLinkStart}隱私權政策{privatyLinkEnd}。您隨時可以前往設定頁面裡的 {billingLinkStart}帳務標籤{billingLinkEnd}使用按鈕取消您的會員資格。若您取消，您依然需要為目前的帳單週期付費。";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。按下「提交訂單」即表示 (1) 您授權我們每個月向您的帳號扣款，直到你取消訂閱為止；(2) 您了解並同意{termsLinkStart}使用條款{termsLinkEnd}與{privacyLinkStart}隱私權政策{privatyLinkEnd}。您隨時可以前往設定頁面裡的 {billingLinkStart}帳務標籤{billingLinkEnd}使用按鈕取消您的會員資格。若您取消，您依然需要為目前的帳單週期付費。";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。按下「提交訂單」即表示 (1) 您授權我們每個月向您的帳號扣款，直到你取消訂閱為止；(2) 您了解並同意{teamOfUseLinkStart}使用條款{teamOfUseLinkEnd}與{privacyPolicyLinkStart}隱私權政策{privacyPolicyLinkEnd}。您隨時可以前往設定頁面裡的 {billingTabLinkStart}帳務標籤{billingTabLinkEnd}使用按鈕取消您的會員資格。若您取消，您依然需要為目前的帳單週期付費。";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "若您未滿 18 歲，請在購買之前徵求家長或法定監護人的同意。若您在未經同意下進行購買，您的帳號可能會遭刪除。按下「提交訂單」即表示 (1) 您授權我們每個月向您的帳號扣款，直到你取消訂閱為止；(2) 您了解並同意{teamOfUseLinkStart}使用條款{teamOfUseLinkEnd}與{privacyPolicyLinkStart}隱私權政策{privacyPolicyLinkEnd}。您隨時可以前往設定頁面裡的 {billingTabLinkStart}帳務標籤{billingTabLinkEnd}使用按鈕取消您的會員資格。若您取消，您依然需要為目前的帳單週期付費。";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "加入 Roblox Premium 之後，您將可以每個月領取 Robux，購買 Robux 時也將獲得 10% 獎勵。除此之外，您還能享用更多 Roblox 功能，包括購買、販賣和交易道具，和增加遊戲中買賣抽成。";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "轉賣道具和販賣您的作品，獲得更多 Robux";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "與其他 Premium 會員交換道具";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "購買 Robux";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "確認取消";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "更多功能";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "錯誤";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "您為 Premium 使用者，購買 Robux 時可享有折扣！";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "伺服器錯誤";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "無法訂閱";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "確認訂閱更新";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "找不到 Builders Club";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "升級到 Roblox Premium";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "無法升級";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "因為您已訂閱，";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "取得更多！";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "訂閱後優惠價格";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "購買 1 次";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "購買 Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "確認";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "您目前的方案";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "以 9 折優惠價購買 Robux";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "取得更多 Robux";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "若要管理 Premium 訂閱，請在瀏覽器前往帳務設定。";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"您目前的訂閱為 {premiumSubscription}，於 {expirationDate} 到期。";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "您目前的訂閱為 {premiumSubscription}，於 {expirationDate} 到期。";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"您目前的方案是 {premiumSubscription}，將於 {expirationDate} 到期。會員資格到期後，您可以重新購買同一個方案或購買新的方案。";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "您目前的方案是 {premiumSubscription}，將於 {expirationDate} 到期。會員資格到期後，您可以重新購買同一個方案或購買新的方案。";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"您目前的方案為 {premiumSubscription}，更新日期為 {renewal}。";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "您目前的方案為 {premiumSubscription}，更新日期為 {renewal}。";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "否";
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
		return $"{robux}{subTextStart} / 月{subTextEnd}";
	}

	protected override string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart} / 月{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public override string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount} / 月";
	}

	protected override string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount} / 月";
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
		return "Roblox Premium 1000 1 個月";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 1 個月";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 1 個月";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "販賣更多";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "您會獲得 10% 額外 Robux";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "訂閱";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"現在訂閱，{upsellLinkStart}獲得更多！{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "現在訂閱，{upsellLinkStart}獲得更多！{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "交易";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "超值配套";
	}

	protected override string _GetTemplateForLabelWantMoreRobux()
	{
		return "想要更多 Robux？";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "是";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public override string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"按下「確認」後，您的 Builders Club 會員資格將會結束，而您將可以訂閱 Roblox Premium。{newLine}您將會收到一次性的 {robuxAmount}。";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "按下「確認」後，您的 Builders Club 會員資格將會結束，而您將可以訂閱 Roblox Premium。{newLine}您將會收到一次性的 {robuxAmount}。";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "更新您的訂閱時發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "沒有訂閱資訊。";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "更新您的訂閱時伺服器發生錯誤，請稍後再試。";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"對不起，在您目前已取消的方案失效之前，您無法訂閱。請於 {expiredDate} 之後重新訂閱。";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "對不起，在您目前已取消的方案失效之前，您無法訂閱。請於 {expiredDate} 之後重新訂閱。";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"按下「確認」代表您授權我們從 {renewalDate} 開始每個月向您收取 {price}，直至您取消或切換訂閱。";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "按下「確認」代表您授權我們從 {renewalDate} 開始每個月向您收取 {price}，直至您取消或切換訂閱。";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "找不到此使用者的 Builders Club 資訊。";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "對不起，目前沒有與 Lifetime Builders Club 相等的配套，無法變更您的訂閱。";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "確認訂閱更新";
	}
}
