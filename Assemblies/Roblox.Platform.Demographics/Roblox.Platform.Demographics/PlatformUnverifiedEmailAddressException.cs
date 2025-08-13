using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

public class PlatformUnverifiedEmailAddressException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Demographics.PlatformUnverifiedEmailAddressException" /> class.
	/// </summary>
	public PlatformUnverifiedEmailAddressException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Demographics.PlatformUnverifiedEmailAddressException" /> class with the given error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="userFacingMessage">The message to be shown to the user.</param>
	public PlatformUnverifiedEmailAddressException(string message, string userFacingMessage)
		: base(message, userFacingMessage)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Demographics.PlatformUnverifiedEmailAddressException" /> class with
	/// the given error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public PlatformUnverifiedEmailAddressException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
