namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CrowdSourcedTranslationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CrowdSourcedTranslationResources_de_de : CrowdSourcedTranslationResources_en_us, ICrowdSourcedTranslationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public override string ActionAddTranslationEntry => "Neuen Eintrag hinzufÃ¼gen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "LÃ¶schen";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "Ã„nderungen verwerfen";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "CSV-Datei herunterladen";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "Mehr laden";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Speichern";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "Gespeichert";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "Wird gespeichert";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "FÃ¼r dieses Spiel wurde kein Inhalt gefunden. Du kannst Auto-Scraping aktivieren oder manuell Inhalt aus dem Developer Studio hochladen, um hier Ãœbersetzungen anzusehen und zu verwalten.";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "Kein Quellinhalt fÃ¼r dieses Spiel gefunden. Wende dich an den Entwickler, wenn du glaubst, dass dies ein Fehler ist.";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "FÃ¼r die aktuellen Suchfilter wurden keine EintrÃ¤ge gefunden";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "Du hast nicht gespeicherte Ã„nderungen. MÃ¶chtest du fortfahren?";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "Ãœbersetzung hier eingeben";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "Neuen Ãœbersetzungseintrag hinzufÃ¼gen";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "Nicht gespeicherte Ã„nderungen";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "Ãœbersetzungen verwalten";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "MÃ¶chtest du diesen Eintrag wirklich lÃ¶schen?";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "Kein Inhalt";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "Ãœbersetzungsverlauf";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "Bitte beachte, dass diese Aktion nicht rÃ¼ckgÃ¤ngig gemacht werden kann.";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "Fertige Ãœbersetzungen:";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "Kontext:";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "LÃ¶schen";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "Beispiel:";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "Die folgenden Ãœbersetzungen werden gelÃ¶scht.";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "SchlÃ¼ssel:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "Zuletzt geÃ¤ndert:";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "Orte im Spiel";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "Mehr Infos";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Erforderlich";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "Suchen ...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "Sortieren nach";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "Alphabetisch";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "Nicht Ã¼bersetzt zuerst";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "Quelltext:";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "Text zum Ãœbersetzen:";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "Ãœbersetzt";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "Ãœbersetzung wurde gelÃ¶scht";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "Ãœbersetzer:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "Nicht Ã¼bersetzt";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "Du hast nicht die nÃ¶tigen Rechte, um diese Seite aufzurufen.";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "Kein Kontext vorhanden";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "Kein Beispiel vorhanden";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "Es wurden keine Spielorte automatisch abgerufen.";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "Kein SchlÃ¼ssel verfÃ¼gbar";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "Kein Ãœbersetzungsverlauf vorhanden.";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "Beim LÃ¶schen des Eintrags ist ein Problem aufgetreten.";

	public CrowdSourcedTranslationResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "Neuen Eintrag hinzufÃ¼gen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "LÃ¶schen";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "Ã„nderungen verwerfen";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "CSV-Datei herunterladen";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "Mehr laden";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Speichern";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "Gespeichert";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "Wird gespeichert";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "FÃ¼r dieses Spiel wurde kein Inhalt gefunden. Du kannst Auto-Scraping aktivieren oder manuell Inhalt aus dem Developer Studio hochladen, um hier Ãœbersetzungen anzusehen und zu verwalten.";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "Kein Quellinhalt fÃ¼r dieses Spiel gefunden. Wende dich an den Entwickler, wenn du glaubst, dass dies ein Fehler ist.";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "FÃ¼r die aktuellen Suchfilter wurden keine EintrÃ¤ge gefunden";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Du hast nicht gespeicherte Ã„nderungen. MÃ¶chtest du fortfahren?";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "Ãœbersetzung hier eingeben";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "Neuen Ãœbersetzungseintrag hinzufÃ¼gen";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "Nicht gespeicherte Ã„nderungen";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "Ãœbersetzungen verwalten";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "MÃ¶chtest du diesen Eintrag wirklich lÃ¶schen?";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "Kein Inhalt";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "Ãœbersetzungsverlauf";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "Bitte beachte, dass diese Aktion nicht rÃ¼ckgÃ¤ngig gemacht werden kann.";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "Fertige Ãœbersetzungen:";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "Kontext:";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "LÃ¶schen";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "Beispiel:";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "Die folgenden Ãœbersetzungen werden gelÃ¶scht.";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "SchlÃ¼ssel:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "Zuletzt geÃ¤ndert:";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "Orte im Spiel";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "Mehr Infos";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"{remainingCharacters} Zeichen";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "{remainingCharacters} Zeichen";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Erforderlich";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "Suchen ...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "Sortieren nach";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "Alphabetisch";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "Nicht Ã¼bersetzt zuerst";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "Quelltext:";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "Text zum Ãœbersetzen:";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "Ãœbersetzt";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "Ãœbersetzung wurde gelÃ¶scht";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "Ãœbersetzer:";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "Nicht Ã¼bersetzt";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Du hast nicht die nÃ¶tigen Rechte, um diese Seite aufzurufen.";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "Kein Kontext vorhanden";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "Kein Beispiel vorhanden";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "Es wurden keine Spielorte automatisch abgerufen.";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "Kein SchlÃ¼ssel verfÃ¼gbar";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "Kein Ãœbersetzungsverlauf vorhanden.";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "Beim LÃ¶schen des Eintrags ist ein Problem aufgetreten.";
	}
}


}
