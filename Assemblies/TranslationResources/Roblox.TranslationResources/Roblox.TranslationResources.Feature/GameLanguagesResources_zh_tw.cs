namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_zh_tw : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "增加語言";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "刪除";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "管理翻譯";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "請加入您的遊戲要支援的語言。";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "刪除語言";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "支援語言";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "已翻譯語言";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "語言";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "選擇語言";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "即將刪除所有此語言的翻譯。此動作無法復原。";

	public GameLanguagesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "增加語言";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "刪除";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "管理翻譯";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "請加入您的遊戲要支援的語言。";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "刪除語言";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "支援語言";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "已翻譯語言";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "語言";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "選擇語言";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "即將刪除所有此語言的翻譯。此動作無法復原。";
	}
}
