namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "ç¢ºèª";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "æºèªžè¨€ç‚ºéŠæˆ²åŽŸæœ¬æ’°å¯«æ™‚æ‰€ç”¨çš„èªžè¨€ã€‚";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "è®Šæ›´æºèªžè¨€";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "éŠæˆ²æºèªžè¨€ï¼š ";

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
	public override string LabelSourceLanguage => "æºèªžè¨€";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "éŒ¯èª¤ï¼šç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	public SourceLanguageResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "ç¢ºèª";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"ç¢ºå®šå°‡æ­¤éŠæˆ²çš„æºèªžè¨€è®Šæ›´ç‚º{languageName}ï¼Ÿæ­¤èªžè¨€æ‡‰ç‚ºæ’°å¯«éŠæˆ²æ™‚ä½¿ç”¨çš„èªžè¨€ã€‚";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "ç¢ºå®šå°‡æ­¤éŠæˆ²çš„æºèªžè¨€è®Šæ›´ç‚º{languageName}ï¼Ÿæ­¤èªžè¨€æ‡‰ç‚ºæ’°å¯«éŠæˆ²æ™‚ä½¿ç”¨çš„èªžè¨€ã€‚";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "æºèªžè¨€ç‚ºéŠæˆ²åŽŸæœ¬æ’°å¯«æ™‚æ‰€ç”¨çš„èªžè¨€ã€‚";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "è®Šæ›´æºèªžè¨€";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "éŠæˆ²æºèªžè¨€ï¼š ";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "æœªæŒ‡å®š";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "æºèªžè¨€";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "éŒ¯èª¤ï¼šç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}
}


}
