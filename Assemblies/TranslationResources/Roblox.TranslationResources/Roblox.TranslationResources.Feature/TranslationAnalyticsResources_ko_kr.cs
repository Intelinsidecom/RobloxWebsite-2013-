namespace Roblox.TranslationResources.Feature;

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
	public override string ActionDownload => "다운로드";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "요청";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "참고: 요청 후, 다운로드가 준비되기까지 몇 분 정도 소요됩니다.";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "번역자 기여도 보고서";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "대기 중";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "기간 선택";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "요청에 오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "이 보고서를 다운로드할 수 있는 권한이 없어요.";

	public TranslationAnalyticsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "다운로드";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "요청";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "참고: 요청 후, 다운로드가 준비되기까지 몇 분 정도 소요됩니다.";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "번역자 기여도 보고서";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "대기 중";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "기간 선택";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "요청에 오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "이 보고서를 다운로드할 수 있는 권한이 없어요.";
	}
}
