namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionBought => "è³¼å…¥ã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "ä»Šã™ãè²·ã†ï¼";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robuxã‚’è²·ã†";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "Robuxã®è³¼å…¥ã§10%ã®ãƒœãƒ¼ãƒŠã‚¹ã‚’ã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "Roblox Premiumã«å…¥ä¼šã™ã‚‹ã¨æ¯ŽæœˆRobuxãŒæ”¯çµ¦ã•ã‚Œã€ã•ã‚‰ã«Robuxã‚’è³¼å…¥ã—ãŸéš›ã«10%ã®ãƒœãƒ¼ãƒŠã‚¹ã‚’ã‚²ãƒƒãƒˆã—ã¾ã™ã€‚ã¾ãŸã€ã™ã¹ã¦ã®ã‚²ãƒ¼ãƒ å†…ã§ã®åŽå…¥ã‚¢ãƒƒãƒ—ã ã‘ã§ãªãã€è³¼å…¥ã€è²©å£²ã€ã‚¢ã‚¤ãƒ†ãƒ ã®äº¤æ›ãªã©ã€Robloxã®çµŒæ¸ˆæ©Ÿèƒ½ã«ã‚¢ã‚¯ã‚»ã‚¹ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "ã‚¢ã‚¤ãƒ†ãƒ ã‚’å†è²©å£²ã—ãŸã‚Šã€ä½œå“ã‚’å£²ã£ã¦Robuxã‚’ã•ã‚‰ã«ã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "ä»–ã®Premiumãƒ¡ãƒ³ãƒãƒ¼ã¨ã‚¢ã‚¤ãƒ†ãƒ ã‚’å–å¼•ã™ã‚‹";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robuxã‚’è²·ã†";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã®ç¢ºèª";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "ã•ã‚‰ã«å¤šãã®æ©Ÿèƒ½";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "ã‚¨ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "Premiumãƒ¦ãƒ¼ã‚¶ãƒ¼ã¨ã—ã¦ã€Robuxã§å‰²å¼•ãã‚’ã‚‚ã‚‰ãˆã¾ã™ï¼";

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
	public override string HeadingServerError => "ã‚µãƒ¼ãƒãƒ¼ã‚¨ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®æ›´æ–°ã‚’ç¢ºèª";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "Builders ClubãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸ";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "Roblox Premiumã«ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰ã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "Robuxã‚’ã•ã‚‰ã«10%ã‚²ãƒƒãƒˆã—ã¾ã™";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "ã•ã‚‰ã«ã‚²ãƒƒãƒˆï¼";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã—ã¦ã„ã‚‹ãŸã‚ï¼";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "ä¸€åº¦è²·ã†";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "Robuxã‚’è²·ã†";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "ç¢ºå®š";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "ç¾åœ¨ã®ãƒ—ãƒ©ãƒ³";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "Robuxã‚’10%ã‚ªãƒ•ã§ã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "ã•ã‚‰ã«Robuxã‚’ã‚²ãƒƒãƒˆã™ã‚‹";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "Premiumã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã‚’ç®¡ç†ã™ã‚‹ã«ã¯ã€ãƒ–ãƒ©ã‚¦ã‚¶ã‚’ä½¿ã£ã¦è«‹æ±‚è¨­å®šã¸è¡Œã£ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "ã„ã„ãˆ";

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
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 ä¸€ãƒ¶æœˆ";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 ä¸€ãƒ¶æœˆ";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 ä¸€ãƒ¶æœˆ";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "ã‚‚ã£ã¨å£²ã‚‹";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã—ãŸãŸã‚";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã™ã‚‹";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "å–å¼•";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "ãƒãƒªãƒ¥ãƒ¼ãƒ‘ãƒƒã‚¯";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public override string LabelWantMoreRobux => "RobuxãŒã‚‚ã£ã¨å¿…è¦ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "ã¯ã„";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageGeneralError => "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³æƒ…å ±ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆä¸­ã«ã‚µãƒ¼ãƒãƒ¼ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã®Builders Clubæƒ…å ±ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ç¾åœ¨ã€æ°¸ä¹…Builders Clubã¨åŒç­‰ã®ãƒ‘ãƒƒã‚±ãƒ¼ã‚¸ãŒãªã„ãŸã‚ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®å¤‰æ›´ã¯ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®æ›´æ–°ã‚’ç¢ºèª";

	public PremiumResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "è³¼å…¥ã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "ä»Šã™ãè²·ã†ï¼";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robuxã‚’è²·ã†";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robuxã‚’è²·ã£ã¦ã‚²ãƒ¼ãƒ å†…ã§ã‚¢ãƒã‚¿ãƒ¼ã®ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰ã‚„ç‰¹æ®Šèƒ½åŠ›ã‚’è³¼å…¥ã—ã¾ã—ã‚‡ã†ã€‚{lineBreak} Roblox Premiumã®ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã‚’ã—ã¦ã€ãƒœãƒ¼ãƒŠã‚¹æ©Ÿèƒ½ã¨æ¯Žæœˆã‚‚ã£ã¨Robuxã‚’ã‚²ãƒƒãƒˆã€‚Premiumã¯ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§ã€æ¯Žæœˆèª²é‡‘ã•ã‚Œã¾ã™ã€‚ {learnMoreLinkStart}è©³ç´°ã¯ã“ã¡ã‚‰ã€‚{learnMoreLinkEnd}";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Robuxã‚’è²·ã£ã¦ã‚²ãƒ¼ãƒ å†…ã§ã‚¢ãƒã‚¿ãƒ¼ã®ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰ã‚„ç‰¹æ®Šèƒ½åŠ›ã‚’è³¼å…¥ã—ã¾ã—ã‚‡ã†ã€‚{lineBreak} Roblox Premiumã®ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã‚’ã—ã¦ã€ãƒœãƒ¼ãƒŠã‚¹æ©Ÿèƒ½ã¨æ¯Žæœˆã‚‚ã£ã¨Robuxã‚’ã‚²ãƒƒãƒˆã€‚Premiumã¯ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§ã€æ¯Žæœˆèª²é‡‘ã•ã‚Œã¾ã™ã€‚ {learnMoreLinkStart}è©³ç´°ã¯ã“ã¡ã‚‰ã€‚{learnMoreLinkEnd}";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robuxã‚’ã‚²ãƒƒãƒˆã—ã¦ã‚²ãƒ¼ãƒ å†…ã§ã‚¢ãƒã‚¿ãƒ¼ã®ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰ã‚„ç‰¹æ®Šèƒ½åŠ›ã‚’è²·ã„ã¾ã—ã‚‡ã†ã€‚Robuxã‚’ç¨¼ãæ–¹æ³•ã«ã¤ã„ã¦ã®æƒ…å ±ã«ã¤ã„ã¦ã¯{helpLinkStart}Robuxãƒ˜ãƒ«ãƒ—ãƒšãƒ¼ã‚¸{helpLinkEnd}ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚{paragraphBreaker}Roblox Premiumã‚’è²·ã†ã¨ã€åŒã˜é‡‘é¡ã§ã‚ˆã‚Šå¤šãRobuxã‚’ã‚²ãƒƒãƒˆã§ãã¾ã™ã€‚Roblox Premiumã¯ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§æ¯Žæœˆèª²é‡‘ã•ã‚Œã¾ã™ã€‚{learnMoreLinkStart}è©³ç´°ã¯ã“ã¡ã‚‰{learnMoreLinkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "Robuxã‚’ã‚²ãƒƒãƒˆã—ã¦ã‚²ãƒ¼ãƒ å†…ã§ã‚¢ãƒã‚¿ãƒ¼ã®ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰ã‚„ç‰¹æ®Šèƒ½åŠ›ã‚’è²·ã„ã¾ã—ã‚‡ã†ã€‚Robuxã‚’ç¨¼ãæ–¹æ³•ã«ã¤ã„ã¦ã®æƒ…å ±ã«ã¤ã„ã¦ã¯{helpLinkStart}Robuxãƒ˜ãƒ«ãƒ—ãƒšãƒ¼ã‚¸{helpLinkEnd}ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚{paragraphBreaker}Roblox Premiumã‚’è²·ã†ã¨ã€åŒã˜é‡‘é¡ã§ã‚ˆã‚Šå¤šãRobuxã‚’ã‚²ãƒƒãƒˆã§ãã¾ã™ã€‚Roblox Premiumã¯ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§æ¯Žæœˆèª²é‡‘ã•ã‚Œã¾ã™ã€‚{learnMoreLinkStart}è©³ç´°ã¯ã“ã¡ã‚‰{learnMoreLinkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "Robuxã®è³¼å…¥ã§10%ã®ãƒœãƒ¼ãƒŠã‚¹ã‚’ã‚²ãƒƒãƒˆ";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premiumã¯ã€æ–™é‡‘ãŒæœˆé¡ {costPrice} ã®ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã§ã™ã€‚ãŠæ”¯æ‰•ã„ã¯ã€ã”è³¼å…¥ã®ç¢ºèªæ™‚ã«iTunesã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«èª²é‡‘ã•ã‚Œã¾ã™ã€‚Roblox Premiumã¯ã€ç¾åœ¨ã®å¥‘ç´„æœŸé–“çµ‚äº†æ—¥ã®å°‘ãªãã¨ã‚‚24æ™‚é–“å‰ã«è‡ªå‹•æ›´æ–°ãŒã‚ªãƒ•ã«ã•ã‚Œãªã„é™ã‚Šè‡ªå‹•æ›´æ–°ã•ã‚Œã¾ã™ã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ç¾åœ¨ã®å¥‘ç´„æœŸé–“ã®æœ€çµ‚æ—¥ã®24æ™‚é–“ä»¥å†…ã« {renewalPrice} èª²é‡‘ã•ã‚Œæ›´æ–°ã•ã‚Œã¾ã™ã€‚ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®šã¸è¡Œã‘ã°ç®¡ç†ã—ãŸã‚Šè‡ªå‹•æ›´æ–°ã‚’ã‚ªãƒ•ã«ã—ãŸã‚Šã§ãã¾ã™ã€‚18æ­³ä»¥ä¸‹ã®å ´åˆã¯ã€è³¼å…¥ã™ã‚‹å‰ã«å¿…ãšä¸¡è¦ªã‹æ³•çš„ãªä¿è­·è€…ã®è¨±å¯ãŒã‚ã‚‹ã“ã¨ã‚’ç¢ºã‹ã‚ã¦ãã ã•ã„ã€‚è¨±å¯ã®ãªã„è³¼å…¥ã‚’ã™ã‚‹ã“ã¨ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å‰Šé™¤ã«ã¤ãªãŒã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premiumã¯ã€æ–™é‡‘ãŒæœˆé¡ {costPrice} ã®ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã§ã™ã€‚ãŠæ”¯æ‰•ã„ã¯ã€ã”è³¼å…¥ã®ç¢ºèªæ™‚ã«iTunesã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«èª²é‡‘ã•ã‚Œã¾ã™ã€‚Roblox Premiumã¯ã€ç¾åœ¨ã®å¥‘ç´„æœŸé–“çµ‚äº†æ—¥ã®å°‘ãªãã¨ã‚‚24æ™‚é–“å‰ã«è‡ªå‹•æ›´æ–°ãŒã‚ªãƒ•ã«ã•ã‚Œãªã„é™ã‚Šè‡ªå‹•æ›´æ–°ã•ã‚Œã¾ã™ã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ç¾åœ¨ã®å¥‘ç´„æœŸé–“ã®æœ€çµ‚æ—¥ã®24æ™‚é–“ä»¥å†…ã« {renewalPrice} èª²é‡‘ã•ã‚Œæ›´æ–°ã•ã‚Œã¾ã™ã€‚ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®šã¸è¡Œã‘ã°ç®¡ç†ã—ãŸã‚Šè‡ªå‹•æ›´æ–°ã‚’ã‚ªãƒ•ã«ã—ãŸã‚Šã§ãã¾ã™ã€‚18æ­³ä»¥ä¸‹ã®å ´åˆã¯ã€è³¼å…¥ã™ã‚‹å‰ã«å¿…ãšä¸¡è¦ªã‹æ³•çš„ãªä¿è­·è€…ã®è¨±å¯ãŒã‚ã‚‹ã“ã¨ã‚’ç¢ºã‹ã‚ã¦ãã ã•ã„ã€‚è¨±å¯ã®ãªã„è³¼å…¥ã‚’ã™ã‚‹ã“ã¨ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å‰Šé™¤ã«ã¤ãªãŒã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public override string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox Premiumã¯ã€æ–™é‡‘ãŒ {costPrice} ã® {durationType} ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã§ã™ã€‚ãŠæ”¯æ‰•ã„ã¯ã€ã”è³¼å…¥ã®ç¢ºèªæ™‚ã«iTunesã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«èª²é‡‘ã•ã‚Œã¾ã™ã€‚Roblox Premiumã¯ã€ç¾åœ¨ã®å¥‘ç´„æœŸé–“çµ‚äº†æ—¥ã®å°‘ãªãã¨ã‚‚24æ™‚é–“å‰ã«è‡ªå‹•æ›´æ–°ãŒã‚ªãƒ•ã«ã•ã‚Œãªã„é™ã‚Šè‡ªå‹•æ›´æ–°ã•ã‚Œã¾ã™ã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ç¾åœ¨ã®å¥‘ç´„æœŸé–“ã®æœ€çµ‚æ—¥ã®24æ™‚é–“ä»¥å†…ã« {renewalPrice} èª²é‡‘ã•ã‚Œæ›´æ–°ã•ã‚Œã¾ã™ã€‚ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã¯ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®šã¸è¡Œã‘ã°ç®¡ç†ã—ãŸã‚Šè‡ªå‹•æ›´æ–°ã‚’ã‚ªãƒ•ã«ã—ãŸã‚Šã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox Premiumã¯ã€æ–™é‡‘ãŒ {costPrice} ã® {durationType} ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã§ã™ã€‚ãŠæ”¯æ‰•ã„ã¯ã€ã”è³¼å…¥ã®ç¢ºèªæ™‚ã«iTunesã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«èª²é‡‘ã•ã‚Œã¾ã™ã€‚Roblox Premiumã¯ã€ç¾åœ¨ã®å¥‘ç´„æœŸé–“çµ‚äº†æ—¥ã®å°‘ãªãã¨ã‚‚24æ™‚é–“å‰ã«è‡ªå‹•æ›´æ–°ãŒã‚ªãƒ•ã«ã•ã‚Œãªã„é™ã‚Šè‡ªå‹•æ›´æ–°ã•ã‚Œã¾ã™ã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ç¾åœ¨ã®å¥‘ç´„æœŸé–“ã®æœ€çµ‚æ—¥ã®24æ™‚é–“ä»¥å†…ã« {renewalPrice} èª²é‡‘ã•ã‚Œæ›´æ–°ã•ã‚Œã¾ã™ã€‚ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã¯ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®šã¸è¡Œã‘ã°ç®¡ç†ã—ãŸã‚Šè‡ªå‹•æ›´æ–°ã‚’ã‚ªãƒ•ã«ã—ãŸã‚Šã§ãã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"Robuxã‚’è²·ã†ã¨ã€åˆ¶é™ãŒã‚ã‚Šè¿”é‡‘ä¸å¯ã§è­²æ¸¡ä¸å¯ã§å–ã‚Šæ¶ˆã—å¯èƒ½ãªRobuxã‚’ä½¿ã†ãƒ©ã‚¤ã‚»ãƒ³ã‚¹ã‚’å—ã‘å–ã‚‹ã ã‘ã§ã€ã“ã‚Œã«ã¯ç¾å®Ÿã®é€šè²¨ã§ã®ä¾¡å€¤ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ãã®ä»–ã®åˆ¶é™ã«ã¤ã„ã¦ã¯ã€{termsLinkStart}åˆ©ç”¨è¦ç´„{termsLinkEnd}ã‚’ã”è¦§ãã ã•ã„ã€‚18æ­³ä»¥ä¸‹ã®å ´åˆã¯ã€è³¼å…¥ã™ã‚‹å‰ã«å¿…ãšä¸¡è¦ªã‹æ³•çš„ãªä¿è­·è€…ã®è¨±å¯ãŒã‚ã‚‹ã“ã¨ã‚’ç¢ºã‹ã‚ã¦ãã ã•ã„ã€‚è¨±å¯ã®ãªã„è³¼å…¥ã‚’ã™ã‚‹ã“ã¨ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å‰Šé™¤ã«ã¤ãªãŒã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "Robuxã‚’è²·ã†ã¨ã€åˆ¶é™ãŒã‚ã‚Šè¿”é‡‘ä¸å¯ã§è­²æ¸¡ä¸å¯ã§å–ã‚Šæ¶ˆã—å¯èƒ½ãªRobuxã‚’ä½¿ã†ãƒ©ã‚¤ã‚»ãƒ³ã‚¹ã‚’å—ã‘å–ã‚‹ã ã‘ã§ã€ã“ã‚Œã«ã¯ç¾å®Ÿã®é€šè²¨ã§ã®ä¾¡å€¤ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ãã®ä»–ã®åˆ¶é™ã«ã¤ã„ã¦ã¯ã€{termsLinkStart}åˆ©ç”¨è¦ç´„{termsLinkEnd}ã‚’ã”è¦§ãã ã•ã„ã€‚18æ­³ä»¥ä¸‹ã®å ´åˆã¯ã€è³¼å…¥ã™ã‚‹å‰ã«å¿…ãšä¸¡è¦ªã‹æ³•çš„ãªä¿è­·è€…ã®è¨±å¯ãŒã‚ã‚‹ã“ã¨ã‚’ç¢ºã‹ã‚ã¦ãã ã•ã„ã€‚è¨±å¯ã®ãªã„è³¼å…¥ã‚’ã™ã‚‹ã“ã¨ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å‰Šé™¤ã«ã¤ãªãŒã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking â€œSubmit Orderâ€ (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking â€œCancel membershipâ€ on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"18æ­³ä»¥ä¸‹ã®å ´åˆã¯ã€è³¼å…¥ã™ã‚‹å‰ã«å¿…ãšä¸¡è¦ªã‹æ³•çš„ãªä¿è­·è€…ã®è¨±å¯ãŒã‚ã‚‹ã“ã¨ã‚’ç¢ºã‹ã‚ã¦ãã ã•ã„ã€‚è¨±å¯ã®ãªã„è³¼å…¥ã‚’ã™ã‚‹ã“ã¨ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å‰Šé™¤ã«ã¤ãªãŒã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚ã€Œã”æ³¨æ–‡ã‚’é€ä¿¡ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€(1) ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§æ¯Žæœˆã€å½“ç¤¾ãŒèª²é‡‘ã™ã‚‹ã“ã¨ã‚’è¨±å¯ã—ã€ (2) {termsLinkStart}åˆ©ç”¨è¦ç´„{termsLinkEnd} ã¨ {privacyLinkStart}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼{privatyLinkEnd}ã‚’ç†è§£ã—ã€åŒæ„ã‚’è¡¨æ˜Žã—ãŸã“ã¨ã«ãªã‚Šã¾ã™ã€‚è¨­å®šãƒšãƒ¼ã‚¸ã«ã‚ã‚‹ {billingLinkStart}ã”è«‹æ±‚ã‚¿ãƒ–{billingLinkEnd} ã®ã€Œãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ã„ã¤ã§ã‚‚ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã§ãã¾ã™ã€‚ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã—ã¦ã‚‚ã€ç¾åœ¨ã®ã”è«‹æ±‚æœŸé–“ã«é–¢ã—ã¦ã¯èª²é‡‘ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "18æ­³ä»¥ä¸‹ã®å ´åˆã¯ã€è³¼å…¥ã™ã‚‹å‰ã«å¿…ãšä¸¡è¦ªã‹æ³•çš„ãªä¿è­·è€…ã®è¨±å¯ãŒã‚ã‚‹ã“ã¨ã‚’ç¢ºã‹ã‚ã¦ãã ã•ã„ã€‚è¨±å¯ã®ãªã„è³¼å…¥ã‚’ã™ã‚‹ã“ã¨ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å‰Šé™¤ã«ã¤ãªãŒã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚ã€Œã”æ³¨æ–‡ã‚’é€ä¿¡ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€(1) ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§æ¯Žæœˆã€å½“ç¤¾ãŒèª²é‡‘ã™ã‚‹ã“ã¨ã‚’è¨±å¯ã—ã€ (2) {termsLinkStart}åˆ©ç”¨è¦ç´„{termsLinkEnd} ã¨ {privacyLinkStart}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼{privatyLinkEnd}ã‚’ç†è§£ã—ã€åŒæ„ã‚’è¡¨æ˜Žã—ãŸã“ã¨ã«ãªã‚Šã¾ã™ã€‚è¨­å®šãƒšãƒ¼ã‚¸ã«ã‚ã‚‹ {billingLinkStart}ã”è«‹æ±‚ã‚¿ãƒ–{billingLinkEnd} ã®ã€Œãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ã„ã¤ã§ã‚‚ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã§ãã¾ã™ã€‚ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã—ã¦ã‚‚ã€ç¾åœ¨ã®ã”è«‹æ±‚æœŸé–“ã«é–¢ã—ã¦ã¯èª²é‡‘ã•ã‚Œã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking â€œSubmit Orderâ€ (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking â€œCancel membershipâ€ on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"18æ­³ä»¥ä¸‹ã®å ´åˆã¯ã€è³¼å…¥ã™ã‚‹å‰ã«å¿…ãšä¸¡è¦ªã‹æ³•çš„ãªä¿è­·è€…ã®è¨±å¯ãŒã‚ã‚‹ã“ã¨ã‚’ç¢ºã‹ã‚ã¦ãã ã•ã„ã€‚è¨±å¯ã®ãªã„è³¼å…¥ã‚’ã™ã‚‹ã“ã¨ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å‰Šé™¤ã«ã¤ãªãŒã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚ã€Œã”æ³¨æ–‡ã‚’é€ä¿¡ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€(1) ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§æ¯Žæœˆã€å½“ç¤¾ãŒèª²é‡‘ã™ã‚‹ã“ã¨ã‚’è¨±å¯ã—ã€ (2) {teamOfUseLinkStart}åˆ©ç”¨è¦ç´„{teamOfUseLinkEnd} ã¨  {privacyPolicyLinkStart}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼{privacyPolicyLinkEnd}ã‚’ç†è§£ã—ã€åŒæ„ã‚’è¡¨æ˜Žã—ãŸã“ã¨ã«ãªã‚Šã¾ã™ã€‚è¨­å®šãƒšãƒ¼ã‚¸ã«ã‚ã‚‹ {billingTabLinkStart} ã”è«‹æ±‚ã‚¿ãƒ–{billingTabLinkEnd} ã®ã€Œãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ã„ã¤ã§ã‚‚ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã§ãã¾ã™ã€‚ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã—ã¦ã‚‚ã€ç¾åœ¨ã®ã”è«‹æ±‚æœŸé–“ã«é–¢ã—ã¦ã¯èª²é‡‘ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "18æ­³ä»¥ä¸‹ã®å ´åˆã¯ã€è³¼å…¥ã™ã‚‹å‰ã«å¿…ãšä¸¡è¦ªã‹æ³•çš„ãªä¿è­·è€…ã®è¨±å¯ãŒã‚ã‚‹ã“ã¨ã‚’ç¢ºã‹ã‚ã¦ãã ã•ã„ã€‚è¨±å¯ã®ãªã„è³¼å…¥ã‚’ã™ã‚‹ã“ã¨ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å‰Šé™¤ã«ã¤ãªãŒã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚ã€Œã”æ³¨æ–‡ã‚’é€ä¿¡ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€(1) ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§æ¯Žæœˆã€å½“ç¤¾ãŒèª²é‡‘ã™ã‚‹ã“ã¨ã‚’è¨±å¯ã—ã€ (2) {teamOfUseLinkStart}åˆ©ç”¨è¦ç´„{teamOfUseLinkEnd} ã¨  {privacyPolicyLinkStart}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼{privacyPolicyLinkEnd}ã‚’ç†è§£ã—ã€åŒæ„ã‚’è¡¨æ˜Žã—ãŸã“ã¨ã«ãªã‚Šã¾ã™ã€‚è¨­å®šãƒšãƒ¼ã‚¸ã«ã‚ã‚‹ {billingTabLinkStart} ã”è«‹æ±‚ã‚¿ãƒ–{billingTabLinkEnd} ã®ã€Œãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚Œã°ã€ã„ã¤ã§ã‚‚ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã§ãã¾ã™ã€‚ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã—ã¦ã‚‚ã€ç¾åœ¨ã®ã”è«‹æ±‚æœŸé–“ã«é–¢ã—ã¦ã¯èª²é‡‘ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "Roblox Premiumã«å…¥ä¼šã™ã‚‹ã¨æ¯ŽæœˆRobuxãŒæ”¯çµ¦ã•ã‚Œã€ã•ã‚‰ã«Robuxã‚’è³¼å…¥ã—ãŸéš›ã«10%ã®ãƒœãƒ¼ãƒŠã‚¹ã‚’ã‚²ãƒƒãƒˆã—ã¾ã™ã€‚ã¾ãŸã€ã™ã¹ã¦ã®ã‚²ãƒ¼ãƒ å†…ã§ã®åŽå…¥ã‚¢ãƒƒãƒ—ã ã‘ã§ãªãã€è³¼å…¥ã€è²©å£²ã€ã‚¢ã‚¤ãƒ†ãƒ ã®äº¤æ›ãªã©ã€Robloxã®çµŒæ¸ˆæ©Ÿèƒ½ã«ã‚¢ã‚¯ã‚»ã‚¹ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ã‚’å†è²©å£²ã—ãŸã‚Šã€ä½œå“ã‚’å£²ã£ã¦Robuxã‚’ã•ã‚‰ã«ã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "ä»–ã®Premiumãƒ¡ãƒ³ãƒãƒ¼ã¨ã‚¢ã‚¤ãƒ†ãƒ ã‚’å–å¼•ã™ã‚‹";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robuxã‚’è²·ã†";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã®ç¢ºèª";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "ã•ã‚‰ã«å¤šãã®æ©Ÿèƒ½";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "ã‚¨ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "Premiumãƒ¦ãƒ¼ã‚¶ãƒ¼ã¨ã—ã¦ã€Robuxã§å‰²å¼•ãã‚’ã‚‚ã‚‰ãˆã¾ã™ï¼";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "ã‚µãƒ¼ãƒãƒ¼ã‚¨ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®æ›´æ–°ã‚’ç¢ºèª";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "Builders ClubãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸ";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "Roblox Premiumã«ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰ã§ãã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "Robuxã‚’ã•ã‚‰ã«10%ã‚²ãƒƒãƒˆã—ã¾ã™";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "ã•ã‚‰ã«ã‚²ãƒƒãƒˆï¼";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã—ã¦ã„ã‚‹ãŸã‚ï¼";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "ä¸€åº¦è²·ã†";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "Robuxã‚’è²·ã†";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "ç¾åœ¨ã®ãƒ—ãƒ©ãƒ³";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "Robuxã‚’10%ã‚ªãƒ•ã§ã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "ã•ã‚‰ã«Robuxã‚’ã‚²ãƒƒãƒˆã™ã‚‹";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "Premiumã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã‚’ç®¡ç†ã™ã‚‹ã«ã¯ã€ãƒ–ãƒ©ã‚¦ã‚¶ã‚’ä½¿ã£ã¦è«‹æ±‚è¨­å®šã¸è¡Œã£ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"ç¾åœ¨ã®ãƒ—ãƒ©ãƒ³ã¯ {premiumSubscription} ã§ã™ã€‚å¥‘ç´„ã¯ {expirationDate} æ—¥ã«çµ‚äº†ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "ç¾åœ¨ã®ãƒ—ãƒ©ãƒ³ã¯ {premiumSubscription} ã§ã™ã€‚å¥‘ç´„ã¯ {expirationDate} æ—¥ã«çµ‚äº†ã—ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"ã‚ãªãŸã®ç¾åœ¨ã®ãƒ—ãƒ©ãƒ³ã¯ {premiumSubscription} ã§ã™ã€‚{expirationDate} ã«çµ‚äº†ã—ã¾ã™ã€‚ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®çµ‚äº†å¾Œã¯ã€å†è³¼å…¥ã™ã‚‹ã‹ã€æ–°ã—ã„ãƒ—ãƒ©ãƒ³ã«ç”³ã—è¾¼ã‚€ã“ã¨ãŒã§ãã¾ã™ã€‚ ";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "ã‚ãªãŸã®ç¾åœ¨ã®ãƒ—ãƒ©ãƒ³ã¯ {premiumSubscription} ã§ã™ã€‚{expirationDate} ã«çµ‚äº†ã—ã¾ã™ã€‚ãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®çµ‚äº†å¾Œã¯ã€å†è³¼å…¥ã™ã‚‹ã‹ã€æ–°ã—ã„ãƒ—ãƒ©ãƒ³ã«ç”³ã—è¾¼ã‚€ã“ã¨ãŒã§ãã¾ã™ã€‚ ";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"ç¾åœ¨ã®ãƒ—ãƒ©ãƒ³ã¯ {premiumSubscription} ã§ã™ã€‚å¥‘ç´„ã¯ {renewal} æ—¥ã«æ›´æ–°ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "ç¾åœ¨ã®ãƒ—ãƒ©ãƒ³ã¯ {premiumSubscription} ã§ã™ã€‚å¥‘ç´„ã¯ {renewal} æ—¥ã«æ›´æ–°ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "ã„ã„ãˆ";
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
		return "Roblox Premium 1000 ä¸€ãƒ¶æœˆ";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 ä¸€ãƒ¶æœˆ";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 ä¸€ãƒ¶æœˆ";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "ã‚‚ã£ã¨å£²ã‚‹";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã—ãŸãŸã‚";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã™ã‚‹";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã—ã¦ {upsellLinkStart}ã‚‚ã£ã¨ã‚²ãƒƒãƒˆã—ã‚ˆã†ï¼{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ã—ã¦ {upsellLinkStart}ã‚‚ã£ã¨ã‚²ãƒƒãƒˆã—ã‚ˆã†ï¼{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "å–å¼•";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "ãƒãƒªãƒ¥ãƒ¼ãƒ‘ãƒƒã‚¯";
	}

	protected override string _GetTemplateForLabelWantMoreRobux()
	{
		return "RobuxãŒã‚‚ã£ã¨å¿…è¦ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "ã¯ã„";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public override string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"ã€Œç¢ºå®šã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‹ã‚‰è„±é€€ã—ã¦ã€Roblox Premiumã®ç”³ã—è¾¼ã¿ãŒå¯èƒ½ã«ãªã‚Šã¾ã™ã€‚{newLine} 1åº¦ã ã‘ {robuxAmount} ã®ãƒšã‚¤ã‚¢ã‚¦ãƒˆã‚’å—ã‘ã‚‹ã“ã¨ãŒã§ãã¾ã™";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "ã€Œç¢ºå®šã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã‹ã‚‰è„±é€€ã—ã¦ã€Roblox Premiumã®ç”³ã—è¾¼ã¿ãŒå¯èƒ½ã«ãªã‚Šã¾ã™ã€‚{newLine} 1åº¦ã ã‘ {robuxAmount} ã®ãƒšã‚¤ã‚¢ã‚¦ãƒˆã‚’å—ã‘ã‚‹ã“ã¨ãŒã§ãã¾ã™";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³æƒ…å ±ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆä¸­ã«ã‚µãƒ¼ãƒãƒ¼ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã—ãŸç¾åœ¨ã®ãƒ—ãƒ©ãƒ³ã®æœŸé™ãŒåˆ‡ã‚Œã‚‹ã¾ã§ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã‚’è¡Œã†ã“ã¨ãŒã§ãã¾ã›ã‚“ã€‚{expiredDate}ã«ã‚‚ã†ä¸€åº¦ç”³ã—è¾¼ã¿ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã—ãŸç¾åœ¨ã®ãƒ—ãƒ©ãƒ³ã®æœŸé™ãŒåˆ‡ã‚Œã‚‹ã¾ã§ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã‚’è¡Œã†ã“ã¨ãŒã§ãã¾ã›ã‚“ã€‚{expiredDate}ã«ã‚‚ã†ä¸€åº¦ç”³ã—è¾¼ã¿ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"ã€Œç¢ºå®šã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€{renewalDate} ã‹ã‚‰ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã¾ãŸã¯ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³åˆ‡ã‚Šæ›¿ãˆã‚’è¡Œã†ã¾ã§ã€æ¯Žæœˆ {price} ã®èª²é‡‘ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "ã€Œç¢ºå®šã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€{renewalDate} ã‹ã‚‰ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã¾ãŸã¯ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³åˆ‡ã‚Šæ›¿ãˆã‚’è¡Œã†ã¾ã§ã€æ¯Žæœˆ {price} ã®èª²é‡‘ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã®Builders Clubæƒ…å ±ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ç¾åœ¨ã€æ°¸ä¹…Builders Clubã¨åŒç­‰ã®ãƒ‘ãƒƒã‚±ãƒ¼ã‚¸ãŒãªã„ãŸã‚ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®å¤‰æ›´ã¯ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã®æ›´æ–°ã‚’ç¢ºèª";
	}
}


}
