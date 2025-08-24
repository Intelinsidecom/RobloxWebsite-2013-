namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_pt_br : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "Alterar padrão";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "Que idioma você deseja configurar como padrão?";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "Excluir";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "Você pode especificar o idioma padrão e localizado, para que o usuário possa ver o título do jogo e descrição em sua própria língua.";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "Adicione as traduções que estão faltando";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "Todas as informações localizadas serão excluídas.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "Você possui alterações não salvas. Quer mesmo sair desta página?";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* Se as informações de aplicativo localizadas não estiverem disponíveis em um território da App Store, as informações do idioma padrão serão usadas.";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "Adicionar traduções em outro(s) idioma(s)";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "Alterar idioma padrão?";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "Adicionar";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "Adicionar outro idioma";

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
	public override string LabelChange => "Alterar";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "Alterar / adicionar outro(s) idioma(s)";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "Escolha um idioma para ver/editar traduções: ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "Idioma atual";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "Padrão";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "Excluir";

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
	public override string LabelNotSpecified => "Não especificado";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "Adicionar outros idiomas";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "Definir idioma padrão";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "Original";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "Ver informações do jogo para idioma";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Erro: ocorreu um erro. Tente novamente mais tarde.";

	public TranslationLanguageSwitchResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "Alterar padrão";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "Que idioma você deseja configurar como padrão?";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "Excluir";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "Você pode especificar o idioma padrão e localizado, para que o usuário possa ver o título do jogo e descrição em sua própria língua.";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "Adicione as traduções que estão faltando";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "Todas as informações localizadas serão excluídas.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "Você possui alterações não salvas. Quer mesmo sair desta página?";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* Se as informações de aplicativo localizadas não estiverem disponíveis em um território da App Store, as informações do idioma padrão serão usadas.";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "Adicionar traduções em outro(s) idioma(s)";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "Alterar idioma padrão?";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"Excluir localização: {languageName}?";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "Excluir localização: {languageName}?";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "Adicionar";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "Adicionar outro idioma";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "Alterar";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "Alterar / adicionar outro(s) idioma(s)";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "Escolha um idioma para ver/editar traduções: ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "Idioma atual";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "Padrão";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "Excluir";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "Idioma";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "Não especificado";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "Adicionar outros idiomas";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "Definir idioma padrão";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "Original";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"Original ({languageName})";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "Original ({languageName})";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "Ver informações do jogo para idioma";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Erro: ocorreu um erro. Tente novamente mais tarde.";
	}
}
