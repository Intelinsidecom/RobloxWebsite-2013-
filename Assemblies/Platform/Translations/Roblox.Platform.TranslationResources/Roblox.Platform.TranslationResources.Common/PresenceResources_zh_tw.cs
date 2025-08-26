namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides PresenceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PresenceResources_zh_tw : PresenceResources_en_us, IPresenceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Creating"
	/// English String: "Creating"
	/// </summary>
	public override string LabelCreating => "æ­£åœ¨å»ºç«‹";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "é›¢ç·š";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "åœ¨ç·š";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "æ­£åœ¨çŽ©";

	public PresenceResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "æ­£åœ¨å»ºç«‹";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"æ­£åœ¨å»ºç«‹{placeName}";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "æ­£åœ¨å»ºç«‹{placeName}";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "é›¢ç·š";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "åœ¨ç·š";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "æ­£åœ¨çŽ©";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"æ­£åœ¨çŽ© {placeName}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "æ­£åœ¨çŽ© {placeName}";
	}
}


}
