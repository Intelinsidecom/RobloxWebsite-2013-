using System;

namespace Roblox.Platform.Core;

/// <summary>
/// Exception thrown when a method argument is invalid.
/// </summary>
public class PlatformPermissionDeniedException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException" /> class.
	/// </summary>
	public PlatformPermissionDeniedException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException" /> class with the given error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public PlatformPermissionDeniedException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException" /> class with
	/// the given error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public PlatformPermissionDeniedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
