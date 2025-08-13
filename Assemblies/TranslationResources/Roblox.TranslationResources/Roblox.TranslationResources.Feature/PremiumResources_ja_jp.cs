namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumResources_ja_jp : PremiumResources_en_us, IPremiumResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Bought"
	/// English String: "Bought"
	/// </summary>
	public override string ActionBought => "購入しました";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "今すぐ買う！";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robuxを買う";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "Robuxの購入で10%のボーナスをゲット";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "Roblox Premiumに入会すると毎月Robuxが支給され、さらにRobuxを購入した際に10%のボーナスをゲットします。また、すべてのゲーム内での収入アップだけでなく、購入、販売、アイテムの交換など、Robloxの経済機能にアクセスすることができます。";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "アイテムを再販売したり、作品を売ってRobuxをさらにゲット";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "他のPremiumメンバーとアイテムを取引する";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robuxを買う";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "キャンセルの確認";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "さらに多くの機能";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "エラー";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "Premiumユーザーとして、Robuxで割引きをもらえます！";

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
	public override string HeadingServerError => "サーバーエラー";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "サブスクリプションは利用できません";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "サブスクリプションの更新を確認";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "Builders Clubが見つかりませんでした";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "Roblox Premiumにアップグレード";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "アップグレードできません";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "Robuxをさらに10%ゲットします";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "さらにゲット！";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "サブスクリプションしているため！";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "一度買う";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "Robuxを買う";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "キャンセル";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "確定";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "現在のプラン";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "Robuxを10%オフでゲット";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "さらにRobuxをゲットする";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "Premiumサブスクリプションを管理するには、ブラウザを使って請求設定へ行ってください。";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "いいえ";

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
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 一ヶ月";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 一ヶ月";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 一ヶ月";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "もっと売る";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "サブスクリプションしたため";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "サブスクリプション契約する";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "取引";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "バリューパック";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public override string LabelWantMoreRobux => "Robuxがもっと必要ですか？";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "はい";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageGeneralError => "サブスクリプションのアップデート中にエラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "サブスクリプション情報はありません。";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "サブスクリプションのアップデート中にサーバーエラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "このユーザーのBuilders Club情報が見つかりません";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "申し訳ありませんが、現在、永久Builders Clubと同等のパッケージがないため、サブスクリプションの変更はできません。";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "サブスクリプションの更新を確認";

	public PremiumResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "購入しました";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "今すぐ買う！";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robuxを買う";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robuxを買ってゲーム内でアバターのアップグレードや特殊能力を購入しましょう。{lineBreak} Roblox Premiumのサブスクリプション契約をして、ボーナス機能と毎月もっとRobuxをゲット。Premiumはキャンセルするまで、毎月課金されます。 {learnMoreLinkStart}詳細はこちら。{learnMoreLinkEnd}";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Robuxを買ってゲーム内でアバターのアップグレードや特殊能力を購入しましょう。{lineBreak} Roblox Premiumのサブスクリプション契約をして、ボーナス機能と毎月もっとRobuxをゲット。Premiumはキャンセルするまで、毎月課金されます。 {learnMoreLinkStart}詳細はこちら。{learnMoreLinkEnd}";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robuxをゲットしてゲーム内でアバターのアップグレードや特殊能力を買いましょう。Robuxを稼ぐ方法についての情報については{helpLinkStart}Robuxヘルプページ{helpLinkEnd}をチェックしてください。{paragraphBreaker}Roblox Premiumを買うと、同じ金額でより多くRobuxをゲットできます。Roblox Premiumはキャンセルするまで毎月課金されます。{learnMoreLinkStart}詳細はこちら{learnMoreLinkEnd}。";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "Robuxをゲットしてゲーム内でアバターのアップグレードや特殊能力を買いましょう。Robuxを稼ぐ方法についての情報については{helpLinkStart}Robuxヘルプページ{helpLinkEnd}をチェックしてください。{paragraphBreaker}Roblox Premiumを買うと、同じ金額でより多くRobuxをゲットできます。Roblox Premiumはキャンセルするまで毎月課金されます。{learnMoreLinkStart}詳細はこちら{learnMoreLinkEnd}。";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "Robuxの購入で10%のボーナスをゲット";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premiumは、料金が月額 {costPrice} のサブスクリプション契約です。お支払いは、ご購入の確認時にiTunesアカウントに課金されます。Roblox Premiumは、現在の契約期間終了日の少なくとも24時間前に自動更新がオフにされない限り自動更新されます。アカウントは現在の契約期間の最終日の24時間以内に {renewalPrice} 課金され更新されます。サブスクリプション契約は、アカウント設定へ行けば管理したり自動更新をオフにしたりできます。18歳以下の場合は、購入する前に必ず両親か法的な保護者の許可があることを確かめてください。許可のない購入をすることは、お持ちのアカウントの削除につながることがあります。";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premiumは、料金が月額 {costPrice} のサブスクリプション契約です。お支払いは、ご購入の確認時にiTunesアカウントに課金されます。Roblox Premiumは、現在の契約期間終了日の少なくとも24時間前に自動更新がオフにされない限り自動更新されます。アカウントは現在の契約期間の最終日の24時間以内に {renewalPrice} 課金され更新されます。サブスクリプション契約は、アカウント設定へ行けば管理したり自動更新をオフにしたりできます。18歳以下の場合は、購入する前に必ず両親か法的な保護者の許可があることを確かめてください。許可のない購入をすることは、お持ちのアカウントの削除につながることがあります。";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public override string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox Premiumは、料金が {costPrice} の {durationType} サブスクリプション契約です。お支払いは、ご購入の確認時にiTunesアカウントに課金されます。Roblox Premiumは、現在の契約期間終了日の少なくとも24時間前に自動更新がオフにされない限り自動更新されます。アカウントは現在の契約期間の最終日の24時間以内に {renewalPrice} 課金され更新されます。サブスクリプション契約はアカウント設定へ行けば管理したり自動更新をオフにしたりできます。";
	}

	protected override string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox Premiumは、料金が {costPrice} の {durationType} サブスクリプション契約です。お支払いは、ご購入の確認時にiTunesアカウントに課金されます。Roblox Premiumは、現在の契約期間終了日の少なくとも24時間前に自動更新がオフにされない限り自動更新されます。アカウントは現在の契約期間の最終日の24時間以内に {renewalPrice} 課金され更新されます。サブスクリプション契約はアカウント設定へ行けば管理したり自動更新をオフにしたりできます。";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"Robuxを買うと、制限があり返金不可で譲渡不可で取り消し可能なRobuxを使うライセンスを受け取るだけで、これには現実の通貨での価値はありません。その他の制限については、{termsLinkStart}利用規約{termsLinkEnd}をご覧ください。18歳以下の場合は、購入する前に必ず両親か法的な保護者の許可があることを確かめてください。許可のない購入をすることは、お持ちのアカウントの削除につながることがあります。";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "Robuxを買うと、制限があり返金不可で譲渡不可で取り消し可能なRobuxを使うライセンスを受け取るだけで、これには現実の通貨での価値はありません。その他の制限については、{termsLinkStart}利用規約{termsLinkEnd}をご覧ください。18歳以下の場合は、購入する前に必ず両親か法的な保護者の許可があることを確かめてください。許可のない購入をすることは、お持ちのアカウントの削除につながることがあります。";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"18歳以下の場合は、購入する前に必ず両親か法的な保護者の許可があることを確かめてください。許可のない購入をすることは、お持ちのアカウントの削除につながることがあります。「ご注文を送信」をクリックすると、(1) サブスクリプション契約をキャンセルするまで毎月、当社が課金することを許可し、 (2) {termsLinkStart}利用規約{termsLinkEnd} と {privacyLinkStart}プライバシーポリシー{privatyLinkEnd}を理解し、同意を表明したことになります。設定ページにある {billingLinkStart}ご請求タブ{billingLinkEnd} の「メンバーシップをキャンセルする」をクリックすれば、いつでもキャンセルできます。キャンセルしても、現在のご請求期間に関しては課金されます。";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "18歳以下の場合は、購入する前に必ず両親か法的な保護者の許可があることを確かめてください。許可のない購入をすることは、お持ちのアカウントの削除につながることがあります。「ご注文を送信」をクリックすると、(1) サブスクリプション契約をキャンセルするまで毎月、当社が課金することを許可し、 (2) {termsLinkStart}利用規約{termsLinkEnd} と {privacyLinkStart}プライバシーポリシー{privatyLinkEnd}を理解し、同意を表明したことになります。設定ページにある {billingLinkStart}ご請求タブ{billingLinkEnd} の「メンバーシップをキャンセルする」をクリックすれば、いつでもキャンセルできます。キャンセルしても、現在のご請求期間に関しては課金されます。";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"18歳以下の場合は、購入する前に必ず両親か法的な保護者の許可があることを確かめてください。許可のない購入をすることは、お持ちのアカウントの削除につながることがあります。「ご注文を送信」をクリックすると、(1) サブスクリプション契約をキャンセルするまで毎月、当社が課金することを許可し、 (2) {teamOfUseLinkStart}利用規約{teamOfUseLinkEnd} と  {privacyPolicyLinkStart}プライバシーポリシー{privacyPolicyLinkEnd}を理解し、同意を表明したことになります。設定ページにある {billingTabLinkStart} ご請求タブ{billingTabLinkEnd} の「メンバーシップをキャンセルする」をクリックすれば、いつでもキャンセルできます。キャンセルしても、現在のご請求期間に関しては課金されます。";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "18歳以下の場合は、購入する前に必ず両親か法的な保護者の許可があることを確かめてください。許可のない購入をすることは、お持ちのアカウントの削除につながることがあります。「ご注文を送信」をクリックすると、(1) サブスクリプション契約をキャンセルするまで毎月、当社が課金することを許可し、 (2) {teamOfUseLinkStart}利用規約{teamOfUseLinkEnd} と  {privacyPolicyLinkStart}プライバシーポリシー{privacyPolicyLinkEnd}を理解し、同意を表明したことになります。設定ページにある {billingTabLinkStart} ご請求タブ{billingTabLinkEnd} の「メンバーシップをキャンセルする」をクリックすれば、いつでもキャンセルできます。キャンセルしても、現在のご請求期間に関しては課金されます。";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "Roblox Premiumに入会すると毎月Robuxが支給され、さらにRobuxを購入した際に10%のボーナスをゲットします。また、すべてのゲーム内での収入アップだけでなく、購入、販売、アイテムの交換など、Robloxの経済機能にアクセスすることができます。";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "アイテムを再販売したり、作品を売ってRobuxをさらにゲット";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "他のPremiumメンバーとアイテムを取引する";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robuxを買う";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "キャンセルの確認";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "さらに多くの機能";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "エラー";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "Premiumユーザーとして、Robuxで割引きをもらえます！";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "サーバーエラー";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "サブスクリプションは利用できません";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "サブスクリプションの更新を確認";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "Builders Clubが見つかりませんでした";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "Roblox Premiumにアップグレード";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "アップグレードできません";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "Robuxをさらに10%ゲットします";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "さらにゲット！";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "サブスクリプションしているため！";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "一度買う";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "Robuxを買う";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "確定";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "現在のプラン";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "Robuxを10%オフでゲット";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "さらにRobuxをゲットする";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "Premiumサブスクリプションを管理するには、ブラウザを使って請求設定へ行ってください。";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"現在のプランは {premiumSubscription} です。契約は {expirationDate} 日に終了します。";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "現在のプランは {premiumSubscription} です。契約は {expirationDate} 日に終了します。";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"あなたの現在のプランは {premiumSubscription} です。{expirationDate} に終了します。メンバーシップの終了後は、再購入するか、新しいプランに申し込むことができます。 ";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "あなたの現在のプランは {premiumSubscription} です。{expirationDate} に終了します。メンバーシップの終了後は、再購入するか、新しいプランに申し込むことができます。 ";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"現在のプランは {premiumSubscription} です。契約は {renewal} 日に更新します。";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "現在のプランは {premiumSubscription} です。契約は {renewal} 日に更新します。";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "いいえ";
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
		return $"{robux}{subTextStart}/月{subTextEnd}";
	}

	protected override string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart}/月{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public override string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount}/月";
	}

	protected override string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount}/月";
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
		return "Roblox Premium 1000 一ヶ月";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 一ヶ月";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 一ヶ月";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "もっと売る";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "サブスクリプションしたため";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "サブスクリプション契約する";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"サブスクリプション契約して {upsellLinkStart}もっとゲットしよう！{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "サブスクリプション契約して {upsellLinkStart}もっとゲットしよう！{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "取引";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "バリューパック";
	}

	protected override string _GetTemplateForLabelWantMoreRobux()
	{
		return "Robuxがもっと必要ですか？";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "はい";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public override string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"「確定」をクリックすると、Builders Clubメンバーシップから脱退して、Roblox Premiumの申し込みが可能になります。{newLine} 1度だけ {robuxAmount} のペイアウトを受けることができます";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "「確定」をクリックすると、Builders Clubメンバーシップから脱退して、Roblox Premiumの申し込みが可能になります。{newLine} 1度だけ {robuxAmount} のペイアウトを受けることができます";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "サブスクリプションのアップデート中にエラーが発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "サブスクリプション情報はありません。";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "サブスクリプションのアップデート中にサーバーエラーが発生しました。後でもう一度お試しください。";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"申し訳ありませんが、キャンセルした現在のプランの期限が切れるまでは、サブスクリプションを行うことができません。{expiredDate}にもう一度申し込みしてください。";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "申し訳ありませんが、キャンセルした現在のプランの期限が切れるまでは、サブスクリプションを行うことができません。{expiredDate}にもう一度申し込みしてください。";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"「確定」をクリックすると、{renewalDate} からキャンセルまたはサブスクリプション切り替えを行うまで、毎月 {price} の課金に同意したものとみなします。";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "「確定」をクリックすると、{renewalDate} からキャンセルまたはサブスクリプション切り替えを行うまで、毎月 {price} の課金に同意したものとみなします。";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "このユーザーのBuilders Club情報が見つかりません";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "申し訳ありませんが、現在、永久Builders Clubと同等のパッケージがないため、サブスクリプションの変更はできません。";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "サブスクリプションの更新を確認";
	}
}
