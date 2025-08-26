namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides CaptchaResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CaptchaResources_ru_ru : CaptchaResources_en_us, ICaptchaResources, ITranslationResources
{
	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð·Ð°Ð¿Ð¾Ð»Ð½Ð¸Ñ‚Ðµ ÐºÐ°Ð¿Ñ‡Ñƒ";

	public CaptchaResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð·Ð°Ð¿Ð¾Ð»Ð½Ð¸Ñ‚Ðµ ÐºÐ°Ð¿Ñ‡Ñƒ";
	}
}


}
