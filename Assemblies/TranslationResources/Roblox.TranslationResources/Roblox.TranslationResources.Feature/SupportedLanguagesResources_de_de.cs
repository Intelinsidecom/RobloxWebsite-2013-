namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_de_de : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Clear"
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "Löschen";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "Automatische Texterfassung der Spieloberfläche, während Benutzer spielen";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "Alle Einträge, die automatisch erfasst wurden und keine dazugehörenden Übersetzungen haben, werden aus deiner Tabelle gelöscht. Bitte beachte: alle zutreffende Texte werden automatisch neu erfasst.";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "Übersetzte Inhalte im Spiel aktivieren";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "Möchtest du wirklich deine Einträge löschen?";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "Übersetzung der Spielinhalte";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "Automatische Texterfassung: ";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "Nicht übersetzte, automatisch erfasste Strings löschen";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "Crowdsourcing aktiviert";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "Automatische UI-Texterfassung aktivieren";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "In Arbeit";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "Sprache";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "Sprachen";

	public override string LabelNotSpecified => "<Nicht festgelegt>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "Nicht unterstützt";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "Weitere Sprachen anzeigen\u00a0...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "Ausgangssprache";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "Unterstützt";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "Unterstützt (Beta)";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "Unterstützungsstatus";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "Übersetzte Inhalte benutzen: ";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "Bestätigt. Bitte beachte, dass dieser Vorgang mehrere Minuten dauern kann.";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "Änderungen erfolgreich gespeichert";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "Wird aktualisiert\u00a0...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "Zu viele Versuche. Bitte warte, bevor du das Löschen noch mal versuchst.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Fehler: Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "Fehler: Die Einstellung konnte nicht geändert werden. Bitte versuche es erneut.";

	public SupportedLanguagesResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "Automatische Texterfassung der Spieloberfläche, während Benutzer spielen";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "Alle Einträge, die automatisch erfasst wurden und keine dazugehörenden Übersetzungen haben, werden aus deiner Tabelle gelöscht. Bitte beachte: alle zutreffende Texte werden automatisch neu erfasst.";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"An: Crowdsourcing ist aktiviert (Übersetzer können Zeilen des Spiels sehen und übersetzen){lineBreak}Aus: Crowdsourcing ist deaktiviert (Übersetzer können Zeilen des Spiels weder sehen noch übersetzen)";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "An: Crowdsourcing ist aktiviert (Übersetzer können Zeilen des Spiels sehen und übersetzen){lineBreak}Aus: Crowdsourcing ist deaktiviert (Übersetzer können Zeilen des Spiels weder sehen noch übersetzen)";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"Grüne Leiste: Prozentsatz der bestätigten Zeilen{lineBreak}Blaue Leiste: Prozentsatz der übersetzten Zeilen";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "Grüne Leiste: Prozentsatz der bestätigten Zeilen{lineBreak}Blaue Leiste: Prozentsatz der übersetzten Zeilen";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"Der Unterstützungsstatus gibt an, ob die Sprache auf der Spielinfo-Seite angezeigt wird.{lineBreak}Unterstützt: gelistet{lineBreak}In Arbeit: als Beta gelistet{lineBreak}Nicht unterstützt: nicht gelistet";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "Der Unterstützungsstatus gibt an, ob die Sprache auf der Spielinfo-Seite angezeigt wird.{lineBreak}Unterstützt: gelistet{lineBreak}In Arbeit: als Beta gelistet{lineBreak}Nicht unterstützt: nicht gelistet";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "Übersetzte Inhalte im Spiel aktivieren";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "Möchtest du wirklich deine Einträge löschen?";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "Übersetzung der Spielinhalte";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "Automatische Texterfassung: ";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "Nicht übersetzte, automatisch erfasste Strings löschen";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "Crowdsourcing aktiviert";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "Automatische UI-Texterfassung aktivieren";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "In Arbeit";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "Sprache";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "Sprachen";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"Lokalisierungsstatus{lineBreak}({stringCount} Zeilen)";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "Lokalisierungsstatus{lineBreak}({stringCount} Zeilen)";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<Nicht festgelegt>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "Nicht unterstützt";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "Weitere Sprachen anzeigen\u00a0...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "Ausgangssprache";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "Unterstützt";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "Unterstützt (Beta)";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "Unterstützungsstatus";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "Übersetzte Inhalte benutzen: ";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "Bestätigt. Bitte beachte, dass dieser Vorgang mehrere Minuten dauern kann.";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "Änderungen erfolgreich gespeichert";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "Wird aktualisiert\u00a0...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "Zu viele Versuche. Bitte warte, bevor du das Löschen noch mal versuchst.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Fehler: Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "Fehler: Die Einstellung konnte nicht geändert werden. Bitte versuche es erneut.";
	}
}
