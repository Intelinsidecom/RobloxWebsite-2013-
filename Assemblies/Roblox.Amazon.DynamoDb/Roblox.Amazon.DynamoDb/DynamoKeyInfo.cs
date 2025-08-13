using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Generic base abstract class which describes DynamoDB key and exposes helper methods.
/// </summary>
/// <typeparam name="T">Data type which is associated with DynamoDB key</typeparam>
/// <seealso cref="T:Roblox.Amazon.DynamoDb.IDynamoKeyInfo" />
public abstract class DynamoKeyInfo<T> : IDynamoKeyInfo
{
	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoKeyInfo" />
	public string Name { get; }

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoKeyInfo" />
	public abstract DynamoDataType Type { get; }

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoKeyInfo" />
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
	/// <param name="name">The DynamoDB key name.</param>
	/// <exception cref="T:System.ArgumentNullException">name</exception>
	protected DynamoKeyInfo(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentNullException("name");
		}
		Name = name;
		PlaceHolder = $":{Name.ToLower()}";
	}

	/// <summary>
	/// Determines whether key is exist in database item.
	/// </summary>
	/// <param name="dbItem">The database item.</param>
	/// <returns>
	///   <c>true</c> if key exist in database item]; otherwise, <c>false</c>.
	/// </returns>
	protected bool IsKeyExistInDbItem(Dictionary<string, AttributeValue> dbItem)
	{
		return dbItem?.ContainsKey(Name) ?? false;
	}
}
