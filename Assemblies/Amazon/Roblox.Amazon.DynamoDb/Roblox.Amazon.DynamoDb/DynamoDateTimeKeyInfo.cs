using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Implementation of DynamoKeyInfo{T} for DateTime type
/// </summary>
/// <seealso cref="T:Roblox.Amazon.DynamoDb.DynamoKeyInfo`1" />
/// <seealso cref="T:Roblox.Amazon.DynamoDb.IDynamoKeyInfo" />
public class DynamoDateTimeKeyInfo : DynamoKeyInfo<DateTime?>
{
	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoKeyInfo" />
	public override DynamoDataType Type => DynamoDataType.N;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoDateTimeKeyInfo" /> class.
	/// </summary>
	/// <param name="name">The DynamoDB key name.</param>
	public DynamoDateTimeKeyInfo(string name)
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
	public override AttributeValue BuildAttributeValue(DateTime? value)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		string dateTimeTicksString = null;
		if (value.HasValue)
		{
			dateTimeTicksString = ((value.Value.Kind == DateTimeKind.Utc) ? value.Value.Ticks.ToString() : DateTime.SpecifyKind(value.Value, DateTimeKind.Utc).Ticks.ToString());
		}
		return new AttributeValue
		{
			N = dateTimeTicksString
		};
	}

	/// <summary>
	/// Gets corresponding <see cref="T:Amazon.DynamoDBv2.Model.AttributeValue" /> from DynamoDB database item, 
	/// converts it to DateTime? and returns as a result.
	/// If corresponding key doesn't exist or value can't be converted then returns null.
	/// </summary>
	/// <param name="dbItem">The DynamoDB database item.</param>
	/// <returns>
	/// Converted value of DateTime? type
	/// </returns>
	public override DateTime? GetValueFromDBItem(Dictionary<string, AttributeValue> dbItem)
	{
		string dbAttribteValue = (IsKeyExistInDbItem(dbItem) ? dbItem[base.Name].N : null);
		if (!string.IsNullOrWhiteSpace(dbAttribteValue) && long.TryParse(dbAttribteValue, out var ticks))
		{
			return new DateTime(ticks, DateTimeKind.Utc);
		}
		return null;
	}
}
