namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SourceLanguageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SourceLanguageResources_de_de : SourceLanguageResources_en_us, ISourceLanguageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Bestätigen";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "Die Quellsprache steht für die Sprache, in der das Spiel geschrieben wurde.";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "Quellsprache ändern";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "Quellsprache des Spiels: ";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public override string LabelNotSpecified => "Nicht festgelegt";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "Quellsprache";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Fehler: Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";

	public SourceLanguageResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Bestätigen";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"Möchtest du die Quellsprache dieses Spiels wirklich zu {languageName} ändern? Dies sollte der Sprache entsprechen, in der das Spiel geschrieben wurde.";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "Möchtest du die Quellsprache dieses Spiels wirklich zu {languageName} ändern? Dies sollte der Sprache entsprechen, in der das Spiel geschrieben wurde.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "Die Quellsprache steht für die Sprache, in der das Spiel geschrieben wurde.";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "Quellsprache ändern";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "Quellsprache des Spiels: ";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "Nicht festgelegt";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "Quellsprache";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Fehler: Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";
	}
}
