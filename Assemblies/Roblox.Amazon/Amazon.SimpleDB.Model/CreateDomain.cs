using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class CreateDomain
{
	private string domainNameField;

	/// <summary>
	/// Gets and sets the DomainName property.
	/// </summary>
	[XmlElement(ElementName = "DomainName")]
	public string DomainName => domainNameField;

	public CreateDomain(string domainName)
	{
		domainNameField = domainName;
	}

	/// <summary>
	/// Representation of operation that returns
	/// Dictionary of AWS Query Parameters
	/// </summary>
	public IDictionary<string, string> ToMap()
	{
		return new Dictionary<string, string>
		{
			{ "Action", "CreateDomain" },
			{ "DomainName", DomainName }
		};
	}
}
