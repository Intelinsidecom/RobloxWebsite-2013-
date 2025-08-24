using System;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Abstract base class for DynamoDB mappers. 
/// Different <see cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" /> implementations can be used in derived classes
/// to describe DynamoDB attributes.
/// </summary>
public abstract class DynamoMapperBase
{
	/// <summary>
	/// Gets the "specified attribute not exists" condition expression.
	/// </summary>
	/// <param name="dynamoAttributeInfo"><see cref="T:Roblox.Amazon.DynamoDb.IDynamoAttributeInfo" /></param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentNullException">dynamoAttributeInfo</exception>
	public string GetAttributeNotExistsConditionExpression(IDynamoAttributeInfo dynamoAttributeInfo)
	{
		if (dynamoAttributeInfo == null)
		{
			throw new ArgumentNullException("dynamoAttributeInfo");
		}
		return $"attribute_not_exists({dynamoAttributeInfo.Name})";
	}

	/// <summary>
	/// Gets the "specified attribute exists" condition expression.
	/// </summary>
	/// <param name="dynamoAttributeInfo">The dynamo attribute information.</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentNullException">dynamoAttributeInfo</exception>
	public string GetAttributeExistsConditionExpression(IDynamoAttributeInfo dynamoAttributeInfo)
	{
		if (dynamoAttributeInfo == null)
		{
			throw new ArgumentNullException("dynamoAttributeInfo");
		}
		return $"attribute_exists({dynamoAttributeInfo.Name})";
	}
}
