namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides PresenceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PresenceResources_de_de : PresenceResources_en_us, IPresenceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Creating"
	/// English String: "Creating"
	/// </summary>
	public override string LabelCreating => "Erstellen";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Offline";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "Online";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "Spielt";

	public PresenceResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "Erstellen";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"Erstellt {placeName}";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "Erstellt {placeName}";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Offline";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "Online";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "Spielt";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"Spielt {placeName}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "Spielt {placeName}";
	}
}
