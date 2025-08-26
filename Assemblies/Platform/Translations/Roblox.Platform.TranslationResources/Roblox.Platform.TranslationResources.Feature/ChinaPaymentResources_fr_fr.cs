namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_fr_fr : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "Erreur";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "Un problÃ¨me est survenu lors du chargement du script Midas. RÃ©essaye plus tard";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "Votre session WeChat a expirÃ© et nous ne pouvons pas traiter votre requÃªte. Veuillez vous reconnecter.";

	public ChinaPaymentResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "Erreur";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "Un problÃ¨me est survenu lors du chargement du script Midas. RÃ©essaye plus tard";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "Votre session WeChat a expirÃ© et nous ne pouvons pas traiter votre requÃªte. Veuillez vous reconnecter.";
	}
}


}
