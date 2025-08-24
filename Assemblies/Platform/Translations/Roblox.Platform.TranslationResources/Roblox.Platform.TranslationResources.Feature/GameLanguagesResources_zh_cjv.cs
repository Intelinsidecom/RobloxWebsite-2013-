namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_zh_cjv : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "添加语言";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "删除";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "管理翻译";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "请添加你希望游戏支持的语言。";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "删除语言";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "支持语言";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "已翻译语言";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "语言";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "选择语言";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "此语言的所有翻译将被删除。此操作不可撤销。";

	public GameLanguagesResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "添加语言";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "删除";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "管理翻译";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "请添加你希望游戏支持的语言。";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "删除语言";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "支持语言";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "已翻译语言";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "语言";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "选择语言";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "此语言的所有翻译将被删除。此操作不可撤销。";
	}
}
