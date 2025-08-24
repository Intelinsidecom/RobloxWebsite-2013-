using System.Diagnostics.CodeAnalysis;
using Amazon.SQS;

namespace Roblox.Amazon.Sqs;

[ExcludeFromCodeCoverage]
internal class SqsClientFactory : ISqsClientFactory
{
	public IAmazonSQS GetSqsClient(IRobloxRegionEndpoint regionEndpoint, ISqsConfigSettings sqsConfigSettings)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		AmazonSQSConfig config = InitializeAWSConfig(regionEndpoint);
		return (IAmazonSQS)new AmazonSQSClient(sqsConfigSettings.SqsAccessKey, sqsConfigSettings.SqsSecretAccessKey, config);
	}

	private AmazonSQSConfig InitializeAWSConfig(IRobloxRegionEndpoint regionEndpoint)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		return new AmazonSQSConfig
		{
			RegionEndpoint = regionEndpoint.GetAwsRegionEndpoint(),
			MaxErrorRetry = 0
		};
	}
}
