namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_ja_jp : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "デフォルトの変更";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "どの言語をデフォルト言語に設定しますか？";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "削除";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "デフォルト言語と翻訳言語を指定すると、ユーザーがゲームタイトルと詳細を現地の言語で見れるようにできます。";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "欠落している翻訳を追加してください";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "翻訳済みデータがすべて削除されました。";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "保存していない変更があります。このページを終了してよろしいですか？";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* App Storeの地域で、翻訳済みアプリ情報が利用できない場合、デフォルト言語の情報が代わりに使われます。";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "別の言語の翻訳を追加";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "デフォルト言語を変更しますか？";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "追加";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "他の言語を追加";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "キャンセル";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public override string LabelChange => "変更";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "他の言語に変更/他の言語を追加";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "翻訳の確認/編集を行う言語を選択: ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "現在の言語";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "デフォルト";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "削除";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "言語";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public override string LabelNotSpecified => "指定されていません";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "他の言語を検索";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "デフォルト言語を設定する";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "ソース";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "ゲーム情報で言語を表示";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "エラー: エラーが発生しました。後でもう一度お試しください。";

	public TranslationLanguageSwitchResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "デフォルトの変更";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "どの言語をデフォルト言語に設定しますか？";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "削除";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "デフォルト言語と翻訳言語を指定すると、ユーザーがゲームタイトルと詳細を現地の言語で見れるようにできます。";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "欠落している翻訳を追加してください";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "翻訳済みデータがすべて削除されました。";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "保存していない変更があります。このページを終了してよろしいですか？";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* App Storeの地域で、翻訳済みアプリ情報が利用できない場合、デフォルト言語の情報が代わりに使われます。";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "別の言語の翻訳を追加";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "デフォルト言語を変更しますか？";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"{languageName}の翻訳を削除しますか？";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "{languageName}の翻訳を削除しますか？";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "追加";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "他の言語を追加";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "変更";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "他の言語に変更/他の言語を追加";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "翻訳の確認/編集を行う言語を選択: ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "現在の言語";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "デフォルト";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "削除";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "言語";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "指定されていません";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "他の言語を検索";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "デフォルト言語を設定する";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "ソース";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"ソース（{languageName}）";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "ソース（{languageName}）";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "ゲーム情報で言語を表示";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "エラー: エラーが発生しました。後でもう一度お試しください。";
	}
}
