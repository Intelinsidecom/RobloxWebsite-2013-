namespace Roblox.Platform.Universes.Properties;

internal interface ISettings
{
	bool IsSettingUniversePrivacyTypeToPrivateOnMissingRootPlaceIdEnabled { get; }

	/// <summary>
	/// Gets the default universe privacy type.
	/// </summary>
	string DefaultUniversePrivacyType { get; }
}
