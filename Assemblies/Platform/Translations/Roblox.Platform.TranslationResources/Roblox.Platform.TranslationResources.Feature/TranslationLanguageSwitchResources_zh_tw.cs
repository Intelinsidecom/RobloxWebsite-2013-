namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_zh_tw : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "變更預設";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "您想要將哪一種語言設為預設語言？";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "刪除";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "您可以指定預設和本地化的語言，使其它使用者可以看到其語言的遊戲標題和說明。";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "請新增遺漏的翻譯";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "將刪除所有本地化資訊。";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "您有未儲存的變更。確定離開此頁面？";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "＊若 App Store 區域沒有本地化 App 資訊，我們將會使用您的預設語言的資訊。";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "新增其它語言的翻譯";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "要變更預設語言嗎？";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "新增";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "新增其它語言";

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
	public override string LabelChange => "變更";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "變更 / 新增其它語言";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "選擇一種語言開始檢視及編輯翻譯： ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "目前語言";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "預設";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "刪除";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "語言";

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
	public override string LabelSearchLanguages => "搜尋其它語言";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "設定預設語言";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "來源";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "檢視遊戲資訊查看可用語言";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "錯誤：發生錯誤，請稍後再試。";

	public TranslationLanguageSwitchResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "變更預設";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "您想要將哪一種語言設為預設語言？";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "刪除";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "您可以指定預設和本地化的語言，使其它使用者可以看到其語言的遊戲標題和說明。";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "請新增遺漏的翻譯";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "將刪除所有本地化資訊。";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "您有未儲存的變更。確定離開此頁面？";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "＊若 App Store 區域沒有本地化 App 資訊，我們將會使用您的預設語言的資訊。";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "新增其它語言的翻譯";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "要變更預設語言嗎？";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"要刪除{languageName}翻譯嗎？";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "要刪除{languageName}翻譯嗎？";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "新增";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "新增其它語言";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "變更";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "變更 / 新增其它語言";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "選擇一種語言開始檢視及編輯翻譯： ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "目前語言";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "預設";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "刪除";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "語言";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "未指定";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "搜尋其它語言";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "設定預設語言";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "來源";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"來源語言（{languageName}）";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "來源語言（{languageName}）";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "檢視遊戲資訊查看可用語言";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "錯誤：發生錯誤，請稍後再試。";
	}
}
