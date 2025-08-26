namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_ja_jp : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "è¨€èªžã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "å‰Šé™¤";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "ç¿»è¨³ã‚’ç®¡ç†";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "å¯¾å¿œã•ã›ãŸã„è¨€èªžã‚’è¿½åŠ ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "è¨€èªžã‚’å‰Šé™¤";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "å¯¾å¿œè¨€èªž";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "ç¿»è¨³æ¸ˆã¿ã®è¨€èªž";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "è¨€èªž";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "è¨€èªžã‚’é¸æŠž";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "ã“ã®è¨€èªžã®ã™ã¹ã¦ã®ç¿»è¨³ãŒå‰Šé™¤ã•ã‚Œã¾ã™ã€‚ã“ã®æ“ä½œã¯å…ƒã«æˆ»ã›ã¾ã›ã‚“ã€‚";

	public GameLanguagesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "è¨€èªžã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "å‰Šé™¤";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "ç¿»è¨³ã‚’ç®¡ç†";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "å¯¾å¿œã•ã›ãŸã„è¨€èªžã‚’è¿½åŠ ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "è¨€èªžã‚’å‰Šé™¤";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "å¯¾å¿œè¨€èªž";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "ç¿»è¨³æ¸ˆã¿ã®è¨€èªž";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "è¨€èªž";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "è¨€èªžã‚’é¸æŠž";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "ã“ã®è¨€èªžã®ã™ã¹ã¦ã®ç¿»è¨³ãŒå‰Šé™¤ã•ã‚Œã¾ã™ã€‚ã“ã®æ“ä½œã¯å…ƒã«æˆ»ã›ã¾ã›ã‚“ã€‚";
	}
}


}
