namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddTranslationEntry => "Ajouter une nouvelle entrée";

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
	public override string ActionDownloadCSV => "Télécharger CSV";

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
	public override string ActionSaved => "Enregistré";

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
	public override string DescriptionNoContent => "Aucun contenu source n'a été trouvé pour ce jeu. Vous pouvez activer Auto-Scraping ou télécharger manuellement du contenu à partir de Developer Studio pour voir et gérer les traductions ici.";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "Aucun contenu de source trouvé pour ce jeu. Si tu penses qu’il s’agit d’une erreur, il faut contacter le développeur.";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "Aucun résultat ne correspond aux filtres de recherche actuels";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "Vous avez des modifications non sauvegardées. Voulez-vous continuer\u00a0?";

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
	public override string HeadingDialogUnsavedChanges => "Modifications non sauvegardées";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "Gérer traductions\u00a0";

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
	public override string LabelActionIrreversibleWarning => "Veuillez noter que cette action est irréversible.";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "Traductions terminées : ";

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
	public override string LabelFollowingTranslationsDeleted => "Les traductions suivantes seront supprimées.";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "Clé\u00a0:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "Dernière modification\u00a0:";

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
	public override string LabelSortingAlphabetical => "Alphabétique";

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
	public override string LabelTextToTranslate => "Texte à traduire\u00a0:";

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
	public override string LabelTranslationCleared => "Traduction effacée";

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
	public override string ResponseAccessDenied => "Vous n'avez pas l'autorisation d'accéder à cette page";

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
	public override string ResponseNoGameLocationsAvailable => "Aucun emplacement de jeu n'a été auto-scraped.";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "Aucune clé disponible";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "Aucune histoire de traduction disponible.";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "Un problème est survenu lors de la suppression.";

	public CrowdSourcedTranslationResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "Ajouter une nouvelle entrée";
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
		return "Télécharger CSV";
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
		return "Enregistré";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "Enregistrement";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "Aucun contenu source n'a été trouvé pour ce jeu. Vous pouvez activer Auto-Scraping ou télécharger manuellement du contenu à partir de Developer Studio pour voir et gérer les traductions ici.";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "Aucun contenu de source trouvé pour ce jeu. Si tu penses qu’il s’agit d’une erreur, il faut contacter le développeur.";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "Aucun résultat ne correspond aux filtres de recherche actuels";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Vous avez des modifications non sauvegardées. Voulez-vous continuer\u00a0?";
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
		return "Modifications non sauvegardées";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "Gérer traductions\u00a0";
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
		return "Veuillez noter que cette action est irréversible.";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "Traductions terminées : ";
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
		return "Les traductions suivantes seront supprimées.";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "Clé\u00a0:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "Dernière modification\u00a0:";
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
		return $"{remainingCharacters}\u00a0caractères";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "{remainingCharacters}\u00a0caractères";
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
		return "Alphabétique";
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
		return "Texte à traduire\u00a0:";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "Traduit";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "Traduction effacée";
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
		return "Vous n'avez pas l'autorisation d'accéder à cette page";
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
		return "Aucun emplacement de jeu n'a été auto-scraped.";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "Aucune clé disponible";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "Aucune histoire de traduction disponible.";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "Un problème est survenu lors de la suppression.";
	}
}
