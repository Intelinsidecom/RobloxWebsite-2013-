namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_es_es : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "Error";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "Tenemos problemas para cargar el script Midas en este momento. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "Parece que la sesión de WeChat ha caducado y no podemos procesar tu solicitud. Cierra sesión y vuelve a iniciarla.";

	public ChinaPaymentResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "Error";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "Tenemos problemas para cargar el script Midas en este momento. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "Parece que la sesión de WeChat ha caducado y no podemos procesar tu solicitud. Cierra sesión y vuelve a iniciarla.";
	}
}
