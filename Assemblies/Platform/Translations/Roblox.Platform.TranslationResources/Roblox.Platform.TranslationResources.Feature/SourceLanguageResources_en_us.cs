using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class SourceLanguageResources_en_us : TranslationResourcesBase, ISourceLanguageResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public virtual string ActionConfirm => "Confirm";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public virtual string DescriptionSourceLanguage => "The source language represents the language the game has been written in.";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public virtual string HeadingChangeSourceLanguage => "Change Source Language";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public virtual string LabelGameSourceLanguage => "Game Source Language: ";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public virtual string LabelNotSpecified => "Not Specified";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public virtual string LabelSourceLanguage => "Source Language";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public virtual string ResponseGeneralError => "Error: An error has occurred. Please try again later.";

	public SourceLanguageResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Confirm",
				_GetTemplateForActionConfirm()
			},
			{
				"Description.ChangeSourceLanguage",
				_GetTemplateForDescriptionChangeSourceLanguage()
			},
			{
				"Description.SourceLanguage",
				_GetTemplateForDescriptionSourceLanguage()
			},
			{
				"Heading.ChangeSourceLanguage",
				_GetTemplateForHeadingChangeSourceLanguage()
			},
			{
				"Label.GameSourceLanguage",
				_GetTemplateForLabelGameSourceLanguage()
			},
			{
				"Label.NotSpecified",
				_GetTemplateForLabelNotSpecified()
			},
			{
				"Label.SourceLanguage",
				_GetTemplateForLabelSourceLanguage()
			},
			{
				"Response.GeneralError",
				_GetTemplateForResponseGeneralError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.SourceLanguage";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionConfirm()
	{
		return "Confirm";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public virtual string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in.";
	}

	protected virtual string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in.";
	}

	protected virtual string _GetTemplateForDescriptionSourceLanguage()
	{
		return "The source language represents the language the game has been written in.";
	}

	protected virtual string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "Change Source Language";
	}

	protected virtual string _GetTemplateForLabelGameSourceLanguage()
	{
		return "Game Source Language: ";
	}

	protected virtual string _GetTemplateForLabelNotSpecified()
	{
		return "Not Specified";
	}

	protected virtual string _GetTemplateForLabelSourceLanguage()
	{
		return "Source Language";
	}

	protected virtual string _GetTemplateForResponseGeneralError()
	{
		return "Error: An error has occurred. Please try again later.";
	}
}
