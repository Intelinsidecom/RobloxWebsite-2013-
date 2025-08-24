namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_ko_kr : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "기본값 변경";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "어떤 언어를 기본 언어로 설정할까요?";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "삭제";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "게임 제목 및 설명을 사용자의 언어로 볼 수 있도록 기본 언어 및 사용 언어를 설정할 수 있어요.";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "빠진 번역을 추가해주세요";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "모든 로컬리제이션 정보가 삭제됩니다.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "저장되지 않은 변경 사항이 있습니다. 정말 페이지를 나가시겠습니까?";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* 번역된 앱 정보를 해당 App Store 지역에서 사용할 수 없는 경우, 설정하신 기본 언어가 대신 사용됩니다.";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "다른 언어로 번역 추가";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "기본 언어로 변경할까요?";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "추가";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "다른 언어 추가";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "취소";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public override string LabelChange => "변경";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "언어 변경 / 추가";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "번역을 확인/수정할 언어 선택: ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "현재 언어";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "기본값";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "삭제";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "언어";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public override string LabelNotSpecified => "지정되지 않음";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "다른 언어 검색";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "기본 언어 설정";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "소스";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "언어에 대한 게임 정보 보기";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "오류: 오류가 발생했어요. 나중에 다시 시도하세요.";

	public TranslationLanguageSwitchResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "기본값 변경";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "어떤 언어를 기본 언어로 설정할까요?";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "삭제";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "게임 제목 및 설명을 사용자의 언어로 볼 수 있도록 기본 언어 및 사용 언어를 설정할 수 있어요.";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "빠진 번역을 추가해주세요";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "모든 로컬리제이션 정보가 삭제됩니다.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "저장되지 않은 변경 사항이 있습니다. 정말 페이지를 나가시겠습니까?";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* 번역된 앱 정보를 해당 App Store 지역에서 사용할 수 없는 경우, 설정하신 기본 언어가 대신 사용됩니다.";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "다른 언어로 번역 추가";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "기본 언어로 변경할까요?";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"{languageName} 로컬리제이션을 삭제할까요?";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "{languageName} 로컬리제이션을 삭제할까요?";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "추가";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "다른 언어 추가";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "변경";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "언어 변경 / 추가";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "번역을 확인/수정할 언어 선택: ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "현재 언어";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "기본값";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "삭제";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "언어";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "지정되지 않음";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "다른 언어 검색";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "기본 언어 설정";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "소스";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"소스 ({languageName})";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "소스 ({languageName})";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "언어에 대한 게임 정보 보기";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "오류: 오류가 발생했어요. 나중에 다시 시도하세요.";
	}
}
