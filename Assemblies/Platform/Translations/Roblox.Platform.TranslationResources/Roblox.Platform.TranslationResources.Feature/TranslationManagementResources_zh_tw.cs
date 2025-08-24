namespace Roblox.TranslationResources.Feature;

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
	public override string ActionPleaseReload => "請重新載入。";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "可接受的檔案格式：jpg、jpeg、png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "可接受的檔案格式：jpg、jpeg、png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "在此輸入翻譯";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "上傳的圖像將先由管理員審核，才會開放其他使用者檢視";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "無法載入圖像。";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "檔案大小上限：4 MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "檔案大小上限：4 MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "找不到此遊戲的產品";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "推薦解析度：512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "推薦解析度：512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "推薦解析度：1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "最多可以設置 10 張截圖";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "未儲存的變更將會被捨棄。確定？";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "徽章說明";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "徽章名稱";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "遊戲說明";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "遊戲圖示";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "遊戲名稱";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "遊戲縮圖";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "管理翻譯";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "沒有內容";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "縮圖";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "翻譯紀錄";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "翻譯管理";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "未儲存變更";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "說明";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "遊戲資訊";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "遊戲產品";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "遊戲字串";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "圖示";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "本地化圖像";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "名稱";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "待翻譯文字";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "縮圖";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "您沒有權限檢視此頁面";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "無法儲存。請檢查內容是否遭到過濾，然後重新嘗試。";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "無法儲存，請確認檔案大小和格式正確。";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "沒有已翻譯的內容。若要翻譯遊戲內容，請在本地化設定新增語言。";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "無法儲存，請重新嘗試。";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "檔案過多，一次最多只能上傳 10 個檔案。";

	public TranslationManagementResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "請重新載入。";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "可接受的檔案格式：jpg、jpeg、png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "可接受的檔案格式：jpg、jpeg、png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber} 個字元";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber} 個字元";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "在此輸入翻譯";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "上傳的圖像將先由管理員審核，才會開放其他使用者檢視";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "無法載入圖像。";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "檔案大小上限：4 MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "檔案大小上限：4 MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "找不到此遊戲的產品";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "推薦解析度：512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "推薦解析度：512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "推薦解析度：1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "最多可以設置 10 張截圖";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "未儲存的變更將會被捨棄。確定？";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "徽章說明";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "徽章名稱";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "遊戲說明";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "遊戲圖示";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "遊戲名稱";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "遊戲縮圖";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "管理翻譯";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "沒有內容";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "縮圖";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "翻譯紀錄";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "翻譯管理";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "未儲存變更";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "說明";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "遊戲資訊";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "遊戲產品";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "遊戲字串";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "圖示";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "本地化圖像";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "名稱";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "待翻譯文字";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "縮圖";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "您沒有權限檢視此頁面";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "無法儲存。請檢查內容是否遭到過濾，然後重新嘗試。";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "無法儲存，請確認檔案大小和格式正確。";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "沒有已翻譯的內容。若要翻譯遊戲內容，請在本地化設定新增語言。";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "無法儲存，請重新嘗試。";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "檔案過多，一次最多只能上傳 10 個檔案。";
	}
}
