namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_zh_tw : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "è®Šæ›´é è¨­";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "æ‚¨æƒ³è¦å°‡å“ªä¸€ç¨®èªžè¨€è¨­ç‚ºé è¨­èªžè¨€ï¼Ÿ";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "åˆªé™¤";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "æ‚¨å¯ä»¥æŒ‡å®šé è¨­å’Œæœ¬åœ°åŒ–çš„èªžè¨€ï¼Œä½¿å…¶å®ƒä½¿ç”¨è€…å¯ä»¥çœ‹åˆ°å…¶èªžè¨€çš„éŠæˆ²æ¨™é¡Œå’Œèªªæ˜Žã€‚";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "è«‹æ–°å¢žéºæ¼çš„ç¿»è­¯";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "å°‡åˆªé™¤æ‰€æœ‰æœ¬åœ°åŒ–è³‡è¨Šã€‚";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "æ‚¨æœ‰æœªå„²å­˜çš„è®Šæ›´ã€‚ç¢ºå®šé›¢é–‹æ­¤é é¢ï¼Ÿ";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "ï¼Šè‹¥ App Store å€åŸŸæ²’æœ‰æœ¬åœ°åŒ– App è³‡è¨Šï¼Œæˆ‘å€‘å°‡æœƒä½¿ç”¨æ‚¨çš„é è¨­èªžè¨€çš„è³‡è¨Šã€‚";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "æ–°å¢žå…¶å®ƒèªžè¨€çš„ç¿»è­¯";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "è¦è®Šæ›´é è¨­èªžè¨€å—Žï¼Ÿ";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "æ–°å¢ž";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "æ–°å¢žå…¶å®ƒèªžè¨€";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public override string LabelChange => "è®Šæ›´";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "è®Šæ›´ / æ–°å¢žå…¶å®ƒèªžè¨€";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "é¸æ“‡ä¸€ç¨®èªžè¨€é–‹å§‹æª¢è¦–åŠç·¨è¼¯ç¿»è­¯ï¼š ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "ç›®å‰èªžè¨€";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "é è¨­";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "åˆªé™¤";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "èªžè¨€";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public override string LabelNotSpecified => "æœªæŒ‡å®š";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "æœå°‹å…¶å®ƒèªžè¨€";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "è¨­å®šé è¨­èªžè¨€";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "ä¾†æº";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "æª¢è¦–éŠæˆ²è³‡è¨ŠæŸ¥çœ‹å¯ç”¨èªžè¨€";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "éŒ¯èª¤ï¼šç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	public TranslationLanguageSwitchResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "è®Šæ›´é è¨­";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "æ‚¨æƒ³è¦å°‡å“ªä¸€ç¨®èªžè¨€è¨­ç‚ºé è¨­èªžè¨€ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "åˆªé™¤";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "æ‚¨å¯ä»¥æŒ‡å®šé è¨­å’Œæœ¬åœ°åŒ–çš„èªžè¨€ï¼Œä½¿å…¶å®ƒä½¿ç”¨è€…å¯ä»¥çœ‹åˆ°å…¶èªžè¨€çš„éŠæˆ²æ¨™é¡Œå’Œèªªæ˜Žã€‚";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "è«‹æ–°å¢žéºæ¼çš„ç¿»è­¯";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "å°‡åˆªé™¤æ‰€æœ‰æœ¬åœ°åŒ–è³‡è¨Šã€‚";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "æ‚¨æœ‰æœªå„²å­˜çš„è®Šæ›´ã€‚ç¢ºå®šé›¢é–‹æ­¤é é¢ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "ï¼Šè‹¥ App Store å€åŸŸæ²’æœ‰æœ¬åœ°åŒ– App è³‡è¨Šï¼Œæˆ‘å€‘å°‡æœƒä½¿ç”¨æ‚¨çš„é è¨­èªžè¨€çš„è³‡è¨Šã€‚";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "æ–°å¢žå…¶å®ƒèªžè¨€çš„ç¿»è­¯";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "è¦è®Šæ›´é è¨­èªžè¨€å—Žï¼Ÿ";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"è¦åˆªé™¤{languageName}ç¿»è­¯å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "è¦åˆªé™¤{languageName}ç¿»è­¯å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "æ–°å¢ž";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "æ–°å¢žå…¶å®ƒèªžè¨€";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "è®Šæ›´";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "è®Šæ›´ / æ–°å¢žå…¶å®ƒèªžè¨€";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "é¸æ“‡ä¸€ç¨®èªžè¨€é–‹å§‹æª¢è¦–åŠç·¨è¼¯ç¿»è­¯ï¼š ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "ç›®å‰èªžè¨€";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "é è¨­";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "åˆªé™¤";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "èªžè¨€";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "æœªæŒ‡å®š";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "æœå°‹å…¶å®ƒèªžè¨€";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "è¨­å®šé è¨­èªžè¨€";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "ä¾†æº";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"ä¾†æºèªžè¨€ï¼ˆ{languageName}ï¼‰";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "ä¾†æºèªžè¨€ï¼ˆ{languageName}ï¼‰";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "æª¢è¦–éŠæˆ²è³‡è¨ŠæŸ¥çœ‹å¯ç”¨èªžè¨€";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "éŒ¯èª¤ï¼šç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}
}


}
