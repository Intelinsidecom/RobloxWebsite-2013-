using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class ListDomains
{
	private decimal? maxNumberOfDomainsField;

	private string nextTokenField;

	/// <summary>
	/// Gets and sets the MaxNumberOfDomains property.
	/// </summary>
	[XmlElement(ElementName = "MaxNumberOfDomains")]
	public decimal MaxNumberOfDomains
	{
		get
		{
			return maxNumberOfDomainsField.GetValueOrDefault();
		}
		set
		{
			maxNumberOfDomainsField = value;
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
	/// Sets the MaxNumberOfDomains property
	/// </summary>
	/// <param name="maxNumberOfDomains">MaxNumberOfDomains property</param>
	/// <returns>this instance</returns>
	public ListDomains WithMaxNumberOfDomains(decimal maxNumberOfDomains)
	{
		maxNumberOfDomainsField = maxNumberOfDomains;
		return this;
	}

	/// <summary>
	/// Checks if MaxNumberOfDomains property is set
	/// </summary>
	/// <returns>true if MaxNumberOfDomains property is set</returns>
	public bool IsSetMaxNumberOfDomains()
	{
		return maxNumberOfDomainsField.HasValue;
	}

	/// <summary>
	/// Sets the NextToken property
	/// </summary>
	/// <param name="nextToken">NextToken property</param>
	/// <returns>this instance</returns>
	public ListDomains WithNextToken(string nextToken)
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
		parameters.Add("Action", "ListDomains");
		if (IsSetMaxNumberOfDomains())
		{
			parameters.Add("MaxNumberOfDomains", string.Concat(MaxNumberOfDomains));
		}
		if (IsSetNextToken())
		{
			parameters.Add("NextToken", NextToken);
		}
		return parameters;
	}
}
