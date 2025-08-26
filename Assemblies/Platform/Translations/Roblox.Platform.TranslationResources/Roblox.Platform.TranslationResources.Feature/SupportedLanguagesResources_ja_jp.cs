namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionClear => "æ¶ˆã™";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "ãƒ—ãƒ¬ã‚¤ä¸­ã«ã‚²ãƒ¼ãƒ UIã‹ã‚‰ãƒ†ã‚­ã‚¹ãƒˆã‚’è‡ªå‹•ã‚­ãƒ£ãƒ—ãƒãƒ£";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "è‡ªå‹•çš„ã«ã‚­ãƒ£ãƒ—ãƒãƒ£ã•ã‚ŒãŸç¿»è¨³ã®ãªã„ã‚¨ãƒ³ãƒˆãƒªãƒ¼ã¯ã€ã™ã¹ã¦ãƒ†ãƒ¼ãƒ–ãƒ«ã‹ã‚‰æ¶ˆåŽ»ã•ã‚Œã¾ã™ã€‚æ³¨ï¼šè©²å½“ã™ã‚‹ãƒ†ã‚­ã‚¹ãƒˆã¯ã™ã¹ã¦è‡ªå‹•çš„ã«å†åº¦ã‚­ãƒ£ãƒ—ãƒãƒ£ã•ã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "ç¿»è¨³æ¸ˆã¿ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ã‚²ãƒ¼ãƒ å†…ã§æœ‰åŠ¹ã«ã™ã‚‹";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "ã‚¨ãƒ³ãƒˆãƒªãƒ¼ã‚’æ¶ˆåŽ»ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "ã‚²ãƒ¼ãƒ ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ç¿»è¨³ä¸­";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "è‡ªå‹•ãƒ†ã‚­ã‚¹ãƒˆã‚­ãƒ£ãƒ—ãƒãƒ£: ";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "è‡ªå‹•ã‚­ãƒ£ãƒ—ãƒãƒ£ã•ã‚ŒãŸæœªç¿»è¨³ã®æ–‡å­—åˆ—ã‚’æ¶ˆã™";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "ã‚¯ãƒ©ã‚¦ãƒ‰ã‚½ãƒ¼ã‚¹ãŒåˆ©ç”¨ã§ãã¾ã™";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "è‡ªå‹•UIãƒ†ã‚­ã‚¹ãƒˆã‚­ãƒ£ãƒ—ãƒãƒ£ã‚’æœ‰åŠ¹ã«ã™ã‚‹";

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
	public override string LabelLanguage => "è¨€èªž";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "è¨€èªž";

	public override string LabelNotSpecified => "<æŒ‡å®šã•ã‚Œã¦ã„ã¾ã›ã‚“>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "å¯¾å¿œã—ã¦ã„ã¾ã›ã‚“";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "ä»–ã®è¨€èªžã‚’è¡¨ç¤º...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "ã‚½ãƒ¼ã‚¹è¨€èªž";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "å¯¾å¿œæ¸ˆã¿";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "å¯¾å¿œæ¸ˆã¿ï¼ˆãƒ™ãƒ¼ã‚¿ï¼‰";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "å¯¾å¿œçŠ¶æ³";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "ç¿»è¨³æ¸ˆã¿ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ä½¿ã†: ";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "ç¢ºèªã—ã¾ã—ãŸã€‚ã“ã®å‡¦ç†ã«ã¯æ•°åˆ†ã‹ã‹ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "å¤‰æ›´ãŒä¿å­˜ã•ã‚Œã¾ã—ãŸ";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆä¸­...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã‚¯ãƒªã‚¢ã™ã‚‹ã«ã¯ã€ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ã‚¨ãƒ©ãƒ¼: ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "ã‚¨ãƒ©ãƒ¼: è¨­å®šã‚’å¤‰æ›´ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public SupportedLanguagesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "æ¶ˆã™";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "ãƒ—ãƒ¬ã‚¤ä¸­ã«ã‚²ãƒ¼ãƒ UIã‹ã‚‰ãƒ†ã‚­ã‚¹ãƒˆã‚’è‡ªå‹•ã‚­ãƒ£ãƒ—ãƒãƒ£";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "è‡ªå‹•çš„ã«ã‚­ãƒ£ãƒ—ãƒãƒ£ã•ã‚ŒãŸç¿»è¨³ã®ãªã„ã‚¨ãƒ³ãƒˆãƒªãƒ¼ã¯ã€ã™ã¹ã¦ãƒ†ãƒ¼ãƒ–ãƒ«ã‹ã‚‰æ¶ˆåŽ»ã•ã‚Œã¾ã™ã€‚æ³¨ï¼šè©²å½“ã™ã‚‹ãƒ†ã‚­ã‚¹ãƒˆã¯ã™ã¹ã¦è‡ªå‹•çš„ã«å†åº¦ã‚­ãƒ£ãƒ—ãƒãƒ£ã•ã‚Œã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"ã‚ªãƒ³: ã‚¯ãƒ©ã‚¦ãƒ‰ã‚½ãƒ¼ã‚¹ãŒåˆ©ç”¨ã§ãã¾ã™ï¼ˆç¿»è¨³è€…ãŒã‚²ãƒ¼ãƒ ã®æ–‡å­—åˆ—ã‚’è¦‹ã¦ç¿»è¨³ã§ãã¾ã™ï¼‰{lineBreak}ã‚ªãƒ•: ã‚¯ãƒ©ã‚¦ãƒ‰ã‚½ãƒ¼ã‚¹ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ï¼ˆç¿»è¨³è€…ã¯ã‚²ãƒ¼ãƒ ã®æ–‡å­—åˆ—ã‚’è¦‹ãŸã‚Šç¿»è¨³ã™ã‚‹ã“ã¨ãŒã§ãã¾ã›ã‚“ï¼‰";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "ã‚ªãƒ³: ã‚¯ãƒ©ã‚¦ãƒ‰ã‚½ãƒ¼ã‚¹ãŒåˆ©ç”¨ã§ãã¾ã™ï¼ˆç¿»è¨³è€…ãŒã‚²ãƒ¼ãƒ ã®æ–‡å­—åˆ—ã‚’è¦‹ã¦ç¿»è¨³ã§ãã¾ã™ï¼‰{lineBreak}ã‚ªãƒ•: ã‚¯ãƒ©ã‚¦ãƒ‰ã‚½ãƒ¼ã‚¹ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ï¼ˆç¿»è¨³è€…ã¯ã‚²ãƒ¼ãƒ ã®æ–‡å­—åˆ—ã‚’è¦‹ãŸã‚Šç¿»è¨³ã™ã‚‹ã“ã¨ãŒã§ãã¾ã›ã‚“ï¼‰";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"ç·‘è‰²ã®ãƒãƒ¼: æ‰¿èªã•ã‚ŒãŸæ–‡å­—åˆ—ã®å‰²åˆ{lineBreak}é’è‰²ã®ãƒãƒ¼: ç¿»è¨³ã•ã‚ŒãŸæ–‡å­—åˆ—ã®å‰²åˆ";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "ç·‘è‰²ã®ãƒãƒ¼: æ‰¿èªã•ã‚ŒãŸæ–‡å­—åˆ—ã®å‰²åˆ{lineBreak}é’è‰²ã®ãƒãƒ¼: ç¿»è¨³ã•ã‚ŒãŸæ–‡å­—åˆ—ã®å‰²åˆ";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"å¯¾å¿œçŠ¶æ³ã¯è¨€èªžãŒã‚²ãƒ¼ãƒ ã®è©³ç´°ãƒšãƒ¼ã‚¸ã«è¼‰ã£ã¦ã„ã‚‹ã‹ã©ã†ã‹ã‚’åæ˜ ã—ã¦ã„ã¾ã™ã€‚{lineBreak}å¯¾å¿œã—ã¦ã„ã¾ã™ - æŽ²è¼‰{lineBreak}é€²è¡Œä¸­ - ãƒ™ãƒ¼ã‚¿ã¨ã—ã¦æŽ²è¼‰{lineBreak}å¯¾å¿œã—ã¦ã„ã¾ã›ã‚“ - éžæŽ²è¼‰";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "å¯¾å¿œçŠ¶æ³ã¯è¨€èªžãŒã‚²ãƒ¼ãƒ ã®è©³ç´°ãƒšãƒ¼ã‚¸ã«è¼‰ã£ã¦ã„ã‚‹ã‹ã©ã†ã‹ã‚’åæ˜ ã—ã¦ã„ã¾ã™ã€‚{lineBreak}å¯¾å¿œã—ã¦ã„ã¾ã™ - æŽ²è¼‰{lineBreak}é€²è¡Œä¸­ - ãƒ™ãƒ¼ã‚¿ã¨ã—ã¦æŽ²è¼‰{lineBreak}å¯¾å¿œã—ã¦ã„ã¾ã›ã‚“ - éžæŽ²è¼‰";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "ç¿»è¨³æ¸ˆã¿ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ã‚²ãƒ¼ãƒ å†…ã§æœ‰åŠ¹ã«ã™ã‚‹";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "ã‚¨ãƒ³ãƒˆãƒªãƒ¼ã‚’æ¶ˆåŽ»ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "ã‚²ãƒ¼ãƒ ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ç¿»è¨³ä¸­";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "è‡ªå‹•ãƒ†ã‚­ã‚¹ãƒˆã‚­ãƒ£ãƒ—ãƒãƒ£: ";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "è‡ªå‹•ã‚­ãƒ£ãƒ—ãƒãƒ£ã•ã‚ŒãŸæœªç¿»è¨³ã®æ–‡å­—åˆ—ã‚’æ¶ˆã™";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "ã‚¯ãƒ©ã‚¦ãƒ‰ã‚½ãƒ¼ã‚¹ãŒåˆ©ç”¨ã§ãã¾ã™";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "è‡ªå‹•UIãƒ†ã‚­ã‚¹ãƒˆã‚­ãƒ£ãƒ—ãƒãƒ£ã‚’æœ‰åŠ¹ã«ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "é€²è¡Œä¸­";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "è¨€èªž";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "è¨€èªž";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"ç¿»è¨³çŠ¶æ³{lineBreak}ï¼ˆæ–‡å­—åˆ—{stringCount}ï¼‰";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "ç¿»è¨³çŠ¶æ³{lineBreak}ï¼ˆæ–‡å­—åˆ—{stringCount}ï¼‰";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<æŒ‡å®šã•ã‚Œã¦ã„ã¾ã›ã‚“>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "å¯¾å¿œã—ã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "ä»–ã®è¨€èªžã‚’è¡¨ç¤º...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "ã‚½ãƒ¼ã‚¹è¨€èªž";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "å¯¾å¿œæ¸ˆã¿";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "å¯¾å¿œæ¸ˆã¿ï¼ˆãƒ™ãƒ¼ã‚¿ï¼‰";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "å¯¾å¿œçŠ¶æ³";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "ç¿»è¨³æ¸ˆã¿ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ä½¿ã†: ";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "ç¢ºèªã—ã¾ã—ãŸã€‚ã“ã®å‡¦ç†ã«ã¯æ•°åˆ†ã‹ã‹ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "å¤‰æ›´ãŒä¿å­˜ã•ã‚Œã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆä¸­...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã‚¯ãƒªã‚¢ã™ã‚‹ã«ã¯ã€ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ã‚¨ãƒ©ãƒ¼: ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "ã‚¨ãƒ©ãƒ¼: è¨­å®šã‚’å¤‰æ›´ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}
}


}
