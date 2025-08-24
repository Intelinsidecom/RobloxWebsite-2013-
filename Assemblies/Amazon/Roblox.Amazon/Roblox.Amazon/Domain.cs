using System.Collections.Generic;
using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;

namespace Roblox.Amazon;

/// <summary>
/// ROBLOX wrapper around Amazon's C# SimpleDB API
/// </summary>
public class Domain
{
	public readonly string Name;

	private readonly AmazonSimpleDB _Service;

	public static Domain Create(string domainName)
	{
		AmazonSimpleDBClient amazonSimpleDBClient = new AmazonSimpleDBClient(new AmazonSimpleDBConfig
		{
			MaxErrorRetry = 0
		});
		CreateDomain cd = new CreateDomain(domainName);
		amazonSimpleDBClient.CreateDomain(cd);
		return Get(domainName);
	}

	public static Domain Get(string domainName)
	{
		return new Domain(domainName);
	}

	private Domain(string name)
	{
		_Service = new AmazonSimpleDBClient();
		Name = name;
	}

	public string PutItem(string itemName, ReplaceableAttributes attributes)
	{
		PutAttributes request = new PutAttributes();
		request.DomainName = Name;
		request.ItemName = itemName;
		request.Attribute = attributes.list;
		return _Service.PutAttributes(request).ResponseMetadata.RequestId;
	}

	public IEnumerable<string> Query(string queryExpression)
	{
		foreach (string item in Query(queryExpression, 100))
		{
			yield return item;
		}
	}

	public IEnumerable<string> Query(string queryExpression, int maxCount)
	{
		Query query = new Query
		{
			DomainName = Name,
			MaxNumberOfItems = maxCount,
			QueryExpression = queryExpression
		};
		QueryResult queryResult = _Service.Query(query).QueryResult;
		foreach (string item in queryResult.ItemName)
		{
			yield return item;
		}
	}

	public ICollection<string> Query(string queryExpression, int maxCount, ref string nextToken)
	{
		Query query = new Query
		{
			DomainName = Name,
			MaxNumberOfItems = maxCount,
			QueryExpression = queryExpression
		};
		if (!string.IsNullOrEmpty(nextToken))
		{
			query.NextToken = nextToken;
		}
		QueryResult queryResult = _Service.Query(query).QueryResult;
		nextToken = queryResult.NextToken;
		return queryResult.ItemName;
	}

	public Attributes GetAttributes(string itemName)
	{
		GetAttributes g = new GetAttributes
		{
			DomainName = Name,
			ItemName = itemName
		};
		return new Attributes(_Service.GetAttributes(g).GetAttributesResult.Attribute);
	}

	public string DeleteItem(string key)
	{
		DeleteAttributes request = new DeleteAttributes
		{
			DomainName = Name,
			ItemName = key
		};
		return _Service.DeleteAttributes(request).ResponseMetadata.RequestId;
	}

	public string DeleteAttributes(string key, Attributes attributes)
	{
		DeleteAttributes request = new DeleteAttributes
		{
			DomainName = Name,
			ItemName = key,
			Attribute = attributes.list
		};
		return _Service.DeleteAttributes(request).ResponseMetadata.RequestId;
	}
}
