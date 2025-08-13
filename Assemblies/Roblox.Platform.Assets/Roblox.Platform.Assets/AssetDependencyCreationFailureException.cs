using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

/// <summary>
/// A platform exception thrown when the creation of a dependency in the asset dependencies service fails. It is intended to be thrown to stop asset creation.
/// </summary>
/// <inheritdoc cref="T:Roblox.Platform.Core.PlatformException" />
public class AssetDependencyCreationFailureException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Assets.AssetDependencyCreationFailureException" /> class.
	/// </summary>
	/// <param name="message">The message that carries additional details on the exeception for the callers.</param>
	public AssetDependencyCreationFailureException(string message)
		: base(message)
	{
	}
}
