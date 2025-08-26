namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_zh_cn : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
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
	public override string ActionConfirm => "ç¡®è®¤";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ä¿å­˜";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "é”™è¯¯ï¼šæ— æ³•ä¿å­˜ã€‚è¯·æ£€æŸ¥å†…å®¹æ˜¯å¦ç¬¦åˆå®¡æŸ¥è¦æ±‚ï¼Œå¹¶é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "é”™è¯¯ï¼šæ— æ³•ä¿å­˜ã€‚";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "å¦‚æžœæ²¡æœ‰æä¾›ç¿»è¯‘ï¼Œç”¨æˆ·å°†çœ‹åˆ°æºè¯­è¨€å†…å®¹ã€‚";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "ä½ æœ‰æœªä¿å­˜çš„æ›´æ”¹ã€‚æ˜¯å¦ç¡®å®šè¦åˆ‡æ¢è¯­è¨€ï¼Ÿ";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "å·²ä¿å­˜åç§°å’Œæè¿°ã€‚";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "æºè¯­è¨€å†…å®¹æ˜¾ç¤ºåœ¨æ­¤ä»¥ä½œå‚è€ƒã€‚åªèƒ½åœ¨æ­¤å¤„æŸ¥çœ‹ã€‚";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "æ¸…é™¤å†…å®¹";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "æœ¬åœ°åŒ–é…ç½®";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "æ¸¸æˆåç§°åŠæè¿°ç¿»è¯‘";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "æœªä¿å­˜çš„æ›´æ”¹";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "æè¿°ï¼š";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "è¯·åœ¨æ­¤è¾“å…¥æ¸¸æˆæè¿°";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "æ¸¸æˆä¿¡æ¯";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "æ¸¸æˆåç§°åŠæè¿°ç¿»è¯‘";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "åœ¨æ­¤å¤„è¾“å…¥æ¸¸æˆåç§° ï¼ˆå¿…å¡«ï¼‰";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "è¯·åœ¨æ­¤è¾“å…¥æ¸¸æˆåç§°";

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
	public override string LabelName => "åç§°ï¼š";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "æ”¯æŒè¯­è¨€";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "æ¸¸æˆä¿¡æ¯";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "è¯­è¨€";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "æŠ¥å‘Š";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "è®¾ç½®";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "è¯‘è€…";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "æ ‡é¢˜";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "é”™è¯¯ï¼šæ— æ³•ä¿å­˜ã€‚è¯·æ£€æŸ¥å†…å®¹æ˜¯å¦ç¬¦åˆå®¡æŸ¥è¦æ±‚ï¼Œå¹¶é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "é”™è¯¯ï¼šå‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "é”™è¯¯ï¼šæ— æ³•ä¿å­˜ã€‚";

	public GameLocalizationResources_zh_cn(TranslationResourceState state)
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
		return "ç¡®è®¤";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ä¿å­˜";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"æ˜¯å¦ç¡®å®šè¦æ¸…é™¤{languageName}çš„ç¿»è¯‘ï¼Ÿç”¨æˆ·å°†åœ¨æ¸¸æˆçš„æºè¯­è¨€ä¸­çœ‹åˆ°åç§°åŠæè¿°ã€‚";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "æ˜¯å¦ç¡®å®šè¦æ¸…é™¤{languageName}çš„ç¿»è¯‘ï¼Ÿç”¨æˆ·å°†åœ¨æ¸¸æˆçš„æºè¯­è¨€ä¸­çœ‹åˆ°åç§°åŠæè¿°ã€‚";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "é”™è¯¯ï¼šæ— æ³•ä¿å­˜ã€‚è¯·æ£€æŸ¥å†…å®¹æ˜¯å¦ç¬¦åˆå®¡æŸ¥è¦æ±‚ï¼Œå¹¶é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "é”™è¯¯ï¼šæ— æ³•ä¿å­˜ã€‚";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "å¦‚æžœæ²¡æœ‰æä¾›ç¿»è¯‘ï¼Œç”¨æˆ·å°†çœ‹åˆ°æºè¯­è¨€å†…å®¹ã€‚";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "ä½ æœ‰æœªä¿å­˜çš„æ›´æ”¹ã€‚æ˜¯å¦ç¡®å®šè¦åˆ‡æ¢è¯­è¨€ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "å·²ä¿å­˜åç§°å’Œæè¿°ã€‚";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "æºè¯­è¨€å†…å®¹æ˜¾ç¤ºåœ¨æ­¤ä»¥ä½œå‚è€ƒã€‚åªèƒ½åœ¨æ­¤å¤„æŸ¥çœ‹ã€‚";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "æ¸…é™¤å†…å®¹";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "æœ¬åœ°åŒ–é…ç½®";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "æ¸¸æˆåç§°åŠæè¿°ç¿»è¯‘";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "æœªä¿å­˜çš„æ›´æ”¹";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "æè¿°ï¼š";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "è¯·åœ¨æ­¤è¾“å…¥æ¸¸æˆæè¿°";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "æ¸¸æˆä¿¡æ¯";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "æ¸¸æˆåç§°åŠæè¿°ç¿»è¯‘";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "åœ¨æ­¤å¤„è¾“å…¥æ¸¸æˆåç§° ï¼ˆå¿…å¡«ï¼‰";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "è¯·åœ¨æ­¤è¾“å…¥æ¸¸æˆåç§°";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "æœ¬åœ°åŒ–";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "åç§°ï¼š";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "æ”¯æŒè¯­è¨€";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "æ¸¸æˆä¿¡æ¯";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "è¯­è¨€";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "æŠ¥å‘Š";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "è®¾ç½®";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "è¯‘è€…";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "æ ‡é¢˜";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "é”™è¯¯ï¼šæ— æ³•ä¿å­˜ã€‚è¯·æ£€æŸ¥å†…å®¹æ˜¯å¦ç¬¦åˆå®¡æŸ¥è¦æ±‚ï¼Œå¹¶é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "é”™è¯¯ï¼šå‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "é”™è¯¯ï¼šæ— æ³•ä¿å­˜ã€‚";
	}
}


}
