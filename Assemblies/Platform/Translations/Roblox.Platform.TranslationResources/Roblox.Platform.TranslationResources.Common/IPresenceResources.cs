namespace Roblox.TranslationResources.Common;

public interface IPresenceResources : ITranslationResources
{
	/// <summary>
	/// Key: "Label.Creating"
	/// English String: "Creating"
	/// </summary>
	string LabelCreating { get; }

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	string LabelOffline { get; }

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	string LabelOnline { get; }

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	string LabelPlaying { get; }

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	string LabelCreatingGame(string placeName);

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	string LabelPlayingGame(string placeName);
}
