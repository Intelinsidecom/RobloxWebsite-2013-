namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_ja_jp : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "言語を追加";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "削除";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "翻訳を管理";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "対応させたい言語を追加してください。";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "言語を削除";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "対応言語";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "翻訳済みの言語";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "言語";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "言語を選択";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "この言語のすべての翻訳が削除されます。この操作は元に戻せません。";

	public GameLanguagesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "言語を追加";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "削除";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "翻訳を管理";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "対応させたい言語を追加してください。";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "言語を削除";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "対応言語";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "翻訳済みの言語";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "言語";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "言語を選択";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "この言語のすべての翻訳が削除されます。この操作は元に戻せません。";
	}
}
