using System;
using Amazon;
using Amazon.Runtime;
using Amazon.SimpleNotificationService;

namespace Roblox.Amazon.Sns;

/// <summary>
/// Creates clients for Amazon SNS.
/// </summary>
public interface IRobloxSnsClientFactory
{
	/// <summary>
	/// Occurs when default client settings changed <see cref="T:Roblox.Amazon.Sns.RobloxSnsClientDefaultSettings" />.
	/// Don't forget to unsubscribe to avoid memory leaks.
	/// </summary>
	event Action<RobloxSnsClientDefaultSettings> DefaultClientSettingsChanged;

	/// <summary>
	/// Creates Amazon SNS client.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	/// <returns>Amazon SNS client</returns>
	IAmazonSimpleNotificationService Create(AWSCredentials credentials, RobloxSnsClientConfig config);

	/// <summary>
	/// Creates Amazon SNS client. Uses default values from settings to build configuration.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">
	/// Name of the client instance.
	/// (required for performance counters creation)
	/// </param>
	/// <returns>
	/// Amazon SNS client
	/// </returns>
	IAmazonSimpleNotificationService Create(AWSCredentials credentials, RegionEndpoint endpoint, string clientInstanceName);

	/// <summary>
	/// Gets the default client settings.
	/// </summary>
	/// <returns><see cref="T:Roblox.Amazon.Sns.RobloxSnsClientDefaultSettings" /></returns>
	RobloxSnsClientDefaultSettings GetDefaultSettings();

	/// <summary>
	/// Creates Amazon SNS client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.</param>
	/// <returns>
	/// Amazon SNS client
	/// </returns>
	IAmazonSimpleNotificationService Create(string awsAccessKey, string awsSecretKey, RegionEndpoint endpoint, string clientInstanceName);

	/// <summary>
	/// Creates Amazon SNS client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.Sns.RobloxSnsClientConfig" />.</param>
	/// <returns>
	/// Amazon SNS client
	/// </returns>
	IAmazonSimpleNotificationService Create(string awsAccessKey, string awsSecretKey, RobloxSnsClientConfig config);
}
