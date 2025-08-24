namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SourceLanguageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SourceLanguageResources_zh_cjv : SourceLanguageResources_en_us, ISourceLanguageResources, ITranslationResources
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
	public override string ActionConfirm => "确认";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "源语言代表此游戏所使用的语言。";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "更改源语言";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "游戏源语言：";

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
	public override string LabelSourceLanguage => "源语言";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "错误：发生错误。请稍后重试。";

	public SourceLanguageResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "确认";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"是否确认将此游戏的源语言更改为{languageName}？此动作应更改此游戏所使用的语言。";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "是否确认将此游戏的源语言更改为{languageName}？此动作应更改此游戏所使用的语言。";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "源语言代表此游戏所使用的语言。";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "更改源语言";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "游戏源语言：";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "未指定";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "源语言";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "错误：发生错误。请稍后重试。";
	}
}
