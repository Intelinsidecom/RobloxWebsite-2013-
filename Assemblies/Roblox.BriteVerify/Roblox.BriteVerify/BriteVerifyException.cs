using System;

namespace Roblox.BriteVerify;

/// <summary>
/// Wrapper for Exceptions in calls to BriteVerify.
/// </summary>
public class BriteVerifyException : Exception
{
	/// <summary>
	/// Basic constructor.
	/// </summary>
	/// <param name="message">Message passed back to the caller.</param>
	/// <param name="innerException"><see cref="T:System.Exception" /> that triggered the exception. See here for HttpStatusCode of the failure.</param>
	public BriteVerifyException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
