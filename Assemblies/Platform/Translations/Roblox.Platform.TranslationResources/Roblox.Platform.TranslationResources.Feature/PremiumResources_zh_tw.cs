namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionBought => "å·²è³¼è²·";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "ç¾åœ¨è³¼è²·ï¼";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "è³¼è²· Robux";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "è³¼è²· Robux æ™‚ç²å¾—é¡å¤– 10%";

	/// <summary>
	/// Key: "Description.GooglePlayMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that is charged to your Google Play account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Google Play account settings. If youâ€™re under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionGooglePlayMonthlySubscriptionDisclosure => "Roblox Premium æ˜¯æœˆè²»åˆ¶çš„è¨‚é–±åˆ¶åº¦ã€‚å®Œæˆè³¼è²·æ™‚ï¼Œæˆ‘å€‘æœƒå‘æ‚¨çš„ Google Play å¸³è™Ÿæ”¶è²»ã€‚Roblox Premium æœƒè‡ªå‹•çºŒè¨‚ï¼Œä½†è‹¥æ‚¨ç›®å‰çš„è¨‚é–±é‚„å‰©è¶…éŽ 24 å°æ™‚ï¼Œæ‚¨å¯ä»¥é—œé–‰è‡ªå‹•æ›´æ–°ã€‚åœ¨æ‚¨çš„è¨‚é–±çµæŸçš„å‰ 24 å°æ™‚ä»¥å…§ï¼Œæˆ‘å€‘å°‡æœƒå‘æ‚¨çš„å¸³è™Ÿæ”¶è²»ã€‚æ‚¨å¯ä»¥åœ¨ Google Play å¸³è™Ÿè¨­å®šé é¢ç®¡ç†è¨‚é–±èˆ‡è‡ªå‹•æ›´æ–°é¸é …ã€‚è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "åŠ å…¥ Roblox Premium ä¹‹å¾Œï¼Œæ‚¨å°‡å¯ä»¥æ¯å€‹æœˆé ˜å– Robuxï¼Œè³¼è²· Robux æ™‚ä¹Ÿå°‡ç²å¾— 10% çŽå‹µã€‚é™¤æ­¤ä¹‹å¤–ï¼Œæ‚¨é‚„èƒ½äº«ç”¨æ›´å¤š Roblox åŠŸèƒ½ï¼ŒåŒ…æ‹¬è³¼è²·ã€è²©è³£å’Œäº¤æ˜“é“å…·ï¼Œå’Œå¢žåŠ éŠæˆ²ä¸­è²·è³£æŠ½æˆã€‚";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "è½‰è³£é“å…·å’Œè²©è³£æ‚¨çš„ä½œå“ï¼Œç²å¾—æ›´å¤š Robux";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "èˆ‡å…¶ä»– Premium æœƒå“¡äº¤æ›é“å…·";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "è³¼è²· Robux";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "ç¢ºèªå–æ¶ˆ";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "æ›´å¤šåŠŸèƒ½";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "éŒ¯èª¤";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "æ‚¨ç‚º Premium ä½¿ç”¨è€…ï¼Œè³¼è²· Robux æ™‚å¯äº«æœ‰æŠ˜æ‰£ï¼";

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
	public override string HeadingServerError => "ä¼ºæœå™¨éŒ¯èª¤";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "ç„¡æ³•è¨‚é–±";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "ç¢ºèªè¨‚é–±æ›´æ–°";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "æ‰¾ä¸åˆ° Builders Club";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "å‡ç´šåˆ° Roblox Premium";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "ç„¡æ³•å‡ç´š";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "å› ç‚ºæ‚¨å·²è¨‚é–±ï¼Œ";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "å–å¾—æ›´å¤šï¼";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "è¨‚é–±å¾Œå„ªæƒ åƒ¹æ ¼";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "è³¼è²· 1 æ¬¡";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "è³¼è²· Robux";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "ç¢ºèª";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "æ‚¨ç›®å‰çš„æ–¹æ¡ˆ";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "ä»¥ 9 æŠ˜å„ªæƒ åƒ¹è³¼è²· Robux";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "å–å¾—æ›´å¤š Robux";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "è‹¥è¦ç®¡ç† Premium è¨‚é–±ï¼Œè«‹åœ¨ç€è¦½å™¨å‰å¾€å¸³å‹™è¨­å®šã€‚";

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
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 1 å€‹æœˆ";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 1 å€‹æœˆ";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 1 å€‹æœˆ";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "è²©è³£æ›´å¤š";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "æ‚¨æœƒç²å¾— 10% é¡å¤– Robux";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "è¨‚é–±";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "äº¤æ˜“";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "è¶…å€¼é…å¥—";

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
	public override string MessageGeneralError => "æ›´æ–°æ‚¨çš„è¨‚é–±æ™‚ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "æ²’æœ‰è¨‚é–±è³‡è¨Šã€‚";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "æ›´æ–°æ‚¨çš„è¨‚é–±æ™‚ä¼ºæœå™¨ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "æ‰¾ä¸åˆ°æ­¤ä½¿ç”¨è€…çš„ Builders Club è³‡è¨Šã€‚";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "å°ä¸èµ·ï¼Œç›®å‰æ²’æœ‰èˆ‡ Lifetime Builders Club ç›¸ç­‰çš„é…å¥—ï¼Œç„¡æ³•è®Šæ›´æ‚¨çš„è¨‚é–±ã€‚";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "ç¢ºèªè¨‚é–±æ›´æ–°";

	public PremiumResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "å·²è³¼è²·";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "ç¾åœ¨è³¼è²·ï¼";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "è³¼è²· Robux";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robux å¯ä»¥ç”¨ä¾†è³¼è²·è™›æ“¬äººå¶å¼·åŒ–è²¨éŠæˆ²å…§çš„ç‰¹æ®Šèƒ½åŠ›ã€‚è‹¥è¦äº†è§£å¦‚ä½•å–å¾— Robuxï¼Œ{lineBreak}è¨‚é–± Roblox Premium å¯ä»¥æ¯ä¸€å€‹æœˆç²å¾—æ›´å¤š Robuxï¼Œä¸¦ä½¿ç”¨é¡å¤–åŠŸèƒ½ã€‚Roblox Premium æŽ¡æœˆè²»åˆ¶ï¼Œç›´åˆ°å–æ¶ˆç‚ºæ­¢ã€‚{learnMoreLinkStart}å‰å¾€æ­¤è™•äº†è§£æ›´å¤š{learnMoreLinkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Robux å¯ä»¥ç”¨ä¾†è³¼è²·è™›æ“¬äººå¶å¼·åŒ–è²¨éŠæˆ²å…§çš„ç‰¹æ®Šèƒ½åŠ›ã€‚è‹¥è¦äº†è§£å¦‚ä½•å–å¾— Robuxï¼Œ{lineBreak}è¨‚é–± Roblox Premium å¯ä»¥æ¯ä¸€å€‹æœˆç²å¾—æ›´å¤š Robuxï¼Œä¸¦ä½¿ç”¨é¡å¤–åŠŸèƒ½ã€‚Roblox Premium æŽ¡æœˆè²»åˆ¶ï¼Œç›´åˆ°å–æ¶ˆç‚ºæ­¢ã€‚{learnMoreLinkStart}å‰å¾€æ­¤è™•äº†è§£æ›´å¤š{learnMoreLinkEnd}ã€‚";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"å–å¾— Robux å¼·åŒ–æ‚¨çš„è™›æ“¬äººå¶åŠè³¼è²·éŠæˆ²å…§çš„ç‰¹æ®Šèƒ½åŠ›ã€‚è‹¥è¦äº†è§£å¦‚ä½•å–å¾— Robuxï¼Œè«‹å‰å¾€ {helpLinkStart}Robux èªªæ˜Žé é¢{helpLinkEnd}ã€‚{paragraphBreaker}è³¼è²· Roblox Premium å°±èƒ½ä»¥ç›¸åŒåƒ¹æ ¼å–å¾—æ›´å¤š Robuxã€‚Roblox Premium æŽ¡æœˆè²»åˆ¶ï¼Œç›´åˆ°å–æ¶ˆç‚ºæ­¢ã€‚{learnMoreLinkStart}å‰å¾€æ­¤è™•äº†è§£æ›´å¤š{learnMoreLinkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "å–å¾— Robux å¼·åŒ–æ‚¨çš„è™›æ“¬äººå¶åŠè³¼è²·éŠæˆ²å…§çš„ç‰¹æ®Šèƒ½åŠ›ã€‚è‹¥è¦äº†è§£å¦‚ä½•å–å¾— Robuxï¼Œè«‹å‰å¾€ {helpLinkStart}Robux èªªæ˜Žé é¢{helpLinkEnd}ã€‚{paragraphBreaker}è³¼è²· Roblox Premium å°±èƒ½ä»¥ç›¸åŒåƒ¹æ ¼å–å¾—æ›´å¤š Robuxã€‚Roblox Premium æŽ¡æœˆè²»åˆ¶ï¼Œç›´åˆ°å–æ¶ˆç‚ºæ­¢ã€‚{learnMoreLinkStart}å‰å¾€æ­¤è™•äº†è§£æ›´å¤š{learnMoreLinkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "è³¼è²· Robux æ™‚ç²å¾—é¡å¤– 10%";
	}

	protected override string _GetTemplateForDescriptionGooglePlayMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium æ˜¯æœˆè²»åˆ¶çš„è¨‚é–±åˆ¶åº¦ã€‚å®Œæˆè³¼è²·æ™‚ï¼Œæˆ‘å€‘æœƒå‘æ‚¨çš„ Google Play å¸³è™Ÿæ”¶è²»ã€‚Roblox Premium æœƒè‡ªå‹•çºŒè¨‚ï¼Œä½†è‹¥æ‚¨ç›®å‰çš„è¨‚é–±é‚„å‰©è¶…éŽ 24 å°æ™‚ï¼Œæ‚¨å¯ä»¥é—œé–‰è‡ªå‹•æ›´æ–°ã€‚åœ¨æ‚¨çš„è¨‚é–±çµæŸçš„å‰ 24 å°æ™‚ä»¥å…§ï¼Œæˆ‘å€‘å°‡æœƒå‘æ‚¨çš„å¸³è™Ÿæ”¶è²»ã€‚æ‚¨å¯ä»¥åœ¨ Google Play å¸³è™Ÿè¨­å®šé é¢ç®¡ç†è¨‚é–±èˆ‡è‡ªå‹•æ›´æ–°é¸é …ã€‚è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premium æ˜¯æ¯å€‹æœˆè²»ç”¨ {costPrice} çš„è¨‚é–±åˆ¶åº¦ã€‚å®Œæˆè³¼è²·æ™‚ï¼Œæˆ‘å€‘æœƒå‘æ‚¨çš„ iTunes å¸³è™Ÿæ”¶è²»ã€‚Roblox Premium æœƒè‡ªå‹•çºŒè¨‚ï¼Œä½†è‹¥æ‚¨ç›®å‰çš„è¨‚é–±é‚„å‰©è¶…éŽ 24 å°æ™‚ï¼Œæ‚¨å¯ä»¥é—œé–‰è‡ªå‹•æ›´æ–°ã€‚åœ¨æ‚¨çš„è¨‚é–±çµæŸçš„å‰ 24 å°æ™‚ä»¥å…§ï¼Œæˆ‘å€‘å°‡æœƒå‘æ‚¨çš„å¸³è™Ÿæ”¶å– {renewalPrice}ã€‚æ‚¨å¯ä»¥åœ¨å¸³è™Ÿè¨­å®šé é¢ç®¡ç†è¨‚é–±èˆ‡è‡ªå‹•æ›´æ–°é¸é …ã€‚è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium æ˜¯æ¯å€‹æœˆè²»ç”¨ {costPrice} çš„è¨‚é–±åˆ¶åº¦ã€‚å®Œæˆè³¼è²·æ™‚ï¼Œæˆ‘å€‘æœƒå‘æ‚¨çš„ iTunes å¸³è™Ÿæ”¶è²»ã€‚Roblox Premium æœƒè‡ªå‹•çºŒè¨‚ï¼Œä½†è‹¥æ‚¨ç›®å‰çš„è¨‚é–±é‚„å‰©è¶…éŽ 24 å°æ™‚ï¼Œæ‚¨å¯ä»¥é—œé–‰è‡ªå‹•æ›´æ–°ã€‚åœ¨æ‚¨çš„è¨‚é–±çµæŸçš„å‰ 24 å°æ™‚ä»¥å…§ï¼Œæˆ‘å€‘å°‡æœƒå‘æ‚¨çš„å¸³è™Ÿæ”¶å– {renewalPrice}ã€‚æ‚¨å¯ä»¥åœ¨å¸³è™Ÿè¨­å®šé é¢ç®¡ç†è¨‚é–±èˆ‡è‡ªå‹•æ›´æ–°é¸é …ã€‚è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public override string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox Premium æ˜¯{durationType}è²»ç”¨ {costPrice} çš„è¨‚é–±åˆ¶åº¦ã€‚å®Œæˆè³¼è²·æ™‚ï¼Œæˆ‘å€‘æœƒå‘æ‚¨çš„ iTunes å¸³è™Ÿæ”¶è²»ã€‚Roblox Premium æœƒè‡ªå‹•çºŒè¨‚ï¼Œä½†è‹¥æ‚¨ç›®å‰çš„è¨‚é–±é‚„å‰©è¶…éŽ 24 å°æ™‚ï¼Œæ‚¨å¯ä»¥é—œé–‰è‡ªå‹•æ›´æ–°ã€‚åœ¨æ‚¨çš„è¨‚é–±çµæŸçš„å‰ 24 å°æ™‚ä»¥å…§ï¼Œæˆ‘å€‘å°‡æœƒå‘æ‚¨çš„å¸³è™Ÿæ”¶å– {renewalPrice}ã€‚æ‚¨å¯ä»¥åœ¨å¸³è™Ÿè¨­å®šé é¢ç®¡ç†è¨‚é–±èˆ‡è‡ªå‹•æ›´æ–°é¸é …ã€‚";
	}

	protected override string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox Premium æ˜¯{durationType}è²»ç”¨ {costPrice} çš„è¨‚é–±åˆ¶åº¦ã€‚å®Œæˆè³¼è²·æ™‚ï¼Œæˆ‘å€‘æœƒå‘æ‚¨çš„ iTunes å¸³è™Ÿæ”¶è²»ã€‚Roblox Premium æœƒè‡ªå‹•çºŒè¨‚ï¼Œä½†è‹¥æ‚¨ç›®å‰çš„è¨‚é–±é‚„å‰©è¶…éŽ 24 å°æ™‚ï¼Œæ‚¨å¯ä»¥é—œé–‰è‡ªå‹•æ›´æ–°ã€‚åœ¨æ‚¨çš„è¨‚é–±çµæŸçš„å‰ 24 å°æ™‚ä»¥å…§ï¼Œæˆ‘å€‘å°‡æœƒå‘æ‚¨çš„å¸³è™Ÿæ”¶å– {renewalPrice}ã€‚æ‚¨å¯ä»¥åœ¨å¸³è™Ÿè¨­å®šé é¢ç®¡ç†è¨‚é–±èˆ‡è‡ªå‹•æ›´æ–°é¸é …ã€‚";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"æ‚¨è³¼è²· Robux æ™‚åªæœƒç²å¾—ä½¿ç”¨ Robux çš„æŽˆæ¬Šã€‚è©²æŽˆæ¬Šå…·æœ‰é™åˆ¶æ€§ã€ç„¡æ³•é€€æ¬¾ã€ç„¡æ³•è½‰è®“ã€å¯è¢«æ”¶å›žï¼Œä¸¦ä¸”æ²’æœ‰é‡‘éŒ¢åƒ¹å€¼ã€‚è‹¥è¦äº†è§£å…¶å®ƒé™åˆ¶ï¼Œè«‹å‰å¾€{termsLinkStart}ä½¿ç”¨æ¢æ¬¾{termsLinkEnd}ã€‚è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "æ‚¨è³¼è²· Robux æ™‚åªæœƒç²å¾—ä½¿ç”¨ Robux çš„æŽˆæ¬Šã€‚è©²æŽˆæ¬Šå…·æœ‰é™åˆ¶æ€§ã€ç„¡æ³•é€€æ¬¾ã€ç„¡æ³•è½‰è®“ã€å¯è¢«æ”¶å›žï¼Œä¸¦ä¸”æ²’æœ‰é‡‘éŒ¢åƒ¹å€¼ã€‚è‹¥è¦äº†è§£å…¶å®ƒé™åˆ¶ï¼Œè«‹å‰å¾€{termsLinkStart}ä½¿ç”¨æ¢æ¬¾{termsLinkEnd}ã€‚è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking â€œSubmit Orderâ€ (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking â€œCancel membershipâ€ on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚æŒ‰ä¸‹ã€Œæäº¤è¨‚å–®ã€å³è¡¨ç¤º (1) æ‚¨æŽˆæ¬Šæˆ‘å€‘æ¯å€‹æœˆå‘æ‚¨çš„å¸³è™Ÿæ‰£æ¬¾ï¼Œç›´åˆ°ä½ å–æ¶ˆè¨‚é–±ç‚ºæ­¢ï¼›(2) æ‚¨äº†è§£ä¸¦åŒæ„{termsLinkStart}ä½¿ç”¨æ¢æ¬¾{termsLinkEnd}èˆ‡{privacyLinkStart}éš±ç§æ¬Šæ”¿ç­–{privatyLinkEnd}ã€‚æ‚¨éš¨æ™‚å¯ä»¥å‰å¾€è¨­å®šé é¢è£¡çš„ {billingLinkStart}å¸³å‹™æ¨™ç±¤{billingLinkEnd}ä½¿ç”¨æŒ‰éˆ•å–æ¶ˆæ‚¨çš„æœƒå“¡è³‡æ ¼ã€‚è‹¥æ‚¨å–æ¶ˆï¼Œæ‚¨ä¾ç„¶éœ€è¦ç‚ºç›®å‰çš„å¸³å–®é€±æœŸä»˜è²»ã€‚";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚æŒ‰ä¸‹ã€Œæäº¤è¨‚å–®ã€å³è¡¨ç¤º (1) æ‚¨æŽˆæ¬Šæˆ‘å€‘æ¯å€‹æœˆå‘æ‚¨çš„å¸³è™Ÿæ‰£æ¬¾ï¼Œç›´åˆ°ä½ å–æ¶ˆè¨‚é–±ç‚ºæ­¢ï¼›(2) æ‚¨äº†è§£ä¸¦åŒæ„{termsLinkStart}ä½¿ç”¨æ¢æ¬¾{termsLinkEnd}èˆ‡{privacyLinkStart}éš±ç§æ¬Šæ”¿ç­–{privatyLinkEnd}ã€‚æ‚¨éš¨æ™‚å¯ä»¥å‰å¾€è¨­å®šé é¢è£¡çš„ {billingLinkStart}å¸³å‹™æ¨™ç±¤{billingLinkEnd}ä½¿ç”¨æŒ‰éˆ•å–æ¶ˆæ‚¨çš„æœƒå“¡è³‡æ ¼ã€‚è‹¥æ‚¨å–æ¶ˆï¼Œæ‚¨ä¾ç„¶éœ€è¦ç‚ºç›®å‰çš„å¸³å–®é€±æœŸä»˜è²»ã€‚";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking â€œSubmit Orderâ€ (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking â€œCancel membershipâ€ on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚æŒ‰ä¸‹ã€Œæäº¤è¨‚å–®ã€å³è¡¨ç¤º (1) æ‚¨æŽˆæ¬Šæˆ‘å€‘æ¯å€‹æœˆå‘æ‚¨çš„å¸³è™Ÿæ‰£æ¬¾ï¼Œç›´åˆ°ä½ å–æ¶ˆè¨‚é–±ç‚ºæ­¢ï¼›(2) æ‚¨äº†è§£ä¸¦åŒæ„{teamOfUseLinkStart}ä½¿ç”¨æ¢æ¬¾{teamOfUseLinkEnd}èˆ‡{privacyPolicyLinkStart}éš±ç§æ¬Šæ”¿ç­–{privacyPolicyLinkEnd}ã€‚æ‚¨éš¨æ™‚å¯ä»¥å‰å¾€è¨­å®šé é¢è£¡çš„ {billingTabLinkStart}å¸³å‹™æ¨™ç±¤{billingTabLinkEnd}ä½¿ç”¨æŒ‰éˆ•å–æ¶ˆæ‚¨çš„æœƒå“¡è³‡æ ¼ã€‚è‹¥æ‚¨å–æ¶ˆï¼Œæ‚¨ä¾ç„¶éœ€è¦ç‚ºç›®å‰çš„å¸³å–®é€±æœŸä»˜è²»ã€‚";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "è‹¥æ‚¨æœªæ»¿ 18 æ­²ï¼Œè«‹åœ¨è³¼è²·ä¹‹å‰å¾µæ±‚å®¶é•·æˆ–æ³•å®šç›£è­·äººçš„åŒæ„ã€‚è‹¥æ‚¨åœ¨æœªç¶“åŒæ„ä¸‹é€²è¡Œè³¼è²·ï¼Œæ‚¨çš„å¸³è™Ÿå¯èƒ½æœƒé­åˆªé™¤ã€‚æŒ‰ä¸‹ã€Œæäº¤è¨‚å–®ã€å³è¡¨ç¤º (1) æ‚¨æŽˆæ¬Šæˆ‘å€‘æ¯å€‹æœˆå‘æ‚¨çš„å¸³è™Ÿæ‰£æ¬¾ï¼Œç›´åˆ°ä½ å–æ¶ˆè¨‚é–±ç‚ºæ­¢ï¼›(2) æ‚¨äº†è§£ä¸¦åŒæ„{teamOfUseLinkStart}ä½¿ç”¨æ¢æ¬¾{teamOfUseLinkEnd}èˆ‡{privacyPolicyLinkStart}éš±ç§æ¬Šæ”¿ç­–{privacyPolicyLinkEnd}ã€‚æ‚¨éš¨æ™‚å¯ä»¥å‰å¾€è¨­å®šé é¢è£¡çš„ {billingTabLinkStart}å¸³å‹™æ¨™ç±¤{billingTabLinkEnd}ä½¿ç”¨æŒ‰éˆ•å–æ¶ˆæ‚¨çš„æœƒå“¡è³‡æ ¼ã€‚è‹¥æ‚¨å–æ¶ˆï¼Œæ‚¨ä¾ç„¶éœ€è¦ç‚ºç›®å‰çš„å¸³å–®é€±æœŸä»˜è²»ã€‚";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "åŠ å…¥ Roblox Premium ä¹‹å¾Œï¼Œæ‚¨å°‡å¯ä»¥æ¯å€‹æœˆé ˜å– Robuxï¼Œè³¼è²· Robux æ™‚ä¹Ÿå°‡ç²å¾— 10% çŽå‹µã€‚é™¤æ­¤ä¹‹å¤–ï¼Œæ‚¨é‚„èƒ½äº«ç”¨æ›´å¤š Roblox åŠŸèƒ½ï¼ŒåŒ…æ‹¬è³¼è²·ã€è²©è³£å’Œäº¤æ˜“é“å…·ï¼Œå’Œå¢žåŠ éŠæˆ²ä¸­è²·è³£æŠ½æˆã€‚";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "è½‰è³£é“å…·å’Œè²©è³£æ‚¨çš„ä½œå“ï¼Œç²å¾—æ›´å¤š Robux";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "èˆ‡å…¶ä»– Premium æœƒå“¡äº¤æ›é“å…·";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "è³¼è²· Robux";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "ç¢ºèªå–æ¶ˆ";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "æ›´å¤šåŠŸèƒ½";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "éŒ¯èª¤";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "æ‚¨ç‚º Premium ä½¿ç”¨è€…ï¼Œè³¼è²· Robux æ™‚å¯äº«æœ‰æŠ˜æ‰£ï¼";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "ä¼ºæœå™¨éŒ¯èª¤";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "ç„¡æ³•è¨‚é–±";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "ç¢ºèªè¨‚é–±æ›´æ–°";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "æ‰¾ä¸åˆ° Builders Club";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "å‡ç´šåˆ° Roblox Premium";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "ç„¡æ³•å‡ç´š";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "å› ç‚ºæ‚¨å·²è¨‚é–±ï¼Œ";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "å–å¾—æ›´å¤šï¼";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "è¨‚é–±å¾Œå„ªæƒ åƒ¹æ ¼";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "è³¼è²· 1 æ¬¡";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "è³¼è²· Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "ç¢ºèª";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "æ‚¨ç›®å‰çš„æ–¹æ¡ˆ";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "ä»¥ 9 æŠ˜å„ªæƒ åƒ¹è³¼è²· Robux";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "å–å¾—æ›´å¤š Robux";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "è‹¥è¦ç®¡ç† Premium è¨‚é–±ï¼Œè«‹åœ¨ç€è¦½å™¨å‰å¾€å¸³å‹™è¨­å®šã€‚";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"æ‚¨ç›®å‰çš„è¨‚é–±ç‚º {premiumSubscription}ï¼Œæ–¼ {expirationDate} åˆ°æœŸã€‚";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "æ‚¨ç›®å‰çš„è¨‚é–±ç‚º {premiumSubscription}ï¼Œæ–¼ {expirationDate} åˆ°æœŸã€‚";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"æ‚¨ç›®å‰çš„æ–¹æ¡ˆæ˜¯ {premiumSubscription}ï¼Œå°‡æ–¼ {expirationDate} åˆ°æœŸã€‚æœƒå“¡è³‡æ ¼åˆ°æœŸå¾Œï¼Œæ‚¨å¯ä»¥é‡æ–°è³¼è²·åŒä¸€å€‹æ–¹æ¡ˆæˆ–è³¼è²·æ–°çš„æ–¹æ¡ˆã€‚";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "æ‚¨ç›®å‰çš„æ–¹æ¡ˆæ˜¯ {premiumSubscription}ï¼Œå°‡æ–¼ {expirationDate} åˆ°æœŸã€‚æœƒå“¡è³‡æ ¼åˆ°æœŸå¾Œï¼Œæ‚¨å¯ä»¥é‡æ–°è³¼è²·åŒä¸€å€‹æ–¹æ¡ˆæˆ–è³¼è²·æ–°çš„æ–¹æ¡ˆã€‚";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"æ‚¨ç›®å‰çš„æ–¹æ¡ˆç‚º {premiumSubscription}ï¼Œæ›´æ–°æ—¥æœŸç‚º {renewal}ã€‚";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "æ‚¨ç›®å‰çš„æ–¹æ¡ˆç‚º {premiumSubscription}ï¼Œæ›´æ–°æ—¥æœŸç‚º {renewal}ã€‚";
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
		return $"{robux}{subTextStart} / æœˆ{subTextEnd}";
	}

	protected override string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart} / æœˆ{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public override string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount} / æœˆ";
	}

	protected override string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount} / æœˆ";
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
		return "Roblox Premium 1000 1 å€‹æœˆ";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 1 å€‹æœˆ";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 1 å€‹æœˆ";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "è²©è³£æ›´å¤š";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "æ‚¨æœƒç²å¾— 10% é¡å¤– Robux";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "è¨‚é–±";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"ç¾åœ¨è¨‚é–±ï¼Œ{upsellLinkStart}ç²å¾—æ›´å¤šï¼{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "ç¾åœ¨è¨‚é–±ï¼Œ{upsellLinkStart}ç²å¾—æ›´å¤šï¼{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "äº¤æ˜“";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "è¶…å€¼é…å¥—";
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
		return $"æŒ‰ä¸‹ã€Œç¢ºèªã€å¾Œï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼å°‡æœƒçµæŸï¼Œè€Œæ‚¨å°‡å¯ä»¥è¨‚é–± Roblox Premiumã€‚{newLine}æ‚¨å°‡æœƒæ”¶åˆ°ä¸€æ¬¡æ€§çš„ {robuxAmount}ã€‚";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "æŒ‰ä¸‹ã€Œç¢ºèªã€å¾Œï¼Œæ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼å°‡æœƒçµæŸï¼Œè€Œæ‚¨å°‡å¯ä»¥è¨‚é–± Roblox Premiumã€‚{newLine}æ‚¨å°‡æœƒæ”¶åˆ°ä¸€æ¬¡æ€§çš„ {robuxAmount}ã€‚";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "æ›´æ–°æ‚¨çš„è¨‚é–±æ™‚ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "æ²’æœ‰è¨‚é–±è³‡è¨Šã€‚";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "æ›´æ–°æ‚¨çš„è¨‚é–±æ™‚ä¼ºæœå™¨ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"å°ä¸èµ·ï¼Œåœ¨æ‚¨ç›®å‰å·²å–æ¶ˆçš„æ–¹æ¡ˆå¤±æ•ˆä¹‹å‰ï¼Œæ‚¨ç„¡æ³•è¨‚é–±ã€‚è«‹æ–¼ {expiredDate} ä¹‹å¾Œé‡æ–°è¨‚é–±ã€‚";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "å°ä¸èµ·ï¼Œåœ¨æ‚¨ç›®å‰å·²å–æ¶ˆçš„æ–¹æ¡ˆå¤±æ•ˆä¹‹å‰ï¼Œæ‚¨ç„¡æ³•è¨‚é–±ã€‚è«‹æ–¼ {expiredDate} ä¹‹å¾Œé‡æ–°è¨‚é–±ã€‚";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"æŒ‰ä¸‹ã€Œç¢ºèªã€ä»£è¡¨æ‚¨æŽˆæ¬Šæˆ‘å€‘å¾ž {renewalDate} é–‹å§‹æ¯å€‹æœˆå‘æ‚¨æ”¶å– {price}ï¼Œç›´è‡³æ‚¨å–æ¶ˆæˆ–åˆ‡æ›è¨‚é–±ã€‚";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "æŒ‰ä¸‹ã€Œç¢ºèªã€ä»£è¡¨æ‚¨æŽˆæ¬Šæˆ‘å€‘å¾ž {renewalDate} é–‹å§‹æ¯å€‹æœˆå‘æ‚¨æ”¶å– {price}ï¼Œç›´è‡³æ‚¨å–æ¶ˆæˆ–åˆ‡æ›è¨‚é–±ã€‚";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "æ‰¾ä¸åˆ°æ­¤ä½¿ç”¨è€…çš„ Builders Club è³‡è¨Šã€‚";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "å°ä¸èµ·ï¼Œç›®å‰æ²’æœ‰èˆ‡ Lifetime Builders Club ç›¸ç­‰çš„é…å¥—ï¼Œç„¡æ³•è®Šæ›´æ‚¨çš„è¨‚é–±ã€‚";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "ç¢ºèªè¨‚é–±æ›´æ–°";
	}
}


}
