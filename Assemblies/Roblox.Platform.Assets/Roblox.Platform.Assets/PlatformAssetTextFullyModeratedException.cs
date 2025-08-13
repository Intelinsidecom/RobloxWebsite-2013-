using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

/// <summary>
/// A platform exception thrown if the asset Name or Description is fully moderated. It is intended to be thrown to stop asset creation.
/// The caller should handle this exception gracefully.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.PlatformException" />
public class PlatformAssetTextFullyModeratedException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException" /> class.
	/// </summary>
	/// <param name="message">The message that carries additional details on the exeception for the callers.</param>
	public PlatformAssetTextFullyModeratedException(string message)
		: base(message)
	{
	}
}
