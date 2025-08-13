namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddTranslationEntry => "Neuen Eintrag hinzufügen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Löschen";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "Änderungen verwerfen";

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
	public override string DescriptionNoContent => "Für dieses Spiel wurde kein Inhalt gefunden. Du kannst Auto-Scraping aktivieren oder manuell Inhalt aus dem Developer Studio hochladen, um hier Übersetzungen anzusehen und zu verwalten.";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "Kein Quellinhalt für dieses Spiel gefunden. Wende dich an den Entwickler, wenn du glaubst, dass dies ein Fehler ist.";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "Für die aktuellen Suchfilter wurden keine Einträge gefunden";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "Du hast nicht gespeicherte Änderungen. Möchtest du fortfahren?";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "Übersetzung hier eingeben";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "Neuen Übersetzungseintrag hinzufügen";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "Nicht gespeicherte Änderungen";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "Übersetzungen verwalten";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "Möchtest du diesen Eintrag wirklich löschen?";

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
	public override string HeadingTranslationHistory => "Übersetzungsverlauf";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "Bitte beachte, dass diese Aktion nicht rückgängig gemacht werden kann.";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "Fertige Übersetzungen:";

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
	public override string LabelDeleting => "Löschen";

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
	public override string LabelFollowingTranslationsDeleted => "Die folgenden Übersetzungen werden gelöscht.";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "Schlüssel:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "Zuletzt geändert:";

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
	public override string LabelSortingUntranslatedFirst => "Nicht übersetzt zuerst";

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
	public override string LabelTextToTranslate => "Text zum Übersetzen:";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "Übersetzt";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "Übersetzung wurde gelöscht";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "Übersetzer:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "Nicht übersetzt";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "Du hast nicht die nötigen Rechte, um diese Seite aufzurufen.";

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
	public override string ResponseNoKeyAvailable => "Kein Schlüssel verfügbar";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "Kein Übersetzungsverlauf vorhanden.";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "Beim Löschen des Eintrags ist ein Problem aufgetreten.";

	public CrowdSourcedTranslationResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "Neuen Eintrag hinzufügen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "Änderungen verwerfen";
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
		return "Für dieses Spiel wurde kein Inhalt gefunden. Du kannst Auto-Scraping aktivieren oder manuell Inhalt aus dem Developer Studio hochladen, um hier Übersetzungen anzusehen und zu verwalten.";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "Kein Quellinhalt für dieses Spiel gefunden. Wende dich an den Entwickler, wenn du glaubst, dass dies ein Fehler ist.";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "Für die aktuellen Suchfilter wurden keine Einträge gefunden";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Du hast nicht gespeicherte Änderungen. Möchtest du fortfahren?";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "Übersetzung hier eingeben";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "Neuen Übersetzungseintrag hinzufügen";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "Nicht gespeicherte Änderungen";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "Übersetzungen verwalten";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "Möchtest du diesen Eintrag wirklich löschen?";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "Kein Inhalt";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "Übersetzungsverlauf";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "Bitte beachte, dass diese Aktion nicht rückgängig gemacht werden kann.";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "Fertige Übersetzungen:";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "Kontext:";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "Beispiel:";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "Die folgenden Übersetzungen werden gelöscht.";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "Schlüssel:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "Zuletzt geändert:";
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
		return "Nicht übersetzt zuerst";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "Quelltext:";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "Text zum Übersetzen:";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "Übersetzt";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "Übersetzung wurde gelöscht";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "Übersetzer:";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "Nicht übersetzt";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Du hast nicht die nötigen Rechte, um diese Seite aufzurufen.";
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
		return "Kein Schlüssel verfügbar";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "Kein Übersetzungsverlauf vorhanden.";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "Beim Löschen des Eintrags ist ein Problem aufgetreten.";
	}
}
