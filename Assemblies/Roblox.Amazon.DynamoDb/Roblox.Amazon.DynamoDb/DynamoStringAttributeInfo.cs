using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Implementation of DynamoAttributeInfo{T} for string type
/// </summary>
/// <seealso cref="T:Roblox.Amazon.DynamoDb.DynamoAttributeInfo`1" />
/// <seealso cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
public class DynamoStringAttributeInfo : DynamoAttributeInfo<string>
{
	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
	public override DynamoDataType Type => DynamoDataType.S;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoStringAttributeInfo" /> class.
	/// </summary>
	/// <param name="name">The DynamoDB attribute name.</param>
	public DynamoStringAttributeInfo(string name)
		: base(name)
	{
	}

	/// <summary>
	/// Converts provided value to the <see cref="T:Amazon.DynamoDBv2.Model.AttributeValue" /> entity.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>
	/// <see cref="T:Amazon.DynamoDBv2.Model.AttributeValue" />
	/// </returns>
	public override AttributeValue BuildAttributeValue(string value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		return new AttributeValue
		{
			S = value
		};
	}

	/// <summary>
	/// Gets corresponding <see cref="T:Amazon.DynamoDBv2.Model.AttributeValue" /> from DynamoDB database item, 
	/// converts it to string and returns as a result.
	/// If corresponding attribute doesn't exist or value can't be converted then returns null.
	/// </summary>
	/// <param name="dbItem">The DynamoDB database item.</param>
	/// <returns>
	/// Converted value of string type
	/// </returns>
	public override string GetValueFromDBItem(Dictionary<string, AttributeValue> dbItem)
	{
		if (!IsAttributeExistInDbItem(dbItem))
		{
			return null;
		}
		return dbItem[base.Name].S;
	}
}
