namespace Roblox.Amazon.Core;

/// <summary>
/// Represents RobloxAws client types
/// </summary>
public enum RobloxAwsClientType
{
	/// <summary>
	/// The Dynamo database
	/// </summary>
	DynamoDb,
	/// <summary>
	/// The Kinesis Firehose
	/// </summary>
	Firehose,
	/// <summary>
	/// The S3
	/// </summary>
	S3,
	/// <summary>
	/// The Cloud Watch
	/// </summary>
	CloudWatch,
	/// <summary>
	/// The SQS
	/// </summary>
	Sqs,
	/// <summary>
	/// The SNS
	/// </summary>
	Sns,
	/// <summary>
	/// The Lambda
	/// </summary>
	Lambda,
	/// <summary>
	/// The Rekognition
	/// </summary>
	Rekognition
}
