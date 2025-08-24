using System;
using Amazon.SQS.Model;
using Roblox.Coordination;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// An interface that represents an AWS SQS message with expiry.
/// <seealso cref="T:Roblox.Coordination.IMessage" />.
/// </summary>
public interface ISqsMessage : IMessage
{
	/// <summary>
	/// The AWS SQS <seealso cref="T:Amazon.SQS.Model.Message" />.
	/// </summary>
	Message FullMessage { get; }

	/// <summary>
	/// The expiry time of the message.
	/// </summary>
	DateTime MessageExpiry { get; }
}
