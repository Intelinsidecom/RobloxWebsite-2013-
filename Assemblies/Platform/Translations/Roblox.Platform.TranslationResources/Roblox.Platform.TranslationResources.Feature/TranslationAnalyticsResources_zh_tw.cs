namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationAnalyticsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationAnalyticsResources_zh_tw : TranslationAnalyticsResources_en_us, ITranslationAnalyticsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public override string ActionDownload => "ä¸‹è¼‰";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "è«‹æ±‚";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "æ³¨æ„ï¼šè«‹æ±‚ä¹‹å¾Œï¼Œä¸‹è¼‰å°‡éœ€è¦å¹¾åˆ†é˜å®Œæˆã€‚";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "è­¯è€…è²¢ç»å ±å‘Š";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "å¾…è™•ç†";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "é¸æ“‡æ—¥æœŸç¯„åœ";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "è™•ç†è«‹æ±‚æ™‚ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "æ‚¨çš„æ¬Šé™ä¸è¶³ï¼Œç„¡æ³•ä¸‹è¼‰æ­¤å ±å‘Šã€‚";

	public TranslationAnalyticsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "ä¸‹è¼‰";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "è«‹æ±‚";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "æ³¨æ„ï¼šè«‹æ±‚ä¹‹å¾Œï¼Œä¸‹è¼‰å°‡éœ€è¦å¹¾åˆ†é˜å®Œæˆã€‚";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "è­¯è€…è²¢ç»å ±å‘Š";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "å¾…è™•ç†";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "é¸æ“‡æ—¥æœŸç¯„åœ";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "è™•ç†è«‹æ±‚æ™‚ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "æ‚¨çš„æ¬Šé™ä¸è¶³ï¼Œç„¡æ³•ä¸‹è¼‰æ­¤å ±å‘Šã€‚";
	}
}


}
