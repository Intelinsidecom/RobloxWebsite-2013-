namespace Roblox.TranslationResources.Feature;

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
	public override string ActionDownload => "下載";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "請求";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "注意：請求之後，下載將需要幾分鐘完成。";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "譯者貢獻報告";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "待處理";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "選擇日期範圍";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "處理請求時發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "您的權限不足，無法下載此報告。";

	public TranslationAnalyticsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "下載";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "請求";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "注意：請求之後，下載將需要幾分鐘完成。";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "譯者貢獻報告";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "待處理";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "選擇日期範圍";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "處理請求時發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "您的權限不足，無法下載此報告。";
	}
}
