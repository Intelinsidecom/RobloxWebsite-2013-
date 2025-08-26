namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "ç¢ºå®š";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "ã‚½ãƒ¼ã‚¹è¨€èªžã¯ã‚²ãƒ¼ãƒ ã®è¨˜è¿°ã«ä½¿ã‚ã‚ŒãŸè¨€èªžã‚’ç¤ºã—ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "ã‚½ãƒ¼ã‚¹è¨€èªžã‚’å¤‰æ›´ã™ã‚‹";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "ã‚²ãƒ¼ãƒ ã‚½ãƒ¼ã‚¹è¨€èªž: ";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public override string LabelNotSpecified => "æŒ‡å®šã•ã‚Œã¦ã„ã¾ã›ã‚“";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "ã‚½ãƒ¼ã‚¹è¨€èªž";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ã‚¨ãƒ©ãƒ¼: ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public SourceLanguageResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "ç¢ºå®š";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹è¨€èªžã‚’{languageName} ã«å¤‰æ›´ã—ã¦ã‚‚ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿã‚²ãƒ¼ãƒ ã®è¨˜è¿°ã«ä½¿ã‚ã‚ŒãŸè¨€èªžã«åæ˜ ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚½ãƒ¼ã‚¹è¨€èªžã‚’{languageName} ã«å¤‰æ›´ã—ã¦ã‚‚ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿã‚²ãƒ¼ãƒ ã®è¨˜è¿°ã«ä½¿ã‚ã‚ŒãŸè¨€èªžã«åæ˜ ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "ã‚½ãƒ¼ã‚¹è¨€èªžã¯ã‚²ãƒ¼ãƒ ã®è¨˜è¿°ã«ä½¿ã‚ã‚ŒãŸè¨€èªžã‚’ç¤ºã—ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "ã‚½ãƒ¼ã‚¹è¨€èªžã‚’å¤‰æ›´ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "ã‚²ãƒ¼ãƒ ã‚½ãƒ¼ã‚¹è¨€èªž: ";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "æŒ‡å®šã•ã‚Œã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "ã‚½ãƒ¼ã‚¹è¨€èªž";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ã‚¨ãƒ©ãƒ¼: ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}
}


}
