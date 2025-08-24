namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_es_es : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "Cambiar predeterminado";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "¿Qué idioma quieres establecer como predeterminado?";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "Eliminar";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "Puedes especificar el idioma predeterminado y localizado, para que el usuario vea el título y la descripción del juego en su idioma.";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "Añadir las traducciones faltantes";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "Se eliminará toda la información localizada.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "Hay cambios sin guardar. ¿Seguro que quieres salir de esta página?";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* Si la información localizada de la aplicación no está disponible en un territorio de App Store, se utilizará la información de tu idioma predeterminado.";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "Añadir traducción en otros idiomas";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "¿Cambiar el idioma predeterminado?";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "Añadir";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "Añadir otro idioma";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Cancelar";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public override string LabelChange => "Cambiar";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "Cambiar / añadir otros idiomas";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "Elige un idioma para ver o editar las traducciones: ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "Idioma actual";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "Predeterminado";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "Eliminar";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "Idioma";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public override string LabelNotSpecified => "Sin especificar";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "Buscar otros idiomas";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "Establecer idioma predeterminado";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "Origen";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "Ver la información del juego para compatibilidad de idiomas";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Error: se ha producido un error. Inténtalo de nuevo más tarde.";

	public TranslationLanguageSwitchResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "Cambiar predeterminado";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "¿Qué idioma quieres establecer como predeterminado?";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "Eliminar";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "Puedes especificar el idioma predeterminado y localizado, para que el usuario vea el título y la descripción del juego en su idioma.";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "Añadir las traducciones faltantes";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "Se eliminará toda la información localizada.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "Hay cambios sin guardar. ¿Seguro que quieres salir de esta página?";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* Si la información localizada de la aplicación no está disponible en un territorio de App Store, se utilizará la información de tu idioma predeterminado.";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "Añadir traducción en otros idiomas";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "¿Cambiar el idioma predeterminado?";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"¿Eliminar la localización en {languageName}?";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "¿Eliminar la localización en {languageName}?";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "Añadir";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "Añadir otro idioma";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "Cambiar";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "Cambiar / añadir otros idiomas";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "Elige un idioma para ver o editar las traducciones: ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "Idioma actual";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "Predeterminado";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "Eliminar";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "Idioma";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "Sin especificar";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "Buscar otros idiomas";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "Establecer idioma predeterminado";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "Origen";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"Idioma de origen ({languageName})";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "Idioma de origen ({languageName})";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "Ver la información del juego para compatibilidad de idiomas";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Error: se ha producido un error. Inténtalo de nuevo más tarde.";
	}
}
