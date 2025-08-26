namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_ja_jp : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "æ¬¡ã‹ã‚‰é€šçŸ¥ã‚’å—ã‘å–ã‚‰ãªã„";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "ä»Šã™ãæ›´æ–°";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒåˆ‡ã‚Œãªã„ã‚ˆã†ã«ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰æƒ…å ±ã‚’æ›´æ–°ã—ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã®æœ‰åŠ¹æœŸé™";

	public CreditCardExpiringModalResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "æ¬¡ã‹ã‚‰é€šçŸ¥ã‚’å—ã‘å–ã‚‰ãªã„";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "ä»Šã™ãæ›´æ–°";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã®æœ‰åŠ¹æœŸé™ã¯ {expirationDate} ã§ã™ï¼";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã®æœ‰åŠ¹æœŸé™ã¯ {expirationDate} ã§ã™ï¼";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "Builders Clubãƒ¡ãƒ³ãƒãƒ¼ã‚·ãƒƒãƒ—ã®æœŸé™ãŒåˆ‡ã‚Œãªã„ã‚ˆã†ã«ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰æƒ…å ±ã‚’æ›´æ–°ã—ã¦ãã ã•ã„ï¼";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã®æœ‰åŠ¹æœŸé™";
	}
}


}
