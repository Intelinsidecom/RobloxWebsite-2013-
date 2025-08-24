using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class QueryResponse
{
	private QueryResult queryResultField;

	private ResponseMetadata responseMetadataField;

	/// <summary>
	/// Gets and sets the QueryResult property.
	/// </summary>
	[XmlElement(ElementName = "QueryResult")]
	public QueryResult QueryResult
	{
		get
		{
			return queryResultField;
		}
		set
		{
			queryResultField = value;
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
	/// Sets the QueryResult property
	/// </summary>
	/// <param name="queryResult">QueryResult property</param>
	/// <returns>this instance</returns>
	public QueryResponse WithQueryResult(QueryResult queryResult)
	{
		queryResultField = queryResult;
		return this;
	}

	/// <summary>
	/// Checks if QueryResult property is set
	/// </summary>
	/// <returns>true if QueryResult property is set</returns>
	public bool IsSetQueryResult()
	{
		return queryResultField != null;
	}

	/// <summary>
	/// Sets the ResponseMetadata property
	/// </summary>
	/// <param name="responseMetadata">ResponseMetadata property</param>
	/// <returns>this instance</returns>
	public QueryResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
		xml.Append("<QueryResponse xmlns=\"http://sdb.amazonaws.com/doc/2007-11-07/\">");
		if (IsSetQueryResult())
		{
			QueryResult queryResult = QueryResult;
			xml.Append("<QueryResult>");
			xml.Append(queryResult.ToXMLFragment());
			xml.Append("</QueryResult>");
		}
		if (IsSetResponseMetadata())
		{
			ResponseMetadata responseMetadata = ResponseMetadata;
			xml.Append("<ResponseMetadata>");
			xml.Append(responseMetadata.ToXMLFragment());
			xml.Append("</ResponseMetadata>");
		}
		xml.Append("</QueryResponse>");
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
