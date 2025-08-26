namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAddTranslationEntry => "æ–°å¢žæ¢ç›®";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "åˆªé™¤";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "æ¨æ£„è®Šæ›´";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "ä¸‹è¼‰ CSV æª”æ¡ˆ";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "è¼‰å…¥æ›´å¤š";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "å„²å­˜";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "å·²å„²å­˜";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "æ­£åœ¨å„²å­˜";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "æ‰¾ä¸åˆ°æ­¤éŠæˆ²çš„æºå…§å®¹ã€‚æ‚¨å¯ä»¥å•Ÿå‹•è‡ªå‹•æŠ“å–ï¼Œæˆ–å¾ž Developer Studio ä¸Šå‚³å…§å®¹ä¸¦åœ¨æ­¤æª¢è¦–èˆ‡ç®¡ç†ç¿»è­¯ã€‚";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "æ‰¾ä¸åˆ°æ­¤éŠæˆ²çš„æºå…§å®¹ã€‚è‹¥æœ‰éŒ¯èª¤ï¼Œè«‹è¯çµ¡é–‹ç™¼äººå“¡ã€‚";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "ç›®å‰æœç´¢æ¢ä»¶æ²’æœ‰çµæžœ";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "æ‚¨æœ‰æœªå„²å­˜çš„è®Šæ›´ã€‚ç¢ºå®šç¹¼çºŒï¼Ÿ";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "åœ¨æ­¤è¼¸å…¥ç¿»è­¯";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "æ–°å¢žç¿»è­¯æ¢ç›®";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "æœªå„²å­˜çš„è®Šæ›´";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "ç®¡ç†ç¿»è­¯";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "ç¢ºå®šåˆªé™¤æ­¤æ¢ç›®ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "æ²’æœ‰å…§å®¹";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "ç¿»è­¯ç´€éŒ„";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "æ­¤å‹•ä½œå°‡ç„¡æ³•å¾©åŽŸã€‚";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "å·²å®Œæˆç¿»è­¯ï¼š";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "èªžå¢ƒï¼š";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "æ­£åœ¨åˆªé™¤";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "ç¯„ä¾‹ï¼š";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "ä»¥ä¸‹ç¿»è­¯å°‡æœƒè¢«åˆªé™¤ã€‚";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "å­—ä¸²ï¼š";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "æœ€å¾Œä¿®æ”¹ï¼š";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "éŠæˆ²ä¸­åœ°é»ž";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "æ›´å¤šè³‡è¨Š";

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
	public override string LabelSearchPlaceholder => "æœå°‹â€¦";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "æŽ’åº";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "ä¾å­—æ¯æŽ’åº";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "æœªç¿»è­¯å„ªå…ˆ";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "æºæ–‡å­—ï¼š";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "å¾…ç¿»è­¯æ–‡å­—ï¼š";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "å·²ç¿»è­¯";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "å·²æ¸…é™¤ç¿»è­¯";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "è­¯è€…ï¼š";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "æœªç¿»è­¯";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "æ‚¨æ²’æœ‰æ¬Šé™æª¢è¦–æ­¤é é¢";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "æ²’æœ‰èªžå¢ƒ";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "æ²’æœ‰ç¯„ä¾‹";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "æ²’æœ‰è‡ªå‹•æŠ“å–çš„éŠæˆ²åœ°é»žã€‚";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "æ²’æœ‰å­—ä¸²";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "æ²’æœ‰ç¿»è­¯ç´€éŒ„ã€‚";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "åˆªé™¤æ¢ç›®æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";

	public CrowdSourcedTranslationResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "æ–°å¢žæ¢ç›®";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "åˆªé™¤";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "æ¨æ£„è®Šæ›´";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "ä¸‹è¼‰ CSV æª”æ¡ˆ";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "è¼‰å…¥æ›´å¤š";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "å„²å­˜";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "å·²å„²å­˜";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "æ­£åœ¨å„²å­˜";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "æ‰¾ä¸åˆ°æ­¤éŠæˆ²çš„æºå…§å®¹ã€‚æ‚¨å¯ä»¥å•Ÿå‹•è‡ªå‹•æŠ“å–ï¼Œæˆ–å¾ž Developer Studio ä¸Šå‚³å…§å®¹ä¸¦åœ¨æ­¤æª¢è¦–èˆ‡ç®¡ç†ç¿»è­¯ã€‚";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "æ‰¾ä¸åˆ°æ­¤éŠæˆ²çš„æºå…§å®¹ã€‚è‹¥æœ‰éŒ¯èª¤ï¼Œè«‹è¯çµ¡é–‹ç™¼äººå“¡ã€‚";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "ç›®å‰æœç´¢æ¢ä»¶æ²’æœ‰çµæžœ";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "æ‚¨æœ‰æœªå„²å­˜çš„è®Šæ›´ã€‚ç¢ºå®šç¹¼çºŒï¼Ÿ";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "åœ¨æ­¤è¼¸å…¥ç¿»è­¯";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "æ–°å¢žç¿»è­¯æ¢ç›®";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "æœªå„²å­˜çš„è®Šæ›´";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "ç®¡ç†ç¿»è­¯";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "ç¢ºå®šåˆªé™¤æ­¤æ¢ç›®ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "æ²’æœ‰å…§å®¹";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "ç¿»è­¯ç´€éŒ„";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "æ­¤å‹•ä½œå°‡ç„¡æ³•å¾©åŽŸã€‚";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "å·²å®Œæˆç¿»è­¯ï¼š";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "èªžå¢ƒï¼š";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "æ­£åœ¨åˆªé™¤";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "ç¯„ä¾‹ï¼š";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "ä»¥ä¸‹ç¿»è­¯å°‡æœƒè¢«åˆªé™¤ã€‚";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "å­—ä¸²ï¼š";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "æœ€å¾Œä¿®æ”¹ï¼š";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "éŠæˆ²ä¸­åœ°é»ž";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "æ›´å¤šè³‡è¨Š";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"å‰©ä¸‹ {remainingCharacters} å€‹å­—å…ƒ";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "å‰©ä¸‹ {remainingCharacters} å€‹å­—å…ƒ";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "å¿…å¡«";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "æœå°‹â€¦";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "æŽ’åº";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "ä¾å­—æ¯æŽ’åº";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "æœªç¿»è­¯å„ªå…ˆ";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "æºæ–‡å­—ï¼š";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "å¾…ç¿»è­¯æ–‡å­—ï¼š";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "å·²ç¿»è­¯";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "å·²æ¸…é™¤ç¿»è­¯";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "è­¯è€…ï¼š";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "æœªç¿»è­¯";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "æ‚¨æ²’æœ‰æ¬Šé™æª¢è¦–æ­¤é é¢";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "æ²’æœ‰èªžå¢ƒ";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "æ²’æœ‰ç¯„ä¾‹";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "æ²’æœ‰è‡ªå‹•æŠ“å–çš„éŠæˆ²åœ°é»žã€‚";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "æ²’æœ‰å­—ä¸²";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "æ²’æœ‰ç¿»è­¯ç´€éŒ„ã€‚";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "åˆªé™¤æ¢ç›®æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";
	}
}


}
