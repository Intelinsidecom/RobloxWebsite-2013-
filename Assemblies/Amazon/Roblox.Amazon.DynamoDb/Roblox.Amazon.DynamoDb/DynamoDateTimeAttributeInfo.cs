using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Implementation of DynamoAttributeInfo{T} for DateTime type
/// </summary>
/// <seealso cref="T:Roblox.Amazon.DynamoDb.DynamoAttributeInfo`1" />
/// <seealso cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
public class DynamoDateTimeAttributeInfo : DynamoAttributeInfo<DateTime?>
{
	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
	public override DynamoDataType Type => DynamoDataType.N;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoDateTimeAttributeInfo" /> class.
	/// </summary>
	/// <param name="name">The DynamoDB attribute name.</param>
	public DynamoDateTimeAttributeInfo(string name)
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		string dateTimeTicksString = null;
		if (value.HasValue)
		{
			dateTimeTicksString = ((value.Value.Kind == DateTimeKind.Utc) ? value.Value.Ticks.ToString() : TimeZoneInfo.ConvertTimeToUtc(value.Value).Ticks.ToString());
		}
		return new AttributeValue
		{
			N = dateTimeTicksString
		};
	}

	/// <summary>
	/// Gets corresponding <see cref="T:Amazon.DynamoDBv2.Model.AttributeValue" /> from DynamoDB database item, 
	/// converts it to DateTime? and returns as a result.
	/// If corresponding attribute doesn't exist or value can't be converted then returns null.
	/// </summary>
	/// <param name="dbItem">The DynamoDB database item.</param>
	/// <returns>
	/// Converted value of DateTime? type
	/// </returns>
	public override DateTime? GetValueFromDBItem(Dictionary<string, AttributeValue> dbItem)
	{
		string dbAttribteValue = (IsAttributeExistInDbItem(dbItem) ? dbItem[base.Name].N : null);
		if (!string.IsNullOrWhiteSpace(dbAttribteValue) && long.TryParse(dbAttribteValue, out var ticks))
		{
			return new DateTime(ticks, DateTimeKind.Utc);
		}
		return null;
	}
}
