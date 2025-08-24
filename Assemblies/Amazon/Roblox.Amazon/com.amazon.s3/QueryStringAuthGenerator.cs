using System;
using System.Collections;
using System.Text;
using System.Web;

namespace com.amazon.s3;

/// This class mimics the behavior of AWSAuthConnection, except instead of actually performing
/// the operation, QueryStringAuthGenerator will return URLs with query string parameters that
/// can be used to do the same thing.  These parameters include an expiration date, so that
/// if you hand them off to someone else, they will only work for a limited amount of time.
public class QueryStringAuthGenerator
{
	private string awsAccessKeyId;

	private string awsSecretAccessKey;

	private bool isSecure;

	private string server;

	private int port;

	private CallingFormat callingFormat;

	private long expiresIn = NOT_SET;

	private long expires = NOT_SET;

	public static readonly long DEFAULT_EXPIRES_IN = 60000L;

	private static readonly long NOT_SET = -1L;

	/// <summary>
	/// Sets/Gets the milliseconds since the Epoch that this
	/// expires at
	/// </summary>
	public long Expires
	{
		get
		{
			return expires;
		}
		set
		{
			expires = value;
			expiresIn = NOT_SET;
		}
	}

	public long ExpiresIn
	{
		get
		{
			return expiresIn;
		}
		set
		{
			expiresIn = value;
			expires = NOT_SET;
		}
	}

	public QueryStringAuthGenerator(string awsAccessKeyId, string awsSecretAccessKey)
		: this(awsAccessKeyId, awsSecretAccessKey, isSecure: true, CallingFormat.REGULAR)
	{
	}

	public QueryStringAuthGenerator(string awsAccessKeyId, string awsSecretAccessKey, bool isSecure, CallingFormat format)
		: this(awsAccessKeyId, awsSecretAccessKey, isSecure, Utils.Host, format)
	{
	}

	public QueryStringAuthGenerator(string awsAccessKeyId, string awsSecretAccessKey, bool isSecure)
		: this(awsAccessKeyId, awsSecretAccessKey, isSecure, Utils.Host, CallingFormat.REGULAR)
	{
	}

	public QueryStringAuthGenerator(string awsAccessKeyId, string awsSecretAccessKey, bool isSecure, string server, CallingFormat format)
		: this(awsAccessKeyId, awsSecretAccessKey, isSecure, server, isSecure ? Utils.SecurePort : Utils.InsecurePort, format)
	{
	}

	public QueryStringAuthGenerator(string awsAccessKeyId, string awsSecretAccessKey, bool isSecure, string server)
		: this(awsAccessKeyId, awsSecretAccessKey, isSecure, server, isSecure ? Utils.SecurePort : Utils.InsecurePort, CallingFormat.REGULAR)
	{
	}

	public QueryStringAuthGenerator(string awsAccessKeyId, string awsSecretAccessKey, bool isSecure, string server, int port)
		: this(awsAccessKeyId, awsSecretAccessKey, isSecure, server, port, CallingFormat.REGULAR)
	{
	}

	public QueryStringAuthGenerator(string awsAccessKeyId, string awsSecretAccessKey, bool isSecure, string server, int port, CallingFormat format)
	{
		this.awsAccessKeyId = awsAccessKeyId;
		this.awsSecretAccessKey = awsSecretAccessKey;
		this.isSecure = isSecure;
		this.server = server;
		this.port = port;
		expiresIn = DEFAULT_EXPIRES_IN;
		expires = NOT_SET;
		callingFormat = format;
	}

	public string createBucket(string bucket, SortedList headers, SortedList metadata)
	{
		return generateURL("PUT", bucket, "", mergeMeta(headers, metadata));
	}

	public string listBucket(string bucket, string prefix, string marker, int maxKeys, SortedList headers)
	{
		return listBucket(bucket, prefix, marker, maxKeys, null, headers);
	}

	public string listBucket(string bucket, string prefix, string marker, int maxKeys, string delimiter, SortedList headers)
	{
		SortedList query = Utils.queryForListOptions(prefix, marker, maxKeys, delimiter);
		return generateURL("GET", bucket, "", query, headers);
	}

	public string deleteBucket(string bucket, SortedList headers)
	{
		return generateURL("DELETE", bucket, "", headers);
	}

