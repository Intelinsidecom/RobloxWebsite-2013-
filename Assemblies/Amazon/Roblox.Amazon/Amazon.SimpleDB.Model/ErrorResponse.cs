using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class ErrorResponse
{
	private List<Error> errorField;

	private string requestIdField;

	/// <summary>
	/// Gets and sets the Error property.
	/// </summary>
	[XmlElement(ElementName = "Error")]
	public List<Error> Error
	{
		get
		{
			if (errorField == null)
			{
				errorField = new List<Error>();
			}
			return errorField;
		}
		set
		{
			errorField = value;
		}
	}

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
	/// Sets the Error property
	/// </summary>
	/// <param name="list">Error property</param>
	/// <returns>this instance</returns>
	public ErrorResponse WithError(params Error[] list)
	{
		foreach (Error item in list)
		{
			Error.Add(item);
		}
		return this;
	}

	/// <summary>
	/// Checks if Error property is set
	/// </summary>
	/// <returns>true if Error property is set</returns>
	public bool IsSetError()
	{
		return Error.Count > 0;
	}

	/// <summary>
	/// Sets the RequestId property
	/// </summary>
	/// <param name="requestId">RequestId property</param>
	/// <returns>this instance</returns>
	public ErrorResponse WithRequestId(string requestId)
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
	/// XML Representation for this object
	/// </summary>
	/// <returns>XML String</returns>
	public string ToXML()
	{
		StringBuilder xml = new StringBuilder();
		xml.Append("<ErrorResponse xmlns=\"http://sdb.amazonaws.com/doc/2007-11-07/\">");
		foreach (Error error in Error)
		{
			xml.Append("<Error>");
			xml.Append(error.ToXMLFragment());
			xml.Append("</Error>");
		}
		if (IsSetRequestId())
		{
			xml.Append("<RequestId>");
			xml.Append(EscapeXML(RequestId));
			xml.Append("</RequestId>");
		}
		xml.Append("</ErrorResponse>");
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
