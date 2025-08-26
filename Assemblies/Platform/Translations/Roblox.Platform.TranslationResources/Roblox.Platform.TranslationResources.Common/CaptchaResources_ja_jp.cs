namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_ja_jp : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToLoad"
	/// Displayed when we fail to load captcha javascript from a third party provider. This has been known to occur in FireFox when "block trackers" is enabled - we need to let the user know that it might be due to their browser without implying that we are intentionally forcing them to turn off their ad/content blockers.
	/// English String: "We need to verify that you are human. Please disable your browser blocker or try a different browser."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToLoad => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒè¡Œã£ãŸæ“ä½œã§ã‚ã‚‹ã“ã¨ã‚’æ¤œè¨¼ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ–ãƒ©ã‚¦ã‚¶ã®ãƒ–ãƒ­ãƒƒã‚«ãƒ¼ã‚’ã‚ªãƒ•ã«ã™ã‚‹ã‹ã€åˆ¥ã®ãƒ–ãƒ©ã‚¦ã‚¶ã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToVerify"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToVerify => "ä¸€æ™‚çš„ãªã‚¨ãƒ©ãƒ¼ã§ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaErrorVerifyFailed"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes"
	/// </summary>
	public override string ResponseCaptchaErrorVerifyFailed => "ä¸€æ™‚çš„ãªã‚¨ãƒ©ãƒ¼ã§ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public CaptchaResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToLoad()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒè¡Œã£ãŸæ“ä½œã§ã‚ã‚‹ã“ã¨ã‚’æ¤œè¨¼ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ–ãƒ©ã‚¦ã‚¶ã®ãƒ–ãƒ­ãƒƒã‚«ãƒ¼ã‚’ã‚ªãƒ•ã«ã™ã‚‹ã‹ã€åˆ¥ã®ãƒ–ãƒ©ã‚¦ã‚¶ã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToVerify()
	{
		return "ä¸€æ™‚çš„ãªã‚¨ãƒ©ãƒ¼ã§ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaErrorVerifyFailed()
	{
		return "ä¸€æ™‚çš„ãªã‚¨ãƒ©ãƒ¼ã§ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}
}


}
