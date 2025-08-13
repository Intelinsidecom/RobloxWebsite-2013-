using System;
using Amazon;
using Amazon.KinesisFirehose;
using Amazon.Runtime;

namespace Roblox.Amazon.Firehose;

/// <summary>
/// Creates clients for Amazon KinesisFirehose.
/// </summary>
public interface IRobloxFirehoseClientFactory
{
	/// <summary>
	/// Occurs when default client settings changed <see cref="T:Roblox.Amazon.Firehose.RobloxFirehoseClientDefaultSettings" />.
	/// Don't forget to unsubscribe to avoid memory leaks.
	/// </summary>
	event Action<RobloxFirehoseClientDefaultSettings> DefaultClientSettingsChanged;

	/// <summary>
	/// Creates Amazon KinesisFirehose client.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration.</param>
	/// <returns>Amazon KinesisFirehose client</returns>
	IAmazonKinesisFirehose Create(AWSCredentials credentials, RobloxFirehoseClientConfig config);

	/// <summary>
	/// Creates Amazon KinesisFirehose client. Uses default values from settings to build configuration.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">
	/// Name of the client instance.
	/// (required for performance counters creation)
	/// </param>
	/// <returns>
	/// Amazon KinesisFirehose client
	/// </returns>
	IAmazonKinesisFirehose Create(AWSCredentials credentials, RegionEndpoint endpoint, string clientInstanceName);

	/// <summary>
	/// Creates Amazon KinesisFirehose client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.</param>
	/// <returns>
	/// Amazon KinesisFirehose client
	/// </returns>
	IAmazonKinesisFirehose Create(string awsAccessKey, string awsSecretKey, RegionEndpoint endpoint, string clientInstanceName);

	/// <summary>
	/// Creates Amazon KinesisFirehose client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.Firehose.RobloxFirehoseClientConfig" />.</param>
	/// <returns>
	/// Amazon KinesisFirehose client
	/// </returns>
	IAmazonKinesisFirehose Create(string awsAccessKey, string awsSecretKey, RobloxFirehoseClientConfig config);

	/// <summary>
	/// Gets the default client settings.
	/// </summary>
	/// <returns><see cref="T:Roblox.Amazon.Firehose.RobloxFirehoseClientDefaultSettings" /></returns>
	RobloxFirehoseClientDefaultSettings GetDefaultSettings();
}
