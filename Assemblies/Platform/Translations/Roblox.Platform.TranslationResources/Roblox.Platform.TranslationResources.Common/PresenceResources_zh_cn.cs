namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides PresenceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PresenceResources_zh_cn : PresenceResources_en_us, IPresenceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Creating"
	/// English String: "Creating"
	/// </summary>
	public override string LabelCreating => "正在创建";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "离线";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "在线";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "正在游戏";

	public PresenceResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelCreating()
	{
		return "正在创建";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public override string LabelCreatingGame(string placeName)
	{
		return $"正在创建“{placeName}”";
	}

	protected override string _GetTemplateForLabelCreatingGame()
	{
		return "正在创建“{placeName}”";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "离线";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "在线";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "正在游戏";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public override string LabelPlayingGame(string placeName)
	{
		return $"正在“{placeName}”玩";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "正在“{placeName}”玩";
	}
}
