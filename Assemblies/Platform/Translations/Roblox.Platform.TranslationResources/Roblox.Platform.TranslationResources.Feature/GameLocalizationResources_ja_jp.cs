namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "æ¶ˆã™";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "ç¢ºå®š";

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
	public override string DescriptionContentModerationError => "ã‚¨ãƒ©ãƒ¼: ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒè¦åˆ¶å¯¾è±¡ã«ãªã£ã¦ã„ãªã„ã‹ãƒã‚§ãƒƒã‚¯ã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "ã‚¨ãƒ©ãƒ¼: ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "ç¿»è¨³ãŒãªã„å ´åˆã€ã‚½ãƒ¼ã‚¹è¨€èªžã®å€¤ãŒè¡¨ç¤ºã•ã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "ä¿å­˜ã—ã¦ã„ãªã„å¤‰æ›´ãŒã‚ã‚Šã¾ã™ã€‚è¨€èªžã‚’å¤‰æ›´ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "åå‰ã¨è©³ç´°ã‚’ä¿å­˜ã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "ã‚½ãƒ¼ã‚¹è¨€èªžã®å€¤ã¯ã€å‚è€ƒç”¨ã«è¡¨ç¤ºã•ã‚Œã¾ã™ã€‚ã“ã“ã«ã—ã‹ã€è¡¨ç¤ºã•ã‚Œã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "å€¤ã‚’æ¶ˆã™";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "ç¿»è¨³ã®ç’°å¢ƒè¨­å®š";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "ã‚²ãƒ¼ãƒ åã¨è©³ç´°ã®ç¿»è¨³";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "ä¿å­˜ã•ã‚Œã¦ã„ãªã„å¤‰æ›´å†…å®¹";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "è©³ç´°: ";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "ã‚²ãƒ¼ãƒ è©³ç´°ã®å…¥åŠ›ã¯ã“ã¡ã‚‰";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "ã‚²ãƒ¼ãƒ æƒ…å ±";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "ã‚²ãƒ¼ãƒ åã¨è©³ç´°ã®ç¿»è¨³";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "ã‚²ãƒ¼ãƒ åã®å…¥åŠ›ã¯ã“ã¡ã‚‰ï¼ˆå¿…é ˆï¼‰";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "ã‚²ãƒ¼ãƒ åã®å…¥åŠ›ã¯ã“ã¡ã‚‰";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "ç¿»è¨³";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "åå‰: ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "å¯¾å¿œè¨€èªž";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "ã‚²ãƒ¼ãƒ æƒ…å ±";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "è¨€èªž";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "å ±å‘Š";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "è¨­å®š";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "ç¿»è¨³è€…";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "ã‚¿ã‚¤ãƒˆãƒ«";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "ã‚¨ãƒ©ãƒ¼: ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒè¦åˆ¶å¯¾è±¡ã«ãªã£ã¦ã„ãªã„ã‹ãƒã‚§ãƒƒã‚¯ã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ã‚¨ãƒ©ãƒ¼: ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "ã‚¨ãƒ©ãƒ¼: ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";

	public GameLocalizationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "æ¶ˆã™";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "ç¢ºå®š";
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
		return $"{languageName} ã®ç¿»è¨³ã‚’æ¶ˆã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿã‚²ãƒ¼ãƒ åã‚„è©³ç´°ã¯ã€ã‚½ãƒ¼ã‚¹è¨€èªžã§è¡¨ç¤ºã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "{languageName} ã®ç¿»è¨³ã‚’æ¶ˆã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿã‚²ãƒ¼ãƒ åã‚„è©³ç´°ã¯ã€ã‚½ãƒ¼ã‚¹è¨€èªžã§è¡¨ç¤ºã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "ã‚¨ãƒ©ãƒ¼: ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒè¦åˆ¶å¯¾è±¡ã«ãªã£ã¦ã„ãªã„ã‹ãƒã‚§ãƒƒã‚¯ã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "ã‚¨ãƒ©ãƒ¼: ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "ç¿»è¨³ãŒãªã„å ´åˆã€ã‚½ãƒ¼ã‚¹è¨€èªžã®å€¤ãŒè¡¨ç¤ºã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "ä¿å­˜ã—ã¦ã„ãªã„å¤‰æ›´ãŒã‚ã‚Šã¾ã™ã€‚è¨€èªžã‚’å¤‰æ›´ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "åå‰ã¨è©³ç´°ã‚’ä¿å­˜ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "ã‚½ãƒ¼ã‚¹è¨€èªžã®å€¤ã¯ã€å‚è€ƒç”¨ã«è¡¨ç¤ºã•ã‚Œã¾ã™ã€‚ã“ã“ã«ã—ã‹ã€è¡¨ç¤ºã•ã‚Œã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "å€¤ã‚’æ¶ˆã™";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "ç¿»è¨³ã®ç’°å¢ƒè¨­å®š";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "ã‚²ãƒ¼ãƒ åã¨è©³ç´°ã®ç¿»è¨³";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "ä¿å­˜ã•ã‚Œã¦ã„ãªã„å¤‰æ›´å†…å®¹";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "è©³ç´°: ";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "ã‚²ãƒ¼ãƒ è©³ç´°ã®å…¥åŠ›ã¯ã“ã¡ã‚‰";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "ã‚²ãƒ¼ãƒ æƒ…å ±";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "ã‚²ãƒ¼ãƒ åã¨è©³ç´°ã®ç¿»è¨³";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "ã‚²ãƒ¼ãƒ åã®å…¥åŠ›ã¯ã“ã¡ã‚‰ï¼ˆå¿…é ˆï¼‰";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "ã‚²ãƒ¼ãƒ åã®å…¥åŠ›ã¯ã“ã¡ã‚‰";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "ç¿»è¨³";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "åå‰: ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "å¯¾å¿œè¨€èªž";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "ã‚²ãƒ¼ãƒ æƒ…å ±";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "è¨€èªž";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "å ±å‘Š";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "è¨­å®š";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "ç¿»è¨³è€…";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "ã‚¿ã‚¤ãƒˆãƒ«";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "ã‚¨ãƒ©ãƒ¼: ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒè¦åˆ¶å¯¾è±¡ã«ãªã£ã¦ã„ãªã„ã‹ãƒã‚§ãƒƒã‚¯ã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ã‚¨ãƒ©ãƒ¼: ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "ã‚¨ãƒ©ãƒ¼: ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";
	}
}


}
