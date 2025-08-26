namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_ja_jp : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public override string ActionPleaseReload => "å†èª­ã¿è¾¼ã¿ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "è¨±å®¹å¯èƒ½ãªãƒ•ã‚¡ã‚¤ãƒ«: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "è¨±å®¹å¯èƒ½ãªãƒ•ã‚¡ã‚¤ãƒ«: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "ç¿»è¨³ã®å…¥åŠ›ã¯ã“ã¡ã‚‰";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "ç”»åƒã¯ã€ãƒ¢ãƒ‡ãƒ¬ãƒ¼ã‚¿ã«ã‚ˆã‚‹ãƒ¬ãƒ“ãƒ¥ãƒ¼å¾Œã€ä»–ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å…¬é–‹ã•ã‚Œã¾ã™";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "ç”»åƒãŒåˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "æœ€å¤§ãƒ•ã‚¡ã‚¤ãƒ«ã‚µã‚¤ã‚º: 4 MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "æœ€å¤§ãƒ•ã‚¡ã‚¤ãƒ«ã‚µã‚¤ã‚º: 4 MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚²ãƒ¼ãƒ è£½å“ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸ";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "æŽ¨å¥¨è§£åƒåº¦: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "æŽ¨å¥¨è§£åƒåº¦: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "æŽ¨å¥¨è§£åƒåº¦ï¼š1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "ã‚¹ã‚¯ãƒªãƒ¼ãƒ³ã‚·ãƒ§ãƒƒãƒˆã‚’10ä»¶ã¾ã§è¨­å®šã§ãã¾ã™";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "ä¿å­˜ã—ã¦ã„ãªã„å¤‰æ›´ã¯ç ´æ£„ã•ã‚Œã¾ã™ã€‚ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "ãƒãƒƒã‚¸ã®è©³ç´°";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "ãƒãƒƒã‚¸å";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "ã‚²ãƒ¼ãƒ ã®è©³ç´°";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "ã‚²ãƒ¼ãƒ ã‚¢ã‚¤ã‚³ãƒ³";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "ã‚²ãƒ¼ãƒ å";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "ã‚²ãƒ¼ãƒ ã®ã‚µãƒ ãƒã‚¤ãƒ«";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "ç¿»è¨³ã‚’ç®¡ç†";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "ã‚µãƒ ãƒã‚¤ãƒ«";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "ç¿»è¨³å±¥æ­´";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "ç¿»è¨³ã®ç®¡ç†";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "ä¿å­˜ã•ã‚Œã¦ã„ãªã„å¤‰æ›´å†…å®¹";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "è©³ç´°";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "ã‚²ãƒ¼ãƒ æƒ…å ±";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "ã‚²ãƒ¼ãƒ å•†å“";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "ã‚²ãƒ¼ãƒ æ–‡å­—åˆ—";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "ã‚¢ã‚¤ã‚³ãƒ³";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "ç¿»è¨³æ¸ˆã¿ç”»åƒ";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "åå‰";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "ç¿»è¨³ã™ã‚‹ãƒ†ã‚­ã‚¹ãƒˆ";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "ã‚µãƒ ãƒã‚¤ãƒ«";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "ã“ã®ãƒšãƒ¼ã‚¸ã«ã‚¢ã‚¯ã‚»ã‚¹ã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒè¦åˆ¶å¯¾è±¡ã«ãªã£ã¦ã„ãªã„ã‹ãƒã‚§ãƒƒã‚¯ã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ãƒ•ã‚¡ã‚¤ãƒ«ã®å¤§ãã•ã¨å½¢å¼ãŒæ­£ã—ã„ã‹ç¢ºèªã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "ç¿»è¨³æ¸ˆã¿ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒã‚ã‚Šã¾ã›ã‚“ã€‚ã‚²ãƒ¼ãƒ ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ç¿»è¨³ã™ã‚‹ã«ã¯ç¿»è¨³ã®ç’°å¢ƒè¨­å®šã§ç¿»è¨³è¨€èªžã‚’è¿½åŠ ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "ãƒ•ã‚¡ã‚¤ãƒ«ãŒå¤šã™ãŽã¾ã™ã€‚ãƒ•ã‚¡ã‚¤ãƒ«ã®æ•°ã‚’10ä»¶ä»¥ä¸‹ã«ã—ã¦ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã—ã¦ãã ã•ã„ã€‚";

	public TranslationManagementResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "å†èª­ã¿è¾¼ã¿ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "è¨±å®¹å¯èƒ½ãªãƒ•ã‚¡ã‚¤ãƒ«: jpg, jpeg, png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "è¨±å®¹å¯èƒ½ãªãƒ•ã‚¡ã‚¤ãƒ«: jpg, jpeg, png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber} æ–‡å­—";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber} æ–‡å­—";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "ç¿»è¨³ã®å…¥åŠ›ã¯ã“ã¡ã‚‰";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "ç”»åƒã¯ã€ãƒ¢ãƒ‡ãƒ¬ãƒ¼ã‚¿ã«ã‚ˆã‚‹ãƒ¬ãƒ“ãƒ¥ãƒ¼å¾Œã€ä»–ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å…¬é–‹ã•ã‚Œã¾ã™";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "ç”»åƒãŒåˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "æœ€å¤§ãƒ•ã‚¡ã‚¤ãƒ«ã‚µã‚¤ã‚º: 4 MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "æœ€å¤§ãƒ•ã‚¡ã‚¤ãƒ«ã‚µã‚¤ã‚º: 4 MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚²ãƒ¼ãƒ è£½å“ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸ";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "æŽ¨å¥¨è§£åƒåº¦: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "æŽ¨å¥¨è§£åƒåº¦: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "æŽ¨å¥¨è§£åƒåº¦ï¼š1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "ã‚¹ã‚¯ãƒªãƒ¼ãƒ³ã‚·ãƒ§ãƒƒãƒˆã‚’10ä»¶ã¾ã§è¨­å®šã§ãã¾ã™";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "ä¿å­˜ã—ã¦ã„ãªã„å¤‰æ›´ã¯ç ´æ£„ã•ã‚Œã¾ã™ã€‚ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "ãƒãƒƒã‚¸ã®è©³ç´°";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "ãƒãƒƒã‚¸å";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "ã‚²ãƒ¼ãƒ ã®è©³ç´°";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "ã‚²ãƒ¼ãƒ ã‚¢ã‚¤ã‚³ãƒ³";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "ã‚²ãƒ¼ãƒ å";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "ã‚²ãƒ¼ãƒ ã®ã‚µãƒ ãƒã‚¤ãƒ«";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "ç¿»è¨³ã‚’ç®¡ç†";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "ã‚µãƒ ãƒã‚¤ãƒ«";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "ç¿»è¨³å±¥æ­´";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "ç¿»è¨³ã®ç®¡ç†";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "ä¿å­˜ã•ã‚Œã¦ã„ãªã„å¤‰æ›´å†…å®¹";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "è©³ç´°";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "ã‚²ãƒ¼ãƒ æƒ…å ±";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "ã‚²ãƒ¼ãƒ å•†å“";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "ã‚²ãƒ¼ãƒ æ–‡å­—åˆ—";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "ã‚¢ã‚¤ã‚³ãƒ³";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "ç¿»è¨³æ¸ˆã¿ç”»åƒ";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "åå‰";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "ç¿»è¨³ã™ã‚‹ãƒ†ã‚­ã‚¹ãƒˆ";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "ã‚µãƒ ãƒã‚¤ãƒ«";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "ã“ã®ãƒšãƒ¼ã‚¸ã«ã‚¢ã‚¯ã‚»ã‚¹ã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒè¦åˆ¶å¯¾è±¡ã«ãªã£ã¦ã„ãªã„ã‹ãƒã‚§ãƒƒã‚¯ã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ãƒ•ã‚¡ã‚¤ãƒ«ã®å¤§ãã•ã¨å½¢å¼ãŒæ­£ã—ã„ã‹ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "ç¿»è¨³æ¸ˆã¿ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒã‚ã‚Šã¾ã›ã‚“ã€‚ã‚²ãƒ¼ãƒ ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ç¿»è¨³ã™ã‚‹ã«ã¯ç¿»è¨³ã®ç’°å¢ƒè¨­å®šã§ç¿»è¨³è¨€èªžã‚’è¿½åŠ ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "ä¿å­˜ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "ãƒ•ã‚¡ã‚¤ãƒ«ãŒå¤šã™ãŽã¾ã™ã€‚ãƒ•ã‚¡ã‚¤ãƒ«ã®æ•°ã‚’10ä»¶ä»¥ä¸‹ã«ã—ã¦ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã—ã¦ãã ã•ã„ã€‚";
	}
}


}
