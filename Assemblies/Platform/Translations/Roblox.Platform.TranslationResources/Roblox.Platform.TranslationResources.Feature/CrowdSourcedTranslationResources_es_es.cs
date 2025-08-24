namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CrowdSourcedTranslationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CrowdSourcedTranslationResources_es_es : CrowdSourcedTranslationResources_en_us, ICrowdSourcedTranslationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public override string ActionAddTranslationEntry => "Añadir una nueva entrada";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Eliminar";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "Descartar cambios";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "Descargar CSV";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "Cargar más";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Guardar";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "Guardado";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "Guardando";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "No se ha podido encontrar el contenido de origen para este juego. Puedes activar la extracción automática o cargar manualmente el contenido desde Developer Studio para ver y gestionar las traducciones aquí.";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "No se ha encontrado el contenido de origen de este juego. Ponte en contacto con el desarrollador si piensas que se ha producido un error.";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "No se han encontrado entradas con los filtros de búsqueda actuales";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "Tienes cambios sin guardar. ¿Quieres proceder?";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "Escribe la traducción aquí";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "Añadir una traducción";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "Cambios sin guardar";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "Gestionar traducciones";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "¿Seguro que quieres eliminar esta entrada?";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "Sin contenido";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "Historial de traducción";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "Ten en cuenta que esta acción es irreversible.";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "Traducciones terminadas:";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "Contexto:";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "Eliminación";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "Ejemplo:";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "Se eliminarán las siguientes traducciones.";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "Clave:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "Última modificación:";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "Lugares en el juego";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "Información adicional";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Obligatorio";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "Buscar...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "Ordenar por";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "En orden alfabético";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "Primero el texto sin traducir";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "Texto de origen:";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "Texto a traducir:";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "Traducido";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "Traducción borrada";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "Traductor:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "Sin traducir";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "No tienes permiso para acceder a esta página";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "Ningún contexto disponible";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "Ningún ejemplo disponible";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "No se ha extracto automáticamente ninguna ubicación del juego.";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "Ninguna clave disponible";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "Ningún historial de traducción disponible.";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "Ha habido un problema al eliminar esta entrada.";

	public CrowdSourcedTranslationResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "Añadir una nueva entrada";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Eliminar";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "Descartar cambios";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "Descargar CSV";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "Cargar más";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Guardar";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "Guardado";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "Guardando";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "No se ha podido encontrar el contenido de origen para este juego. Puedes activar la extracción automática o cargar manualmente el contenido desde Developer Studio para ver y gestionar las traducciones aquí.";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "No se ha encontrado el contenido de origen de este juego. Ponte en contacto con el desarrollador si piensas que se ha producido un error.";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "No se han encontrado entradas con los filtros de búsqueda actuales";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Tienes cambios sin guardar. ¿Quieres proceder?";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "Escribe la traducción aquí";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "Añadir una traducción";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "Cambios sin guardar";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "Gestionar traducciones";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "¿Seguro que quieres eliminar esta entrada?";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "Sin contenido";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "Historial de traducción";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "Ten en cuenta que esta acción es irreversible.";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "Traducciones terminadas:";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "Contexto:";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "Eliminación";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "Ejemplo:";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "Se eliminarán las siguientes traducciones.";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "Clave:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "Última modificación:";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "Lugares en el juego";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "Información adicional";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"{remainingCharacters} caracteres";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "{remainingCharacters} caracteres";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Obligatorio";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "Buscar...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "Ordenar por";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "En orden alfabético";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "Primero el texto sin traducir";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "Texto de origen:";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "Texto a traducir:";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "Traducido";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "Traducción borrada";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "Traductor:";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "Sin traducir";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "No tienes permiso para acceder a esta página";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "Ningún contexto disponible";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "Ningún ejemplo disponible";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "No se ha extracto automáticamente ninguna ubicación del juego.";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "Ninguna clave disponible";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "Ningún historial de traducción disponible.";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "Ha habido un problema al eliminar esta entrada.";
	}
}
