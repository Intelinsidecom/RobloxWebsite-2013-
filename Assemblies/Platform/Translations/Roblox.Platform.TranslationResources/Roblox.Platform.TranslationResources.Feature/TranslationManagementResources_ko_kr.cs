namespace Roblox.TranslationResources.Feature;

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
	public override string ActionPleaseReload => "다시 불러오세요.";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "가능한 파일 형식: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "가능한 파일 형식: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "여기에 번역 입력";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "이미지는 검열팀의 검토가 끝난 후에 다른 사용자에게 공개됩니다";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "이미지 사용 불가.";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "최대 파일 크기: 4MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "최대 파일 크기: 4MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "이 게임의 상품을 찾을 수 없습니다";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "권장 해상도: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "권장 해상도: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "권장 해상도: 1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "최대 10개의 스크린샷을 설정할 수 있어요.";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "저장하지 않은 변경 사항이 삭제됩니다. 진행할까요?";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "배지 설명";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "배지 이름";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "게임 설명";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "게임 아이콘";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "게임 이름";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "게임 섬네일";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "번역 관리";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "콘텐츠 없음";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "섬네일";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "번역 내역";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "번역 관리";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "저장하지 않은 변경 사항";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "설명";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "게임 정보";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "게임 상품";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "게임 문자열";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "아이콘";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "현지화된 이미지";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "이름";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "번역할 텍스트";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "섬네일";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "본 페이지에 대한 접근 권한이 없습니다";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "저장 실패. 콘텐츠에 문제의 소지가 있는지 확인하고 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "저장하지 못했어요. 파일의 크기와 형식이 맞는지 확인하세요.";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "번역된 콘텐츠가 없습니다. 게임 콘텐츠를 번역하려면 '로컬리제이션 구성'에서 번역할 언어를 추가하세요.";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "저장할 수 없습니다. 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "파일이 너무 많습니다. 한 번에 파일 10개씩만 업로드하세요.";

	public TranslationManagementResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "다시 불러오세요.";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "가능한 파일 형식: jpg, jpeg, png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "가능한 파일 형식: jpg, jpeg, png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber}자";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber}자";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "여기에 번역 입력";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "이미지는 검열팀의 검토가 끝난 후에 다른 사용자에게 공개됩니다";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "이미지 사용 불가.";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "최대 파일 크기: 4MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "최대 파일 크기: 4MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "이 게임의 상품을 찾을 수 없습니다";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "권장 해상도: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "권장 해상도: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "권장 해상도: 1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "최대 10개의 스크린샷을 설정할 수 있어요.";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "저장하지 않은 변경 사항이 삭제됩니다. 진행할까요?";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "배지 설명";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "배지 이름";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "게임 설명";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "게임 아이콘";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "게임 이름";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "게임 섬네일";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "번역 관리";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "콘텐츠 없음";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "섬네일";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "번역 내역";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "번역 관리";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "저장하지 않은 변경 사항";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "설명";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "게임 정보";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "게임 상품";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "게임 문자열";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "아이콘";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "현지화된 이미지";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "이름";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "번역할 텍스트";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "섬네일";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "본 페이지에 대한 접근 권한이 없습니다";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "저장 실패. 콘텐츠에 문제의 소지가 있는지 확인하고 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "저장하지 못했어요. 파일의 크기와 형식이 맞는지 확인하세요.";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "번역된 콘텐츠가 없습니다. 게임 콘텐츠를 번역하려면 '로컬리제이션 구성'에서 번역할 언어를 추가하세요.";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "저장할 수 없습니다. 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "파일이 너무 많습니다. 한 번에 파일 10개씩만 업로드하세요.";
	}
}
