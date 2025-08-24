namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_de_de : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "Standard ändern";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "Welche Sprache möchtest du als Standardsprache festlegen?";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "Löschen";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "Du kannst die Standardsprache und die lokalisierte Sprache festlegen, damit Benutzer den Titel und die Beschreibung deines Spiels in ihrer Sprache sehen können.";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "Bitte gib die fehlende Übersetzung ein.";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "Alle lokalisierten Daten werden gelöscht.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "Du hast nicht gespeicherte Änderungen. Möchtest du diese Seite wirklich verlassen?";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* Sollten lokalisierte App-Informationen im Nutzungsgebiet eines App Stores nicht verfügbar sein, wird stattdessen die von dir gewählte Standardsprache verwendet.";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "Übersetzungen in anderen Sprachen hinzufügen";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "Standardsprache ändern?";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "Hinzufügen";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "Andere Sprache hinzufügen";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Abbrechen";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public override string LabelChange => "Ändern";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "Sprache(n) ändern / hinzufügen";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "Sprache zum Ansehen bzw. Bearbeiten von Übersetzungen wählen: ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "Aktuelle Sprache";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "Standard";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "Löschen";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "Sprache";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public override string LabelNotSpecified => "Nicht festgelegt";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "Andere Sprachen suchen";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "Standardsprache festlegen";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "Quelle";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "Spielinformationen für Sprache ansehen";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Fehler: Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";

	public TranslationLanguageSwitchResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "Standard ändern";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "Welche Sprache möchtest du als Standardsprache festlegen?";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "Du kannst die Standardsprache und die lokalisierte Sprache festlegen, damit Benutzer den Titel und die Beschreibung deines Spiels in ihrer Sprache sehen können.";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "Bitte gib die fehlende Übersetzung ein.";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "Alle lokalisierten Daten werden gelöscht.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "Du hast nicht gespeicherte Änderungen. Möchtest du diese Seite wirklich verlassen?";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* Sollten lokalisierte App-Informationen im Nutzungsgebiet eines App Stores nicht verfügbar sein, wird stattdessen die von dir gewählte Standardsprache verwendet.";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "Übersetzungen in anderen Sprachen hinzufügen";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "Standardsprache ändern?";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"Lokalisierung für {languageName} löschen?";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "Lokalisierung für {languageName} löschen?";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "Hinzufügen";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "Andere Sprache hinzufügen";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "Ändern";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "Sprache(n) ändern / hinzufügen";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "Sprache zum Ansehen bzw. Bearbeiten von Übersetzungen wählen: ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "Aktuelle Sprache";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "Standard";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "Sprache";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "Nicht festgelegt";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "Andere Sprachen suchen";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "Standardsprache festlegen";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "Quelle";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"Quelle ({languageName})";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "Quelle ({languageName})";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "Spielinformationen für Sprache ansehen";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Fehler: Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";
	}
}
