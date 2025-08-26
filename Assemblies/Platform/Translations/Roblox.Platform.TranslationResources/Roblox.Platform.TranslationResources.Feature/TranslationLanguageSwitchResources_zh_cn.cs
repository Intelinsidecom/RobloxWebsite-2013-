namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_zh_cn : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "æ›´æ”¹é»˜è®¤è®¾ç½®";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "ä½ æƒ³è¦è®¾ç½®å“ªç§è¯­è¨€ä½œä¸ºé»˜è®¤è¯­è¨€ï¼Ÿ";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "åˆ é™¤";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "ä½ å¯ä»¥æŒ‡å®šé»˜è®¤è¯­è¨€å’Œæœ¬åœ°åŒ–è¯­è¨€ï¼Œä»¥ä¾¿ç”¨æˆ·å¯æŸ¥çœ‹å…¶è¯­è¨€çš„æ¸¸æˆæ ‡é¢˜å’Œæè¿°ã€‚";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "è¯·æ·»åŠ é—æ¼çš„ç¿»è¯‘";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "æ‰€æœ‰æœ¬åœ°åŒ–ä¿¡æ¯å°†è¢«åˆ é™¤ã€‚";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "ä½ æœ‰æœªä¿å­˜çš„æ›´æ”¹ã€‚æ˜¯å¦ç¡®å®šè¦ç¦»å¼€æ­¤é¡µï¼Ÿ";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* å¦‚æžœ App Store åŒºåŸŸä¸­æ²¡æœ‰å¯ç”¨çš„æœ¬åœ°åŒ–åº”ç”¨ç¨‹åºä¿¡æ¯ï¼Œåˆ™å°†ä½¿ç”¨ä½ çš„é»˜è®¤è¯­è¨€æ›¿ä»£ã€‚";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "æ·»åŠ å…¶ä»–è¯­è¨€çš„ç¿»è¯‘";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "è¦æ›´æ”¹é»˜è®¤è¯­è¨€å—ï¼Ÿ";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "æ·»åŠ ";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "æ·»åŠ å…¶ä»–è¯­è¨€";

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
	public override string LabelChange => "æ›´æ”¹";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "æ›´æ”¹ / æ·»åŠ å…¶ä»–è¯­è¨€";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "é€‰å–è¯­è¨€ä»¥æŸ¥çœ‹/ç¼–è¾‘ç¿»è¯‘ï¼š";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "å½“å‰è¯­è¨€";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "é»˜è®¤";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "åˆ é™¤";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "è¯­è¨€";

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
	public override string LabelSearchLanguages => "æœç´¢å…¶ä»–è¯­è¨€";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "è®¾ç½®é»˜è®¤è¯­è¨€";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "æº";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "åœ¨æ¸¸æˆä¿¡æ¯ä¸­æŸ¥çœ‹å¯ç”¨è¯­è¨€";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "é”™è¯¯ï¼šå‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	public TranslationLanguageSwitchResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "æ›´æ”¹é»˜è®¤è®¾ç½®";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "ä½ æƒ³è¦è®¾ç½®å“ªç§è¯­è¨€ä½œä¸ºé»˜è®¤è¯­è¨€ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "åˆ é™¤";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "ä½ å¯ä»¥æŒ‡å®šé»˜è®¤è¯­è¨€å’Œæœ¬åœ°åŒ–è¯­è¨€ï¼Œä»¥ä¾¿ç”¨æˆ·å¯æŸ¥çœ‹å…¶è¯­è¨€çš„æ¸¸æˆæ ‡é¢˜å’Œæè¿°ã€‚";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "è¯·æ·»åŠ é—æ¼çš„ç¿»è¯‘";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "æ‰€æœ‰æœ¬åœ°åŒ–ä¿¡æ¯å°†è¢«åˆ é™¤ã€‚";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "ä½ æœ‰æœªä¿å­˜çš„æ›´æ”¹ã€‚æ˜¯å¦ç¡®å®šè¦ç¦»å¼€æ­¤é¡µï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* å¦‚æžœ App Store åŒºåŸŸä¸­æ²¡æœ‰å¯ç”¨çš„æœ¬åœ°åŒ–åº”ç”¨ç¨‹åºä¿¡æ¯ï¼Œåˆ™å°†ä½¿ç”¨ä½ çš„é»˜è®¤è¯­è¨€æ›¿ä»£ã€‚";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "æ·»åŠ å…¶ä»–è¯­è¨€çš„ç¿»è¯‘";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "è¦æ›´æ”¹é»˜è®¤è¯­è¨€å—ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"è¦åˆ é™¤â€œ{languageName}â€çš„æœ¬åœ°åŒ–å—ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "è¦åˆ é™¤â€œ{languageName}â€çš„æœ¬åœ°åŒ–å—ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "æ·»åŠ ";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "æ·»åŠ å…¶ä»–è¯­è¨€";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "æ›´æ”¹";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "æ›´æ”¹ / æ·»åŠ å…¶ä»–è¯­è¨€";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "é€‰å–è¯­è¨€ä»¥æŸ¥çœ‹/ç¼–è¾‘ç¿»è¯‘ï¼š";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "å½“å‰è¯­è¨€";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "é»˜è®¤";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "åˆ é™¤";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "è¯­è¨€";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "æœªæŒ‡å®š";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "æœç´¢å…¶ä»–è¯­è¨€";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "è®¾ç½®é»˜è®¤è¯­è¨€";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "æº";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"æºè¯­è¨€ï¼ˆ{languageName}ï¼‰";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "æºè¯­è¨€ï¼ˆ{languageName}ï¼‰";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "åœ¨æ¸¸æˆä¿¡æ¯ä¸­æŸ¥çœ‹å¯ç”¨è¯­è¨€";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "é”™è¯¯ï¼šå‘ç”Ÿé”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}
}


}
