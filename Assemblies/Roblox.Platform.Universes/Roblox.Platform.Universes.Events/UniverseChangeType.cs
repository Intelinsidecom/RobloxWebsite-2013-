namespace Roblox.Platform.Universes.Events;

internal enum UniverseChangeType
{
	/// <summary>
	/// An unknown change was made
	/// </summary>
	Unknown,
	/// <summary>
	/// The name or description was changed
	/// </summary>
	NameDescription,
	/// <summary>
	/// The root place was changed
	/// </summary>
	RootPlace,
	/// <summary>
	/// A universe was created
	/// </summary>
	Created,
	/// <summary>
	/// The creator was set
	/// </summary>
	CreatorChanged,
	/// <summary>
	/// The archive status of a game was changed
	/// </summary>
	IsArchivedChanged
}
