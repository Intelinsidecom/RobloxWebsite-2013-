using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class GetAttributes
{
	private string domainNameField;

	private string itemNameField;

	private List<string> attributeNameField;

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
	/// Gets and sets the ItemName property.
	/// </summary>
	[XmlElement(ElementName = "ItemName")]
	public string ItemName
	{
		get
		{
			return itemNameField;
		}
		set
		{
			itemNameField = value;
		}
	}

	/// <summary>
	/// Gets and sets the AttributeName property.
	/// </summary>
	[XmlElement(ElementName = "AttributeName")]
	public List<string> AttributeName
	{
		get
		{
			if (attributeNameField == null)
			{
				attributeNameField = new List<string>();
			}
			return attributeNameField;
		}
		set
		{
			attributeNameField = value;
		}
	}

	/// <summary>
	/// Sets the DomainName property
	/// </summary>
	/// <param name="domainName">DomainName property</param>
	/// <returns>this instance</returns>
	public GetAttributes WithDomainName(string domainName)
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
	/// Sets the ItemName property
	/// </summary>
	/// <param name="itemName">ItemName property</param>
	/// <returns>this instance</returns>
	public GetAttributes WithItemName(string itemName)
	{
		itemNameField = itemName;
		return this;
	}

	/// <summary>
	/// Checks if ItemName property is set
	/// </summary>
	/// <returns>true if ItemName property is set</returns>
	public bool IsSetItemName()
	{
		return itemNameField != null;
	}

	/// <summary>
	/// Sets the AttributeName property
	/// </summary>
	/// <param name="list">AttributeName property</param>
	/// <returns>this instance</returns>
	public GetAttributes WithAttributeName(params string[] list)
	{
		foreach (string item in list)
		{
			AttributeName.Add(item);
		}
		return this;
	}

	/// <summary>
	/// Checks of AttributeName property is set
	/// </summary>
	/// <returns>true if AttributeName property is set</returns>
	public bool IsSetAttributeName()
	{
		return AttributeName.Count > 0;
	}

	/// <summary>
	/// Representation of operation that returns
	/// Dictionary of AWS Query Parameters
	/// </summary>
	public IDictionary<string, string> ToMap()
	{
		IDictionary<string, string> parameters = new Dictionary<string, string>();
		parameters.Add("Action", "GetAttributes");
		if (IsSetDomainName())
		{
			parameters.Add("DomainName", DomainName);
		}
		if (IsSetItemName())
		{
			parameters.Add("ItemName", ItemName);
		}
		List<string> attributeNameList = AttributeName;
		foreach (string attributeName in attributeNameList)
		{
			parameters.Add("AttributeName." + (attributeNameList.IndexOf(attributeName) + 1), attributeName);
		}
		return parameters;
	}
}
