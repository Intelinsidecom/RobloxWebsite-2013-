namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_fr_fr : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "Changer la langue par défaut";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "Quelle langue voulez-vous choisir par défaut\u00a0?";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "Supprimer";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "Vous pouvez définir la langue par défaut et de traduction, qui permet à l'utilisateur de voir le titre du jeu et les descriptions dans sa langue.";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "Veuillez ajouter les traductions manquantes";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "Toutes les informations traduites seront supprimées.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "Certaines de vos modifications n'ont pas enregistrées. Voulez-vous vraiment quitter cette page\u00a0?";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* Si les informations traduites de l'application ne sont pas disponibles dans l'App Store de votre territoire, elles seront affichées dans votre langue par défaut.";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "Ajouter la traduction dans d'autres langues";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "Changer la langue par défaut\u00a0?";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "Ajouter";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "Ajouter une autre langue";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Annuler";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public override string LabelChange => "Changer";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "Changer/ajouter d'autres langues";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "Sélectionnez une langue pour consulter/éditer les traductions\u00a0: ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "Langue actuelle";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "Par défaut";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "Supprimer";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "Langue";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public override string LabelNotSpecified => "Non spécifié(e)";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "Rechercher d'autres langues";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "Langue par défaut";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "Source";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "Voir les informations de jeu sur la langue";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Erreur\u00a0: une erreur s'est produite. Veuillez réessayer plus tard.";

	public TranslationLanguageSwitchResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "Changer la langue par défaut";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "Quelle langue voulez-vous choisir par défaut\u00a0?";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "Supprimer";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "Vous pouvez définir la langue par défaut et de traduction, qui permet à l'utilisateur de voir le titre du jeu et les descriptions dans sa langue.";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "Veuillez ajouter les traductions manquantes";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "Toutes les informations traduites seront supprimées.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "Certaines de vos modifications n'ont pas enregistrées. Voulez-vous vraiment quitter cette page\u00a0?";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* Si les informations traduites de l'application ne sont pas disponibles dans l'App Store de votre territoire, elles seront affichées dans votre langue par défaut.";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "Ajouter la traduction dans d'autres langues";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "Changer la langue par défaut\u00a0?";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"Supprimer la localisation en {languageName}\u00a0?";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "Supprimer la localisation en {languageName}\u00a0?";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "Ajouter";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "Ajouter une autre langue";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "Changer";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "Changer/ajouter d'autres langues";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "Sélectionnez une langue pour consulter/éditer les traductions\u00a0: ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "Langue actuelle";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "Par défaut";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "Supprimer";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "Langue";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "Non spécifié(e)";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "Rechercher d'autres langues";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "Langue par défaut";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "Source";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"Source ({languageName})";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "Source ({languageName})";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "Voir les informations de jeu sur la langue";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Erreur\u00a0: une erreur s'est produite. Veuillez réessayer plus tard.";
	}
}
