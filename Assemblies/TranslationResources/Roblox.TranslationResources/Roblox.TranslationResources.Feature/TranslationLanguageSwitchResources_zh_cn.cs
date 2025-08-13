namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_zh_cn : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "更改默认设置";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "你想要设置哪种语言作为默认语言？";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "删除";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "你可以指定默认语言和本地化语言，以便用户可查看其语言的游戏标题和描述。";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "请添加遗漏的翻译";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "所有本地化信息将被删除。";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "你有未保存的更改。是否确定要离开此页？";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* 如果 App Store 区域中没有可用的本地化应用程序信息，则将使用你的默认语言替代。";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "添加其他语言的翻译";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "要更改默认语言吗？";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "添加";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "添加其他语言";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public override string LabelChange => "更改";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "更改 / 添加其他语言";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "选取语言以查看/编辑翻译：";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "当前语言";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "默认";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "删除";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "语言";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public override string LabelNotSpecified => "未指定";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "搜索其他语言";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "设置默认语言";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "源";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "在游戏信息中查看可用语言";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "错误：发生错误。请稍后重试。";

	public TranslationLanguageSwitchResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "更改默认设置";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "你想要设置哪种语言作为默认语言？";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "删除";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "你可以指定默认语言和本地化语言，以便用户可查看其语言的游戏标题和描述。";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "请添加遗漏的翻译";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "所有本地化信息将被删除。";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "你有未保存的更改。是否确定要离开此页？";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* 如果 App Store 区域中没有可用的本地化应用程序信息，则将使用你的默认语言替代。";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "添加其他语言的翻译";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "要更改默认语言吗？";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"要删除“{languageName}”的本地化吗？";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "要删除“{languageName}”的本地化吗？";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "添加";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "添加其他语言";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "更改";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "更改 / 添加其他语言";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "选取语言以查看/编辑翻译：";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "当前语言";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "默认";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "删除";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "语言";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "未指定";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "搜索其他语言";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "设置默认语言";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "源";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"源语言（{languageName}）";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "源语言（{languageName}）";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "在游戏信息中查看可用语言";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "错误：发生错误。请稍后重试。";
	}
}
