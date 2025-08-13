using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleDB.Model;

[XmlType(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/")]
[XmlRoot(Namespace = "http://sdb.amazonaws.com/doc/2007-11-07/", IsNullable = false)]
public class QueryResult
{
	private List<string> itemNameField;

	private string nextTokenField;

	/// <summary>
	/// Gets and sets the ItemName property.
	/// </summary>
	[XmlElement(ElementName = "ItemName")]
	public List<string> ItemName
	{
		get
		{
			if (itemNameField == null)
			{
				itemNameField = new List<string>();
			}
			return itemNameField;
		}
		set
		{
			itemNameField = value;
		}
	}

	/// <summary>
	/// Gets and sets the NextToken property.
	/// </summary>
	[XmlElement(ElementName = "NextToken")]
	public string NextToken
	{
		get
		{
			return nextTokenField;
		}
		set
		{
			nextTokenField = value;
		}
	}

	/// <summary>
	/// Sets the ItemName property
	/// </summary>
	/// <param name="list">ItemName property</param>
	/// <returns>this instance</returns>
	public QueryResult WithItemName(params string[] list)
	{
		foreach (string item in list)
		{
			ItemName.Add(item);
		}
		return this;
	}

	/// <summary>
	/// Checks of ItemName property is set
	/// </summary>
	/// <returns>true if ItemName property is set</returns>
	public bool IsSetItemName()
	{
		return ItemName.Count > 0;
	}

	/// <summary>
	/// Sets the NextToken property
	/// </summary>
	/// <param name="nextToken">NextToken property</param>
	/// <returns>this instance</returns>
	public QueryResult WithNextToken(string nextToken)
	{
		nextTokenField = nextToken;
		return this;
	}

	/// <summary>
	/// Checks if NextToken property is set
	/// </summary>
	/// <returns>true if NextToken property is set</returns>
	public bool IsSetNextToken()
	{
		return nextTokenField != null;
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
		foreach (string itemName in ItemName)
		{
			xml.Append("<ItemName>");
			xml.Append(EscapeXML(itemName));
			xml.Append("</ItemName>");
		}
		if (IsSetNextToken())
		{
			xml.Append("<NextToken>");
			xml.Append(EscapeXML(NextToken));
			xml.Append("</NextToken>");
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
