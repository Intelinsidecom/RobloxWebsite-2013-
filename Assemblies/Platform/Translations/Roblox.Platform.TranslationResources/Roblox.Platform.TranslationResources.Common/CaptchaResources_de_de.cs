namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_de_de : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToLoad"
	/// Displayed when we fail to load captcha javascript from a third party provider. This has been known to occur in FireFox when "block trackers" is enabled - we need to let the user know that it might be due to their browser without implying that we are intentionally forcing them to turn off their ad/content blockers.
	/// English String: "We need to verify that you are human. Please disable your browser blocker or try a different browser."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToLoad => "Wir müssen überprüfen, ob du ein Mensch bist. Bitte deaktiviere die Blockierung der Aktivitätenverfolgung in deinem Browser oder versuche es mit einem anderen Browser.";

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToVerify"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToVerify => "Vorübergehender Fehler. Bitte versuche es in einigen Minuten erneut.";

	/// <summary>
	/// Key: "Response.CaptchaErrorVerifyFailed"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes"
	/// </summary>
	public override string ResponseCaptchaErrorVerifyFailed => "Vorübergehender Fehler. Bitte versuche es in einigen Minuten erneut.";

	public CaptchaResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToLoad()
	{
		return "Wir müssen überprüfen, ob du ein Mensch bist. Bitte deaktiviere die Blockierung der Aktivitätenverfolgung in deinem Browser oder versuche es mit einem anderen Browser.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToVerify()
	{
		return "Vorübergehender Fehler. Bitte versuche es in einigen Minuten erneut.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorVerifyFailed()
	{
		return "Vorübergehender Fehler. Bitte versuche es in einigen Minuten erneut.";
	}
}
