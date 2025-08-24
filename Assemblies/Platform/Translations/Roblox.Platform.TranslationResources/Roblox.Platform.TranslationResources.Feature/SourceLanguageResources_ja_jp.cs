namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SourceLanguageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SourceLanguageResources_ja_jp : SourceLanguageResources_en_us, ISourceLanguageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "確定";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "ソース言語はゲームの記述に使われた言語を示しています。";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "ソース言語を変更する";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "ゲームソース言語: ";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public override string LabelNotSpecified => "指定されていません";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "ソース言語";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "エラー: エラーが発生しました。後でもう一度お試しください。";

	public SourceLanguageResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "確定";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"このゲームのソース言語を{languageName} に変更してもよろしいですか？ゲームの記述に使われた言語に反映されます。";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "このゲームのソース言語を{languageName} に変更してもよろしいですか？ゲームの記述に使われた言語に反映されます。";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "ソース言語はゲームの記述に使われた言語を示しています。";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "ソース言語を変更する";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "ゲームソース言語: ";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "指定されていません";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "ソース言語";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "エラー: エラーが発生しました。後でもう一度お試しください。";
	}
}
