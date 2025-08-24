using System;

namespace Roblox.Platform.Universes;

/// <summary>
/// An exception thrown if the Universe Name or Description is partially moderated.
/// </summary>
public class UniverseTextPartiallyModeratedException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Universes.UniverseTextPartiallyModeratedException" /> class.
	/// </summary>
	public UniverseTextPartiallyModeratedException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Universes.UniverseTextPartiallyModeratedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	public UniverseTextPartiallyModeratedException(string message)
		: base(message)
	{
	}
}
