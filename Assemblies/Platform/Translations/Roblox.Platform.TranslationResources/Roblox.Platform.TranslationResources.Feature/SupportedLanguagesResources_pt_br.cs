namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_pt_br : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Clear"
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "Limpar";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "Capturar automaticamente o texto da interface do jogo enquanto os usuários jogam";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "Todos os itens que foram automaticamente capturados e não possuem traduções serão retirados da sua tabela. Aviso: todo texto aplicável será recapturado automaticamente.";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "Habilitar conteúdo traduzido no jogo";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "Quer mesmo limpar os itens?";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "Traduções do conteúdo do jogo";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "Captura automática de texto: ";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "Limpar textos não traduzidos capturados automaticamente";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "Crowdsource ativado";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "Ativar captura de texto na UI automática";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "Em andamento";

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

	public override string LabelNotSpecified => "<Não especificado>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "Sem suporte";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "Exibir mais idiomas...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "Idioma de origem";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "Com suporte";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "Com suporte (beta)";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "Status com suporte";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "Use conteúdo traduzido: ";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "Confirmado. Fique ciente de que este processo pode levar vários minutos.";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "Ocorreu um erro. Tente novamente mais tarde.";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "Mudanças salvas com sucesso";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "Atualizando...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "Tentativas excessivas. Aguarde antes de tentar limpar de novo.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Erro: ocorreu um erro. Tente novamente mais tarde.";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "Erro: não foi possível alterar configuração. Tente de novo mais tarde.";

	public SupportedLanguagesResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "Limpar";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "Capturar automaticamente o texto da interface do jogo enquanto os usuários jogam";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "Todos os itens que foram automaticamente capturados e não possuem traduções serão retirados da sua tabela. Aviso: todo texto aplicável será recapturado automaticamente.";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"Ativado: o crowdsourcing está ativado (tradutores podem ver e traduzir textos do jogo){lineBreak}Desativado: o recurso de crowdsourcing está desativado (tradutores não podem ver ou traduzir textos do jogo)";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "Ativado: o crowdsourcing está ativado (tradutores podem ver e traduzir textos do jogo){lineBreak}Desativado: o recurso de crowdsourcing está desativado (tradutores não podem ver ou traduzir textos do jogo)";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"Barra verde: porcentagem de textos que foram aprovados{lineBreak}Barra azul: porcentagem de textos que foram traduzidos";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "Barra verde: porcentagem de textos que foram aprovados{lineBreak}Barra azul: porcentagem de textos que foram traduzidos";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"O status “com suporte” reflete se o idioma está listado na página de detalhes do jogo.{lineBreak}Com suporte - listado{lineBreak}Em andamento - listado como beta{lineBreak}Sem suporte - não listado";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "O status “com suporte” reflete se o idioma está listado na página de detalhes do jogo.{lineBreak}Com suporte - listado{lineBreak}Em andamento - listado como beta{lineBreak}Sem suporte - não listado";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "Habilitar conteúdo traduzido no jogo";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "Quer mesmo limpar os itens?";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "Traduções do conteúdo do jogo";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "Captura automática de texto: ";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "Limpar textos não traduzidos capturados automaticamente";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "Crowdsource ativado";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "Ativar captura de texto na UI automática";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "Em andamento";
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
		return $"Status de localização{lineBreak}({stringCount} textos)";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "Status de localização{lineBreak}({stringCount} textos)";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<Não especificado>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "Sem suporte";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "Exibir mais idiomas...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "Idioma de origem";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "Com suporte";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "Com suporte (beta)";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "Status com suporte";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "Use conteúdo traduzido: ";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "Confirmado. Fique ciente de que este processo pode levar vários minutos.";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "Ocorreu um erro. Tente novamente mais tarde.";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "Mudanças salvas com sucesso";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "Atualizando...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "Tentativas excessivas. Aguarde antes de tentar limpar de novo.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Erro: ocorreu um erro. Tente novamente mais tarde.";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "Erro: não foi possível alterar configuração. Tente de novo mais tarde.";
	}
}
