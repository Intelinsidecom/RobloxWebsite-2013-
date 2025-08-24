namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationAnalyticsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationAnalyticsResources_es_es : TranslationAnalyticsResources_en_us, ITranslationAnalyticsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public override string ActionDownload => "Descargar";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "Solicitud";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "Nota: Una vez pedida la descarga, esta toma unos minutos en prepararse.";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "Informe de las contribuciones del traductor";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "Pendiente";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "Seleccionar rango de fechas";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "Ha habido un problema con tu solicitud. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "No tienes los permisos necesarios para descargar este informe.";

	public TranslationAnalyticsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "Descargar";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "Solicitud";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "Nota: Una vez pedida la descarga, esta toma unos minutos en prepararse.";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "Informe de las contribuciones del traductor";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "Pendiente";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "Seleccionar rango de fechas";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "Ha habido un problema con tu solicitud. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "No tienes los permisos necesarios para descargar este informe.";
	}
}
