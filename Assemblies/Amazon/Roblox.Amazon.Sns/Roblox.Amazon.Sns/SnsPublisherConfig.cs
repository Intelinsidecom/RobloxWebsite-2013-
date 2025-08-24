using Amazon;

namespace Roblox.Amazon.Sns;

/// <summary>
/// Configuration for <see cref="T:Roblox.Amazon.Sns.SnsPublisher" />
/// </summary>
public class SnsPublisherConfig
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
	/// Gets the primary region endpoint.
	/// </summary>
	public RegionEndpoint AwsPrimaryRegionEndpoint { get; }

	/// <summary>
	/// Gets the primary SNS topic arn.
	/// </summary>
	public string AwsPrimarySnsTopicArn { get; }

	/// <summary>
	/// Gets the name of the perfmon instance.
	/// </summary>
	public string PerfmonInstanceName { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Sns.SnsPublisherConfig" /> class.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="awsPrimaryRegionEndpoint">The primary region endpoint.</param>
	/// <param name="awsPrimarySnsTopicArn">The primary SNS topic arn.</param>
	/// <param name="perfmonInstanceName">Name of the perfmon instance.</param>
	public SnsPublisherConfig(string awsAccessKey, string awsSecretKey, RegionEndpoint awsPrimaryRegionEndpoint, string awsPrimarySnsTopicArn, string perfmonInstanceName)
	{
		AwsAccessKey = awsAccessKey;
		AwsSecretKey = awsSecretKey;
		AwsPrimaryRegionEndpoint = awsPrimaryRegionEndpoint;
		AwsPrimarySnsTopicArn = awsPrimarySnsTopicArn;
		PerfmonInstanceName = perfmonInstanceName;
	}
}
