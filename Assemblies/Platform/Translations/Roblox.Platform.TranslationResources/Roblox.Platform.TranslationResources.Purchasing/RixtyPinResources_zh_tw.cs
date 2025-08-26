namespace Roblox.Platform.TranslationResources.Purchasing {
    /// <summary>

/// This class overrides RixtyPinResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RixtyPinResources_zh_tw : RixtyPinResources_en_us, IRixtyPinResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "ç¾åœ¨è³¼è²·";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "è³¼è²· Robux";

	/// <summary>
	/// Key: "Action.MoreBCOptions"
	/// English String: "More Builders Club Options"
	/// </summary>
	public override string ActionMoreBCOptions => "æ›´å¤š Builders Club é¸é …";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "å…Œæ›";

	/// <summary>
	/// Key: "Heading.AlreadyHaveCredit"
	/// English String: "You have Roblox Credit!"
	/// </summary>
	public override string HeadingAlreadyHaveCredit => "æ‚¨æœ‰ Roblox é»žæ•¸ï¼";

	/// <summary>
	/// Key: "Heading.BuyRobuxUsingRixty"
	/// English String: "Buy Robux using Rixty"
	/// </summary>
	public override string HeadingBuyRobuxUsingRixty => "ä»¥ Rixty è³¼è²· Robux";

	/// <summary>
	/// Key: "Heading.GetRobuxOrBcWithRixty"
	/// English String: "Get Robux or Builders Club with Rixty"
	/// </summary>
	public override string HeadingGetRobuxOrBcWithRixty => "ä»¥ Rixty å–å¾— Robux æˆ– Builders Club";

	/// <summary>
	/// Key: "Heading.GetRobuxWithRixty"
	/// English String: "Get Robux with Rixty"
	/// </summary>
	public override string HeadingGetRobuxWithRixty => "ä»¥ Rixty å–å¾— Robux";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "ä½¿ç”¨èªªæ˜Ž";

	/// <summary>
	/// Key: "Heading.PayWithRixty"
	/// English String: "Pay with Rixty"
	/// </summary>
	public override string HeadingPayWithRixty => "ä»¥ Rixty ä»˜æ¬¾";

	/// <summary>
	/// Key: "Heading.RedeemRixtyCards"
	/// English String: "Redeem Rixty Cards"
	/// </summary>
	public override string HeadingRedeemRixtyCards => "å…Œæ› Rixty é»žæ•¸å¡";

	/// <summary>
	/// Key: "Label.AlreadyHaveAccount"
	/// English String: "I already have a Rixty account"
	/// </summary>
	public override string LabelAlreadyHaveAccount => "æˆ‘æœ‰ Rixty å¸³è™Ÿ";

	/// <summary>
	/// Key: "Label.BuildersClubImage"
	/// Alternate text for Builders Club image
	/// English String: "Builders Club"
	/// </summary>
	public override string LabelBuildersClubImage => "Builders Club";

	/// <summary>
	/// Key: "Label.EnterPin"
	/// English String: "Enter PIN:"
	/// </summary>
	public override string LabelEnterPin => "è¼¸å…¥ PINï¼š";

	/// <summary>
	/// Key: "Label.EnterPinImage"
	/// English String: "Enter Your PIN"
	/// </summary>
	public override string LabelEnterPinImage => "è¼¸å…¥æ‚¨çš„ PIN";

	/// <summary>
	/// Key: "Label.FortyFiveDaysBC"
	/// English String: "45 Day Builders Club Extension - $10.00 (Existing BC members only)"
	/// </summary>
	public override string LabelFortyFiveDaysBC => "45 å¤© Builders Club çºŒç´„ï¼š$10.00ï¼ˆé™ Builders Club æœƒå“¡ï¼‰";

	/// <summary>
	/// Key: "Label.InstructionForCombineCards"
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string LabelInstructionForCombineCards => "åˆä½µé»žæ•¸å¡ï¼Œå–å¾—æ›´å¤š Roblox é»žæ•¸ã€‚";

	/// <summary>
	/// Key: "Label.InstructionForEnterPin"
	/// English String: "Enter your Rixty PIN."
	/// </summary>
	public override string LabelInstructionForEnterPin => "è¼¸å…¥æ‚¨çš„ Rixty PINã€‚";

	/// <summary>
	/// Key: "Label.OrUppercase"
	/// English String: "OR"
	/// </summary>
	public override string LabelOrUppercase => "æˆ–";

	/// <summary>
	/// Key: "Label.PinImageText"
	/// English String: "Your PIN is on your receipt"
	/// </summary>
	public override string LabelPinImageText => "æ‚¨çš„ PIN åœ¨æ‚¨çš„æ”¶æ“šä¸Š";

	/// <summary>
	/// Key: "Label.RixtyLogo"
	/// English String: "Rixty Logo"
	/// </summary>
	public override string LabelRixtyLogo => "Rixty æ¨™èªŒ";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.ThirtyDaysBC"
	/// English String: "30 Days of Builders Club - $10.00"
	/// </summary>
	public override string LabelThirtyDaysBC => "30 å¤© Builders Clubï¼š$10.00";

	/// <summary>
	/// Key: "Label.WhySpendCredit"
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string LabelWhySpendCredit => "æ‚¨å¯ä»¥å°‡ Roblox é»žæ•¸ç”¨åœ¨ Robux å’Œ Builders Clubï¼";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// English String: "Your Balance:"
	/// </summary>
	public override string LabelYourBalance => "æ‚¨çš„é¤˜é¡ï¼š";

	/// <summary>
	/// Key: "Message.AnErrorOccurred"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageAnErrorOccurred => "ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "Message.Failure"
	/// English String: "Failure"
	/// </summary>
	public override string MessageFailure => "å¤±æ•—";

	/// <summary>
	/// Key: "Message.Loading"
	/// English String: "Loading"
	/// </summary>
	public override string MessageLoading => "æ­£åœ¨è¼‰å…¥";

	/// <summary>
	/// Key: "Message.PinAlreadyRedeemed"
	/// English String: "PIN already redeemed"
	/// </summary>
	public override string MessagePinAlreadyRedeemed => "PIN å·²å…Œæ›";

	/// <summary>
	/// Key: "Message.RixtyUnavailable"
	/// English String: "Currently unavailable. Please try again later."
	/// </summary>
	public override string MessageRixtyUnavailable => "ç›®å‰ç„¡æ³•ä½¿ç”¨ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "æˆåŠŸ";

	/// <summary>
	/// Key: "Message.SuccessfulRedemption"
	/// English String: "You have successfully redeemed your PIN!"
	/// </summary>
	public override string MessageSuccessfulRedemption => "æˆåŠŸå…Œæ› PIN ï¼";

	public RixtyPinResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "ç¾åœ¨è³¼è²·";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "è³¼è²· Robux";
	}

	protected override string _GetTemplateForActionMoreBCOptions()
	{
		return "æ›´å¤š Builders Club é¸é …";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "å…Œæ›";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobux"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobux(string lineBreak)
	{
		return $"æœ‰äº† Rixtyï¼Œæ‚¨å°±å¯ä»¥ä½¿ç”¨ç¾é‡‘èˆ‡ç¡¬å¹£è³¼è²· Robux èˆ‡ Builders Clubã€‚{lineBreak}æ²’æœ‰ä¿¡ç”¨å¡å—Žï¼Ÿæ²’å•é¡Œ";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobux()
	{
		return "æœ‰äº† Rixtyï¼Œæ‚¨å°±å¯ä»¥ä½¿ç”¨ç¾é‡‘èˆ‡ç¡¬å¹£è³¼è²· Robux èˆ‡ Builders Clubã€‚{lineBreak}æ²’æœ‰ä¿¡ç”¨å¡å—Žï¼Ÿæ²’å•é¡Œ";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobuxAndPremium"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobuxAndPremium(string lineBreak)
	{
		return $"æœ‰äº† Rixtyï¼Œæ‚¨å°±å¯ä»¥ä½¿ç”¨ç¾é‡‘èˆ‡ç¡¬å¹£è³¼è²· Robux èˆ‡ Builders Clubã€‚{lineBreak}æ²’æœ‰ä¿¡ç”¨å¡å—Žï¼Ÿæ²’å•é¡Œ";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobuxAndPremium()
	{
		return "æœ‰äº† Rixtyï¼Œæ‚¨å°±å¯ä»¥ä½¿ç”¨ç¾é‡‘èˆ‡ç¡¬å¹£è³¼è²· Robux èˆ‡ Builders Clubã€‚{lineBreak}æ²’æœ‰ä¿¡ç”¨å¡å—Žï¼Ÿæ²’å•é¡Œ";
	}

	protected override string _GetTemplateForHeadingAlreadyHaveCredit()
	{
		return "æ‚¨æœ‰ Roblox é»žæ•¸ï¼";
	}

	protected override string _GetTemplateForHeadingBuyRobuxUsingRixty()
	{
		return "ä»¥ Rixty è³¼è²· Robux";
	}

	protected override string _GetTemplateForHeadingGetRobuxOrBcWithRixty()
	{
		return "ä»¥ Rixty å–å¾— Robux æˆ– Builders Club";
	}

	protected override string _GetTemplateForHeadingGetRobuxWithRixty()
	{
		return "ä»¥ Rixty å–å¾— Robux";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "ä½¿ç”¨èªªæ˜Ž";
	}

	protected override string _GetTemplateForHeadingPayWithRixty()
	{
		return "ä»¥ Rixty ä»˜æ¬¾";
	}

	protected override string _GetTemplateForHeadingRedeemRixtyCards()
	{
		return "å…Œæ› Rixty é»žæ•¸å¡";
	}

	protected override string _GetTemplateForLabelAlreadyHaveAccount()
	{
		return "æˆ‘æœ‰ Rixty å¸³è™Ÿ";
	}

	/// <summary>
	/// Key: "Label.BuildersClubExtensionExisting"
	/// For example, 45 Day Builders Club Extension - $10.00 (Existing BC members only)
	/// English String: "{numberOfDays} Day Builders Club Extension - {cost} (Existing BC members only)"
	/// </summary>
	public override string LabelBuildersClubExtensionExisting(string numberOfDays, string cost)
	{
		return $"{numberOfDays} å¤© Builders Club çºŒç´„ï¼š{cost}ï¼ˆé™ BC æœƒå“¡ï¼‰";
	}

	protected override string _GetTemplateForLabelBuildersClubExtensionExisting()
	{
		return "{numberOfDays} å¤© Builders Club çºŒç´„ï¼š{cost}ï¼ˆé™ BC æœƒå“¡ï¼‰";
	}

	protected override string _GetTemplateForLabelBuildersClubImage()
	{
		return "Builders Club";
	}

	/// <summary>
	/// Key: "Label.BuildersClubOffer"
	/// New purchase offer of builders club
	/// English String: "{numberOfDays} Days of Builders Club - {cost}"
	/// </summary>
	public override string LabelBuildersClubOffer(string numberOfDays, string cost)
	{
		return $"{numberOfDays} å¤© Builders Club çºŒç´„ï¼š{cost}";
	}

	protected override string _GetTemplateForLabelBuildersClubOffer()
	{
		return "{numberOfDays} å¤© Builders Club çºŒç´„ï¼š{cost}";
	}

	/// <summary>
	/// Key: "Label.BuyRobuxWithRixty"
	/// For example, "400 Robux for $4.95"
	/// English String: "{robuxAmount} Robux for {currencyAmount}"
	/// </summary>
	public override string LabelBuyRobuxWithRixty(string robuxAmount, string currencyAmount)
	{
		return $"ä»¥ {currencyAmount} è³¼è²· {robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelBuyRobuxWithRixty()
	{
		return "ä»¥ {currencyAmount} è³¼è²· {robuxAmount} Robux";
	}

	protected override string _GetTemplateForLabelEnterPin()
	{
		return "è¼¸å…¥ PINï¼š";
	}

	protected override string _GetTemplateForLabelEnterPinImage()
	{
		return "è¼¸å…¥æ‚¨çš„ PIN";
	}

	protected override string _GetTemplateForLabelFortyFiveDaysBC()
	{
		return "45 å¤© Builders Club çºŒç´„ï¼š$10.00ï¼ˆé™ Builders Club æœƒå“¡ï¼‰";
	}

	/// <summary>
	/// Key: "Label.GetPhysicalRixtyCard"
	/// English String: "{startLink}Go to your local store{endLink} and get a Rixty Card."
	/// </summary>
	public override string LabelGetPhysicalRixtyCard(string startLink, string endLink)
	{
		return $"{startLink}å‰å¾€å•†å®¶{endLink}è³¼è²· Rixty é»žæ•¸å¡ã€‚";
	}

	protected override string _GetTemplateForLabelGetPhysicalRixtyCard()
	{
		return "{startLink}å‰å¾€å•†å®¶{endLink}è³¼è²· Rixty é»žæ•¸å¡ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionForCombineCards()
	{
		return "åˆä½µé»žæ•¸å¡ï¼Œå–å¾—æ›´å¤š Roblox é»žæ•¸ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionForEnterPin()
	{
		return "è¼¸å…¥æ‚¨çš„ Rixty PINã€‚";
	}

	protected override string _GetTemplateForLabelOrUppercase()
	{
		return "æˆ–";
	}

	protected override string _GetTemplateForLabelPinImageText()
	{
		return "æ‚¨çš„ PIN åœ¨æ‚¨çš„æ”¶æ“šä¸Š";
	}

	protected override string _GetTemplateForLabelRixtyLogo()
	{
		return "Rixty æ¨™èªŒ";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelThirtyDaysBC()
	{
		return "30 å¤© Builders Clubï¼š$10.00";
	}

	protected override string _GetTemplateForLabelWhySpendCredit()
	{
		return "æ‚¨å¯ä»¥å°‡ Roblox é»žæ•¸ç”¨åœ¨ Robux å’Œ Builders Clubï¼";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "æ‚¨çš„é¤˜é¡ï¼š";
	}

	protected override string _GetTemplateForMessageAnErrorOccurred()
	{
		return "ç™¼ç”ŸéŒ¯èª¤";
	}

	protected override string _GetTemplateForMessageFailure()
	{
		return "å¤±æ•—";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "æ­£åœ¨è¼‰å…¥";
	}

	protected override string _GetTemplateForMessagePinAlreadyRedeemed()
	{
		return "PIN å·²å…Œæ›";
	}

	protected override string _GetTemplateForMessageRixtyUnavailable()
	{
		return "ç›®å‰ç„¡æ³•ä½¿ç”¨ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "æˆåŠŸ";
	}

	protected override string _GetTemplateForMessageSuccessfulRedemption()
	{
		return "æˆåŠŸå…Œæ› PIN ï¼";
	}
}


}
