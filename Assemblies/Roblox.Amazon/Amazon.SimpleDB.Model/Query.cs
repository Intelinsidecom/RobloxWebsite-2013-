using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class Query
{
	private string domainNameField;

	private string queryExpressionField;

	private decimal? maxNumberOfItemsField;

	private string nextTokenField;

	/// <summary>
	/// Gets and sets the DomainName property.
	/// </summary>
	[XmlElement(ElementName = "DomainName")]
	public string DomainName
	{
		get
		{
			return domainNameField;
		}
		set
		{
			domainNameField = value;
		}
	}

	/// <summary>
	/// Gets and sets the QueryExpression property.
	/// </summary>
	[XmlElement(ElementName = "QueryExpression")]
	public string QueryExpression
	{
		get
		{
			return queryExpressionField;
		}
		set
		{
			queryExpressionField = value;
		}
	}

	/// <summary>
	/// Gets and sets the MaxNumberOfItems property.
	/// </summary>
	[XmlElement(ElementName = "MaxNumberOfItems")]
	public decimal MaxNumberOfItems
	{
		get
		{
			return maxNumberOfItemsField.GetValueOrDefault();
		}
		set
		{
			maxNumberOfItemsField = value;
		}
	}

	/// <summary>
	/// Gets and sets the NextToken property.
	/// </summary>
	[XmlElement(ElementName = "NextToken")]
	public string NextToken
	{
		get
		{
			return nextTokenField;
		}
		set
		{
			nextTokenField = value;
		}
	}

	/// <summary>
	/// Sets the DomainName property
	/// </summary>
	/// <param name="domainName">DomainName property</param>
	/// <returns>this instance</returns>
	public Query WithDomainName(string domainName)
	{
		domainNameField = domainName;
		return this;
	}

	/// <summary>
	/// Checks if DomainName property is set
	/// </summary>
	/// <returns>true if DomainName property is set</returns>
	public bool IsSetDomainName()
	{
		return domainNameField != null;
	}

	/// <summary>
	/// Sets the QueryExpression property
	/// </summary>
	/// <param name="queryExpression">QueryExpression property</param>
	/// <returns>this instance</returns>
	public Query WithQueryExpression(string queryExpression)
	{
		queryExpressionField = queryExpression;
		return this;
	}

	/// <summary>
	/// Checks if QueryExpression property is set
	/// </summary>
	/// <returns>true if QueryExpression property is set</returns>
	public bool IsSetQueryExpression()
	{
		return queryExpressionField != null;
	}

	/// <summary>
	/// Sets the MaxNumberOfItems property
	/// </summary>
	/// <param name="maxNumberOfItems">MaxNumberOfItems property</param>
	/// <returns>this instance</returns>
	public Query WithMaxNumberOfItems(decimal maxNumberOfItems)
	{
		maxNumberOfItemsField = maxNumberOfItems;
		return this;
	}

	/// <summary>
	/// Checks if MaxNumberOfItems property is set
	/// </summary>
	/// <returns>true if MaxNumberOfItems property is set</returns>
	public bool IsSetMaxNumberOfItems()
	{
		return maxNumberOfItemsField.HasValue;
	}

	/// <summary>
	/// Sets the NextToken property
	/// </summary>
	/// <param name="nextToken">NextToken property</param>
	/// <returns>this instance</returns>
	public Query WithNextToken(string nextToken)
	{
		nextTokenField = nextToken;
		return this;
	}

	/// <summary>
	/// Checks if NextToken property is set
	/// </summary>
	/// <returns>true if NextToken property is set</returns>
	public bool IsSetNextToken()
	{
		return nextTokenField != null;
	}

	/// <summary>
	/// Representation of operation that returns
	/// Dictionary of AWS Query Parameters
	/// </summary>
	public IDictionary<string, string> ToMap()
	{
		IDictionary<string, string> parameters = new Dictionary<string, string>();
		parameters.Add("Action", "Query");
		if (IsSetDomainName())
		{
			parameters.Add("DomainName", DomainName);
		}
		if (IsSetQueryExpression())
		{
			parameters.Add("QueryExpression", QueryExpression);
		}
		if (IsSetMaxNumberOfItems())
		{
			parameters.Add("MaxNumberOfItems", string.Concat(MaxNumberOfItems));
		}
		if (IsSetNextToken())
		{
			parameters.Add("NextToken", NextToken);
		}
		return parameters;
	}
}
