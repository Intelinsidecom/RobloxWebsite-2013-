namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides PresenceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PresenceResources_ko_kr : PresenceResources_en_us, IPresenceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Creating"
	/// English String: "Creating"
	/// </summary>
	public override string LabelCreating => "ë§Œë“¤ê¸° ì¤‘";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ì˜¤í”„ë¼ì¸";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ì˜¨ë¼ì¸";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "í”Œë ˆì´ ì¤‘";

	public PresenceResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "ë§Œë“¤ê¸° ì¤‘";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"{placeName} ë§Œë“¤ê¸° ì¤‘";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "{placeName} ë§Œë“¤ê¸° ì¤‘";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ì˜¤í”„ë¼ì¸";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ì˜¨ë¼ì¸";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "í”Œë ˆì´ ì¤‘";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"{placeName} í”Œë ˆì´ ì¤‘";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "{placeName} í”Œë ˆì´ ì¤‘";
	}
}


}
