namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CrowdSourcedTranslationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CrowdSourcedTranslationResources_pt_br : CrowdSourcedTranslationResources_en_us, ICrowdSourcedTranslationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddTranslationEntry"
	/// English String: "Add New Entry"
	/// </summary>
	public override string ActionAddTranslationEntry => "Adicionar novo item";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Excluir";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "Descartar alterações";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "Baixar CSV";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "Carregar mais";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Salvar";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "Salvo";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "Salvando";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "Nenhum conteúdo original encontrado para este jogo. Você pode habilitar Auto-Scraping ou importar conteúdo manualmente do Developer Studio para ver e gerenciar traduções aqui.";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "Nenhum conteúdo fonte encontrado para este jogo. Contate o desenvolvedor se você acha que isto é um erro.";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "Nenhuma entrada foi encontrada com base nos filtros de pesquisa atuais";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "Você possui alterações não salvas. Deseja continuar?";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "Insira a tradução aqui";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "Adicione uma tradução";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "Alterações não salvas";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "Gerenciar traduções";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "Quer mesmo excluir este registro?";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "Sem conteúdo";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "Histórico de tradução";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "Saiba que esta ação é irreversível.";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "Traduções completadas:";

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
	public override string LabelDeleting => "Excluindo";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "Exemplo:";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "As seguintes traduções serão excluídas.";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "Chave:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "Última modificação:";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "Locais no jogo";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "Mais informações";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Necessário";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "Pesquisar...";

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
	public override string LabelSortingAlphabetical => "Alfabético";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "Não traduzido primeiro";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "Texto original:";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "Texto a traduzir:";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "Traduzido";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "Tradução excluída";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "Tradutor:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "Não traduzido";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "Você não tem permissão para acessar esta página";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "Nenhum contexto disponível";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "Nenhum exemplo disponível";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "Nenhum local do jogo sofreu “Auto-Scraping”.";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "Nenhuma chave disponível";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "Nenhum histórico de tradução disponível.";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "Ocorreu um erro ao excluir o registro.";

	public CrowdSourcedTranslationResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "Adicionar novo item";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Excluir";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "Descartar alterações";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "Baixar CSV";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "Carregar mais";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Salvar";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "Salvo";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "Salvando";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "Nenhum conteúdo original encontrado para este jogo. Você pode habilitar Auto-Scraping ou importar conteúdo manualmente do Developer Studio para ver e gerenciar traduções aqui.";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "Nenhum conteúdo fonte encontrado para este jogo. Contate o desenvolvedor se você acha que isto é um erro.";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "Nenhuma entrada foi encontrada com base nos filtros de pesquisa atuais";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Você possui alterações não salvas. Deseja continuar?";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "Insira a tradução aqui";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "Adicione uma tradução";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "Alterações não salvas";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "Gerenciar traduções";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "Quer mesmo excluir este registro?";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "Sem conteúdo";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "Histórico de tradução";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "Saiba que esta ação é irreversível.";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "Traduções completadas:";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "Contexto:";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "Excluindo";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "Exemplo:";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "As seguintes traduções serão excluídas.";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "Chave:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "Última modificação:";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "Locais no jogo";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "Mais informações";
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
		return "Necessário";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "Pesquisar...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "Ordenar por";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "Alfabético";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "Não traduzido primeiro";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "Texto original:";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "Texto a traduzir:";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "Traduzido";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "Tradução excluída";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "Tradutor:";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "Não traduzido";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Você não tem permissão para acessar esta página";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "Nenhum contexto disponível";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "Nenhum exemplo disponível";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "Nenhum local do jogo sofreu “Auto-Scraping”.";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "Nenhuma chave disponível";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "Nenhum histórico de tradução disponível.";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "Ocorreu um erro ao excluir o registro.";
	}
}
