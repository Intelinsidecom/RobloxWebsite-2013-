namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_zh_cn : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
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
	public override string DescriptionAutomaticTextCapture => "在用户在玩游戏时自动捕捉游戏界面的文本";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "所有自动捕捉并未翻译的条目将从你的表格中删除。请注意：所有适用的文本将被自动捕捉。";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "在游戏中启用已翻译内容";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "确定要清除这些条目吗？";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "游戏内容翻译";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "自动化文本捕捉：";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "清除未翻译的自动捕捉字符串";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "众包已启用";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "启用自动 UI 文本捕捉";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "进行中";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "语言";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "语言";

	public override string LabelNotSpecified => "<未指定>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "不支持";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "显示更多语言...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "源语言";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "已支持";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "已支持（beta 版）";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "支持状态";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "使用已翻译内容：";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "已确认。请注意这个过程可能持续几分钟。";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "发生错误。请稍后重试！";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "成功保存更改";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "正在更新...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "尝试次数过多。请稍候，然后再尝试清除。";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "错误：发生错误。请稍后重试。";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "错误：无法更改设置。请重试。";

	public SupportedLanguagesResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "清除";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "在用户在玩游戏时自动捕捉游戏界面的文本";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "所有自动捕捉并未翻译的条目将从你的表格中删除。请注意：所有适用的文本将被自动捕捉。";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"开启：众包已启用（译者可看到并翻译游戏字符串）{lineBreak}关闭：众包已停用（译者不能看到或翻译游戏字符串）";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "开启：众包已启用（译者可看到并翻译游戏字符串）{lineBreak}关闭：众包已停用（译者不能看到或翻译游戏字符串）";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"绿色栏：已批准的字符串百分比{lineBreak}蓝色栏：已翻译的字符串百分比";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "绿色栏：已批准的字符串百分比{lineBreak}蓝色栏：已翻译的字符串百分比";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"已支持状态反映语言是否列在游戏详情页面上。{lineBreak}已支持 - 已列出{lineBreak}进行中 - 列为 beta 版{lineBreak}不支持 - 未列出";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "已支持状态反映语言是否列在游戏详情页面上。{lineBreak}已支持 - 已列出{lineBreak}进行中 - 列为 beta 版{lineBreak}不支持 - 未列出";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "在游戏中启用已翻译内容";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "确定要清除这些条目吗？";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "游戏内容翻译";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "自动化文本捕捉：";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "清除未翻译的自动捕捉字符串";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "众包已启用";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "启用自动 UI 文本捕捉";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "进行中";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "语言";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "语言";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"本地化状态{lineBreak}（{stringCount} 个字符串）";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "本地化状态{lineBreak}（{stringCount} 个字符串）";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<未指定>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "不支持";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "显示更多语言...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "源语言";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "已支持";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "已支持（beta 版）";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "支持状态";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "使用已翻译内容：";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "已确认。请注意这个过程可能持续几分钟。";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "发生错误。请稍后重试！";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "成功保存更改";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "正在更新...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "尝试次数过多。请稍候，然后再尝试清除。";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "错误：发生错误。请稍后重试。";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "错误：无法更改设置。请重试。";
	}
}
