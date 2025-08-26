namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationAnalyticsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationAnalyticsResources_ko_kr : TranslationAnalyticsResources_en_us, ITranslationAnalyticsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public override string ActionDownload => "ë‹¤ìš´ë¡œë“œ";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "ìš”ì²­";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "ì°¸ê³ : ìš”ì²­ í›„, ë‹¤ìš´ë¡œë“œê°€ ì¤€ë¹„ë˜ê¸°ê¹Œì§€ ëª‡ ë¶„ ì •ë„ ì†Œìš”ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "ë²ˆì—­ìž ê¸°ì—¬ë„ ë³´ê³ ì„œ";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "ëŒ€ê¸° ì¤‘";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "ê¸°ê°„ ì„ íƒ";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "ìš”ì²­ì— ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "ì´ ë³´ê³ ì„œë¥¼ ë‹¤ìš´ë¡œë“œí•  ìˆ˜ ìžˆëŠ” ê¶Œí•œì´ ì—†ì–´ìš”.";

	public TranslationAnalyticsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "ë‹¤ìš´ë¡œë“œ";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "ìš”ì²­";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "ì°¸ê³ : ìš”ì²­ í›„, ë‹¤ìš´ë¡œë“œê°€ ì¤€ë¹„ë˜ê¸°ê¹Œì§€ ëª‡ ë¶„ ì •ë„ ì†Œìš”ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "ë²ˆì—­ìž ê¸°ì—¬ë„ ë³´ê³ ì„œ";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "ëŒ€ê¸° ì¤‘";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "ê¸°ê°„ ì„ íƒ";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "ìš”ì²­ì— ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "ì´ ë³´ê³ ì„œë¥¼ ë‹¤ìš´ë¡œë“œí•  ìˆ˜ ìžˆëŠ” ê¶Œí•œì´ ì—†ì–´ìš”.";
	}
}


}
