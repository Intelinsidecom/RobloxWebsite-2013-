using System;
using System.Collections.Generic;
namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_zh_tw : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{

    public IReadOnlyDictionary<string, string> GetAllKeys()
    {
        return base.GetAllKeys();
    }

    public string GetFullContentNamespaceName()
    {
        return "Feature.TranslationManagement";
    }

    public TranslationManagementResources_zh_tw(TranslationResourceState state)
        : base(state)
    {
    }

    /// <summary>
    /// Key: "Action.PleaseReload"
    /// A clickable text which allows user to reload the image and see if it is available.
    /// English String: "Please reload."
    /// </summary>
    public override string ActionPleaseReload => "Ã¨Â«â€¹Ã©â€¡ÂÃ¦â€“Â°Ã¨Â¼â€°Ã¥â€¦Â¥Ã£â‚¬â€š";

    /// <summary>
    /// Key: "Description.AcceptableFilesForIcon"
    /// Tell the developer what types of files their images should be for upload.
    /// English String: "Acceptable files: jpg, jpeg, png"
    /// </summary>
    public override string DescriptionAcceptableFilesForIcon => "Ã¥ÂÂ¯Ã¦Å½Â¥Ã¥Ââ€”Ã§Å¡â€žÃ¦Âªâ€Ã¦Â¡Ë†Ã¦Â Â¼Ã¥Â¼ÂÃ¯Â¼Å¡jpgÃ£â‚¬ÂjpegÃ£â‚¬Âpng";

    /// <summary>
    /// Key: "Description.AcceptableFilesForThumbnail"
    /// English String: "Acceptable files: jpg, jpeg, png"
    /// </summary>
    public override string DescriptionAcceptableFilesForThumbnail => "Ã¥ÂÂ¯Ã¦Å½Â¥Ã¥Ââ€”Ã§Å¡â€žÃ¦Âªâ€Ã¦Â¡Ë†Ã¦Â Â¼Ã¥Â¼ÂÃ¯Â¼Å¡jpgÃ£â‚¬ÂjpegÃ£â‚¬Âpng";

    /// <summary>
    /// Key: "Description.EnterTranslationHere"
    /// Placeholder text for the input text area of name/description
    /// English String: "Enter translation here"
    /// </summary>
    public override string DescriptionEnterTranslationHere => "Ã¥Å“Â¨Ã¦Â­Â¤Ã¨Â¼Â¸Ã¥â€¦Â¥Ã§Â¿Â»Ã¨Â­Â¯";

    /// <summary>
    /// Key: "Description.IconWillBeReviewed"
    /// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
    /// English String: "Image will be reviewed by moderators before being made visible to other users"
    /// </summary>
    public override string DescriptionIconWillBeReviewed => "Ã¤Â¸Å Ã¥â€šÂ³Ã§Å¡â€žÃ¥Å“â€“Ã¥Æ’ÂÃ¥Â°â€¡Ã¥â€¦Ë†Ã§â€Â±Ã§Â®Â¡Ã§Ââ€ Ã¥â€œÂ¡Ã¥Â¯Â©Ã¦Â Â¸Ã¯Â¼Å’Ã¦â€°ÂÃ¦Å“Æ’Ã©â€“â€¹Ã¦â€Â¾Ã¥â€¦Â¶Ã¤Â»â€“Ã¤Â½Â¿Ã§â€Â¨Ã¨â‚¬â€¦Ã¦ÂªÂ¢Ã¨Â¦â€“";

    /// <summary>
    /// Key: "Description.ImageNotAvailable"
    /// Message that tells the user their image is still being prepared
    /// English String: "Image not available."
    /// </summary>
    public override string DescriptionImageNotAvailable => "Ã§â€žÂ¡Ã¦Â³â€¢Ã¨Â¼â€°Ã¥â€¦Â¥Ã¥Å“â€“Ã¥Æ’ÂÃ£â‚¬â€š";

    /// <summary>
    /// Key: "Description.MaximumSizeForIcon"
    /// The maximum file size for the icon
    /// English String: "Maximum file size: 4 MB"
    /// </summary>
    public override string DescriptionMaximumSizeForIcon => "Ã¦Âªâ€Ã¦Â¡Ë†Ã¥Â¤Â§Ã¥Â°ÂÃ¤Â¸Å Ã©â„¢ÂÃ¯Â¼Å¡4 MB";

    /// <summary>
    /// Key: "Description.MaximumSizeForThumbnail"
    /// English String: "Maximum file size: 4 MB"
    /// </summary>
    public override string DescriptionMaximumSizeForThumbnail => "Ã¦Âªâ€Ã¦Â¡Ë†Ã¥Â¤Â§Ã¥Â°ÂÃ¤Â¸Å Ã©â„¢ÂÃ¯Â¼Å¡4 MB";

    /// <summary>
    /// Key: "Description.NoGameProducts"
    /// English String: "No game products found for this game"
    /// </summary>
    public override string DescriptionNoGameProducts => "Ã¦â€°Â¾Ã¤Â¸ÂÃ¥Ë†Â°Ã¦Â­Â¤Ã©ÂÅ Ã¦Ë†Â²Ã§Å¡â€žÃ§â€Â¢Ã¥â€œÂ";

    /// <summary>
    /// Key: "Description.RecommendedResolution"
    /// The recommended resolution for icon image
    /// English String: "Recommended resolution: 512 x 512"
    /// </summary>
    public override string DescriptionRecommendedResolution => "Ã¦Å½Â¨Ã¨â€“Â¦Ã¨Â§Â£Ã¦Å¾ÂÃ¥ÂºÂ¦Ã¯Â¼Å¡512 x 512";

    /// <summary>
    /// Key: "Description.RecommendedResolutionForIcon"
    /// English String: "Recommended resolution: 512 x 512"
    /// </summary>
    public override string DescriptionRecommendedResolutionForIcon => "Ã¦Å½Â¨Ã¨â€“Â¦Ã¨Â§Â£Ã¦Å¾ÂÃ¥ÂºÂ¦Ã¯Â¼Å¡512 x 512";

    /// <summary>
    /// Key: "Description.RecommendedResolutionForThumbnail"
    /// English String: "Recommended resolution: 1920 x 1080"
    /// </summary>
    public override string DescriptionRecommendedResolutionForThumbnail => "Ã¦Å½Â¨Ã¨â€“Â¦Ã¨Â§Â£Ã¦Å¾ÂÃ¥ÂºÂ¦Ã¯Â¼Å¡1920 x 1080";

    /// <summary>
    /// Key: "Description.ScreenshotsLimitForThumbnail"
    /// English String: "You can set up to 10 screenshots"
    /// </summary>
    public override string DescriptionScreenshotsLimitForThumbnail => "Ã¦Å“â‚¬Ã¥Â¤Å¡Ã¥ÂÂ¯Ã¤Â»Â¥Ã¨Â¨Â­Ã§Â½Â® 10 Ã¥Â¼ÂµÃ¦Ë†ÂªÃ¥Å“â€“";

    /// <summary>
    /// Key: "Description.UnsavedChanges"
    /// The body of the modal that asks the user to confirm discarding unsaved changes
    /// English String: "Unsaved changes will be discarded. Are you sure?"
    /// </summary>
    public override string DescriptionUnsavedChanges => "Ã¦Å“ÂªÃ¥â€žÂ²Ã¥Â­ËœÃ§Å¡â€žÃ¨Â®Å Ã¦â€ºÂ´Ã¥Â°â€¡Ã¦Å“Æ’Ã¨Â¢Â«Ã¦ÂÂ¨Ã¦Â£â€žÃ£â‚¬â€šÃ§Â¢ÂºÃ¥Â®Å¡Ã¯Â¼Å¸";

    /// <summary>
    /// Key: "Heading.BadgeDescription"
    /// Badge Description localization tool heading
    /// English String: "Badge Description"
    /// </summary>
    public override string HeadingBadgeDescription => "Ã¥Â¾Â½Ã§Â«Â Ã¨ÂªÂªÃ¦ËœÅ½";

    /// <summary>
    /// Key: "Heading.BadgeName"
    /// Badge Name localization tool heading
    /// English String: "Badge Name"
    /// </summary>
    public override string HeadingBadgeName => "Ã¥Â¾Â½Ã§Â«Â Ã¥ÂÂÃ§Â¨Â±";

    /// <summary>
    /// Key: "Heading.GameDescription"
    /// Game Description localization tool heading
    /// English String: "Game Description"
    /// </summary>
    public override string HeadingGameDescription => "Ã©ÂÅ Ã¦Ë†Â²Ã¨ÂªÂªÃ¦ËœÅ½";

    /// <summary>
    /// Key: "Heading.GameIcon"
    /// Game Icon localization tool heading
    /// English String: "Game Icon"
    /// </summary>
    public override string HeadingGameIcon => "Ã©ÂÅ Ã¦Ë†Â²Ã¥Å“â€“Ã§Â¤Âº";

    /// <summary>
    /// Key: "Heading.GameName"
    /// Game Name localization tool heading
    /// English String: "Game Name"
    /// </summary>
    public override string HeadingGameName => "Ã©ÂÅ Ã¦Ë†Â²Ã¥ÂÂÃ§Â¨Â±";

    /// <summary>
    /// Key: "Heading.GameThumbnails"
    /// Game Thumbnails localization tool heading
    /// English String: "Game Thumbnails"
    /// </summary>
    public override string HeadingGameThumbnails => "Ã©ÂÅ Ã¦Ë†Â²Ã§Â¸Â®Ã¥Å“â€“";

    /// <summary>
    /// Key: "Heading.ManageTranslations"
    /// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
    /// English String: "Manage Translations"
    /// </summary>
    public override string HeadingManageTranslations => "Ã§Â®Â¡Ã§Ââ€ Ã§Â¿Â»Ã¨Â­Â¯";

    /// <summary>
    /// Key: "Heading.NoContent"
    /// English String: "No Content"
    /// </summary>
    public override string HeadingNoContent => "Ã¦Â²â€™Ã¦Å“â€°Ã¥â€¦Â§Ã¥Â®Â¹";

    /// <summary>
    /// Key: "Heading.Thumbnails"
    /// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
    /// English String: "Thumbnails"
    /// </summary>
    public override string HeadingThumbnails => "Ã§Â¸Â®Ã¥Å“â€“";

    /// <summary>
    /// Key: "Heading.TranslationHistory"
    /// Heading for the translation history section of name/description
    /// English String: "Translation History"
    /// </summary>
    public override string HeadingTranslationHistory => "Ã§Â¿Â»Ã¨Â­Â¯Ã§Â´â‚¬Ã©Å’â€ž";

    /// <summary>
    /// Key: "Heading.TranslationManagement"
    /// The title of the translation management page
    /// English String: "Translation Management"
    /// </summary>
    public override string HeadingTranslationManagement => "Ã§Â¿Â»Ã¨Â­Â¯Ã§Â®Â¡Ã§Ââ€ ";

    /// <summary>
    /// Key: "Heading.UnsavedChanges"
    /// The heading of the modal that asks the user to confirm discarding unsaved changes
    /// English String: "Unsaved Changes"
    /// </summary>
    public override string HeadingUnsavedChanges => "Ã¦Å“ÂªÃ¥â€žÂ²Ã¥Â­ËœÃ¨Â®Å Ã¦â€ºÂ´";

    /// <summary>
    /// Key: "Label.Description"
    /// The label for Description I18n sub navigation tab
    /// English String: "Description"
    /// </summary>
    public override string LabelDescription => "Ã¨ÂªÂªÃ¦ËœÅ½";

    /// <summary>
    /// Key: "Label.GameInformation"
    /// The label for Game Information I18n navigation tab
    /// English String: "Game Information"
    /// </summary>
    public override string LabelGameInformation => "Ã©ÂÅ Ã¦Ë†Â²Ã¨Â³â€¡Ã¨Â¨Å ";

    /// <summary>
    /// Key: "Label.GameProducts"
    /// The label for Game Products I18n navigation tab
    /// English String: "Game Products"
    /// </summary>
    public override string LabelGameProducts => "Ã©ÂÅ Ã¦Ë†Â²Ã§â€Â¢Ã¥â€œÂ";

    /// <summary>
    /// Key: "Label.GameStrings"
    /// The label for Game Strings I18n navigation tab
    /// English String: "Game Strings"
    /// </summary>
    public override string LabelGameStrings => "Ã©ÂÅ Ã¦Ë†Â²Ã¥Â­â€”Ã¤Â¸Â²";

    /// <summary>
    /// Key: "Label.Icon"
    /// The label for Icon I18n sub navigation tab
    /// English String: "Icon"
    /// </summary>
    public override string LabelIcon => "Ã¥Å“â€“Ã§Â¤Âº";

    /// <summary>
    /// Key: "Label.ImageHoverText"
    /// User is hovering over a localized image. Describes screen for user with accessibility settings.
    /// English String: "Localized Image"
    /// </summary>
    public override string LabelImageHoverText => "Ã¦Å“Â¬Ã¥Å“Â°Ã¥Å’â€“Ã¥Å“â€“Ã¥Æ’Â";

    /// <summary>
    /// Key: "Label.Name"
    /// The label for Name I18n sub navigation tab
    /// English String: "Name"
    /// </summary>
    public override string LabelName => "Ã¥ÂÂÃ§Â¨Â±";

    /// <summary>
    /// Key: "Label.TextToTranslate"
    /// Label for the source name/description text
    /// English String: "Text to translate"
    /// </summary>
    public override string LabelTextToTranslate => "Ã¥Â¾â€¦Ã§Â¿Â»Ã¨Â­Â¯Ã¦â€“â€¡Ã¥Â­â€”";

    /// <summary>
    /// Key: "Label.Thumbnails"
    /// The label for Thumbnails I18n sub navigation tab
    /// English String: "Thumbnails"
    /// </summary>
    public override string LabelThumbnails => "Ã§Â¸Â®Ã¥Å“â€“";

    /// <summary>
    /// Key: "Response.AccessDenied"
    /// Message if user does not have permission to access the UI
    /// English String: "You don't have permission to access this page"
    /// </summary>
    public override string ResponseAccessDenied => "Ã¦â€šÂ¨Ã¦Â²â€™Ã¦Å“â€°Ã¦Â¬Å Ã©â„¢ÂÃ¦ÂªÂ¢Ã¨Â¦â€“Ã¦Â­Â¤Ã©Â ÂÃ©ÂÂ¢";

    /// <summary>
    /// Key: "Response.ContentModerationError"
    /// The error text when user's input does not pass the text filter
    /// English String: "Could not save. Please check content for moderation and try again."
    /// </summary>
    public override string ResponseContentModerationError => "Ã§â€žÂ¡Ã¦Â³â€¢Ã¥â€žÂ²Ã¥Â­ËœÃ£â‚¬â€šÃ¨Â«â€¹Ã¦ÂªÂ¢Ã¦Å¸Â¥Ã¥â€¦Â§Ã¥Â®Â¹Ã¦ËœÂ¯Ã¥ÂÂ¦Ã©ÂÂ­Ã¥Ë†Â°Ã©ÂÅ½Ã¦Â¿Â¾Ã¯Â¼Å’Ã§â€žÂ¶Ã¥Â¾Å’Ã©â€¡ÂÃ¦â€“Â°Ã¥Ëœâ€”Ã¨Â©Â¦Ã£â‚¬â€š";

    /// <summary>
    /// Key: "Response.GeneralError"
    /// Message for general errors
    /// English String: "An error has occurred. Please try again later."
    /// </summary>
    public override string ResponseGeneralError => "Ã§â„¢Â¼Ã§â€Å¸Ã©Å’Â¯Ã¨ÂªÂ¤Ã¯Â¼Å’Ã¨Â«â€¹Ã§Â¨ÂÃ¥Â¾Å’Ã¥â€ ÂÃ¨Â©Â¦Ã£â‚¬â€š";

    /// <summary>
    /// Key: "Response.IncorrectFormatOrSize"
    /// Response shows to user when their icon image fails to save due to incorrect format or size too large
    /// English String: "Could not save. Please make sure files are the correct size and format."
    /// </summary>
    public override string ResponseIncorrectFormatOrSize => "Ã§â€žÂ¡Ã¦Â³â€¢Ã¥â€žÂ²Ã¥Â­ËœÃ¯Â¼Å’Ã¨Â«â€¹Ã§Â¢ÂºÃ¨ÂªÂÃ¦Âªâ€Ã¦Â¡Ë†Ã¥Â¤Â§Ã¥Â°ÂÃ¥â€™Å’Ã¦Â Â¼Ã¥Â¼ÂÃ¦Â­Â£Ã§Â¢ÂºÃ£â‚¬â€š";

    /// <summary>
    /// Key: "Response.NoTranslationLanguageAvailable"
    /// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
    /// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
    /// </summary>
    public override string ResponseNoTranslationLanguageAvailable => "Ã¦Â²â€™Ã¦Å“â€°Ã¥Â·Â²Ã§Â¿Â»Ã¨Â­Â¯Ã§Å¡â€žÃ¥â€¦Â§Ã¥Â®Â¹Ã£â‚¬â€šÃ¨â€¹Â¥Ã¨Â¦ÂÃ§Â¿Â»Ã¨Â­Â¯Ã©ÂÅ Ã¦Ë†Â²Ã¥â€¦Â§Ã¥Â®Â¹Ã¯Â¼Å’Ã¨Â«â€¹Ã¥Å“Â¨Ã¦Å“Â¬Ã¥Å“Â°Ã¥Å’â€“Ã¨Â¨Â­Ã¥Â®Å¡Ã¦â€“Â°Ã¥Â¢Å¾Ã¨ÂªÅ¾Ã¨Â¨â‚¬Ã£â‚¬â€š";

    /// <summary>
    /// Key: "Response.SaveFailure"
    /// Feedback message if a change cannot be saved
    /// English String: "Could not save. Please try again."
    /// </summary>
    public override string ResponseSaveFailure => "Ã§â€žÂ¡Ã¦Â³â€¢Ã¥â€žÂ²Ã¥Â­ËœÃ¯Â¼Å’Ã¨Â«â€¹Ã©â€¡ÂÃ¦â€“Â°Ã¥Ëœâ€”Ã¨Â©Â¦Ã£â‚¬â€š";

    /// <summary>
    /// Key: "Response.TooManyFiles"
    /// English String: "Too many files. Please upload up to 10 files only."
    /// </summary>
    public override string ResponseTooManyFiles => "Ã¦Âªâ€Ã¦Â¡Ë†Ã©ÂÅ½Ã¥Â¤Å¡Ã¯Â¼Å’Ã¤Â¸â‚¬Ã¦Â¬Â¡Ã¦Å“â‚¬Ã¥Â¤Å¡Ã¥ÂÂªÃ¨Æ’Â½Ã¤Â¸Å Ã¥â€šÂ³ 10 Ã¥â‚¬â€¹Ã¦Âªâ€Ã¦Â¡Ë†Ã£â‚¬â€š";

    protected override string _GetTemplateForActionPleaseReload()
    {
        return "Ã¨Â«â€¹Ã©â€¡ÂÃ¦â€“Â°Ã¨Â¼â€°Ã¥â€¦Â¥Ã£â‚¬â€š";
    }

    protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
    {
        return "Ã¥ÂÂ¯Ã¦Å½Â¥Ã¥Ââ€”Ã§Å¡â€žÃ¦Âªâ€Ã¦Â¡Ë†Ã¦Â Â¼Ã¥Â¼ÂÃ¯Â¼Å¡jpgÃ£â‚¬ÂjpegÃ£â‚¬Âpng";
    }

    protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
    {
        return "Ã¥ÂÂ¯Ã¦Å½Â¥Ã¥Ââ€”Ã§Å¡â€žÃ¦Âªâ€Ã¦Â¡Ë†Ã¦Â Â¼Ã¥Â¼ÂÃ¯Â¼Å¡jpgÃ£â‚¬ÂjpegÃ£â‚¬Âpng";
    }

    /// <summary>
    /// Key: "Description.CharacterLimit"
    /// Description for character limit of name/description
    /// English String: "{limitNumber} Characters"
    /// </summary>
    public override string DescriptionCharacterLimit(string limitNumber)
    {
        return $"{limitNumber} Ã¥â‚¬â€¹Ã¥Â­â€”Ã¥â€¦Æ’";
    }

    protected override string _GetTemplateForDescriptionCharacterLimit()
    {
        return "{limitNumber} Ã¥â‚¬â€¹Ã¥Â­â€”Ã¥â€¦Æ’";
    }

    protected override string _GetTemplateForDescriptionEnterTranslationHere()
    {
        return "Ã¥Å“Â¨Ã¦Â­Â¤Ã¨Â¼Â¸Ã¥â€¦Â¥Ã§Â¿Â»Ã¨Â­Â¯";
    }

    protected override string _GetTemplateForDescriptionIconWillBeReviewed()
    {
        return "Ã¤Â¸Å Ã¥â€šÂ³Ã§Å¡â€žÃ¥Å“â€“Ã¥Æ’ÂÃ¥Â°â€¡Ã¥â€¦Ë†Ã§â€Â±Ã§Â®Â¡Ã§Ââ€ Ã¥â€œÂ¡Ã¥Â¯Â©Ã¦Â Â¸Ã¯Â¼Å’Ã¦â€°ÂÃ¦Å“Æ’Ã©â€“â€¹Ã¦â€Â¾Ã¥â€¦Â¶Ã¤Â»â€“Ã¤Â½Â¿Ã§â€Â¨Ã¨â‚¬â€¦Ã¦ÂªÂ¢Ã¨Â¦â€“";
    }

    protected override string _GetTemplateForDescriptionImageNotAvailable()
    {
        return "Ã§â€žÂ¡Ã¦Â³â€¢Ã¨Â¼â€°Ã¥â€¦Â¥Ã¥Å“â€“Ã¥Æ’ÂÃ£â‚¬â€š";
    }

    protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
    {
        return "Ã¦Âªâ€Ã¦Â¡Ë†Ã¥Â¤Â§Ã¥Â°ÂÃ¤Â¸Å Ã©â„¢ÂÃ¯Â¼Å¡4 MB";
    }

    protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
    {
        return "Ã¦Âªâ€Ã¦Â¡Ë†Ã¥Â¤Â§Ã¥Â°ÂÃ¤Â¸Å Ã©â„¢ÂÃ¯Â¼Å¡4 MB";
    }

    protected override string _GetTemplateForDescriptionNoGameProducts()
    {
        return "Ã¦â€°Â¾Ã¤Â¸ÂÃ¥Ë†Â°Ã¦Â­Â¤Ã©ÂÅ Ã¦Ë†Â²Ã§Å¡â€žÃ§â€Â¢Ã¥â€œÂ";
    }

    protected override string _GetTemplateForDescriptionRecommendedResolution()
    {
        return "Ã¦Å½Â¨Ã¨â€“Â¦Ã¨Â§Â£Ã¦Å¾ÂÃ¥ÂºÂ¦Ã¯Â¼Å¡512 x 512";
    }

    protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
    {
        return "Ã¦Å½Â¨Ã¨â€“Â¦Ã¨Â§Â£Ã¦Å¾ÂÃ¥ÂºÂ¦Ã¯Â¼Å¡512 x 512";
    }

    protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
    {
        return "Ã¦Å½Â¨Ã¨â€“Â¦Ã¨Â§Â£Ã¦Å¾ÂÃ¥ÂºÂ¦Ã¯Â¼Å¡1920 x 1080";
    }

    protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
    {
        return "Ã¦Å“â‚¬Ã¥Â¤Å¡Ã¥ÂÂ¯Ã¤Â»Â¥Ã¨Â¨Â­Ã§Â½Â® 10 Ã¥Â¼ÂµÃ¦Ë†ÂªÃ¥Å“â€“";
    }

    protected override string _GetTemplateForDescriptionUnsavedChanges()
    {
        return "Ã¦Å“ÂªÃ¥â€žÂ²Ã¥Â­ËœÃ§Å¡â€žÃ¨Â®Å Ã¦â€ºÂ´Ã¥Â°â€¡Ã¦Å“Æ’Ã¨Â¢Â«Ã¦ÂÂ¨Ã¦Â£â€žÃ£â‚¬â€šÃ§Â¢ÂºÃ¥Â®Å¡Ã¯Â¼Å¸";
    }

    protected override string _GetTemplateForHeadingBadgeDescription()
    {
        return "Ã¥Â¾Â½Ã§Â«Â Ã¨ÂªÂªÃ¦ËœÅ½";
    }

    protected override string _GetTemplateForHeadingBadgeName()
    {
        return "Ã¥Â¾Â½Ã§Â«Â Ã¥ÂÂÃ§Â¨Â±";
    }

    protected override string _GetTemplateForHeadingGameDescription()
    {
        return "Ã©ÂÅ Ã¦Ë†Â²Ã¨ÂªÂªÃ¦ËœÅ½";
    }

    protected override string _GetTemplateForHeadingGameIcon()
    {
        return "Ã©ÂÅ Ã¦Ë†Â²Ã¥Å“â€“Ã§Â¤Âº";
    }

    protected override string _GetTemplateForHeadingGameName()
    {
        return "Ã©ÂÅ Ã¦Ë†Â²Ã¥ÂÂÃ§Â¨Â±";
    }

    protected override string _GetTemplateForHeadingGameThumbnails()
    {
        return "Ã©ÂÅ Ã¦Ë†Â²Ã§Â¸Â®Ã¥Å“â€“";
    }

    protected override string _GetTemplateForHeadingManageTranslations()
    {
        return "Ã§Â®Â¡Ã§Ââ€ Ã§Â¿Â»Ã¨Â­Â¯";
    }

    protected override string _GetTemplateForHeadingNoContent()
    {
        return "Ã¦Â²â€™Ã¦Å“â€°Ã¥â€¦Â§Ã¥Â®Â¹";
    }

    protected override string _GetTemplateForHeadingThumbnails()
    {
        return "Ã§Â¸Â®Ã¥Å“â€“";
    }

    protected override string _GetTemplateForHeadingTranslationHistory()
    {
        return "Ã§Â¿Â»Ã¨Â­Â¯Ã§Â´â‚¬Ã©Å’â€ž";
    }

    protected override string _GetTemplateForHeadingTranslationManagement()
    {
        return "Ã§Â¿Â»Ã¨Â­Â¯Ã§Â®Â¡Ã§Ââ€ ";
    }

    protected override string _GetTemplateForHeadingUnsavedChanges()
    {
        return "Ã¦Å“ÂªÃ¥â€žÂ²Ã¥Â­ËœÃ¨Â®Å Ã¦â€ºÂ´";
    }

    protected override string _GetTemplateForLabelDescription()
    {
        return "Ã¨ÂªÂªÃ¦ËœÅ½";
    }

    protected override string _GetTemplateForLabelGameInformation()
    {
        return "Ã©ÂÅ Ã¦Ë†Â²Ã¨Â³â€¡Ã¨Â¨Å ";
    }

    protected override string _GetTemplateForLabelGameProducts()
    {
        return "Ã©ÂÅ Ã¦Ë†Â²Ã§â€Â¢Ã¥â€œÂ";
    }

    protected override string _GetTemplateForLabelGameStrings()
    {
        return "Ã©ÂÅ Ã¦Ë†Â²Ã¥Â­â€”Ã¤Â¸Â²";
    }

    protected override string _GetTemplateForLabelIcon()
    {
        return "Ã¥Å“â€“Ã§Â¤Âº";
    }

    protected override string _GetTemplateForLabelImageHoverText()
    {
        return "Ã¦Å“Â¬Ã¥Å“Â°Ã¥Å’â€“Ã¥Å“â€“Ã¥Æ’Â";
    }

    protected override string _GetTemplateForLabelName()
    {
        return "Ã¥ÂÂÃ§Â¨Â±";
    }

    protected override string _GetTemplateForLabelTextToTranslate()
    {
        return "Ã¥Â¾â€¦Ã§Â¿Â»Ã¨Â­Â¯Ã¦â€“â€¡Ã¥Â­â€”";
    }

    protected override string _GetTemplateForLabelThumbnails()
    {
        return "Ã§Â¸Â®Ã¥Å“â€“";
    }

    protected override string _GetTemplateForResponseAccessDenied()
    {
        return "Ã¦â€šÂ¨Ã¦Â²â€™Ã¦Å“â€°Ã¦Â¬Å Ã©â„¢ÂÃ¦ÂªÂ¢Ã¨Â¦â€“Ã¦Â­Â¤Ã©Â ÂÃ©ÂÂ¢";
    }

    protected override string _GetTemplateForResponseContentModerationError()
    {
        return "Ã§â€žÂ¡Ã¦Â³â€¢Ã¥â€žÂ²Ã¥Â­ËœÃ£â‚¬â€šÃ¨Â«â€¹Ã¦ÂªÂ¢Ã¦Å¸Â¥Ã¥â€¦Â§Ã¥Â®Â¹Ã¦ËœÂ¯Ã¥ÂÂ¦Ã©ÂÂ­Ã¥Ë†Â°Ã©ÂÅ½Ã¦Â¿Â¾Ã¯Â¼Å’Ã§â€žÂ¶Ã¥Â¾Å’Ã©â€¡ÂÃ¦â€“Â°Ã¥Ëœâ€”Ã¨Â©Â¦Ã£â‚¬â€š";
    }

    protected override string _GetTemplateForResponseGeneralError()
    {
        return "Ã§â„¢Â¼Ã§â€Å¸Ã©Å’Â¯Ã¨ÂªÂ¤Ã¯Â¼Å’Ã¨Â«â€¹Ã§Â¨ÂÃ¥Â¾Å’Ã¥â€ ÂÃ¨Â©Â¦Ã£â‚¬â€š";
    }

    protected override string _GetTemplateForResponseIncorrectFormatOrSize()
    {
        return "Ã§â€žÂ¡Ã¦Â³â€¢Ã¥â€žÂ²Ã¥Â­ËœÃ¯Â¼Å’Ã¨Â«â€¹Ã§Â¢ÂºÃ¨ÂªÂÃ¦Âªâ€Ã¦Â¡Ë†Ã¥Â¤Â§Ã¥Â°ÂÃ¥â€™Å’Ã¦Â Â¼Ã¥Â¼ÂÃ¦Â­Â£Ã§Â¢ÂºÃ£â‚¬â€š";
    }

    protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
    {
        return "Ã¦Â²â€™Ã¦Å“â€°Ã¥Â·Â²Ã§Â¿Â»Ã¨Â­Â¯Ã§Å¡â€žÃ¥â€¦Â§Ã¥Â®Â¹Ã£â‚¬â€šÃ¨â€¹Â¥Ã¨Â¦ÂÃ§Â¿Â»Ã¨Â­Â¯Ã©ÂÅ Ã¦Ë†Â²Ã¥â€¦Â§Ã¥Â®Â¹Ã¯Â¼Å’Ã¨Â«â€¹Ã¥Å“Â¨Ã¦Å“Â¬Ã¥Å“Â°Ã¥Å’â€“Ã¨Â¨Â­Ã¥Â®Å¡Ã¦â€“Â°Ã¥Â¢Å¾Ã¨ÂªÅ¾Ã¨Â¨â‚¬Ã£â‚¬â€š";
    }

    protected override string _GetTemplateForResponseSaveFailure()
    {
        return "Ã§â€žÂ¡Ã¦Â³â€¢Ã¥â€žÂ²Ã¥Â­ËœÃ¯Â¼Å’Ã¨Â«â€¹Ã©â€¡ÂÃ¦â€“Â°Ã¥Ëœâ€”Ã¨Â©Â¦Ã£â‚¬â€š";
    }

    protected override string _GetTemplateForResponseTooManyFiles()
    {
        return "Ã¦Âªâ€Ã¦Â¡Ë†Ã©ÂÅ½Ã¥Â¤Å¡Ã¯Â¼Å’Ã¤Â¸â‚¬Ã¦Â¬Â¡Ã¦Å“â‚¬Ã¥Â¤Å¡Ã¥ÂÂªÃ¨Æ’Â½Ã¤Â¸Å Ã¥â€šÂ³ 10 Ã¥â‚¬â€¹Ã¦Âªâ€Ã¦Â¡Ë†Ã£â‚¬â€š";
    }
}
}

