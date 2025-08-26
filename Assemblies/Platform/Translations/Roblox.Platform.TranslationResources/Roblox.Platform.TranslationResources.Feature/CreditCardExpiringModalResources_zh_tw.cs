namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_zh_tw : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "ä¸è¦å†æé†’æˆ‘";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "ç¾åœ¨æ›´æ–°";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "è«‹æ›´æ–°æ‚¨çš„ä¿¡ç”¨å¡è³‡æ–™ï¼Œé¿å…æ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼åˆ°æœŸï¼";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "ä¿¡ç”¨å¡åˆ°æœŸ";

	public CreditCardExpiringModalResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "ä¸è¦å†æé†’æˆ‘";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "ç¾åœ¨æ›´æ–°";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"æ‚¨çš„ä¿¡ç”¨å¡å°‡æ–¼ {expirationDate} åˆ°æœŸï¼";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "æ‚¨çš„ä¿¡ç”¨å¡å°‡æ–¼ {expirationDate} åˆ°æœŸï¼";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "è«‹æ›´æ–°æ‚¨çš„ä¿¡ç”¨å¡è³‡æ–™ï¼Œé¿å…æ‚¨çš„ Builders Club æœƒå“¡è³‡æ ¼åˆ°æœŸï¼";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "ä¿¡ç”¨å¡åˆ°æœŸ";
	}
}


}
