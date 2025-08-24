namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_de_de : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "Fehler";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "Das Midas-Skript konnte nicht geladen werden. Bitte versuch es später erneut";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "Deine WeChat-Sitzung ist abgelaufen und deine Anfrage konnte nicht bearbeitet werden. Bitte melde dich erneut ein und versuch es noch mal.";

	public ChinaPaymentResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "Fehler";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "Das Midas-Skript konnte nicht geladen werden. Bitte versuch es später erneut";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "Deine WeChat-Sitzung ist abgelaufen und deine Anfrage konnte nicht bearbeitet werden. Bitte melde dich erneut ein und versuch es noch mal.";
	}
}
