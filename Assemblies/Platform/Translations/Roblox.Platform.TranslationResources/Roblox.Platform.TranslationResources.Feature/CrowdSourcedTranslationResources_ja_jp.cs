namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddTranslationEntry => "新しい入力内容を追加";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "削除";

	/// <summary>
	/// Key: "Action.Dialog.DiscardChanges"
	/// English String: "Discard Changes"
	/// </summary>
	public override string ActionDialogDiscardChanges => "変更を破棄";

	/// <summary>
	/// Key: "Action.DownloadCSV"
	/// button label
	/// English String: "Download CSV"
	/// </summary>
	public override string ActionDownloadCSV => "CSVをダウンロード";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "さらに読み込む";

	/// <summary>
	/// Key: "Action.Save"
	/// button text
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Action.Saved"
	/// button text when data is saved
	/// English String: "Saved"
	/// </summary>
	public override string ActionSaved => "保存しました";

	/// <summary>
	/// Key: "Action.Saving"
	/// English String: "Saving"
	/// </summary>
	public override string ActionSaving => "保存中";

	/// <summary>
	/// Key: "Description.NoContent"
	/// description for no content case
	/// English String: "No source content found for this game. You can enable Auto-Scraping or manually upload content from Developer Studio to view and manage translations here."
	/// </summary>
	public override string DescriptionNoContent => "このゲームのソースコンテンツはありません。ここで、自動取得を有効にしたり、Developer Studioからコンテンツを手動でアップロードして、翻訳の確認や管理を行うことができます。";

	/// <summary>
	/// Key: "Description.NoContentDeveloper"
	/// English String: "No source content found for this game. Please contact the Developer if you think this is an error."
	/// </summary>
	public override string DescriptionNoContentDeveloper => "このゲームのソースコンテンツがありません。エラーだと思われる場合は、開発者にご連絡ください。";

	/// <summary>
	/// Key: "Description.NoEntriesFound"
	/// message shown when no entries are found while doing a search or filter
	/// English String: "No entries were found based on current search filters"
	/// </summary>
	public override string DescriptionNoEntriesFound => "最近の検索フィルタに基づいた入力はありません";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// English String: "You have unsaved changes. Do you want to proceed?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "保存されていない変更内容があります。続けてよろしいですか？";

	/// <summary>
	/// Key: "Example.EnterTranslationHere"
	/// placeholder text
	/// English String: "Enter Translation Here"
	/// </summary>
	public override string ExampleEnterTranslationHere => "翻訳の入力はこちら";

	/// <summary>
	/// Key: "Heading.AddTranslationEntry"
	/// English String: "Add a Translation Entry"
	/// </summary>
	public override string HeadingAddTranslationEntry => "翻訳の入力内容を追加";

	/// <summary>
	/// Key: "Heading.Dialog.UnsavedChanges"
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingDialogUnsavedChanges => "保存されていない変更内容";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading for the page
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "翻訳を管理";

	/// <summary>
	/// Key: "Heading.Modal.DeleteEntry"
	/// English String: "Are you sure you want to delete this entry?"
	/// </summary>
	public override string HeadingModalDeleteEntry => "この入力内容を削除してよろしいですか。";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// heading for section
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "コンテンツがありません";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "翻訳履歴";

	/// <summary>
	/// Key: "Label.ActionIrreversibleWarning"
	/// English String: "Please note that this action is irreversible."
	/// </summary>
	public override string LabelActionIrreversibleWarning => "この操作をすると、元に戻せないのでご注意ください。";

	/// <summary>
	/// Key: "Label.CompletedTranslations"
	/// English String: "Completed Translations:"
	/// </summary>
	public override string LabelCompletedTranslations => "翻訳が終了しました。";

	/// <summary>
	/// Key: "Label.Context"
	/// form label - context of the translation text
	/// English String: "Context:"
	/// </summary>
	public override string LabelContext => "文脈:";

	/// <summary>
	/// Key: "Label.Deleting"
	/// English String: "Deleting"
	/// </summary>
	public override string LabelDeleting => "削除中";

	/// <summary>
	/// Key: "Label.Example"
	/// example text
	/// English String: "Example:"
	/// </summary>
	public override string LabelExample => "例:";

	/// <summary>
	/// Key: "Label.FollowingTranslationsDeleted"
	/// English String: "The following translations will be deleted."
	/// </summary>
	public override string LabelFollowingTranslationsDeleted => "以下の翻訳は削除されます。";

	/// <summary>
	/// Key: "Label.Key"
	/// label for the key of text to be translated
	/// English String: "Key:"
	/// </summary>
	public override string LabelKey => "キー:";

	/// <summary>
	/// Key: "Label.LastModified"
	/// form label
	/// English String: "Last Modified:"
	/// </summary>
	public override string LabelLastModified => "最終更新:";

	/// <summary>
	/// Key: "Label.LocationsInGame"
	/// English String: "Locations in Game"
	/// </summary>
	public override string LabelLocationsInGame => "ゲーム内の場所";

	/// <summary>
	/// Key: "Label.MoreInformation"
	/// English String: "More Information"
	/// </summary>
	public override string LabelMoreInformation => "もっと詳しく";

	/// <summary>
	/// Key: "Label.Required"
	/// placeholder label for a required field
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "必須";

	/// <summary>
	/// Key: "Label.SearchPlaceholder"
	/// placeholder text for a search field
	/// English String: "Search..."
	/// </summary>
	public override string LabelSearchPlaceholder => "検索...";

	/// <summary>
	/// Key: "Label.SortBy"
	/// sorting drop down label
	/// English String: "Sort By"
	/// </summary>
	public override string LabelSortBy => "並べ替え";

	/// <summary>
	/// Key: "Label.Sorting.Alphabetical"
	/// sort type label
	/// English String: "Alphabetical"
	/// </summary>
	public override string LabelSortingAlphabetical => "アルファベット順";

	/// <summary>
	/// Key: "Label.Sorting.UntranslatedFirst"
	/// sorting label
	/// English String: "Untranslated First"
	/// </summary>
	public override string LabelSortingUntranslatedFirst => "翻訳されていない順";

	/// <summary>
	/// Key: "Label.SourceText"
	/// English String: "Source Text:"
	/// </summary>
	public override string LabelSourceText => "ソーステキスト:";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// form label
	/// English String: "Text to Translate:"
	/// </summary>
	public override string LabelTextToTranslate => "翻訳するテキスト：";

	/// <summary>
	/// Key: "Label.Translated"
	/// tooltip help text
	/// English String: "Translated"
	/// </summary>
	public override string LabelTranslated => "翻訳済み";

	/// <summary>
	/// Key: "Label.TranslationCleared"
	/// English String: "Translation cleared"
	/// </summary>
	public override string LabelTranslationCleared => "翻訳を消しました";

	/// <summary>
	/// Key: "Label.Translator"
	/// form label
	/// English String: "Translator:"
	/// </summary>
	public override string LabelTranslator => "翻訳者:";

	/// <summary>
	/// Key: "Label.Untranslated"
	/// tooltip help text
	/// English String: "Untranslated"
	/// </summary>
	public override string LabelUntranslated => "翻訳されていません";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "このページにアクセスする権限がありません";

	/// <summary>
	/// Key: "Response.NoContextAvailable"
	/// English String: "No context available"
	/// </summary>
	public override string ResponseNoContextAvailable => "文脈情報がありません";

	/// <summary>
	/// Key: "Response.NoExampleAvailable"
	/// English String: "No example available"
	/// </summary>
	public override string ResponseNoExampleAvailable => "例がありません";

	/// <summary>
	/// Key: "Response.NoGameLocationsAvailable"
	/// English String: "No game locations have been auto-scraped."
	/// </summary>
	public override string ResponseNoGameLocationsAvailable => "自動抽出されたゲーム上の場所はありません。";

	/// <summary>
	/// Key: "Response.NoKeyAvailable"
	/// English String: "No key available"
	/// </summary>
	public override string ResponseNoKeyAvailable => "キーがありません";

	/// <summary>
	/// Key: "Response.NoTranslationHistory"
	/// English String: "No translation history available."
	/// </summary>
	public override string ResponseNoTranslationHistory => "翻訳履歴がありません。";

	/// <summary>
	/// Key: "Response.ProblemDeletingEntry"
	/// English String: "There was a problem deleting entry."
	/// </summary>
	public override string ResponseProblemDeletingEntry => "入力内容の削除で問題が発生しました。";

	public CrowdSourcedTranslationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddTranslationEntry()
	{
		return "新しい入力内容を追加";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "削除";
	}

	protected override string _GetTemplateForActionDialogDiscardChanges()
	{
		return "変更を破棄";
	}

	protected override string _GetTemplateForActionDownloadCSV()
	{
		return "CSVをダウンロード";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "さらに読み込む";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForActionSaved()
	{
		return "保存しました";
	}

	protected override string _GetTemplateForActionSaving()
	{
		return "保存中";
	}

	protected override string _GetTemplateForDescriptionNoContent()
	{
		return "このゲームのソースコンテンツはありません。ここで、自動取得を有効にしたり、Developer Studioからコンテンツを手動でアップロードして、翻訳の確認や管理を行うことができます。";
	}

	protected override string _GetTemplateForDescriptionNoContentDeveloper()
	{
		return "このゲームのソースコンテンツがありません。エラーだと思われる場合は、開発者にご連絡ください。";
	}

	protected override string _GetTemplateForDescriptionNoEntriesFound()
	{
		return "最近の検索フィルタに基づいた入力はありません";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "保存されていない変更内容があります。続けてよろしいですか？";
	}

	protected override string _GetTemplateForExampleEnterTranslationHere()
	{
		return "翻訳の入力はこちら";
	}

	protected override string _GetTemplateForHeadingAddTranslationEntry()
	{
		return "翻訳の入力内容を追加";
	}

	protected override string _GetTemplateForHeadingDialogUnsavedChanges()
	{
		return "保存されていない変更内容";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "翻訳を管理";
	}

	protected override string _GetTemplateForHeadingModalDeleteEntry()
	{
		return "この入力内容を削除してよろしいですか。";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "コンテンツがありません";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "翻訳履歴";
	}

	protected override string _GetTemplateForLabelActionIrreversibleWarning()
	{
		return "この操作をすると、元に戻せないのでご注意ください。";
	}

	protected override string _GetTemplateForLabelCompletedTranslations()
	{
		return "翻訳が終了しました。";
	}

	protected override string _GetTemplateForLabelContext()
	{
		return "文脈:";
	}

	protected override string _GetTemplateForLabelDeleting()
	{
		return "削除中";
	}

	protected override string _GetTemplateForLabelExample()
	{
		return "例:";
	}

	protected override string _GetTemplateForLabelFollowingTranslationsDeleted()
	{
		return "以下の翻訳は削除されます。";
	}

	protected override string _GetTemplateForLabelKey()
	{
		return "キー:";
	}

	protected override string _GetTemplateForLabelLastModified()
	{
		return "最終更新:";
	}

	protected override string _GetTemplateForLabelLocationsInGame()
	{
		return "ゲーム内の場所";
	}

	protected override string _GetTemplateForLabelMoreInformation()
	{
		return "もっと詳しく";
	}

	/// <summary>
	/// Key: "Label.RemainingCharacters"
	/// English String: "{remainingCharacters} Characters"
	/// </summary>
	public override string LabelRemainingCharacters(string remainingCharacters)
	{
		return $"{remainingCharacters} 文字";
	}

	protected override string _GetTemplateForLabelRemainingCharacters()
	{
		return "{remainingCharacters} 文字";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "必須";
	}

	protected override string _GetTemplateForLabelSearchPlaceholder()
	{
		return "検索...";
	}

	protected override string _GetTemplateForLabelSortBy()
	{
		return "並べ替え";
	}

	protected override string _GetTemplateForLabelSortingAlphabetical()
	{
		return "アルファベット順";
	}

	protected override string _GetTemplateForLabelSortingUntranslatedFirst()
	{
		return "翻訳されていない順";
	}

	protected override string _GetTemplateForLabelSourceText()
	{
		return "ソーステキスト:";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "翻訳するテキスト：";
	}

	protected override string _GetTemplateForLabelTranslated()
	{
		return "翻訳済み";
	}

	protected override string _GetTemplateForLabelTranslationCleared()
	{
		return "翻訳を消しました";
	}

	protected override string _GetTemplateForLabelTranslator()
	{
		return "翻訳者:";
	}

	protected override string _GetTemplateForLabelUntranslated()
	{
		return "翻訳されていません";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "このページにアクセスする権限がありません";
	}

	protected override string _GetTemplateForResponseNoContextAvailable()
	{
		return "文脈情報がありません";
	}

	protected override string _GetTemplateForResponseNoExampleAvailable()
	{
		return "例がありません";
	}

	protected override string _GetTemplateForResponseNoGameLocationsAvailable()
	{
		return "自動抽出されたゲーム上の場所はありません。";
	}

	protected override string _GetTemplateForResponseNoKeyAvailable()
	{
		return "キーがありません";
	}

	protected override string _GetTemplateForResponseNoTranslationHistory()
	{
		return "翻訳履歴がありません。";
	}

	protected override string _GetTemplateForResponseProblemDeletingEntry()
	{
		return "入力内容の削除で問題が発生しました。";
	}
}
