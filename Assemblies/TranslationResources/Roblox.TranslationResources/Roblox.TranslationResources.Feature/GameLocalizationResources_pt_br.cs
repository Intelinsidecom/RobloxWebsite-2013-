namespace Roblox.TranslationResources.Feature;

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
	public override string DescriptionContentModerationError => "Erro: impossível salvar. Certifique-se de que o conteúdo não tem problemas de moderação e tente de novo.";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "Erro: impossível salvar.";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "Se nenhuma tradução for fornecida, os usuários verão os valores do idioma de origem.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "Você possui alterações não salvas. Quer mesmo trocar o idioma?";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "Nome e descrição salvos.";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "Os valores do idioma de origem são mostrados como referência. Eles só podem ser visualizados aqui.";

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
	public override string HeadingConfigureLocalization => "Configurar localização";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "Traduções do nome e descrição do jogo";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "Alterações não salvas";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "Descrição: ";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "Insira a descrição do jogo aqui";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "Informações do jogo";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "Traduções do nome e descrição do jogo";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "Insira o nome do jogo aqui (obrigatório)";

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
	public override string LabelLocalization => "Localização";

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
	public override string LabelTabGameInfo => "Informações do jogo";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "Idiomas";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "Denúncias";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "Configurações";

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
	public override string LabelTitle => "Título";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "Erro: impossível salvar. Certifique-se de que o conteúdo não tem problemas de moderação e tente de novo.";

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
	public override string ResponseGeneralSaveError => "Erro: impossível salvar.";

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
		return $"Quer mesmo apagar as traduções para {languageName}? Os usuários verão o nome e a descrição no idioma de origem do jogo.";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "Quer mesmo apagar as traduções para {languageName}? Os usuários verão o nome e a descrição no idioma de origem do jogo.";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "Erro: impossível salvar. Certifique-se de que o conteúdo não tem problemas de moderação e tente de novo.";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "Erro: impossível salvar.";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "Se nenhuma tradução for fornecida, os usuários verão os valores do idioma de origem.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "Você possui alterações não salvas. Quer mesmo trocar o idioma?";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "Nome e descrição salvos.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "Os valores do idioma de origem são mostrados como referência. Eles só podem ser visualizados aqui.";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "Limpar valores";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "Configurar localização";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "Traduções do nome e descrição do jogo";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "Alterações não salvas";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Descrição: ";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "Insira a descrição do jogo aqui";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "Informações do jogo";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "Traduções do nome e descrição do jogo";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "Insira o nome do jogo aqui (obrigatório)";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "Insira o nome do jogo aqui";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "Localização";
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
		return "Informações do jogo";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "Idiomas";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "Denúncias";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "Configurações";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "Tradutores";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "Título";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "Erro: impossível salvar. Certifique-se de que o conteúdo não tem problemas de moderação e tente de novo.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Erro: ocorreu um erro. Tente novamente mais tarde.";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "Erro: impossível salvar.";
	}
}
