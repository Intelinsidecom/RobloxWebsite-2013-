using System;
using Amazon;
using Amazon.Runtime;
using Amazon.SQS;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// Creates clients for Amazon SQS.
/// </summary>
public interface IRobloxSqsClientFactory
{
	/// <summary>
	/// Occurs when default client settings changed <see cref="T:Roblox.Amazon.Sqs.RobloxSqsClientDefaultSettings" />.
	/// Don't forget to unsubscribe to avoid memory leaks.
	/// </summary>
	event Action<RobloxSqsClientDefaultSettings> DefaultClientSettingsChanged;

	/// <summary>
	/// Creates Amazon SQS client.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	/// <returns>Amazon SQS client</returns>
	IAmazonSQS Create(AWSCredentials credentials, RobloxSqsClientConfig config);

	/// <summary>
	/// Creates Amazon SQS client. Uses default values from settings to build configuration.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">
	/// Name of the client instance.
	/// (required for performance counters creation)
	/// </param>
	/// <returns>
	/// Amazon SQS client
	/// </returns>
	IAmazonSQS Create(AWSCredentials credentials, RegionEndpoint endpoint, string clientInstanceName);

	/// <summary>
	/// Creates Amazon SQS client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.</param>
	/// <returns>
	/// Amazon SQS client
	/// </returns>
	IAmazonSQS Create(string awsAccessKey, string awsSecretKey, RegionEndpoint endpoint, string clientInstanceName);

	/// <summary>
	/// Creates Amazon SQS client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.Sqs.RobloxSqsClientConfig" />.</param>
	/// <returns>
	/// Amazon SQS client
	/// </returns>
	IAmazonSQS Create(string awsAccessKey, string awsSecretKey, RobloxSqsClientConfig config);

	/// <summary>
	/// Gets the default client settings.
	/// </summary>
	/// <returns><see cref="T:Roblox.Amazon.Sqs.RobloxSqsClientDefaultSettings" /></returns>
	RobloxSqsClientDefaultSettings GetDefaultSettings();
}
