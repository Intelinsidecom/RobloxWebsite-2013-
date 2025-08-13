using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class ReplaceableAttribute
{
	private string nameField;

	private string valueField;

	private bool? replaceField;

	/// <summary>
	/// Gets and sets the Name property.
	/// </summary>
	[XmlElement(ElementName = "Name")]
	public string Name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
		}
	}

	/// <summary>
	/// Gets and sets the Value property.
	/// </summary>
	[XmlElement(ElementName = "Value")]
	public string Value
	{
		get
		{
			return valueField;
		}
		set
		{
			valueField = value;
		}
	}

	/// <summary>
	/// Gets and sets the Replace property.
	/// </summary>
	[XmlElement(ElementName = "Replace")]
	public bool Replace
	{
		get
		{
			return replaceField.GetValueOrDefault();
		}
		set
		{
			replaceField = value;
		}
	}

	/// <summary>
	/// Sets the Name property
	/// </summary>
	/// <param name="name">Name property</param>
	/// <returns>this instance</returns>
	public ReplaceableAttribute WithName(string name)
	{
		nameField = name;
		return this;
	}

	/// <summary>
	/// Checks if Name property is set
	/// </summary>
	/// <returns>true if Name property is set</returns>
	public bool IsSetName()
	{
		return nameField != null;
	}

	/// <summary>
	/// Sets the Value property
	/// </summary>
	/// <param name="value">Value property</param>
	/// <returns>this instance</returns>
	public ReplaceableAttribute WithValue(string value)
	{
		valueField = value;
		return this;
	}

	/// <summary>
	/// Checks if Value property is set
	/// </summary>
	/// <returns>true if Value property is set</returns>
	public bool IsSetValue()
	{
		return valueField != null;
	}

	/// <summary>
	/// Sets the Replace property
	/// </summary>
	/// <param name="replace">Replace property</param>
	/// <returns>this instance</returns>
	public ReplaceableAttribute WithReplace(bool replace)
	{
		replaceField = replace;
		return this;
	}

	/// <summary>
	/// Checks if Replace property is set
	/// </summary>
	/// <returns>true if Replace property is set</returns>
	public bool IsSetReplace()
	{
		return replaceField.HasValue;
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
		if (IsSetName())
		{
			xml.Append("<Name>");
			xml.Append(EscapeXML(Name));
			xml.Append("</Name>");
		}
		if (IsSetValue())
		{
			xml.Append("<Value>");
			xml.Append(EscapeXML(Value));
			xml.Append("</Value>");
		}
		if (IsSetReplace())
		{
			xml.Append("<Replace>");
			xml.Append(Replace);
			xml.Append("</Replace>");
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
