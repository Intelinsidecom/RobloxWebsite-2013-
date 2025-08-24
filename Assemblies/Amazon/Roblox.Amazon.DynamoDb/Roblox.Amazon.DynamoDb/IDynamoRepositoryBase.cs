using System;
using Amazon.DynamoDBv2;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// DynamoRepositoryBase interface which exposes methods to get DynamoDB client, table name, update DynamoDB client configs/aws credentials
/// </summary>
[Obsolete("Use IDynamoRepository instead.")]
public interface IDynamoRepositoryBase
{
	/// <summary>
	/// Gets the name of the DynamoDB table.
	/// </summary>
	/// <value>
	/// The name of the DynamoDB table.
	/// </value>
	string TableName { get; }

	/// <summary>
	/// Gets the name of the client instance.
	/// </summary>
	string ClientName { get; }

	/// <summary>
	/// Gets the AWS DynamoDB client <see cref="T:Amazon.DynamoDBv2.IAmazonDynamoDB" />.
	/// </summary>
	/// <value>
	/// The AWS DynamoDB client.
	/// </value>
	IAmazonDynamoDB Client { get; }

	/// <summary>
	/// Updates DynamoDB client with new aws credentials.
	/// </summary>
	/// <param name="awsAccessKey">The AWS access key.</param>
	/// <param name="awsSecretKey">The AWS secret key.</param>
	void Refresh(string awsAccessKey, string awsSecretKey);

	/// <summary>
	/// Updates DynamoDB client with the specified client configuration.
	/// </summary>
	/// <param name="repositoryConfig">The DynamoDB credentials.</param>
	void Refresh(DynamoRepositoryConfig repositoryConfig);
}
