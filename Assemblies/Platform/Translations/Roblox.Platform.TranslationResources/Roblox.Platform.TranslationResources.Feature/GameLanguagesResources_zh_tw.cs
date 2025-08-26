namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_zh_tw : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "å¢žåŠ èªžè¨€";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "åˆªé™¤";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "ç®¡ç†ç¿»è­¯";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "è«‹åŠ å…¥æ‚¨çš„éŠæˆ²è¦æ”¯æ´çš„èªžè¨€ã€‚";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "åˆªé™¤èªžè¨€";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "æ”¯æ´èªžè¨€";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "å·²ç¿»è­¯èªžè¨€";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "èªžè¨€";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "é¸æ“‡èªžè¨€";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "å³å°‡åˆªé™¤æ‰€æœ‰æ­¤èªžè¨€çš„ç¿»è­¯ã€‚æ­¤å‹•ä½œç„¡æ³•å¾©åŽŸã€‚";

	public GameLanguagesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "å¢žåŠ èªžè¨€";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "åˆªé™¤";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "ç®¡ç†ç¿»è­¯";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "è«‹åŠ å…¥æ‚¨çš„éŠæˆ²è¦æ”¯æ´çš„èªžè¨€ã€‚";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "åˆªé™¤èªžè¨€";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "æ”¯æ´èªžè¨€";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "å·²ç¿»è­¯èªžè¨€";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "èªžè¨€";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "é¸æ“‡èªžè¨€";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "å³å°‡åˆªé™¤æ‰€æœ‰æ­¤èªžè¨€çš„ç¿»è­¯ã€‚æ­¤å‹•ä½œç„¡æ³•å¾©åŽŸã€‚";
	}
}


}
