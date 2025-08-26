namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_zh_tw : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToLoad"
	/// Displayed when we fail to load captcha javascript from a third party provider. This has been known to occur in FireFox when "block trackers" is enabled - we need to let the user know that it might be due to their browser without implying that we are intentionally forcing them to turn off their ad/content blockers.
	/// English String: "We need to verify that you are human. Please disable your browser blocker or try a different browser."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToLoad => "æˆ‘å€‘éœ€è¦é€²è¡ŒçœŸäººé©—è­‰ï¼Œè«‹åœç”¨é‹ä½œä¸­çš„ç€è¦½å™¨å¤–æŽ›æˆ–ä½¿ç”¨å…¶å®ƒç€è¦½å™¨ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToVerify"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToVerify => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaErrorVerifyFailed"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes"
	/// </summary>
	public override string ResponseCaptchaErrorVerifyFailed => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	public CaptchaResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToLoad()
	{
		return "æˆ‘å€‘éœ€è¦é€²è¡ŒçœŸäººé©—è­‰ï¼Œè«‹åœç”¨é‹ä½œä¸­çš„ç€è¦½å™¨å¤–æŽ›æˆ–ä½¿ç”¨å…¶å®ƒç€è¦½å™¨ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToVerify()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaErrorVerifyFailed()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}
}


}
