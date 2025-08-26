namespace Roblox.Platform.TranslationResources.Moderation {
    /// <summary>

/// This class overrides ModeratorActionsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ModeratorActionsResources_ja_jp : ModeratorActionsResources_en_us, IModeratorActionsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ScrubText"
	/// English String: "[ Content Deleted ]"
	/// </summary>
	public override string LabelScrubText => "[ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒå‰Šé™¤ã•ã‚Œã¾ã—ãŸ]";

	public ModeratorActionsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelScrubText()
	{
		return "[ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ãŒå‰Šé™¤ã•ã‚Œã¾ã—ãŸ]";
	}
}


}
