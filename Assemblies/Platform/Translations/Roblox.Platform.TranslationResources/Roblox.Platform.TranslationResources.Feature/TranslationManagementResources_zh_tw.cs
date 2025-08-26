namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_zh_tw : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public override string ActionPleaseReload => "è«‹é‡æ–°è¼‰å…¥ã€‚";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "å¯æŽ¥å—çš„æª”æ¡ˆæ ¼å¼ï¼šjpgã€jpegã€png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "å¯æŽ¥å—çš„æª”æ¡ˆæ ¼å¼ï¼šjpgã€jpegã€png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "åœ¨æ­¤è¼¸å…¥ç¿»è­¯";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "ä¸Šå‚³çš„åœ–åƒå°‡å…ˆç”±ç®¡ç†å“¡å¯©æ ¸ï¼Œæ‰æœƒé–‹æ”¾å…¶ä»–ä½¿ç”¨è€…æª¢è¦–";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "ç„¡æ³•è¼‰å…¥åœ–åƒã€‚";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "æª”æ¡ˆå¤§å°ä¸Šé™ï¼š4 MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "æª”æ¡ˆå¤§å°ä¸Šé™ï¼š4 MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "æ‰¾ä¸åˆ°æ­¤éŠæˆ²çš„ç”¢å“";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "æŽ¨è–¦è§£æžåº¦ï¼š512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "æŽ¨è–¦è§£æžåº¦ï¼š512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "æŽ¨è–¦è§£æžåº¦ï¼š1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "æœ€å¤šå¯ä»¥è¨­ç½® 10 å¼µæˆªåœ–";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "æœªå„²å­˜çš„è®Šæ›´å°‡æœƒè¢«æ¨æ£„ã€‚ç¢ºå®šï¼Ÿ";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "å¾½ç« èªªæ˜Ž";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "å¾½ç« åç¨±";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "éŠæˆ²èªªæ˜Ž";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "éŠæˆ²åœ–ç¤º";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "éŠæˆ²åç¨±";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "éŠæˆ²ç¸®åœ–";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "ç®¡ç†ç¿»è­¯";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "æ²’æœ‰å…§å®¹";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "ç¸®åœ–";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "ç¿»è­¯ç´€éŒ„";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "ç¿»è­¯ç®¡ç†";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "æœªå„²å­˜è®Šæ›´";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "èªªæ˜Ž";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "éŠæˆ²è³‡è¨Š";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "éŠæˆ²ç”¢å“";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "éŠæˆ²å­—ä¸²";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "åœ–ç¤º";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "æœ¬åœ°åŒ–åœ–åƒ";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "åç¨±";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "å¾…ç¿»è­¯æ–‡å­—";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "ç¸®åœ–";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "æ‚¨æ²’æœ‰æ¬Šé™æª¢è¦–æ­¤é é¢";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "ç„¡æ³•å„²å­˜ã€‚è«‹æª¢æŸ¥å…§å®¹æ˜¯å¦é­åˆ°éŽæ¿¾ï¼Œç„¶å¾Œé‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "ç„¡æ³•å„²å­˜ï¼Œè«‹ç¢ºèªæª”æ¡ˆå¤§å°å’Œæ ¼å¼æ­£ç¢ºã€‚";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "æ²’æœ‰å·²ç¿»è­¯çš„å…§å®¹ã€‚è‹¥è¦ç¿»è­¯éŠæˆ²å…§å®¹ï¼Œè«‹åœ¨æœ¬åœ°åŒ–è¨­å®šæ–°å¢žèªžè¨€ã€‚";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "ç„¡æ³•å„²å­˜ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "æª”æ¡ˆéŽå¤šï¼Œä¸€æ¬¡æœ€å¤šåªèƒ½ä¸Šå‚³ 10 å€‹æª”æ¡ˆã€‚";

	public TranslationManagementResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "è«‹é‡æ–°è¼‰å…¥ã€‚";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "å¯æŽ¥å—çš„æª”æ¡ˆæ ¼å¼ï¼šjpgã€jpegã€png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "å¯æŽ¥å—çš„æª”æ¡ˆæ ¼å¼ï¼šjpgã€jpegã€png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber} å€‹å­—å…ƒ";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber} å€‹å­—å…ƒ";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "åœ¨æ­¤è¼¸å…¥ç¿»è­¯";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "ä¸Šå‚³çš„åœ–åƒå°‡å…ˆç”±ç®¡ç†å“¡å¯©æ ¸ï¼Œæ‰æœƒé–‹æ”¾å…¶ä»–ä½¿ç”¨è€…æª¢è¦–";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "ç„¡æ³•è¼‰å…¥åœ–åƒã€‚";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "æª”æ¡ˆå¤§å°ä¸Šé™ï¼š4 MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "æª”æ¡ˆå¤§å°ä¸Šé™ï¼š4 MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "æ‰¾ä¸åˆ°æ­¤éŠæˆ²çš„ç”¢å“";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "æŽ¨è–¦è§£æžåº¦ï¼š512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "æŽ¨è–¦è§£æžåº¦ï¼š512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "æŽ¨è–¦è§£æžåº¦ï¼š1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "æœ€å¤šå¯ä»¥è¨­ç½® 10 å¼µæˆªåœ–";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "æœªå„²å­˜çš„è®Šæ›´å°‡æœƒè¢«æ¨æ£„ã€‚ç¢ºå®šï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "å¾½ç« èªªæ˜Ž";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "å¾½ç« åç¨±";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "éŠæˆ²èªªæ˜Ž";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "éŠæˆ²åœ–ç¤º";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "éŠæˆ²åç¨±";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "éŠæˆ²ç¸®åœ–";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "ç®¡ç†ç¿»è­¯";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "æ²’æœ‰å…§å®¹";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "ç¸®åœ–";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "ç¿»è­¯ç´€éŒ„";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "ç¿»è­¯ç®¡ç†";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "æœªå„²å­˜è®Šæ›´";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "èªªæ˜Ž";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "éŠæˆ²è³‡è¨Š";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "éŠæˆ²ç”¢å“";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "éŠæˆ²å­—ä¸²";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "åœ–ç¤º";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "æœ¬åœ°åŒ–åœ–åƒ";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "åç¨±";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "å¾…ç¿»è­¯æ–‡å­—";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "ç¸®åœ–";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "æ‚¨æ²’æœ‰æ¬Šé™æª¢è¦–æ­¤é é¢";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "ç„¡æ³•å„²å­˜ã€‚è«‹æª¢æŸ¥å…§å®¹æ˜¯å¦é­åˆ°éŽæ¿¾ï¼Œç„¶å¾Œé‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "ç„¡æ³•å„²å­˜ï¼Œè«‹ç¢ºèªæª”æ¡ˆå¤§å°å’Œæ ¼å¼æ­£ç¢ºã€‚";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "æ²’æœ‰å·²ç¿»è­¯çš„å…§å®¹ã€‚è‹¥è¦ç¿»è­¯éŠæˆ²å…§å®¹ï¼Œè«‹åœ¨æœ¬åœ°åŒ–è¨­å®šæ–°å¢žèªžè¨€ã€‚";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "ç„¡æ³•å„²å­˜ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "æª”æ¡ˆéŽå¤šï¼Œä¸€æ¬¡æœ€å¤šåªèƒ½ä¸Šå‚³ 10 å€‹æª”æ¡ˆã€‚";
	}
}


}
