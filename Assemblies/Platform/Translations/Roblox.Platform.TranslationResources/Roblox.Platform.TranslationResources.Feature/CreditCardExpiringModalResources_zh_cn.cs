namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_zh_cn : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
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
	public override string ActionUpdateNow => "ç«‹å³æ›´æ–°";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "è¯·æ›´æ–°æ‚¨çš„ä¿¡ç”¨å¡ä¿¡æ¯ï¼Œä»¥é¿å…ä½ çš„ Builders Club ä¼šå‘˜èµ„æ ¼å¤±æ•ˆï¼";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "ä¿¡ç”¨å¡å¤±æ•ˆæ—¥æœŸ";

	public CreditCardExpiringModalResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "ä¸è¦å†æé†’æˆ‘";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "ç«‹å³æ›´æ–°";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"æ‚¨çš„ä¿¡ç”¨å¡å°†äºŽ {expirationDate} å¤±æ•ˆï¼";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "æ‚¨çš„ä¿¡ç”¨å¡å°†äºŽ {expirationDate} å¤±æ•ˆï¼";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "è¯·æ›´æ–°æ‚¨çš„ä¿¡ç”¨å¡ä¿¡æ¯ï¼Œä»¥é¿å…ä½ çš„ Builders Club ä¼šå‘˜èµ„æ ¼å¤±æ•ˆï¼";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "ä¿¡ç”¨å¡å¤±æ•ˆæ—¥æœŸ";
	}
}


}
