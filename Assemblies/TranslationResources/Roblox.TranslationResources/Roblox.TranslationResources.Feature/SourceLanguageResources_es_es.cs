namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SourceLanguageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SourceLanguageResources_es_es : SourceLanguageResources_en_us, ISourceLanguageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Confirmar";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "El idioma de origen es el idioma en el cual se ha escrito el juego.";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "Cambiar el idioma de origen";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "Idioma de origen del juego: ";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public override string LabelNotSpecified => "Sin especificar";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "Idioma de origen";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Error: no se ha podido guardar. Inténtalo de nuevo más tarde.";

	public SourceLanguageResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Confirmar";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"¿Seguro que quieres cambiar el idioma de origen de este juego a {languageName}? Este debería corresponder al idioma en el cual se ha escrito el juego.";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "¿Seguro que quieres cambiar el idioma de origen de este juego a {languageName}? Este debería corresponder al idioma en el cual se ha escrito el juego.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "El idioma de origen es el idioma en el cual se ha escrito el juego.";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "Cambiar el idioma de origen";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "Idioma de origen del juego: ";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "Sin especificar";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "Idioma de origen";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Error: no se ha podido guardar. Inténtalo de nuevo más tarde.";
	}
}
