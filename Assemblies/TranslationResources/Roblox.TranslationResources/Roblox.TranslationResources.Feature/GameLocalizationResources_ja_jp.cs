namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_ja_jp : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "消す";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "確定";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "エラー: 保存できませんでした。コンテンツが規制対象になっていないかチェックしてからやり直してください。";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "エラー: 保存できませんでした。";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "翻訳がない場合、ソース言語の値が表示されます。";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "保存していない変更があります。言語を変更してよろしいですか？";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "名前と詳細を保存しました。";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "ソース言語の値は、参考用に表示されます。ここにしか、表示されません。";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "値を消す";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "翻訳の環境設定";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "ゲーム名と詳細の翻訳";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "保存されていない変更内容";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "詳細: ";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "ゲーム詳細の入力はこちら";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "ゲーム情報";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "ゲーム名と詳細の翻訳";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "ゲーム名の入力はこちら（必須）";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "ゲーム名の入力はこちら";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "翻訳";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "名前: ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "対応言語";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "ゲーム情報";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "言語";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "報告";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "設定";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "翻訳者";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "タイトル";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "エラー: 保存できませんでした。コンテンツが規制対象になっていないかチェックしてからやり直してください。";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "エラー: エラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "エラー: 保存できませんでした。";

	public GameLocalizationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "消す";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "確定";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"{languageName} の翻訳を消してよろしいですか？ゲーム名や詳細は、ソース言語で表示されます。";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "{languageName} の翻訳を消してよろしいですか？ゲーム名や詳細は、ソース言語で表示されます。";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "エラー: 保存できませんでした。コンテンツが規制対象になっていないかチェックしてからやり直してください。";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "エラー: 保存できませんでした。";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "翻訳がない場合、ソース言語の値が表示されます。";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "保存していない変更があります。言語を変更してよろしいですか？";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "名前と詳細を保存しました。";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "ソース言語の値は、参考用に表示されます。ここにしか、表示されません。";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "値を消す";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "翻訳の環境設定";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "ゲーム名と詳細の翻訳";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "保存されていない変更内容";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "詳細: ";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "ゲーム詳細の入力はこちら";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "ゲーム情報";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "ゲーム名と詳細の翻訳";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "ゲーム名の入力はこちら（必須）";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "ゲーム名の入力はこちら";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "翻訳";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "名前: ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "対応言語";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "ゲーム情報";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "言語";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "報告";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "設定";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "翻訳者";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "タイトル";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "エラー: 保存できませんでした。コンテンツが規制対象になっていないかチェックしてからやり直してください。";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "エラー: エラーが発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "エラー: 保存できませんでした。";
	}
}
