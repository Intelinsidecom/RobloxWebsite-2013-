using System;
using System.Xml;

namespace com.amazon.s3;

public class Bucket
{
	private string name;

	private DateTime creationDate;

	public string Name => name;

	public DateTime CreationDate => creationDate;

	public Bucket(string name, DateTime creationDate)
	{
		this.name = name;
		this.creationDate = creationDate;
	}

	public Bucket(XmlNode node)
	{
		foreach (XmlNode child in node.ChildNodes)
		{
			if (child.Name.Equals("Name"))
			{
				name = Utils.getXmlChildText(child);
			}
			else if (child.Name.Equals("CreationDate"))
			{
				string strDate = Utils.getXmlChildText(child);
				creationDate = Utils.parseDate(strDate);
			}
		}
	}
}
