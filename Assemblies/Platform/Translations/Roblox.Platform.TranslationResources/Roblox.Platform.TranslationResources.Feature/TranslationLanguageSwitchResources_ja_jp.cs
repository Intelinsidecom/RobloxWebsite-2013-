namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_ja_jp : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆã®å¤‰æ›´";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "ã©ã®è¨€èªžã‚’ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã«è¨­å®šã—ã¾ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "å‰Šé™¤";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã¨ç¿»è¨³è¨€èªžã‚’æŒ‡å®šã™ã‚‹ã¨ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒã‚²ãƒ¼ãƒ ã‚¿ã‚¤ãƒˆãƒ«ã¨è©³ç´°ã‚’ç¾åœ°ã®è¨€èªžã§è¦‹ã‚Œã‚‹ã‚ˆã†ã«ã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "æ¬ è½ã—ã¦ã„ã‚‹ç¿»è¨³ã‚’è¿½åŠ ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "ç¿»è¨³æ¸ˆã¿ãƒ‡ãƒ¼ã‚¿ãŒã™ã¹ã¦å‰Šé™¤ã•ã‚Œã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "ä¿å­˜ã—ã¦ã„ãªã„å¤‰æ›´ãŒã‚ã‚Šã¾ã™ã€‚ã“ã®ãƒšãƒ¼ã‚¸ã‚’çµ‚äº†ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* App Storeã®åœ°åŸŸã§ã€ç¿»è¨³æ¸ˆã¿ã‚¢ãƒ—ãƒªæƒ…å ±ãŒåˆ©ç”¨ã§ããªã„å ´åˆã€ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã®æƒ…å ±ãŒä»£ã‚ã‚Šã«ä½¿ã‚ã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "åˆ¥ã®è¨€èªžã®ç¿»è¨³ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã‚’å¤‰æ›´ã—ã¾ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "è¿½åŠ ";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "ä»–ã®è¨€èªžã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public override string LabelChange => "å¤‰æ›´";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "ä»–ã®è¨€èªžã«å¤‰æ›´/ä»–ã®è¨€èªžã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "ç¿»è¨³ã®ç¢ºèª/ç·¨é›†ã‚’è¡Œã†è¨€èªžã‚’é¸æŠž: ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "ç¾åœ¨ã®è¨€èªž";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆ";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "å‰Šé™¤";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "è¨€èªž";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public override string LabelNotSpecified => "æŒ‡å®šã•ã‚Œã¦ã„ã¾ã›ã‚“";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "ä»–ã®è¨€èªžã‚’æ¤œç´¢";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã‚’è¨­å®šã™ã‚‹";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "ã‚½ãƒ¼ã‚¹";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "ã‚²ãƒ¼ãƒ æƒ…å ±ã§è¨€èªžã‚’è¡¨ç¤º";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ã‚¨ãƒ©ãƒ¼: ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public TranslationLanguageSwitchResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆã®å¤‰æ›´";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "ã©ã®è¨€èªžã‚’ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã«è¨­å®šã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "å‰Šé™¤";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã¨ç¿»è¨³è¨€èªžã‚’æŒ‡å®šã™ã‚‹ã¨ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒã‚²ãƒ¼ãƒ ã‚¿ã‚¤ãƒˆãƒ«ã¨è©³ç´°ã‚’ç¾åœ°ã®è¨€èªžã§è¦‹ã‚Œã‚‹ã‚ˆã†ã«ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "æ¬ è½ã—ã¦ã„ã‚‹ç¿»è¨³ã‚’è¿½åŠ ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "ç¿»è¨³æ¸ˆã¿ãƒ‡ãƒ¼ã‚¿ãŒã™ã¹ã¦å‰Šé™¤ã•ã‚Œã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "ä¿å­˜ã—ã¦ã„ãªã„å¤‰æ›´ãŒã‚ã‚Šã¾ã™ã€‚ã“ã®ãƒšãƒ¼ã‚¸ã‚’çµ‚äº†ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* App Storeã®åœ°åŸŸã§ã€ç¿»è¨³æ¸ˆã¿ã‚¢ãƒ—ãƒªæƒ…å ±ãŒåˆ©ç”¨ã§ããªã„å ´åˆã€ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã®æƒ…å ±ãŒä»£ã‚ã‚Šã«ä½¿ã‚ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "åˆ¥ã®è¨€èªžã®ç¿»è¨³ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã‚’å¤‰æ›´ã—ã¾ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"{languageName}ã®ç¿»è¨³ã‚’å‰Šé™¤ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "{languageName}ã®ç¿»è¨³ã‚’å‰Šé™¤ã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "è¿½åŠ ";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "ä»–ã®è¨€èªžã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "å¤‰æ›´";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "ä»–ã®è¨€èªžã«å¤‰æ›´/ä»–ã®è¨€èªžã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "ç¿»è¨³ã®ç¢ºèª/ç·¨é›†ã‚’è¡Œã†è¨€èªžã‚’é¸æŠž: ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "ç¾åœ¨ã®è¨€èªž";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆ";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "å‰Šé™¤";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "è¨€èªž";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "æŒ‡å®šã•ã‚Œã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "ä»–ã®è¨€èªžã‚’æ¤œç´¢";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "ãƒ‡ãƒ•ã‚©ãƒ«ãƒˆè¨€èªžã‚’è¨­å®šã™ã‚‹";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "ã‚½ãƒ¼ã‚¹";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"ã‚½ãƒ¼ã‚¹ï¼ˆ{languageName}ï¼‰";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "ã‚½ãƒ¼ã‚¹ï¼ˆ{languageName}ï¼‰";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "ã‚²ãƒ¼ãƒ æƒ…å ±ã§è¨€èªžã‚’è¡¨ç¤º";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ã‚¨ãƒ©ãƒ¼: ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}
}


}
