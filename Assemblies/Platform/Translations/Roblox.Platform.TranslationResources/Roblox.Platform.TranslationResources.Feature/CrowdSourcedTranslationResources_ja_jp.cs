namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CrowdSourcedTranslationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CrowdSourcedTranslationResources_ja_jp : CrowdSourcedTranslationResources_en_us, ICrowdSourcedTranslationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public override string ActionAddTranslationEntry => "æ–°ã—ã„å…¥åŠ›å†…å®¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "å‰Šé™¤";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "å¤‰æ›´ã‚’ç ´æ£„";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "CSVã‚’ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "ã•ã‚‰ã«èª­ã¿è¾¼ã‚€";

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
	public override string ActionSaved => "ä¿å­˜ã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "ä¿å­˜ä¸­";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ã“ã“ã§ã€è‡ªå‹•å–å¾—ã‚’æœ‰åŠ¹ã«ã—ãŸã‚Šã€Developer Studioã‹ã‚‰ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’æ‰‹å‹•ã§ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã—ã¦ã€ç¿»è¨³ã®ç¢ºèªã‚„ç®¡ç†ã‚’è¡Œã†ã“ã¨ãŒã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒã‚ã‚Šã¾ã›ã‚“ã€‚ã‚¨ãƒ©ãƒ¼ã ã¨æ€ã‚ã‚Œã‚‹å ´åˆã¯ã€é–‹ç™ºè€…ã«ã”é€£çµ¡ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "æœ€è¿‘ã®æ¤œç´¢ãƒ•ã‚£ãƒ«ã‚¿ã«åŸºã¥ã„ãŸå…¥åŠ›ã¯ã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "ä¿å­˜ã•ã‚Œã¦ã„ãªã„å¤‰æ›´å†…å®¹ãŒã‚ã‚Šã¾ã™ã€‚ç¶šã‘ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "ç¿»è¨³ã®å…¥åŠ›ã¯ã“ã¡ã‚‰";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "ç¿»è¨³ã®å…¥åŠ›å†…å®¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "ä¿å­˜ã•ã‚Œã¦ã„ãªã„å¤‰æ›´å†…å®¹";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "ç¿»è¨³ã‚’ç®¡ç†";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "ã“ã®å…¥åŠ›å†…å®¹ã‚’å‰Šé™¤ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ã€‚";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "ç¿»è¨³å±¥æ­´";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "ã“ã®æ“ä½œã‚’ã™ã‚‹ã¨ã€å…ƒã«æˆ»ã›ãªã„ã®ã§ã”æ³¨æ„ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "ç¿»è¨³ãŒçµ‚äº†ã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "æ–‡è„ˆ:";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "å‰Šé™¤ä¸­";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "ä¾‹:";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "ä»¥ä¸‹ã®ç¿»è¨³ã¯å‰Šé™¤ã•ã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "ã‚­ãƒ¼:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "æœ€çµ‚æ›´æ–°:";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "ã‚²ãƒ¼ãƒ å†…ã®å ´æ‰€";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "ã‚‚ã£ã¨è©³ã—ã";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "å¿…é ˆ";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "æ¤œç´¢...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "ä¸¦ã¹æ›¿ãˆ";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "ã‚¢ãƒ«ãƒ•ã‚¡ãƒ™ãƒƒãƒˆé †";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "ç¿»è¨³ã•ã‚Œã¦ã„ãªã„é †";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "ã‚½ãƒ¼ã‚¹ãƒ†ã‚­ã‚¹ãƒˆ:";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "ç¿»è¨³ã™ã‚‹ãƒ†ã‚­ã‚¹ãƒˆï¼š";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "ç¿»è¨³æ¸ˆã¿";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "ç¿»è¨³ã‚’æ¶ˆã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "ç¿»è¨³è€…:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "ç¿»è¨³ã•ã‚Œã¦ã„ã¾ã›ã‚“";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "ã“ã®ãƒšãƒ¼ã‚¸ã«ã‚¢ã‚¯ã‚»ã‚¹ã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "æ–‡è„ˆæƒ…å ±ãŒã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "ä¾‹ãŒã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "è‡ªå‹•æŠ½å‡ºã•ã‚ŒãŸã‚²ãƒ¼ãƒ ä¸Šã®å ´æ‰€ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "ã‚­ãƒ¼ãŒã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "ç¿»è¨³å±¥æ­´ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "å…¥åŠ›å†…å®¹ã®å‰Šé™¤ã§å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	public CrowdSourcedTranslationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "æ–°ã—ã„å…¥åŠ›å†…å®¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "å‰Šé™¤";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "å¤‰æ›´ã‚’ç ´æ£„";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "CSVã‚’ãƒ€ã‚¦ãƒ³ãƒ­ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "ã•ã‚‰ã«èª­ã¿è¾¼ã‚€";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ä¿å­˜";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "ä¿å­˜ã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "ä¿å­˜ä¸­";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ã“ã“ã§ã€è‡ªå‹•å–å¾—ã‚’æœ‰åŠ¹ã«ã—ãŸã‚Šã€Developer Studioã‹ã‚‰ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’æ‰‹å‹•ã§ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã—ã¦ã€ç¿»è¨³ã®ç¢ºèªã‚„ç®¡ç†ã‚’è¡Œã†ã“ã¨ãŒã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒã‚ã‚Šã¾ã›ã‚“ã€‚ã‚¨ãƒ©ãƒ¼ã ã¨æ€ã‚ã‚Œã‚‹å ´åˆã¯ã€é–‹ç™ºè€…ã«ã”é€£çµ¡ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "æœ€è¿‘ã®æ¤œç´¢ãƒ•ã‚£ãƒ«ã‚¿ã«åŸºã¥ã„ãŸå…¥åŠ›ã¯ã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "ä¿å­˜ã•ã‚Œã¦ã„ãªã„å¤‰æ›´å†…å®¹ãŒã‚ã‚Šã¾ã™ã€‚ç¶šã‘ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "ç¿»è¨³ã®å…¥åŠ›ã¯ã“ã¡ã‚‰";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "ç¿»è¨³ã®å…¥åŠ›å†…å®¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "ä¿å­˜ã•ã‚Œã¦ã„ãªã„å¤‰æ›´å†…å®¹";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "ç¿»è¨³ã‚’ç®¡ç†";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "ã“ã®å…¥åŠ›å†…å®¹ã‚’å‰Šé™¤ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ã€‚";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "ç¿»è¨³å±¥æ­´";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "ã“ã®æ“ä½œã‚’ã™ã‚‹ã¨ã€å…ƒã«æˆ»ã›ãªã„ã®ã§ã”æ³¨æ„ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "ç¿»è¨³ãŒçµ‚äº†ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "æ–‡è„ˆ:";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "å‰Šé™¤ä¸­";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "ä¾‹:";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "ä»¥ä¸‹ã®ç¿»è¨³ã¯å‰Šé™¤ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "ã‚­ãƒ¼:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "æœ€çµ‚æ›´æ–°:";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "ã‚²ãƒ¼ãƒ å†…ã®å ´æ‰€";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "ã‚‚ã£ã¨è©³ã—ã";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"{remainingCharacters} æ–‡å­—";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "{remainingCharacters} æ–‡å­—";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "å¿…é ˆ";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "æ¤œç´¢...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "ä¸¦ã¹æ›¿ãˆ";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "ã‚¢ãƒ«ãƒ•ã‚¡ãƒ™ãƒƒãƒˆé †";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "ç¿»è¨³ã•ã‚Œã¦ã„ãªã„é †";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "ã‚½ãƒ¼ã‚¹ãƒ†ã‚­ã‚¹ãƒˆ:";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "ç¿»è¨³ã™ã‚‹ãƒ†ã‚­ã‚¹ãƒˆï¼š";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "ç¿»è¨³æ¸ˆã¿";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "ç¿»è¨³ã‚’æ¶ˆã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "ç¿»è¨³è€…:";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "ç¿»è¨³ã•ã‚Œã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "ã“ã®ãƒšãƒ¼ã‚¸ã«ã‚¢ã‚¯ã‚»ã‚¹ã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "æ–‡è„ˆæƒ…å ±ãŒã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "ä¾‹ãŒã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "è‡ªå‹•æŠ½å‡ºã•ã‚ŒãŸã‚²ãƒ¼ãƒ ä¸Šã®å ´æ‰€ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "ã‚­ãƒ¼ãŒã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "ç¿»è¨³å±¥æ­´ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "å…¥åŠ›å†…å®¹ã®å‰Šé™¤ã§å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}
}


}
