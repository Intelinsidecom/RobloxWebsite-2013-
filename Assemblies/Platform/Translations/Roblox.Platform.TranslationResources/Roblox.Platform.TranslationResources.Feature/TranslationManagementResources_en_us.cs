using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class TranslationManagementResources_en_us : TranslationResourcesBase, ITranslationManagementResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public virtual string ActionPleaseReload => "Please reload.";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public virtual string DescriptionAcceptableFilesForIcon => "Acceptable files: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public virtual string DescriptionAcceptableFilesForThumbnail => "Acceptable files: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public virtual string DescriptionEnterTranslationHere => "Enter translation here";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public virtual string DescriptionIconWillBeReviewed => "Image will be reviewed by moderators before being made visible to other users";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public virtual string DescriptionImageNotAvailable => "Image not available.";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public virtual string DescriptionMaximumSizeForIcon => "Maximum file size: 4 MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public virtual string DescriptionMaximumSizeForThumbnail => "Maximum file size: 4 MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public virtual string DescriptionNoGameProducts => "No game products found for this game";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public virtual string DescriptionRecommendedResolution => "Recommended resolution: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public virtual string DescriptionRecommendedResolutionForIcon => "Recommended resolution: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public virtual string DescriptionRecommendedResolutionForThumbnail => "Recommended resolution: 1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public virtual string DescriptionScreenshotsLimitForThumbnail => "You can set up to 10 screenshots";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public virtual string DescriptionUnsavedChanges => "Unsaved changes will be discarded. Are you sure?";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public virtual string HeadingBadgeDescription => "Badge Description";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public virtual string HeadingBadgeName => "Badge Name";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public virtual string HeadingGameDescription => "Game Description";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public virtual string HeadingGameIcon => "Game Icon";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public virtual string HeadingGameName => "Game Name";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public virtual string HeadingGameThumbnails => "Game Thumbnails";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public virtual string HeadingManageTranslations => "Manage Translations";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public virtual string HeadingNoContent => "No Content";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public virtual string HeadingThumbnails => "Thumbnails";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public virtual string HeadingTranslationHistory => "Translation History";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public virtual string HeadingTranslationManagement => "Translation Management";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public virtual string HeadingUnsavedChanges => "Unsaved Changes";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public virtual string LabelDescription => "Description";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public virtual string LabelGameInformation => "Game Information";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public virtual string LabelGameProducts => "Game Products";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public virtual string LabelGameStrings => "Game Strings";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public virtual string LabelIcon => "Icon";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public virtual string LabelImageHoverText => "Localized Image";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public virtual string LabelName => "Name";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public virtual string LabelTextToTranslate => "Text to translate";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public virtual string LabelThumbnails => "Thumbnails";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public virtual string ResponseAccessDenied => "You don't have permission to access this page";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public virtual string ResponseContentModerationError => "Could not save. Please check content for moderation and try again.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public virtual string ResponseGeneralError => "An error has occurred. Please try again later.";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public virtual string ResponseIncorrectFormatOrSize => "Could not save. Please make sure files are the correct size and format.";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public virtual string ResponseNoTranslationLanguageAvailable => "Translated content does not exist. Add a translation language in Configure Localization to translate game content.";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public virtual string ResponseSaveFailure => "Could not save. Please try again.";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public virtual string ResponseTooManyFiles => "Too many files. Please upload up to 10 files only.";

	public TranslationManagementResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.PleaseReload",
				_GetTemplateForActionPleaseReload()
			},
			{
				"Description.AcceptableFilesForIcon",
				_GetTemplateForDescriptionAcceptableFilesForIcon()
			},
			{
				"Description.AcceptableFilesForThumbnail",
				_GetTemplateForDescriptionAcceptableFilesForThumbnail()
			},
			{
				"Description.CharacterLimit",
				_GetTemplateForDescriptionCharacterLimit()
			},
			{
				"Description.EnterTranslationHere",
				_GetTemplateForDescriptionEnterTranslationHere()
			},
			{
				"Description.IconWillBeReviewed",
				_GetTemplateForDescriptionIconWillBeReviewed()
			},
			{
				"Description.ImageNotAvailable",
				_GetTemplateForDescriptionImageNotAvailable()
			},
			{
				"Description.MaximumSizeForIcon",
				_GetTemplateForDescriptionMaximumSizeForIcon()
			},
			{
				"Description.MaximumSizeForThumbnail",
				_GetTemplateForDescriptionMaximumSizeForThumbnail()
			},
			{
				"Description.NoGameProducts",
				_GetTemplateForDescriptionNoGameProducts()
			},
			{
				"Description.RecommendedResolution",
				_GetTemplateForDescriptionRecommendedResolution()
			},
			{
				"Description.RecommendedResolutionForIcon",
				_GetTemplateForDescriptionRecommendedResolutionForIcon()
			},
			{
				"Description.RecommendedResolutionForThumbnail",
				_GetTemplateForDescriptionRecommendedResolutionForThumbnail()
			},
			{
				"Description.ScreenshotsLimitForThumbnail",
				_GetTemplateForDescriptionScreenshotsLimitForThumbnail()
			},
			{
				"Description.UnsavedChanges",
				_GetTemplateForDescriptionUnsavedChanges()
			},
			{
				"Heading.BadgeDescription",
				_GetTemplateForHeadingBadgeDescription()
			},
			{
				"Heading.BadgeName",
				_GetTemplateForHeadingBadgeName()
			},
			{
				"Heading.GameDescription",
				_GetTemplateForHeadingGameDescription()
			},
			{
				"Heading.GameIcon",
				_GetTemplateForHeadingGameIcon()
			},
			{
				"Heading.GameName",
				_GetTemplateForHeadingGameName()
			},
			{
				"Heading.GameThumbnails",
				_GetTemplateForHeadingGameThumbnails()
			},
			{
				"Heading.ManageTranslations",
				_GetTemplateForHeadingManageTranslations()
			},
			{
				"Heading.NoContent",
				_GetTemplateForHeadingNoContent()
			},
			{
				"Heading.Thumbnails",
				_GetTemplateForHeadingThumbnails()
			},
			{
				"Heading.TranslationHistory",
				_GetTemplateForHeadingTranslationHistory()
			},
			{
				"Heading.TranslationManagement",
				_GetTemplateForHeadingTranslationManagement()
			},
			{
				"Heading.UnsavedChanges",
				_GetTemplateForHeadingUnsavedChanges()
			},
			{
				"Label.Description",
				_GetTemplateForLabelDescription()
			},
			{
				"Label.GameInformation",
				_GetTemplateForLabelGameInformation()
			},
			{
				"Label.GameProducts",
				_GetTemplateForLabelGameProducts()
			},
			{
				"Label.GameStrings",
				_GetTemplateForLabelGameStrings()
			},
			{
				"Label.Icon",
				_GetTemplateForLabelIcon()
			},
			{
				"Label.ImageHoverText",
				_GetTemplateForLabelImageHoverText()
			},
			{
				"Label.Name",
				_GetTemplateForLabelName()
			},
			{
				"Label.TextToTranslate",
				_GetTemplateForLabelTextToTranslate()
			},
			{
				"Label.Thumbnails",
				_GetTemplateForLabelThumbnails()
			},
			{
				"Response.AccessDenied",
				_GetTemplateForResponseAccessDenied()
			},
			{
				"Response.ContentModerationError",
				_GetTemplateForResponseContentModerationError()
			},
			{
				"Response.GeneralError",
				_GetTemplateForResponseGeneralError()
			},
			{
				"Response.IncorrectFormatOrSize",
				_GetTemplateForResponseIncorrectFormatOrSize()
			},
			{
				"Response.NoTranslationLanguageAvailable",
				_GetTemplateForResponseNoTranslationLanguageAvailable()
			},
			{
				"Response.SaveFailure",
				_GetTemplateForResponseSaveFailure()
			},
			{
				"Response.TooManyFiles",
				_GetTemplateForResponseTooManyFiles()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.TranslationManagement";
	}

	protected virtual string _GetTemplateForActionPleaseReload()
	{
		return "Please reload.";
	}

	protected virtual string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "Acceptable files: jpg, jpeg, png";
	}

	protected virtual string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "Acceptable files: jpg, jpeg, png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public virtual string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber} Characters";
	}

	protected virtual string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber} Characters";
	}

	protected virtual string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "Enter translation here";
	}

	protected virtual string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "Image will be reviewed by moderators before being made visible to other users";
	}

	protected virtual string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "Image not available.";
	}

	protected virtual string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "Maximum file size: 4 MB";
	}

	protected virtual string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "Maximum file size: 4 MB";
	}

	protected virtual string _GetTemplateForDescriptionNoGameProducts()
	{
		return "No game products found for this game";
	}

	protected virtual string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "Recommended resolution: 512 x 512";
	}

	protected virtual string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "Recommended resolution: 512 x 512";
	}

	protected virtual string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "Recommended resolution: 1920 x 1080";
	}

	protected virtual string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "You can set up to 10 screenshots";
	}

	protected virtual string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Unsaved changes will be discarded. Are you sure?";
	}

	protected virtual string _GetTemplateForHeadingBadgeDescription()
	{
		return "Badge Description";
	}

	protected virtual string _GetTemplateForHeadingBadgeName()
	{
		return "Badge Name";
	}

	protected virtual string _GetTemplateForHeadingGameDescription()
	{
		return "Game Description";
	}

	protected virtual string _GetTemplateForHeadingGameIcon()
	{
		return "Game Icon";
	}

	protected virtual string _GetTemplateForHeadingGameName()
	{
		return "Game Name";
	}

	protected virtual string _GetTemplateForHeadingGameThumbnails()
	{
		return "Game Thumbnails";
	}

	protected virtual string _GetTemplateForHeadingManageTranslations()
	{
		return "Manage Translations";
	}

	protected virtual string _GetTemplateForHeadingNoContent()
	{
		return "No Content";
	}

	protected virtual string _GetTemplateForHeadingThumbnails()
	{
		return "Thumbnails";
	}

	protected virtual string _GetTemplateForHeadingTranslationHistory()
	{
		return "Translation History";
	}

	protected virtual string _GetTemplateForHeadingTranslationManagement()
	{
		return "Translation Management";
	}

	protected virtual string _GetTemplateForHeadingUnsavedChanges()
	{
		return "Unsaved Changes";
	}

	protected virtual string _GetTemplateForLabelDescription()
	{
		return "Description";
	}

	protected virtual string _GetTemplateForLabelGameInformation()
	{
		return "Game Information";
	}

	protected virtual string _GetTemplateForLabelGameProducts()
	{
		return "Game Products";
	}

	protected virtual string _GetTemplateForLabelGameStrings()
	{
		return "Game Strings";
	}

	protected virtual string _GetTemplateForLabelIcon()
	{
		return "Icon";
	}

	protected virtual string _GetTemplateForLabelImageHoverText()
	{
		return "Localized Image";
	}

	protected virtual string _GetTemplateForLabelName()
	{
		return "Name";
	}

	protected virtual string _GetTemplateForLabelTextToTranslate()
	{
		return "Text to translate";
	}

	protected virtual string _GetTemplateForLabelThumbnails()
	{
		return "Thumbnails";
	}

	protected virtual string _GetTemplateForResponseAccessDenied()
	{
		return "You don't have permission to access this page";
	}

	protected virtual string _GetTemplateForResponseContentModerationError()
	{
		return "Could not save. Please check content for moderation and try again.";
	}

	protected virtual string _GetTemplateForResponseGeneralError()
	{
		return "An error has occurred. Please try again later.";
	}

	protected virtual string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "Could not save. Please make sure files are the correct size and format.";
	}

	protected virtual string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "Translated content does not exist. Add a translation language in Configure Localization to translate game content.";
	}

	protected virtual string _GetTemplateForResponseSaveFailure()
	{
		return "Could not save. Please try again.";
	}

	protected virtual string _GetTemplateForResponseTooManyFiles()
	{
		return "Too many files. Please upload up to 10 files only.";
	}
}
