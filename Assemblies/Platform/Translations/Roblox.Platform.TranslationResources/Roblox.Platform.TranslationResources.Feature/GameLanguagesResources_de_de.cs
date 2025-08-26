namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_de_de : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "Sprache hinzufÃ¼gen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "LÃ¶schen";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "Ãœbersetzungen verwalten";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "Bitte fÃ¼ge Sprachen hinzu, die dein Spiel unterstÃ¼tzen soll.";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "Sprache lÃ¶schen";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "UnterstÃ¼tzte Sprachen";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "Ãœbersetzte Sprachen";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "Sprachen";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "Sprache auswÃ¤hlen";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "Alle Ãœbersetzungen fÃ¼r diese Sprache werden gelÃ¶scht. Diese Aktion kann nicht rÃ¼ckgÃ¤ngig gemacht werden.";

	public GameLanguagesResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "Sprache hinzufÃ¼gen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "LÃ¶schen";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "Ãœbersetzungen verwalten";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "Bitte fÃ¼ge Sprachen hinzu, die dein Spiel unterstÃ¼tzen soll.";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "Sprache lÃ¶schen";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "UnterstÃ¼tzte Sprachen";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "Ãœbersetzte Sprachen";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "Sprachen";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "Sprache auswÃ¤hlen";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "Alle Ãœbersetzungen fÃ¼r diese Sprache werden gelÃ¶scht. Diese Aktion kann nicht rÃ¼ckgÃ¤ngig gemacht werden.";
	}
}


}
