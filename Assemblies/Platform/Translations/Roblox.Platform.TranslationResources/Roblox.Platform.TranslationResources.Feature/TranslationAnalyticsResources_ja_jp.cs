namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationAnalyticsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationAnalyticsResources_ja_jp : TranslationAnalyticsResources_en_us, ITranslationAnalyticsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public override string ActionDownload => "ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆ";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "ã”æ³¨æ„ï¼šä¸€åº¦ãƒªã‚¯ã‚¨ã‚¹ãƒˆã™ã‚‹ã¨ã€ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã®æº–å‚™ã«æ•°åˆ†ã‹ã‹ã‚‹ã‹ã‚‚ã—ã‚Œã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "ç¿»è¨³è€…ã®è²¢çŒ®ãƒ¬ãƒãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "ä¿ç•™ä¸­ã§ã™";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "æ—¥ä»˜ã®ç¯„å›²ã‚’é¸æŠž";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã«å•é¡ŒãŒã‚ã‚Šã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "ã“ã®ãƒ¬ãƒãƒ¼ãƒˆã‚’ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";

	public TranslationAnalyticsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆ";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "ã”æ³¨æ„ï¼šä¸€åº¦ãƒªã‚¯ã‚¨ã‚¹ãƒˆã™ã‚‹ã¨ã€ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã®æº–å‚™ã«æ•°åˆ†ã‹ã‹ã‚‹ã‹ã‚‚ã—ã‚Œã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "ç¿»è¨³è€…ã®è²¢çŒ®ãƒ¬ãƒãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "ä¿ç•™ä¸­ã§ã™";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "æ—¥ä»˜ã®ç¯„å›²ã‚’é¸æŠž";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã«å•é¡ŒãŒã‚ã‚Šã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "ã“ã®ãƒ¬ãƒãƒ¼ãƒˆã‚’ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰ã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";
	}
}


}
