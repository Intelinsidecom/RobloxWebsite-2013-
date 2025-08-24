using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class SupportedLanguagesResources_en_us : TranslationResourcesBase, ISupportedLanguagesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Clear"
	/// English String: "Clear"
	/// </summary>
	public virtual string ActionClear => "Clear";

	/// <summary>
	/// Key: "Description.AutomaticTextCapture"
	/// The tooltip content for Automatic Text Capture toggle button
	/// English String: "Automatically capture text from game UI while users play"
	/// </summary>
	public virtual string DescriptionAutomaticTextCapture => "Automatically capture text from game UI while users play";

	/// <summary>
	/// Key: "Description.ClearTableWarning"
	/// English String: "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically."
	/// </summary>
	public virtual string DescriptionClearTableWarning => "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically.";

	/// <summary>
	/// Key: "Description.UseTranslatedContent"
	/// The tooltip content for Use Translated Contente toggle button
	/// English String: "Enable translated content in game"
	/// </summary>
	public virtual string DescriptionUseTranslatedContent => "Enable translated content in game";

	/// <summary>
	/// Key: "Heading.AreYouSureToClear"
	/// modal heading
	/// English String: "Are you sure you want to clear entries?"
	/// </summary>
	public virtual string HeadingAreYouSureToClear => "Are you sure you want to clear entries?";

	/// <summary>
	/// Key: "Heading.InGameContentTranslations"
	/// The header for in game content translations section
	/// English String: "In Game Content Translations"
	/// </summary>
	public virtual string HeadingInGameContentTranslations => "In Game Content Translations";

	/// <summary>
	/// Key: "Label.AutomaticTextCapture"
	/// The label for toggle button that is used to enable/disable automatic text scraping for a game
	/// English String: "Automatic Text Capture: "
	/// </summary>
	public virtual string LabelAutomaticTextCapture => "Automatic Text Capture: ";

	/// <summary>
	/// Key: "Label.ClearTableEntries"
	/// English String: "Clear untranslated auto-captured strings"
	/// </summary>
	public virtual string LabelClearTableEntries => "Clear untranslated auto-captured strings";

	/// <summary>
	/// Key: "Label.CrowdsourceEnabled"
	/// Table header for the column which will display the toggle button that can by used by the user to turn on/off crowdsource translation for each language
	/// English String: "Crowdsource Enabled"
	/// </summary>
	public virtual string LabelCrowdsourceEnabled => "Crowdsource Enabled";

	/// <summary>
	/// Key: "Label.EnableAutoUITextCapture"
	/// The label for the checkbox used to turn on/off automatic UI text captrue feature
	/// English String: "Enable Auto UI Text Capture"
	/// </summary>
	public virtual string LabelEnableAutoUITextCapture => "Enable Auto UI Text Capture";

	/// <summary>
	/// Key: "Label.InProgress"
	/// supported language status for beta support in selected language
	/// English String: "In Progress"
	/// </summary>
	public virtual string LabelInProgress => "In Progress";

	/// <summary>
	/// Key: "Label.Language"
	/// Table header for the column which will display the name of each language
	/// English String: "Language"
	/// </summary>
	public virtual string LabelLanguage => "Language";

	/// <summary>
	/// Key: "Label.Languages"
	/// The heading for supported languages tab
	/// English String: "Languages"
	/// </summary>
	public virtual string LabelLanguages => "Languages";

	public virtual string LabelNotSpecified => "<Not specified>";

	/// <summary>
	/// Key: "Label.NotSupported"
	/// Label for language support status: not supported
	/// English String: "Not supported"
	/// </summary>
	public virtual string LabelNotSupported => "Not supported";

	/// <summary>
	/// Key: "Label.ShowMoreLanguages"
	/// Text for the link that user can click to display more languages in the table
	/// English String: "Show more languages..."
	/// </summary>
	public virtual string LabelShowMoreLanguages => "Show more languages...";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for section which displays user's current source language
	/// English String: "Source Language"
	/// </summary>
	public virtual string LabelSourceLanguage => "Source Language";

	/// <summary>
	/// Key: "Label.Supported"
	/// Label for language support status: supported
	/// English String: "Supported"
	/// </summary>
	public virtual string LabelSupported => "Supported";

	/// <summary>
	/// Key: "Label.SupportedBeta"
	/// Label for language support status: supported (beta)
	/// English String: "Supported (beta)"
	/// </summary>
	public virtual string LabelSupportedBeta => "Supported (beta)";

	/// <summary>
	/// Key: "Label.SupportedStatus"
	/// Table header for the column which will display the current support status for each language
	/// English String: "Supported Status"
	/// </summary>
	public virtual string LabelSupportedStatus => "Supported Status";

	/// <summary>
	/// Key: "Label.UseTranslatedContent"
	/// The label for toggle button that is used to enable/disable whether translated strings should be used in game
	/// English String: "Use Translated Content: "
	/// </summary>
	public virtual string LabelUseTranslatedContent => "Use Translated Content: ";

	/// <summary>
	/// Key: "Message.ClearTableSuccess"
	/// English String: "Confirmed. Please note that this process may take several minutes."
	/// </summary>
	public virtual string MessageClearTableSuccess => "Confirmed. Please note that this process may take several minutes.";

	/// <summary>
	/// Key: "Message.UpdateFail"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns an error
	/// English String: "An error has occurred, please try again later!"
	/// </summary>
	public virtual string MessageUpdateFail => "An error has occurred, please try again later!";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// The text of the system feedback which is displayed when the request to persist a change to a status of a language returns successfully
	/// English String: "Changes saved successfully"
	/// </summary>
	public virtual string MessageUpdateSuccess => "Changes saved successfully";

	/// <summary>
	/// Key: "Message.Updating"
	/// The text of the system feedback which is displayed when persisting a change to a status of a language
	/// English String: "Updating..."
	/// </summary>
	public virtual string MessageUpdating => "Updating...";

	/// <summary>
	/// Key: "Message.WaitAndTryAgain"
	/// English String: "Too many attempts. Please wait before trying to clear again."
	/// </summary>
	public virtual string MessageWaitAndTryAgain => "Too many attempts. Please wait before trying to clear again.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public virtual string ResponseGeneralError => "Error: An error has occurred. Please try again later.";

	/// <summary>
	/// Key: "Response.SaveConfiguration"
	/// The feedback message for user when a configuration setting change cannot be saved
	/// English String: "Error: Could not change setting. Please try again."
	/// </summary>
	public virtual string ResponseSaveConfiguration => "Error: Could not change setting. Please try again.";

	public SupportedLanguagesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Clear",
				_GetTemplateForActionClear()
			},
			{
				"Description.AutomaticTextCapture",
				_GetTemplateForDescriptionAutomaticTextCapture()
			},
			{
				"Description.ClearTableWarning",
				_GetTemplateForDescriptionClearTableWarning()
			},
			{
				"Description.CrowdsourceEnabled",
				_GetTemplateForDescriptionCrowdsourceEnabled()
			},
			{
				"Description.LocalizationStatus",
				_GetTemplateForDescriptionLocalizationStatus()
			},
			{
				"Description.SupportedStatus",
				_GetTemplateForDescriptionSupportedStatus()
			},
			{
				"Description.UseTranslatedContent",
				_GetTemplateForDescriptionUseTranslatedContent()
			},
			{
				"Heading.AreYouSureToClear",
				_GetTemplateForHeadingAreYouSureToClear()
			},
			{
				"Heading.InGameContentTranslations",
				_GetTemplateForHeadingInGameContentTranslations()
			},
			{
				"Label.AutomaticTextCapture",
				_GetTemplateForLabelAutomaticTextCapture()
			},
			{
				"Label.ClearTableEntries",
				_GetTemplateForLabelClearTableEntries()
			},
			{
				"Label.CrowdsourceEnabled",
				_GetTemplateForLabelCrowdsourceEnabled()
			},
			{
				"Label.EnableAutoUITextCapture",
				_GetTemplateForLabelEnableAutoUITextCapture()
			},
			{
				"Label.InProgress",
				_GetTemplateForLabelInProgress()
			},
			{
				"Label.Language",
				_GetTemplateForLabelLanguage()
			},
			{
				"Label.Languages",
				_GetTemplateForLabelLanguages()
			},
			{
				"Label.LocalizationStatus",
				_GetTemplateForLabelLocalizationStatus()
			},
			{
				"Label.NotSpecified",
				_GetTemplateForLabelNotSpecified()
			},
			{
				"Label.NotSupported",
				_GetTemplateForLabelNotSupported()
			},
			{
				"Label.ShowMoreLanguages",
				_GetTemplateForLabelShowMoreLanguages()
			},
			{
				"Label.SourceLanguage",
				_GetTemplateForLabelSourceLanguage()
			},
			{
				"Label.Supported",
				_GetTemplateForLabelSupported()
			},
			{
				"Label.SupportedBeta",
				_GetTemplateForLabelSupportedBeta()
			},
			{
				"Label.SupportedStatus",
				_GetTemplateForLabelSupportedStatus()
			},
			{
				"Label.UseTranslatedContent",
				_GetTemplateForLabelUseTranslatedContent()
			},
			{
				"Message.ClearTableSuccess",
				_GetTemplateForMessageClearTableSuccess()
			},
			{
				"Message.UpdateFail",
				_GetTemplateForMessageUpdateFail()
			},
			{
				"Message.UpdateSuccess",
				_GetTemplateForMessageUpdateSuccess()
			},
			{
				"Message.Updating",
				_GetTemplateForMessageUpdating()
			},
			{
				"Message.WaitAndTryAgain",
				_GetTemplateForMessageWaitAndTryAgain()
			},
			{
				"Response.GeneralError",
				_GetTemplateForResponseGeneralError()
			},
			{
				"Response.SaveConfiguration",
				_GetTemplateForResponseSaveConfiguration()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.SupportedLanguages";
	}

	protected virtual string _GetTemplateForActionClear()
	{
		return "Clear";
	}

	protected virtual string _GetTemplateForDescriptionAutomaticTextCapture()
	{
		return "Automatically capture text from game UI while users play";
	}

	protected virtual string _GetTemplateForDescriptionClearTableWarning()
	{
		return "All entries that have been automatically captured and have no translations will be cleared from your table. Note: All applicable text will be recaptured automatically.";
	}

	/// <summary>
	/// Key: "Description.CrowdsourceEnabled"
	/// Text for the tooltip that explains to user what effect it will have if the courdsource trasnlation is enable/disable for a language
	/// English String: "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)"
	/// </summary>
	public virtual string DescriptionCrowdsourceEnabled(string lineBreak)
	{
		return $"On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)";
	}

	protected virtual string _GetTemplateForDescriptionCrowdsourceEnabled()
	{
		return "On: crowdsourcing is enabled (translators can see and translate game strings){lineBreak}Off: crowdsourcing is disabled(translators cannot see or translate game strings)";
	}

	/// <summary>
	/// Key: "Description.LocalizationStatus"
	/// Text for the tooltip that explains to user how to interpret the localization status progress bar
	/// English String: "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated"
	/// </summary>
	public virtual string DescriptionLocalizationStatus(string lineBreak)
	{
		return $"Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated";
	}

	protected virtual string _GetTemplateForDescriptionLocalizationStatus()
	{
		return "Green bar: percentage of strings that have been approved{lineBreak}Blue bar: percentage of strings that have been translated";
	}

	/// <summary>
	/// Key: "Description.SupportedStatus"
	/// Text for the tooltip that explains to user what each support status means
	/// English String: "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed"
	/// </summary>
	public virtual string DescriptionSupportedStatus(string lineBreak)
	{
		return $"Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed";
	}

	protected virtual string _GetTemplateForDescriptionSupportedStatus()
	{
		return "Supported status reflects whether the language is listed on the game detail page.{lineBreak}Supported - listed{lineBreak}In Progress - listed as beta{lineBreak}Not supported - not listed";
	}

	protected virtual string _GetTemplateForDescriptionUseTranslatedContent()
	{
		return "Enable translated content in game";
	}

	protected virtual string _GetTemplateForHeadingAreYouSureToClear()
	{
		return "Are you sure you want to clear entries?";
	}

	protected virtual string _GetTemplateForHeadingInGameContentTranslations()
	{
		return "In Game Content Translations";
	}

	protected virtual string _GetTemplateForLabelAutomaticTextCapture()
	{
		return "Automatic Text Capture: ";
	}

	protected virtual string _GetTemplateForLabelClearTableEntries()
	{
		return "Clear untranslated auto-captured strings";
	}

	protected virtual string _GetTemplateForLabelCrowdsourceEnabled()
	{
		return "Crowdsource Enabled";
	}

	protected virtual string _GetTemplateForLabelEnableAutoUITextCapture()
	{
		return "Enable Auto UI Text Capture";
	}

	protected virtual string _GetTemplateForLabelInProgress()
	{
		return "In Progress";
	}

	protected virtual string _GetTemplateForLabelLanguage()
	{
		return "Language";
	}

	protected virtual string _GetTemplateForLabelLanguages()
	{
		return "Languages";
	}

	/// <summary>
	/// Key: "Label.LocalizationStatus"
	/// Table header for the column which will display the current localization progress for each language
	/// English String: "Localization Status{lineBreak}({stringCount} strings)"
	/// </summary>
	public virtual string LabelLocalizationStatus(string lineBreak, string stringCount)
	{
		return $"Localization Status{lineBreak}({stringCount} strings)";
	}

	protected virtual string _GetTemplateForLabelLocalizationStatus()
	{
		return "Localization Status{lineBreak}({stringCount} strings)";
	}

	protected virtual string _GetTemplateForLabelNotSpecified()
	{
		return "<Not specified>";
	}

	protected virtual string _GetTemplateForLabelNotSupported()
	{
		return "Not supported";
	}

	protected virtual string _GetTemplateForLabelShowMoreLanguages()
	{
		return "Show more languages...";
	}

	protected virtual string _GetTemplateForLabelSourceLanguage()
	{
		return "Source Language";
	}

	protected virtual string _GetTemplateForLabelSupported()
	{
		return "Supported";
	}

	protected virtual string _GetTemplateForLabelSupportedBeta()
	{
		return "Supported (beta)";
	}

	protected virtual string _GetTemplateForLabelSupportedStatus()
	{
		return "Supported Status";
	}

	protected virtual string _GetTemplateForLabelUseTranslatedContent()
	{
		return "Use Translated Content: ";
	}

	protected virtual string _GetTemplateForMessageClearTableSuccess()
	{
		return "Confirmed. Please note that this process may take several minutes.";
	}

	protected virtual string _GetTemplateForMessageUpdateFail()
	{
		return "An error has occurred, please try again later!";
	}

	protected virtual string _GetTemplateForMessageUpdateSuccess()
	{
		return "Changes saved successfully";
	}

	protected virtual string _GetTemplateForMessageUpdating()
	{
		return "Updating...";
	}

	protected virtual string _GetTemplateForMessageWaitAndTryAgain()
	{
		return "Too many attempts. Please wait before trying to clear again.";
	}

	protected virtual string _GetTemplateForResponseGeneralError()
	{
		return "Error: An error has occurred. Please try again later.";
	}

	protected virtual string _GetTemplateForResponseSaveConfiguration()
	{
		return "Error: Could not change setting. Please try again.";
	}
}
