namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_fr_fr : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Clear"
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "Effacer";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "Capturer automatiquement le texte de l'interface du jeu alors que les utilisateurs jouent";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "Toutes les entrÃ©es ayant Ã©tÃ© capturÃ©es automatiquement et sans traduction seront effacÃ©es de ton tableau. Tout le texte applicable sera recapturÃ© automatiquement.";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "Autoriser le contenu traduit en jeu";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "Voulez-vous vraiment effacer toutes les entrÃ©es\u00a0?";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "Traductions du contenu en jeu";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "Capture automatique de texte\u00a0: ";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "Effacer les chaÃ®nes non traduites capturÃ©es automatiquement";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "Crowdsourcing activÃ©";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "Active l'IU de capture automatique de texte";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "En cours.";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "Langue";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "Langues";

	public override string LabelNotSpecified => "<Non spÃ©cifiÃ©e>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "Non prise en charge";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "Afficher plus de langues...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "Langue source";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "Prise en charge";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "Prise en charge (bÃªta)";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "Ã‰tat de prise en charge de langue";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "Utiliser du contenu traduit\u00a0: ";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "ConfirmÃ©. Veuillez remarquer que ce processus peut prendre plusieurs minutes.";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "Une erreur s'est produite, veuillez rÃ©essayer plus tard\u00a0!";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "Modifications enregistrÃ©es avec succÃ¨s";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "Mise Ã  jour...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "Trop de tentatives. Veuillez patienter un moment avant d'effacer Ã  nouveau.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Erreur\u00a0: une erreur s'est produite. Veuillez rÃ©essayer plus tard.";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "Erreur\u00a0: impossible de modifier le paramÃ¨tre. Veuillez rÃ©essayer plus tard.";

	public SupportedLanguagesResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "Effacer";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "Capturer automatiquement le texte de l'interface du jeu alors que les utilisateurs jouent";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "Toutes les entrÃ©es ayant Ã©tÃ© capturÃ©es automatiquement et sans traduction seront effacÃ©es de ton tableau. Tout le texte applicable sera recapturÃ© automatiquement.";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"ActivÃ©\u00a0: crowdsourcing activÃ© (les traducteurs peuvent voir et traduire les segments){lineBreak}DÃ©sactivÃ©\u00a0: crowdsourcing dÃ©sactivÃ© (les traducteurs ne peuvent ni voir ni traduire les segments)";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "ActivÃ©\u00a0: crowdsourcing activÃ© (les traducteurs peuvent voir et traduire les segments){lineBreak}DÃ©sactivÃ©\u00a0: crowdsourcing dÃ©sactivÃ© (les traducteurs ne peuvent ni voir ni traduire les segments)";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"Barre verte\u00a0: pourcentage de segments qui ont Ã©tÃ© approuvÃ©s{lineBreak}Barre bleue\u00a0: pourcentage de segments qui ont Ã©tÃ© traduits";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "Barre verte\u00a0: pourcentage de segments qui ont Ã©tÃ© approuvÃ©s{lineBreak}Barre bleue\u00a0: pourcentage de segments qui ont Ã©tÃ© traduits";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"L'Ã©tat de prise en charge d'une langue indique si elle est listÃ©e sur la page du jeu.{lineBreak}Prise en charge - listÃ©e{lineBreak}En cours - listÃ©e en bÃªta{lineBreak}Non prise en charge - non listÃ©e";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "L'Ã©tat de prise en charge d'une langue indique si elle est listÃ©e sur la page du jeu.{lineBreak}Prise en charge - listÃ©e{lineBreak}En cours - listÃ©e en bÃªta{lineBreak}Non prise en charge - non listÃ©e";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "Autoriser le contenu traduit en jeu";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "Voulez-vous vraiment effacer toutes les entrÃ©es\u00a0?";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "Traductions du contenu en jeu";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "Capture automatique de texte\u00a0: ";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "Effacer les chaÃ®nes non traduites capturÃ©es automatiquement";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "Crowdsourcing activÃ©";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "Active l'IU de capture automatique de texte";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "En cours.";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "Langue";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "Langues";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"Ã‰tat de la localisation{lineBreak}({stringCount}\u00a0segments)";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "Ã‰tat de la localisation{lineBreak}({stringCount}\u00a0segments)";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<Non spÃ©cifiÃ©e>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "Non prise en charge";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "Afficher plus de langues...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "Langue source";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "Prise en charge";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "Prise en charge (bÃªta)";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "Ã‰tat de prise en charge de langue";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "Utiliser du contenu traduit\u00a0: ";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "ConfirmÃ©. Veuillez remarquer que ce processus peut prendre plusieurs minutes.";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "Une erreur s'est produite, veuillez rÃ©essayer plus tard\u00a0!";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "Modifications enregistrÃ©es avec succÃ¨s";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "Mise Ã  jour...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "Trop de tentatives. Veuillez patienter un moment avant d'effacer Ã  nouveau.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Erreur\u00a0: une erreur s'est produite. Veuillez rÃ©essayer plus tard.";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "Erreur\u00a0: impossible de modifier le paramÃ¨tre. Veuillez rÃ©essayer plus tard.";
	}
}


}
