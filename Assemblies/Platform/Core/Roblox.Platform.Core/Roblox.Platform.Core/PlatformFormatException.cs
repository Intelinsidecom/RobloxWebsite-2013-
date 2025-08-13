using System;

namespace Roblox.Platform.Core;

/// <summary>
/// The exception that is thrown when the format of an argument is invalid, or when a composite format string is not well formed.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.PlatformException" />
public class PlatformFormatException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformFormatException" /> class.
	/// </summary>
	public PlatformFormatException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformFormatException" /> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public PlatformFormatException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformFormatException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception.</param>
	public PlatformFormatException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
