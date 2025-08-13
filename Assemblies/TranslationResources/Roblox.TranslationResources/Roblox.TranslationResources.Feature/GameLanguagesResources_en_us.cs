using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GameLanguagesResources_en_us : TranslationResourcesBase, IGameLanguagesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.AddLanguage"
	/// English String: "Add Language"
	/// </summary>
	public virtual string ActionAddLanguage => "Add Language";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public virtual string ActionDelete => "Delete";

	/// <summary>
	/// Key: "Action.ManageTranslations"
	/// English String: "Manage Translations"
	/// </summary>
	public virtual string ActionManageTranslations => "Manage Translations";

	/// <summary>
	/// Key: "Description.NoLanguages"
	/// English String: "Please add languages you want your game to support."
	/// </summary>
	public virtual string DescriptionNoLanguages => "Please add languages you want your game to support.";

	/// <summary>
	/// Key: "Heading.DeleteLanguage"
	/// English String: "Delete Language"
	/// </summary>
	public virtual string HeadingDeleteLanguage => "Delete Language";

	/// <summary>
	/// Key: "Heading.SupportedLanguages"
	/// English String: "Supported Languages"
	/// </summary>
	public virtual string HeadingSupportedLanguages => "Supported Languages";

	/// <summary>
	/// Key: "Heading.TranslatedLanguages"
	/// English String: "Translated Languages"
	/// </summary>
	public virtual string HeadingTranslatedLanguages => "Translated Languages";

	/// <summary>
	/// Key: "Label.Languages"
	/// English String: "Languages"
	/// </summary>
	public virtual string LabelLanguages => "Languages";

	/// <summary>
	/// Key: "Label.SelectLanguage"
	/// English String: "Select Language"
	/// </summary>
	public virtual string LabelSelectLanguage => "Select Language";

	/// <summary>
	/// Key: "Message.DeleteLanguageWarning"
	/// English String: "All translations for this language will be deleted. This action is irreversible."
	/// </summary>
	public virtual string MessageDeleteLanguageWarning => "All translations for this language will be deleted. This action is irreversible.";

	public GameLanguagesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.AddLanguage",
				_GetTemplateForActionAddLanguage()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Delete",
				_GetTemplateForActionDelete()
			},
			{
				"Action.ManageTranslations",
				_GetTemplateForActionManageTranslations()
			},
			{
				"Description.NoLanguages",
				_GetTemplateForDescriptionNoLanguages()
			},
			{
				"Heading.DeleteLanguage",
				_GetTemplateForHeadingDeleteLanguage()
			},
			{
				"Heading.SupportedLanguages",
				_GetTemplateForHeadingSupportedLanguages()
			},
			{
				"Heading.TranslatedLanguages",
				_GetTemplateForHeadingTranslatedLanguages()
			},
			{
				"Label.Languages",
				_GetTemplateForLabelLanguages()
			},
			{
				"Label.SelectLanguage",
				_GetTemplateForLabelSelectLanguage()
			},
			{
				"Message.DeleteLanguageWarning",
				_GetTemplateForMessageDeleteLanguageWarning()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GameLanguages";
	}

	protected virtual string _GetTemplateForActionAddLanguage()
	{
		return "Add Language";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForActionManageTranslations()
	{
		return "Manage Translations";
	}

	protected virtual string _GetTemplateForDescriptionNoLanguages()
	{
		return "Please add languages you want your game to support.";
	}

	protected virtual string _GetTemplateForHeadingDeleteLanguage()
	{
		return "Delete Language";
	}

	protected virtual string _GetTemplateForHeadingSupportedLanguages()
	{
		return "Supported Languages";
	}

	protected virtual string _GetTemplateForHeadingTranslatedLanguages()
	{
		return "Translated Languages";
	}

	protected virtual string _GetTemplateForLabelLanguages()
	{
		return "Languages";
	}

	protected virtual string _GetTemplateForLabelSelectLanguage()
	{
		return "Select Language";
	}

	protected virtual string _GetTemplateForMessageDeleteLanguageWarning()
	{
		return "All translations for this language will be deleted. This action is irreversible.";
	}
}
