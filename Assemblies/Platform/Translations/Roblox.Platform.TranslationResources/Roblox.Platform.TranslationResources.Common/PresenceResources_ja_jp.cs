namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides PresenceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PresenceResources_ja_jp : PresenceResources_en_us, IPresenceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Creating"
	/// English String: "Creating"
	/// </summary>
	public override string LabelCreating => "ä½œæˆä¸­";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ã‚ªãƒ•ãƒ©ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "ãƒ—ãƒ¬ã‚¤ä¸­";

	public PresenceResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "ä½œæˆä¸­";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"{placeName} ã‚’ä½œæˆä¸­";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "{placeName} ã‚’ä½œæˆä¸­";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ã‚ªãƒ•ãƒ©ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "ãƒ—ãƒ¬ã‚¤ä¸­";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"{placeName} ã‚’ãƒ—ãƒ¬ã‚¤ä¸­";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "{placeName} ã‚’ãƒ—ãƒ¬ã‚¤ä¸­";
	}
}


}
