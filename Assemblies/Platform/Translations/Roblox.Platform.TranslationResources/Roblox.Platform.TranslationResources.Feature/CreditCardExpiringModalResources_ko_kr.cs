namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_ko_kr : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "ë‹¤ì‹œ ì•Œë ¤ì£¼ì§€ ë§ˆì„¸ìš”";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "ì§€ê¸ˆ ì—…ë°ì´íŠ¸";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "Builders Club ë©¤ë²„ì‹­ì´ ë§Œë£Œë˜ì§€ ì•Šë„ë¡ ì‹ ìš©ì¹´ë“œ ì •ë³´ë¥¼ ì—…ë°ì´íŠ¸í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "ì‹ ìš©ì¹´ë“œ ìœ íš¨ê¸°ê°„";

	public CreditCardExpiringModalResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "ë‹¤ì‹œ ì•Œë ¤ì£¼ì§€ ë§ˆì„¸ìš”";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "ì§€ê¸ˆ ì—…ë°ì´íŠ¸";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"ì‹ ìš©ì¹´ë“œ ìœ íš¨ê¸°ê°„ì´ {expirationDate}ì— ë§Œë£Œë©ë‹ˆë‹¤!";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "ì‹ ìš©ì¹´ë“œ ìœ íš¨ê¸°ê°„ì´ {expirationDate}ì— ë§Œë£Œë©ë‹ˆë‹¤!";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "Builders Club ë©¤ë²„ì‹­ì´ ë§Œë£Œë˜ì§€ ì•Šë„ë¡ ì‹ ìš©ì¹´ë“œ ì •ë³´ë¥¼ ì—…ë°ì´íŠ¸í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "ì‹ ìš©ì¹´ë“œ ìœ íš¨ê¸°ê°„";
	}
}


}
