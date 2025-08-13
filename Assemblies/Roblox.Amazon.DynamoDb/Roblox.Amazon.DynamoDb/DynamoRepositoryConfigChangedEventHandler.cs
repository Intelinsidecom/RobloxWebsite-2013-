namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// EventHandler for event which has to be fired when DynamoDB repository configuration was changed.
/// <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryConfig" />
/// </summary>
/// <param name="sender">The sender.</param>
/// <param name="e">The <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryConfigChangedEventArgs" /> instance containing the event data.</param>
public delegate void DynamoRepositoryConfigChangedEventHandler(object sender, DynamoRepositoryConfigChangedEventArgs e);
