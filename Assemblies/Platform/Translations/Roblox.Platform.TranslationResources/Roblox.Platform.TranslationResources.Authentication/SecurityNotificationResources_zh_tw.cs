namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SecurityNotificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SecurityNotificationResources_zh_tw : SecurityNotificationResources_en_us, ISecurityNotificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Important"
	/// English String: "Important"
	/// </summary>
	public override string HeadingImportant => "é‡è¦";

	public SecurityNotificationResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationText"
	/// English String: "For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}."
	/// </summary>
	public override string DescriptionSecurityNotificationText(string aTagStartWithHref, string emailMailToLink, string hrefEnd, string emailText, string aTagEnd)
	{
		return $"ç‚ºäº†ç¶­è­·æ‚¨çš„å¸³è™Ÿçš„å®‰å…¨ï¼Œæ‚¨çš„ Roblox å¯†ç¢¼å·²è¢«é‡è£½ã€‚è‹¥è¦å–å›žæ‚¨çš„å¸³è™Ÿï¼Œè«‹åœ¨æ­¤é é¢çš„ã€Œæäº¤ã€æŒ‰éˆ•è¼¸å…¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€æˆ–æ‰‹æ©Ÿè™Ÿç¢¼ã€‚è‹¥æ‚¨çš„å¸³è™Ÿæ²’æœ‰é›»å­éƒµä»¶åœ°å€æˆ–æ‰‹æ©Ÿè™Ÿç¢¼ã€‚è«‹åœ¨ {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd} è¯çµ¡ Roblox å®¢æœäººå“¡ã€‚";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationText()
	{
		return "ç‚ºäº†ç¶­è­·æ‚¨çš„å¸³è™Ÿçš„å®‰å…¨ï¼Œæ‚¨çš„ Roblox å¯†ç¢¼å·²è¢«é‡è£½ã€‚è‹¥è¦å–å›žæ‚¨çš„å¸³è™Ÿï¼Œè«‹åœ¨æ­¤é é¢çš„ã€Œæäº¤ã€æŒ‰éˆ•è¼¸å…¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€æˆ–æ‰‹æ©Ÿè™Ÿç¢¼ã€‚è‹¥æ‚¨çš„å¸³è™Ÿæ²’æœ‰é›»å­éƒµä»¶åœ°å€æˆ–æ‰‹æ©Ÿè™Ÿç¢¼ã€‚è«‹åœ¨ {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd} è¯çµ¡ Roblox å®¢æœäººå“¡ã€‚";
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationTextWarning"
	/// English String: "Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised."
	/// </summary>
	public override string DescriptionSecurityNotificationTextWarning(string startSpan, string endSpan)
	{
		return $"è«‹é¸æ“‡{startSpan}å…¨æ–°{endSpan}ä¸”{startSpan}åªç”¨æ–¼ Roblox {endSpan}çš„å¯†ç¢¼ã€‚è«‹å‹¿åœ¨å…¶å®ƒç¶²ç«™ä¸Šä½¿ç”¨æ­¤å¯†ç¢¼ï¼Œä»¥å…æ‚¨çš„ Roblox å¸³è™Ÿé­åˆ°å…¥ä¾µã€‚";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationTextWarning()
	{
		return "è«‹é¸æ“‡{startSpan}å…¨æ–°{endSpan}ä¸”{startSpan}åªç”¨æ–¼ Roblox {endSpan}çš„å¯†ç¢¼ã€‚è«‹å‹¿åœ¨å…¶å®ƒç¶²ç«™ä¸Šä½¿ç”¨æ­¤å¯†ç¢¼ï¼Œä»¥å…æ‚¨çš„ Roblox å¸³è™Ÿé­åˆ°å…¥ä¾µã€‚";
	}

	protected override string _GetTemplateForHeadingImportant()
	{
		return "é‡è¦";
	}
}


}
