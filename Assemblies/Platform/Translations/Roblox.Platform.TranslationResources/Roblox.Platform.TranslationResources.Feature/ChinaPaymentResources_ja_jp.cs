namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_ja_jp : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "ã‚¨ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "ç¾åœ¨ã€Midas scriptã®èª­ã¿è¾¼ã¿ã«å•é¡ŒãŒã‚ã‚Šã¾ã™ã€‚å¾Œã§ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "WeChatã‚»ãƒƒã‚·ãƒ§ãƒ³ãŒæœŸé™åˆ‡ã‚Œã®ãŸã‚ã€ãƒªã‚¹ã‚¨ã‚¹ãƒˆã‚’å‡¦ç†ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ãƒ­ã‚°ã‚¢ã‚¦ãƒˆå¾Œã€ãƒ­ã‚°ã‚¤ãƒ³ã—ãªãŠã—ã¦ãã ã•ã„ã€‚";

	public ChinaPaymentResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "ã‚¨ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "ç¾åœ¨ã€Midas scriptã®èª­ã¿è¾¼ã¿ã«å•é¡ŒãŒã‚ã‚Šã¾ã™ã€‚å¾Œã§ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "WeChatã‚»ãƒƒã‚·ãƒ§ãƒ³ãŒæœŸé™åˆ‡ã‚Œã®ãŸã‚ã€ãƒªã‚¹ã‚¨ã‚¹ãƒˆã‚’å‡¦ç†ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ãƒ­ã‚°ã‚¢ã‚¦ãƒˆå¾Œã€ãƒ­ã‚°ã‚¤ãƒ³ã—ãªãŠã—ã¦ãã ã•ã„ã€‚";
	}
}


}
