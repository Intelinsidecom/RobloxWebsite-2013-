namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CrowdSourcedTranslationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CrowdSourcedTranslationResources_fr_fr : CrowdSourcedTranslationResources_en_us, ICrowdSourcedTranslationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public override string ActionAddTranslationEntry => "Ajouter une nouvelle entrÃ©e";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Supprimer";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "Abandonner les modifications";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "TÃ©lÃ©charger CSV";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "Charger plus";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Enregistrer";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "EnregistrÃ©";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "Enregistrement";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "Aucun contenu source n'a Ã©tÃ© trouvÃ© pour ce jeu. Vous pouvez activer Auto-Scraping ou tÃ©lÃ©charger manuellement du contenu Ã  partir de Developer Studio pour voir et gÃ©rer les traductions ici.";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "Aucun contenu de source trouvÃ© pour ce jeu. Si tu penses quâ€™il sâ€™agit dâ€™une erreur, il faut contacter le dÃ©veloppeur.";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "Aucun rÃ©sultat ne correspond aux filtres de recherche actuels";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "Vous avez des modifications non sauvegardÃ©es. Voulez-vous continuer\u00a0?";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "Saisir la traduction ici";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "Ajouter une traduction";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "Modifications non sauvegardÃ©es";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "GÃ©rer traductions\u00a0";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "Tu veux vraiment supprimer ca?";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "Aucun contenu";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "Historique de traduction";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "Veuillez noter que cette action est irrÃ©versible.";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "Traductions terminÃ©es : ";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "Contexte\u00a0:";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "Suppression";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "Exemple\u00a0:";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "Les traductions suivantes seront supprimÃ©es.";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "ClÃ©\u00a0:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "DerniÃ¨re modification\u00a0:";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "Endroits du jeu";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "Plus d'infos";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Requis";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "Rechercher...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "Trier par";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "AlphabÃ©tique";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "Non traduit en premier";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "Texte source\u00a0:";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "Texte Ã  traduire\u00a0:";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "Traduit";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "Traduction effacÃ©e";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "Traducteur\u00a0:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "Non traduit";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "Vous n'avez pas l'autorisation d'accÃ©der Ã  cette page";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "Aucun contexte disponible";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "Aucun exemple disponible";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "Aucun emplacement de jeu n'a Ã©tÃ© auto-scraped.";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "Aucune clÃ© disponible";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "Aucune histoire de traduction disponible.";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "Un problÃ¨me est survenu lors de la suppression.";

	public CrowdSourcedTranslationResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "Ajouter une nouvelle entrÃ©e";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Supprimer";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "Abandonner les modifications";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "TÃ©lÃ©charger CSV";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "Charger plus";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Enregistrer";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "EnregistrÃ©";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "Enregistrement";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "Aucun contenu source n'a Ã©tÃ© trouvÃ© pour ce jeu. Vous pouvez activer Auto-Scraping ou tÃ©lÃ©charger manuellement du contenu Ã  partir de Developer Studio pour voir et gÃ©rer les traductions ici.";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "Aucun contenu de source trouvÃ© pour ce jeu. Si tu penses quâ€™il sâ€™agit dâ€™une erreur, il faut contacter le dÃ©veloppeur.";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "Aucun rÃ©sultat ne correspond aux filtres de recherche actuels";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Vous avez des modifications non sauvegardÃ©es. Voulez-vous continuer\u00a0?";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "Saisir la traduction ici";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "Ajouter une traduction";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "Modifications non sauvegardÃ©es";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "GÃ©rer traductions\u00a0";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "Tu veux vraiment supprimer ca?";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "Aucun contenu";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "Historique de traduction";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "Veuillez noter que cette action est irrÃ©versible.";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "Traductions terminÃ©es : ";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "Contexte\u00a0:";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "Suppression";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "Exemple\u00a0:";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "Les traductions suivantes seront supprimÃ©es.";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "ClÃ©\u00a0:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "DerniÃ¨re modification\u00a0:";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "Endroits du jeu";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "Plus d'infos";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"{remainingCharacters}\u00a0caractÃ¨res";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "{remainingCharacters}\u00a0caractÃ¨res";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Requis";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "Rechercher...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "Trier par";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "AlphabÃ©tique";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "Non traduit en premier";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "Texte source\u00a0:";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "Texte Ã  traduire\u00a0:";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "Traduit";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "Traduction effacÃ©e";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "Traducteur\u00a0:";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "Non traduit";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Vous n'avez pas l'autorisation d'accÃ©der Ã  cette page";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "Aucun contexte disponible";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "Aucun exemple disponible";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "Aucun emplacement de jeu n'a Ã©tÃ© auto-scraped.";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "Aucune clÃ© disponible";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "Aucune histoire de traduction disponible.";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "Un problÃ¨me est survenu lors de la suppression.";
	}
}


}
