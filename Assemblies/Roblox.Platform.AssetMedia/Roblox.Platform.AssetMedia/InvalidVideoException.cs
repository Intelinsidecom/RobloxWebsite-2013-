using System;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Throws when a video URL does not refer to a valid video.
/// </summary>
public class InvalidVideoException : Exception
{
	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.InvalidVideoException" />
	/// </summary>
	public InvalidVideoException()
	{
	}

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.InvalidVideoException" />
	/// </summary>
	/// <param name="message">Exception message</param>
	public InvalidVideoException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.InvalidVideoException" />
	/// </summary>
	/// <param name="message">Exception message</param>
	/// <param name="innerException">Inner exception</param>
	public InvalidVideoException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
