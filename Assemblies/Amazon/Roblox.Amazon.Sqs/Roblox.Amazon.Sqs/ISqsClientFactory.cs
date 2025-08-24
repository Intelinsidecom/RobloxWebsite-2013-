using Amazon.SQS;

namespace Roblox.Amazon.Sqs;

internal interface ISqsClientFactory
{
	IAmazonSQS GetSqsClient(IRobloxRegionEndpoint regionEndpoint, ISqsConfigSettings sqsConfigSettings);
}
