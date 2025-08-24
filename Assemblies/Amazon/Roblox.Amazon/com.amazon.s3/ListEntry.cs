using System;
using System.Xml;

namespace com.amazon.s3;

public class ListEntry
{
	private string key;

	private DateTime lastModified;

	private string etag;

	private long size;

	private string storageClass;

	private Owner owner;

	public string Key => key;

	public DateTime LastModified => lastModified;

	public string ETag => etag;

	public long Size => size;

	public string StorageClass => storageClass;

	public Owner Owner => owner;

	public ListEntry(string key, DateTime lastModified, string etag, long size, string storageClass, Owner owner)
	{
		this.key = key;
		this.lastModified = lastModified;
		this.etag = etag;
		this.size = size;
		this.storageClass = storageClass;
		this.owner = owner;
	}

	public ListEntry(XmlNode node)
	{
		foreach (XmlNode child in node.ChildNodes)
		{
			if (child.Name.Equals("Key"))
			{
				key = Utils.getXmlChildText(child);
			}
			else if (child.Name.Equals("LastModified"))
			{
				string value = Utils.getXmlChildText(child);
				lastModified = Utils.parseDate(value);
			}
			else if (child.Name.Equals("ETag"))
			{
				etag = Utils.getXmlChildText(child);
			}
			else if (child.Name.Equals("Size"))
			{
				size = long.Parse(Utils.getXmlChildText(child));
			}
			else if (child.Name.Equals("Owner"))
			{
				owner = new Owner(child);
			}
			else if (child.Name.Equals("StorageClass"))
			{
				storageClass = Utils.getXmlChildText(child);
			}
		}
	}
}
