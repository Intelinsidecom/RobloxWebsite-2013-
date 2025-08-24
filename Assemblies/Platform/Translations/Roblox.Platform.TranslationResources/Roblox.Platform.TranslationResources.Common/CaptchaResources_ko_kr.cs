namespace Roblox.TranslationResources.Common;

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
	public override string ResponseCaptchaErrorFailedToLoad => "사용자가 로봇이 아님을 확인해야 합니다. 브라우저 차단을 해제하거나 다른 브라우저를 이용하세요.";

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToVerify"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToVerify => "일시적인 오류. 몇 분 후에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.CaptchaErrorVerifyFailed"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes"
	/// </summary>
	public override string ResponseCaptchaErrorVerifyFailed => "일시적인 오류가 발생했어요. 몇 분 후 다시 시도하세요";

	public CaptchaResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToLoad()
	{
		return "사용자가 로봇이 아님을 확인해야 합니다. 브라우저 차단을 해제하거나 다른 브라우저를 이용하세요.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToVerify()
	{
		return "일시적인 오류. 몇 분 후에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorVerifyFailed()
	{
		return "일시적인 오류가 발생했어요. 몇 분 후 다시 시도하세요";
	}
}
