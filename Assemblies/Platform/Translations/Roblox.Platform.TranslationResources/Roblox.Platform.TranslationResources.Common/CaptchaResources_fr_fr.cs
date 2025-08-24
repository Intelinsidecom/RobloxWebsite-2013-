namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_fr_fr : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToLoad"
	/// Displayed when we fail to load captcha javascript from a third party provider. This has been known to occur in FireFox when "block trackers" is enabled - we need to let the user know that it might be due to their browser without implying that we are intentionally forcing them to turn off their ad/content blockers.
	/// English String: "We need to verify that you are human. Please disable your browser blocker or try a different browser."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToLoad => "Nous devons vérifier que vous n'êtes pas un robot. Veuillez désactiver le bloqueur de votre navigateur ou essayer un autre navigateur.";

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToVerify"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToVerify => "Erreur temporaire. Veuillez réessayer dans quelques minutes.";

	/// <summary>
	/// Key: "Response.CaptchaErrorVerifyFailed"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes"
	/// </summary>
	public override string ResponseCaptchaErrorVerifyFailed => "Erreur temporaire. Veuillez réessayer dans quelques minutes.";

	public CaptchaResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToLoad()
	{
		return "Nous devons vérifier que vous n'êtes pas un robot. Veuillez désactiver le bloqueur de votre navigateur ou essayer un autre navigateur.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToVerify()
	{
		return "Erreur temporaire. Veuillez réessayer dans quelques minutes.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorVerifyFailed()
	{
		return "Erreur temporaire. Veuillez réessayer dans quelques minutes.";
	}
}
