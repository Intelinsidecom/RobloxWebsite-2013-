namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_es_es : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Clear"
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "Borrar";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "Capturar automáticamente el texto de la interfaz de usuario del juego mientras los jugadores juegan";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "Todas las entradas que han sido capturadas automáticamente y no están traducidas se borrarán de tu tabla. Nota: Todo el texto disponible se volverá a capturar automáticamente.";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "Activar el contenido traducido en el juego";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "¿Seguro que quieres borrar estas entradas?";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "Traducciones del contenido en el juego";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "Captura automática del texto: ";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "Borrar las cadenas sin traducción capturadas automáticamente";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "Colaboración masiva activada";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "Activar captura de texto automática de la interfaz de usuario";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "En curso";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "Idioma";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "Idiomas";

	public override string LabelNotSpecified => "<Sin especificar>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "No compatible";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "Mostrar más idiomas...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "Idioma de origen";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "Compatible";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "Compatible (beta)";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "Estado de compatibilidad";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "Utilizar contenido traducido: ";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "Confirmado. Ten en cuenta que este proceso puede tardar varios minutos.";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "Se ha producido un error. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "Cambios guardados correctamente";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "Actualizando...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "Demasiados intentos. Espera un momento antes de intentar borrar otra vez.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Error: se ha producido un error. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "Error: no se ha podido cambiar la configuración. Inténtalo de nuevo.";

	public SupportedLanguagesResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "Borrar";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "Capturar automáticamente el texto de la interfaz de usuario del juego mientras los jugadores juegan";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "Todas las entradas que han sido capturadas automáticamente y no están traducidas se borrarán de tu tabla. Nota: Todo el texto disponible se volverá a capturar automáticamente.";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"Activada: la colaboración masiva está activada (los traductores pueden ver y traducir las cadenas del juego){lineBreak}Desactivada: la colaboración masiva está desactivada (los traductores no pueden ver ni traducir las cadenas del juego)";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "Activada: la colaboración masiva está activada (los traductores pueden ver y traducir las cadenas del juego){lineBreak}Desactivada: la colaboración masiva está desactivada (los traductores no pueden ver ni traducir las cadenas del juego)";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"Barra verde: indica el porcentaje de cadenas que han sido aprobadas{lineBreak}Barra azul: indica el porcentaje de cadenas que han sido traducidas";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "Barra verde: indica el porcentaje de cadenas que han sido aprobadas{lineBreak}Barra azul: indica el porcentaje de cadenas que han sido traducidas";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"El estado de compatibilidad muestra si el idioma figura en la lista de la página de detalles del juego.{lineBreak}Compatible - incluido en la lista{lineBreak}En curso - incluido en la lista como beta{lineBreak}No compatible - no incluido en la lista";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "El estado de compatibilidad muestra si el idioma figura en la lista de la página de detalles del juego.{lineBreak}Compatible - incluido en la lista{lineBreak}En curso - incluido en la lista como beta{lineBreak}No compatible - no incluido en la lista";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "Activar el contenido traducido en el juego";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "¿Seguro que quieres borrar estas entradas?";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "Traducciones del contenido en el juego";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "Captura automática del texto: ";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "Borrar las cadenas sin traducción capturadas automáticamente";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "Colaboración masiva activada";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "Activar captura de texto automática de la interfaz de usuario";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "En curso";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "Idioma";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "Idiomas";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"Estado de la localización{lineBreak}({stringCount} cadenas)";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "Estado de la localización{lineBreak}({stringCount} cadenas)";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<Sin especificar>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "No compatible";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "Mostrar más idiomas...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "Idioma de origen";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "Compatible";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "Compatible (beta)";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "Estado de compatibilidad";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "Utilizar contenido traducido: ";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "Confirmado. Ten en cuenta que este proceso puede tardar varios minutos.";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "Se ha producido un error. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "Cambios guardados correctamente";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "Actualizando...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "Demasiados intentos. Espera un momento antes de intentar borrar otra vez.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Error: se ha producido un error. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "Error: no se ha podido cambiar la configuración. Inténtalo de nuevo.";
	}
}
