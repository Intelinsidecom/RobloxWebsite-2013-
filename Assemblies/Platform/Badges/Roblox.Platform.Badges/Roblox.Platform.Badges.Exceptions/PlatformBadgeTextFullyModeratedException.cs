using Roblox.Platform.Core;

namespace Roblox.Platform.Badges.Exceptions;

/// <summary>
/// A platform exception thrown if the badge Name or Description is fully moderated. It is intended to be thrown to stop badge creation.
/// The caller should handle this exception gracefully.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.PlatformException" />
public class PlatformBadgeTextFullyModeratedException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Badges.Exceptions.PlatformBadgeTextFullyModeratedException" /> class.
	/// </summary>
	/// <param name="message">The message that carries additional details on the exeception for the callers.</param>
	public PlatformBadgeTextFullyModeratedException(string message)
		: base(message)
	{
	}
}
