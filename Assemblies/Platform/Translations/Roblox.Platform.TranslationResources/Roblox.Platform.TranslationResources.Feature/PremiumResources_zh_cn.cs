namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionBought => "å·²è´­";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "ç«‹å³è´­ä¹°ï¼";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "è´­ä¹° Robux";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "è´­ä¹° Robux æ—¶èŽ·å¾—é¢å¤– 10%";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "åŠ å…¥ Roblox Premium è®©ä½ æ¯ä¸ªæœˆèŽ·å¾— Robux æ´¥è´´ï¼Œä¸”è´­ä¹° Robux æ—¶è¿˜å¯èŽ·å¾—é¢å¤– 10%ã€‚ä½ è¿˜èƒ½äº«å— Roblox çš„äº¤æ˜“åŠŸèƒ½ï¼ŒåŒ…æ‹¬è´­ä¹°ã€å‡ºå”®åŠäº¤æ˜“ç‰©å“ï¼Œå¹¶å¯å¢žåŠ æ¸¸æˆä¸­æ‰€æœ‰é”€å”®çš„æ”¶ç›Šæ¯”ä¾‹ã€‚";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "è½¬å”®ç‰©å“åŠå‡ºå”®ä½ çš„ä½œå“ï¼Œä»¥èŽ·å¾—æ›´å¤š Robux";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "ä¸Žå…¶ä»– Premium ä¼šå‘˜äº¤æ˜“ç‰©å“";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "è´­ä¹° Robux";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "ç¡®è®¤å–æ¶ˆæ–¹æ¡ˆ";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "æ›´å¤šä¸“å±žåŠŸèƒ½";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "é”™è¯¯";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "æˆä¸º Premium ç”¨æˆ·å³å¯äº«æœ‰ Robux æŠ˜æ‰£ï¼";

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
	public override string HeadingServerError => "æœåŠ¡å™¨é”™è¯¯";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "æ— æ³•è®¢é˜…";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "ç¡®è®¤è®¢é˜…æ›´æ–°";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "æ‰¾ä¸åˆ° Builders Club";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "å‡çº§è‡³ Roblox Premium";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "æ— æ³•å‡çº§";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "ä½ å°†èŽ·å¾—é¢å¤– 10% çš„ Robux";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "èŽ·å¾—æ›´å¤šï¼";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "è®¢é˜…åŽä¼˜æƒ ä»·æ ¼";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "å•æ¬¡è´­ä¹°";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "è´­ä¹° Robux";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "ç¡®è®¤";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "ä½ çš„å½“å‰æ–¹æ¡ˆ";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "å–å¾— Robux 10% æŠ˜æ‰£";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "èŽ·å¾—æ›´å¤š Robux";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "è‹¥è¦ç®¡ç† Premium è®¢é˜…ï¼Œè¯·åœ¨æµè§ˆå™¨ä¸­å‰å¾€è´¦å•è®¾ç½®ã€‚";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "å¦";

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
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 ä¸€ä¸ªæœˆ";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 ä¸€ä¸ªæœˆ";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 ä¸€ä¸ªæœˆ";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "å‡ºå”®æ›´å¤š";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "ä½ å·²è®¢é˜…";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "è®¢é˜…";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "äº¤æ˜“";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "è¶…å€¼å¥—è£…";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public override string LabelWantMoreRobux => "æƒ³è¦æ›´å¤š Robuxï¼Ÿ";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "æ˜¯";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageGeneralError => "æ›´æ–°ä½ çš„è®¢é˜…æ—¶å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "æ— è®¢é˜…ä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "æ›´æ–°ä½ çš„è®¢é˜…æ—¶æœåŠ¡å™¨å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "æ— æ³•æ‰¾åˆ°æ­¤ç”¨æˆ·çš„ Builders Club ä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "å¾ˆæŠ±æ­‰ï¼Œç›®å‰æ²¡æœ‰ç›¸å½“äºŽç»ˆèº« Builders Club çš„å¥—è£…ï¼Œå› æ­¤æˆ‘ä»¬æ— æ³•æ›´æ”¹ä½ çš„è®¢é˜…ã€‚";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "ç¡®è®¤è®¢é˜…æ›´æ–°";

	public PremiumResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "å·²è´­";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "ç«‹å³è´­ä¹°ï¼";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "è´­ä¹° Robux";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"è´­ä¹° Robuxï¼Œä»¥å‡çº§ä½ çš„è™šæ‹Ÿå½¢è±¡æˆ–èŽ·å¾—æ¸¸æˆä¸­çš„ç‰¹æ®ŠæŠ€èƒ½ã€‚{lineBreak}è®¢é˜… Roblox Premiumï¼Œæ¯æœˆèŽ·å¾—æ›´å¤š Robux åŠæ›´å¤šé¢å¤–ç¦åˆ©ã€‚åœ¨å–æ¶ˆå‰ï¼ŒRoblox Premium å°†é‡‡å–æ¯æœˆè®¡è´¹ã€‚åœ¨{learnMoreLinkStart}è¿™é‡Œ{learnMoreLinkEnd}äº†è§£æ›´å¤šä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "è´­ä¹° Robuxï¼Œä»¥å‡çº§ä½ çš„è™šæ‹Ÿå½¢è±¡æˆ–èŽ·å¾—æ¸¸æˆä¸­çš„ç‰¹æ®ŠæŠ€èƒ½ã€‚{lineBreak}è®¢é˜… Roblox Premiumï¼Œæ¯æœˆèŽ·å¾—æ›´å¤š Robux åŠæ›´å¤šé¢å¤–ç¦åˆ©ã€‚åœ¨å–æ¶ˆå‰ï¼ŒRoblox Premium å°†é‡‡å–æ¯æœˆè®¡è´¹ã€‚åœ¨{learnMoreLinkStart}è¿™é‡Œ{learnMoreLinkEnd}äº†è§£æ›´å¤šä¿¡æ¯ã€‚";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"èŽ·å¾— Robuxï¼Œè´­ä¹°ä½ è™šæ‹Ÿå½¢è±¡çš„å‡çº§ç‰©å“æˆ–æ¸¸æˆä¸­çš„ç‰¹æ®ŠæŠ€èƒ½ã€‚å¦‚éœ€æœ‰å…³å¦‚ä½•èµšå– Robux çš„æ›´å¤šä¿¡æ¯ï¼Œè¯·è®¿é—®æˆ‘ä»¬çš„{helpLinkStart} Robux å¸®åŠ©é¡µé¢{helpLinkEnd}ã€‚{paragraphBreaker}è´­ä¹° Roblox Premium å°±èƒ½ä»¥ç›¸åŒä»·æ ¼èŽ·å¾—æ›´å¤šçš„ Robuxã€‚åœ¨å–æ¶ˆå‰ï¼ŒRoblox Premium å°†é‡‡å–æ¯æœˆè®¡è´¹ã€‚åœ¨{learnMoreLinkStart}è¿™é‡Œ{learnMoreLinkEnd}äº†è§£æ›´å¤šä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "èŽ·å¾— Robuxï¼Œè´­ä¹°ä½ è™šæ‹Ÿå½¢è±¡çš„å‡çº§ç‰©å“æˆ–æ¸¸æˆä¸­çš„ç‰¹æ®ŠæŠ€èƒ½ã€‚å¦‚éœ€æœ‰å…³å¦‚ä½•èµšå– Robux çš„æ›´å¤šä¿¡æ¯ï¼Œè¯·è®¿é—®æˆ‘ä»¬çš„{helpLinkStart} Robux å¸®åŠ©é¡µé¢{helpLinkEnd}ã€‚{paragraphBreaker}è´­ä¹° Roblox Premium å°±èƒ½ä»¥ç›¸åŒä»·æ ¼èŽ·å¾—æ›´å¤šçš„ Robuxã€‚åœ¨å–æ¶ˆå‰ï¼ŒRoblox Premium å°†é‡‡å–æ¯æœˆè®¡è´¹ã€‚åœ¨{learnMoreLinkStart}è¿™é‡Œ{learnMoreLinkEnd}äº†è§£æ›´å¤šä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "è´­ä¹° Robux æ—¶èŽ·å¾—é¢å¤– 10%";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premium æ˜¯æ¯ä¸ªæœˆè´¹ç”¨ä¸º {costPrice} çš„è®¢é˜…åˆ¶åº¦ã€‚å®Œæˆè´­ä¹°æ—¶ï¼Œæˆ‘ä»¬ä¼šå‘æ‚¨çš„ iTunes å¸æˆ·æ”¶å–è´¹ç”¨ã€‚Roblox Premium ä¸ºæ¯æœˆè‡ªåŠ¨ç»­è®¢ï¼Œä½†å¦‚æžœæ‚¨ç›®å‰çš„è®¢é˜…æœŸè¿˜å‰©ä¸‹è¶…è¿‡ 24 å°æ—¶ï¼Œæ‚¨å¯ä»¥å…³é—­è‡ªåŠ¨ç»­è®¢é€‰é¡¹ã€‚åœ¨æ‚¨å½“å‰è®¢é˜…æœŸç»“æŸå‰çš„ 24 å°æ—¶å†…ï¼Œæˆ‘ä»¬å°†ä¼šå‘æ‚¨çš„å¸æˆ·æ”¶å– {renewalPrice}ã€‚æ‚¨å¯ä»¥åœ¨å¸æˆ·è®¾ç½®é¡µé¢ç®¡ç†è®¢é˜…ä¸Žè‡ªåŠ¨ç»­è®¢é€‰é¡¹ã€‚å¦‚æžœæ‚¨æœªæ»¡ 18 å²ï¼Œåœ¨è´­ä¹°å‰è¯·å…ˆå¾å¾—çˆ¶æ¯æˆ–æ³•å®šç›‘æŠ¤äººçš„åŒæ„ã€‚å¦‚æžœåœ¨æœªèŽ·åŒæ„çš„æƒ…å†µä¸‹è¿›è¡Œè´­ä¹°ï¼Œå¯èƒ½ä¼šå¯¼è‡´æ‚¨çš„å¸æˆ·è¢«åˆ é™¤ã€‚";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium æ˜¯æ¯ä¸ªæœˆè´¹ç”¨ä¸º {costPrice} çš„è®¢é˜…åˆ¶åº¦ã€‚å®Œæˆè´­ä¹°æ—¶ï¼Œæˆ‘ä»¬ä¼šå‘æ‚¨çš„ iTunes å¸æˆ·æ”¶å–è´¹ç”¨ã€‚Roblox Premium ä¸ºæ¯æœˆè‡ªåŠ¨ç»­è®¢ï¼Œä½†å¦‚æžœæ‚¨ç›®å‰çš„è®¢é˜…æœŸè¿˜å‰©ä¸‹è¶…è¿‡ 24 å°æ—¶ï¼Œæ‚¨å¯ä»¥å…³é—­è‡ªåŠ¨ç»­è®¢é€‰é¡¹ã€‚åœ¨æ‚¨å½“å‰è®¢é˜…æœŸç»“æŸå‰çš„ 24 å°æ—¶å†…ï¼Œæˆ‘ä»¬å°†ä¼šå‘æ‚¨çš„å¸æˆ·æ”¶å– {renewalPrice}ã€‚æ‚¨å¯ä»¥åœ¨å¸æˆ·è®¾ç½®é¡µé¢ç®¡ç†è®¢é˜…ä¸Žè‡ªåŠ¨ç»­è®¢é€‰é¡¹ã€‚å¦‚æžœæ‚¨æœªæ»¡ 18 å²ï¼Œåœ¨è´­ä¹°å‰è¯·å…ˆå¾å¾—çˆ¶æ¯æˆ–æ³•å®šç›‘æŠ¤äººçš„åŒæ„ã€‚å¦‚æžœåœ¨æœªèŽ·åŒæ„çš„æƒ…å†µä¸‹è¿›è¡Œè´­ä¹°ï¼Œå¯èƒ½ä¼šå¯¼è‡´æ‚¨çš„å¸æˆ·è¢«åˆ é™¤ã€‚";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"è´­ä¹° Robux æ—¶ï¼Œæ‚¨åªä¼šæ”¶åˆ°æœ‰ä½¿ç”¨é™åˆ¶ã€ä¸å¯é€€æ¬¾ã€ä¸å¯è½¬è®©ä¸”å¯æ’¤é”€çš„ Robux ä½¿ç”¨è®¸å¯ï¼Œå¹¶æ²¡æœ‰çœŸå®žè´§å¸çš„ä»·å€¼ã€‚å¦‚æ¬²äº†è§£å…¶ä»–é™åˆ¶äº‹é¡¹çš„ä¿¡æ¯ï¼Œè¯·å‚é˜…{termsLinkStart}ä½¿ç”¨æ¡æ¬¾{termsLinkEnd}ã€‚å¦‚æžœæ‚¨æœªæ»¡ 18 å²ï¼Œåœ¨è´­ä¹°å‰è¯·å…ˆå¾å¾—çˆ¶æ¯æˆ–æ³•å®šç›‘æŠ¤äººçš„åŒæ„ã€‚å¦‚æžœåœ¨æœªèŽ·åŒæ„çš„æƒ…å†µä¸‹è¿›è¡Œè´­ä¹°ï¼Œå¯èƒ½ä¼šå¯¼è‡´æ‚¨çš„å¸æˆ·è¢«åˆ é™¤ã€‚";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "è´­ä¹° Robux æ—¶ï¼Œæ‚¨åªä¼šæ”¶åˆ°æœ‰ä½¿ç”¨é™åˆ¶ã€ä¸å¯é€€æ¬¾ã€ä¸å¯è½¬è®©ä¸”å¯æ’¤é”€çš„ Robux ä½¿ç”¨è®¸å¯ï¼Œå¹¶æ²¡æœ‰çœŸå®žè´§å¸çš„ä»·å€¼ã€‚å¦‚æ¬²äº†è§£å…¶ä»–é™åˆ¶äº‹é¡¹çš„ä¿¡æ¯ï¼Œè¯·å‚é˜…{termsLinkStart}ä½¿ç”¨æ¡æ¬¾{termsLinkEnd}ã€‚å¦‚æžœæ‚¨æœªæ»¡ 18 å²ï¼Œåœ¨è´­ä¹°å‰è¯·å…ˆå¾å¾—çˆ¶æ¯æˆ–æ³•å®šç›‘æŠ¤äººçš„åŒæ„ã€‚å¦‚æžœåœ¨æœªèŽ·åŒæ„çš„æƒ…å†µä¸‹è¿›è¡Œè´­ä¹°ï¼Œå¯èƒ½ä¼šå¯¼è‡´æ‚¨çš„å¸æˆ·è¢«åˆ é™¤ã€‚";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking â€œSubmit Orderâ€ (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking â€œCancel membershipâ€ on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"å¦‚æžœæ‚¨æœªæ»¡ 18 å²ï¼Œåœ¨è´­ä¹°å‰è¯·å…ˆå¾å¾—çˆ¶æ¯æˆ–æ³•å®šç›‘æŠ¤äººçš„åŒæ„ã€‚å¦‚æžœåœ¨æœªèŽ·åŒæ„çš„æƒ…å†µä¸‹è¿›è¡Œè´­ä¹°ï¼Œå¯èƒ½ä¼šå¯¼è‡´æ‚¨çš„å¸æˆ·è¢«åˆ é™¤ã€‚ç‚¹æŒ‰â€œæäº¤è®¢å•â€ï¼ˆ1ï¼‰å³ä»£è¡¨æ‚¨æŽˆæƒæˆ‘ä»¬æ¯æœˆå‘æ‚¨æ”¶å–è´¹ç”¨ï¼Œç›´åˆ°æ‚¨å–æ¶ˆä¸ºæ­¢ï¼Œå¹¶ï¼ˆ2ï¼‰ä»£è¡¨æ‚¨äº†è§£ä¸”åŒæ„{termsLinkStart}ä½¿ç”¨æ¡æ¬¾{termsLinkEnd}ä¸Ž{privacyLinkStart}éšç§æ”¿ç­–{privatyLinkEnd}ã€‚æ‚¨éšæ—¶å¯ä»¥åœ¨è®¾ç½®é¡µé¢çš„{billingLinkStart}è´¦å•{billingLinkEnd}æ ‡ç­¾ä¸­ç‚¹æŒ‰â€œå–æ¶ˆä¼šå‘˜èµ„æ ¼â€æ¥å–æ¶ˆã€‚å–æ¶ˆåŽï¼Œæˆ‘ä»¬ä»ä¼šå‘æ‚¨æ”¶å–å½“æœŸè´¦å•çš„è´¹ç”¨ã€‚";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "å¦‚æžœæ‚¨æœªæ»¡ 18 å²ï¼Œåœ¨è´­ä¹°å‰è¯·å…ˆå¾å¾—çˆ¶æ¯æˆ–æ³•å®šç›‘æŠ¤äººçš„åŒæ„ã€‚å¦‚æžœåœ¨æœªèŽ·åŒæ„çš„æƒ…å†µä¸‹è¿›è¡Œè´­ä¹°ï¼Œå¯èƒ½ä¼šå¯¼è‡´æ‚¨çš„å¸æˆ·è¢«åˆ é™¤ã€‚ç‚¹æŒ‰â€œæäº¤è®¢å•â€ï¼ˆ1ï¼‰å³ä»£è¡¨æ‚¨æŽˆæƒæˆ‘ä»¬æ¯æœˆå‘æ‚¨æ”¶å–è´¹ç”¨ï¼Œç›´åˆ°æ‚¨å–æ¶ˆä¸ºæ­¢ï¼Œå¹¶ï¼ˆ2ï¼‰ä»£è¡¨æ‚¨äº†è§£ä¸”åŒæ„{termsLinkStart}ä½¿ç”¨æ¡æ¬¾{termsLinkEnd}ä¸Ž{privacyLinkStart}éšç§æ”¿ç­–{privatyLinkEnd}ã€‚æ‚¨éšæ—¶å¯ä»¥åœ¨è®¾ç½®é¡µé¢çš„{billingLinkStart}è´¦å•{billingLinkEnd}æ ‡ç­¾ä¸­ç‚¹æŒ‰â€œå–æ¶ˆä¼šå‘˜èµ„æ ¼â€æ¥å–æ¶ˆã€‚å–æ¶ˆåŽï¼Œæˆ‘ä»¬ä»ä¼šå‘æ‚¨æ”¶å–å½“æœŸè´¦å•çš„è´¹ç”¨ã€‚";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking â€œSubmit Orderâ€ (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking â€œCancel membershipâ€ on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"å¦‚æžœæ‚¨æœªæ»¡ 18 å²ï¼Œåœ¨è´­ä¹°å‰è¯·å…ˆå¾å¾—çˆ¶æ¯æˆ–æ³•å®šç›‘æŠ¤äººçš„åŒæ„ã€‚å¦‚æžœåœ¨æœªèŽ·åŒæ„çš„æƒ…å†µä¸‹è¿›è¡Œè´­ä¹°ï¼Œå¯èƒ½ä¼šå¯¼è‡´æ‚¨çš„å¸æˆ·è¢«åˆ é™¤ã€‚ç‚¹æŒ‰â€œæäº¤è®¢å•â€ï¼ˆ1ï¼‰å³ä»£è¡¨æ‚¨æŽˆæƒæˆ‘ä»¬æ¯æœˆå‘æ‚¨æ”¶å–è´¹ç”¨ï¼Œç›´åˆ°æ‚¨å–æ¶ˆä¸ºæ­¢ï¼Œå¹¶ï¼ˆ2ï¼‰ä»£è¡¨æ‚¨äº†è§£ä¸”åŒæ„{teamOfUseLinkStart}ä½¿ç”¨æ¡æ¬¾{teamOfUseLinkEnd}ä¸Ž{privacyPolicyLinkStart}éšç§æ”¿ç­–{privacyPolicyLinkEnd}ã€‚æ‚¨éšæ—¶å¯ä»¥åœ¨è®¾ç½®é¡µé¢çš„{billingTabLinkStart}è´¦å•{billingTabLinkEnd}æ ‡ç­¾ä¸­ç‚¹æŒ‰â€œå–æ¶ˆä¼šå‘˜èµ„æ ¼â€æ¥å–æ¶ˆã€‚å–æ¶ˆåŽï¼Œæˆ‘ä»¬ä»ä¼šå‘æ‚¨æ”¶å–å½“æœŸè´¦å•çš„è´¹ç”¨ã€‚";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "å¦‚æžœæ‚¨æœªæ»¡ 18 å²ï¼Œåœ¨è´­ä¹°å‰è¯·å…ˆå¾å¾—çˆ¶æ¯æˆ–æ³•å®šç›‘æŠ¤äººçš„åŒæ„ã€‚å¦‚æžœåœ¨æœªèŽ·åŒæ„çš„æƒ…å†µä¸‹è¿›è¡Œè´­ä¹°ï¼Œå¯èƒ½ä¼šå¯¼è‡´æ‚¨çš„å¸æˆ·è¢«åˆ é™¤ã€‚ç‚¹æŒ‰â€œæäº¤è®¢å•â€ï¼ˆ1ï¼‰å³ä»£è¡¨æ‚¨æŽˆæƒæˆ‘ä»¬æ¯æœˆå‘æ‚¨æ”¶å–è´¹ç”¨ï¼Œç›´åˆ°æ‚¨å–æ¶ˆä¸ºæ­¢ï¼Œå¹¶ï¼ˆ2ï¼‰ä»£è¡¨æ‚¨äº†è§£ä¸”åŒæ„{teamOfUseLinkStart}ä½¿ç”¨æ¡æ¬¾{teamOfUseLinkEnd}ä¸Ž{privacyPolicyLinkStart}éšç§æ”¿ç­–{privacyPolicyLinkEnd}ã€‚æ‚¨éšæ—¶å¯ä»¥åœ¨è®¾ç½®é¡µé¢çš„{billingTabLinkStart}è´¦å•{billingTabLinkEnd}æ ‡ç­¾ä¸­ç‚¹æŒ‰â€œå–æ¶ˆä¼šå‘˜èµ„æ ¼â€æ¥å–æ¶ˆã€‚å–æ¶ˆåŽï¼Œæˆ‘ä»¬ä»ä¼šå‘æ‚¨æ”¶å–å½“æœŸè´¦å•çš„è´¹ç”¨ã€‚";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "åŠ å…¥ Roblox Premium è®©ä½ æ¯ä¸ªæœˆèŽ·å¾— Robux æ´¥è´´ï¼Œä¸”è´­ä¹° Robux æ—¶è¿˜å¯èŽ·å¾—é¢å¤– 10%ã€‚ä½ è¿˜èƒ½äº«å— Roblox çš„äº¤æ˜“åŠŸèƒ½ï¼ŒåŒ…æ‹¬è´­ä¹°ã€å‡ºå”®åŠäº¤æ˜“ç‰©å“ï¼Œå¹¶å¯å¢žåŠ æ¸¸æˆä¸­æ‰€æœ‰é”€å”®çš„æ”¶ç›Šæ¯”ä¾‹ã€‚";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "è½¬å”®ç‰©å“åŠå‡ºå”®ä½ çš„ä½œå“ï¼Œä»¥èŽ·å¾—æ›´å¤š Robux";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "ä¸Žå…¶ä»– Premium ä¼šå‘˜äº¤æ˜“ç‰©å“";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "è´­ä¹° Robux";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "ç¡®è®¤å–æ¶ˆæ–¹æ¡ˆ";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "æ›´å¤šä¸“å±žåŠŸèƒ½";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "é”™è¯¯";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "æˆä¸º Premium ç”¨æˆ·å³å¯äº«æœ‰ Robux æŠ˜æ‰£ï¼";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "æœåŠ¡å™¨é”™è¯¯";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "æ— æ³•è®¢é˜…";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "ç¡®è®¤è®¢é˜…æ›´æ–°";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "æ‰¾ä¸åˆ° Builders Club";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "å‡çº§è‡³ Roblox Premium";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "æ— æ³•å‡çº§";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "ä½ å°†èŽ·å¾—é¢å¤– 10% çš„ Robux";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "èŽ·å¾—æ›´å¤šï¼";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "è®¢é˜…åŽä¼˜æƒ ä»·æ ¼";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "å•æ¬¡è´­ä¹°";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "è´­ä¹° Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "ç¡®è®¤";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "ä½ çš„å½“å‰æ–¹æ¡ˆ";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "å–å¾— Robux 10% æŠ˜æ‰£";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "èŽ·å¾—æ›´å¤š Robux";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "è‹¥è¦ç®¡ç† Premium è®¢é˜…ï¼Œè¯·åœ¨æµè§ˆå™¨ä¸­å‰å¾€è´¦å•è®¾ç½®ã€‚";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"ä½ å½“å‰çš„è®¢é˜…è®¡åˆ’ä¸º {premiumSubscription}ï¼Œå°†äºŽ {expirationDate} åˆ°æœŸã€‚";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "ä½ å½“å‰çš„è®¢é˜…è®¡åˆ’ä¸º {premiumSubscription}ï¼Œå°†äºŽ {expirationDate} åˆ°æœŸã€‚";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"ä½ çš„å½“å‰æ–¹æ¡ˆä¸º {premiumSubscription}ï¼Œå°†äºŽ {expirationDate} è¿‡æœŸã€‚ä¼šå‘˜èµ„æ ¼è¿‡æœŸåŽï¼Œä½ å¯ä»¥é‡æ–°è´­ä¹°å½“å‰æ–¹æ¡ˆï¼Œæˆ–è´­ä¹°æ–°æ–¹æ¡ˆã€‚";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "ä½ çš„å½“å‰æ–¹æ¡ˆä¸º {premiumSubscription}ï¼Œå°†äºŽ {expirationDate} è¿‡æœŸã€‚ä¼šå‘˜èµ„æ ¼è¿‡æœŸåŽï¼Œä½ å¯ä»¥é‡æ–°è´­ä¹°å½“å‰æ–¹æ¡ˆï¼Œæˆ–è´­ä¹°æ–°æ–¹æ¡ˆã€‚";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"ä½ å½“å‰çš„è®¢é˜…è®¡åˆ’ä¸º {premiumSubscription}ï¼Œå°†äºŽ {renewal} æ›´æ–°ã€‚";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "ä½ å½“å‰çš„è®¢é˜…è®¡åˆ’ä¸º {premiumSubscription}ï¼Œå°†äºŽ {renewal} æ›´æ–°ã€‚";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "å¦";
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
		return $"{robux}{subTextStart}/æœˆ{subTextEnd}";
	}

	protected override string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart}/æœˆ{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public override string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount}/æœˆ";
	}

	protected override string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount}/æœˆ";
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
		return "Roblox Premium 1000 ä¸€ä¸ªæœˆ";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 ä¸€ä¸ªæœˆ";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 ä¸€ä¸ªæœˆ";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "å‡ºå”®æ›´å¤š";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "ä½ å·²è®¢é˜…";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "è®¢é˜…";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"è®¢é˜… {upsellLinkStart} ä»¥èŽ·å–æ›´å¤šå†…å®¹ï¼{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "è®¢é˜… {upsellLinkStart} ä»¥èŽ·å–æ›´å¤šå†…å®¹ï¼{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "äº¤æ˜“";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "è¶…å€¼å¥—è£…";
	}

	protected override string _GetTemplateForLabelWantMoreRobux()
	{
		return "æƒ³è¦æ›´å¤š Robuxï¼Ÿ";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "æ˜¯";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public override string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"ç‚¹æŒ‰â€œç¡®è®¤â€ï¼Œå°†ç»“æŸä½ çš„ Builders Club ä¼šå‘˜èµ„æ ¼ï¼Œä»¥ä¾¿ä½ è®¢é˜… Roblox Premiumã€‚{newLine}ä½ å°†ä¼šæ”¶åˆ°ä¸€æ¬¡æ€§æ”¯ä»˜çš„{robuxAmount}";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "ç‚¹æŒ‰â€œç¡®è®¤â€ï¼Œå°†ç»“æŸä½ çš„ Builders Club ä¼šå‘˜èµ„æ ¼ï¼Œä»¥ä¾¿ä½ è®¢é˜… Roblox Premiumã€‚{newLine}ä½ å°†ä¼šæ”¶åˆ°ä¸€æ¬¡æ€§æ”¯ä»˜çš„{robuxAmount}";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "æ›´æ–°ä½ çš„è®¢é˜…æ—¶å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "æ— è®¢é˜…ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "æ›´æ–°ä½ çš„è®¢é˜…æ—¶æœåŠ¡å™¨å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"å¾ˆæŠ±æ­‰ï¼Œåœ¨ä½ ç›®å‰å·²å–æ¶ˆçš„æ–¹æ¡ˆè¿‡æœŸä¹‹å‰ï¼Œä½ æ— æ³•è®¢é˜…ã€‚è¯·äºŽ {expiredDate} é‡æ–°è®¢é˜…ã€‚";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "å¾ˆæŠ±æ­‰ï¼Œåœ¨ä½ ç›®å‰å·²å–æ¶ˆçš„æ–¹æ¡ˆè¿‡æœŸä¹‹å‰ï¼Œä½ æ— æ³•è®¢é˜…ã€‚è¯·äºŽ {expiredDate} é‡æ–°è®¢é˜…ã€‚";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"ç‚¹æŒ‰â€œç¡®è®¤â€œï¼Œå³ä»£è¡¨ä½ æŽˆæƒæˆ‘ä»¬æ¯æœˆå‘ä½ æ”¶å– {price}ï¼Œ ç›´åˆ°ä½ å–æ¶ˆï¼Œæˆ–è‡³ {renewalDate} åˆ‡æ¢è®¢é˜…ç”Ÿæ•ˆä¸ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "ç‚¹æŒ‰â€œç¡®è®¤â€œï¼Œå³ä»£è¡¨ä½ æŽˆæƒæˆ‘ä»¬æ¯æœˆå‘ä½ æ”¶å– {price}ï¼Œ ç›´åˆ°ä½ å–æ¶ˆï¼Œæˆ–è‡³ {renewalDate} åˆ‡æ¢è®¢é˜…ç”Ÿæ•ˆä¸ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "æ— æ³•æ‰¾åˆ°æ­¤ç”¨æˆ·çš„ Builders Club ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "å¾ˆæŠ±æ­‰ï¼Œç›®å‰æ²¡æœ‰ç›¸å½“äºŽç»ˆèº« Builders Club çš„å¥—è£…ï¼Œå› æ­¤æˆ‘ä»¬æ— æ³•æ›´æ”¹ä½ çš„è®¢é˜…ã€‚";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "ç¡®è®¤è®¢é˜…æ›´æ–°";
	}
}


}
