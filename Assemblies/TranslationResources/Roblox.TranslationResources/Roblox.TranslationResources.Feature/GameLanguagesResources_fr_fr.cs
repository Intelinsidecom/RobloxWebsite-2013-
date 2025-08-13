namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_fr_fr : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "Ajouter langue";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Supprimer";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "Gérer traductions\u00a0";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "Merci d'ajouter les langues dans lesquelles tu souhaites que ton jeu soit disponible.";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "Supprimer langue";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "Langues disponibles";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "Langue traduites";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "Langues";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "Choisir langue";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "Toutes les traductions pour cette langue seront supprimées. Cette action est irréversible.";

	public GameLanguagesResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "Ajouter langue";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Supprimer";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "Gérer traductions\u00a0";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "Merci d'ajouter les langues dans lesquelles tu souhaites que ton jeu soit disponible.";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "Supprimer langue";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "Langues disponibles";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "Langue traduites";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "Langues";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "Choisir langue";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "Toutes les traductions pour cette langue seront supprimées. Cette action est irréversible.";
	}
}
