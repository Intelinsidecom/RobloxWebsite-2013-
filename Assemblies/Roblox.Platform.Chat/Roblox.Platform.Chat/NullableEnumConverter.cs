using System;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

/// <summary>
/// Converts nullable enum type to <see cref="T:Amazon.DynamoDBv2.DocumentModel.DynamoDBEntry" /> and vice-versa.
/// TODO: Use where T : Enum, when we upgrade C# language version to 7.3
/// </summary>
internal class NullableEnumConverter<T> : IPropertyConverter where T : struct
{
	public DynamoDBEntry ToEntry(object value)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		if (value == null)
		{
			return (DynamoDBEntry)(object)DynamoDBNull.Null;
		}
		Type valueType = value.GetType();
		if (valueType == null || !valueType.IsEnum)
		{
			throw new PlatformArgumentException($"Unsupported type - {valueType}");
		}
		return (DynamoDBEntry)new Primitive
		{
			Value = (int)value
		};
	}

	public object FromEntry(DynamoDBEntry entry)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if (entry == null || entry is DynamoDBNull || entry == DynamoDBNull.Null)
		{
			return null;
		}
		Primitive primitive = (Primitive)(object)((entry is Primitive) ? entry : null);
		T value2;
		if (primitive != null && (int)primitive.Type == 1)
		{
			return Enum.TryParse<T>(((DynamoDBEntry)primitive).AsInt().ToString(), out value2) ? new T?(value2) : null;
		}
		T value;
		if (primitive != null && (int)primitive.Type == 0)
		{
			return Enum.TryParse<T>(((DynamoDBEntry)primitive).AsString(), out value) ? new T?(value) : null;
		}
		throw new PlatformArgumentException($"Unsupported DynamoDBEntry - {entry}");
	}
}
