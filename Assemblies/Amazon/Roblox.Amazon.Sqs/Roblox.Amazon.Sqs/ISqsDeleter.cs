namespace Roblox.Amazon.Sqs;

/// <summary>
/// Deletes messages on the active queue based on the given receipt handle.
/// </summary>
internal interface ISqsDeleter
{
	/// <summary>
	/// Push the message receipt handle into deletion queue to be deleted in batch by the background deleter.
	/// </summary>
	/// <param name="receiptHandle">The receipt handle string being used in requesting message deletion by AWS SQS.</param>
	void DeleteMessage(string receiptHandle);
}
