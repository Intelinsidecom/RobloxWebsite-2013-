namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumResources_zh_cn : PremiumResources_en_us, IPremiumResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Bought"
	/// English String: "Bought"
	/// </summary>
	public override string ActionBought => "已购";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "立即购买！";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "购买 Robux";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "购买 Robux 时获得额外 10%";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "加入 Roblox Premium 让你每个月获得 Robux 津贴，且购买 Robux 时还可获得额外 10%。你还能享受 Roblox 的交易功能，包括购买、出售及交易物品，并可增加游戏中所有销售的收益比例。";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "转售物品及出售你的作品，以获得更多 Robux";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "与其他 Premium 会员交易物品";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "购买 Robux";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "确认取消方案";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "更多专属功能";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "错误";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "成为 Premium 用户即可享有 Robux 折扣！";

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
	public override string HeadingServerError => "服务器错误";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "无法订阅";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "确认订阅更新";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "找不到 Builders Club";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "升级至 Roblox Premium";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "无法升级";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "你将获得额外 10% 的 Robux";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "获得更多！";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "订阅后优惠价格";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "单次购买";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "购买 Robux";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "确认";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "你的当前方案";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "取得 Robux 10% 折扣";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "获得更多 Robux";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "若要管理 Premium 订阅，请在浏览器中前往账单设置。";

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
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 一个月";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 一个月";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 一个月";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "出售更多";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "你已订阅";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "订阅";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "交易";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "超值套装";

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
	public override string MessageGeneralError => "更新你的订阅时发生错误。请稍后重试。";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "无订阅信息。";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "更新你的订阅时服务器发生错误。请稍后重试。";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "无法找到此用户的 Builders Club 信息。";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "很抱歉，目前没有相当于终身 Builders Club 的套装，因此我们无法更改你的订阅。";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "确认订阅更新";

	public PremiumResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "已购";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "立即购买！";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "购买 Robux";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"购买 Robux，以升级你的虚拟形象或获得游戏中的特殊技能。{lineBreak}订阅 Roblox Premium，每月获得更多 Robux 及更多额外福利。在取消前，Roblox Premium 将采取每月计费。在{learnMoreLinkStart}这里{learnMoreLinkEnd}了解更多信息。";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "购买 Robux，以升级你的虚拟形象或获得游戏中的特殊技能。{lineBreak}订阅 Roblox Premium，每月获得更多 Robux 及更多额外福利。在取消前，Roblox Premium 将采取每月计费。在{learnMoreLinkStart}这里{learnMoreLinkEnd}了解更多信息。";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"获得 Robux，购买你虚拟形象的升级物品或游戏中的特殊技能。如需有关如何赚取 Robux 的更多信息，请访问我们的{helpLinkStart} Robux 帮助页面{helpLinkEnd}。{paragraphBreaker}购买 Roblox Premium 就能以相同价格获得更多的 Robux。在取消前，Roblox Premium 将采取每月计费。在{learnMoreLinkStart}这里{learnMoreLinkEnd}了解更多信息。";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "获得 Robux，购买你虚拟形象的升级物品或游戏中的特殊技能。如需有关如何赚取 Robux 的更多信息，请访问我们的{helpLinkStart} Robux 帮助页面{helpLinkEnd}。{paragraphBreaker}购买 Roblox Premium 就能以相同价格获得更多的 Robux。在取消前，Roblox Premium 将采取每月计费。在{learnMoreLinkStart}这里{learnMoreLinkEnd}了解更多信息。";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "购买 Robux 时获得额外 10%";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premium 是每个月费用为 {costPrice} 的订阅制度。完成购买时，我们会向您的 iTunes 帐户收取费用。Roblox Premium 为每月自动续订，但如果您目前的订阅期还剩下超过 24 小时，您可以关闭自动续订选项。在您当前订阅期结束前的 24 小时内，我们将会向您的帐户收取 {renewalPrice}。您可以在帐户设置页面管理订阅与自动续订选项。如果您未满 18 岁，在购买前请先征得父母或法定监护人的同意。如果在未获同意的情况下进行购买，可能会导致您的帐户被删除。";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium 是每个月费用为 {costPrice} 的订阅制度。完成购买时，我们会向您的 iTunes 帐户收取费用。Roblox Premium 为每月自动续订，但如果您目前的订阅期还剩下超过 24 小时，您可以关闭自动续订选项。在您当前订阅期结束前的 24 小时内，我们将会向您的帐户收取 {renewalPrice}。您可以在帐户设置页面管理订阅与自动续订选项。如果您未满 18 岁，在购买前请先征得父母或法定监护人的同意。如果在未获同意的情况下进行购买，可能会导致您的帐户被删除。";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"购买 Robux 时，您只会收到有使用限制、不可退款、不可转让且可撤销的 Robux 使用许可，并没有真实货币的价值。如欲了解其他限制事项的信息，请参阅{termsLinkStart}使用条款{termsLinkEnd}。如果您未满 18 岁，在购买前请先征得父母或法定监护人的同意。如果在未获同意的情况下进行购买，可能会导致您的帐户被删除。";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "购买 Robux 时，您只会收到有使用限制、不可退款、不可转让且可撤销的 Robux 使用许可，并没有真实货币的价值。如欲了解其他限制事项的信息，请参阅{termsLinkStart}使用条款{termsLinkEnd}。如果您未满 18 岁，在购买前请先征得父母或法定监护人的同意。如果在未获同意的情况下进行购买，可能会导致您的帐户被删除。";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"如果您未满 18 岁，在购买前请先征得父母或法定监护人的同意。如果在未获同意的情况下进行购买，可能会导致您的帐户被删除。点按“提交订单”（1）即代表您授权我们每月向您收取费用，直到您取消为止，并（2）代表您了解且同意{termsLinkStart}使用条款{termsLinkEnd}与{privacyLinkStart}隐私政策{privatyLinkEnd}。您随时可以在设置页面的{billingLinkStart}账单{billingLinkEnd}标签中点按“取消会员资格”来取消。取消后，我们仍会向您收取当期账单的费用。";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "如果您未满 18 岁，在购买前请先征得父母或法定监护人的同意。如果在未获同意的情况下进行购买，可能会导致您的帐户被删除。点按“提交订单”（1）即代表您授权我们每月向您收取费用，直到您取消为止，并（2）代表您了解且同意{termsLinkStart}使用条款{termsLinkEnd}与{privacyLinkStart}隐私政策{privatyLinkEnd}。您随时可以在设置页面的{billingLinkStart}账单{billingLinkEnd}标签中点按“取消会员资格”来取消。取消后，我们仍会向您收取当期账单的费用。";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"如果您未满 18 岁，在购买前请先征得父母或法定监护人的同意。如果在未获同意的情况下进行购买，可能会导致您的帐户被删除。点按“提交订单”（1）即代表您授权我们每月向您收取费用，直到您取消为止，并（2）代表您了解且同意{teamOfUseLinkStart}使用条款{teamOfUseLinkEnd}与{privacyPolicyLinkStart}隐私政策{privacyPolicyLinkEnd}。您随时可以在设置页面的{billingTabLinkStart}账单{billingTabLinkEnd}标签中点按“取消会员资格”来取消。取消后，我们仍会向您收取当期账单的费用。";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "如果您未满 18 岁，在购买前请先征得父母或法定监护人的同意。如果在未获同意的情况下进行购买，可能会导致您的帐户被删除。点按“提交订单”（1）即代表您授权我们每月向您收取费用，直到您取消为止，并（2）代表您了解且同意{teamOfUseLinkStart}使用条款{teamOfUseLinkEnd}与{privacyPolicyLinkStart}隐私政策{privacyPolicyLinkEnd}。您随时可以在设置页面的{billingTabLinkStart}账单{billingTabLinkEnd}标签中点按“取消会员资格”来取消。取消后，我们仍会向您收取当期账单的费用。";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "加入 Roblox Premium 让你每个月获得 Robux 津贴，且购买 Robux 时还可获得额外 10%。你还能享受 Roblox 的交易功能，包括购买、出售及交易物品，并可增加游戏中所有销售的收益比例。";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "转售物品及出售你的作品，以获得更多 Robux";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "与其他 Premium 会员交易物品";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "购买 Robux";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "确认取消方案";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "更多专属功能";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "错误";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "成为 Premium 用户即可享有 Robux 折扣！";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "服务器错误";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "无法订阅";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "确认订阅更新";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "找不到 Builders Club";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "升级至 Roblox Premium";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "无法升级";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "你将获得额外 10% 的 Robux";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "获得更多！";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "订阅后优惠价格";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "单次购买";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "购买 Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "确认";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "你的当前方案";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "取得 Robux 10% 折扣";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "获得更多 Robux";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "若要管理 Premium 订阅，请在浏览器中前往账单设置。";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"你当前的订阅计划为 {premiumSubscription}，将于 {expirationDate} 到期。";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "你当前的订阅计划为 {premiumSubscription}，将于 {expirationDate} 到期。";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"你的当前方案为 {premiumSubscription}，将于 {expirationDate} 过期。会员资格过期后，你可以重新购买当前方案，或购买新方案。";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "你的当前方案为 {premiumSubscription}，将于 {expirationDate} 过期。会员资格过期后，你可以重新购买当前方案，或购买新方案。";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"你当前的订阅计划为 {premiumSubscription}，将于 {renewal} 更新。";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "你当前的订阅计划为 {premiumSubscription}，将于 {renewal} 更新。";
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
		return "Roblox Premium 1000 一个月";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 一个月";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 一个月";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "出售更多";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "你已订阅";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "订阅";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"订阅 {upsellLinkStart} 以获取更多内容！{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "订阅 {upsellLinkStart} 以获取更多内容！{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "交易";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "超值套装";
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
		return $"点按“确认”，将结束你的 Builders Club 会员资格，以便你订阅 Roblox Premium。{newLine}你将会收到一次性支付的{robuxAmount}";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "点按“确认”，将结束你的 Builders Club 会员资格，以便你订阅 Roblox Premium。{newLine}你将会收到一次性支付的{robuxAmount}";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "更新你的订阅时发生错误。请稍后重试。";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "无订阅信息。";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "更新你的订阅时服务器发生错误。请稍后重试。";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"很抱歉，在你目前已取消的方案过期之前，你无法订阅。请于 {expiredDate} 重新订阅。";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "很抱歉，在你目前已取消的方案过期之前，你无法订阅。请于 {expiredDate} 重新订阅。";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"点按“确认“，即代表你授权我们每月向你收取 {price}， 直到你取消，或至 {renewalDate} 切换订阅生效为止。";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "点按“确认“，即代表你授权我们每月向你收取 {price}， 直到你取消，或至 {renewalDate} 切换订阅生效为止。";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "无法找到此用户的 Builders Club 信息。";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "很抱歉，目前没有相当于终身 Builders Club 的套装，因此我们无法更改你的订阅。";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "确认订阅更新";
	}
}
