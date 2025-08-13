namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_zh_cjv : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public override string ActionPleaseReload => "请重新加载。";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "可接受的文件格式：jpg、jpeg、png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "可接受的文件格式：jpg、jpeg、png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "在此处输入翻译";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "图像将先由管理员审阅，通过后即可对其他用户可见";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "图像不可用。";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "文件大小上限：4 MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "文件大小上限：4 MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "无法找到此游戏的游戏产品";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "推荐分辨率：512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "推荐分辨率：512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "推荐分辨率：1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "你可最多设置 10 张屏幕快照";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "未保存的更改将被丢弃。是否确定？";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "奖章内容";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "奖章名称";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "游戏描述";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "游戏图标";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "游戏名称";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "游戏缩略图";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "管理翻译";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "无内容";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "缩略图";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "翻译历史记录";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "翻译管理";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "未保存的更改";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "描述";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "游戏信息";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "游戏产品";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "游戏字符串";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "图标";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "本地化图像";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "名称";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "待翻译文本";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "缩略图";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "你没有访问此页面的权限";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "无法保存。请检查内容是否符合审查要求，并重试。";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "发生错误，请稍后重试。";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "无法保存，请确认文件大小和格式正确。";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "没有已翻译的内容。在“本地化配置”中添加一个翻译语言，即可翻译游戏内容。";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "无法保存，请重试。";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "文件过多。请确定上传文件的数量不超过 10 个。";

	public TranslationManagementResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "请重新加载。";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "可接受的文件格式：jpg、jpeg、png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "可接受的文件格式：jpg、jpeg、png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber} 个字符";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber} 个字符";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "在此处输入翻译";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "图像将先由管理员审阅，通过后即可对其他用户可见";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "图像不可用。";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "文件大小上限：4 MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "文件大小上限：4 MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "无法找到此游戏的游戏产品";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "推荐分辨率：512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "推荐分辨率：512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "推荐分辨率：1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "你可最多设置 10 张屏幕快照";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "未保存的更改将被丢弃。是否确定？";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "奖章内容";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "奖章名称";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "游戏描述";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "游戏图标";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "游戏名称";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "游戏缩略图";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "管理翻译";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "无内容";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "缩略图";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "翻译历史记录";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "翻译管理";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "未保存的更改";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "描述";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "游戏信息";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "游戏产品";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "游戏字符串";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "图标";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "本地化图像";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "名称";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "待翻译文本";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "缩略图";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "你没有访问此页面的权限";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "无法保存。请检查内容是否符合审查要求，并重试。";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "发生错误，请稍后重试。";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "无法保存，请确认文件大小和格式正确。";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "没有已翻译的内容。在“本地化配置”中添加一个翻译语言，即可翻译游戏内容。";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "无法保存，请重试。";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "文件过多。请确定上传文件的数量不超过 10 个。";
	}
}
