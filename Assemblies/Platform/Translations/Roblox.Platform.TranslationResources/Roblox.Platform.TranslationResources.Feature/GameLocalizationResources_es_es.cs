namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_es_es : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "Borrar";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Confirmar";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Guardar";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "Error: no se ha podido guardar. AsegÃºrate de que pase nuestro proceso de moderaciÃ³n e intÃ©ntalo de nuevo.";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "Error: no se ha podido guardar.";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "Si no hay traducciones disponibles, los usuarios verÃ¡n los valores en el idioma de origen.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "Hay cambios sin guardar. Â¿Seguro que quieres cambiar el idioma?";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "Nombre y descripciÃ³n guardados.";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "Los valores del idioma de origen se muestran solo como referencia. Se pueden ver Ãºnicamente aquÃ­.";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "Borrar valores";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "Configurar la localizaciÃ³n";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "TraducciÃ³n del nombre y descripciÃ³n del juego";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "Cambios sin guardar";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "DescripciÃ³n: ";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "Introduce la descripciÃ³n del juego aquÃ­";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "InformaciÃ³n del juego";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "TraducciÃ³n del nombre y descripciÃ³n del juego";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "Introduce el nombre del juego aquÃ­ (obligatorio)";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "Introduce el nombre del juego aquÃ­";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "LocalizaciÃ³n";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "Nombre: ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "Idiomas compatibles";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "InformaciÃ³n del juego";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "Idiomas";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "Informes";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "ConfiguraciÃ³n";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "Traductores";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "TÃ­tulo";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "Error: no se ha podido guardar. AsegÃºrate de que pase nuestro proceso de moderaciÃ³n e intÃ©ntalo de nuevo.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Error: no se ha podido guardar. IntÃ©ntalo de nuevo mÃ¡s tarde.";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "Error: no se ha podido guardar.";

	public GameLocalizationResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "Borrar";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Confirmar";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Guardar";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"Â¿Seguro que quieres borrar las traducciones en {languageName}? Los usuarios verÃ¡n el nombre y la descripciÃ³n en el idioma de origen del juego.";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "Â¿Seguro que quieres borrar las traducciones en {languageName}? Los usuarios verÃ¡n el nombre y la descripciÃ³n en el idioma de origen del juego.";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "Error: no se ha podido guardar. AsegÃºrate de que pase nuestro proceso de moderaciÃ³n e intÃ©ntalo de nuevo.";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "Error: no se ha podido guardar.";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "Si no hay traducciones disponibles, los usuarios verÃ¡n los valores en el idioma de origen.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "Hay cambios sin guardar. Â¿Seguro que quieres cambiar el idioma?";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "Nombre y descripciÃ³n guardados.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "Los valores del idioma de origen se muestran solo como referencia. Se pueden ver Ãºnicamente aquÃ­.";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "Borrar valores";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "Configurar la localizaciÃ³n";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "TraducciÃ³n del nombre y descripciÃ³n del juego";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "Cambios sin guardar";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "DescripciÃ³n: ";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "Introduce la descripciÃ³n del juego aquÃ­";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "InformaciÃ³n del juego";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "TraducciÃ³n del nombre y descripciÃ³n del juego";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "Introduce el nombre del juego aquÃ­ (obligatorio)";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "Introduce el nombre del juego aquÃ­";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "LocalizaciÃ³n";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Nombre: ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "Idiomas compatibles";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "InformaciÃ³n del juego";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "Idiomas";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "Informes";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "ConfiguraciÃ³n";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "Traductores";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "TÃ­tulo";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "Error: no se ha podido guardar. AsegÃºrate de que pase nuestro proceso de moderaciÃ³n e intÃ©ntalo de nuevo.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Error: no se ha podido guardar. IntÃ©ntalo de nuevo mÃ¡s tarde.";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "Error: no se ha podido guardar.";
	}
}


}
