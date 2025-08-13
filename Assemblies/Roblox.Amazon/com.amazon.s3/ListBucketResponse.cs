using System.Collections;
using System.IO;
using System.Net;
using System.Xml;

namespace com.amazon.s3;

public class ListBucketResponse : Response
{
	/// <summary>
	/// The name of the bucket being listed.  Null if the request fails.
	/// </summary>
	private string name;

	/// <summary>
	/// The prefix echoed back from the request.  Null if the request fails.
	/// </summary>
	private string prefix;

	/// <summary>
	/// The marker echoed back from the request.  Null if the request fails.
	/// </summary>
	private string marker;

	/// <summary>
	/// The delimiter echoed back from the request.  Null if not specified in
	/// the request or it fails.
	/// </summary>
	private string delimiter;

	/// <summary>
	/// The maxKeys echoed back from the request if specified.  0 if the request fails.
	/// </summary>
	private int maxKeys;

	/// <summary>
	/// Indicates if there are more results to the list.  True if the current
	/// list results have been truncated.  The value will be false if the request
	/// fails.
	/// </summary>
	private bool isTruncated;

	/// <summary>
	/// Indicates what to use as a marker for subsequent list requests in the event
	/// that the results are truncated.  Present only when a delimiter is specified.
	/// Null if the requests fails.
	/// </summary>
	private string nextMarker;

	/// <summary>
	/// A list of ListEntry objects representing the objects in the given bucket.
	/// Null if the request fails.
	/// </summary>
	private ArrayList entries;

	/// <summary>
	/// A list of CommonPrefixEntry objects representing the common prefixes of the
	/// keys that matched up to the delimiter.  Null if the request fails.
	/// </summary>
	private ArrayList commonPrefixEntries;

	public string Name => name;

	public string Prefix => prefix;

	public string Marker => marker;

	public string Delimiter => delimiter;

	public int MaxKeys => maxKeys;

	public bool IsTruncated => isTruncated;

	public string NextMarker => nextMarker;

	public ArrayList Entries => entries;

	public ArrayList CommonPrefixEntries => commonPrefixEntries;

	private ListBucketResponse()
	{
	}

	protected override void Process(WebRequest request)
	{
		base.Process(request);
		entries = new ArrayList();
		commonPrefixEntries = new ArrayList();
		string rawBucketXML;
		using (Stream stream = response.GetResponseStream())
		{
			rawBucketXML = Utils.slurpInputStreamAsString(stream);
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(rawBucketXML);
		foreach (XmlNode node in xmlDocument.ChildNodes)
		{
			if (!node.Name.Equals("ListBucketResult"))
			{
				continue;
			}
			foreach (XmlNode child in node.ChildNodes)
			{
				switch (child.Name)
				{
				case "Contents":
					entries.Add(new ListEntry(child));
					break;
				case "CommonPrefixes":
					commonPrefixEntries.Add(new CommonPrefixEntry(child));
					break;
				case "Name":
					name = Utils.getXmlChildText(child);
					break;
				case "Prefix":
					prefix = Utils.getXmlChildText(child);
					break;
				case "Marker":
					marker = Utils.getXmlChildText(child);
					break;
				case "Delimiter":
					delimiter = Utils.getXmlChildText(child);
					break;
				case "MaxKeys":
					maxKeys = int.Parse(Utils.getXmlChildText(child));
					break;
				case "IsTruncated":
					isTruncated = bool.Parse(Utils.getXmlChildText(child));
					break;
				case "NextMarker":
					nextMarker = Utils.getXmlChildText(child);
					break;
				}
			}
		}
	}

	public new static ListBucketResponse Get(WebRequest request)
	{
		ListBucketResponse listBucketResponse = new ListBucketResponse();
		listBucketResponse.Process(request);
		return listBucketResponse;
	}
}
