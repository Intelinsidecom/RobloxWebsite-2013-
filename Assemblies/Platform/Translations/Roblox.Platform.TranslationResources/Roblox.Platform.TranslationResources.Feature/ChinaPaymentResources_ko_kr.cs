namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_ko_kr : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "ì§€ê¸ˆ Midas ìŠ¤í¬ë¦½íŠ¸ë¥¼ ë¶ˆëŸ¬ì˜¤ëŠ” ë°ì— ë¬¸ì œê°€ ìžˆìŠµë‹ˆë‹¤. ìž ì‹œ í›„ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "WeChat ì„¸ì…˜ì´ ë§Œë£Œë˜ì–´ ìš”ì²­ì„ ì²˜ë¦¬í•  ìˆ˜ ì—†ì–´ìš”. ë¡œê·¸ì•„ì›ƒí•˜ì—¬ ë‹¤ì‹œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";

	public ChinaPaymentResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "ì§€ê¸ˆ Midas ìŠ¤í¬ë¦½íŠ¸ë¥¼ ë¶ˆëŸ¬ì˜¤ëŠ” ë°ì— ë¬¸ì œê°€ ìžˆìŠµë‹ˆë‹¤. ìž ì‹œ í›„ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "WeChat ì„¸ì…˜ì´ ë§Œë£Œë˜ì–´ ìš”ì²­ì„ ì²˜ë¦¬í•  ìˆ˜ ì—†ì–´ìš”. ë¡œê·¸ì•„ì›ƒí•˜ì—¬ ë‹¤ì‹œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";
	}
}


}
