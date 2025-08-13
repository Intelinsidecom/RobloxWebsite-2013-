using System;

namespace Roblox.Platform.Core;

/// <summary>
/// The exception that is thrown for invalid casting or explicit conversion.
/// </summary>
public class PlatformInvalidCastException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformInvalidCastException" /> class.
	/// </summary>
	public PlatformInvalidCastException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformInvalidCastException" /> class with the given error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public PlatformInvalidCastException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformInvalidCastException" /> class with
	/// the given error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public PlatformInvalidCastException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
