using Roblox.Platform.Core;

namespace Roblox.Platform.Universes;

/// <summary>
/// A platform exception thrown if the Universe Name or Description is fully moderated. In this case we do not save the entity in the database and throw this exception.
/// The caller should handle this exception gracefully.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.PlatformException" />
public class PlatformUniverseTextFullyModeratedException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Universes.PlatformUniverseTextFullyModeratedException" /> class.
	/// </summary>
	public PlatformUniverseTextFullyModeratedException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Universes.PlatformUniverseTextFullyModeratedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	public PlatformUniverseTextFullyModeratedException(string message)
		: base(message)
	{
	}
}
