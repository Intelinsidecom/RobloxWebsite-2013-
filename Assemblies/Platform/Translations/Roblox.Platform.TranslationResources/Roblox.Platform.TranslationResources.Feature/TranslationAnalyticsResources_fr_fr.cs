namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationAnalyticsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationAnalyticsResources_fr_fr : TranslationAnalyticsResources_en_us, ITranslationAnalyticsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public override string ActionDownload => "Téléchargement";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "Demande";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "À noter : une fois la demande faite, les téléchargements peuvent prendre du temps à la préparation.";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "Compte rendu de traduction";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "En attente";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "Sélectionner la période";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "Un problème est survenu lors de ta requête. Réessaie plus tard.";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "Tu n'as pas les permissions nécessaire pour télécharger ce compte rendu.";

	public TranslationAnalyticsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "Téléchargement";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "Demande";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "À noter : une fois la demande faite, les téléchargements peuvent prendre du temps à la préparation.";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "Compte rendu de traduction";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "En attente";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "Sélectionner la période";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "Un problème est survenu lors de ta requête. Réessaie plus tard.";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "Tu n'as pas les permissions nécessaire pour télécharger ce compte rendu.";
	}
}
