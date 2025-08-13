namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_fr_fr : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "Effacer";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Confirmer";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Enregistrer";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "Erreur\u00a0: enregistrement impossible. Veuillez consulter les signalements avant de réessayer.";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "Erreur\u00a0: enregistrement impossible.";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "Si aucune traduction n'est disponible, les utilisateurs verront les données s'afficher en langue source.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "Certaines de vos modifications n'ont pas été sauvegardées. Voulez-vous vraiment modifier la langue\u00a0?";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "Nom et description enregistrés.";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "Les données en langue source sont affichées à titre de référence. Elles ne sont disponibles qu'ici.";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "Effacer les données";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "Configurer la localisation";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "Traductions du nom et de la description du jeu";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "Modifications non sauvegardées";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "Description\u00a0: ";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "Saisissez la description du jeu ici.";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "Informations";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "Nom du jeu et description sauvegardés.";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "Saisissez le nom du jeu ici (obligatoire)";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "Saisissez le nom du jeu ici";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "Traduction";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "Nom\u00a0: ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "Langues disponibles";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "Info de jeu";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "Langages";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "Rapports";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "Paramètres";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "Traducteurs";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "Titre";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "Erreur\u00a0: enregistrement impossible. Veuillez consulter les signalements avant de réessayer.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Erreur\u00a0: une erreur s'est produite. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "Erreur\u00a0: enregistrement impossible.";

	public GameLocalizationResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "Effacer";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Confirmer";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Enregistrer";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"Voulez-vous vraiment effacer toutes les traductions en {languageName}\u00a0? Les utilisateurs verront le nom et la description dans la langue source du jeu.";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "Voulez-vous vraiment effacer toutes les traductions en {languageName}\u00a0? Les utilisateurs verront le nom et la description dans la langue source du jeu.";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "Erreur\u00a0: enregistrement impossible. Veuillez consulter les signalements avant de réessayer.";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "Erreur\u00a0: enregistrement impossible.";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "Si aucune traduction n'est disponible, les utilisateurs verront les données s'afficher en langue source.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "Certaines de vos modifications n'ont pas été sauvegardées. Voulez-vous vraiment modifier la langue\u00a0?";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "Nom et description enregistrés.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "Les données en langue source sont affichées à titre de référence. Elles ne sont disponibles qu'ici.";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "Effacer les données";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "Configurer la localisation";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "Traductions du nom et de la description du jeu";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "Modifications non sauvegardées";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Description\u00a0: ";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "Saisissez la description du jeu ici.";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "Informations";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "Nom du jeu et description sauvegardés.";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "Saisissez le nom du jeu ici (obligatoire)";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "Saisissez le nom du jeu ici";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "Traduction";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Nom\u00a0: ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "Langues disponibles";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "Info de jeu";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "Langages";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "Rapports";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "Paramètres";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "Traducteurs";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "Titre";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "Erreur\u00a0: enregistrement impossible. Veuillez consulter les signalements avant de réessayer.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Erreur\u00a0: une erreur s'est produite. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "Erreur\u00a0: enregistrement impossible.";
	}
}
