using System;

namespace Roblox.Platform.Core;

public class PlatformInvalidAccountStatusException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformInvalidAccountStatusException" /> class.
	/// </summary>
	public PlatformInvalidAccountStatusException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformInvalidAccountStatusException" /> class with the given error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="userFacingMessage">The message to be shown to the user.</param>
	public PlatformInvalidAccountStatusException(string message, string userFacingMessage)
		: base(message, userFacingMessage)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.PlatformInvalidAccountStatusException" /> class with
	/// the given error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public PlatformInvalidAccountStatusException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
