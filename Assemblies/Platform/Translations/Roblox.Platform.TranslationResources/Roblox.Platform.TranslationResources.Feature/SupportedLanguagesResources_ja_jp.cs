namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_ja_jp : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Clear"
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "消す";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "プレイ中にゲームUIからテキストを自動キャプチャ";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "自動的にキャプチャされた翻訳のないエントリーは、すべてテーブルから消去されます。注：該当するテキストはすべて自動的に再度キャプチャされます。";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "翻訳済みのコンテンツをゲーム内で有効にする";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "エントリーを消去してよろしいですか？";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "ゲームコンテンツの翻訳中";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "自動テキストキャプチャ: ";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "自動キャプチャされた未翻訳の文字列を消す";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "クラウドソースが利用できます";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "自動UIテキストキャプチャを有効にする";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "進行中";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "言語";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "言語";

	public override string LabelNotSpecified => "<指定されていません>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "対応していません";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "他の言語を表示...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "ソース言語";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "対応済み";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "対応済み（ベータ）";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "対応状況";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "翻訳済みのコンテンツを使う: ";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "確認しました。この処理には数分かかる場合があります。";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "エラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "変更が保存されました";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "アップデート中...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "試行回数が多すぎます。クリアするには、しばらくしてからやり直してください。";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "エラー: エラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "エラー: 設定を変更できませんでした。もう一度お試しください。";

	public SupportedLanguagesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "消す";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "プレイ中にゲームUIからテキストを自動キャプチャ";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "自動的にキャプチャされた翻訳のないエントリーは、すべてテーブルから消去されます。注：該当するテキストはすべて自動的に再度キャプチャされます。";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"オン: クラウドソースが利用できます（翻訳者がゲームの文字列を見て翻訳できます）{lineBreak}オフ: クラウドソースは利用できません（翻訳者はゲームの文字列を見たり翻訳することができません）";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "オン: クラウドソースが利用できます（翻訳者がゲームの文字列を見て翻訳できます）{lineBreak}オフ: クラウドソースは利用できません（翻訳者はゲームの文字列を見たり翻訳することができません）";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"緑色のバー: 承認された文字列の割合{lineBreak}青色のバー: 翻訳された文字列の割合";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "緑色のバー: 承認された文字列の割合{lineBreak}青色のバー: 翻訳された文字列の割合";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"対応状況は言語がゲームの詳細ページに載っているかどうかを反映しています。{lineBreak}対応しています - 掲載{lineBreak}進行中 - ベータとして掲載{lineBreak}対応していません - 非掲載";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "対応状況は言語がゲームの詳細ページに載っているかどうかを反映しています。{lineBreak}対応しています - 掲載{lineBreak}進行中 - ベータとして掲載{lineBreak}対応していません - 非掲載";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "翻訳済みのコンテンツをゲーム内で有効にする";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "エントリーを消去してよろしいですか？";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "ゲームコンテンツの翻訳中";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "自動テキストキャプチャ: ";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "自動キャプチャされた未翻訳の文字列を消す";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "クラウドソースが利用できます";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "自動UIテキストキャプチャを有効にする";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "進行中";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "言語";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "言語";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"翻訳状況{lineBreak}（文字列{stringCount}）";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "翻訳状況{lineBreak}（文字列{stringCount}）";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<指定されていません>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "対応していません";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "他の言語を表示...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "ソース言語";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "対応済み";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "対応済み（ベータ）";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "対応状況";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "翻訳済みのコンテンツを使う: ";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "確認しました。この処理には数分かかる場合があります。";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "エラーが発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "変更が保存されました";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "アップデート中...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "試行回数が多すぎます。クリアするには、しばらくしてからやり直してください。";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "エラー: エラーが発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "エラー: 設定を変更できませんでした。もう一度お試しください。";
	}
}
