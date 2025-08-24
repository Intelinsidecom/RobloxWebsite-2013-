namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationAnalyticsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationAnalyticsResources_de_de : TranslationAnalyticsResources_en_us, ITranslationAnalyticsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public override string ActionDownload => "Herunterladen";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "Anfrage";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "Hinweis: Nach Aufforderung kann die Vorbereitung des Downloads einige Minuten dauern.";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "Übersetzer-Beitragsbericht";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "Ausstehend";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "Datumsbereich auswählen";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "Es gab ein Problem mit deiner Anfrage. Bitte versuch es später erneut.";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "Du hast keine ausreichende Berechtigung zum Herunterladen dieses Berichts.";

	public TranslationAnalyticsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "Herunterladen";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "Anfrage";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "Hinweis: Nach Aufforderung kann die Vorbereitung des Downloads einige Minuten dauern.";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "Übersetzer-Beitragsbericht";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "Ausstehend";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "Datumsbereich auswählen";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "Es gab ein Problem mit deiner Anfrage. Bitte versuch es später erneut.";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "Du hast keine ausreichende Berechtigung zum Herunterladen dieses Berichts.";
	}
}
