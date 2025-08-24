namespace Roblox.Amazon.Sqs;

/// <summary>
/// An interface object represents an AWS Sqs message receipt with region name.
/// To be used for AWS Sqs message operations such as deleting the message from the queue.
/// </summary>
public interface ISqsReceipt
{
	/// <summary>
	/// The handle string of the receipt.
	/// </summary>
	string ReceiptHandle { get; }

	/// <summary>
	/// The regional system name of the receipt that is received from.
	/// </summary>
	string RegionName { get; }
}
