namespace Roblox.TranslationResources.Common;

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
	public override string LabelCreating => "正在建立";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "離線";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "在線";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "正在玩";

	public PresenceResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "正在建立";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"正在建立{placeName}";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "正在建立{placeName}";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "離線";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "在線";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "正在玩";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"正在玩 {placeName}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "正在玩 {placeName}";
	}
}
