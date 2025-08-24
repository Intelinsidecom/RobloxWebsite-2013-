namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_pt_br : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "Adicionar idioma";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Excluir";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "Gerenciar traduções";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "Adicione os idiomas que você quer ter no seu jogo.";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "Excluir idioma";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "Idiomas inclusos";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "Idiomas traduzidos";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "Idiomas";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "Selecionar idioma";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "Todas as traduções para este idioma serão excluídas. Esta ação é irreversível.";

	public GameLanguagesResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "Adicionar idioma";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Excluir";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "Gerenciar traduções";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "Adicione os idiomas que você quer ter no seu jogo.";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "Excluir idioma";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "Idiomas inclusos";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "Idiomas traduzidos";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "Idiomas";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "Selecionar idioma";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "Todas as traduções para este idioma serão excluídas. Esta ação é irreversível.";
	}
}
