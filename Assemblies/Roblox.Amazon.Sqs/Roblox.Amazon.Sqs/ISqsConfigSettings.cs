namespace Roblox.Amazon.Sqs;

/// <summary>
/// An interface represents AWS settings for configuring the access of a SQS queue.
/// </summary>
public interface ISqsConfigSettings
{
	/// <summary>
	/// The SQS queue access key.
	/// </summary>
	string SqsAccessKey { get; }

	/// <summary>
	/// The SQS queue Secret Access Key.
	/// </summary>
	string SqsSecretAccessKey { get; }

	/// <summary>
	/// The URL of the SQS queue.
	/// </summary>
	string SqsUrl { get; }
}
