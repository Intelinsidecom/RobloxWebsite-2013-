namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CrowdSourcedTranslationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CrowdSourcedTranslationResources_zh_cn : CrowdSourcedTranslationResources_en_us, ICrowdSourcedTranslationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public override string ActionAddTranslationEntry => "æ·»åŠ æ–°æ¡ç›®";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "åˆ é™¤";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "æ”¾å¼ƒæ›´æ”¹";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "ä¸‹è½½ CSV";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "åŠ è½½æ›´å¤š";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ä¿å­˜";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "å·²ä¿å­˜";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "æ­£åœ¨ä¿å­˜";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "æœªæ‰¾åˆ°æ­¤æ¸¸æˆçš„æºå†…å®¹ã€‚ä½ å¯ä»¥å¯ç”¨è‡ªåŠ¨æŠ“å–ï¼Œæˆ–ä»Ž Developer Studio æ‰‹åŠ¨ä¸Šä¼ å†…å®¹ï¼Œå¹¶åœ¨æ­¤å¤„æŸ¥çœ‹ä¸Žç®¡ç†ç¿»è¯‘ã€‚";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "æ‰¾ä¸åˆ°æ­¤æ¸¸æˆçš„åŽŸå†…å®¹ã€‚å¦‚æžœä½ è®¤ä¸ºè¿™æ˜¯ä¸ªé”™è¯¯ï¼Œè¯·è”ç³»å¼€å‘è€…ã€‚";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "æœªæ‰¾åˆ°åŸºäºŽç›®å‰æœç´¢æˆ–ç­›é€‰çš„ç»“æžœ";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "ä½ æœ‰æœªä¿å­˜çš„æ›´æ”¹ã€‚æ˜¯å¦ç»§ç»­ï¼Ÿ";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "åœ¨æ­¤å¤„è¾“å…¥ç¿»è¯‘";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "æ·»åŠ ç¿»è¯‘æ¡ç›®";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "æœªä¿å­˜çš„æ›´æ”¹";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "ç®¡ç†ç¿»è¯‘";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "æ˜¯å¦ç¡®å®šè¦åˆ é™¤æ­¤æ¡ç›®ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "æ— å†…å®¹";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "ç¿»è¯‘åŽ†å²è®°å½•";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "è¯·æ³¨æ„ï¼Œæ­¤åŠ¨ä½œä¸å¯æ’¤å›žã€‚";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "å·²å®Œæˆçš„ç¿»è¯‘ï¼š";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "è¯­å¢ƒï¼š";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "æ­£åœ¨åˆ é™¤";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "ç¤ºä¾‹ï¼š";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "ä¸‹åˆ—ç¿»è¯‘å†…å®¹å°†è¢«åˆ é™¤ã€‚";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "å­—ç¬¦ä¸²ï¼š";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "ä¸Šæ¬¡ä¿®æ”¹æ—¶é—´ï¼š";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "æ¸¸æˆä¸­ä½ç½®";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "æ›´å¤šä¿¡æ¯";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "å¿…å¡«";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "æœç´¢...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "æŽ’åºä¾æ®";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "æŒ‰å­—æ¯é¡ºåº";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "æœªç¿»è¯‘å†…å®¹ä¼˜å…ˆ";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "æºæ–‡æœ¬ï¼š";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "å¾…ç¿»è¯‘æ–‡æœ¬ï¼š";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "å·²ç¿»è¯‘";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "ç¿»è¯‘å†…å®¹å·²æ¸…é™¤";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "è¯‘è€…ï¼š";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "æœªç¿»è¯‘";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "ä½ æ²¡æœ‰è®¿é—®æ­¤é¡µé¢çš„æƒé™";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "æ— è¯­å¢ƒ";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "æ— ç¤ºä¾‹";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "æ²¡æœ‰è‡ªåŠ¨æŠ“å–çš„æ¸¸æˆåœ°ç‚¹ã€‚";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "æ— å­—ç¬¦ä¸²";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "æ— ç¿»è¯‘åŽ†å²è®°å½•ã€‚";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "åˆ é™¤æ¡ç›®æ—¶å‡ºçŽ°é—®é¢˜ã€‚";

	public CrowdSourcedTranslationResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "æ·»åŠ æ–°æ¡ç›®";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "åˆ é™¤";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "æ”¾å¼ƒæ›´æ”¹";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "ä¸‹è½½ CSV";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "åŠ è½½æ›´å¤š";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ä¿å­˜";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "å·²ä¿å­˜";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "æ­£åœ¨ä¿å­˜";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "æœªæ‰¾åˆ°æ­¤æ¸¸æˆçš„æºå†…å®¹ã€‚ä½ å¯ä»¥å¯ç”¨è‡ªåŠ¨æŠ“å–ï¼Œæˆ–ä»Ž Developer Studio æ‰‹åŠ¨ä¸Šä¼ å†…å®¹ï¼Œå¹¶åœ¨æ­¤å¤„æŸ¥çœ‹ä¸Žç®¡ç†ç¿»è¯‘ã€‚";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "æ‰¾ä¸åˆ°æ­¤æ¸¸æˆçš„åŽŸå†…å®¹ã€‚å¦‚æžœä½ è®¤ä¸ºè¿™æ˜¯ä¸ªé”™è¯¯ï¼Œè¯·è”ç³»å¼€å‘è€…ã€‚";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "æœªæ‰¾åˆ°åŸºäºŽç›®å‰æœç´¢æˆ–ç­›é€‰çš„ç»“æžœ";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "ä½ æœ‰æœªä¿å­˜çš„æ›´æ”¹ã€‚æ˜¯å¦ç»§ç»­ï¼Ÿ";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "åœ¨æ­¤å¤„è¾“å…¥ç¿»è¯‘";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "æ·»åŠ ç¿»è¯‘æ¡ç›®";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "æœªä¿å­˜çš„æ›´æ”¹";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "ç®¡ç†ç¿»è¯‘";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "æ˜¯å¦ç¡®å®šè¦åˆ é™¤æ­¤æ¡ç›®ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "æ— å†…å®¹";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "ç¿»è¯‘åŽ†å²è®°å½•";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "è¯·æ³¨æ„ï¼Œæ­¤åŠ¨ä½œä¸å¯æ’¤å›žã€‚";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "å·²å®Œæˆçš„ç¿»è¯‘ï¼š";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "è¯­å¢ƒï¼š";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "æ­£åœ¨åˆ é™¤";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "ç¤ºä¾‹ï¼š";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "ä¸‹åˆ—ç¿»è¯‘å†…å®¹å°†è¢«åˆ é™¤ã€‚";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "å­—ç¬¦ä¸²ï¼š";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "ä¸Šæ¬¡ä¿®æ”¹æ—¶é—´ï¼š";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "æ¸¸æˆä¸­ä½ç½®";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "æ›´å¤šä¿¡æ¯";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"å‰©ä½™ {remainingCharacters} ä¸ªå­—ç¬¦";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "å‰©ä½™ {remainingCharacters} ä¸ªå­—ç¬¦";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "å¿…å¡«";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "æœç´¢...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "æŽ’åºä¾æ®";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "æŒ‰å­—æ¯é¡ºåº";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "æœªç¿»è¯‘å†…å®¹ä¼˜å…ˆ";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "æºæ–‡æœ¬ï¼š";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "å¾…ç¿»è¯‘æ–‡æœ¬ï¼š";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "å·²ç¿»è¯‘";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "ç¿»è¯‘å†…å®¹å·²æ¸…é™¤";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "è¯‘è€…ï¼š";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "æœªç¿»è¯‘";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "ä½ æ²¡æœ‰è®¿é—®æ­¤é¡µé¢çš„æƒé™";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "æ— è¯­å¢ƒ";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "æ— ç¤ºä¾‹";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "æ²¡æœ‰è‡ªåŠ¨æŠ“å–çš„æ¸¸æˆåœ°ç‚¹ã€‚";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "æ— å­—ç¬¦ä¸²";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "æ— ç¿»è¯‘åŽ†å²è®°å½•ã€‚";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "åˆ é™¤æ¡ç›®æ—¶å‡ºçŽ°é—®é¢˜ã€‚";
	}
}


}
