namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationAnalyticsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationAnalyticsResources_zh_cn : TranslationAnalyticsResources_en_us, ITranslationAnalyticsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public override string ActionDownload => "下载";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "请求";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "请注意：请求后，下载将需要几分钟的时间准备。";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "译者贡献报告";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "处理中";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "选择日期范围";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "处理请求时遇到问题，请稍后重试。";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "你的权限不足，无法下载此报告。";

	public TranslationAnalyticsResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "下载";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "请求";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "请注意：请求后，下载将需要几分钟的时间准备。";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "译者贡献报告";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "处理中";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "选择日期范围";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "处理请求时遇到问题，请稍后重试。";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "你的权限不足，无法下载此报告。";
	}
}
