namespace Roblox.Platform.Assets.Events;

internal enum AssetChangeType
{
	/// <summary>
	/// Unknown change event
	/// </summary>
	Unknown,
	/// <summary>
	/// Some text on an asset was changed.
	/// </summary>
	TextChanged,
	/// <summary>
	/// The creator was changed.
	/// </summary>
	CreatorChanged,
	/// <summary>
	/// The asset was reverted
	/// </summary>
	Reverted,
	/// <summary>
	/// The asset has a new version
	/// </summary>
	VersionChanged,
	/// <summary>
	/// The asset was archived.
	/// </summary>
	Archived,
	/// <summary>
	/// The asset was unarchived.
	/// </summary>
	Unarchived
}
