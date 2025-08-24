namespace Roblox.TranslationResources.Authentication;

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
	public override string ResponseCaptchaNotEnteredError => "보안 문자를 입력하세요";

	public CaptchaResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "보안 문자를 입력하세요";
	}
}
