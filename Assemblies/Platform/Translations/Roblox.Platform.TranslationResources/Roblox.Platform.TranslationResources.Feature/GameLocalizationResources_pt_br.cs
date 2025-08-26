namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_pt_br : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
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
	public override string ActionClear => "Limpar";

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
	public override string ActionSave => "Salvar";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "Erro: impossÃ­vel salvar. Certifique-se de que o conteÃºdo nÃ£o tem problemas de moderaÃ§Ã£o e tente de novo.";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "Erro: impossÃ­vel salvar.";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "Se nenhuma traduÃ§Ã£o for fornecida, os usuÃ¡rios verÃ£o os valores do idioma de origem.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "VocÃª possui alteraÃ§Ãµes nÃ£o salvas. Quer mesmo trocar o idioma?";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "Nome e descriÃ§Ã£o salvos.";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "Os valores do idioma de origem sÃ£o mostrados como referÃªncia. Eles sÃ³ podem ser visualizados aqui.";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "Limpar valores";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "Configurar localizaÃ§Ã£o";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "TraduÃ§Ãµes do nome e descriÃ§Ã£o do jogo";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "AlteraÃ§Ãµes nÃ£o salvas";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "DescriÃ§Ã£o: ";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "Insira a descriÃ§Ã£o do jogo aqui";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "InformaÃ§Ãµes do jogo";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "TraduÃ§Ãµes do nome e descriÃ§Ã£o do jogo";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "Insira o nome do jogo aqui (obrigatÃ³rio)";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "Insira o nome do jogo aqui";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "LocalizaÃ§Ã£o";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "Nome: ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "Idiomas inclusos";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "InformaÃ§Ãµes do jogo";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "Idiomas";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "DenÃºncias";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "ConfiguraÃ§Ãµes";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "Tradutores";

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
	public override string ResponseContentModerationError => "Erro: impossÃ­vel salvar. Certifique-se de que o conteÃºdo nÃ£o tem problemas de moderaÃ§Ã£o e tente de novo.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Erro: ocorreu um erro. Tente novamente mais tarde.";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "Erro: impossÃ­vel salvar.";

	public GameLocalizationResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "Limpar";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Confirmar";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Salvar";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"Quer mesmo apagar as traduÃ§Ãµes para {languageName}? Os usuÃ¡rios verÃ£o o nome e a descriÃ§Ã£o no idioma de origem do jogo.";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "Quer mesmo apagar as traduÃ§Ãµes para {languageName}? Os usuÃ¡rios verÃ£o o nome e a descriÃ§Ã£o no idioma de origem do jogo.";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "Erro: impossÃ­vel salvar. Certifique-se de que o conteÃºdo nÃ£o tem problemas de moderaÃ§Ã£o e tente de novo.";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "Erro: impossÃ­vel salvar.";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "Se nenhuma traduÃ§Ã£o for fornecida, os usuÃ¡rios verÃ£o os valores do idioma de origem.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "VocÃª possui alteraÃ§Ãµes nÃ£o salvas. Quer mesmo trocar o idioma?";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "Nome e descriÃ§Ã£o salvos.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "Os valores do idioma de origem sÃ£o mostrados como referÃªncia. Eles sÃ³ podem ser visualizados aqui.";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "Limpar valores";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "Configurar localizaÃ§Ã£o";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "TraduÃ§Ãµes do nome e descriÃ§Ã£o do jogo";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "AlteraÃ§Ãµes nÃ£o salvas";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "DescriÃ§Ã£o: ";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "Insira a descriÃ§Ã£o do jogo aqui";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "InformaÃ§Ãµes do jogo";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "TraduÃ§Ãµes do nome e descriÃ§Ã£o do jogo";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "Insira o nome do jogo aqui (obrigatÃ³rio)";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "Insira o nome do jogo aqui";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "LocalizaÃ§Ã£o";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Nome: ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "Idiomas inclusos";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "InformaÃ§Ãµes do jogo";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "Idiomas";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "DenÃºncias";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "ConfiguraÃ§Ãµes";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "Tradutores";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "TÃ­tulo";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "Erro: impossÃ­vel salvar. Certifique-se de que o conteÃºdo nÃ£o tem problemas de moderaÃ§Ã£o e tente de novo.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Erro: ocorreu um erro. Tente novamente mais tarde.";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "Erro: impossÃ­vel salvar.";
	}
}


}
