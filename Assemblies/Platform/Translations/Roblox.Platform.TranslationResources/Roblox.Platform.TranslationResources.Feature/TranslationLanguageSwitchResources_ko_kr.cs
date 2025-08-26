namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides TranslationLanguageSwitchResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationLanguageSwitchResources_ko_kr : TranslationLanguageSwitchResources_en_us, ITranslationLanguageSwitchResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.ChangeDefault"
	/// The label for the gear icon which is used to open the modal for changing default language
	/// English String: "Change default"
	/// </summary>
	public override string DescriptionChangeDefault => "ê¸°ë³¸ê°’ ë³€ê²½";

	/// <summary>
	/// Key: "Description.ChangeDefaultLanguage"
	/// The body content for the modal which is used to change default language
	/// English String: "What language do you want to set as default language?"
	/// </summary>
	public override string DescriptionChangeDefaultLanguage => "ì–´ë–¤ ì–¸ì–´ë¥¼ ê¸°ë³¸ ì–¸ì–´ë¡œ ì„¤ì •í• ê¹Œìš”?";

	/// <summary>
	/// Key: "Description.Delete"
	/// The label for the trash bin icon which is used to open the modal for deleting a language
	/// English String: "Delete"
	/// </summary>
	public override string DescriptionDelete => "ì‚­ì œ";

	/// <summary>
	/// Key: "Description.LanguageSwitch"
	/// The tooltip description to explain what the language switch is
	/// English String: "You can specify default and localized language, so that user can see game title and description in their language."
	/// </summary>
	public override string DescriptionLanguageSwitch => "ê²Œìž„ ì œëª© ë° ì„¤ëª…ì„ ì‚¬ìš©ìžì˜ ì–¸ì–´ë¡œ ë³¼ ìˆ˜ ìžˆë„ë¡ ê¸°ë³¸ ì–¸ì–´ ë° ì‚¬ìš© ì–¸ì–´ë¥¼ ì„¤ì •í•  ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Description.MissingTranslation"
	/// The eror text when user has entered invalid information for some languages
	/// English String: "Please add missing translations(s)"
	/// </summary>
	public override string DescriptionMissingTranslation => "ë¹ ì§„ ë²ˆì—­ì„ ì¶”ê°€í•´ì£¼ì„¸ìš”";

	/// <summary>
	/// Key: "Description.RemoveLanguage"
	/// The body content for the modal which is used to delete a language
	/// English String: "All localized information will be deleted."
	/// </summary>
	public override string DescriptionRemoveLanguage => "ëª¨ë“  ë¡œì»¬ë¦¬ì œì´ì…˜ ì •ë³´ê°€ ì‚­ì œë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for save confirmation modal
	/// English String: "You have unsaved changes. Are you sure you want to leave this page?"
	/// </summary>
	public override string DescriptionSave => "ì €ìž¥ë˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­ì´ ìžˆìŠµë‹ˆë‹¤. ì •ë§ íŽ˜ì´ì§€ë¥¼ ë‚˜ê°€ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Description.UseDefault"
	/// The hint text in the body content of the model which is used to change default language
	/// English String: "* If localized app information isn't available in an App Store territory, the information from your default language will be used instead."
	/// </summary>
	public override string DescriptionUseDefault => "* ë²ˆì—­ëœ ì•± ì •ë³´ë¥¼ í•´ë‹¹ App Store ì§€ì—­ì—ì„œ ì‚¬ìš©í•  ìˆ˜ ì—†ëŠ” ê²½ìš°, ì„¤ì •í•˜ì‹  ê¸°ë³¸ ì–¸ì–´ê°€ ëŒ€ì‹  ì‚¬ìš©ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Heading.AddLanguage"
	/// The title for the modal which is used to add new languages
	/// English String: "Add translations in other language(s)"
	/// </summary>
	public override string HeadingAddLanguage => "ë‹¤ë¥¸ ì–¸ì–´ë¡œ ë²ˆì—­ ì¶”ê°€";

	/// <summary>
	/// Key: "Heading.ChangeDefault"
	/// The title for the modal which is used to change default language
	/// English String: "Change the default language?"
	/// </summary>
	public override string HeadingChangeDefault => "ê¸°ë³¸ ì–¸ì–´ë¡œ ë³€ê²½í• ê¹Œìš”?";

	/// <summary>
	/// Key: "Label.Add"
	/// The label for the button in the modal which is used to add new languages
	/// English String: "Add"
	/// </summary>
	public override string LabelAdd => "ì¶”ê°€";

	/// <summary>
	/// Key: "Label.AddAnotherLanguage"
	/// The label for the dropdown menu option that is used open up a modal for user to add new languages
	/// English String: "Add another language"
	/// </summary>
	public override string LabelAddAnotherLanguage => "ë‹¤ë¥¸ ì–¸ì–´ ì¶”ê°€";

	/// <summary>
	/// Key: "Label.Cancel"
	/// The label for the button in the modal which is used to dismiss the modal
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.Change"
	/// The label for the button in the modal which is used to change default language
	/// English String: "Change"
	/// </summary>
	public override string LabelChange => "ë³€ê²½";

	/// <summary>
	/// Key: "Label.ChangeAddLanguages"
	/// The label for the link which is used to open up a modal for user to add new languages
	/// English String: "Change / add in other language(s)"
	/// </summary>
	public override string LabelChangeAddLanguages => "ì–¸ì–´ ë³€ê²½ / ì¶”ê°€";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// The label for current language selection dropdown
	/// English String: "Choose a language to view/edit translations: "
	/// </summary>
	public override string LabelChooseLanguage => "ë²ˆì—­ì„ í™•ì¸/ìˆ˜ì •í•  ì–¸ì–´ ì„ íƒ: ";

	/// <summary>
	/// Key: "Label.CurrentLanguage"
	/// The label for the field that displays user's current language
	/// English String: "Current Language"
	/// </summary>
	public override string LabelCurrentLanguage => "í˜„ìž¬ ì–¸ì–´";

	/// <summary>
	/// Key: "Label.Default"
	/// The label for user's default language
	/// English String: "Default"
	/// </summary>
	public override string LabelDefault => "ê¸°ë³¸ê°’";

	/// <summary>
	/// Key: "Label.Delete"
	/// The label for the button in the modal which is used to delete a language
	/// English String: "Delete"
	/// </summary>
	public override string LabelDelete => "ì‚­ì œ";

	/// <summary>
	/// Key: "Label.Language"
	/// The label for the language switch dropdown
	/// English String: "Language"
	/// </summary>
	public override string LabelLanguage => "ì–¸ì–´";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for current language field when user hasn't specified a language yet
	/// English String: "Not specified"
	/// </summary>
	public override string LabelNotSpecified => "ì§€ì •ë˜ì§€ ì•ŠìŒ";

	/// <summary>
	/// Key: "Label.SearchLanguages"
	/// The placeholder for the search bar in the add languages modal
	/// English String: "Search other languages"
	/// </summary>
	public override string LabelSearchLanguages => "ë‹¤ë¥¸ ì–¸ì–´ ê²€ìƒ‰";

	/// <summary>
	/// Key: "Label.SetDefaultLanguage"
	/// The label for the link which is used to open up a modal for user to set a default language for the very first time
	/// English String: "Set default language"
	/// </summary>
	public override string LabelSetDefaultLanguage => "ê¸°ë³¸ ì–¸ì–´ ì„¤ì •";

	/// <summary>
	/// Key: "Label.Source"
	/// The label for the soure language in the dropdown
	/// English String: "Source"
	/// </summary>
	public override string LabelSource => "ì†ŒìŠ¤";

	/// <summary>
	/// Key: "Label.ViewGameInfoForLanguage"
	/// The label for current language selection dropdown
	/// English String: "View Game Info for language"
	/// </summary>
	public override string LabelViewGameInfoForLanguage => "ì–¸ì–´ì— ëŒ€í•œ ê²Œìž„ ì •ë³´ ë³´ê¸°";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ì˜¤ë¥˜: ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public TranslationLanguageSwitchResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionChangeDefault()
	{
		return "ê¸°ë³¸ê°’ ë³€ê²½";
	}

	protected override string _GetTemplateForDescriptionChangeDefaultLanguage()
	{
		return "ì–´ë–¤ ì–¸ì–´ë¥¼ ê¸°ë³¸ ì–¸ì–´ë¡œ ì„¤ì •í• ê¹Œìš”?";
	}

	protected override string _GetTemplateForDescriptionDelete()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForDescriptionLanguageSwitch()
	{
		return "ê²Œìž„ ì œëª© ë° ì„¤ëª…ì„ ì‚¬ìš©ìžì˜ ì–¸ì–´ë¡œ ë³¼ ìˆ˜ ìžˆë„ë¡ ê¸°ë³¸ ì–¸ì–´ ë° ì‚¬ìš© ì–¸ì–´ë¥¼ ì„¤ì •í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForDescriptionMissingTranslation()
	{
		return "ë¹ ì§„ ë²ˆì—­ì„ ì¶”ê°€í•´ì£¼ì„¸ìš”";
	}

	protected override string _GetTemplateForDescriptionRemoveLanguage()
	{
		return "ëª¨ë“  ë¡œì»¬ë¦¬ì œì´ì…˜ ì •ë³´ê°€ ì‚­ì œë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "ì €ìž¥ë˜ì§€ ì•Šì€ ë³€ê²½ ì‚¬í•­ì´ ìžˆìŠµë‹ˆë‹¤. ì •ë§ íŽ˜ì´ì§€ë¥¼ ë‚˜ê°€ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForDescriptionUseDefault()
	{
		return "* ë²ˆì—­ëœ ì•± ì •ë³´ë¥¼ í•´ë‹¹ App Store ì§€ì—­ì—ì„œ ì‚¬ìš©í•  ìˆ˜ ì—†ëŠ” ê²½ìš°, ì„¤ì •í•˜ì‹  ê¸°ë³¸ ì–¸ì–´ê°€ ëŒ€ì‹  ì‚¬ìš©ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingAddLanguage()
	{
		return "ë‹¤ë¥¸ ì–¸ì–´ë¡œ ë²ˆì—­ ì¶”ê°€";
	}

	protected override string _GetTemplateForHeadingChangeDefault()
	{
		return "ê¸°ë³¸ ì–¸ì–´ë¡œ ë³€ê²½í• ê¹Œìš”?";
	}

	/// <summary>
	/// Key: "Heading.RemoveLanguage"
	/// The title for the modal which is used to delete a language
	/// English String: "Delete the {languageName} localization?"
	/// </summary>
	public override string HeadingRemoveLanguage(string languageName)
	{
		return $"{languageName} ë¡œì»¬ë¦¬ì œì´ì…˜ì„ ì‚­ì œí• ê¹Œìš”?";
	}

	protected override string _GetTemplateForHeadingRemoveLanguage()
	{
		return "{languageName} ë¡œì»¬ë¦¬ì œì´ì…˜ì„ ì‚­ì œí• ê¹Œìš”?";
	}

	protected override string _GetTemplateForLabelAdd()
	{
		return "ì¶”ê°€";
	}

	protected override string _GetTemplateForLabelAddAnotherLanguage()
	{
		return "ë‹¤ë¥¸ ì–¸ì–´ ì¶”ê°€";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForLabelChange()
	{
		return "ë³€ê²½";
	}

	protected override string _GetTemplateForLabelChangeAddLanguages()
	{
		return "ì–¸ì–´ ë³€ê²½ / ì¶”ê°€";
	}

	protected override string _GetTemplateForLabelChooseLanguage()
	{
		return "ë²ˆì—­ì„ í™•ì¸/ìˆ˜ì •í•  ì–¸ì–´ ì„ íƒ: ";
	}

	protected override string _GetTemplateForLabelCurrentLanguage()
	{
		return "í˜„ìž¬ ì–¸ì–´";
	}

	protected override string _GetTemplateForLabelDefault()
	{
		return "ê¸°ë³¸ê°’";
	}

	protected override string _GetTemplateForLabelDelete()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForLabelLanguage()
	{
		return "ì–¸ì–´";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "ì§€ì •ë˜ì§€ ì•ŠìŒ";
	}

	protected override string _GetTemplateForLabelSearchLanguages()
	{
		return "ë‹¤ë¥¸ ì–¸ì–´ ê²€ìƒ‰";
	}

	protected override string _GetTemplateForLabelSetDefaultLanguage()
	{
		return "ê¸°ë³¸ ì–¸ì–´ ì„¤ì •";
	}

	protected override string _GetTemplateForLabelSource()
	{
		return "ì†ŒìŠ¤";
	}

	/// <summary>
	/// Key: "Label.SourceWithLanguageName"
	/// The label for source language in Game Info selection dropdown
	/// English String: "Source ({languageName})"
	/// </summary>
	public override string LabelSourceWithLanguageName(string languageName)
	{
		return $"ì†ŒìŠ¤ ({languageName})";
	}

	protected override string _GetTemplateForLabelSourceWithLanguageName()
	{
		return "ì†ŒìŠ¤ ({languageName})";
	}

	protected override string _GetTemplateForLabelViewGameInfoForLanguage()
	{
		return "ì–¸ì–´ì— ëŒ€í•œ ê²Œìž„ ì •ë³´ ë³´ê¸°";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ì˜¤ë¥˜: ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}
}


}
