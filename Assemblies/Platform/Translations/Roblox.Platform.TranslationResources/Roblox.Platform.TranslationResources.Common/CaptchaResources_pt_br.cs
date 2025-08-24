namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_pt_br : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToLoad"
	/// Displayed when we fail to load captcha javascript from a third party provider. This has been known to occur in FireFox when "block trackers" is enabled - we need to let the user know that it might be due to their browser without implying that we are intentionally forcing them to turn off their ad/content blockers.
	/// English String: "We need to verify that you are human. Please disable your browser blocker or try a different browser."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToLoad => "Precisamos verificar se você é humano. Desative o bloqueador do navegador ou tente um navegador diferente.";

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToVerify"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes."
	/// </summary>
	public override string ResponseCaptchaErrorFailedToVerify => "Erro temporário. Tente novamente em alguns minutos.";

	/// <summary>
	/// Key: "Response.CaptchaErrorVerifyFailed"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes"
	/// </summary>
	public override string ResponseCaptchaErrorVerifyFailed => "Erro temporário. Tente novamente em alguns minutos.";

	public CaptchaResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToLoad()
	{
		return "Precisamos verificar se você é humano. Desative o bloqueador do navegador ou tente um navegador diferente.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorFailedToVerify()
	{
		return "Erro temporário. Tente novamente em alguns minutos.";
	}

	protected override string _GetTemplateForResponseCaptchaErrorVerifyFailed()
	{
		return "Erro temporário. Tente novamente em alguns minutos.";
	}
}
