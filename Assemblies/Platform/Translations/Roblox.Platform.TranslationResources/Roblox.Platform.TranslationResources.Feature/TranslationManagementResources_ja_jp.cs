namespace Roblox.TranslationResources.Feature;

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
	public override string ActionPleaseReload => "再読み込みしてください。";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "許容可能なファイル: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "許容可能なファイル: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "翻訳の入力はこちら";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "画像は、モデレータによるレビュー後、他のユーザーに公開されます";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "画像が利用できません。";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "最大ファイルサイズ: 4 MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "最大ファイルサイズ: 4 MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "このゲームのゲーム製品が見つかりませんでした";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "推奨解像度: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "推奨解像度: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "推奨解像度：1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "スクリーンショットを10件まで設定できます";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "保存していない変更は破棄されます。よろしいですか？";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "バッジの詳細";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "バッジ名";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "ゲームの詳細";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "ゲームアイコン";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "ゲーム名";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "ゲームのサムネイル";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "翻訳を管理";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "コンテンツがありません";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "サムネイル";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "翻訳履歴";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "翻訳の管理";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "保存されていない変更内容";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "詳細";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "ゲーム情報";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "ゲーム商品";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "ゲーム文字列";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "アイコン";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "翻訳済み画像";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "名前";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "翻訳するテキスト";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "サムネイル";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "このページにアクセスする権限がありません";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "保存できませんでした。コンテンツが規制対象になっていないかチェックしてからやり直してください。";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "エラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "保存できませんでした。ファイルの大きさと形式が正しいか確認してください。";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "翻訳済みのコンテンツがありません。ゲームコンテンツを翻訳するには翻訳の環境設定で翻訳言語を追加してください。";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "保存できませんでした。もう一度お試しください。";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "ファイルが多すぎます。ファイルの数を10件以下にしてアップロードしてください。";

	public TranslationManagementResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "再読み込みしてください。";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "許容可能なファイル: jpg, jpeg, png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "許容可能なファイル: jpg, jpeg, png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber} 文字";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber} 文字";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "翻訳の入力はこちら";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "画像は、モデレータによるレビュー後、他のユーザーに公開されます";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "画像が利用できません。";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "最大ファイルサイズ: 4 MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "最大ファイルサイズ: 4 MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "このゲームのゲーム製品が見つかりませんでした";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "推奨解像度: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "推奨解像度: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "推奨解像度：1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "スクリーンショットを10件まで設定できます";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "保存していない変更は破棄されます。よろしいですか？";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "バッジの詳細";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "バッジ名";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "ゲームの詳細";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "ゲームアイコン";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "ゲーム名";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "ゲームのサムネイル";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "翻訳を管理";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "コンテンツがありません";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "サムネイル";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "翻訳履歴";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "翻訳の管理";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "保存されていない変更内容";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "詳細";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "ゲーム情報";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "ゲーム商品";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "ゲーム文字列";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "アイコン";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "翻訳済み画像";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "名前";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "翻訳するテキスト";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "サムネイル";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "このページにアクセスする権限がありません";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "保存できませんでした。コンテンツが規制対象になっていないかチェックしてからやり直してください。";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "エラーが発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "保存できませんでした。ファイルの大きさと形式が正しいか確認してください。";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "翻訳済みのコンテンツがありません。ゲームコンテンツを翻訳するには翻訳の環境設定で翻訳言語を追加してください。";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "保存できませんでした。もう一度お試しください。";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "ファイルが多すぎます。ファイルの数を10件以下にしてアップロードしてください。";
	}
}
