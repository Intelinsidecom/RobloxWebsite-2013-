using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class GetAttributesResult
{
	private List<Attribute> attributeField;

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
	/// Sets the Attribute property
	/// </summary>
	/// <param name="list">Attribute property</param>
	/// <returns>this instance</returns>
	public GetAttributesResult WithAttribute(params Attribute[] list)
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
	/// XML fragment representation of this object
	/// </summary>
	/// <returns>XML fragment for this object.</returns>
	/// <remarks>
	/// Name for outer tag expected to be set by calling method. 
	/// This fragment returns inner properties representation only
	/// </remarks>
	protected internal string ToXMLFragment()
	{
		StringBuilder xml = new StringBuilder();
		foreach (Attribute attribute in Attribute)
		{
			xml.Append("<Attribute>");
			xml.Append(attribute.ToXMLFragment());
			xml.Append("</Attribute>");
		}
		return xml.ToString();
	}

	/// Escape XML special characters
	private string EscapeXML(string str)
	{
		StringBuilder sb = new StringBuilder();
		foreach (char c in str)
		{
			switch (c)
			{
			case '&':
				sb.Append("&amp;");
				break;
			case '<':
				sb.Append("&lt;");
				break;
			case '>':
				sb.Append("&gt;");
				break;
			case '\'':
				sb.Append("&#039;");
				break;
			case '"':
				sb.Append("&quot;");
				break;
			default:
				sb.Append(c);
				break;
			}
		}
		return sb.ToString();
	}
}
