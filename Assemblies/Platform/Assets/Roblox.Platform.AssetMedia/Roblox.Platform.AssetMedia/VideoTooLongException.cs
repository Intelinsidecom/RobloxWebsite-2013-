using System;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Thrown when a video duration is longer than allowed.
/// </summary>
public class VideoTooLongException : Exception
{
	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.VideoTooLongException" />
	/// </summary>
	public VideoTooLongException()
	{
	}

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.VideoTooLongException" />
	/// </summary>
	/// <param name="message">Exception message</param>
	public VideoTooLongException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.VideoTooLongException" />
	/// </summary>
	/// <param name="message">Exception message</param>
	/// <param name="innerException">Inner exception</param>
	public VideoTooLongException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
