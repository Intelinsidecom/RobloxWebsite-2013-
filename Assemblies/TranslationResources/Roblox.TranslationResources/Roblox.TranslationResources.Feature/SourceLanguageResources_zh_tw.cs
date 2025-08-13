namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SourceLanguageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SourceLanguageResources_zh_tw : SourceLanguageResources_en_us, ISourceLanguageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "確認";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "源語言為遊戲原本撰寫時所用的語言。";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "變更源語言";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "遊戲源語言： ";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public override string LabelNotSpecified => "未指定";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "源語言";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "錯誤：發生錯誤，請稍後再試。";

	public SourceLanguageResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "確認";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"確定將此遊戲的源語言變更為{languageName}？此語言應為撰寫遊戲時使用的語言。";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "確定將此遊戲的源語言變更為{languageName}？此語言應為撰寫遊戲時使用的語言。";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "源語言為遊戲原本撰寫時所用的語言。";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "變更源語言";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "遊戲源語言： ";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "未指定";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "源語言";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "錯誤：發生錯誤，請稍後再試。";
	}
}
