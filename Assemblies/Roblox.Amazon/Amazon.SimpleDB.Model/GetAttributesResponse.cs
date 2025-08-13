using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class GetAttributesResponse
{
	private GetAttributesResult getAttributesResultField;

	private ResponseMetadata responseMetadataField;

	/// <summary>
	/// Gets and sets the GetAttributesResult property.
	/// </summary>
	[XmlElement(ElementName = "GetAttributesResult")]
	public GetAttributesResult GetAttributesResult
	{
		get
		{
			return getAttributesResultField;
		}
		set
		{
			getAttributesResultField = value;
		}
	}

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
	/// Sets the GetAttributesResult property
	/// </summary>
	/// <param name="getAttributesResult">GetAttributesResult property</param>
	/// <returns>this instance</returns>
	public GetAttributesResponse WithGetAttributesResult(GetAttributesResult getAttributesResult)
	{
		getAttributesResultField = getAttributesResult;
		return this;
	}

	/// <summary>
	/// Checks if GetAttributesResult property is set
	/// </summary>
	/// <returns>true if GetAttributesResult property is set</returns>
	public bool IsSetGetAttributesResult()
	{
		return getAttributesResultField != null;
	}

	/// <summary>
	/// Sets the ResponseMetadata property
	/// </summary>
	/// <param name="responseMetadata">ResponseMetadata property</param>
	/// <returns>this instance</returns>
	public GetAttributesResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
		xml.Append("<GetAttributesResponse xmlns=\"http://sdb.amazonaws.com/doc/2007-11-07/\">");
		if (IsSetGetAttributesResult())
		{
			GetAttributesResult getAttributesResult = GetAttributesResult;
			xml.Append("<GetAttributesResult>");
			xml.Append(getAttributesResult.ToXMLFragment());
			xml.Append("</GetAttributesResult>");
		}
		if (IsSetResponseMetadata())
		{
			ResponseMetadata responseMetadata = ResponseMetadata;
			xml.Append("<ResponseMetadata>");
			xml.Append(responseMetadata.ToXMLFragment());
			xml.Append("</ResponseMetadata>");
		}
		xml.Append("</GetAttributesResponse>");
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