	public string put(string bucket, string key, S3Object obj, SortedList headers)
	{
		SortedList metadata = null;
		if (obj != null)
		{
			metadata = obj.Metadata;
		}
		return generateURL("PUT", bucket, HttpUtility.UrlEncode(key), mergeMeta(headers, metadata));
	}

	public string get(string bucket, string key, SortedList headers)
	{
		return generateURL("GET", bucket, HttpUtility.UrlEncode(key), headers);
	}

	public string delete(string bucket, string key, SortedList headers)
	{
		return generateURL("DELETE", bucket, HttpUtility.UrlEncode(key), headers);
	}

	public string getBucketLogging(string bucket, SortedList headers)
	{
		SortedList query = new SortedList();
		query.Add("logging", "");
		return generateURL("GET", bucket, "", query, headers);
	}

	public string putBucketLogging(string bucket, SortedList headers)
	{
		SortedList query = new SortedList();
		query.Add("logging", "");
		return generateURL("PUT", bucket, "", query, headers);
	}

	public string getBucketACL(string bucket, SortedList headers)
	{
		SortedList query = new SortedList();
		query.Add("acl", "");
		return generateURL("GET", bucket, "", query, headers);
	}

	public string getACL(string bucket, string key, SortedList headers)
	{
		SortedList query = new SortedList();
		query.Add("acl", "");
		return generateURL("GET", bucket, HttpUtility.UrlEncode(key), query, headers);
	}

	public string putBucketACL(string bucket, SortedList headers)
	{
		SortedList query = new SortedList();
		query.Add("acl", "");
		return generateURL("PUT", bucket, "", query, headers);
	}

	public string putACL(string bucket, string key, SortedList headers)
	{
		SortedList query = new SortedList();
		query.Add("acl", "");
		return generateURL("PUT", bucket, HttpUtility.UrlEncode(key), query, headers);
	}

	public string listAllMyBuckets(SortedList headers)
	{
		return generateURL("GET", "", "", headers);
	}

	public string makeBaseURL(string bucket, string key)
	{
		StringBuilder buffer = new StringBuilder();
		if (isSecure)
		{
			buffer.Append("https://");
		}
		else
		{
			buffer.Append("http://");
		}
		buffer.Append(server).Append(":").Append(port)
			.Append("/");
		if (bucket != null)
		{
			buffer.Append(bucket);
			if (key != null)
			{
				buffer.Append("/");
				buffer.Append(HttpUtility.UrlEncode(key));
			}
		}
		return buffer.ToString();
	}

	private string generateURL(string method, string bucket, string key, SortedList headers)
	{
		return generateURL(method, bucket, key, new SortedList(), headers);
	}

	private string generateURL(string method, string bucket, string key, SortedList queryParameters, SortedList headers)
	{
		long expires = 0L;
		if (expiresIn != NOT_SET)
		{
			expires = Utils.currentTimeMillis() + expiresIn;
		}
		else
		{
			if (this.expires == NOT_SET)
			{
				throw new Exception("Illegal expire state!");
			}
			expires = this.expires;
		}
		expires /= 1000;
		string canonicalString = Utils.makeCanonicalString(method, bucket, key, queryParameters, headers, string.Concat(expires));
		string encodedCanonical = Utils.encode(awsSecretAccessKey, canonicalString, urlEncode: true);
		StringBuilder builder = new StringBuilder();
		if (isSecure)
		{
			builder.Append("https://");
		}
		else
		{
			builder.Append("http://");
		}
		builder.Append(Utils.buildUrlBase(server, port, bucket, callingFormat));
		if (bucket != null && !bucket.Equals("") && key != null && !key.Equals(""))
		{
			builder.Append(key);
		}
		queryParameters.Add("Signature", encodedCanonical);
		queryParameters.Add("Expires", string.Concat(expires));
		queryParameters.Add("AWSAccessKeyId", awsAccessKeyId);
		builder.Append(Utils.convertQueryListToQueryString(queryParameters));
		return builder.ToString();
	}

	private SortedList mergeMeta(SortedList headers, SortedList metadata)
	{
		SortedList merged = new SortedList();
		if (headers != null)
		{
			foreach (string key2 in headers.Keys)
			{
				merged.Add(key2, headers[key2]);
			}
		}
		if (metadata != null)
		{
			foreach (string key in metadata.Keys)
			{
				string existing = ((!(merged[key] is string existing2)) ? (metadata[key] as string) : (existing2 + "," + metadata[key]));
				merged.Add(key, existing);
			}
		}
		return merged;
	}
}
