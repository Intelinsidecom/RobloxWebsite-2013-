namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_ko_kr : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "ë³´ì•ˆ ë¬¸ìžë¥¼ ìž…ë ¥í•˜ì„¸ìš”";

	public CaptchaResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "ë³´ì•ˆ ë¬¸ìžë¥¼ ìž…ë ¥í•˜ì„¸ìš”";
	}
}


}
