namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SecurityNotificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SecurityNotificationResources_es_es : SecurityNotificationResources_en_us, ISecurityNotificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Important"
	/// English String: "Important"
	/// </summary>
	public override string HeadingImportant => "Importante";

	public SecurityNotificationResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationText"
	/// English String: "For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}."
	/// </summary>
	public override string DescriptionSecurityNotificationText(string aTagStartWithHref, string emailMailToLink, string hrefEnd, string emailText, string aTagEnd)
	{
		return $"Se ha cambiado la contraseÃ±a para proteger tu cuenta. Para acceder a ella, escribe tu correo electrÃ³nico o nÃºmero de telÃ©fono y haz clic en el botÃ³n Enviar. Si no hay correos electrÃ³nicos o telÃ©fonos asociados a la cuenta, contacta AtenciÃ³n al cliente de Roblox en {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}.";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationText()
	{
		return "Se ha cambiado la contraseÃ±a para proteger tu cuenta. Para acceder a ella, escribe tu correo electrÃ³nico o nÃºmero de telÃ©fono y haz clic en el botÃ³n Enviar. Si no hay correos electrÃ³nicos o telÃ©fonos asociados a la cuenta, contacta AtenciÃ³n al cliente de Roblox en {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}.";
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationTextWarning"
	/// English String: "Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised."
	/// </summary>
	public override string DescriptionSecurityNotificationTextWarning(string startSpan, string endSpan)
	{
		return $"Escoge una contraseÃ±a que sea {startSpan}nueva{endSpan} y {startSpan}Ãºnica{endSpan} para tu cuenta de Roblox. No uses esa contraseÃ±a en ningÃºn otro sitio. Esta es la mejor manera para proteger tu cuenta.";
	}

	protected override string _GetTemplateForDescriptionSecurityNotificationTextWarning()
	{
		return "Escoge una contraseÃ±a que sea {startSpan}nueva{endSpan} y {startSpan}Ãºnica{endSpan} para tu cuenta de Roblox. No uses esa contraseÃ±a en ningÃºn otro sitio. Esta es la mejor manera para proteger tu cuenta.";
	}

	protected override string _GetTemplateForHeadingImportant()
	{
		return "Importante";
	}
}


}
