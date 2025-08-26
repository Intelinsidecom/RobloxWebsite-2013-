namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_zh_cn : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public override string ActionPleaseReload => "è¯·é‡æ–°åŠ è½½ã€‚";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "å¯æŽ¥å—çš„æ–‡ä»¶æ ¼å¼ï¼šjpgã€jpegã€png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "å¯æŽ¥å—çš„æ–‡ä»¶æ ¼å¼ï¼šjpgã€jpegã€png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "åœ¨æ­¤å¤„è¾“å…¥ç¿»è¯‘";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "å›¾åƒå°†å…ˆç”±ç®¡ç†å‘˜å®¡é˜…ï¼Œé€šè¿‡åŽå³å¯å¯¹å…¶ä»–ç”¨æˆ·å¯è§";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "å›¾åƒä¸å¯ç”¨ã€‚";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "æ–‡ä»¶å¤§å°ä¸Šé™ï¼š4 MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "æ–‡ä»¶å¤§å°ä¸Šé™ï¼š4 MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "æ— æ³•æ‰¾åˆ°æ­¤æ¸¸æˆçš„æ¸¸æˆäº§å“";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "æŽ¨èåˆ†è¾¨çŽ‡ï¼š512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "æŽ¨èåˆ†è¾¨çŽ‡ï¼š512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "æŽ¨èåˆ†è¾¨çŽ‡ï¼š1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "ä½ å¯æœ€å¤šè®¾ç½® 10 å¼ å±å¹•å¿«ç…§";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "æœªä¿å­˜çš„æ›´æ”¹å°†è¢«ä¸¢å¼ƒã€‚æ˜¯å¦ç¡®å®šï¼Ÿ";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "å¥–ç« å†…å®¹";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "å¥–ç« åç§°";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "æ¸¸æˆæè¿°";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "æ¸¸æˆå›¾æ ‡";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "æ¸¸æˆåç§°";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "æ¸¸æˆç¼©ç•¥å›¾";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "ç®¡ç†ç¿»è¯‘";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "æ— å†…å®¹";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "ç¼©ç•¥å›¾";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "ç¿»è¯‘åŽ†å²è®°å½•";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "ç¿»è¯‘ç®¡ç†";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "æœªä¿å­˜çš„æ›´æ”¹";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "æè¿°";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "æ¸¸æˆä¿¡æ¯";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "æ¸¸æˆäº§å“";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "æ¸¸æˆå­—ç¬¦ä¸²";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "å›¾æ ‡";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "æœ¬åœ°åŒ–å›¾åƒ";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "åç§°";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "å¾…ç¿»è¯‘æ–‡æœ¬";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "ç¼©ç•¥å›¾";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "ä½ æ²¡æœ‰è®¿é—®æ­¤é¡µé¢çš„æƒé™";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "æ— æ³•ä¿å­˜ã€‚è¯·æ£€æŸ¥å†…å®¹æ˜¯å¦ç¬¦åˆå®¡æŸ¥è¦æ±‚ï¼Œå¹¶é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "æ— æ³•ä¿å­˜ï¼Œè¯·ç¡®è®¤æ–‡ä»¶å¤§å°å’Œæ ¼å¼æ­£ç¡®ã€‚";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "æ²¡æœ‰å·²ç¿»è¯‘çš„å†…å®¹ã€‚åœ¨â€œæœ¬åœ°åŒ–é…ç½®â€ä¸­æ·»åŠ ä¸€ä¸ªç¿»è¯‘è¯­è¨€ï¼Œå³å¯ç¿»è¯‘æ¸¸æˆå†…å®¹ã€‚";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "æ— æ³•ä¿å­˜ï¼Œè¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "æ–‡ä»¶è¿‡å¤šã€‚è¯·ç¡®å®šä¸Šä¼ æ–‡ä»¶çš„æ•°é‡ä¸è¶…è¿‡ 10 ä¸ªã€‚";

	public TranslationManagementResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "è¯·é‡æ–°åŠ è½½ã€‚";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "å¯æŽ¥å—çš„æ–‡ä»¶æ ¼å¼ï¼šjpgã€jpegã€png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "å¯æŽ¥å—çš„æ–‡ä»¶æ ¼å¼ï¼šjpgã€jpegã€png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber} ä¸ªå­—ç¬¦";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber} ä¸ªå­—ç¬¦";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "åœ¨æ­¤å¤„è¾“å…¥ç¿»è¯‘";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "å›¾åƒå°†å…ˆç”±ç®¡ç†å‘˜å®¡é˜…ï¼Œé€šè¿‡åŽå³å¯å¯¹å…¶ä»–ç”¨æˆ·å¯è§";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "å›¾åƒä¸å¯ç”¨ã€‚";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "æ–‡ä»¶å¤§å°ä¸Šé™ï¼š4 MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "æ–‡ä»¶å¤§å°ä¸Šé™ï¼š4 MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "æ— æ³•æ‰¾åˆ°æ­¤æ¸¸æˆçš„æ¸¸æˆäº§å“";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "æŽ¨èåˆ†è¾¨çŽ‡ï¼š512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "æŽ¨èåˆ†è¾¨çŽ‡ï¼š512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "æŽ¨èåˆ†è¾¨çŽ‡ï¼š1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "ä½ å¯æœ€å¤šè®¾ç½® 10 å¼ å±å¹•å¿«ç…§";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "æœªä¿å­˜çš„æ›´æ”¹å°†è¢«ä¸¢å¼ƒã€‚æ˜¯å¦ç¡®å®šï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "å¥–ç« å†…å®¹";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "å¥–ç« åç§°";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "æ¸¸æˆæè¿°";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "æ¸¸æˆå›¾æ ‡";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "æ¸¸æˆåç§°";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "æ¸¸æˆç¼©ç•¥å›¾";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "ç®¡ç†ç¿»è¯‘";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "æ— å†…å®¹";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "ç¼©ç•¥å›¾";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "ç¿»è¯‘åŽ†å²è®°å½•";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "ç¿»è¯‘ç®¡ç†";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "æœªä¿å­˜çš„æ›´æ”¹";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "æè¿°";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "æ¸¸æˆä¿¡æ¯";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "æ¸¸æˆäº§å“";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "æ¸¸æˆå­—ç¬¦ä¸²";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "å›¾æ ‡";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "æœ¬åœ°åŒ–å›¾åƒ";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "åç§°";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "å¾…ç¿»è¯‘æ–‡æœ¬";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "ç¼©ç•¥å›¾";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "ä½ æ²¡æœ‰è®¿é—®æ­¤é¡µé¢çš„æƒé™";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "æ— æ³•ä¿å­˜ã€‚è¯·æ£€æŸ¥å†…å®¹æ˜¯å¦ç¬¦åˆå®¡æŸ¥è¦æ±‚ï¼Œå¹¶é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "å‘ç”Ÿé”™è¯¯ï¼Œè¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "æ— æ³•ä¿å­˜ï¼Œè¯·ç¡®è®¤æ–‡ä»¶å¤§å°å’Œæ ¼å¼æ­£ç¡®ã€‚";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "æ²¡æœ‰å·²ç¿»è¯‘çš„å†…å®¹ã€‚åœ¨â€œæœ¬åœ°åŒ–é…ç½®â€ä¸­æ·»åŠ ä¸€ä¸ªç¿»è¯‘è¯­è¨€ï¼Œå³å¯ç¿»è¯‘æ¸¸æˆå†…å®¹ã€‚";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "æ— æ³•ä¿å­˜ï¼Œè¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "æ–‡ä»¶è¿‡å¤šã€‚è¯·ç¡®å®šä¸Šä¼ æ–‡ä»¶çš„æ•°é‡ä¸è¶…è¿‡ 10 ä¸ªã€‚";
	}
}


}
