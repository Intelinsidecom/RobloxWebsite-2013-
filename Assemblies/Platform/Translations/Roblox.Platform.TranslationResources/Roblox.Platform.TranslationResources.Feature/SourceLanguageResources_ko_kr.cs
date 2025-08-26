namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides SourceLanguageResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SourceLanguageResources_ko_kr : SourceLanguageResources_en_us, ISourceLanguageResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "í™•ì¸";

	/// <summary>
	/// Key: "Description.SourceLanguage"
	/// The label for source language tooltip
	/// English String: "The source language represents the language the game has been written in."
	/// </summary>
	public override string DescriptionSourceLanguage => "ì†ŒìŠ¤ ì–¸ì–´ëŠ” ê²Œìž„ ì œìž‘ì‹œ ì‚¬ìš©ëœ ì–¸ì–´ë¥¼ ëœ»í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Heading.ChangeSourceLanguage"
	/// The modal title for change source language modal
	/// English String: "Change Source Language"
	/// </summary>
	public override string HeadingChangeSourceLanguage => "ì–¸ì–´ ë³€ê²½";

	/// <summary>
	/// Key: "Label.GameSourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Game Source Language: "
	/// </summary>
	public override string LabelGameSourceLanguage => "ê²Œìž„ ì†ŒìŠ¤ ì–¸ì–´: ";

	/// <summary>
	/// Key: "Label.NotSpecified"
	/// The label for not specified in source language dropdown
	/// English String: "Not Specified"
	/// </summary>
	public override string LabelNotSpecified => "ì§€ì •ë˜ì§€ ì•ŠìŒ";

	/// <summary>
	/// Key: "Label.SourceLanguage"
	/// The label for source language selection dropdown
	/// English String: "Source Language"
	/// </summary>
	public override string LabelSourceLanguage => "ì†ŒìŠ¤ ì–¸ì–´";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "ì˜¤ë¥˜: ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public SourceLanguageResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "í™•ì¸";
	}

	/// <summary>
	/// Key: "Description.ChangeSourceLanguage"
	/// The modal content for change source language modal
	/// English String: "Are you sure you want to change the source language of this game to {languageName}? This should reflect the language the game has been written in."
	/// </summary>
	public override string DescriptionChangeSourceLanguage(string languageName)
	{
		return $"ë³¸ ê²Œìž„ì—ì„œ ì‚¬ìš©í•  ì–¸ì–´ë¥¼ {languageName}ë¡œ ë°”ê¾¸ì‹œê² ìŠµë‹ˆê¹Œ? ê²Œìž„ì˜ ì‚¬ìš© ì–¸ì–´ê°€ ë²ˆê²½ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionChangeSourceLanguage()
	{
		return "ë³¸ ê²Œìž„ì—ì„œ ì‚¬ìš©í•  ì–¸ì–´ë¥¼ {languageName}ë¡œ ë°”ê¾¸ì‹œê² ìŠµë‹ˆê¹Œ? ê²Œìž„ì˜ ì‚¬ìš© ì–¸ì–´ê°€ ë²ˆê²½ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionSourceLanguage()
	{
		return "ì†ŒìŠ¤ ì–¸ì–´ëŠ” ê²Œìž„ ì œìž‘ì‹œ ì‚¬ìš©ëœ ì–¸ì–´ë¥¼ ëœ»í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingChangeSourceLanguage()
	{
		return "ì–¸ì–´ ë³€ê²½";
	}

	protected override string _GetTemplateForLabelGameSourceLanguage()
	{
		return "ê²Œìž„ ì†ŒìŠ¤ ì–¸ì–´: ";
	}

	protected override string _GetTemplateForLabelNotSpecified()
	{
		return "ì§€ì •ë˜ì§€ ì•ŠìŒ";
	}

	protected override string _GetTemplateForLabelSourceLanguage()
	{
		return "ì†ŒìŠ¤ ì–¸ì–´";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "ì˜¤ë¥˜: ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}
}


}
