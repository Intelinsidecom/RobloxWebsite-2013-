namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides SourceLanguageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SourceLanguageResources_zh_cn : SourceLanguageResources_en_us, ISourceLanguageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "ç¡®è®¤";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "æºè¯­è¨€ä»£è¡¨æ­¤æ¸¸æˆæ‰€ä½¿ç”¨çš„è¯­è¨€ã€‚";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "æ›´æ”¹æºè¯­è¨€";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "æ¸¸æˆæºè¯­è¨€ï¼š";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public override string LabelNotSpecified => "æœªæŒ‡å®š";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "æºè¯­è¨€";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "é”™è¯¯ï¼šå‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	public SourceLanguageResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "ç¡®è®¤";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"æ˜¯å¦ç¡®è®¤å°†æ­¤æ¸¸æˆçš„æºè¯­è¨€æ›´æ”¹ä¸º{languageName}ï¼Ÿæ­¤åŠ¨ä½œåº”æ›´æ”¹æ­¤æ¸¸æˆæ‰€ä½¿ç”¨çš„è¯­è¨€ã€‚";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "æ˜¯å¦ç¡®è®¤å°†æ­¤æ¸¸æˆçš„æºè¯­è¨€æ›´æ”¹ä¸º{languageName}ï¼Ÿæ­¤åŠ¨ä½œåº”æ›´æ”¹æ­¤æ¸¸æˆæ‰€ä½¿ç”¨çš„è¯­è¨€ã€‚";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "æºè¯­è¨€ä»£è¡¨æ­¤æ¸¸æˆæ‰€ä½¿ç”¨çš„è¯­è¨€ã€‚";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "æ›´æ”¹æºè¯­è¨€";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "æ¸¸æˆæºè¯­è¨€ï¼š";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "æœªæŒ‡å®š";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "æºè¯­è¨€";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "é”™è¯¯ï¼šå‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}
}


}
