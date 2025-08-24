namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SupportedLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SupportedLanguagesResources_ko_kr : SupportedLanguagesResources_en_us, ISupportedLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Clear"
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "삭제";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public override string DescriptionAutomaticTextCapture => "사용자 플레이 중 게임 텍스트 자동 캡쳐";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public override string DescriptionClearTableWarning => "자동으로 캡처되고 번역되지 않은 모든 입력 내용이 테이블에서 삭제됩니다. 참고: 해당하는 모든 텍스트는 자동으로 다시 캡처됩니다.";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public override string DescriptionUseTranslatedContent => "게임 내 콘텐츠 번역 활성화";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public override string HeadingAreYouSureToClear => "정말로 엔트리를 삭제할까요?";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public override string HeadingInGameContentTranslations => "게임 내 콘텐츠 번역";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public override string LabelAutomaticTextCapture => "자동 텍스트 캡처: ";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public override string LabelClearTableEntries => "번역되지 않은 자동 캡처 스트링 삭제";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public override string LabelCrowdsourceEnabled => "크라우드소스 활성화됨";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public override string LabelEnableAutoUITextCapture => "자동 UI 텍스트 캡처 활성화";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public override string LabelInProgress => "진행 중";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "언어";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "언어";

	public override string LabelNotSpecified => "<지정되지 않음>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public override string LabelNotSupported => "지원되지 않음";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public override string LabelShowMoreLanguages => "더 많은 언어 표시...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "소스 언어";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public override string LabelSupported => "지원됨";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public override string LabelSupportedBeta => "지원됨 (베타)";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public override string LabelSupportedStatus => "지원 상태";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public override string LabelUseTranslatedContent => "번역 콘텐츠 사용: ";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public override string MessageClearTableSuccess => "확인. 이 작업을 수행하는 데 몇 분 정도 소요될 수 있습니다.";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public override string MessageUpdateFail => "오류가 발생했어요. 나중에 다시 시도하세요!";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public override string MessageUpdateSuccess => "변경 내용이 성공적으로 저장되었습니다";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public override string MessageUpdating => "업데이트 중...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public override string MessageWaitAndTryAgain => "시도 횟수가 너무 많습니다. 잠시 후에 다시 삭제를 시도하세요.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "오류: 오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public override string ResponseSaveConfiguration => "오류: 설정을 변경할 수 없어요. 나중에 다시 시도하세요.";

	public SupportedLanguagesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClear()
	{
		return "삭제";
	}

	protected override string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "사용자 플레이 중 게임 텍스트 자동 캡쳐";
	}

	protected override string _GetTemplateForDescriptionClearTableWarning()
	{
		return "자동으로 캡처되고 번역되지 않은 모든 입력 내용이 테이블에서 삭제됩니다. 참고: 해당하는 모든 텍스트는 자동으로 다시 캡처됩니다.";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public override string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"켜기: 크라우드소싱이 활성화(변역사가 게임 문자열을 보고 번역할 수 있음){lineBreak}끄기: 크라우드소싱이 비활성화(번역사가 게임 문자열을 보거나 번역할 수 없음)";
	}

	protected override string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "켜기: 크라우드소싱이 활성화(변역사가 게임 문자열을 보고 번역할 수 있음){lineBreak}끄기: 크라우드소싱이 비활성화(번역사가 게임 문자열을 보거나 번역할 수 없음)";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public override string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"녹색 막대: 승인된 문자열의 백분율{lineBreak}파란색 막대: 번역된 문자열의 백분율";
	}

	protected override string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "녹색 막대: 승인된 문자열의 백분율{lineBreak}파란색 막대: 번역된 문자열의 백분율";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public override string DescriptionSupportedStatus(string lineBreak)
	{
		return $"지원 상태는 해당 언어가 게임 설명 페이지에 표시되는지 여부를 보여줍니다.{lineBreak}지원됨 - 표시됨{lineBreak}진행 중 - 베타로 표시됨{lineBreak}지원되지 않음 - 표시되지 않음";
	}

	protected override string _GetTemplateForDescriptionSupportedStatus()
	{
		return "지원 상태는 해당 언어가 게임 설명 페이지에 표시되는지 여부를 보여줍니다.{lineBreak}지원됨 - 표시됨{lineBreak}진행 중 - 베타로 표시됨{lineBreak}지원되지 않음 - 표시되지 않음";
	}

	protected override string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "게임 내 콘텐츠 번역 활성화";
	}

	protected override string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "정말로 엔트리를 삭제할까요?";
	}

	protected override string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "게임 내 콘텐츠 번역";
	}

	protected override string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "자동 텍스트 캡처: ";
	}

	protected override string _GetTemplateForLabelClearTableEntries()
	{
		return "번역되지 않은 자동 캡처 스트링 삭제";
	}

	protected override string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "크라우드소스 활성화됨";
	}

	protected override string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "자동 UI 텍스트 캡처 활성화";
	}

	protected override string _GetTemplateForLabelInProgress()
	{
		return "진행 중";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "언어";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "언어";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public override string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"로컬리제이션 상태{lineBreak}({stringCount}개 문자열)";
	}

	protected override string _GetTemplateForLabelLocalizationStatus()
	{
		return "로컬리제이션 상태{lineBreak}({stringCount}개 문자열)";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "<지정되지 않음>";
	}

	protected override string _GetTemplateForLabelNotSupported()
	{
		return "지원되지 않음";
	}

	protected override string _GetTemplateForLabelShowMoreLanguages()
	{
		return "더 많은 언어 표시...";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "소스 언어";
	}

	protected override string _GetTemplateForLabelSupported()
	{
		return "지원됨";
	}

	protected override string _GetTemplateForLabelSupportedBeta()
	{
		return "지원됨 (베타)";
	}

	protected override string _GetTemplateForLabelSupportedStatus()
	{
		return "지원 상태";
	}

	protected override string _GetTemplateForLabelUseTranslatedContent()
	{
		return "번역 콘텐츠 사용: ";
	}

	protected override string _GetTemplateForMessageClearTableSuccess()
	{
		return "확인. 이 작업을 수행하는 데 몇 분 정도 소요될 수 있습니다.";
	}

	protected override string _GetTemplateForMessageUpdateFail()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요!";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "변경 내용이 성공적으로 저장되었습니다";
	}

	protected override string _GetTemplateForMessageUpdating()
	{
		return "업데이트 중...";
	}

	protected override string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "시도 횟수가 너무 많습니다. 잠시 후에 다시 삭제를 시도하세요.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "오류: 오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseSaveConfiguration()
	{
		return "오류: 설정을 변경할 수 없어요. 나중에 다시 시도하세요.";
	}
}
