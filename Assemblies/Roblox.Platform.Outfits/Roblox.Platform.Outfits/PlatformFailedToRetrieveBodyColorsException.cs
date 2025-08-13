using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

/// <summary>
/// A platform exception thrown if body colors fail to be downloaded from Amazon S3
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.PlatformException" />
public class PlatformFailedToRetrieveBodyColorsException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Outfits.PlatformFailedToRetrieveBodyColorsException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException"></param>
	public PlatformFailedToRetrieveBodyColorsException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
