namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionClear => "æ¸…é™¤";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "åœ¨éŠçŽ©æœŸé–“è‡ªå‹•å¾žéŠæˆ² UI æ“·å–æ–‡å­—";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "æ‰€æœ‰è‡ªå‹•æ“·å–ä¸¦æœªç¿»è­¯çš„æ¢ç›®å°‡æœƒè¢«æ¸…é™¤ã€‚æ³¨æ„ï¼šæ‰€æœ‰é©ç”¨æ–‡å­—å°‡æœƒé‡æ–°è¢«è‡ªå‹•æ“·å–ã€‚";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "åœ¨éŠæˆ²å…§å•Ÿç”¨å·²ç¿»è­¯å…§å®¹";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "ç¢ºå®šæ¸…é™¤æ¢ç›®ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "éŠæˆ²å…§å®¹ç¿»è­¯";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "è‡ªå‹•æ–‡å­—æ“·å–ï¼š";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "æ¸…é™¤ä½ç¿»è­¯çš„è‡ªå‹•æ“·å–å­—ä¸²";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "å·²å•Ÿç”¨çœ¾åŒ…";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "å•Ÿç”¨è‡ªå‹• UI æ–‡å­—æ“·å–";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "é€²è¡Œä¸­";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "èªžè¨€";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "èªžè¨€";

	public override string LabelNotSpecified => "ï¼œæœªæŒ‡å®šï¼ž";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "æœªæ”¯æ´";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "é¡¯ç¤ºæ›´å¤šèªžè¨€â€¦";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "æºèªžè¨€";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "å·²æ”¯æ´";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "å·²æ”¯æ´ï¼ˆBeta æ¸¬è©¦ï¼‰";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "æ”¯æ´ç‹€æ…‹";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "ä½¿ç”¨å·²ç¿»è­¯çš„å…§å®¹ï¼š";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "å·²ç¢ºèªï¼Œä½œæ¥­å°‡æ–¼å¹¾åˆ†é˜å¾Œå®Œæˆã€‚";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "æˆåŠŸå„²å­˜è®Šæ›´";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "æ­£åœ¨æ›´æ–°â€¦";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "éŒ¯èª¤ï¼šç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "éŒ¯èª¤ï¼šç„¡æ³•è®Šæ›´è¨­å®šï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	public SupportedLanguagesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "æ¸…é™¤";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "åœ¨éŠçŽ©æœŸé–“è‡ªå‹•å¾žéŠæˆ² UI æ“·å–æ–‡å­—";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "æ‰€æœ‰è‡ªå‹•æ“·å–ä¸¦æœªç¿»è­¯çš„æ¢ç›®å°‡æœƒè¢«æ¸…é™¤ã€‚æ³¨æ„ï¼šæ‰€æœ‰é©ç”¨æ–‡å­—å°‡æœƒé‡æ–°è¢«è‡ªå‹•æ“·å–ã€‚";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"é–‹å•Ÿï¼šå•Ÿç”¨çœ¾åŒ…ï¼ˆè­¯è€…å¯ä»¥çœ‹åˆ°ä¸¦ç¿»è­¯éŠæˆ²å­—ä¸²ï¼‰{lineBreak}é—œé–‰ï¼šåœç”¨çœ¾åŒ…ï¼ˆè­¯è€…ç„¡æ³•çœ‹åˆ°æˆ–ç¿»è­¯éŠæˆ²å­—ä¸²ï¼‰";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "é–‹å•Ÿï¼šå•Ÿç”¨çœ¾åŒ…ï¼ˆè­¯è€…å¯ä»¥çœ‹åˆ°ä¸¦ç¿»è­¯éŠæˆ²å­—ä¸²ï¼‰{lineBreak}é—œé–‰ï¼šåœç”¨çœ¾åŒ…ï¼ˆè­¯è€…ç„¡æ³•çœ‹åˆ°æˆ–ç¿»è­¯éŠæˆ²å­—ä¸²ï¼‰";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"ç¶ è‰²æ©«æ¢ï¼šå·²æ ¸å‡†çš„å­—ä¸²æ¯”ä¾‹{lineBreak}è—è‰²æ©«æ¢ï¼šå·²ç¿»è­¯çš„å­—ä¸²æ¯”ä¾‹";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "ç¶ è‰²æ©«æ¢ï¼šå·²æ ¸å‡†çš„å­—ä¸²æ¯”ä¾‹{lineBreak}è—è‰²æ©«æ¢ï¼šå·²ç¿»è­¯çš„å­—ä¸²æ¯”ä¾‹";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"æ”¯æ´ç‹€æ…‹ä»£è¡¨è©²èªžè¨€æ˜¯å¦åˆ—åœ¨éŠæˆ²è©³ç´°è³‡æ–™é é¢ã€‚{lineBreak}å·²æ”¯æ´ - å·²åˆ—å…¥{lineBreak}é€²è¡Œä¸­ - ä½œç‚ºBeta æ¸¬è©¦åˆ—å…¥{lineBreak}æœªæ”¯æ´ - æœªåˆ—å…¥";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "æ”¯æ´ç‹€æ…‹ä»£è¡¨è©²èªžè¨€æ˜¯å¦åˆ—åœ¨éŠæˆ²è©³ç´°è³‡æ–™é é¢ã€‚{lineBreak}å·²æ”¯æ´ - å·²åˆ—å…¥{lineBreak}é€²è¡Œä¸­ - ä½œç‚ºBeta æ¸¬è©¦åˆ—å…¥{lineBreak}æœªæ”¯æ´ - æœªåˆ—å…¥";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "åœ¨éŠæˆ²å…§å•Ÿç”¨å·²ç¿»è­¯å…§å®¹";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "ç¢ºå®šæ¸…é™¤æ¢ç›®ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "éŠæˆ²å…§å®¹ç¿»è­¯";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "è‡ªå‹•æ–‡å­—æ“·å–ï¼š";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "æ¸…é™¤ä½ç¿»è­¯çš„è‡ªå‹•æ“·å–å­—ä¸²";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "å·²å•Ÿç”¨çœ¾åŒ…";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "å•Ÿç”¨è‡ªå‹• UI æ–‡å­—æ“·å–";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "é€²è¡Œä¸­";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "èªžè¨€";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "èªžè¨€";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"æœ¬åœ°åŒ–ç‹€æ…‹{lineBreak}ï¼ˆ{stringCount} å€‹å­—ä¸²ï¼‰";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "æœ¬åœ°åŒ–ç‹€æ…‹{lineBreak}ï¼ˆ{stringCount} å€‹å­—ä¸²ï¼‰";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "ï¼œæœªæŒ‡å®šï¼ž";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "æœªæ”¯æ´";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "é¡¯ç¤ºæ›´å¤šèªžè¨€â€¦";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "æºèªžè¨€";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "å·²æ”¯æ´";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "å·²æ”¯æ´ï¼ˆBeta æ¸¬è©¦ï¼‰";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "æ”¯æ´ç‹€æ…‹";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "ä½¿ç”¨å·²ç¿»è­¯çš„å…§å®¹ï¼š";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "å·²ç¢ºèªï¼Œä½œæ¥­å°‡æ–¼å¹¾åˆ†é˜å¾Œå®Œæˆã€‚";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "æˆåŠŸå„²å­˜è®Šæ›´";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "æ­£åœ¨æ›´æ–°â€¦";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "éŒ¯èª¤ï¼šç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "éŒ¯èª¤ï¼šç„¡æ³•è®Šæ›´è¨­å®šï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}
}


}
