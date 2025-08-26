namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides PresenceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PresenceResources_fr_fr : PresenceResources_en_us, IPresenceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Creating"
	/// English String: "Creating"
	/// </summary>
	public override string LabelCreating => "CrÃ©ation";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "DÃ©connectÃ©";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ConnectÃ©";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "En jeu";

	public PresenceResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "CrÃ©ation";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"CrÃ©e {placeName}";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "CrÃ©e {placeName}";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "DÃ©connectÃ©";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ConnectÃ©";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "En jeu";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"Joue Ã  {placeName}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "Joue Ã  {placeName}";
	}
}


}
