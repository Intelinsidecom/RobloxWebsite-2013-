using Amazon;

namespace Roblox.Amazon.Firehose;

/// <summary>
/// Configuration for <see cref="T:Roblox.Amazon.Firehose.AmazonKinesisFirehoseBatchEventSender" />
/// </summary>
internal class AmazonKinesisFirehoseBatchEventSenderConfig
{
	/// <summary>
	/// Gets the aws access key.
	/// </summary>
	public string AwsAccessKey { get; }

	/// <summary>
	/// Gets the aws secret key.
	/// </summary>
	public string AwsSecretKey { get; }

	/// <summary>
	/// Gets the mame of the amazon kinesis firehose delivery stream.
	/// </summary>
	public string AwsKinesisFirehoseDeliveryStreamName { get; }

	/// <summary>
	/// Gets the aws region endpoint.
	/// </summary>
	public RegionEndpoint AwsRegionEndpoint { get; }

	/// <summary>
	/// Gets the maximum size of the buffer.
	/// </summary>
	public int? MaxBufferSize { get; }

	/// <summary>
	/// Gets the maximum messages per batch request.
	/// </summary>
	public int? MaxMessagesPerBatchRequest { get; }

	/// <summary>
	/// Gets the maximum timeout per message.
	/// </summary>
	public int? MaxTimeoutPerMessage { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Firehose.AmazonKinesisFirehoseBatchEventSenderConfig" /> class.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="awsKinesisFirehoseDeliveryStreamName">Name of the aws kinesis firehose delivery stream.</param>
	/// <param name="maxBufferSize">Maximum size of the buffer (optional, default value will be used).</param>
	/// <param name="maxMessagesPerBatchRequest">The maximum messages per batch request (optional, default value will be used).</param>
	/// <param name="maxTimeoutPerMessage">The maximum timeout per message (optional, default value will be used).</param>
	/// <param name="awsRegionEndpoint">The aws region endpoint. (optional, default value is RegionEndpoint.USEast1)</param>
	public AmazonKinesisFirehoseBatchEventSenderConfig(string awsAccessKey, string awsSecretKey, string awsKinesisFirehoseDeliveryStreamName, int? maxBufferSize, int? maxMessagesPerBatchRequest, int? maxTimeoutPerMessage, RegionEndpoint awsRegionEndpoint = null)
	{
		AwsAccessKey = awsAccessKey;
		AwsSecretKey = awsSecretKey;
		AwsKinesisFirehoseDeliveryStreamName = awsKinesisFirehoseDeliveryStreamName;
		MaxBufferSize = maxBufferSize;
		MaxMessagesPerBatchRequest = maxMessagesPerBatchRequest;
		MaxTimeoutPerMessage = maxTimeoutPerMessage;
		AwsRegionEndpoint = awsRegionEndpoint;
	}
}
