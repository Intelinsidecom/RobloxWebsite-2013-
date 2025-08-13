namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_ko_kr : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "언어 추가";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "삭제";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "번역 관리";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "내 게임에 지원하고 싶은 언어를 추가하세요.";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "언어 삭제";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "지원 언어";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "번역된 언어";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "언어";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "언어 선택";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "해당 언어로의 모든 번역이 삭제됩니다. 이 작업은 되돌릴 수 없습니다.";

	public GameLanguagesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "언어 추가";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "삭제";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "번역 관리";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "내 게임에 지원하고 싶은 언어를 추가하세요.";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "언어 삭제";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "지원 언어";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "번역된 언어";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "언어";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "언어 선택";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "해당 언어로의 모든 번역이 삭제됩니다. 이 작업은 되돌릴 수 없습니다.";
	}
}
