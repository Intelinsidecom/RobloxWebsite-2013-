namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CrowdSourcedTranslationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CrowdSourcedTranslationResources_ko_kr : CrowdSourcedTranslationResources_en_us, ICrowdSourcedTranslationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public override string ActionAddTranslationEntry => "새 엔트리 추가";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "삭제";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "변경 사항 삭제";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "CSV 다운로드";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "더 불러오기";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "저장";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "저장 완료";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "저장하는 중";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "본 게임의 소스 콘텐츠를 찾을 수 없습니다. 자동 추출 기능을 활성화하거나 혹은 번역을 읽고 관리하기 위해 Developer Studio에서 직접 콘텐츠를 업로드할 수 있습니다.";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "이 게임의 소스 콘텐츠를 찾을 수 없습니다. 오류라고 생각되면 개발자에게 연락해 보세요.";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "현 검색 필터에 대한 검색 결과 없음";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "저장하지 않은 변경 사항이 있어요. 계속하시겠어요?";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "여기에 번역 입력";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "번역 엔트리 추가";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "저장하지 않은 변경 사항";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "번역 관리";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "이 엔트리를 정말로 삭제할까요?";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "콘텐츠 없음";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "번역 내역";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "이 작업은 되돌릴 수 없으니 주의하세요.";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "완성된 번역:";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "컨텍스트:";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "삭제 중";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "예:";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "다음 번역이 삭제됩니다.";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "키:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "마지막 수정:";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "게임 내 위치";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "또 다른 정보";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "필수";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "검색...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "정렬 기준";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "알파벳 순";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "미번역 우선";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "소스 텍스트:";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "번역할 텍스트:";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "번역됨";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "번역이 삭제됨";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "번역자:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "번역 안 됨";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "본 페이지에 대한 접근 권한이 없습니다";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "사용할 수 있는 컨텍스트가 없어요";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "사용할 수 있는 예제가 없어요";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "자동 스크랩한 위치가 없어요.";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "사용할 수 있는 키가 없어요";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "번역 기록이 없어요.";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "엔트리를 삭제하는 데 문제가 발생했습니다.";

	public CrowdSourcedTranslationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "새 엔트리 추가";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "삭제";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "변경 사항 삭제";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "CSV 다운로드";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "더 불러오기";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "저장";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "저장 완료";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "저장하는 중";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "본 게임의 소스 콘텐츠를 찾을 수 없습니다. 자동 추출 기능을 활성화하거나 혹은 번역을 읽고 관리하기 위해 Developer Studio에서 직접 콘텐츠를 업로드할 수 있습니다.";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "이 게임의 소스 콘텐츠를 찾을 수 없습니다. 오류라고 생각되면 개발자에게 연락해 보세요.";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "현 검색 필터에 대한 검색 결과 없음";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "저장하지 않은 변경 사항이 있어요. 계속하시겠어요?";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "여기에 번역 입력";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "번역 엔트리 추가";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "저장하지 않은 변경 사항";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "번역 관리";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "이 엔트리를 정말로 삭제할까요?";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "콘텐츠 없음";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "번역 내역";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "이 작업은 되돌릴 수 없으니 주의하세요.";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "완성된 번역:";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "컨텍스트:";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "삭제 중";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "예:";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "다음 번역이 삭제됩니다.";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "키:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "마지막 수정:";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "게임 내 위치";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "또 다른 정보";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"{remainingCharacters}자";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "{remainingCharacters}자";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "필수";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "검색...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "정렬 기준";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "알파벳 순";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "미번역 우선";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "소스 텍스트:";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "번역할 텍스트:";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "번역됨";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "번역이 삭제됨";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "번역자:";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "번역 안 됨";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "본 페이지에 대한 접근 권한이 없습니다";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "사용할 수 있는 컨텍스트가 없어요";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "사용할 수 있는 예제가 없어요";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "자동 스크랩한 위치가 없어요.";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "사용할 수 있는 키가 없어요";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "번역 기록이 없어요.";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "엔트리를 삭제하는 데 문제가 발생했습니다.";
	}
}
