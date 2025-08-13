using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class DeleteAttributesResponse
{
	private ResponseMetadata responseMetadataField;

	/// <summary>
	/// Gets and sets the ResponseMetadata property.
	/// </summary>
	[XmlElement(ElementName = "ResponseMetadata")]
	public ResponseMetadata ResponseMetadata
	{
		get
		{
			return responseMetadataField;
		}
		set
		{
			responseMetadataField = value;
		}
	}

	/// <summary>
	/// Sets the ResponseMetadata property
	/// </summary>
	/// <param name="responseMetadata">ResponseMetadata property</param>
	/// <returns>this instance</returns>
	public DeleteAttributesResponse WithResponseMetadata(ResponseMetadata responseMetadata)
	{
		responseMetadataField = responseMetadata;
		return this;
	}

	/// <summary>
	/// Checks if ResponseMetadata property is set
	/// </summary>
	/// <returns>true if ResponseMetadata property is set</returns>
	public bool IsSetResponseMetadata()
	{
		return responseMetadataField != null;
	}

	/// <summary>
	/// XML Representation for this object
	/// </summary>
	/// <returns>XML String</returns>
	public string ToXML()
	{
		StringBuilder xml = new StringBuilder();
		xml.Append("<DeleteAttributesResponse xmlns=\"http://sdb.amazonaws.com/doc/2007-11-07/\">");
		if (IsSetResponseMetadata())
		{
			ResponseMetadata responseMetadata = ResponseMetadata;
			xml.Append("<ResponseMetadata>");
			xml.Append(responseMetadata.ToXMLFragment());
			xml.Append("</ResponseMetadata>");
		}
		xml.Append("</DeleteAttributesResponse>");
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
