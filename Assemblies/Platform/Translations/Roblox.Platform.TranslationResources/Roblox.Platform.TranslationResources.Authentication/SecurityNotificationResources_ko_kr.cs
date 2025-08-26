namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SecurityNotificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SecurityNotificationResources_ko_kr : SecurityNotificationResources_en_us, ISecurityNotificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Important"
	/// English String: "Important"
	/// </summary>
	public override string HeadingImportant => "ì¤‘ìš”";

	public SecurityNotificationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationText"
	/// English String: "For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}."
	/// </summary>
	public override string DescriptionSecurityNotificationText(string aTagStartWithHref, string emailMailToLink, string hrefEnd, string emailText, string aTagEnd)
	{
		return $"íšŒì›ë‹˜ ê³„ì •ì˜ ì•ˆì „ê³¼ ë³´ì•ˆì„ ìœ„í•´ ë¹„ë°€ë²ˆí˜¸ê°€ ìž¬ì„¤ì •ë˜ì—ˆìŠµë‹ˆë‹¤. ê³„ì •ì— ë‹¤ì‹œ ì ‘ê·¼í•˜ë ¤ë©´ ì´ íŽ˜ì´ì§€ì— ì´ë©”ì¼ ë˜ëŠ” ì „í™”ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ê³  ì œì¶œ ë²„íŠ¼ì„ í´ë¦­í•˜ì„¸ìš”. ê³„ì •ê³¼ ì—°ê²°ëœ ì´ë©”ì¼ ë˜ëŠ” ì „í™”ë²ˆí˜¸ê°€ ì—†ëŠ” ê²½ìš°, Roblox ì§€ì› ì„¼í„°{aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}ì— ë¬¸ì˜í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationText()
	{
		return "íšŒì›ë‹˜ ê³„ì •ì˜ ì•ˆì „ê³¼ ë³´ì•ˆì„ ìœ„í•´ ë¹„ë°€ë²ˆí˜¸ê°€ ìž¬ì„¤ì •ë˜ì—ˆìŠµë‹ˆë‹¤. ê³„ì •ì— ë‹¤ì‹œ ì ‘ê·¼í•˜ë ¤ë©´ ì´ íŽ˜ì´ì§€ì— ì´ë©”ì¼ ë˜ëŠ” ì „í™”ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ê³  ì œì¶œ ë²„íŠ¼ì„ í´ë¦­í•˜ì„¸ìš”. ê³„ì •ê³¼ ì—°ê²°ëœ ì´ë©”ì¼ ë˜ëŠ” ì „í™”ë²ˆí˜¸ê°€ ì—†ëŠ” ê²½ìš°, Roblox ì§€ì› ì„¼í„°{aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}ì— ë¬¸ì˜í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationTextWarning"
	/// English String: "Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised."
	/// </summary>
	public override string DescriptionSecurityNotificationTextWarning(string startSpan, string endSpan)
	{
		return $"Robloxì—ì„œë§Œ ì‚¬ìš©í•˜ëŠ” {startSpan}ìƒˆë¡­ê³ {endSpan} {startSpan}ë…íŠ¹í•œ{endSpan} ë¹„ë°€ë²ˆí˜¸ë¥¼ ë§Œë“¤ê³ , ë‹¤ë¥¸ ì‚¬ì´íŠ¸ì—ì„œëŠ” ì´ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”. íšŒì›ë‹˜ì˜ Roblox ê³„ì •ì„ ë³´í˜¸í•  ìˆ˜ ìžˆëŠ” ê°€ìž¥ ì¢‹ì€ ë°©ë²•ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationTextWarning()
	{
		return "Robloxì—ì„œë§Œ ì‚¬ìš©í•˜ëŠ” {startSpan}ìƒˆë¡­ê³ {endSpan} {startSpan}ë…íŠ¹í•œ{endSpan} ë¹„ë°€ë²ˆí˜¸ë¥¼ ë§Œë“¤ê³ , ë‹¤ë¥¸ ì‚¬ì´íŠ¸ì—ì„œëŠ” ì´ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”. íšŒì›ë‹˜ì˜ Roblox ê³„ì •ì„ ë³´í˜¸í•  ìˆ˜ ìžˆëŠ” ê°€ìž¥ ì¢‹ì€ ë°©ë²•ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingImportant()
	{
		return "ì¤‘ìš”";
	}
}


}
