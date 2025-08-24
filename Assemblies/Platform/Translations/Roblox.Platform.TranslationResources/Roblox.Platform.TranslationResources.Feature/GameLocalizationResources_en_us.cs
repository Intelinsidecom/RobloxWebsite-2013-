using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GameLocalizationResources_en_us : TranslationResourcesBase, IGameLocalizationResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public virtual string ActionClear => "Clear";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public virtual string ActionConfirm => "Confirm";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public virtual string ActionSave => "Save";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public virtual string DescriptionContentModerationError => "Error: Could not save. Please check content for moderation and try again.";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public virtual string DescriptionGeneralError => "Error: Could not save.";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public virtual string DescriptionNonSourceLanguageForm => "If no translations are provided, users will see the source language values.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public virtual string DescriptionSave => "You have unsaved changes. Are you sure you want to switch language?";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public virtual string DescriptionSaveSuccess => "Name and Description saved.";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public virtual string DescriptionSourceLanguageForm => "Source language values are shown as a reference. They can only be viewed here.";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public virtual string HeadingClear => "Clear Values";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public virtual string HeadingConfigureLocalization => "Configure Localization";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public virtual string HeadingGameNameDescriptionTranslations => "Game Name and Description Translations";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public virtual string HeadingSave => "Unsaved Changes";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public virtual string LabelDescription => "Description: ";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public virtual string LabelGameDescriptionPlaceholder => "Enter game description here";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public virtual string LabelGameInfo => "Game Info";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public virtual string LabelGameNameDescriptionTranslations => "Game Name and Description Translations";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public virtual string LabelGameNamePlaceholder => "Enter game name here (required)";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public virtual string LabelGameTitlePlaceholder => "Enter game name here";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public virtual string LabelLocalization => "Localization";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public virtual string LabelName => "Name: ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public virtual string LabelSupportedLanguages => "Supported Languages";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public virtual string LabelTabGameInfo => "Game Info";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public virtual string LabelTabLanguages => "Languages";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public virtual string LabelTabReports => "Reports";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public virtual string LabelTabSettings => "Settings";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public virtual string LabelTabTranslators => "Translators";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public virtual string LabelTitle => "Title";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public virtual string ResponseContentModerationError => "Error: Could not save. Please check content for moderation and try again.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public virtual string ResponseGeneralError => "Error: An error has occurred. Please try again later.";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public virtual string ResponseGeneralSaveError => "Error: Could not save.";

	public GameLocalizationResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Clear",
				_GetTemplateForActionClear()
			},
			{
				"Action.Confirm",
				_GetTemplateForActionConfirm()
			},
			{
				"Action.Save",
				_GetTemplateForActionSave()
			},
			{
				"Description.Clear",
				_GetTemplateForDescriptionClear()
			},
			{
				"Description.ContentModerationError",
				_GetTemplateForDescriptionContentModerationError()
			},
			{
				"Description.GeneralError",
				_GetTemplateForDescriptionGeneralError()
			},
			{
				"Description.NonSourceLanguageForm",
				_GetTemplateForDescriptionNonSourceLanguageForm()
			},
			{
				"Description.Save",
				_GetTemplateForDescriptionSave()
			},
			{
				"Description.SaveSuccess",
				_GetTemplateForDescriptionSaveSuccess()
			},
			{
				"Description.SourceLanguageForm",
				_GetTemplateForDescriptionSourceLanguageForm()
			},
			{
				"Heading.Clear",
				_GetTemplateForHeadingClear()
			},
			{
				"Heading.ConfigureLocalization",
				_GetTemplateForHeadingConfigureLocalization()
			},
			{
				"Heading.GameNameDescriptionTranslations",
				_GetTemplateForHeadingGameNameDescriptionTranslations()
			},
			{
				"Heading.Save",
				_GetTemplateForHeadingSave()
			},
			{
				"Label.Description",
				_GetTemplateForLabelDescription()
			},
			{
				"Label.GameDescriptionPlaceholder",
				_GetTemplateForLabelGameDescriptionPlaceholder()
			},
			{
				"Label.GameInfo",
				_GetTemplateForLabelGameInfo()
			},
			{
				"Label.GameNameDescriptionTranslations",
				_GetTemplateForLabelGameNameDescriptionTranslations()
			},
			{
				"Label.GameNamePlaceholder",
				_GetTemplateForLabelGameNamePlaceholder()
			},
			{
				"Label.GameTitlePlaceholder",
				_GetTemplateForLabelGameTitlePlaceholder()
			},
			{
				"Label.Localization",
				_GetTemplateForLabelLocalization()
			},
			{
				"Label.Name",
				_GetTemplateForLabelName()
			},
			{
				"Label.SupportedLanguages",
				_GetTemplateForLabelSupportedLanguages()
			},
			{
				"Label.TabGameInfo",
				_GetTemplateForLabelTabGameInfo()
			},
			{
				"Label.TabLanguages",
				_GetTemplateForLabelTabLanguages()
			},
			{
				"Label.TabReports",
				_GetTemplateForLabelTabReports()
			},
			{
				"Label.TabSettings",
				_GetTemplateForLabelTabSettings()
			},
			{
				"Label.TabTranslators",
				_GetTemplateForLabelTabTranslators()
			},
			{
				"Label.Title",
				_GetTemplateForLabelTitle()
			},
			{
				"Response.ContentModerationError",
				_GetTemplateForResponseContentModerationError()
			},
			{
				"Response.GeneralError",
				_GetTemplateForResponseGeneralError()
			},
			{
				"Response.GeneralSaveError",
				_GetTemplateForResponseGeneralSaveError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GameLocalization";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionClear()
	{
		return "Clear";
	}

	protected virtual string _GetTemplateForActionConfirm()
	{
		return "Confirm";
	}

	protected virtual string _GetTemplateForActionSave()
	{
		return "Save";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public virtual string DescriptionClear(string languageName)
	{
		return $"Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game.";
	}

	protected virtual string _GetTemplateForDescriptionClear()
	{
		return "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game.";
	}

	protected virtual string _GetTemplateForDescriptionContentModerationError()
	{
		return "Error: Could not save. Please check content for moderation and try again.";
	}

	protected virtual string _GetTemplateForDescriptionGeneralError()
	{
		return "Error: Could not save.";
	}

	protected virtual string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "If no translations are provided, users will see the source language values.";
	}

	protected virtual string _GetTemplateForDescriptionSave()
	{
		return "You have unsaved changes. Are you sure you want to switch language?";
	}

	protected virtual string _GetTemplateForDescriptionSaveSuccess()
	{
		return "Name and Description saved.";
	}

	protected virtual string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "Source language values are shown as a reference. They can only be viewed here.";
	}

	protected virtual string _GetTemplateForHeadingClear()
	{
		return "Clear Values";
	}

	protected virtual string _GetTemplateForHeadingConfigureLocalization()
	{
		return "Configure Localization";
	}

	protected virtual string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "Game Name and Description Translations";
	}

	protected virtual string _GetTemplateForHeadingSave()
	{
		return "Unsaved Changes";
	}

	protected virtual string _GetTemplateForLabelDescription()
	{
		return "Description: ";
	}

	protected virtual string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "Enter game description here";
	}

	protected virtual string _GetTemplateForLabelGameInfo()
	{
		return "Game Info";
	}

	protected virtual string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "Game Name and Description Translations";
	}

	protected virtual string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "Enter game name here (required)";
	}

	protected virtual string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "Enter game name here";
	}

	protected virtual string _GetTemplateForLabelLocalization()
	{
		return "Localization";
	}

	protected virtual string _GetTemplateForLabelName()
	{
		return "Name: ";
	}

	protected virtual string _GetTemplateForLabelSupportedLanguages()
	{
		return "Supported Languages";
	}

	protected virtual string _GetTemplateForLabelTabGameInfo()
	{
		return "Game Info";
	}

	protected virtual string _GetTemplateForLabelTabLanguages()
	{
		return "Languages";
	}

	protected virtual string _GetTemplateForLabelTabReports()
	{
		return "Reports";
	}

	protected virtual string _GetTemplateForLabelTabSettings()
	{
		return "Settings";
	}

	protected virtual string _GetTemplateForLabelTabTranslators()
	{
		return "Translators";
	}

	protected virtual string _GetTemplateForLabelTitle()
	{
		return "Title";
	}

	protected virtual string _GetTemplateForResponseContentModerationError()
	{
		return "Error: Could not save. Please check content for moderation and try again.";
	}

	protected virtual string _GetTemplateForResponseGeneralError()
	{
		return "Error: An error has occurred. Please try again later.";
	}

	protected virtual string _GetTemplateForResponseGeneralSaveError()
	{
		return "Error: Could not save.";
	}
}
