namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_id_id : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Harap mengisi Captcha";

	public CaptchaResources_id_id(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Harap mengisi Captcha";
	}
}
