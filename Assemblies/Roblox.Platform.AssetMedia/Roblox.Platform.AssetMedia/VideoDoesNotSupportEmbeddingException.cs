using System;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Thrown when a YouTube video does not support embedding.
/// </summary>
public class VideoDoesNotSupportEmbeddingException : Exception
{
	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.VideoDoesNotSupportEmbeddingException" />
	/// </summary>
	public VideoDoesNotSupportEmbeddingException()
	{
	}

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.VideoDoesNotSupportEmbeddingException" />
	/// </summary>
	/// <param name="message">Exception message</param>
	public VideoDoesNotSupportEmbeddingException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.VideoDoesNotSupportEmbeddingException" />
	/// </summary>
	/// <param name="message">Exception message</param>
	/// <param name="innerException">Inner exception</param>
	public VideoDoesNotSupportEmbeddingException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
