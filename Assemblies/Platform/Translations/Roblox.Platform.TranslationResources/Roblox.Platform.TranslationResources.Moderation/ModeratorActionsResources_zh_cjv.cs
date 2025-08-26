namespace Roblox.Platform.TranslationResources.Moderation {
    /// <summary>

/// This class overrides ModeratorActionsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ModeratorActionsResources_zh_cjv : ModeratorActionsResources_en_us, IModeratorActionsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ScrubText"
	/// English String: "[ Content Deleted ]"
	/// </summary>
	public override string LabelScrubText => "[ å†…å®¹å·²åˆ é™¤ ]";

	public ModeratorActionsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelScrubText()
	{
		return "[ å†…å®¹å·²åˆ é™¤ ]";
	}
}


}
