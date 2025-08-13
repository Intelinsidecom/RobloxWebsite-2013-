using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Xml;

namespace com.amazon.s3;

internal class Utils
{
	public static readonly string METADATA_PREFIX = "x-amz-meta-";

	public static readonly string AMAZON_HEADER_PREFIX = "x-amz-";

	public static readonly string ALTERNATIVE_DATE_HEADER = "x-amz-date";

	private static string host = "s3.amazonaws.com";

	private static int securePort = 443;

	private static int insecurePort = 80;

	public static string Host
	{
		get
		{
			return host;
		}
		set
		{
			host = value;
		}
	}

	public static int SecurePort
	{
		get
		{
			return securePort;
		}
		set
		{
			securePort = value;
		}
	}

	public static int InsecurePort
	{
		get
		{
			return insecurePort;
		}
		set
		{
			insecurePort = value;
		}
	}

	/// <summary>
	/// Calculates the endpoint based on the calling format.
	/// </summary>
	public static string buildUrlBase(string server, int port, string bucket, CallingFormat format)
	{
		StringBuilder endpoint = new StringBuilder();
		switch (format)
		{
		case CallingFormat.REGULAR:
			endpoint.Append(server);
			endpoint.Append(":");
			endpoint.Append(port);
			if (bucket != null && !bucket.Equals(""))
			{
				endpoint.Append("/");
				endpoint.Append(bucket);
			}
			break;
		case CallingFormat.SUBDOMAIN:
			if (bucket.Length != 0)
			{
				endpoint.Append(bucket);
				endpoint.Append(".");
			}
			endpoint.Append(server);
			endpoint.Append(":");
			endpoint.Append(port);
			break;
		case CallingFormat.VANITY:
			endpoint.Append(bucket);
			endpoint.Append(":");
			endpoint.Append(port);
			break;
		}
		endpoint.Append("/");
		return endpoint.ToString();
	}

	public static string convertQueryListToQueryString(SortedList query)
	{
		StringBuilder queryString = new StringBuilder();
		bool firstParameter = true;
		if (query != null)
		{
			foreach (string key in query.Keys)
			{
				if (firstParameter)
				{
					firstParameter = false;
					queryString.Append("?");
				}
				else
				{
					queryString.Append("&");
				}
				queryString.Append(key);
				string value = (string)query[key];
				if (value != null && value.Length != 0)
				{
					queryString.Append("=");
					queryString.Append(value);
				}
			}
		}
		return queryString.ToString();
	}

	public static long currentTimeMillis()
	{
		return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
	}

