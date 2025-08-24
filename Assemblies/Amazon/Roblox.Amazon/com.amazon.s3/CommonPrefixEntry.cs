using System.Xml;

namespace com.amazon.s3;

public class CommonPrefixEntry
{
	/// <summary>
	/// The prefix common to the delimited keys it represents.
	/// </summary>
	private string prefix;

	public string Prefix
	{
		get
		{
			return prefix;
		}
		set
		{
			prefix = value;
		}
	}

	public CommonPrefixEntry(string prefix)
	{
		this.prefix = prefix;
	}

	public CommonPrefixEntry(XmlNode node)
	{
		foreach (XmlNode child in node.ChildNodes)
		{
			if (child.Name.Equals("Prefix"))
			{
				prefix = Utils.getXmlChildText(child);
			}
		}
	}
}
