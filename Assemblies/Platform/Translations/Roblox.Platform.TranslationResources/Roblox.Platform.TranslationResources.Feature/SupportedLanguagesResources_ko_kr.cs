namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_ko_kr : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Clear"
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "ì‚­ì œ";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "ì‚¬ìš©ìž í”Œë ˆì´ ì¤‘ ê²Œìž„ í…ìŠ¤íŠ¸ ìžë™ ìº¡ì³";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "ìžë™ìœ¼ë¡œ ìº¡ì²˜ë˜ê³  ë²ˆì—­ë˜ì§€ ì•Šì€ ëª¨ë“  ìž…ë ¥ ë‚´ìš©ì´ í…Œì´ë¸”ì—ì„œ ì‚­ì œë©ë‹ˆë‹¤. ì°¸ê³ : í•´ë‹¹í•˜ëŠ” ëª¨ë“  í…ìŠ¤íŠ¸ëŠ” ìžë™ìœ¼ë¡œ ë‹¤ì‹œ ìº¡ì²˜ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "ê²Œìž„ ë‚´ ì½˜í…ì¸  ë²ˆì—­ í™œì„±í™”";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "ì •ë§ë¡œ ì—”íŠ¸ë¦¬ë¥¼ ì‚­ì œí• ê¹Œìš”?";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "ê²Œìž„ ë‚´ ì½˜í…ì¸  ë²ˆì—­";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "ìžë™ í…ìŠ¤íŠ¸ ìº¡ì²˜: ";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "ë²ˆì—­ë˜ì§€ ì•Šì€ ìžë™ ìº¡ì²˜ ìŠ¤íŠ¸ë§ ì‚­ì œ";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "í¬ë¼ìš°ë“œì†ŒìŠ¤ í™œì„±í™”ë¨";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "ìžë™ UI í…ìŠ¤íŠ¸ ìº¡ì²˜ í™œì„±í™”";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "ì§„í–‰ ì¤‘";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "ì–¸ì–´";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "ì–¸ì–´";

	public override string LabelNotSpecified => "<ì§€ì •ë˜ì§€ ì•ŠìŒ>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "ì§€ì›ë˜ì§€ ì•ŠìŒ";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "ë” ë§Žì€ ì–¸ì–´ í‘œì‹œ...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "ì†ŒìŠ¤ ì–¸ì–´";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "ì§€ì›ë¨";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "ì§€ì›ë¨ (ë² íƒ€)";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "ì§€ì› ìƒíƒœ";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "ë²ˆì—­ ì½˜í…ì¸  ì‚¬ìš©: ";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "í™•ì¸. ì´ ìž‘ì—…ì„ ìˆ˜í–‰í•˜ëŠ” ë° ëª‡ ë¶„ ì •ë„ ì†Œìš”ë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "ë³€ê²½ ë‚´ìš©ì´ ì„±ê³µì ìœ¼ë¡œ ì €ìž¥ë˜ì—ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "ì—…ë°ì´íŠ¸ ì¤‘...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "ì‹œë„ íšŸìˆ˜ê°€ ë„ˆë¬´ ë§ŽìŠµë‹ˆë‹¤. ìž ì‹œ í›„ì— ë‹¤ì‹œ ì‚­ì œë¥¼ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ì˜¤ë¥˜: ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "ì˜¤ë¥˜: ì„¤ì •ì„ ë³€ê²½í•  ìˆ˜ ì—†ì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public SupportedLanguagesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "ì‚¬ìš©ìž í”Œë ˆì´ ì¤‘ ê²Œìž„ í…ìŠ¤íŠ¸ ìžë™ ìº¡ì³";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "ìžë™ìœ¼ë¡œ ìº¡ì²˜ë˜ê³  ë²ˆì—­ë˜ì§€ ì•Šì€ ëª¨ë“  ìž…ë ¥ ë‚´ìš©ì´ í…Œì´ë¸”ì—ì„œ ì‚­ì œë©ë‹ˆë‹¤. ì°¸ê³ : í•´ë‹¹í•˜ëŠ” ëª¨ë“  í…ìŠ¤íŠ¸ëŠ” ìžë™ìœ¼ë¡œ ë‹¤ì‹œ ìº¡ì²˜ë©ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"ì¼œê¸°: í¬ë¼ìš°ë“œì†Œì‹±ì´ í™œì„±í™”(ë³€ì—­ì‚¬ê°€ ê²Œìž„ ë¬¸ìžì—´ì„ ë³´ê³  ë²ˆì—­í•  ìˆ˜ ìžˆìŒ){lineBreak}ë„ê¸°: í¬ë¼ìš°ë“œì†Œì‹±ì´ ë¹„í™œì„±í™”(ë²ˆì—­ì‚¬ê°€ ê²Œìž„ ë¬¸ìžì—´ì„ ë³´ê±°ë‚˜ ë²ˆì—­í•  ìˆ˜ ì—†ìŒ)";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "ì¼œê¸°: í¬ë¼ìš°ë“œì†Œì‹±ì´ í™œì„±í™”(ë³€ì—­ì‚¬ê°€ ê²Œìž„ ë¬¸ìžì—´ì„ ë³´ê³  ë²ˆì—­í•  ìˆ˜ ìžˆìŒ){lineBreak}ë„ê¸°: í¬ë¼ìš°ë“œì†Œì‹±ì´ ë¹„í™œì„±í™”(ë²ˆì—­ì‚¬ê°€ ê²Œìž„ ë¬¸ìžì—´ì„ ë³´ê±°ë‚˜ ë²ˆì—­í•  ìˆ˜ ì—†ìŒ)";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"ë…¹ìƒ‰ ë§‰ëŒ€: ìŠ¹ì¸ëœ ë¬¸ìžì—´ì˜ ë°±ë¶„ìœ¨{lineBreak}íŒŒëž€ìƒ‰ ë§‰ëŒ€: ë²ˆì—­ëœ ë¬¸ìžì—´ì˜ ë°±ë¶„ìœ¨";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "ë…¹ìƒ‰ ë§‰ëŒ€: ìŠ¹ì¸ëœ ë¬¸ìžì—´ì˜ ë°±ë¶„ìœ¨{lineBreak}íŒŒëž€ìƒ‰ ë§‰ëŒ€: ë²ˆì—­ëœ ë¬¸ìžì—´ì˜ ë°±ë¶„ìœ¨";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"ì§€ì› ìƒíƒœëŠ” í•´ë‹¹ ì–¸ì–´ê°€ ê²Œìž„ ì„¤ëª… íŽ˜ì´ì§€ì— í‘œì‹œë˜ëŠ”ì§€ ì—¬ë¶€ë¥¼ ë³´ì—¬ì¤ë‹ˆë‹¤.{lineBreak}ì§€ì›ë¨ - í‘œì‹œë¨{lineBreak}ì§„í–‰ ì¤‘ - ë² íƒ€ë¡œ í‘œì‹œë¨{lineBreak}ì§€ì›ë˜ì§€ ì•ŠìŒ - í‘œì‹œë˜ì§€ ì•ŠìŒ";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "ì§€ì› ìƒíƒœëŠ” í•´ë‹¹ ì–¸ì–´ê°€ ê²Œìž„ ì„¤ëª… íŽ˜ì´ì§€ì— í‘œì‹œë˜ëŠ”ì§€ ì—¬ë¶€ë¥¼ ë³´ì—¬ì¤ë‹ˆë‹¤.{lineBreak}ì§€ì›ë¨ - í‘œì‹œë¨{lineBreak}ì§„í–‰ ì¤‘ - ë² íƒ€ë¡œ í‘œì‹œë¨{lineBreak}ì§€ì›ë˜ì§€ ì•ŠìŒ - í‘œì‹œë˜ì§€ ì•ŠìŒ";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "ê²Œìž„ ë‚´ ì½˜í…ì¸  ë²ˆì—­ í™œì„±í™”";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "ì •ë§ë¡œ ì—”íŠ¸ë¦¬ë¥¼ ì‚­ì œí• ê¹Œìš”?";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "ê²Œìž„ ë‚´ ì½˜í…ì¸  ë²ˆì—­";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "ìžë™ í…ìŠ¤íŠ¸ ìº¡ì²˜: ";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "ë²ˆì—­ë˜ì§€ ì•Šì€ ìžë™ ìº¡ì²˜ ìŠ¤íŠ¸ë§ ì‚­ì œ";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "í¬ë¼ìš°ë“œì†ŒìŠ¤ í™œì„±í™”ë¨";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "ìžë™ UI í…ìŠ¤íŠ¸ ìº¡ì²˜ í™œì„±í™”";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "ì§„í–‰ ì¤‘";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "ì–¸ì–´";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "ì–¸ì–´";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"ë¡œì»¬ë¦¬ì œì´ì…˜ ìƒíƒœ{lineBreak}({stringCount}ê°œ ë¬¸ìžì—´)";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "ë¡œì»¬ë¦¬ì œì´ì…˜ ìƒíƒœ{lineBreak}({stringCount}ê°œ ë¬¸ìžì—´)";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<ì§€ì •ë˜ì§€ ì•ŠìŒ>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "ì§€ì›ë˜ì§€ ì•ŠìŒ";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "ë” ë§Žì€ ì–¸ì–´ í‘œì‹œ...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "ì†ŒìŠ¤ ì–¸ì–´";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "ì§€ì›ë¨";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "ì§€ì›ë¨ (ë² íƒ€)";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "ì§€ì› ìƒíƒœ";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "ë²ˆì—­ ì½˜í…ì¸  ì‚¬ìš©: ";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "í™•ì¸. ì´ ìž‘ì—…ì„ ìˆ˜í–‰í•˜ëŠ” ë° ëª‡ ë¶„ ì •ë„ ì†Œìš”ë  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "ë³€ê²½ ë‚´ìš©ì´ ì„±ê³µì ìœ¼ë¡œ ì €ìž¥ë˜ì—ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "ì—…ë°ì´íŠ¸ ì¤‘...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "ì‹œë„ íšŸìˆ˜ê°€ ë„ˆë¬´ ë§ŽìŠµë‹ˆë‹¤. ìž ì‹œ í›„ì— ë‹¤ì‹œ ì‚­ì œë¥¼ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ì˜¤ë¥˜: ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "ì˜¤ë¥˜: ì„¤ì •ì„ ë³€ê²½í•  ìˆ˜ ì—†ì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}
}


}
