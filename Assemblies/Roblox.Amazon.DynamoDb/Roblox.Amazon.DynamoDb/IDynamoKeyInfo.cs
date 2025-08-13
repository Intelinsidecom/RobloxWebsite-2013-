namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Describes particular DynamoDB key
/// </summary>
public interface IDynamoKeyInfo
{
	/// <summary>
	/// Gets the DynamoDB key name.
	/// </summary>
	/// <value>
	/// The DynamoDB key name.
	/// </value>
	string Name { get; }

	/// <summary>
	/// Gets the DynamoDB data type <see cref="T:Roblox.Amazon.DynamoDb.DynamoDataType" />.
	/// </summary>
	/// <value>
	/// The DynamoDB data type.
	/// </value>
	DynamoDataType Type { get; }

	/// <summary>
	/// Gets the DynamoDB key place holder which can be used to define an expression attribute value 
	/// as a placeholder.
	/// </summary>
	/// <value>
	/// The DynamoDB key place holder.
	/// </value>
	string PlaceHolder { get; }
}
