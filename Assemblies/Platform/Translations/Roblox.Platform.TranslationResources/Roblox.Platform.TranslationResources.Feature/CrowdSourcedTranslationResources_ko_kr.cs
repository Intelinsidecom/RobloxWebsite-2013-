namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAddTranslationEntry => "ìƒˆ ì—”íŠ¸ë¦¬ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "ì‚­ì œ";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "ë³€ê²½ ì‚¬í•­ ì‚­ì œ";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "CSV ë‹¤ìš´ë¡œë“œ";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "ë” ë¶ˆëŸ¬ì˜¤ê¸°";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ì €ìž¥";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "ì €ìž¥ ì™„ë£Œ";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "ì €ìž¥í•˜ëŠ” ì¤‘";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "ë³¸ ê²Œìž„ì˜ ì†ŒìŠ¤ ì½˜í…ì¸ ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ìžë™ ì¶”ì¶œ ê¸°ëŠ¥ì„ í™œì„±í™”í•˜ê±°ë‚˜ í˜¹ì€ ë²ˆì—­ì„ ì½ê³  ê´€ë¦¬í•˜ê¸° ìœ„í•´ Developer Studioì—ì„œ ì§ì ‘ ì½˜í…ì¸ ë¥¼ ì—…ë¡œë“œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "ì´ ê²Œìž„ì˜ ì†ŒìŠ¤ ì½˜í…ì¸ ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ì˜¤ë¥˜ë¼ê³  ìƒê°ë˜ë©´ ê°œë°œìžì—ê²Œ ì—°ë½í•´ ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "í˜„ ê²€ìƒ‰ í•„í„°ì— ëŒ€í•œ ê²€ìƒ‰ ê²°ê³¼ ì—†ìŒ";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­ì´ ìžˆì–´ìš”. ê³„ì†í•˜ì‹œê² ì–´ìš”?";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "ì—¬ê¸°ì— ë²ˆì—­ ìž…ë ¥";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "ë²ˆì—­ ì—”íŠ¸ë¦¬ ì¶”ê°€";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "ë²ˆì—­ ê´€ë¦¬";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "ì´ ì—”íŠ¸ë¦¬ë¥¼ ì •ë§ë¡œ ì‚­ì œí• ê¹Œìš”?";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "ì½˜í…ì¸  ì—†ìŒ";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "ë²ˆì—­ ë‚´ì—­";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "ì´ ìž‘ì—…ì€ ë˜ëŒë¦´ ìˆ˜ ì—†ìœ¼ë‹ˆ ì£¼ì˜í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "ì™„ì„±ëœ ë²ˆì—­:";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "ì»¨í…ìŠ¤íŠ¸:";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "ì‚­ì œ ì¤‘";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "ì˜ˆ:";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "ë‹¤ìŒ ë²ˆì—­ì´ ì‚­ì œë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "í‚¤:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "ë§ˆì§€ë§‰ ìˆ˜ì •:";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "ê²Œìž„ ë‚´ ìœ„ì¹˜";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "ë˜ ë‹¤ë¥¸ ì •ë³´";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "í•„ìˆ˜";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "ê²€ìƒ‰...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "ì •ë ¬ ê¸°ì¤€";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "ì•ŒíŒŒë²³ ìˆœ";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "ë¯¸ë²ˆì—­ ìš°ì„ ";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "ì†ŒìŠ¤ í…ìŠ¤íŠ¸:";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "ë²ˆì—­í•  í…ìŠ¤íŠ¸:";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "ë²ˆì—­ë¨";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "ë²ˆì—­ì´ ì‚­ì œë¨";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "ë²ˆì—­ìž:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "ë²ˆì—­ ì•ˆ ë¨";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "ë³¸ íŽ˜ì´ì§€ì— ëŒ€í•œ ì ‘ê·¼ ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "ì‚¬ìš©í•  ìˆ˜ ìžˆëŠ” ì»¨í…ìŠ¤íŠ¸ê°€ ì—†ì–´ìš”";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "ì‚¬ìš©í•  ìˆ˜ ìžˆëŠ” ì˜ˆì œê°€ ì—†ì–´ìš”";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "ìžë™ ìŠ¤í¬ëž©í•œ ìœ„ì¹˜ê°€ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "ì‚¬ìš©í•  ìˆ˜ ìžˆëŠ” í‚¤ê°€ ì—†ì–´ìš”";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "ë²ˆì—­ ê¸°ë¡ì´ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "ì—”íŠ¸ë¦¬ë¥¼ ì‚­ì œí•˜ëŠ” ë° ë¬¸ì œê°€ ë°œìƒí–ˆìŠµë‹ˆë‹¤.";

	public CrowdSourcedTranslationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "ìƒˆ ì—”íŠ¸ë¦¬ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "ë³€ê²½ ì‚¬í•­ ì‚­ì œ";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "CSV ë‹¤ìš´ë¡œë“œ";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "ë” ë¶ˆëŸ¬ì˜¤ê¸°";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "ì €ìž¥ ì™„ë£Œ";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "ì €ìž¥í•˜ëŠ” ì¤‘";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "ë³¸ ê²Œìž„ì˜ ì†ŒìŠ¤ ì½˜í…ì¸ ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ìžë™ ì¶”ì¶œ ê¸°ëŠ¥ì„ í™œì„±í™”í•˜ê±°ë‚˜ í˜¹ì€ ë²ˆì—­ì„ ì½ê³  ê´€ë¦¬í•˜ê¸° ìœ„í•´ Developer Studioì—ì„œ ì§ì ‘ ì½˜í…ì¸ ë¥¼ ì—…ë¡œë“œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "ì´ ê²Œìž„ì˜ ì†ŒìŠ¤ ì½˜í…ì¸ ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ì˜¤ë¥˜ë¼ê³  ìƒê°ë˜ë©´ ê°œë°œìžì—ê²Œ ì—°ë½í•´ ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "í˜„ ê²€ìƒ‰ í•„í„°ì— ëŒ€í•œ ê²€ìƒ‰ ê²°ê³¼ ì—†ìŒ";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­ì´ ìžˆì–´ìš”. ê³„ì†í•˜ì‹œê² ì–´ìš”?";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "ì—¬ê¸°ì— ë²ˆì—­ ìž…ë ¥";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "ë²ˆì—­ ì—”íŠ¸ë¦¬ ì¶”ê°€";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "ì €ìž¥í•˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "ë²ˆì—­ ê´€ë¦¬";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "ì´ ì—”íŠ¸ë¦¬ë¥¼ ì •ë§ë¡œ ì‚­ì œí• ê¹Œìš”?";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "ì½˜í…ì¸  ì—†ìŒ";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "ë²ˆì—­ ë‚´ì—­";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "ì´ ìž‘ì—…ì€ ë˜ëŒë¦´ ìˆ˜ ì—†ìœ¼ë‹ˆ ì£¼ì˜í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "ì™„ì„±ëœ ë²ˆì—­:";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "ì»¨í…ìŠ¤íŠ¸:";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "ì‚­ì œ ì¤‘";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "ì˜ˆ:";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "ë‹¤ìŒ ë²ˆì—­ì´ ì‚­ì œë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "í‚¤:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "ë§ˆì§€ë§‰ ìˆ˜ì •:";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "ê²Œìž„ ë‚´ ìœ„ì¹˜";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "ë˜ ë‹¤ë¥¸ ì •ë³´";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"{remainingCharacters}ìž";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "{remainingCharacters}ìž";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "í•„ìˆ˜";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "ê²€ìƒ‰...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "ì •ë ¬ ê¸°ì¤€";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "ì•ŒíŒŒë²³ ìˆœ";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "ë¯¸ë²ˆì—­ ìš°ì„ ";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "ì†ŒìŠ¤ í…ìŠ¤íŠ¸:";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "ë²ˆì—­í•  í…ìŠ¤íŠ¸:";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "ë²ˆì—­ë¨";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "ë²ˆì—­ì´ ì‚­ì œë¨";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "ë²ˆì—­ìž:";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "ë²ˆì—­ ì•ˆ ë¨";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "ë³¸ íŽ˜ì´ì§€ì— ëŒ€í•œ ì ‘ê·¼ ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "ì‚¬ìš©í•  ìˆ˜ ìžˆëŠ” ì»¨í…ìŠ¤íŠ¸ê°€ ì—†ì–´ìš”";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "ì‚¬ìš©í•  ìˆ˜ ìžˆëŠ” ì˜ˆì œê°€ ì—†ì–´ìš”";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "ìžë™ ìŠ¤í¬ëž©í•œ ìœ„ì¹˜ê°€ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "ì‚¬ìš©í•  ìˆ˜ ìžˆëŠ” í‚¤ê°€ ì—†ì–´ìš”";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "ë²ˆì—­ ê¸°ë¡ì´ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "ì—”íŠ¸ë¦¬ë¥¼ ì‚­ì œí•˜ëŠ” ë° ë¬¸ì œê°€ ë°œìƒí–ˆìŠµë‹ˆë‹¤.";
	}
}


}
