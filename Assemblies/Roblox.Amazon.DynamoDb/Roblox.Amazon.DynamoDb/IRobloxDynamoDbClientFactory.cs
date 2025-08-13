using System;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Runtime;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Creates clients for Amazon DynamoDB.
/// </summary>
public interface IRobloxDynamoDbClientFactory
{
	/// <summary>
	/// Occurs when default client settings changed <see cref="T:Roblox.Amazon.DynamoDb.RobloxDynamoDbClientDefaultSettings" />.
	/// Don't forget to unsubscribe to avoid memory leaks.
	/// </summary>
	event Action<RobloxDynamoDbClientDefaultSettings> DefaultClientSettingsChanged;

	/// <summary>
	/// Gets the default client settings.
	/// </summary>
	/// <returns><see cref="T:Roblox.Amazon.DynamoDb.RobloxDynamoDbClientDefaultSettings" /></returns>
	RobloxDynamoDbClientDefaultSettings GetDefaultSettings();

	/// <summary>
	/// Creates Amazon DynamoDB client.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.DynamoDb.RobloxDynamoDbClientConfig" />.</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	IAmazonDynamoDB Create(AWSCredentials credentials, RobloxDynamoDbClientConfig config);

	/// <summary>
	/// Creates Amazon DynamoDB client. Uses default settings to build configuration.
	/// </summary>
	/// <param name="credentials">The credentials.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.
	/// (required for performance counters creation)</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	IAmazonDynamoDB Create(AWSCredentials credentials, RegionEndpoint endpoint, string clientInstanceName);

	/// <summary>
	/// Creates Amazon DynamoDB client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="endpoint">The endpoint.</param>
	/// <param name="clientInstanceName">Name of the client instance.</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	IAmazonDynamoDB Create(string awsAccessKey, string awsSecretKey, RegionEndpoint endpoint, string clientInstanceName);

	/// <summary>
	/// Creates Amazon DynamoDB client.
	/// </summary>
	/// <param name="awsAccessKey">The aws access key.</param>
	/// <param name="awsSecretKey">The aws secret key.</param>
	/// <param name="config">The configuration <see cref="T:Roblox.Amazon.DynamoDb.RobloxDynamoDbClientConfig" />.</param>
	/// <returns>
	/// Amazon DynamoDB client
	/// </returns>
	IAmazonDynamoDB Create(string awsAccessKey, string awsSecretKey, RobloxDynamoDbClientConfig config);
}
