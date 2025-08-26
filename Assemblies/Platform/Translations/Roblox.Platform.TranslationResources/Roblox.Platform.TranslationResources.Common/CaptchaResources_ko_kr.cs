namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_ko_kr : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToLoad"
	/// Displayed when we fail to load captcha javascript from a third party provider. This has been known to occur in FireFox when "block trackers" is enabled - we need to let the user know that it might be due to their browser without implying that we are intentionally forcing them to turn off their ad/content blockers.
	/// English String: "We need to verify that you are human. Please disable your browser blocker or try a different browser."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToLoad => "ì‚¬ìš©ìžê°€ ë¡œë´‡ì´ ì•„ë‹˜ì„ í™•ì¸í•´ì•¼ í•©ë‹ˆë‹¤. ë¸Œë¼ìš°ì € ì°¨ë‹¨ì„ í•´ì œí•˜ê±°ë‚˜ ë‹¤ë¥¸ ë¸Œë¼ìš°ì €ë¥¼ ì´ìš©í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToVerify"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToVerify => "ì¼ì‹œì ì¸ ì˜¤ë¥˜. ëª‡ ë¶„ í›„ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.CaptchaErrorVerifyFailed"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes"
	/// </summary>
	public override string ResponseCaptchaErrorVerifyFailed => "ì¼ì‹œì ì¸ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ëª‡ ë¶„ í›„ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”";

	public CaptchaResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToLoad()
	{
		return "ì‚¬ìš©ìžê°€ ë¡œë´‡ì´ ì•„ë‹˜ì„ í™•ì¸í•´ì•¼ í•©ë‹ˆë‹¤. ë¸Œë¼ìš°ì € ì°¨ë‹¨ì„ í•´ì œí•˜ê±°ë‚˜ ë‹¤ë¥¸ ë¸Œë¼ìš°ì €ë¥¼ ì´ìš©í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToVerify()
	{
		return "ì¼ì‹œì ì¸ ì˜¤ë¥˜. ëª‡ ë¶„ í›„ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorVerifyFailed()
	{
		return "ì¼ì‹œì ì¸ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ëª‡ ë¶„ í›„ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”";
	}
}


}
