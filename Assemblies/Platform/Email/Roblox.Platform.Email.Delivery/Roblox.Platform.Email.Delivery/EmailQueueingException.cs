using System;

namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// Exception to be thrown when there is an error while queueing the <see cref="T:Roblox.Platform.Email.Delivery.EmailDeliveryEvent" /> to SNS.
/// </summary>
public class EmailQueueingException : Exception
{
	/// <summary>
	/// Basic constructor.
	/// </summary>
	/// <param name="message">Message passed back to the caller to be handled.</param>
	/// <param name="innerException"><see cref="T:System.Exception" /> that triggered the exception.</param>
	public EmailQueueingException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
