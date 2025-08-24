using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

/// <summary>
/// Converts decorators in the format of comma-separated values to <see cref="T:Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry" /> and vice-versa.
/// </summary>
internal class DecoratorsCsvConverter : IPropertyConverter
{
	private const string _Separator = ",";

	public DynamoDBEntry ToEntry(object value)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		if (value != null)
		{
			if (!(value is IEnumerable<string> decorators))
			{
				throw new PlatformArgumentException($"Unsupported type - {value.GetType()}");
			}
			return (DynamoDBEntry)new Primitive
			{
				Value = string.Join(",", decorators)
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
		return new HashSet<string>(entry.AsString().Split(','), StringComparer.OrdinalIgnoreCase);
	}
}
