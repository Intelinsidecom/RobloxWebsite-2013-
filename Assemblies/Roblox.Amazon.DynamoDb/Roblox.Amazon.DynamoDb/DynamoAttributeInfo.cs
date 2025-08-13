using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Generic base abstract class which describes DynamoDB attribute and exposes helper methods.
/// </summary>
/// <typeparam name="T">Data type which is associated with DynamoDB attribute</typeparam>
/// <seealso cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
public abstract class DynamoAttributeInfo<T> : IDynamoAttributeInfo
{
	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
	public string Name { get; }

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
	public abstract DynamoDataType Type { get; }

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" />
	public string PlaceHolder { get; }

	/// <summary>
	/// Converts provided value of T type to the <see cref="T:Amazon.DynamoDBv2.Model.AttributeValue" /> entity. 
	/// </summary>
	/// <param name="value">The value of T type .</param>
	/// <returns><see cref="T:Amazon.DynamoDBv2.Model.AttributeValue" /></returns>
	public abstract AttributeValue BuildAttributeValue(T value);

	/// <summary>
	/// Gets corresponding <see cref="T:Amazon.DynamoDBv2.Model.AttributeValue" /> from DynamoDB database item, converts it to T type 
	/// and returns as a result.
	/// </summary>
	/// <param name="dbItem">The DynamoDB database item.</param>
	/// <returns>Converted value of T type</returns>
	public abstract T GetValueFromDBItem(Dictionary<string, AttributeValue> dbItem);

	/// <summary>
	/// Base constructor.
	/// </summary>
	/// <param name="name">The DynamoDB attribute name.</param>
	/// <exception cref="T:System.ArgumentException">name</exception>
	protected DynamoAttributeInfo(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("name");
		}
		Name = name;
		PlaceHolder = $":{Name.ToLower()}";
	}

	/// <summary>
	/// Determines whether attribute is exist in database item.
	/// </summary>
	/// <param name="dbItem">The database item.</param>
	/// <returns>
	///   <c>true</c> if attribute exist in database item; otherwise, <c>false</c>.
	/// </returns>
	public bool IsAttributeExistInDbItem(Dictionary<string, AttributeValue> dbItem)
	{
		if (dbItem != null && dbItem.ContainsKey(Name))
		{
			return dbItem[Name] != null;
		}
		return false;
	}
}
