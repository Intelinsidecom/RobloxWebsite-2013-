using System;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

/// <summary>
/// Converts <see cref="T:System.DateTime" /> to <see cref="T:Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry" /> and vice-versa.
/// </summary>
internal class DateTimeConverter : IPropertyConverter
{
	public DynamoDBEntry ToEntry(object value)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		if (value != null)
		{
			if (!(value is DateTime dateTime))
			{
				throw new PlatformArgumentException($"Unsupported type - {value.GetType()}");
			}
			return (DynamoDBEntry)new Primitive
			{
				Value = dateTime.Ticks
			};
		}
		return (DynamoDBEntry)new DynamoDBNull();
	}

	public object FromEntry(DynamoDBEntry entry)
	{
		if (entry == null || entry is DynamoDBNull)
		{
			return null;
		}
		return new DateTime(entry.AsLong(), DateTimeKind.Utc);
	}
}
