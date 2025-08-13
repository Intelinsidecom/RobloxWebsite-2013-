namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CrowdSourcedTranslationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CrowdSourcedTranslationResources_zh_cjv : CrowdSourcedTranslationResources_en_us, ICrowdSourcedTranslationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public override string ActionAddTranslationEntry => "添加新条目";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "删除";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "放弃更改";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "下载 CSV";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "加载更多";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "已保存";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "正在保存";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "未找到此游戏的源内容。你可以启用自动抓取，或从 Developer Studio 手动上传内容，并在此处查看与管理翻译。";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "找不到此游戏的原内容。如果你认为这是个错误，请联系开发者。";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "未找到基于目前搜索或筛选的结果";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "你有未保存的更改。是否继续？";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "在此处输入翻译";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "添加翻译条目";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "未保存的更改";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "管理翻译";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "是否确定要删除此条目？";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "无内容";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "翻译历史记录";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "请注意，此动作不可撤回。";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "已完成的翻译：";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "语境：";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "正在删除";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "示例：";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "下列翻译内容将被删除。";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "字符串：";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "上次修改时间：";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "游戏中位置";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "更多信息";

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
	public override string LabelSearchPlaceholder => "搜索...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "排序依据";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "按字母顺序";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "未翻译内容优先";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "源文本：";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "待翻译文本：";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "已翻译";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "翻译内容已清除";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "译者：";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "未翻译";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "你没有访问此页面的权限";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "无语境";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "无示例";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "没有自动抓取的游戏地点。";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "无字符串";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "无翻译历史记录。";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "删除条目时出现问题。";

	public CrowdSourcedTranslationResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "添加新条目";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "删除";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "放弃更改";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "下载 CSV";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "加载更多";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "已保存";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "正在保存";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "未找到此游戏的源内容。你可以启用自动抓取，或从 Developer Studio 手动上传内容，并在此处查看与管理翻译。";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "找不到此游戏的原内容。如果你认为这是个错误，请联系开发者。";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "未找到基于目前搜索或筛选的结果";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "你有未保存的更改。是否继续？";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "在此处输入翻译";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "添加翻译条目";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "未保存的更改";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "管理翻译";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "是否确定要删除此条目？";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "无内容";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "翻译历史记录";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "请注意，此动作不可撤回。";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "已完成的翻译：";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "语境：";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "正在删除";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "示例：";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "下列翻译内容将被删除。";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "字符串：";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "上次修改时间：";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "游戏中位置";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "更多信息";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"剩余 {remainingCharacters} 个字符";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "剩余 {remainingCharacters} 个字符";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "必填";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "搜索...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "排序依据";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "按字母顺序";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "未翻译内容优先";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "源文本：";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "待翻译文本：";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "已翻译";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "翻译内容已清除";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "译者：";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "未翻译";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "你没有访问此页面的权限";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "无语境";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "无示例";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "没有自动抓取的游戏地点。";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "无字符串";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "无翻译历史记录。";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "删除条目时出现问题。";
	}
}
