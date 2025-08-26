namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationAnalyticsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationAnalyticsResources_zh_cjv : TranslationAnalyticsResources_en_us, ITranslationAnalyticsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public override string ActionDownload => "ä¸‹è½½";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "è¯·æ±‚";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "è¯·æ³¨æ„ï¼šè¯·æ±‚åŽï¼Œä¸‹è½½å°†éœ€è¦å‡ åˆ†é’Ÿçš„æ—¶é—´å‡†å¤‡ã€‚";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "è¯‘è€…è´¡çŒ®æŠ¥å‘Š";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "å¤„ç†ä¸­";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "é€‰æ‹©æ—¥æœŸèŒƒå›´";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "å¤„ç†è¯·æ±‚æ—¶é‡åˆ°é—®é¢˜ï¼Œè¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "ä½ çš„æƒé™ä¸è¶³ï¼Œæ— æ³•ä¸‹è½½æ­¤æŠ¥å‘Šã€‚";

	public TranslationAnalyticsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "ä¸‹è½½";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "è¯·æ±‚";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "è¯·æ³¨æ„ï¼šè¯·æ±‚åŽï¼Œä¸‹è½½å°†éœ€è¦å‡ åˆ†é’Ÿçš„æ—¶é—´å‡†å¤‡ã€‚";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "è¯‘è€…è´¡çŒ®æŠ¥å‘Š";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "å¤„ç†ä¸­";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "é€‰æ‹©æ—¥æœŸèŒƒå›´";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "å¤„ç†è¯·æ±‚æ—¶é‡åˆ°é—®é¢˜ï¼Œè¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "ä½ çš„æƒé™ä¸è¶³ï¼Œæ— æ³•ä¸‹è½½æ­¤æŠ¥å‘Šã€‚";
	}
}


}
