namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_zh_tw : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "æ¸…é™¤";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "ç¢ºèª";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "å„²å­˜";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "éŒ¯èª¤ï¼šç„¡æ³•å„²å­˜ã€‚è«‹æª¢æŸ¥å…§å®¹æ˜¯å¦é­åˆ°éŽæ¿¾ï¼Œç„¶å¾Œé‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "éŒ¯èª¤ï¼šç„¡æ³•å„²å­˜ã€‚";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "è‹¥æœªæä¾›ç¿»è­¯ï¼Œä½¿ç”¨è€…å°‡æœƒçœ‹è¦‹æºèªžè¨€å€¼ã€‚";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "æ‚¨æœ‰æœªå„²å­˜çš„è®Šæ›´ã€‚ç¢ºå®šåˆ‡æ›èªžè¨€ï¼Ÿ";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "åç¨±èˆ‡èªªæ˜Žå·²å„²å­˜ã€‚";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "é¡¯ç¤ºçš„æºèªžè¨€å€¼ç‚ºåƒè€ƒç”¨ï¼Œåªå¯ä»¥åœ¨æ­¤è™•æª¢è¦–ã€‚";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "æ¸…é™¤å€¼";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "æœ¬åœ°åŒ–è¨­å®š";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "éŠæˆ²åç¨±èˆ‡èªªæ˜Žç¿»è­¯";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "æœªå„²å­˜è®Šæ›´";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "èªªæ˜Žï¼š";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "æ–¼æ­¤è™•è¼¸å…¥éŠæˆ²èªªæ˜Ž";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "éŠæˆ²è³‡è¨Š";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "éŠæˆ²åç¨±èˆ‡èªªæ˜Žç¿»è­¯";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "æ–¼æ­¤è™•è¼¸å…¥éŠæˆ²åç¨±ï¼ˆå¿…å¡«ï¼‰";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "æ–¼æ­¤è™•è¼¸å…¥éŠæˆ²åç¨±";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "æœ¬åœ°åŒ–";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "åç¨±ï¼š ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "æ”¯æ´èªžè¨€";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "éŠæˆ²è³‡è¨Š";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "èªžè¨€";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "èˆ‰å ±";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "è¨­å®š";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "è­¯è€…";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "æ¨™é¡Œ";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "éŒ¯èª¤ï¼šç„¡æ³•å„²å­˜ã€‚è«‹æª¢æŸ¥å…§å®¹æ˜¯å¦é­åˆ°éŽæ¿¾ï¼Œç„¶å¾Œé‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "éŒ¯èª¤ï¼šç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "éŒ¯èª¤ï¼šç„¡æ³•å„²å­˜ã€‚";

	public GameLocalizationResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "æ¸…é™¤";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "ç¢ºèª";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "å„²å­˜";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"ç¢ºå®šæ¸…é™¤{languageName}ç¿»è­¯ï¼Ÿä½¿ç”¨è€…å°‡æœƒçœ‹åˆ°éŠæˆ²æºèªžè¨€çš„åç¨±å’Œèªªæ˜Žã€‚";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "ç¢ºå®šæ¸…é™¤{languageName}ç¿»è­¯ï¼Ÿä½¿ç”¨è€…å°‡æœƒçœ‹åˆ°éŠæˆ²æºèªžè¨€çš„åç¨±å’Œèªªæ˜Žã€‚";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "éŒ¯èª¤ï¼šç„¡æ³•å„²å­˜ã€‚è«‹æª¢æŸ¥å…§å®¹æ˜¯å¦é­åˆ°éŽæ¿¾ï¼Œç„¶å¾Œé‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "éŒ¯èª¤ï¼šç„¡æ³•å„²å­˜ã€‚";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "è‹¥æœªæä¾›ç¿»è­¯ï¼Œä½¿ç”¨è€…å°‡æœƒçœ‹è¦‹æºèªžè¨€å€¼ã€‚";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "æ‚¨æœ‰æœªå„²å­˜çš„è®Šæ›´ã€‚ç¢ºå®šåˆ‡æ›èªžè¨€ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "åç¨±èˆ‡èªªæ˜Žå·²å„²å­˜ã€‚";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "é¡¯ç¤ºçš„æºèªžè¨€å€¼ç‚ºåƒè€ƒç”¨ï¼Œåªå¯ä»¥åœ¨æ­¤è™•æª¢è¦–ã€‚";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "æ¸…é™¤å€¼";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "æœ¬åœ°åŒ–è¨­å®š";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "éŠæˆ²åç¨±èˆ‡èªªæ˜Žç¿»è­¯";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "æœªå„²å­˜è®Šæ›´";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "èªªæ˜Žï¼š";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "æ–¼æ­¤è™•è¼¸å…¥éŠæˆ²èªªæ˜Ž";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "éŠæˆ²è³‡è¨Š";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "éŠæˆ²åç¨±èˆ‡èªªæ˜Žç¿»è­¯";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "æ–¼æ­¤è™•è¼¸å…¥éŠæˆ²åç¨±ï¼ˆå¿…å¡«ï¼‰";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "æ–¼æ­¤è™•è¼¸å…¥éŠæˆ²åç¨±";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "æœ¬åœ°åŒ–";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "åç¨±ï¼š ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "æ”¯æ´èªžè¨€";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "éŠæˆ²è³‡è¨Š";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "èªžè¨€";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "èˆ‰å ±";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "è¨­å®š";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "è­¯è€…";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "æ¨™é¡Œ";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "éŒ¯èª¤ï¼šç„¡æ³•å„²å­˜ã€‚è«‹æª¢æŸ¥å…§å®¹æ˜¯å¦é­åˆ°éŽæ¿¾ï¼Œç„¶å¾Œé‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "éŒ¯èª¤ï¼šç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "éŒ¯èª¤ï¼šç„¡æ³•å„²å­˜ã€‚";
	}
}


}
