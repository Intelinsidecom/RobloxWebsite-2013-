namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SourceLanguageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SourceLanguageResources_fr_fr : SourceLanguageResources_en_us, ISourceLanguageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Confirmer";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "La langue source est la langue dans laquelle le jeu a été écrit.";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "Changer la langue source du jeu";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "Langue source du jeu\u00a0: ";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public override string LabelNotSpecified => "Non spécifié(e)";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "Langue source";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Erreur\u00a0: une erreur s'est produite. Veuillez réessayer plus tard.";

	public SourceLanguageResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Confirmer";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"Voulez-vous vraiment sélectionner cette langue\u00a0: {languageName} comme langue source du jeu\u00a0? Celle-ci doit correspondre à la langue dans laquelle le jeu a été écrit.";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "Voulez-vous vraiment sélectionner cette langue\u00a0: {languageName} comme langue source du jeu\u00a0? Celle-ci doit correspondre à la langue dans laquelle le jeu a été écrit.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "La langue source est la langue dans laquelle le jeu a été écrit.";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "Changer la langue source du jeu";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "Langue source du jeu\u00a0: ";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "Non spécifié(e)";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "Langue source";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Erreur\u00a0: une erreur s'est produite. Veuillez réessayer plus tard.";
	}
}
