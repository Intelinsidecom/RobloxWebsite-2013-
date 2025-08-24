using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

/// <summary>
/// A platform exception thrown if body colors are retrieved from S3 and they contain one more more invalid brickColorIds
/// In this case, we will reset the player's body colors
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.PlatformException" />
public class PlatformIllegalBodyColorsException : PlatformException
{
	public PlatformIllegalBodyColorsException(string message)
		: base(message)
	{
	}
}
