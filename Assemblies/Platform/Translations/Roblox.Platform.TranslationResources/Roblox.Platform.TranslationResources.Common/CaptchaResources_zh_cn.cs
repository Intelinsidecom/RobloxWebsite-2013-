namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_zh_cn : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToLoad"
	/// Displayed when we fail to load captcha javascript from a third party provider. This has been known to occur in FireFox when "block trackers" is enabled - we need to let the user know that it might be due to their browser without implying that we are intentionally forcing them to turn off their ad/content blockers.
	/// English String: "We need to verify that you are human. Please disable your browser blocker or try a different browser."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToLoad => "æˆ‘ä»¬éœ€è¦éªŒè¯ä½ æ˜¯çœŸäººã€‚è¯·åœç”¨æ­£åœ¨è¿è¡Œçš„æµè§ˆå™¨å¤–æŒ‚æˆ–å°è¯•ä½¿ç”¨å…¶ä»–æµè§ˆå™¨ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToVerify"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToVerify => "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽå†è¯•ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaErrorVerifyFailed"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes"
	/// </summary>
	public override string ResponseCaptchaErrorVerifyFailed => "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽå†è¯•ã€‚";

	public CaptchaResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToLoad()
	{
		return "æˆ‘ä»¬éœ€è¦éªŒè¯ä½ æ˜¯çœŸäººã€‚è¯·åœç”¨æ­£åœ¨è¿è¡Œçš„æµè§ˆå™¨å¤–æŒ‚æˆ–å°è¯•ä½¿ç”¨å…¶ä»–æµè§ˆå™¨ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToVerify()
	{
		return "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽå†è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaErrorVerifyFailed()
	{
		return "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽå†è¯•ã€‚";
	}
}


}
