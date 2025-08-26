namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ChinaPaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChinaPaymentResources_zh_cn : ChinaPaymentResources_en_us, IChinaPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public override string HeadingError => "é”™è¯¯";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public override string MessageScriptNotLoadError => "åŠ è½½ Midas è„šæœ¬æ—¶é‡åˆ°é—®é¢˜ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public override string MessageSessionExpiredError => "ä½ çš„å¾®ä¿¡ä¼šè¯ä¼¼ä¹Žå·²è¿‡æœŸï¼Œæˆ‘ä»¬æ— æ³•å¤„ç†ä½ çš„è¯·æ±‚ã€‚è¯·é€€å‡ºç™»å½•å¹¶é‡è¯•ã€‚";

	public ChinaPaymentResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingError()
	{
		return "é”™è¯¯";
	}

	protected override string _GetTemplateForMessageScriptNotLoadError()
	{
		return "åŠ è½½ Midas è„šæœ¬æ—¶é‡åˆ°é—®é¢˜ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageSessionExpiredError()
	{
		return "ä½ çš„å¾®ä¿¡ä¼šè¯ä¼¼ä¹Žå·²è¿‡æœŸï¼Œæˆ‘ä»¬æ— æ³•å¤„ç†ä½ çš„è¯·æ±‚ã€‚è¯·é€€å‡ºç™»å½•å¹¶é‡è¯•ã€‚";
	}
}


}
