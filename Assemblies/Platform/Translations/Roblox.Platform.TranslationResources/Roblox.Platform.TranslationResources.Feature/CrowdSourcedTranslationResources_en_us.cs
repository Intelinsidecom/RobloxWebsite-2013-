using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class CrowdSourcedTranslationResources_en_us : TranslationResourcesBase, ICrowdSourcedTranslationResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public virtual string ActionAddTranslationEntry => "Add New Entry";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public virtual string ActionDelete => "Delete";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public virtual string ActionDialogDiscardChanges => "Discard Changes";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public virtual string ActionDownloadCSV => "Download CSV";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public virtual string ActionLoadMore => "Load More";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public virtual string ActionSave => "Save";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public virtual string ActionSaved => "Saved";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public virtual string ActionSaving => "Saving";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public virtual string DescriptionNoContent => "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here.";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public virtual string DescriptionNoContentDeveloper => "No source content found for this game. Please contact the Developer if you think this is an error.";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public virtual string DescriptionNoEntriesFound => "No entries were found based on current search filters";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public virtual string DescriptionUnsavedChanges => "You have unsaved changes. Do you want to proceed?";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public virtual string ExampleEnterTranslationHere => "Enter Translation Here";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public virtual string HeadingAddTranslationEntry => "Add a Translation Entry";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public virtual string HeadingDialogUnsavedChanges => "Unsaved Changes";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public virtual string HeadingManageTranslations => "Manage Translations";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public virtual string HeadingModalDeleteEntry => "Are you sure you want to delete this entry?";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public virtual string HeadingNoContent => "No Content";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public virtual string HeadingTranslationHistory => "Translation History";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public virtual string LabelActionIrreversibleWarning => "Please note that this action is irreversible.";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public virtual string LabelCompletedTranslations => "Completed Translations:";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public virtual string LabelContext => "Context:";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public virtual string LabelDeleting => "Deleting";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public virtual string LabelExample => "Example:";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public virtual string LabelFollowingTranslationsDeleted => "The following translations will be deleted.";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public virtual string LabelKey => "Key:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public virtual string LabelLastModified => "Last Modified:";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public virtual string LabelLocationsInGame => "Locations in Game";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public virtual string LabelMoreInformation => "More Information";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public virtual string LabelRequired => "Required";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public virtual string LabelSearchPlaceholder => "Search...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public virtual string LabelSortBy => "Sort By";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public virtual string LabelSortingAlphabetical => "Alphabetical";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public virtual string LabelSortingUntranslatedFirst => "Untranslated First";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public virtual string LabelSourceText => "Source Text:";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public virtual string LabelTextToTranslate => "Text to Translate:";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public virtual string LabelTranslated => "Translated";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public virtual string LabelTranslationCleared => "Translation cleared";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public virtual string LabelTranslator => "Translator:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public virtual string LabelUntranslated => "Untranslated";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public virtual string ResponseAccessDenied => "You don't have permission to access this page";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public virtual string ResponseNoContextAvailable => "No context available";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public virtual string ResponseNoExampleAvailable => "No example available";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public virtual string ResponseNoGameLocationsAvailable => "No game locations have been auto-scraped.";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public virtual string ResponseNoKeyAvailable => "No key available";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public virtual string ResponseNoTranslationHistory => "No translation history available.";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public virtual string ResponseProblemDeletingEntry => "There was a problem deleting entry.";

	public CrowdSourcedTranslationResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.AddTranslationEntry",
				_GetTemplateForActionAddTranslationEntry()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Delete",
				_GetTemplateForActionDelete()
			},
			{
				"Action.Dialog.DiscardChanges",
				_GetTemplateForActionDialogDiscardChanges()
			},
			{
				"Action.DownloadCSV",
				_GetTemplateForActionDownloadCSV()
			},
			{
				"Action.LoadMore",
				_GetTemplateForActionLoadMore()
			},
			{
				"Action.Save",
				_GetTemplateForActionSave()
			},
			{
				"Action.Saved",
				_GetTemplateForActionSaved()
			},
			{
				"Action.Saving",
				_GetTemplateForActionSaving()
			},
			{
				"Description.NoContent",
				_GetTemplateForDescriptionNoContent()
			},
			{
				"Description.NoContentDeveloper",
				_GetTemplateForDescriptionNoContentDeveloper()
			},
			{
				"Description.NoEntriesFound",
				_GetTemplateForDescriptionNoEntriesFound()
			},
			{
				"Description.UnsavedChanges",
				_GetTemplateForDescriptionUnsavedChanges()
			},
			{
				"Example.EnterTranslationHere",
				_GetTemplateForExampleEnterTranslationHere()
			},
			{
				"Heading.AddTranslationEntry",
				_GetTemplateForHeadingAddTranslationEntry()
			},
			{
				"Heading.Dialog.UnsavedChanges",
				_GetTemplateForHeadingDialogUnsavedChanges()
			},
			{
				"Heading.ManageTranslations",
				_GetTemplateForHeadingManageTranslations()
			},
			{
				"Heading.Modal.DeleteEntry",
				_GetTemplateForHeadingModalDeleteEntry()
			},
			{
				"Heading.NoContent",
				_GetTemplateForHeadingNoContent()
			},
			{
				"Heading.TranslationHistory",
				_GetTemplateForHeadingTranslationHistory()
			},
			{
				"Label.ActionIrreversibleWarning",
				_GetTemplateForLabelActionIrreversibleWarning()
			},
			{
				"Label.CompletedTranslations",
				_GetTemplateForLabelCompletedTranslations()
			},
			{
				"Label.Context",
				_GetTemplateForLabelContext()
			},
			{
				"Label.Deleting",
				_GetTemplateForLabelDeleting()
			},
			{
				"Label.Example",
				_GetTemplateForLabelExample()
			},
			{
				"Label.FollowingTranslationsDeleted",
				_GetTemplateForLabelFollowingTranslationsDeleted()
			},
			{
				"Label.Key",
				_GetTemplateForLabelKey()
			},
			{
				"Label.LastModified",
				_GetTemplateForLabelLastModified()
			},
			{
				"Label.LocationsInGame",
				_GetTemplateForLabelLocationsInGame()
			},
			{
				"Label.MoreInformation",
				_GetTemplateForLabelMoreInformation()
			},
			{
				"Label.RemainingCharacters",
				_GetTemplateForLabelRemainingCharacters()
			},
			{
				"Label.Required",
				_GetTemplateForLabelRequired()
			},
			{
				"Label.SearchPlaceholder",
				_GetTemplateForLabelSearchPlaceholder()
			},
			{
				"Label.SortBy",
				_GetTemplateForLabelSortBy()
			},
			{
				"Label.Sorting.Alphabetical",
				_GetTemplateForLabelSortingAlphabetical()
			},
			{
				"Label.Sorting.UntranslatedFirst",
				_GetTemplateForLabelSortingUntranslatedFirst()
			},
			{
				"Label.SourceText",
				_GetTemplateForLabelSourceText()
			},
			{
				"Label.TextToTranslate",
				_GetTemplateForLabelTextToTranslate()
			},
			{
				"Label.Translated",
				_GetTemplateForLabelTranslated()
			},
			{
				"Label.TranslationCleared",
				_GetTemplateForLabelTranslationCleared()
			},
			{
				"Label.Translator",
				_GetTemplateForLabelTranslator()
			},
			{
				"Label.Untranslated",
				_GetTemplateForLabelUntranslated()
			},
			{
				"Response.AccessDenied",
				_GetTemplateForResponseAccessDenied()
			},
			{
				"Response.NoContextAvailable",
				_GetTemplateForResponseNoContextAvailable()
			},
			{
				"Response.NoExampleAvailable",
				_GetTemplateForResponseNoExampleAvailable()
			},
			{
				"Response.NoGameLocationsAvailable",
				_GetTemplateForResponseNoGameLocationsAvailable()
			},
			{
				"Response.NoKeyAvailable",
				_GetTemplateForResponseNoKeyAvailable()
			},
			{
				"Response.NoTranslationHistory",
				_GetTemplateForResponseNoTranslationHistory()
			},
			{
				"Response.ProblemDeletingEntry",
				_GetTemplateForResponseProblemDeletingEntry()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.CrowdSourcedTranslation";
	}

	protected virtual string _GetTemplateForActionAddTranslationEntry()
	{
		return "Add New Entry";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForActionDialogDiscardChanges()
	{
		return "Discard Changes";
	}

	protected virtual string _GetTemplateForActionDownloadCSV()
	{
		return "Download CSV";
	}

	protected virtual string _GetTemplateForActionLoadMore()
	{
		return "Load More";
	}

	protected virtual string _GetTemplateForActionSave()
	{
		return "Save";
	}

	protected virtual string _GetTemplateForActionSaved()
	{
		return "Saved";
	}

	protected virtual string _GetTemplateForActionSaving()
	{
		return "Saving";
	}

	protected virtual string _GetTemplateForDescriptionNoContent()
	{
		return "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here.";
	}

	protected virtual string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "No source content found for this game. Please contact the Developer if you think this is an error.";
	}

	protected virtual string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "No entries were found based on current search filters";
	}

	protected virtual string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "You have unsaved changes. Do you want to proceed?";
	}

	protected virtual string _GetTemplateForExampleEnterTranslationHere()
	{
		return "Enter Translation Here";
	}

	protected virtual string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "Add a Translation Entry";
	}

	protected virtual string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "Unsaved Changes";
	}

	protected virtual string _GetTemplateForHeadingManageTranslations()
	{
		return "Manage Translations";
	}

	protected virtual string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "Are you sure you want to delete this entry?";
	}

	protected virtual string _GetTemplateForHeadingNoContent()
	{
		return "No Content";
	}

	protected virtual string _GetTemplateForHeadingTranslationHistory()
	{
		return "Translation History";
	}

	protected virtual string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "Please note that this action is irreversible.";
	}

	protected virtual string _GetTemplateForLabelCompletedTranslations()
	{
		return "Completed Translations:";
	}

	protected virtual string _GetTemplateForLabelContext()
	{
		return "Context:";
	}

	protected virtual string _GetTemplateForLabelDeleting()
	{
		return "Deleting";
	}

	protected virtual string _GetTemplateForLabelExample()
	{
		return "Example:";
	}

	protected virtual string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "The following translations will be deleted.";
	}

	protected virtual string _GetTemplateForLabelKey()
	{
		return "Key:";
	}

	protected virtual string _GetTemplateForLabelLastModified()
	{
		return "Last Modified:";
	}

	protected virtual string _GetTemplateForLabelLocationsInGame()
	{
		return "Locations in Game";
	}

	protected virtual string _GetTemplateForLabelMoreInformation()
	{
		return "More Information";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public virtual string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"{remainingCharacters} Characters";
	}

	protected virtual string _GetTemplateForLabelRemainingCharacters()
	{
		return "{remainingCharacters} Characters";
	}

	protected virtual string _GetTemplateForLabelRequired()
	{
		return "Required";
	}

	protected virtual string _GetTemplateForLabelSearchPlaceholder()
	{
		return "Search...";
	}

	protected virtual string _GetTemplateForLabelSortBy()
	{
		return "Sort By";
	}

	protected virtual string _GetTemplateForLabelSortingAlphabetical()
	{
		return "Alphabetical";
	}

	protected virtual string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "Untranslated First";
	}

	protected virtual string _GetTemplateForLabelSourceText()
	{
		return "Source Text:";
	}

	protected virtual string _GetTemplateForLabelTextToTranslate()
	{
		return "Text to Translate:";
	}

	protected virtual string _GetTemplateForLabelTranslated()
	{
		return "Translated";
	}

	protected virtual string _GetTemplateForLabelTranslationCleared()
	{
		return "Translation cleared";
	}

	protected virtual string _GetTemplateForLabelTranslator()
	{
		return "Translator:";
	}

	protected virtual string _GetTemplateForLabelUntranslated()
	{
		return "Untranslated";
	}

	protected virtual string _GetTemplateForResponseAccessDenied()
	{
		return "You don't have permission to access this page";
	}

	protected virtual string _GetTemplateForResponseNoContextAvailable()
	{
		return "No context available";
	}

	protected virtual string _GetTemplateForResponseNoExampleAvailable()
	{
		return "No example available";
	}

	protected virtual string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "No game locations have been auto-scraped.";
	}

	protected virtual string _GetTemplateForResponseNoKeyAvailable()
	{
		return "No key available";
	}

	protected virtual string _GetTemplateForResponseNoTranslationHistory()
	{
		return "No translation history available.";
	}

	protected virtual string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "There was a problem deleting entry.";
	}
}
