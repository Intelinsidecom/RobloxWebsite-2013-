namespace Roblox.TranslationResources.Feature;

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
	public override string ActionDownload => "ダウンロード";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "リクエスト";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "ご注意：一度リクエストすると、ダウンロードの準備に数分かかるかもしれません。";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "翻訳者の貢献レポート";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "保留中です";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "日付の範囲を選択";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "リクエストに問題があります。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "このレポートをダウンロードする権限がありません。";

	public TranslationAnalyticsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "ダウンロード";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "リクエスト";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "ご注意：一度リクエストすると、ダウンロードの準備に数分かかるかもしれません。";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "翻訳者の貢献レポート";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "保留中です";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "日付の範囲を選択";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "リクエストに問題があります。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "このレポートをダウンロードする権限がありません。";
	}
}
