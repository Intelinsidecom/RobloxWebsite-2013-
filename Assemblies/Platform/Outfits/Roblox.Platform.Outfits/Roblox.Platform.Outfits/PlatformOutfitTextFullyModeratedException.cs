using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

/// <summary>
/// A platform exception thrown if the Outfit Name is fully moderated. In this case we do not save the entity in the database and throw this exception.
/// The caller should handle this exception gracefully.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.PlatformException" />
public class PlatformOutfitTextFullyModeratedException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Outfits.PlatformOutfitTextFullyModeratedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	public PlatformOutfitTextFullyModeratedException(string message)
		: base(message)
	{
	}
}
