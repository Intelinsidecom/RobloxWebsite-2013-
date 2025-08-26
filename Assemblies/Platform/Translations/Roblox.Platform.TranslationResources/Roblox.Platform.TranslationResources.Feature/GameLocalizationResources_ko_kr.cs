namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_ko_kr : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "ì‚­ì œ";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "í™•ì¸";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ì €ìž¥";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "ì˜¤ë¥˜: ì €ìž¥ ì‹¤íŒ¨. ì½˜í…ì¸ ì— ë¬¸ì œì˜ ì†Œì§€ê°€ ìžˆëŠ”ì§€ í™•ì¸í•˜ê³  ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "ì˜¤ë¥˜: ì €ìž¥ ì‹¤íŒ¨.";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "ë²ˆì—­ì´ ì—†ìœ¼ë©´ ì‚¬ìš©ìžëŠ” ì†ŒìŠ¤ ì–¸ì–´ ê°’ì„ ë³´ê²Œ ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "ì €ìž¥ë˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­ì´ ìžˆì–´ìš”. ì–¸ì–´ë¥¼ ì „í™˜í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "ì´ë¦„ ë° ì„¤ëª…ì´ ì €ìž¥ë˜ì—ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "ì†ŒìŠ¤ ì–¸ì–´ ê°’ì´ ì°¸ì¡°ë¡œ í‘œì‹œë©ë‹ˆë‹¤. ì—¬ê¸°ì—ì„œë§Œ ë³¼ ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "ê°’ ì§€ìš°ê¸°";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "ë¡œì»¬ë¦¬ì œì´ì…˜ êµ¬ì„±";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "ê²Œìž„ ì´ë¦„ ë° ì„¤ëª… ë²ˆì—­";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "ì„¤ëª…:";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "ì—¬ê¸°ì— ê²Œìž„ ì„¤ëª… ìž…ë ¥";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "ê²Œìž„ ì •ë³´";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "ê²Œìž„ ì´ë¦„ ë° ì„¤ëª… ë²ˆì—­";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "ì—¬ê¸°ì— ê²Œìž„ ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”(í•„ìˆ˜)";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "ì—¬ê¸°ì— ê²Œìž„ ì´ë¦„ ìž…ë ¥";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "ë¡œì»¬ë¦¬ì œì´ì…˜";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "ì´ë¦„: ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "ì§€ì› ì–¸ì–´";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "ê²Œìž„ ì •ë³´";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "ì–¸ì–´";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "ì‹ ê³ ";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "ì„¤ì •";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "ë²ˆì—­ìž";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "ì œëª©";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "ì˜¤ë¥˜: ì €ìž¥ ì‹¤íŒ¨. ì½˜í…ì¸ ì— ë¬¸ì œì˜ ì†Œì§€ê°€ ìžˆëŠ”ì§€ í™•ì¸í•˜ê³  ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ì˜¤ë¥˜: ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "ì˜¤ë¥˜: ì €ìž¥ ì‹¤íŒ¨.";

	public GameLocalizationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ì €ìž¥";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"{languageName}ì˜ ë²ˆì—­ì„ ì§€ìš°ì‹œê² ìŠµë‹ˆê¹Œ? ì‚¬ìš©ìžë“¤ì€ ê²Œìž„ì˜ ì†ŒìŠ¤ ì–¸ì–´ë¡œ ì´ë¦„ê³¼ ì„¤ëª…ì„ ë³´ê²Œ ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "{languageName}ì˜ ë²ˆì—­ì„ ì§€ìš°ì‹œê² ìŠµë‹ˆê¹Œ? ì‚¬ìš©ìžë“¤ì€ ê²Œìž„ì˜ ì†ŒìŠ¤ ì–¸ì–´ë¡œ ì´ë¦„ê³¼ ì„¤ëª…ì„ ë³´ê²Œ ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "ì˜¤ë¥˜: ì €ìž¥ ì‹¤íŒ¨. ì½˜í…ì¸ ì— ë¬¸ì œì˜ ì†Œì§€ê°€ ìžˆëŠ”ì§€ í™•ì¸í•˜ê³  ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "ì˜¤ë¥˜: ì €ìž¥ ì‹¤íŒ¨.";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "ë²ˆì—­ì´ ì—†ìœ¼ë©´ ì‚¬ìš©ìžëŠ” ì†ŒìŠ¤ ì–¸ì–´ ê°’ì„ ë³´ê²Œ ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "ì €ìž¥ë˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­ì´ ìžˆì–´ìš”. ì–¸ì–´ë¥¼ ì „í™˜í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "ì´ë¦„ ë° ì„¤ëª…ì´ ì €ìž¥ë˜ì—ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "ì†ŒìŠ¤ ì–¸ì–´ ê°’ì´ ì°¸ì¡°ë¡œ í‘œì‹œë©ë‹ˆë‹¤. ì—¬ê¸°ì—ì„œë§Œ ë³¼ ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "ê°’ ì§€ìš°ê¸°";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "ë¡œì»¬ë¦¬ì œì´ì…˜ êµ¬ì„±";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "ê²Œìž„ ì´ë¦„ ë° ì„¤ëª… ë²ˆì—­";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "ì„¤ëª…:";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "ì—¬ê¸°ì— ê²Œìž„ ì„¤ëª… ìž…ë ¥";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "ê²Œìž„ ì •ë³´";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "ê²Œìž„ ì´ë¦„ ë° ì„¤ëª… ë²ˆì—­";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "ì—¬ê¸°ì— ê²Œìž„ ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”(í•„ìˆ˜)";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "ì—¬ê¸°ì— ê²Œìž„ ì´ë¦„ ìž…ë ¥";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "ë¡œì»¬ë¦¬ì œì´ì…˜";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "ì´ë¦„: ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "ì§€ì› ì–¸ì–´";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "ê²Œìž„ ì •ë³´";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "ì–¸ì–´";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "ì‹ ê³ ";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "ì„¤ì •";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "ë²ˆì—­ìž";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "ì œëª©";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "ì˜¤ë¥˜: ì €ìž¥ ì‹¤íŒ¨. ì½˜í…ì¸ ì— ë¬¸ì œì˜ ì†Œì§€ê°€ ìžˆëŠ”ì§€ í™•ì¸í•˜ê³  ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ì˜¤ë¥˜: ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "ì˜¤ë¥˜: ì €ìž¥ ì‹¤íŒ¨.";
	}
}


}
