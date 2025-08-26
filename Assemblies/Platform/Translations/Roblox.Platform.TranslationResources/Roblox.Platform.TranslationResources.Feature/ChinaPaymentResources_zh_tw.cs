namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_zh_tw : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "éŒ¯èª¤";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "è¼‰å…¥ Midas è…³æœ¬ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "ç„¡æ³•è™•ç†è«‹æ±‚ï¼Œæ‚¨çš„å¾®ä¿¡ç™»å…¥ä¼¼ä¹Žé€¾æ™‚ã€‚è«‹é‡æ–°ç™»å…¥ã€‚";

	public ChinaPaymentResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "éŒ¯èª¤";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "è¼‰å…¥ Midas è…³æœ¬ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "ç„¡æ³•è™•ç†è«‹æ±‚ï¼Œæ‚¨çš„å¾®ä¿¡ç™»å…¥ä¼¼ä¹Žé€¾æ™‚ã€‚è«‹é‡æ–°ç™»å…¥ã€‚";
	}
}


}
