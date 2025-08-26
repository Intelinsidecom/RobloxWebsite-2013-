namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides SocialShareResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialShareResources_ja_jp : SocialShareResources_en_us, ISocialShareResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Share"
	/// Label for share button.
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "ã‚·ã‚§ã‚¢";

	public SocialShareResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShare()
	{
		return "ã‚·ã‚§ã‚¢";
	}
}


}
