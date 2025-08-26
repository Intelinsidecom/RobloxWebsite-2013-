namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_zh_cjv : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
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
	public override string DescriptionAutomaticTextCapture => "åœ¨ç”¨æˆ·åœ¨çŽ©æ¸¸æˆæ—¶è‡ªåŠ¨æ•æ‰æ¸¸æˆç•Œé¢çš„æ–‡æœ¬";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "æ‰€æœ‰è‡ªåŠ¨æ•æ‰å¹¶æœªç¿»è¯‘çš„æ¡ç›®å°†ä»Žä½ çš„è¡¨æ ¼ä¸­åˆ é™¤ã€‚è¯·æ³¨æ„ï¼šæ‰€æœ‰é€‚ç”¨çš„æ–‡æœ¬å°†è¢«è‡ªåŠ¨æ•æ‰ã€‚";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "åœ¨æ¸¸æˆä¸­å¯ç”¨å·²ç¿»è¯‘å†…å®¹";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "ç¡®å®šè¦æ¸…é™¤è¿™äº›æ¡ç›®å—ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "æ¸¸æˆå†…å®¹ç¿»è¯‘";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "è‡ªåŠ¨åŒ–æ–‡æœ¬æ•æ‰ï¼š";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "æ¸…é™¤æœªç¿»è¯‘çš„è‡ªåŠ¨æ•æ‰å­—ç¬¦ä¸²";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "ä¼—åŒ…å·²å¯ç”¨";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "å¯ç”¨è‡ªåŠ¨ UI æ–‡æœ¬æ•æ‰";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "è¿›è¡Œä¸­";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "è¯­è¨€";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "è¯­è¨€";

	public override string LabelNotSpecified => "<æœªæŒ‡å®š>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "ä¸æ”¯æŒ";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "æ˜¾ç¤ºæ›´å¤šè¯­è¨€...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "æºè¯­è¨€";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "å·²æ”¯æŒ";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "å·²æ”¯æŒï¼ˆbeta ç‰ˆï¼‰";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "æ”¯æŒçŠ¶æ€";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "ä½¿ç”¨å·²ç¿»è¯‘å†…å®¹ï¼š";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "å·²ç¡®è®¤ã€‚è¯·æ³¨æ„è¿™ä¸ªè¿‡ç¨‹å¯èƒ½æŒç»­å‡ åˆ†é’Ÿã€‚";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ï¼";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "æˆåŠŸä¿å­˜æ›´æ”¹";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "æ­£åœ¨æ›´æ–°...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨å€™ï¼Œç„¶åŽå†å°è¯•æ¸…é™¤ã€‚";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "é”™è¯¯ï¼šå‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "é”™è¯¯ï¼šæ— æ³•æ›´æ”¹è®¾ç½®ã€‚è¯·é‡è¯•ã€‚";

	public SupportedLanguagesResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "æ¸…é™¤";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "åœ¨ç”¨æˆ·åœ¨çŽ©æ¸¸æˆæ—¶è‡ªåŠ¨æ•æ‰æ¸¸æˆç•Œé¢çš„æ–‡æœ¬";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "æ‰€æœ‰è‡ªåŠ¨æ•æ‰å¹¶æœªç¿»è¯‘çš„æ¡ç›®å°†ä»Žä½ çš„è¡¨æ ¼ä¸­åˆ é™¤ã€‚è¯·æ³¨æ„ï¼šæ‰€æœ‰é€‚ç”¨çš„æ–‡æœ¬å°†è¢«è‡ªåŠ¨æ•æ‰ã€‚";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"å¼€å¯ï¼šä¼—åŒ…å·²å¯ç”¨ï¼ˆè¯‘è€…å¯çœ‹åˆ°å¹¶ç¿»è¯‘æ¸¸æˆå­—ç¬¦ä¸²ï¼‰{lineBreak}å…³é—­ï¼šä¼—åŒ…å·²åœç”¨ï¼ˆè¯‘è€…ä¸èƒ½çœ‹åˆ°æˆ–ç¿»è¯‘æ¸¸æˆå­—ç¬¦ä¸²ï¼‰";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "å¼€å¯ï¼šä¼—åŒ…å·²å¯ç”¨ï¼ˆè¯‘è€…å¯çœ‹åˆ°å¹¶ç¿»è¯‘æ¸¸æˆå­—ç¬¦ä¸²ï¼‰{lineBreak}å…³é—­ï¼šä¼—åŒ…å·²åœç”¨ï¼ˆè¯‘è€…ä¸èƒ½çœ‹åˆ°æˆ–ç¿»è¯‘æ¸¸æˆå­—ç¬¦ä¸²ï¼‰";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"ç»¿è‰²æ ï¼šå·²æ‰¹å‡†çš„å­—ç¬¦ä¸²ç™¾åˆ†æ¯”{lineBreak}è“è‰²æ ï¼šå·²ç¿»è¯‘çš„å­—ç¬¦ä¸²ç™¾åˆ†æ¯”";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "ç»¿è‰²æ ï¼šå·²æ‰¹å‡†çš„å­—ç¬¦ä¸²ç™¾åˆ†æ¯”{lineBreak}è“è‰²æ ï¼šå·²ç¿»è¯‘çš„å­—ç¬¦ä¸²ç™¾åˆ†æ¯”";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"å·²æ”¯æŒçŠ¶æ€åæ˜ è¯­è¨€æ˜¯å¦åˆ—åœ¨æ¸¸æˆè¯¦æƒ…é¡µé¢ä¸Šã€‚{lineBreak}å·²æ”¯æŒ - å·²åˆ—å‡º{lineBreak}è¿›è¡Œä¸­ - åˆ—ä¸º beta ç‰ˆ{lineBreak}ä¸æ”¯æŒ - æœªåˆ—å‡º";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "å·²æ”¯æŒçŠ¶æ€åæ˜ è¯­è¨€æ˜¯å¦åˆ—åœ¨æ¸¸æˆè¯¦æƒ…é¡µé¢ä¸Šã€‚{lineBreak}å·²æ”¯æŒ - å·²åˆ—å‡º{lineBreak}è¿›è¡Œä¸­ - åˆ—ä¸º beta ç‰ˆ{lineBreak}ä¸æ”¯æŒ - æœªåˆ—å‡º";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "åœ¨æ¸¸æˆä¸­å¯ç”¨å·²ç¿»è¯‘å†…å®¹";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "ç¡®å®šè¦æ¸…é™¤è¿™äº›æ¡ç›®å—ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "æ¸¸æˆå†…å®¹ç¿»è¯‘";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "è‡ªåŠ¨åŒ–æ–‡æœ¬æ•æ‰ï¼š";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "æ¸…é™¤æœªç¿»è¯‘çš„è‡ªåŠ¨æ•æ‰å­—ç¬¦ä¸²";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "ä¼—åŒ…å·²å¯ç”¨";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "å¯ç”¨è‡ªåŠ¨ UI æ–‡æœ¬æ•æ‰";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "è¿›è¡Œä¸­";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "è¯­è¨€";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "è¯­è¨€";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"æœ¬åœ°åŒ–çŠ¶æ€{lineBreak}ï¼ˆ{stringCount} ä¸ªå­—ç¬¦ä¸²ï¼‰";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "æœ¬åœ°åŒ–çŠ¶æ€{lineBreak}ï¼ˆ{stringCount} ä¸ªå­—ç¬¦ä¸²ï¼‰";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<æœªæŒ‡å®š>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "ä¸æ”¯æŒ";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "æ˜¾ç¤ºæ›´å¤šè¯­è¨€...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "æºè¯­è¨€";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "å·²æ”¯æŒ";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "å·²æ”¯æŒï¼ˆbeta ç‰ˆï¼‰";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "æ”¯æŒçŠ¶æ€";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "ä½¿ç”¨å·²ç¿»è¯‘å†…å®¹ï¼š";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "å·²ç¡®è®¤ã€‚è¯·æ³¨æ„è¿™ä¸ªè¿‡ç¨‹å¯èƒ½æŒç»­å‡ åˆ†é’Ÿã€‚";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "å‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ï¼";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "æˆåŠŸä¿å­˜æ›´æ”¹";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "æ­£åœ¨æ›´æ–°...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨å€™ï¼Œç„¶åŽå†å°è¯•æ¸…é™¤ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "é”™è¯¯ï¼šå‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "é”™è¯¯ï¼šæ— æ³•æ›´æ”¹è®¾ç½®ã€‚è¯·é‡è¯•ã€‚";
	}
}


}
