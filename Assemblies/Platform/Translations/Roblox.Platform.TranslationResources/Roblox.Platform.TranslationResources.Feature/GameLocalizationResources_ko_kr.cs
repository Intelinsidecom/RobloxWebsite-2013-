namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_ko_kr : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "삭제";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "확인";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "저장";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "오류: 저장 실패. 콘텐츠에 문제의 소지가 있는지 확인하고 다시 시도하세요.";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "오류: 저장 실패.";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "번역이 없으면 사용자는 소스 언어 값을 보게 됩니다.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "저장되지 않은 변경 사항이 있어요. 언어를 전환하시겠습니까?";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "이름 및 설명이 저장되었습니다.";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "소스 언어 값이 참조로 표시됩니다. 여기에서만 볼 수 있어요.";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "값 지우기";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "로컬리제이션 구성";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "게임 이름 및 설명 번역";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "저장하지 않은 변경 사항";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "설명:";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "여기에 게임 설명 입력";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "게임 정보";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "게임 이름 및 설명 번역";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "여기에 게임 이름을 입력하세요(필수)";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "여기에 게임 이름 입력";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "로컬리제이션";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "이름: ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "지원 언어";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "게임 정보";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "언어";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "신고";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "설정";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "번역자";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "제목";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "오류: 저장 실패. 콘텐츠에 문제의 소지가 있는지 확인하고 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "오류: 오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "오류: 저장 실패.";

	public GameLocalizationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "삭제";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "저장";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"{languageName}의 번역을 지우시겠습니까? 사용자들은 게임의 소스 언어로 이름과 설명을 보게 됩니다.";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "{languageName}의 번역을 지우시겠습니까? 사용자들은 게임의 소스 언어로 이름과 설명을 보게 됩니다.";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "오류: 저장 실패. 콘텐츠에 문제의 소지가 있는지 확인하고 다시 시도하세요.";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "오류: 저장 실패.";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "번역이 없으면 사용자는 소스 언어 값을 보게 됩니다.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "저장되지 않은 변경 사항이 있어요. 언어를 전환하시겠습니까?";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "이름 및 설명이 저장되었습니다.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "소스 언어 값이 참조로 표시됩니다. 여기에서만 볼 수 있어요.";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "값 지우기";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "로컬리제이션 구성";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "게임 이름 및 설명 번역";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "저장하지 않은 변경 사항";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "설명:";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "여기에 게임 설명 입력";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "게임 정보";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "게임 이름 및 설명 번역";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "여기에 게임 이름을 입력하세요(필수)";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "여기에 게임 이름 입력";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "로컬리제이션";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "이름: ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "지원 언어";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "게임 정보";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "언어";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "신고";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "설정";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "번역자";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "제목";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "오류: 저장 실패. 콘텐츠에 문제의 소지가 있는지 확인하고 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "오류: 오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "오류: 저장 실패.";
	}
}
