using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class Error
{
	private string typeField;

	private string codeField;

	private string messageField;

	private object detailField;

	/// <summary>
	/// Gets and sets the Type property.
	/// </summary>
	[XmlElement(ElementName = "Type")]
	public string Type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
		}
	}

	/// <summary>
	/// Gets and sets the Code property.
	/// </summary>
	[XmlElement(ElementName = "Code")]
	public string Code
	{
		get
		{
			return codeField;
		}
		set
		{
			codeField = value;
		}
	}

	/// <summary>
	/// Gets and sets the Message property.
	/// </summary>
	[XmlElement(ElementName = "Message")]
	public string Message
	{
		get
		{
			return messageField;
		}
		set
		{
			messageField = value;
		}
	}

	/// <summary>
	/// Gets and sets the Detail property.
	/// </summary>
	[XmlElement(ElementName = "Detail")]
	public object Detail
	{
		get
		{
			return detailField;
		}
		set
		{
			detailField = value;
		}
	}

	/// <summary>
	/// Sets the Type property
	/// </summary>
	/// <param name="type">Type property</param>
	/// <returns>this instance</returns>
	public Error WithType(string type)
	{
		typeField = type;
		return this;
	}

	/// <summary>
	/// Checks if Type property is set
	/// </summary>
	/// <returns>true if Type property is set</returns>
	public bool IsSetType()
	{
		return typeField != null;
	}

	/// <summary>
	/// Sets the Code property
	/// </summary>
	/// <param name="code">Code property</param>
	/// <returns>this instance</returns>
	public Error WithCode(string code)
	{
		codeField = code;
		return this;
	}

	/// <summary>
	/// Checks if Code property is set
	/// </summary>
	/// <returns>true if Code property is set</returns>
	public bool IsSetCode()
	{
		return codeField != null;
	}

	/// <summary>
	/// Sets the Message property
	/// </summary>
	/// <param name="message">Message property</param>
	/// <returns>this instance</returns>
	public Error WithMessage(string message)
	{
		messageField = message;
		return this;
	}

	/// <summary>
	/// Checks if Message property is set
	/// </summary>
	/// <returns>true if Message property is set</returns>
	public bool IsSetMessage()
	{
		return messageField != null;
	}

	/// <summary>
	/// Sets the Detail property
	/// </summary>
	/// <param name="detail">Detail property</param>
	/// <returns>this instance</returns>
	public Error WithDetail(object detail)
	{
		detailField = detail;
		return this;
	}

	/// <summary>
	/// Checks if Detail property is set
	/// </summary>
	/// <returns>true if Detail property is set</returns>
	public bool IsSetDetail()
	{
		return detailField != null;
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
		if (IsSetType())
		{
			xml.Append("<Type>");
			xml.Append(Type);
			xml.Append("</Type>");
		}
		if (IsSetCode())
		{
			xml.Append("<Code>");
			xml.Append(EscapeXML(Code));
			xml.Append("</Code>");
		}
		if (IsSetMessage())
		{
			xml.Append("<Message>");
			xml.Append(EscapeXML(Message));
			xml.Append("</Message>");
		}
		if (IsSetDetail())
		{
			object detail = Detail;
			xml.Append("<Detail>");
			xml.Append(detail.ToString());
			xml.Append("</Detail>");
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
