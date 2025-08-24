using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class DeleteDomain
{
	private string domainNameField;

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
	/// Sets the DomainName property
	/// </summary>
	/// <param name="domainName">DomainName property</param>
	/// <returns>this instance</returns>
	public DeleteDomain WithDomainName(string domainName)
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
	/// Representation of operation that returns
	/// Dictionary of AWS Query Parameters
	/// </summary>
	public IDictionary<string, string> ToMap()
	{
		IDictionary<string, string> parameters = new Dictionary<string, string>();
		parameters.Add("Action", "DeleteDomain");
		if (IsSetDomainName())
		{
			parameters.Add("DomainName", DomainName);
		}
		return parameters;
	}
}
