using System.Xml;

namespace com.amazon.s3;

public class Owner
{
	private string id;

	private string displayName;

	public string Id => id;

	public string DisplayName => displayName;

	public Owner(string id, string displayName)
	{
		this.id = id;
		this.displayName = displayName;
	}

	public Owner(XmlNode node)
	{
		foreach (XmlNode child in node.ChildNodes)
		{
			if (child.Name.Equals("ID"))
			{
				id = Utils.getXmlChildText(child);
			}
			else if (child.Name.Equals("DisplayName"))
			{
				displayName = Utils.getXmlChildText(child);
			}
		}
	}
}
