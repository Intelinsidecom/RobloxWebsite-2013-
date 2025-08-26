namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_th_th : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™ Captcha";

	public CaptchaResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™ Captcha";
	}
}


}
