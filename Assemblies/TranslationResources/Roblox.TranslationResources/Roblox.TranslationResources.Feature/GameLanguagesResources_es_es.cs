namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLanguagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLanguagesResources_es_es : GameLanguagesResources_en_us, IGameLanguagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public override string ActionAddLanguage => "Añadir idioma";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Eliminar";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public override string ActionManageTranslations => "Gestionar traducciones";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public override string DescriptionNoLanguages => "Añade idiomas compatibles con tu juego.";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public override string HeadingDeleteLanguage => "Eliminar idioma";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public override string HeadingSupportedLanguages => "Idiomas compatibles";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public override string HeadingTranslatedLanguages => "Idiomas a los que está traducido";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelLanguages => "Idiomas";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public override string LabelSelectLanguage => "Seleccionar idioma";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public override string MessageDeleteLanguageWarning => "Se borrarán todas las traducciones disponibles para este idioma. Esta acción es irreversible.";

	public GameLanguagesResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLanguage()
	{
		return "Añadir idioma";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Eliminar";
	}

	protected override string _GetTemplateForActionManageTranslations()
	{
		return "Gestionar traducciones";
	}

	protected override string _GetTemplateForDescriptionNoLanguages()
	{
		return "Añade idiomas compatibles con tu juego.";
	}

	protected override string _GetTemplateForHeadingDeleteLanguage()
	{
		return "Eliminar idioma";
	}

	protected override string _GetTemplateForHeadingSupportedLanguages()
	{
		return "Idiomas compatibles";
	}

	protected override string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "Idiomas a los que está traducido";
	}

	protected override string _GetTemplateForLabelLanguages()
	{
		return "Idiomas";
	}

	protected override string _GetTemplateForLabelSelectLanguage()
	{
		return "Seleccionar idioma";
	}

	protected override string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "Se borrarán todas las traducciones disponibles para este idioma. Esta acción es irreversible.";
	}
}
