namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CrowdSourcedTranslationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CrowdSourcedTranslationResources_zh_tw : CrowdSourcedTranslationResources_en_us, ICrowdSourcedTranslationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public override string ActionAddTranslationEntry => "新增條目";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "刪除";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "捨棄變更";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "下載 CSV 檔案";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "載入更多";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "儲存";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "已儲存";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "正在儲存";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "找不到此遊戲的源內容。您可以啟動自動抓取，或從 Developer Studio 上傳內容並在此檢視與管理翻譯。";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "找不到此遊戲的源內容。若有錯誤，請聯絡開發人員。";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "目前搜索條件沒有結果";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "您有未儲存的變更。確定繼續？";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "在此輸入翻譯";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "新增翻譯條目";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "未儲存的變更";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "管理翻譯";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "確定刪除此條目？";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "沒有內容";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "翻譯紀錄";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "此動作將無法復原。";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "已完成翻譯：";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "語境：";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "正在刪除";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "範例：";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "以下翻譯將會被刪除。";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "字串：";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "最後修改：";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "遊戲中地點";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "更多資訊";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "必填";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "搜尋…";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "排序";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "依字母排序";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "未翻譯優先";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "源文字：";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "待翻譯文字：";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "已翻譯";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "已清除翻譯";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "譯者：";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "未翻譯";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "您沒有權限檢視此頁面";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "沒有語境";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "沒有範例";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "沒有自動抓取的遊戲地點。";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "沒有字串";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "沒有翻譯紀錄。";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "刪除條目時發生錯誤。";

	public CrowdSourcedTranslationResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "新增條目";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "刪除";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "捨棄變更";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "下載 CSV 檔案";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "載入更多";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "儲存";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "已儲存";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "正在儲存";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "找不到此遊戲的源內容。您可以啟動自動抓取，或從 Developer Studio 上傳內容並在此檢視與管理翻譯。";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "找不到此遊戲的源內容。若有錯誤，請聯絡開發人員。";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "目前搜索條件沒有結果";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "您有未儲存的變更。確定繼續？";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "在此輸入翻譯";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "新增翻譯條目";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "未儲存的變更";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "管理翻譯";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "確定刪除此條目？";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "沒有內容";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "翻譯紀錄";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "此動作將無法復原。";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "已完成翻譯：";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "語境：";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "正在刪除";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "範例：";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "以下翻譯將會被刪除。";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "字串：";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "最後修改：";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "遊戲中地點";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "更多資訊";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"剩下 {remainingCharacters} 個字元";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "剩下 {remainingCharacters} 個字元";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "必填";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "搜尋…";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "排序";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "依字母排序";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "未翻譯優先";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "源文字：";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "待翻譯文字：";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "已翻譯";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "已清除翻譯";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "譯者：";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "未翻譯";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "您沒有權限檢視此頁面";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "沒有語境";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "沒有範例";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "沒有自動抓取的遊戲地點。";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "沒有字串";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "沒有翻譯紀錄。";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "刪除條目時發生錯誤。";
	}
}
