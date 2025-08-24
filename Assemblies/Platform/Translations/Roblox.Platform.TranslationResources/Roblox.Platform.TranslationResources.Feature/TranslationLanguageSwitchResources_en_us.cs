using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class TranslationLanguageSwitchResources_en_us : TranslationResourcesBase, ITranslationLanguageSwitchResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public virtual string DescriptionChangeDefault => "Change default";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public virtual string DescriptionChangeDefaultLanguage => "What language do you want to set as default language?";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public virtual string DescriptionDelete => "Delete";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public virtual string DescriptionLanguageSwitch => "You can specify default and localized language, so that user can see game title and description in their language.";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public virtual string DescriptionMissingTranslation => "Please add missing translations(s)";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public virtual string DescriptionRemoveLanguage => "All localized information will be deleted.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public virtual string DescriptionSave => "You have unsaved changes. Are you sure you want to leave this page?";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public virtual string DescriptionUseDefault => "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead.";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public virtual string HeadingAddLanguage => "Add translations in other language(s)";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public virtual string HeadingChangeDefault => "Change the default language?";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public virtual string LabelAdd => "Add";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public virtual string LabelAddAnotherLanguage => "Add another language";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelCancel => "Cancel";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public virtual string LabelChange => "Change";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public virtual string LabelChangeAddLanguages => "Change / add in other language(s)";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public virtual string LabelChooseLanguage => "Choose a language to view/edit translations: ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public virtual string LabelCurrentLanguage => "Current Language";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public virtual string LabelDefault => "Default";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public virtual string LabelDelete => "Delete";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public virtual string LabelLanguage => "Language";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public virtual string LabelNotSpecified => "Not specified";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public virtual string LabelSearchLanguages => "Search other languages";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public virtual string LabelSetDefaultLanguage => "Set default language";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public virtual string LabelSource => "Source";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public virtual string LabelViewGameInfoForLanguage => "View Game Info for language";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public virtual string ResponseGeneralError => "Error: An error has occurred. Please try again later.";

	public TranslationLanguageSwitchResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.ChangeDefault",
				_GetTemplateForDescriptionChangeDefault()
			},
			{
				"Description.ChangeDefaultLanguage",
				_GetTemplateForDescriptionChangeDefaultLanguage()
			},
			{
				"Description.Delete",
				_GetTemplateForDescriptionDelete()
			},
			{
				"Description.LanguageSwitch",
				_GetTemplateForDescriptionLanguageSwitch()
			},
			{
				"Description.MissingTranslation",
				_GetTemplateForDescriptionMissingTranslation()
			},
			{
				"Description.RemoveLanguage",
				_GetTemplateForDescriptionRemoveLanguage()
			},
			{
				"Description.Save",
				_GetTemplateForDescriptionSave()
			},
			{
				"Description.UseDefault",
				_GetTemplateForDescriptionUseDefault()
			},
			{
				"Heading.AddLanguage",
				_GetTemplateForHeadingAddLanguage()
			},
			{
				"Heading.ChangeDefault",
				_GetTemplateForHeadingChangeDefault()
			},
			{
				"Heading.RemoveLanguage",
				_GetTemplateForHeadingRemoveLanguage()
			},
			{
				"Label.Add",
				_GetTemplateForLabelAdd()
			},
			{
				"Label.AddAnotherLanguage",
				_GetTemplateForLabelAddAnotherLanguage()
			},
			{
				"Label.Cancel",
				_GetTemplateForLabelCancel()
			},
			{
				"Label.Change",
				_GetTemplateForLabelChange()
			},
			{
				"Label.ChangeAddLanguages",
				_GetTemplateForLabelChangeAddLanguages()
			},
			{
				"Label.ChooseLanguage",
				_GetTemplateForLabelChooseLanguage()
			},
			{
				"Label.CurrentLanguage",
				_GetTemplateForLabelCurrentLanguage()
			},
			{
				"Label.Default",
				_GetTemplateForLabelDefault()
			},
			{
				"Label.Delete",
				_GetTemplateForLabelDelete()
			},
			{
				"Label.Language",
				_GetTemplateForLabelLanguage()
			},
			{
				"Label.NotSpecified",
				_GetTemplateForLabelNotSpecified()
			},
			{
				"Label.SearchLanguages",
				_GetTemplateForLabelSearchLanguages()
			},
			{
				"Label.SetDefaultLanguage",
				_GetTemplateForLabelSetDefaultLanguage()
			},
			{
				"Label.Source",
				_GetTemplateForLabelSource()
			},
			{
				"Label.SourceWithLanguageName",
				_GetTemplateForLabelSourceWithLanguageName()
			},
			{
				"Label.ViewGameInfoForLanguage",
				_GetTemplateForLabelViewGameInfoForLanguage()
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
		return "Feature.TranslationLanguageSwitch";
	}

	protected virtual string _GetTemplateForDescriptionChangeDefault()
	{
		return "Change default";
	}

	protected virtual string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "What language do you want to set as default language?";
	}

	protected virtual string _GetTemplateForDescriptionDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "You can specify default and localized language, so that user can see game title and description in their language.";
	}

	protected virtual string _GetTemplateForDescriptionMissingTranslation()
	{
		return "Please add missing translations(s)";
	}

	protected virtual string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "All localized information will be deleted.";
	}

	protected virtual string _GetTemplateForDescriptionSave()
	{
		return "You have unsaved changes. Are you sure you want to leave this page?";
	}

	protected virtual string _GetTemplateForDescriptionUseDefault()
	{
		return "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead.";
	}

	protected virtual string _GetTemplateForHeadingAddLanguage()
	{
		return "Add translations in other language(s)";
	}

	protected virtual string _GetTemplateForHeadingChangeDefault()
	{
		return "Change the default language?";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public virtual string HeadingRemoveLanguage(string languageName)
	{
		return $"Delete the {languageName} localization?";
	}

	protected virtual string _GetTemplateForHeadingRemoveLanguage()
	{
		return "Delete the {languageName} localization?";
	}

	protected virtual string _GetTemplateForLabelAdd()
	{
		return "Add";
	}

	protected virtual string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "Add another language";
	}

	protected virtual string _GetTemplateForLabelCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForLabelChange()
	{
		return "Change";
	}

	protected virtual string _GetTemplateForLabelChangeAddLanguages()
	{
		return "Change / add in other language(s)";
	}

	protected virtual string _GetTemplateForLabelChooseLanguage()
	{
		return "Choose a language to view/edit translations: ";
	}

	protected virtual string _GetTemplateForLabelCurrentLanguage()
	{
		return "Current Language";
	}

	protected virtual string _GetTemplateForLabelDefault()
	{
		return "Default";
	}

	protected virtual string _GetTemplateForLabelDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForLabelLanguage()
	{
		return "Language";
	}

	protected virtual string _GetTemplateForLabelNotSpecified()
	{
		return "Not specified";
	}

	protected virtual string _GetTemplateForLabelSearchLanguages()
	{
		return "Search other languages";
	}

	protected virtual string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "Set default language";
	}

	protected virtual string _GetTemplateForLabelSource()
	{
		return "Source";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public virtual string LabelSourceWithLanguageName(string languageName)
	{
		return $"Source ({languageName})";
	}

	protected virtual string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "Source ({languageName})";
	}

	protected virtual string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "View Game Info for language";
	}

	protected virtual string _GetTemplateForResponseGeneralError()
	{
		return "Error: An error has occurred. Please try again later.";
	}
}
