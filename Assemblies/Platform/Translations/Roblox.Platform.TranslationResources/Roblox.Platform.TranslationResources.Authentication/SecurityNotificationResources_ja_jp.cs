namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SecurityNotificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SecurityNotificationResources_ja_jp : SecurityNotificationResources_en_us, ISecurityNotificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Important"
	/// English String: "Important"
	/// </summary>
	public override string HeadingImportant => "é‡è¦";

	public SecurityNotificationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationText"
	/// English String: "For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}."
	/// </summary>
	public override string DescriptionSecurityNotificationText(string aTagStartWithHref, string emailMailToLink, string hrefEnd, string emailText, string aTagEnd)
	{
		return $"ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å®‰å…¨æ€§ã¨ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã®ãŸã‚ã€Robloxãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒãƒªã‚»ãƒƒãƒˆã•ã‚Œã¾ã—ãŸã€‚ ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’å–ã‚Šæˆ»ã™ã«ã¯ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‹é›»è©±ç•ªå·ã‚’å…¥åŠ›ã—ã¦ã€ã“ã®ãƒšãƒ¼ã‚¸ã®é€ä¿¡ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚ã“ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«é–¢é€£ã¥ã‘ã‚‰ã‚ŒãŸãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‹é›»è©±ç•ªå·ãŒãªã„å ´åˆã¯ã€Robloxã‚«ã‚¹ã‚¿ãƒžãƒ¼ã‚µãƒ¼ãƒ“ã‚¹\n{aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd} ã«ã”é€£çµ¡ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationText()
	{
		return "ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®å®‰å…¨æ€§ã¨ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã®ãŸã‚ã€Robloxãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒãƒªã‚»ãƒƒãƒˆã•ã‚Œã¾ã—ãŸã€‚ ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¸ã®ã‚¢ã‚¯ã‚»ã‚¹ã‚’å–ã‚Šæˆ»ã™ã«ã¯ã€ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‹é›»è©±ç•ªå·ã‚’å…¥åŠ›ã—ã¦ã€ã“ã®ãƒšãƒ¼ã‚¸ã®é€ä¿¡ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚ã“ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«é–¢é€£ã¥ã‘ã‚‰ã‚ŒãŸãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‹é›»è©±ç•ªå·ãŒãªã„å ´åˆã¯ã€Robloxã‚«ã‚¹ã‚¿ãƒžãƒ¼ã‚µãƒ¼ãƒ“ã‚¹\n{aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd} ã«ã”é€£çµ¡ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationTextWarning"
	/// English String: "Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised."
	/// </summary>
	public override string DescriptionSecurityNotificationTextWarning(string startSpan, string endSpan)
	{
		return $"ã¾ã£ãŸã{startSpan}æ–°ã—ã„{endSpan}Robloxã ã‘ã®{startSpan}ãƒ¦ãƒ‹ãƒ¼ã‚¯{endSpan}ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’é¸ã‚“ã§ãã ã•ã„ã€‚ã“ã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ä»–ã®ã‚µã‚¤ãƒˆã§ã¯ä½¿ã‚ãªã„ã§ãã ã•ã„ã€‚ã“ã‚ŒãŒãŠæŒã¡ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ä¹—ã£å–ã‚Šã‚’é˜²ããƒ™ã‚¹ãƒˆãªæ–¹æ³•ã§ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationTextWarning()
	{
		return "ã¾ã£ãŸã{startSpan}æ–°ã—ã„{endSpan}Robloxã ã‘ã®{startSpan}ãƒ¦ãƒ‹ãƒ¼ã‚¯{endSpan}ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’é¸ã‚“ã§ãã ã•ã„ã€‚ã“ã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ä»–ã®ã‚µã‚¤ãƒˆã§ã¯ä½¿ã‚ãªã„ã§ãã ã•ã„ã€‚ã“ã‚ŒãŒãŠæŒã¡ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ä¹—ã£å–ã‚Šã‚’é˜²ããƒ™ã‚¹ãƒˆãªæ–¹æ³•ã§ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingImportant()
	{
		return "é‡è¦";
	}
}


}
