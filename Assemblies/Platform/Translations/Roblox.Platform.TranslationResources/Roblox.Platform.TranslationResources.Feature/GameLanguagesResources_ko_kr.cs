namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_ko_kr : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "ì–¸ì–´ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "ì‚­ì œ";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "ë²ˆì—­ ê´€ë¦¬";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "ë‚´ ê²Œìž„ì— ì§€ì›í•˜ê³  ì‹¶ì€ ì–¸ì–´ë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "ì–¸ì–´ ì‚­ì œ";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "ì§€ì› ì–¸ì–´";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "ë²ˆì—­ëœ ì–¸ì–´";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "ì–¸ì–´";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "ì–¸ì–´ ì„ íƒ";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "í•´ë‹¹ ì–¸ì–´ë¡œì˜ ëª¨ë“  ë²ˆì—­ì´ ì‚­ì œë©ë‹ˆë‹¤. ì´ ìž‘ì—…ì€ ë˜ëŒë¦´ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	public GameLanguagesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "ì–¸ì–´ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "ë²ˆì—­ ê´€ë¦¬";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "ë‚´ ê²Œìž„ì— ì§€ì›í•˜ê³  ì‹¶ì€ ì–¸ì–´ë¥¼ ì¶”ê°€í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "ì–¸ì–´ ì‚­ì œ";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "ì§€ì› ì–¸ì–´";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "ë²ˆì—­ëœ ì–¸ì–´";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "ì–¸ì–´";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "ì–¸ì–´ ì„ íƒ";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "í•´ë‹¹ ì–¸ì–´ë¡œì˜ ëª¨ë“  ë²ˆì—­ì´ ì‚­ì œë©ë‹ˆë‹¤. ì´ ìž‘ì—…ì€ ë˜ëŒë¦´ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}
}


}
