namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_zh_tw : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Clear"
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "清除";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "在遊玩期間自動從遊戲 UI 擷取文字";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "所有自動擷取並未翻譯的條目將會被清除。注意：所有適用文字將會重新被自動擷取。";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "在遊戲內啟用已翻譯內容";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "確定清除條目？";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "遊戲內容翻譯";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "自動文字擷取：";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "清除位翻譯的自動擷取字串";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "已啟用眾包";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "啟用自動 UI 文字擷取";

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
	public override string LabelLanguage => "語言";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "語言";

	public override string LabelNotSpecified => "＜未指定＞";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "未支援";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "顯示更多語言…";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "源語言";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "已支援";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "已支援（Beta 測試）";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "支援狀態";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "使用已翻譯的內容：";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "已確認，作業將於幾分鐘後完成。";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "成功儲存變更";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "正在更新…";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "嘗試次數過多，請稍後再試。";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "錯誤：發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "錯誤：無法變更設定，請重新嘗試。";

	public SupportedLanguagesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "清除";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "在遊玩期間自動從遊戲 UI 擷取文字";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "所有自動擷取並未翻譯的條目將會被清除。注意：所有適用文字將會重新被自動擷取。";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"開啟：啟用眾包（譯者可以看到並翻譯遊戲字串）{lineBreak}關閉：停用眾包（譯者無法看到或翻譯遊戲字串）";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "開啟：啟用眾包（譯者可以看到並翻譯遊戲字串）{lineBreak}關閉：停用眾包（譯者無法看到或翻譯遊戲字串）";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"綠色橫條：已核准的字串比例{lineBreak}藍色橫條：已翻譯的字串比例";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "綠色橫條：已核准的字串比例{lineBreak}藍色橫條：已翻譯的字串比例";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"支援狀態代表該語言是否列在遊戲詳細資料頁面。{lineBreak}已支援 - 已列入{lineBreak}進行中 - 作為Beta 測試列入{lineBreak}未支援 - 未列入";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "支援狀態代表該語言是否列在遊戲詳細資料頁面。{lineBreak}已支援 - 已列入{lineBreak}進行中 - 作為Beta 測試列入{lineBreak}未支援 - 未列入";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "在遊戲內啟用已翻譯內容";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "確定清除條目？";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "遊戲內容翻譯";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "自動文字擷取：";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "清除位翻譯的自動擷取字串";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "已啟用眾包";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "啟用自動 UI 文字擷取";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "進行中";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "語言";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "語言";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"本地化狀態{lineBreak}（{stringCount} 個字串）";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "本地化狀態{lineBreak}（{stringCount} 個字串）";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "＜未指定＞";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "未支援";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "顯示更多語言…";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "源語言";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "已支援";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "已支援（Beta 測試）";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "支援狀態";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "使用已翻譯的內容：";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "已確認，作業將於幾分鐘後完成。";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "成功儲存變更";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "正在更新…";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "嘗試次數過多，請稍後再試。";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "錯誤：發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "錯誤：無法變更設定，請重新嘗試。";
	}
}