	public static string encode(string awsSecretAccessKey, string canonicalString, bool urlEncode)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		Encoding ae = new UTF8Encoding();
		string b64 = Convert.ToBase64String(((HashAlgorithm)new HMACSHA1(ae.GetBytes(awsSecretAccessKey))).ComputeHash(ae.GetBytes(canonicalString.ToCharArray())));
		if (urlEncode)
		{
			return HttpUtility.UrlEncode(b64);
		}
		return b64;
	}

	public static string getHttpDate()
	{
		return DateTime.UtcNow.ToString("ddd, dd MMM yyyy HH:mm:ss ", CultureInfo.InvariantCulture) + "GMT";
	}

	public static string getXmlChildText(XmlNode data)
	{
		StringBuilder builder = new StringBuilder();
		foreach (XmlNode node in data.ChildNodes)
		{
			if (node.NodeType == XmlNodeType.Text || node.NodeType == XmlNodeType.CDATA)
			{
				builder.Append(node.Value);
			}
		}
		return builder.ToString();
	}

	public static string makeCanonicalString(string bucket, string key, WebRequest request)
	{
		return makeCanonicalString(bucket, key, new SortedList(), request);
	}

	public static string makeCanonicalString(string bucket, string key, SortedList query, WebRequest request)
	{
		SortedList headers = new SortedList();
		foreach (string header in request.Headers)
		{
			headers.Add(header, request.Headers[header]);
		}
		if (headers["Content-Type"] == null)
		{
			headers.Add("Content-Type", request.ContentType);
		}
		return makeCanonicalString(request.Method, bucket, key, query, headers, null);
	}

	public static string makeCanonicalString(string verb, string bucketName, string key, SortedList queryParams, SortedList headers, string expires)
	{
		StringBuilder buf = new StringBuilder();
		buf.Append(verb);
		buf.Append("\n");
		SortedList interestingHeaders = new SortedList();
		if (headers != null)
		{
			foreach (string header3 in headers.Keys)
			{
				string lk = header3.ToLower();
				if (lk.Equals("content-type") || lk.Equals("content-md5") || lk.Equals("date") || lk.StartsWith(AMAZON_HEADER_PREFIX))
				{
					interestingHeaders.Add(lk, headers[header3]);
				}
			}
		}
		if (interestingHeaders[ALTERNATIVE_DATE_HEADER] != null)
		{
			interestingHeaders.Add("date", "");
		}
		if (expires != null)
		{
			interestingHeaders.Add("date", expires);
		}
		string[] array = new string[2] { "content-type", "content-md5" };
		foreach (string header in array)
		{
			if (interestingHeaders.IndexOfKey(header) == -1)
			{
				interestingHeaders.Add(header, "");
			}
		}
		foreach (string header2 in interestingHeaders.Keys)
		{
			if (header2.StartsWith(AMAZON_HEADER_PREFIX))
			{
				buf.Append(header2).Append(":").Append((interestingHeaders[header2] as string).Trim());
			}
			else
			{
				buf.Append(interestingHeaders[header2]);
			}
			buf.Append("\n");
		}
		buf.Append("/");
		if (bucketName != null && !bucketName.Equals(""))
		{
			buf.Append(bucketName);
			buf.Append("/");
		}
		if (key != null && key.Length != 0)
		{
			buf.Append(key);
		}
		if (queryParams != null)
		{
			if (queryParams.IndexOfKey("acl") != -1)
			{
				buf.Append("?acl");
			}
			else if (queryParams.IndexOfKey("torrent") != -1)
			{
				buf.Append("?torrent");
			}
			else if (queryParams.IndexOfKey("logging") != -1)
			{
				buf.Append("?logging");
			}
		}
		return buf.ToString();
	}

	public static DateTime parseDate(string dateStr)
	{
		return DateTime.Parse(dateStr);
	}

	public static SortedList queryForListOptions(string prefix, string marker, int maxKeys)
	{
		return queryForListOptions(prefix, marker, maxKeys, null);
	}

	public static SortedList queryForListOptions(string prefix, string marker, int maxKeys, string delimiter)
	{
		SortedList queryStrings = new SortedList();
		if (prefix != null)
		{
			queryStrings.Add("prefix", HttpUtility.UrlEncode(prefix));
		}
		if (marker != null)
		{
			queryStrings.Add("marker", HttpUtility.UrlEncode(marker));
		}
		if (maxKeys != 0)
		{
			queryStrings.Add("max-keys", string.Concat(maxKeys));
		}
		if (delimiter != null)
		{
			queryStrings.Add("delimiter", HttpUtility.UrlEncode(delimiter));
		}
		return queryStrings;
	}

	public static byte[] slurpInputStream(Stream stream)
	{
		byte[] buffer = new byte[32768];
		using MemoryStream ms = new MemoryStream();
		while (true)
		{
			int nRead = stream.Read(buffer, 0, buffer.Length);
			if (nRead <= 0)
			{
				break;
			}
			ms.Write(buffer, 0, nRead);
		}
		return ms.ToArray();
	}

	public static string slurpInputStreamAsString(Stream stream)
	{
		return new ASCIIEncoding().GetString(slurpInputStream(stream));
	}
}
