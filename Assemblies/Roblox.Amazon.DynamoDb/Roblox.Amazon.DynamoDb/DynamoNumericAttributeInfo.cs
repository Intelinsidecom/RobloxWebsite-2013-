using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Implementation of DynamoAttributeInfo{T} for long type
/// </summary>
/// <seealso cref="T:Roblox.Amazon.DynamoDb.DynamoAttributeInfo`1" />
/// <seealso cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
public class DynamoNumericAttributeInfo : DynamoAttributeInfo<long?>
{
	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
	public override DynamoDataType Type => DynamoDataType.N;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoNumericAttributeInfo" /> class.
	/// </summary>
	/// <param name="name">The DynamoDB attribute name.</param>
	public DynamoNumericAttributeInfo(string name)
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
	public override AttributeValue BuildAttributeValue(long? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		return new AttributeValue
		{
			N = (value.HasValue ? value.ToString() : null)
		};
	}

	/// <summary>
	/// Gets corresponding <see cref="T:Amazon.DynamoDBv2.Model.AttributeValue" /> from DynamoDB database item, 
	/// converts it to long? and returns as a result. 
	/// If corresponding attribute doesn't exist or value can't be converted then returns null.
	/// </summary>
	/// <param name="dbItem">The DynamoDB database item.</param>
	/// <returns>
	/// Converted value of DateTime? type
	/// </returns>
	public override long? GetValueFromDBItem(Dictionary<string, AttributeValue> dbItem)
	{
		string dbAttributeValue = (IsAttributeExistInDbItem(dbItem) ? dbItem[base.Name].N : null);
		if (!string.IsNullOrWhiteSpace(dbAttributeValue) && long.TryParse(dbAttributeValue, out var result))
		{
			return result;
		}
		return null;
	}
}
