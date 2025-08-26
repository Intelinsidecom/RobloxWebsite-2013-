namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionBought => "êµ¬ë§¤í•¨";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "ì§€ê¸ˆ êµ¬ë§¤í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux êµ¬ë§¤";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "Robux êµ¬ë§¤ ì‹œ 10% ë” íšë“";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "Roblox Premiumì— ê°€ìž…í•˜ë©´ ë§¤ì›” ì¼ì •í•œ Robuxë¥¼ ì§€ê¸‰ë°›ê²Œ ë˜ë©°, Robux êµ¬ë§¤ ì‹œ 10% ë³´ë„ˆìŠ¤ í˜œíƒì„ ë°›ì„ ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ë˜í•œ ì•„ì´í…œ êµ¬ìž…, íŒë§¤, ê±°ëž˜ì™€ ê°™ì€ Roblox ê²½ì œ ê¸°ëŠ¥ì„ ì‚¬ìš©í•  ìˆ˜ ìžˆì„ ë¿ ì•„ë‹ˆë¼, ê²Œìž„ ë‚´ íŒë§¤ ì‹œ ë³´ë‹¤ ë†’ì€ ë¹„ìœ¨ë¡œ ìˆ˜ìµì„ ì–»ì„ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "ì•„ì´í…œì„ ë‹¤ì‹œ íŒë§¤í•˜ì—¬ ì—¬ëŸ¬ë¶„ì˜ ìž‘í’ˆì— ëŒ€í•´ ë” ë§Žì€ Robuxë¥¼ íšë“í•´ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "ë‹¤ë¥¸ Premium ë©¤ë²„ì™€ ì•„ì´í…œ ê±°ëž˜";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robux êµ¬ë§¤";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "ì·¨ì†Œ í™•ì¸";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "ë” ë§Žì€ ê¸°ëŠ¥";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "Premium íšŒì›ì´ì…”ì„œ, Robux êµ¬ë§¤ ì‹œ í• ì¸ë°›ì„ ìˆ˜ ìžˆì–´ìš”!";

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
	public override string HeadingServerError => "ì„œë²„ ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "ê°€ìž… ì‹ ì²­ ë¶ˆê°€";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "ê°€ìž… ì—…ë°ì´íŠ¸ í™•ì¸";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "Builders Clubì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "Roblox Premiumìœ¼ë¡œ ì—…ê·¸ë ˆì´ë“œ";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "ì—…ê·¸ë ˆì´ë“œ ì´ìš© ë¶ˆê°€";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "Robuxê°€ 10% ë” ì¶”ê°€ë©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "ë” ë§Žì´ ë°›ìœ¼ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "ê°€ìž… ê¸°ë°˜ ì¶”ì²œ!";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "1íšŒ êµ¬ë§¤";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "Robux êµ¬ë§¤";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "í™•ì¸";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœ";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "Robux 10% í• ì¸ ë°›ê¸°";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "ë” ë§Žì€ Robux íšë“";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "Premium ê°€ìž…ì„ ê´€ë¦¬í•˜ë ¤ë©´, ë¸Œë¼ìš°ì €ì—ì„œ ì²­êµ¬ ì„¤ì •ìœ¼ë¡œ ì´ë™í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "ì•„ë‹ˆìš”";

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
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 1ê°œì›”";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 1ê°œì›”";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 1ê°œì›”";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "íŒë§¤ ê¸ˆì•¡ ì¦ê°€";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "ê°€ìž…í•˜ì…¨ìœ¼ë‹ˆê¹Œìš”";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "ê°€ìž…";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "ê±°ëž˜";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "ë°¸ë¥˜ íŒ©";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public override string LabelWantMoreRobux => "ë” ë§Žì€ Robuxë¥¼ ì›í•˜ì‹œë‚˜ìš”?";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "ì˜ˆ";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageGeneralError => "ê°€ìž… ì—…ë°ì´íŠ¸ ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "ê°€ìž… ì •ë³´ê°€ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "ê°€ìž… ì—…ë°ì´íŠ¸ ì¤‘ ì„œë²„ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "ë³¸ ì‚¬ìš©ìžì˜ Builders Club ì •ë³´ë¥¼ ì°¾ì„ ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "ì£„ì†¡í•©ë‹ˆë‹¤. í‰ìƒ Builders Clubê³¼ ëŒ€ë“±í•œ íŒ¨í‚¤ì§€ê°€ ì¡´ìž¬í•˜ì§€ ì•Šì•„ í”Œëžœì„ ë³€ê²½í•  ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "ê°€ìž… ì—…ë°ì´íŠ¸ í™•ì¸";

	public PremiumResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "êµ¬ë§¤í•¨";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "ì§€ê¸ˆ êµ¬ë§¤í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux êµ¬ë§¤";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robuxë¥¼ êµ¬ë§¤í•˜ë©´ ì•„ë°”íƒ€ ì—…ê·¸ë ˆì´ë“œ í˜¹ì€ íŠ¹ìˆ˜ ëŠ¥ë ¥ì„ êµ¬ë§¤í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.{lineBreak} Roblox Premiumì— ê°€ìž…í•´ ë§¤ì›” ì¶”ê°€ Robux ë° ë³´ë„ˆìŠ¤ ê¸°ëŠ¥ì„ íšë“í•˜ì„¸ìš”. Premium ë¹„ìš©ì€ ì·¨ì†Œí•  ë•Œê¹Œì§€ ë§¤ë‹¬ ë¶€ê³¼ë©ë‹ˆë‹¤. {learnMoreLinkStart}ì—¬ê¸°{learnMoreLinkEnd}ì—ì„œ ë” ìžì„¸ížˆ ì•Œì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Robuxë¥¼ êµ¬ë§¤í•˜ë©´ ì•„ë°”íƒ€ ì—…ê·¸ë ˆì´ë“œ í˜¹ì€ íŠ¹ìˆ˜ ëŠ¥ë ¥ì„ êµ¬ë§¤í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.{lineBreak} Roblox Premiumì— ê°€ìž…í•´ ë§¤ì›” ì¶”ê°€ Robux ë° ë³´ë„ˆìŠ¤ ê¸°ëŠ¥ì„ íšë“í•˜ì„¸ìš”. Premium ë¹„ìš©ì€ ì·¨ì†Œí•  ë•Œê¹Œì§€ ë§¤ë‹¬ ë¶€ê³¼ë©ë‹ˆë‹¤. {learnMoreLinkStart}ì—¬ê¸°{learnMoreLinkEnd}ì—ì„œ ë” ìžì„¸ížˆ ì•Œì•„ë³´ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Robuxë¥¼ íšë“í•˜ì—¬ ì•„ë°”íƒ€ë¥¼ ì—…ê·¸ë ˆì´ë“œí•˜ê±°ë‚˜ ê²Œìž„ ë‚´ íŠ¹ìˆ˜ ê¸°ëŠ¥ì„ êµ¬ë§¤í•´ë³´ì„¸ìš”! Robux íšë“ ë°©ë²•ì— ëŒ€í•œ ìžì„¸í•œ ë‚´ìš©ì€ {helpLinkStart}Robux ë„ì›€ë§ íŽ˜ì´ì§€{helpLinkEnd}ë¥¼ ì°¸ì¡°í•˜ì‹œê¸° ë°”ëžë‹ˆë‹¤. {paragraphBreaker}Roblox Premiumì„ êµ¬ë§¤í•˜ë©´ ê°™ì€ ê°€ê²©ì— ë” ë§Žì€ Robuxë¥¼ ì–»ìœ¼ì‹¤ ìˆ˜ ìžˆì–´ìš”. Roblox Premiumì€ ì·¨ì†Œí•  ë•Œê¹Œì§€ ë§¤ì›” ê²°ì œë©ë‹ˆë‹¤. {learnMoreLinkStart}ì—¬ê¸°ì—ì„œ ìžì„¸ížˆ ì•Œì•„ë³´ì„¸ìš”{learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "Robuxë¥¼ íšë“í•˜ì—¬ ì•„ë°”íƒ€ë¥¼ ì—…ê·¸ë ˆì´ë“œí•˜ê±°ë‚˜ ê²Œìž„ ë‚´ íŠ¹ìˆ˜ ê¸°ëŠ¥ì„ êµ¬ë§¤í•´ë³´ì„¸ìš”! Robux íšë“ ë°©ë²•ì— ëŒ€í•œ ìžì„¸í•œ ë‚´ìš©ì€ {helpLinkStart}Robux ë„ì›€ë§ íŽ˜ì´ì§€{helpLinkEnd}ë¥¼ ì°¸ì¡°í•˜ì‹œê¸° ë°”ëžë‹ˆë‹¤. {paragraphBreaker}Roblox Premiumì„ êµ¬ë§¤í•˜ë©´ ê°™ì€ ê°€ê²©ì— ë” ë§Žì€ Robuxë¥¼ ì–»ìœ¼ì‹¤ ìˆ˜ ìžˆì–´ìš”. Roblox Premiumì€ ì·¨ì†Œí•  ë•Œê¹Œì§€ ë§¤ì›” ê²°ì œë©ë‹ˆë‹¤. {learnMoreLinkStart}ì—¬ê¸°ì—ì„œ ìžì„¸ížˆ ì•Œì•„ë³´ì„¸ìš”{learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "Robux êµ¬ë§¤ ì‹œ 10% ë” íšë“";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premiumì€ ë§¤ì›” {costPrice}ì˜ ê°€ìž… ì„œë¹„ìŠ¤ë¡œ, êµ¬ë§¤ ì™„ë£Œ ì‹œ iTunes ê³„ì •ìœ¼ë¡œ ë¹„ìš©ì´ ì²­êµ¬ë©ë‹ˆë‹¤. Roblox Premiumì€ ë§¤ì›” ìžë™ìœ¼ë¡œ ê°±ì‹ ë˜ë©°, í•´ì§€í•˜ê³  ì‹¶ì„ ê²½ìš° í˜„ìž¬ì˜ ê°€ìž… ë§Œë£Œì¼ì„ ê¸°ì¤€ìœ¼ë¡œ ìµœì†Œ 24ì‹œê°„ ì´ì „ì— ìžë™ ê°±ì‹ ì„ ë„ë©´ ë©ë‹ˆë‹¤. í˜„ìž¬ ê°€ìž… ê¸°ê°„ ì¢…ë£Œ ì „ 24ì‹œê°„ ì´ë‚´ì— {renewalPrice}ì˜ ë¹„ìš©ì´ ì²­êµ¬ë˜ë©° ê°€ìž…ì´ ê°±ì‹ ë©ë‹ˆë‹¤. ê³„ì • ì„¤ì • íŽ˜ì´ì§€ì—ì„œ ê°€ìž…ì„ ê´€ë¦¬í•˜ê³  ìžë™ ê°±ì‹ ì„ ëŒ ìˆ˜ ìžˆìŠµë‹ˆë‹¤. 18ì„¸ ë¯¸ë§Œì˜ ì‚¬ìš©ìžë¼ë©´ êµ¬ë§¤í•˜ê¸° ì „ì— ë¶€ëª¨ ë˜ëŠ” ë²•ì  ë³´í˜¸ìžì˜ í—ˆë½ì„ ë°›ì•„ì•¼ í•˜ë©°, í—ˆë½ ì—†ì´ êµ¬ë§¤í•˜ë©´ ê³„ì •ì´ ì‚­ì œë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premiumì€ ë§¤ì›” {costPrice}ì˜ ê°€ìž… ì„œë¹„ìŠ¤ë¡œ, êµ¬ë§¤ ì™„ë£Œ ì‹œ iTunes ê³„ì •ìœ¼ë¡œ ë¹„ìš©ì´ ì²­êµ¬ë©ë‹ˆë‹¤. Roblox Premiumì€ ë§¤ì›” ìžë™ìœ¼ë¡œ ê°±ì‹ ë˜ë©°, í•´ì§€í•˜ê³  ì‹¶ì„ ê²½ìš° í˜„ìž¬ì˜ ê°€ìž… ë§Œë£Œì¼ì„ ê¸°ì¤€ìœ¼ë¡œ ìµœì†Œ 24ì‹œê°„ ì´ì „ì— ìžë™ ê°±ì‹ ì„ ë„ë©´ ë©ë‹ˆë‹¤. í˜„ìž¬ ê°€ìž… ê¸°ê°„ ì¢…ë£Œ ì „ 24ì‹œê°„ ì´ë‚´ì— {renewalPrice}ì˜ ë¹„ìš©ì´ ì²­êµ¬ë˜ë©° ê°€ìž…ì´ ê°±ì‹ ë©ë‹ˆë‹¤. ê³„ì • ì„¤ì • íŽ˜ì´ì§€ì—ì„œ ê°€ìž…ì„ ê´€ë¦¬í•˜ê³  ìžë™ ê°±ì‹ ì„ ëŒ ìˆ˜ ìžˆìŠµë‹ˆë‹¤. 18ì„¸ ë¯¸ë§Œì˜ ì‚¬ìš©ìžë¼ë©´ êµ¬ë§¤í•˜ê¸° ì „ì— ë¶€ëª¨ ë˜ëŠ” ë²•ì  ë³´í˜¸ìžì˜ í—ˆë½ì„ ë°›ì•„ì•¼ í•˜ë©°, í—ˆë½ ì—†ì´ êµ¬ë§¤í•˜ë©´ ê³„ì •ì´ ì‚­ì œë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public override string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox Premiumì€ {durationType} {costPrice}ì˜ ê°€ìž… ì„œë¹„ìŠ¤ë¡œ, êµ¬ë§¤ ì™„ë£Œ ì‹œ iTunes ê³„ì •ìœ¼ë¡œ ë¹„ìš©ì´ ì²­êµ¬ë©ë‹ˆë‹¤. Roblox Premiumì€ ë§¤ì›” ìžë™ìœ¼ë¡œ ê°±ì‹ ë˜ë©°, í•´ì§€í•˜ê³  ì‹¶ì„ ê²½ìš° í˜„ìž¬ì˜ ê°€ìž… ë§Œë£Œì¼ì„ ê¸°ì¤€ìœ¼ë¡œ ìµœì†Œ 24ì‹œê°„ ì´ì „ì— ìžë™ ê°±ì‹ ì„ ë„ë©´ ë©ë‹ˆë‹¤. í˜„ìž¬ ê°€ìž… ê¸°ê°„ ì¢…ë£Œ ì „ 24ì‹œê°„ ì´ë‚´ì— {renewalPrice}ì˜ ë¹„ìš©ì´ ì²­êµ¬ë˜ë©° ê°€ìž…ì´ ê°±ì‹ ë©ë‹ˆë‹¤. ê³„ì • ì„¤ì • íŽ˜ì´ì§€ì—ì„œ ê°€ìž…ì„ ê´€ë¦¬í•˜ê³  ìžë™ ê°±ì‹ ì„ ëŒ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox Premiumì€ {durationType} {costPrice}ì˜ ê°€ìž… ì„œë¹„ìŠ¤ë¡œ, êµ¬ë§¤ ì™„ë£Œ ì‹œ iTunes ê³„ì •ìœ¼ë¡œ ë¹„ìš©ì´ ì²­êµ¬ë©ë‹ˆë‹¤. Roblox Premiumì€ ë§¤ì›” ìžë™ìœ¼ë¡œ ê°±ì‹ ë˜ë©°, í•´ì§€í•˜ê³  ì‹¶ì„ ê²½ìš° í˜„ìž¬ì˜ ê°€ìž… ë§Œë£Œì¼ì„ ê¸°ì¤€ìœ¼ë¡œ ìµœì†Œ 24ì‹œê°„ ì´ì „ì— ìžë™ ê°±ì‹ ì„ ë„ë©´ ë©ë‹ˆë‹¤. í˜„ìž¬ ê°€ìž… ê¸°ê°„ ì¢…ë£Œ ì „ 24ì‹œê°„ ì´ë‚´ì— {renewalPrice}ì˜ ë¹„ìš©ì´ ì²­êµ¬ë˜ë©° ê°€ìž…ì´ ê°±ì‹ ë©ë‹ˆë‹¤. ê³„ì • ì„¤ì • íŽ˜ì´ì§€ì—ì„œ ê°€ìž…ì„ ê´€ë¦¬í•˜ê³  ìžë™ ê°±ì‹ ì„ ëŒ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"Robuxë¥¼ êµ¬ë§¤í•˜ë©´, ì´ë¥¼ ì‚¬ìš©í•˜ê¸° ìœ„í•´ ì œí•œì ì´ê³  í™˜ë¶ˆ ë° ì–‘ë„ê°€ ë¶ˆê°€ëŠ¥í•˜ë©°, ì² íšŒ ê°€ëŠ¥í•œ ë¼ì´ì„ ìŠ¤ë¥¼ ë°›ê²Œ ë©ë‹ˆë‹¤. Robuxì—ëŠ” ì‹¤ì œ í†µí™” ê°€ì¹˜ê°€ ì—†ìŠµë‹ˆë‹¤. ê·¸ ì™¸ ì œí•œ ì‚¬í•­ì€ {termsLinkStart}ì´ìš© ì•½ê´€{termsLinkEnd}ì—ì„œ í™•ì¸í•˜ì„¸ìš”. 18ì„¸ ë¯¸ë§Œì˜ ì‚¬ìš©ìžë¼ë©´ êµ¬ë§¤í•˜ê¸° ì „ì— ë¶€ëª¨ ë˜ëŠ” ë²•ì  ë³´í˜¸ìžì˜ í—ˆë½ì„ ë°›ì•„ì•¼ í•˜ë©°, í—ˆë½ ì—†ì´ êµ¬ë§¤í•˜ë©´ ê³„ì •ì´ ì‚­ì œë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "Robuxë¥¼ êµ¬ë§¤í•˜ë©´, ì´ë¥¼ ì‚¬ìš©í•˜ê¸° ìœ„í•´ ì œí•œì ì´ê³  í™˜ë¶ˆ ë° ì–‘ë„ê°€ ë¶ˆê°€ëŠ¥í•˜ë©°, ì² íšŒ ê°€ëŠ¥í•œ ë¼ì´ì„ ìŠ¤ë¥¼ ë°›ê²Œ ë©ë‹ˆë‹¤. Robuxì—ëŠ” ì‹¤ì œ í†µí™” ê°€ì¹˜ê°€ ì—†ìŠµë‹ˆë‹¤. ê·¸ ì™¸ ì œí•œ ì‚¬í•­ì€ {termsLinkStart}ì´ìš© ì•½ê´€{termsLinkEnd}ì—ì„œ í™•ì¸í•˜ì„¸ìš”. 18ì„¸ ë¯¸ë§Œì˜ ì‚¬ìš©ìžë¼ë©´ êµ¬ë§¤í•˜ê¸° ì „ì— ë¶€ëª¨ ë˜ëŠ” ë²•ì  ë³´í˜¸ìžì˜ í—ˆë½ì„ ë°›ì•„ì•¼ í•˜ë©°, í—ˆë½ ì—†ì´ êµ¬ë§¤í•˜ë©´ ê³„ì •ì´ ì‚­ì œë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking â€œSubmit Orderâ€ (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking â€œCancel membershipâ€ on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"18ì„¸ ë¯¸ë§Œì˜ ì‚¬ìš©ìžë¼ë©´ Premiumì„ êµ¬ë§¤í•˜ê¸° ì „ì— ë¶€ëª¨ ë˜ëŠ” ë²•ì  ë³´í˜¸ìžì˜ í—ˆë½ì„ ë°›ì•„ì•¼ í•˜ë©°, í—ˆë½ ì—†ì´ êµ¬ë§¤í•˜ë©´ ê³„ì •ì´ ì‚­ì œë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. 'ì£¼ë¬¸ í™•ì¸'ì„ í´ë¦­í•˜ë©´ íšŒì›ë‹˜ì€ (1) ê°€ìž…ì„ ì·¨ì†Œí•  ë•Œê¹Œì§€ Robloxê°€ ê³„ì •ì— ìš”ê¸ˆì„ ì²­êµ¬í•  ìˆ˜ ìžˆëŠ” ê¶Œí•œì„ ë¶€ì—¬í•˜ë©°, (2) {termsLinkStart}ì´ìš© ì•½ê´€{termsLinkEnd} ë° {privacyLinkStart}ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨{privatyLinkEnd}ì„ ì´í•´í•˜ê³  ì´ì— ë™ì˜í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë©ë‹ˆë‹¤. ì„¤ì • íŽ˜ì´ì§€ì˜ {billingLinkStart}ì²­êµ¬ íƒ­{billingLinkEnd}ì—ì„œ 'ë©¤ë²„ì‹­ ì·¨ì†Œ'ë¥¼ í´ë¦­í•˜ë©´ ì–¸ì œë“ ì§€ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ì·¨ì†Œí•œ í›„ì—ë„ í˜„ìž¬ ì²­êµ¬ ê¸°ê°„ì— ëŒ€í•œ ë¹„ìš©ì€ ê·¸ëŒ€ë¡œ ìœ ì§€ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "18ì„¸ ë¯¸ë§Œì˜ ì‚¬ìš©ìžë¼ë©´ Premiumì„ êµ¬ë§¤í•˜ê¸° ì „ì— ë¶€ëª¨ ë˜ëŠ” ë²•ì  ë³´í˜¸ìžì˜ í—ˆë½ì„ ë°›ì•„ì•¼ í•˜ë©°, í—ˆë½ ì—†ì´ êµ¬ë§¤í•˜ë©´ ê³„ì •ì´ ì‚­ì œë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. 'ì£¼ë¬¸ í™•ì¸'ì„ í´ë¦­í•˜ë©´ íšŒì›ë‹˜ì€ (1) ê°€ìž…ì„ ì·¨ì†Œí•  ë•Œê¹Œì§€ Robloxê°€ ê³„ì •ì— ìš”ê¸ˆì„ ì²­êµ¬í•  ìˆ˜ ìžˆëŠ” ê¶Œí•œì„ ë¶€ì—¬í•˜ë©°, (2) {termsLinkStart}ì´ìš© ì•½ê´€{termsLinkEnd} ë° {privacyLinkStart}ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨{privatyLinkEnd}ì„ ì´í•´í•˜ê³  ì´ì— ë™ì˜í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë©ë‹ˆë‹¤. ì„¤ì • íŽ˜ì´ì§€ì˜ {billingLinkStart}ì²­êµ¬ íƒ­{billingLinkEnd}ì—ì„œ 'ë©¤ë²„ì‹­ ì·¨ì†Œ'ë¥¼ í´ë¦­í•˜ë©´ ì–¸ì œë“ ì§€ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ì·¨ì†Œí•œ í›„ì—ë„ í˜„ìž¬ ì²­êµ¬ ê¸°ê°„ì— ëŒ€í•œ ë¹„ìš©ì€ ê·¸ëŒ€ë¡œ ìœ ì§€ë©ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking â€œSubmit Orderâ€ (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking â€œCancel membershipâ€ on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"18ì„¸ ë¯¸ë§Œì˜ ì‚¬ìš©ìžë¼ë©´ Premiumì„ êµ¬ë§¤í•˜ê¸° ì „ì— ë¶€ëª¨ ë˜ëŠ” ë²•ì  ë³´í˜¸ìžì˜ í—ˆë½ì„ ë°›ì•„ì•¼ í•˜ë©°, í—ˆë½ ì—†ì´ êµ¬ë§¤í•˜ë©´ ê³„ì •ì´ ì‚­ì œë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. 'ì£¼ë¬¸ í™•ì¸'ì„ í´ë¦­í•˜ë©´ íšŒì›ë‹˜ì€ (1) ê°€ìž…ì„ ì·¨ì†Œí•  ë•Œê¹Œì§€ Robloxê°€ ê³„ì •ì— ìš”ê¸ˆì„ ì²­êµ¬í•  ìˆ˜ ìžˆëŠ” ê¶Œí•œì„ ë¶€ì—¬í•˜ë©°, (2) {teamOfUseLinkStart}ì´ìš© ì•½ê´€{teamOfUseLinkEnd} ë° {privacyPolicyLinkStart}ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨{privacyPolicyLinkEnd}ì„ ì´í•´í•˜ê³  ì´ì— ë™ì˜í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë©ë‹ˆë‹¤. ì„¤ì • íŽ˜ì´ì§€ì˜ {billingTabLinkStart}ì²­êµ¬ íƒ­{billingTabLinkEnd}ì—ì„œ 'ë©¤ë²„ì‹­ ì·¨ì†Œ'ë¥¼ í´ë¦­í•˜ë©´ ì–¸ì œë“ ì§€ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ì·¨ì†Œí•œ í›„ì—ë„ í˜„ìž¬ ì²­êµ¬ ê¸°ê°„ì— ëŒ€í•œ ë¹„ìš©ì€ ê·¸ëŒ€ë¡œ ìœ ì§€ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "18ì„¸ ë¯¸ë§Œì˜ ì‚¬ìš©ìžë¼ë©´ Premiumì„ êµ¬ë§¤í•˜ê¸° ì „ì— ë¶€ëª¨ ë˜ëŠ” ë²•ì  ë³´í˜¸ìžì˜ í—ˆë½ì„ ë°›ì•„ì•¼ í•˜ë©°, í—ˆë½ ì—†ì´ êµ¬ë§¤í•˜ë©´ ê³„ì •ì´ ì‚­ì œë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. 'ì£¼ë¬¸ í™•ì¸'ì„ í´ë¦­í•˜ë©´ íšŒì›ë‹˜ì€ (1) ê°€ìž…ì„ ì·¨ì†Œí•  ë•Œê¹Œì§€ Robloxê°€ ê³„ì •ì— ìš”ê¸ˆì„ ì²­êµ¬í•  ìˆ˜ ìžˆëŠ” ê¶Œí•œì„ ë¶€ì—¬í•˜ë©°, (2) {teamOfUseLinkStart}ì´ìš© ì•½ê´€{teamOfUseLinkEnd} ë° {privacyPolicyLinkStart}ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨{privacyPolicyLinkEnd}ì„ ì´í•´í•˜ê³  ì´ì— ë™ì˜í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë©ë‹ˆë‹¤. ì„¤ì • íŽ˜ì´ì§€ì˜ {billingTabLinkStart}ì²­êµ¬ íƒ­{billingTabLinkEnd}ì—ì„œ 'ë©¤ë²„ì‹­ ì·¨ì†Œ'ë¥¼ í´ë¦­í•˜ë©´ ì–¸ì œë“ ì§€ ì·¨ì†Œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ì·¨ì†Œí•œ í›„ì—ë„ í˜„ìž¬ ì²­êµ¬ ê¸°ê°„ì— ëŒ€í•œ ë¹„ìš©ì€ ê·¸ëŒ€ë¡œ ìœ ì§€ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "Roblox Premiumì— ê°€ìž…í•˜ë©´ ë§¤ì›” ì¼ì •í•œ Robuxë¥¼ ì§€ê¸‰ë°›ê²Œ ë˜ë©°, Robux êµ¬ë§¤ ì‹œ 10% ë³´ë„ˆìŠ¤ í˜œíƒì„ ë°›ì„ ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ë˜í•œ ì•„ì´í…œ êµ¬ìž…, íŒë§¤, ê±°ëž˜ì™€ ê°™ì€ Roblox ê²½ì œ ê¸°ëŠ¥ì„ ì‚¬ìš©í•  ìˆ˜ ìžˆì„ ë¿ ì•„ë‹ˆë¼, ê²Œìž„ ë‚´ íŒë§¤ ì‹œ ë³´ë‹¤ ë†’ì€ ë¹„ìœ¨ë¡œ ìˆ˜ìµì„ ì–»ì„ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "ì•„ì´í…œì„ ë‹¤ì‹œ íŒë§¤í•˜ì—¬ ì—¬ëŸ¬ë¶„ì˜ ìž‘í’ˆì— ëŒ€í•´ ë” ë§Žì€ Robuxë¥¼ íšë“í•´ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "ë‹¤ë¥¸ Premium ë©¤ë²„ì™€ ì•„ì´í…œ ê±°ëž˜";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robux êµ¬ë§¤";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "ì·¨ì†Œ í™•ì¸";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "ë” ë§Žì€ ê¸°ëŠ¥";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "Premium íšŒì›ì´ì…”ì„œ, Robux êµ¬ë§¤ ì‹œ í• ì¸ë°›ì„ ìˆ˜ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "ì„œë²„ ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "ê°€ìž… ì‹ ì²­ ë¶ˆê°€";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "ê°€ìž… ì—…ë°ì´íŠ¸ í™•ì¸";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "Builders Clubì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "Roblox Premiumìœ¼ë¡œ ì—…ê·¸ë ˆì´ë“œ";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "ì—…ê·¸ë ˆì´ë“œ ì´ìš© ë¶ˆê°€";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "Robuxê°€ 10% ë” ì¶”ê°€ë©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "ë” ë§Žì´ ë°›ìœ¼ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "ê°€ìž… ê¸°ë°˜ ì¶”ì²œ!";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "1íšŒ êµ¬ë§¤";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "Robux êµ¬ë§¤";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœ";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "Robux 10% í• ì¸ ë°›ê¸°";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "ë” ë§Žì€ Robux íšë“";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "Premium ê°€ìž…ì„ ê´€ë¦¬í•˜ë ¤ë©´, ë¸Œë¼ìš°ì €ì—ì„œ ì²­êµ¬ ì„¤ì •ìœ¼ë¡œ ì´ë™í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœì€ {premiumSubscription}ìž…ë‹ˆë‹¤. ì¢…ë£Œì¼ì€ {expirationDate}ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœì€ {premiumSubscription}ìž…ë‹ˆë‹¤. ì¢…ë£Œì¼ì€ {expirationDate}ìž…ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœì€ {premiumSubscription}ì´ë©°, {expirationDate}ì— ì¢…ë£Œë©ë‹ˆë‹¤. ë©¤ë²„ì‹­ ì¢…ë£Œ ì´í›„ ê°™ì€ í”Œëžœì— ìž¬ê°€ìž…í•  ìˆ˜ë„ ìžˆê³ , ìƒˆë¡œìš´ í”Œëžœì„ ì„ íƒí•˜ì‹¤ ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœì€ {premiumSubscription}ì´ë©°, {expirationDate}ì— ì¢…ë£Œë©ë‹ˆë‹¤. ë©¤ë²„ì‹­ ì¢…ë£Œ ì´í›„ ê°™ì€ í”Œëžœì— ìž¬ê°€ìž…í•  ìˆ˜ë„ ìžˆê³ , ìƒˆë¡œìš´ í”Œëžœì„ ì„ íƒí•˜ì‹¤ ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœì€ {premiumSubscription}ìž…ë‹ˆë‹¤. ê°±ì‹ ì¼ì€ {renewal}ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "íšŒì›ë‹˜ì˜ í˜„ìž¬ í”Œëžœì€ {premiumSubscription}ìž…ë‹ˆë‹¤. ê°±ì‹ ì¼ì€ {renewal}ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "ì•„ë‹ˆìš”";
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
		return $"{robux}{subTextStart}/ì›”{subTextEnd}";
	}

	protected override string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart}/ì›”{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public override string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount}/ì›”";
	}

	protected override string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount}/ì›”";
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
		return "Roblox Premium 1000 1ê°œì›”";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 1ê°œì›”";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 1ê°œì›”";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "íŒë§¤ ê¸ˆì•¡ ì¦ê°€";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "ê°€ìž…í•˜ì…¨ìœ¼ë‹ˆê¹Œìš”";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "ê°€ìž…";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"{upsellLinkStart}ì— ê°€ìž…í•´ ë” ìžì„¸ížˆ ì•Œì•„ë³´ì„¸ìš”! {upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "{upsellLinkStart}ì— ê°€ìž…í•´ ë” ìžì„¸ížˆ ì•Œì•„ë³´ì„¸ìš”! {upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "ê±°ëž˜";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "ë°¸ë¥˜ íŒ©";
	}

	protected override string _GetTemplateForLabelWantMoreRobux()
	{
		return "ë” ë§Žì€ Robuxë¥¼ ì›í•˜ì‹œë‚˜ìš”?";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "ì˜ˆ";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public override string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"'í™•ì¸'ì„ í´ë¦­í•˜ë©´ í˜„ Builders Club ë©¤ë²„ì‹­ì´ ì¢…ë£Œë˜ì–´ Roblox Premiumì— ê°€ìž…í•  ìˆ˜ ìžˆì–´ìš”.{newLine} ì¼ì‹œë¶ˆë¡œ {robuxAmount}ì´(ê°€) ì²­êµ¬ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "'í™•ì¸'ì„ í´ë¦­í•˜ë©´ í˜„ Builders Club ë©¤ë²„ì‹­ì´ ì¢…ë£Œë˜ì–´ Roblox Premiumì— ê°€ìž…í•  ìˆ˜ ìžˆì–´ìš”.{newLine} ì¼ì‹œë¶ˆë¡œ {robuxAmount}ì´(ê°€) ì²­êµ¬ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "ê°€ìž… ì—…ë°ì´íŠ¸ ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "ê°€ìž… ì •ë³´ê°€ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "ê°€ìž… ì—…ë°ì´íŠ¸ ì¤‘ ì„œë²„ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"ì£„ì†¡í•©ë‹ˆë‹¤. ì·¨ì†Œí•œ í˜„ìž¬ í”Œëžœì˜ ë§Œë£Œì¼ê¹Œì§€ ê°€ìž… ì‹ ì²­ì„ í•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. {expiredDate}ì— ë‹¤ì‹œ ê°€ìž… ì‹ ì²­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ì·¨ì†Œí•œ í˜„ìž¬ í”Œëžœì˜ ë§Œë£Œì¼ê¹Œì§€ ê°€ìž… ì‹ ì²­ì„ í•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. {expiredDate}ì— ë‹¤ì‹œ ê°€ìž… ì‹ ì²­í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"'í™•ì¸'ì„ í´ë¦­í•˜ë©´ ê°€ìž…ì„ ì·¨ì†Œí•˜ê±°ë‚˜ ì „í™˜í•˜ê¸° ì „ê¹Œì§€ {renewalDate}ë¶€í„° ë§¤ì›” {price}ì˜ ê¸ˆì•¡ì´ ë¶€ê³¼ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "'í™•ì¸'ì„ í´ë¦­í•˜ë©´ ê°€ìž…ì„ ì·¨ì†Œí•˜ê±°ë‚˜ ì „í™˜í•˜ê¸° ì „ê¹Œì§€ {renewalDate}ë¶€í„° ë§¤ì›” {price}ì˜ ê¸ˆì•¡ì´ ë¶€ê³¼ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "ë³¸ ì‚¬ìš©ìžì˜ Builders Club ì •ë³´ë¥¼ ì°¾ì„ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. í‰ìƒ Builders Clubê³¼ ëŒ€ë“±í•œ íŒ¨í‚¤ì§€ê°€ ì¡´ìž¬í•˜ì§€ ì•Šì•„ í”Œëžœì„ ë³€ê²½í•  ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "ê°€ìž… ì—…ë°ì´íŠ¸ í™•ì¸";
	}
}


}
