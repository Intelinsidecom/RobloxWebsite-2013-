using Amazon.DynamoDBv2;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Provides a common interface for an object that exposes a configurable DynamoDB client.
/// </summary>
public interface IDynamoRepository
{
	/// <summary>
	/// Gets the <see cref="T:Amazon.DynamoDBv2.IAmazonDynamoDB" /> that connected to the repository.
	/// </summary>
	IAmazonDynamoDB Client { get; }

	/// <summary>
	/// Gets the name of the client instance.
	/// </summary>
	string ClientName { get; }

	/// <summary>
	/// Updates DynamoDB client with new aws credentials.
	/// </summary>
	/// <param name="awsAccessKey">The AWS access key.</param>
	/// <param name="awsSecretKey">The AWS secret key.</param>
	void Refresh(string awsAccessKey, string awsSecretKey);

	/// <summary>
	/// Updates the instance's client with the specified client configuration.
	/// </summary>
	/// <param name="repositoryConfig">The DynamoDB credentials.</param>
	void Refresh(DynamoRepositoryConfig repositoryConfig);
}
