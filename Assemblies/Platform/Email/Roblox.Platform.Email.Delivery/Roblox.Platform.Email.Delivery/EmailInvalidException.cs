using System;

namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// Exception to be thrown when an input email failed the validity check.
/// </summary>
public class EmailInvalidException : Exception
{
	/// <summary>
	/// User-friendly error message intended for display to the user.
	/// </summary>
	public readonly string UserFacingMessage;

	/// <summary>
	/// Basic constructor.
	/// </summary>
	/// <param name="message">Message passed back to the caller to be handled.</param>
	/// <param name="userFacingMessage">User-friendly error mesage intended for display to the user.</param>
	public EmailInvalidException(string message, string userFacingMessage = null)
		: base(message)
	{
		UserFacingMessage = userFacingMessage;
	}
}
