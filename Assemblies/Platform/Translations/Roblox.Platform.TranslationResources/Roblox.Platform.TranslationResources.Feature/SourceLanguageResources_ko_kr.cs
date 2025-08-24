namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SourceLanguageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SourceLanguageResources_ko_kr : SourceLanguageResources_en_us, ISourceLanguageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "확인";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "소스 언어는 게임 제작시 사용된 언어를 뜻합니다.";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "언어 변경";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "게임 소스 언어: ";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public override string LabelNotSpecified => "지정되지 않음";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "소스 언어";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "오류: 오류가 발생했어요. 나중에 다시 시도하세요.";

	public SourceLanguageResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "확인";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"본 게임에서 사용할 언어를 {languageName}로 바꾸시겠습니까? 게임의 사용 언어가 번경됩니다.";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "본 게임에서 사용할 언어를 {languageName}로 바꾸시겠습니까? 게임의 사용 언어가 번경됩니다.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "소스 언어는 게임 제작시 사용된 언어를 뜻합니다.";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "언어 변경";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "게임 소스 언어: ";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "지정되지 않음";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "소스 언어";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "오류: 오류가 발생했어요. 나중에 다시 시도하세요.";
	}
}
