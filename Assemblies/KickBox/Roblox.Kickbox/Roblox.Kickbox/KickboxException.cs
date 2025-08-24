using System;

namespace Roblox.Kickbox;

/// <summary>
/// Wrapper for Exceptions in calls to Kickbox.
/// </summary>
public class KickboxException : Exception
{
	/// <summary>
	/// Basic constructor.
	/// </summary>
	/// <param name="message">Message passed back to the caller.</param>
	/// <param name="innerException"><see cref="T:System.Exception" /> that triggered the exception. See here for HttpStatusCode of the failure.</param>
	public KickboxException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
