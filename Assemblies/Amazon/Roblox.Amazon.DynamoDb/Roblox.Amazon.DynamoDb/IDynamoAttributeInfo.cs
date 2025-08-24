namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Describes particular DynamoDB attribute
/// </summary>
public interface IDynamoAttributeInfo
{
	/// <summary>
	/// Gets the DynamoDB attribute name.
	/// </summary>
	/// <value>
	/// The DynamoDB attribute name.
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
	/// Gets the DynamoDB attribute value placeholder. More information: http://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_Query.html
	/// </summary>
	/// <value>
	/// The DynamoDB attribute value place holder.
	/// </value>
	string PlaceHolder { get; }
}
