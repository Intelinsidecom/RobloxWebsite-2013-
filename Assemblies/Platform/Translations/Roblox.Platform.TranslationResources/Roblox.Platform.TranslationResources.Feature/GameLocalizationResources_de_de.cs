namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_de_de : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "Löschen";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Bestätigen";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Speichern";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "Fehler: Konnte nicht speichern. Bitte überprüfe den Inhalt auf Moderation und versuche es erneut.";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "Fehler: Konnte nicht speichern.";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "Wenn keine Übersetzungen bereitgestellt werden, sehen Benutzer die Werte der Quellsprache.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "Du hast nicht gespeicherte Änderungen. Möchtest du die Sprache wirklich wechseln?";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "Name und Beschreibung wurden gespeichert.";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "Werte der Quellsprache werden als Referenz angezeigt. Sie können nur hier gesehen werden.";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "Werte löschen";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "Lokalisierung konfigurieren";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "Spielname und Beschreibungsübersetzungen";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "Nicht gespeicherte Änderungen";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "Beschreibung: ";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "Gib die Spielbeschreibung hier ein";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "Spielinformationen";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "Spielname und Beschreibungsübersetzungen";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "Gib den Spielnamen hier ein (erforderlich)";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "Gib den Spielnamen hier ein";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "Lokalisierung";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "Name: ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "Unterstützte Sprachen";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "Spielinformationen";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "Sprachen";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "Berichte";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "Einstellungen";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "Übersetzer";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "Titel";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "Fehler: Konnte nicht speichern. Bitte überprüfe den Inhalt auf Moderation und versuche es erneut.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Fehler: Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "Fehler: Konnte nicht speichern.";

	public GameLocalizationResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Bestätigen";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Speichern";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"Möchtest du die Übersetzungen für {languageName} wirklich löschen? Benutzer werden den Namen und die Beschreibung in der Quellsprache des Spiels sehen.";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "Möchtest du die Übersetzungen für {languageName} wirklich löschen? Benutzer werden den Namen und die Beschreibung in der Quellsprache des Spiels sehen.";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "Fehler: Konnte nicht speichern. Bitte überprüfe den Inhalt auf Moderation und versuche es erneut.";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "Fehler: Konnte nicht speichern.";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "Wenn keine Übersetzungen bereitgestellt werden, sehen Benutzer die Werte der Quellsprache.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "Du hast nicht gespeicherte Änderungen. Möchtest du die Sprache wirklich wechseln?";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "Name und Beschreibung wurden gespeichert.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "Werte der Quellsprache werden als Referenz angezeigt. Sie können nur hier gesehen werden.";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "Werte löschen";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "Lokalisierung konfigurieren";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "Spielname und Beschreibungsübersetzungen";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "Nicht gespeicherte Änderungen";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Beschreibung: ";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "Gib die Spielbeschreibung hier ein";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "Spielinformationen";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "Spielname und Beschreibungsübersetzungen";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "Gib den Spielnamen hier ein (erforderlich)";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "Gib den Spielnamen hier ein";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "Lokalisierung";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Name: ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "Unterstützte Sprachen";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "Spielinformationen";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "Sprachen";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "Berichte";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "Einstellungen";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "Übersetzer";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "Titel";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "Fehler: Konnte nicht speichern. Bitte überprüfe den Inhalt auf Moderation und versuche es erneut.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Fehler: Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "Fehler: Konnte nicht speichern.";
	}
}
