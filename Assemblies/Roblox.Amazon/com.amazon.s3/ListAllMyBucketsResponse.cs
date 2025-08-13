using System.Collections;
using System.IO;
using System.Net;
using System.Xml;

namespace com.amazon.s3;

public class ListAllMyBucketsResponse : Response
{
	private Owner owner;

	private ArrayList buckets;

	public Owner Owner => owner;

	public ArrayList Buckets => buckets;

	private ListAllMyBucketsResponse()
	{
	}

	protected override void Process(WebRequest request)
	{
		base.Process(request);
		buckets = new ArrayList();
		string rawBucketXML;
		using (Stream stream = response.GetResponseStream())
		{
			rawBucketXML = Utils.slurpInputStreamAsString(stream);
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(rawBucketXML);
		foreach (XmlNode node in xmlDocument.ChildNodes)
		{
			if (!node.Name.Equals("ListAllMyBucketsResult"))
			{
				continue;
			}
			foreach (XmlNode child in node.ChildNodes)
			{
				string name = child.Name;
				if (!(name == "Owner"))
				{
					if (!(name == "Buckets"))
					{
						continue;
					}
					foreach (XmlNode bucket in child.ChildNodes)
					{
						if (bucket.Name.Equals("Bucket"))
						{
							buckets.Add(new Bucket(bucket));
						}
					}
				}
				else
				{
					owner = new Owner(child);
				}
			}
		}
	}

	public new static ListAllMyBucketsResponse Get(WebRequest request)
	{
		ListAllMyBucketsResponse listAllMyBucketsResponse = new ListAllMyBucketsResponse();
		listAllMyBucketsResponse.Process(request);
		return listAllMyBucketsResponse;
	}
}
