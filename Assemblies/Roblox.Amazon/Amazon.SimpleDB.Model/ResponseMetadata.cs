using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class ResponseMetadata
{
	private string requestIdField;

	private string boxUsageField;

	/// <summary>
	/// Gets and sets the RequestId property.
	/// </summary>
	[XmlElement(ElementName = "RequestId")]
	public string RequestId
	{
		get
		{
			return requestIdField;
		}
		set
		{
			requestIdField = value;
		}
	}

	/// <summary>
	/// Gets and sets the BoxUsage property.
	/// </summary>
	[XmlElement(ElementName = "BoxUsage")]
	public string BoxUsage
	{
		get
		{
			return boxUsageField;
		}
		set
		{
			boxUsageField = value;
		}
	}

	/// <summary>
	/// Sets the RequestId property
	/// </summary>
	/// <param name="requestId">RequestId property</param>
	/// <returns>this instance</returns>
	public ResponseMetadata WithRequestId(string requestId)
	{
		requestIdField = requestId;
		return this;
	}

	/// <summary>
	/// Checks if RequestId property is set
	/// </summary>
	/// <returns>true if RequestId property is set</returns>
	public bool IsSetRequestId()
	{
		return requestIdField != null;
	}

	/// <summary>
	/// Sets the BoxUsage property
	/// </summary>
	/// <param name="boxUsage">BoxUsage property</param>
	/// <returns>this instance</returns>
	public ResponseMetadata WithBoxUsage(string boxUsage)
	{
		boxUsageField = boxUsage;
		return this;
	}

	/// <summary>
	/// Checks if BoxUsage property is set
	/// </summary>
	/// <returns>true if BoxUsage property is set</returns>
	public bool IsSetBoxUsage()
	{
		return boxUsageField != null;
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
		if (IsSetRequestId())
		{
			xml.Append("<RequestId>");
			xml.Append(EscapeXML(RequestId));
			xml.Append("</RequestId>");
		}
		if (IsSetBoxUsage())
		{
			xml.Append("<BoxUsage>");
			xml.Append(EscapeXML(BoxUsage));
			xml.Append("</BoxUsage>");
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
