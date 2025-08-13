using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

/// <summary>
/// A platform exception thrown if the Group Name or Description is fully moderated. In this case we do not save the entity in the database and throw this exception.
/// The caller should handle this exception gracefully.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.PlatformException" />
public class PlatformGroupTextFullyModeratedException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Groups.PlatformGroupTextFullyModeratedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	public PlatformGroupTextFullyModeratedException(string message)
		: base(message)
	{
	}
}
