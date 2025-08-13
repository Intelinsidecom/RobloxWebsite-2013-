namespace Roblox.TranslationResources.Common;

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
	public override string LabelCreating => "만들기 중";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "오프라인";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "온라인";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "플레이 중";

	public PresenceResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "만들기 중";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"{placeName} 만들기 중";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "{placeName} 만들기 중";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "오프라인";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "온라인";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "플레이 중";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"{placeName} 플레이 중";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "{placeName} 플레이 중";
	}
}
