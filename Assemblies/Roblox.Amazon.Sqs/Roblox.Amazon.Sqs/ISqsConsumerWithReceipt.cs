using System;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// An interface that repesents an object that is capable of getting a message with receipt
/// from AWS SQS and delete it later on in an asynchronous way.
/// </summary>
public interface ISqsConsumerWithReceipt : IDisposable
{
	/// <summary>
	/// Fetch the next message in the queue from AWS SQS.
	/// </summary>
	/// <returns>An <see cref="T:Roblox.Amazon.Sqs.ISqsMessageWithReceipt" />, returns null if there's no messages available.</returns>
	ISqsMessageWithReceipt GetNextMessage();

	/// <summary>
	/// Delete the message from the AWS SQS queue using the receipt.
	/// </summary>
	/// <param name="sqsReceipt">The <see cref="T:Roblox.Amazon.Sqs.ISqsReceipt" /> to be used in deletion.</param>
	/// <exception cref="T:System.ArgumentNullException">Throws when the input parameter sqsReceipt is null.</exception>
	void DeleteMessage(ISqsReceipt sqsReceipt);
}
