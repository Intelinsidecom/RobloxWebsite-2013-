using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class DeleteAttributes
{
	private string domainNameField;

	private string itemNameField;

	private List<Attribute> attributeField;

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
	/// Gets and sets the Attribute property.
	/// </summary>
	[XmlElement(ElementName = "Attribute")]
	public List<Attribute> Attribute
	{
		get
		{
			if (attributeField == null)
			{
				attributeField = new List<Attribute>();
			}
			return attributeField;
		}
		set
		{
			attributeField = value;
		}
	}

	/// <summary>
	/// Sets the DomainName property
	/// </summary>
	/// <param name="domainName">DomainName property</param>
	/// <returns>this instance</returns>
	public DeleteAttributes WithDomainName(string domainName)
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
	public DeleteAttributes WithItemName(string itemName)
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
	/// Sets the Attribute property
	/// </summary>
	/// <param name="list">Attribute property</param>
	/// <returns>this instance</returns>
	public DeleteAttributes WithAttribute(params Attribute[] list)
	{
		foreach (Attribute item in list)
		{
			Attribute.Add(item);
		}
		return this;
	}

	/// <summary>
	/// Checks if Attribute property is set
	/// </summary>
	/// <returns>true if Attribute property is set</returns>
	public bool IsSetAttribute()
	{
		return Attribute.Count > 0;
	}

	/// <summary>
	/// Representation of operation that returns
	/// Dictionary of AWS Query Parameters
	/// </summary>
	public IDictionary<string, string> ToMap()
	{
		IDictionary<string, string> parameters = new Dictionary<string, string>();
		parameters.Add("Action", "DeleteAttributes");
		if (IsSetDomainName())
		{
			parameters.Add("DomainName", DomainName);
		}
		if (IsSetItemName())
		{
			parameters.Add("ItemName", ItemName);
		}
		List<Attribute> attributeList = Attribute;
		foreach (Attribute attribute in attributeList)
		{
			if (attribute.IsSetName())
			{
				parameters.Add("Attribute." + (attributeList.IndexOf(attribute) + 1) + ".Name", attribute.Name);
			}
			if (attribute.IsSetValue())
			{
				parameters.Add("Attribute." + (attributeList.IndexOf(attribute) + 1) + ".Value", attribute.Value);
			}
		}
		return parameters;
	}
}
