using System;

namespace Roblox.Web.Authentication;

/// <summary>
/// Thrown when there is an error sending the challenge
/// </summary>
public class TransmissionException : Exception
{
	/// <summary>
	/// Constructs a <see cref="T:Roblox.Web.Authentication.TransmissionException" />
	/// </summary>
	public TransmissionException()
	{
	}

	/// <summary>
	/// Constructs a <see cref="T:Roblox.Web.Authentication.TransmissionException" />
	/// </summary>
	/// <param name="message">The message</param>
	public TransmissionException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Constructs a <see cref="T:Roblox.Web.Authentication.TransmissionException" />
	/// </summary>
	/// <param name="message">The message</param>
	/// <param name="innerException">The inner <see cref="T:System.Exception" /></param>
	public TransmissionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
