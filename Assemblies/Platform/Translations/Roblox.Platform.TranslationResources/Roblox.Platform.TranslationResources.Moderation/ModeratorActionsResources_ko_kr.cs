namespace Roblox.Platform.TranslationResources.Moderation {
    /// <summary>

/// This class overrides ModeratorActionsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ModeratorActionsResources_ko_kr : ModeratorActionsResources_en_us, IModeratorActionsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ScrubText"
	/// English String: "[ Content Deleted ]"
	/// </summary>
	public override string LabelScrubText => "[ ì½˜í…ì¸  ì‚­ì œë¨ ]";

	public ModeratorActionsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelScrubText()
	{
		return "[ ì½˜í…ì¸  ì‚­ì œë¨ ]";
	}
}


}
