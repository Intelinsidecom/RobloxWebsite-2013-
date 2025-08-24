namespace Roblox.TranslationResources.Common;

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
	public override string LabelCreating => "作成中";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "オフライン";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "オンライン";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "プレイ中";

	public PresenceResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "作成中";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"{placeName} を作成中";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "{placeName} を作成中";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "オフライン";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "オンライン";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "プレイ中";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"{placeName} をプレイ中";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "{placeName} をプレイ中";
	}
}
