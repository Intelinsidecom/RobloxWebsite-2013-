namespace Roblox.Platform.UserSetting;

/// <summary>
/// Encapsulates the User's Settings data.
/// </summary>
public interface IUserSettings
{
	/// <summary>
	/// Does this user have the switch that enforces only curated games can be played?
	/// </summary>
	bool CuratedGamesOnlyIsEnabled { get; }

	/// <summary>
	/// Update the value of the CuratedGamesOnly switch.
	/// </summary>
	/// <param name="value"></param>
	void UpdateCuratedGamesOnlyIsEnabled(bool value);
}
