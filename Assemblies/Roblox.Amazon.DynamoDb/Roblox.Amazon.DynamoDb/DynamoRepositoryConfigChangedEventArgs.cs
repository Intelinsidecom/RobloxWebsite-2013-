using System;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// EventArgs for <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryConfigChangedEventHandler" /> which contains changed DynamoDB repository configuration
/// </summary>
/// <seealso cref="T:System.EventArgs" />
public class DynamoRepositoryConfigChangedEventArgs : EventArgs
{
	/// <summary>
	/// Gets the repository configuration.
	/// </summary>
	public DynamoRepositoryConfig RepositoryConfig { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryConfigChangedEventArgs" /> class.
	/// </summary>
	/// <param name="repositoryConfig">The client <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryConfigChangedEventHandler" />.</param>
	public DynamoRepositoryConfigChangedEventArgs(DynamoRepositoryConfig repositoryConfig)
	{
		RepositoryConfig = repositoryConfig;
	}
}
