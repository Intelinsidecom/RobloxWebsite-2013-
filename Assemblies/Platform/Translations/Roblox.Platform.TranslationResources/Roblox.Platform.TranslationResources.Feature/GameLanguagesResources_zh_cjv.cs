namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_zh_cjv : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "æ·»åŠ è¯­è¨€";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "åˆ é™¤";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "ç®¡ç†ç¿»è¯‘";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "è¯·æ·»åŠ ä½ å¸Œæœ›æ¸¸æˆæ”¯æŒçš„è¯­è¨€ã€‚";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "åˆ é™¤è¯­è¨€";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "æ”¯æŒè¯­è¨€";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "å·²ç¿»è¯‘è¯­è¨€";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "è¯­è¨€";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "é€‰æ‹©è¯­è¨€";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "æ­¤è¯­è¨€çš„æ‰€æœ‰ç¿»è¯‘å°†è¢«åˆ é™¤ã€‚æ­¤æ“ä½œä¸å¯æ’¤é”€ã€‚";

	public GameLanguagesResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "æ·»åŠ è¯­è¨€";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "åˆ é™¤";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "ç®¡ç†ç¿»è¯‘";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "è¯·æ·»åŠ ä½ å¸Œæœ›æ¸¸æˆæ”¯æŒçš„è¯­è¨€ã€‚";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "åˆ é™¤è¯­è¨€";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "æ”¯æŒè¯­è¨€";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "å·²ç¿»è¯‘è¯­è¨€";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "è¯­è¨€";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "é€‰æ‹©è¯­è¨€";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "æ­¤è¯­è¨€çš„æ‰€æœ‰ç¿»è¯‘å°†è¢«åˆ é™¤ã€‚æ­¤æ“ä½œä¸å¯æ’¤é”€ã€‚";
	}
}


}
