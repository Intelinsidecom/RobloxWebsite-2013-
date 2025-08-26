namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationAnalyticsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationAnalyticsResources_pt_br : TranslationAnalyticsResources_en_us, ITranslationAnalyticsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Download"
	/// button text to download report
	/// English String: "Download"
	/// </summary>
	public override string ActionDownload => "Download";

	/// <summary>
	/// Key: "Action.Request"
	/// button text to request report
	/// English String: "Request"
	/// </summary>
	public override string ActionRequest => "SolicitaÃ§Ã£o";

	/// <summary>
	/// Key: "Description.ReportHint"
	/// English String: "Please note: Once requested, downloads may take a few minutes to prepare."
	/// </summary>
	public override string DescriptionReportHint => "Aviso: depois de solicitados, os downloads podem levar um tempo para serem preparados.";

	/// <summary>
	/// Key: "Heading.TranslationAnalytics"
	/// section heading
	/// English String: "Translator Contribution Report"
	/// </summary>
	public override string HeadingTranslationAnalytics => "RelatÃ³rio de contribuiÃ§Ã£o de tradutor";

	/// <summary>
	/// Key: "Label.Pending"
	/// status of report generation
	/// English String: "Pending"
	/// </summary>
	public override string LabelPending => "Pendente";

	/// <summary>
	/// Key: "Label.SelectDates"
	/// label for date selection dropdown
	/// English String: "Select Date Range"
	/// </summary>
	public override string LabelSelectDates => "Selecionar limites de data";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with your request. Please try again later."
	/// </summary>
	public override string MessageGenericError => "Ocorreu um erro com seu pedido. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Message.PermissionError"
	/// English String: "You do not have sufficient permission to download this report."
	/// </summary>
	public override string MessagePermissionError => "VocÃª nÃ£o tem permissÃ£o para baixar este relatÃ³rio.";

	public TranslationAnalyticsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDownload()
	{
		return "Download";
	}

	protected override string _GetTemplateForActionRequest()
	{
		return "SolicitaÃ§Ã£o";
	}

	protected override string _GetTemplateForDescriptionReportHint()
	{
		return "Aviso: depois de solicitados, os downloads podem levar um tempo para serem preparados.";
	}

	protected override string _GetTemplateForHeadingTranslationAnalytics()
	{
		return "RelatÃ³rio de contribuiÃ§Ã£o de tradutor";
	}

	protected override string _GetTemplateForLabelPending()
	{
		return "Pendente";
	}

	protected override string _GetTemplateForLabelSelectDates()
	{
		return "Selecionar limites de data";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "Ocorreu um erro com seu pedido. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForMessagePermissionError()
	{
		return "VocÃª nÃ£o tem permissÃ£o para baixar este relatÃ³rio.";
	}
}


}
