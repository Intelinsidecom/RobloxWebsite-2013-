using System;

namespace Roblox.CommunitySift;

/// <summary>
/// Wrapper for Exceptions in calls to CommunitySift.
/// </summary>
public class CommunitySiftException : Exception
{
	/// <summary>
	/// Basic constructor.
	/// </summary>
	/// <param name="message">Message passed back to the caller.</param>
	/// <param name="innerException"><see cref="T:System.Exception" /> that triggered the exception. See here for HttpStatusCode of the failure.</param>
	public CommunitySiftException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
