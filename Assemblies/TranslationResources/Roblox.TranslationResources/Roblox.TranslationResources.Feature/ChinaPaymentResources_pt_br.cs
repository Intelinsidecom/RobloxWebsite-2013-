namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_pt_br : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "Erro";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "Estamos tendo problemas para carregar o script Midas agora. Tente de novo mais tarde";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "Parece que sua sessão de WeChat expirou e não podemos processar sua solicitação. Desconecte-se e reconecte-se.";

	public ChinaPaymentResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "Erro";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "Estamos tendo problemas para carregar o script Midas agora. Tente de novo mais tarde";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "Parece que sua sessão de WeChat expirou e não podemos processar sua solicitação. Desconecte-se e reconecte-se.";
	}
}
