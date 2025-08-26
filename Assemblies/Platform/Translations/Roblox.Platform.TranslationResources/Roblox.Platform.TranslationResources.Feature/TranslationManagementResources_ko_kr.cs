namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_ko_kr : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public override string ActionPleaseReload => "ë‹¤ì‹œ ë¶ˆëŸ¬ì˜¤ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "ê°€ëŠ¥í•œ íŒŒì¼ í˜•ì‹: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "ê°€ëŠ¥í•œ íŒŒì¼ í˜•ì‹: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "ì—¬ê¸°ì— ë²ˆì—­ ìž…ë ¥";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "ì´ë¯¸ì§€ëŠ” ê²€ì—´íŒ€ì˜ ê²€í† ê°€ ëë‚œ í›„ì— ë‹¤ë¥¸ ì‚¬ìš©ìžì—ê²Œ ê³µê°œë©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "ì´ë¯¸ì§€ ì‚¬ìš© ë¶ˆê°€.";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "ìµœëŒ€ íŒŒì¼ í¬ê¸°: 4MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "ìµœëŒ€ íŒŒì¼ í¬ê¸°: 4MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "ì´ ê²Œìž„ì˜ ìƒí’ˆì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "ê¶Œìž¥ í•´ìƒë„: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "ê¶Œìž¥ í•´ìƒë„: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "ê¶Œìž¥ í•´ìƒë„: 1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "ìµœëŒ€ 10ê°œì˜ ìŠ¤í¬ë¦°ìƒ·ì„ ì„¤ì •í•  ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­ì´ ì‚­ì œë©ë‹ˆë‹¤. ì§„í–‰í• ê¹Œìš”?";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "ë°°ì§€ ì„¤ëª…";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "ë°°ì§€ ì´ë¦„";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "ê²Œìž„ ì„¤ëª…";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "ê²Œìž„ ì•„ì´ì½˜";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "ê²Œìž„ ì´ë¦„";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "ê²Œìž„ ì„¬ë„¤ì¼";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "ë²ˆì—­ ê´€ë¦¬";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "ì½˜í…ì¸  ì—†ìŒ";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "ì„¬ë„¤ì¼";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "ë²ˆì—­ ë‚´ì—­";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "ë²ˆì—­ ê´€ë¦¬";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "ì„¤ëª…";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "ê²Œìž„ ì •ë³´";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "ê²Œìž„ ìƒí’ˆ";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "ê²Œìž„ ë¬¸ìžì—´";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "ì•„ì´ì½˜";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "í˜„ì§€í™”ëœ ì´ë¯¸ì§€";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "ì´ë¦„";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "ë²ˆì—­í•  í…ìŠ¤íŠ¸";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "ì„¬ë„¤ì¼";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "ë³¸ íŽ˜ì´ì§€ì— ëŒ€í•œ ì ‘ê·¼ ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "ì €ìž¥ ì‹¤íŒ¨. ì½˜í…ì¸ ì— ë¬¸ì œì˜ ì†Œì§€ê°€ ìžˆëŠ”ì§€ í™•ì¸í•˜ê³  ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "ì €ìž¥í•˜ì§€ ëª»í–ˆì–´ìš”. íŒŒì¼ì˜ í¬ê¸°ì™€ í˜•ì‹ì´ ë§žëŠ”ì§€ í™•ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "ë²ˆì—­ëœ ì½˜í…ì¸ ê°€ ì—†ìŠµë‹ˆë‹¤. ê²Œìž„ ì½˜í…ì¸ ë¥¼ ë²ˆì—­í•˜ë ¤ë©´ 'ë¡œì»¬ë¦¬ì œì´ì…˜ êµ¬ì„±'ì—ì„œ ë²ˆì—­í•  ì–¸ì–´ë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "ì €ìž¥í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "íŒŒì¼ì´ ë„ˆë¬´ ë§ŽìŠµë‹ˆë‹¤. í•œ ë²ˆì— íŒŒì¼ 10ê°œì”©ë§Œ ì—…ë¡œë“œí•˜ì„¸ìš”.";

	public TranslationManagementResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "ë‹¤ì‹œ ë¶ˆëŸ¬ì˜¤ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "ê°€ëŠ¥í•œ íŒŒì¼ í˜•ì‹: jpg, jpeg, png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "ê°€ëŠ¥í•œ íŒŒì¼ í˜•ì‹: jpg, jpeg, png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber}ìž";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber}ìž";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "ì—¬ê¸°ì— ë²ˆì—­ ìž…ë ¥";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "ì´ë¯¸ì§€ëŠ” ê²€ì—´íŒ€ì˜ ê²€í† ê°€ ëë‚œ í›„ì— ë‹¤ë¥¸ ì‚¬ìš©ìžì—ê²Œ ê³µê°œë©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "ì´ë¯¸ì§€ ì‚¬ìš© ë¶ˆê°€.";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "ìµœëŒ€ íŒŒì¼ í¬ê¸°: 4MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "ìµœëŒ€ íŒŒì¼ í¬ê¸°: 4MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "ì´ ê²Œìž„ì˜ ìƒí’ˆì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "ê¶Œìž¥ í•´ìƒë„: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "ê¶Œìž¥ í•´ìƒë„: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "ê¶Œìž¥ í•´ìƒë„: 1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "ìµœëŒ€ 10ê°œì˜ ìŠ¤í¬ë¦°ìƒ·ì„ ì„¤ì •í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­ì´ ì‚­ì œë©ë‹ˆë‹¤. ì§„í–‰í• ê¹Œìš”?";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "ë°°ì§€ ì„¤ëª…";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "ë°°ì§€ ì´ë¦„";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "ê²Œìž„ ì„¤ëª…";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "ê²Œìž„ ì•„ì´ì½˜";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "ê²Œìž„ ì´ë¦„";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "ê²Œìž„ ì„¬ë„¤ì¼";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "ë²ˆì—­ ê´€ë¦¬";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "ì½˜í…ì¸  ì—†ìŒ";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "ì„¬ë„¤ì¼";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "ë²ˆì—­ ë‚´ì—­";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "ë²ˆì—­ ê´€ë¦¬";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "ì„¤ëª…";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "ê²Œìž„ ì •ë³´";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "ê²Œìž„ ìƒí’ˆ";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "ê²Œìž„ ë¬¸ìžì—´";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "ì•„ì´ì½˜";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "í˜„ì§€í™”ëœ ì´ë¯¸ì§€";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "ì´ë¦„";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "ë²ˆì—­í•  í…ìŠ¤íŠ¸";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "ì„¬ë„¤ì¼";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "ë³¸ íŽ˜ì´ì§€ì— ëŒ€í•œ ì ‘ê·¼ ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "ì €ìž¥ ì‹¤íŒ¨. ì½˜í…ì¸ ì— ë¬¸ì œì˜ ì†Œì§€ê°€ ìžˆëŠ”ì§€ í™•ì¸í•˜ê³  ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "ì €ìž¥í•˜ì§€ ëª»í–ˆì–´ìš”. íŒŒì¼ì˜ í¬ê¸°ì™€ í˜•ì‹ì´ ë§žëŠ”ì§€ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "ë²ˆì—­ëœ ì½˜í…ì¸ ê°€ ì—†ìŠµë‹ˆë‹¤. ê²Œìž„ ì½˜í…ì¸ ë¥¼ ë²ˆì—­í•˜ë ¤ë©´ 'ë¡œì»¬ë¦¬ì œì´ì…˜ êµ¬ì„±'ì—ì„œ ë²ˆì—­í•  ì–¸ì–´ë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "ì €ìž¥í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "íŒŒì¼ì´ ë„ˆë¬´ ë§ŽìŠµë‹ˆë‹¤. í•œ ë²ˆì— íŒŒì¼ 10ê°œì”©ë§Œ ì—…ë¡œë“œí•˜ì„¸ìš”.";
	}
}


}
