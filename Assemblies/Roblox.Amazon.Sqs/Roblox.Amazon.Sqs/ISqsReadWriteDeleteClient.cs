using System;
using System.Collections.Generic;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// An interface that repesents an object that is capable of retrieving messages from AWS SQS 
/// and batch deleting them if the specific message tasks are marked as completed.
/// </summary>
internal interface ISqsReadWriteDeleteClient
{
	/// <summary>
	/// The Getter for the <see cref="T:Roblox.Amazon.Sqs.ISqsBatchDeleter" />.
	/// </summary>
	Func<ISqsBatchDeleter> SqsBatchDeleterGetter { get; }

	/// <summary>
	/// Retrieve an array of <see cref="T:Roblox.Amazon.Sqs.ISqsMessage" /> from AWS SQS.
	/// </summary>
	/// <param name="batchSize">The batch size of each request.</param>
	/// <returns>An array of <see cref="T:Roblox.Amazon.Sqs.ISqsMessage" />. Returns an empty array if there's no messages from SQS.</returns>
	IReadOnlyCollection<ISqsMessage> GetMessages(int batchSize);

	/// <summary>
	/// Retrieve an array of <see cref="T:Roblox.Amazon.Sqs.ISqsMessageWithReceipt" /> from AWS SQS.
	/// </summary>
	/// <param name="batchSize">The batch size of each request.</param>
	/// <param name="visibilityTimeout">The visibility timeout to be set on the messages being retrieved.</param>
	/// <returns>An array of <see cref="T:Roblox.Amazon.Sqs.ISqsMessageWithReceipt" />. Returns an empty array if there's no messages from SQS.</returns>
	IReadOnlyCollection<ISqsMessageWithReceipt> GetMessagesWithReceipt(int batchSize, int visibilityTimeout);
}
