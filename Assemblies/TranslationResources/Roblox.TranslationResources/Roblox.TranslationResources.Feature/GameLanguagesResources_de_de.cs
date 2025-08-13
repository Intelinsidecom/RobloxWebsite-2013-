namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddLanguage => "Sprache hinzufügen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Löschen";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "Übersetzungen verwalten";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "Bitte füge Sprachen hinzu, die dein Spiel unterstützen soll.";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "Sprache löschen";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "Unterstützte Sprachen";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "Übersetzte Sprachen";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "Sprachen";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "Sprache auswählen";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "Alle Übersetzungen für diese Sprache werden gelöscht. Diese Aktion kann nicht rückgängig gemacht werden.";

	public GameLanguagesResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "Sprache hinzufügen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Löschen";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "Übersetzungen verwalten";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "Bitte füge Sprachen hinzu, die dein Spiel unterstützen soll.";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "Sprache löschen";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "Unterstützte Sprachen";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "Übersetzte Sprachen";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "Sprachen";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "Sprache auswählen";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "Alle Übersetzungen für diese Sprache werden gelöscht. Diese Aktion kann nicht rückgängig gemacht werden.";
	}
}
