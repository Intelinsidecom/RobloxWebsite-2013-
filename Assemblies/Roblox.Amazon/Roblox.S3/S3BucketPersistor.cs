using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using com.amazon.s3;
using Roblox.Amazon;
using Roblox.Amazon.Properties;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.S3;

/// <summary>
/// Public interface to Roblox's Amazon S3 database
/// </summary>
public class S3BucketPersistor : IBucketPersistor
{
	private class Perfs
	{
		private readonly ICounterRegistry _CounterRegistry;

		private readonly string _CategoryName = "Roblox S3 Operations";

		internal IAverageValueCounter _AverageResponseTime;

		internal IRateOfCountsPerSecondCounter ErrorsPerSecond;

		internal IRateOfCountsPerSecondCounter RequestsPerSecond;

		internal IRawValueCounter TotalErrorCount;

		internal IRawValueCounter TotalRequestCount;

		internal IAverageValueCounter AverageResponseTime;

		public Perfs(string instanceName)
		{
			_CounterRegistry = StaticCounterRegistry.Instance;
			_AverageResponseTime = _CounterRegistry.GetAverageValueCounter(_CategoryName, "Average Response Time", instanceName);
			ErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter(_CategoryName, "Errors/s", instanceName);
			RequestsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter(_CategoryName, "Requests/s", instanceName);
			TotalErrorCount = _CounterRegistry.GetRawValueCounter(_CategoryName, "Total Error Count", instanceName);
			TotalRequestCount = _CounterRegistry.GetRawValueCounter(_CategoryName, "Total Request Count", instanceName);
			AverageResponseTime = _CounterRegistry.GetAverageValueCounter(_CategoryName, "AverageResponseTime", instanceName);
		}
	}

	private readonly Perfs _Perfs;

	private readonly AWSAuthConnection _SecureConnection;

	private readonly ILogger _Logger;

	protected bool IncludeAmzAclHeader = true;

	internal S3BucketPersistor(string accessKey, string secretAccessKey, ILogger logger)
	{
		if (string.IsNullOrWhiteSpace(accessKey))
		{
			throw new ArgumentNullException("accessKey");
		}
		if (string.IsNullOrWhiteSpace(secretAccessKey))
		{
			throw new ArgumentNullException("secretAccessKey");
		}
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_SecureConnection = new AWSAuthConnection(accessKey, secretAccessKey, isSecure: true);
		_Perfs = new Perfs("Roblox Web Site");
	}

	private void LogPerfs(Stopwatch stopwatch, bool error)
	{
		_Perfs.TotalRequestCount.Increment();
		_Perfs.RequestsPerSecond.Increment();
		_Perfs.AverageResponseTime.Sample(stopwatch.ElapsedMilliseconds);
		if (error)
		{
			_Perfs.TotalErrorCount.Increment();
			_Perfs.ErrorsPerSecond.Increment();
		}
	}

	private QueryStringAuthGenerator NewExpiringGenerator(CallingFormat format, TimeSpan expiration)
	{
		return new QueryStringAuthGenerator(Settings.Default.accessKeyId, Settings.Default.secretAccessKey, isSecure: true, format)
		{
			ExpiresIn = (long)expiration.TotalMilliseconds
		};
	}

	private SortedList NewUploadHeaders(DecompressionMethods contentEncoding, bool neverExpires)
	{
		SortedList headers = new SortedList();
		if (neverExpires)
		{
			headers.Add("Cache-Control", "public, max-age=31536000");
		}
		else
		{
			headers.Add("Cache-Control", "no-cache");
			headers.Add("Pragma", "no-cache");
		}
		if (IncludeAmzAclHeader)
		{
			headers.Add("x-amz-acl", "public-read");
		}
		switch (contentEncoding)
		{
		case DecompressionMethods.GZip:
			headers.Add("Content-Encoding", "gzip");
			break;
		case DecompressionMethods.Deflate:
			headers.Add("Content-Encoding", "deflate");
			break;
		}
		return headers;
	}

	public bool BucketExists(string bucketName)
	{
		foreach (com.amazon.s3.Bucket bucket in GetBuckets())
		{
			if (bucket.Name == bucketName)
			{
				return true;
			}
		}
		return false;
	}

	public void ClearBucket(string bucket)
	{
		if (!Settings.Default.BucketAdminEnabled)
		{
			throw new ApplicationException("Roblox.S3.Settings.BucketAdminEnabled is false");
		}
		bool more;
		do
		{
			using ListBucketResponse response = _SecureConnection.listBucket(bucket, null, null, 1000, null);
			foreach (ListEntry entry in response.Entries)
			{
				using (_SecureConnection.delete(bucket, entry.Key, null))
				{
				}
			}
			more = response.IsTruncated;
		}
		while (more);
	}

	public void CreateBucket(string name)
	{
		if (!Settings.Default.BucketAdminEnabled)
		{
			throw new ApplicationException("Roblox.S3.Settings.BucketAdminEnabled is false");
		}
		bool error = false;
		Exception exception = null;
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			using (_SecureConnection.createBucket(name, null))
			{
			}
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
	}

	public void Delete(string bucket, string key)
	{
		bool error = false;
		Exception exception = null;
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			using (_SecureConnection.delete(bucket, key, null))
			{
			}
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
	}

	public void DeleteBucket(string name)
	{
		if (!Settings.Default.BucketAdminEnabled)
		{
			throw new ApplicationException("Roblox.S3.Settings.BucketAdminEnabled is false");
		}
		bool error = false;
		Exception exception = null;
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			using (_SecureConnection.deleteBucket(name, null))
			{
			}
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
	}

	public GetResponse Get(string bucket, string key)
	{
		bool error = false;
		Exception exception = null;
		GetResponse response = null;
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			response = _SecureConnection.get(bucket, key, null);
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
		return response;
	}

	public byte[] Download(string bucket, string key)
	{
		bool error = false;
		Exception exception = null;
		S3Object s3Object = null;
		HttpStatusCode httpStatusCode = HttpStatusCode.OK;
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			using GetResponse response = _SecureConnection.get(bucket, key, null);
			s3Object = response.Object;
			httpStatusCode = response.Status;
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
		if (s3Object == null)
		{
			throw new ApplicationException($"S3 {bucket} {key} returned {httpStatusCode}");
		}
		return s3Object.Bytes;
	}

	public bool Exists(string bucket, string key)
	{
		bool error = false;
		Exception exception = null;
		bool exists = false;
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			using ListBucketResponse response = _SecureConnection.listBucket(bucket, key, null, 1, null);
			exists = response.Entries.Count == 1;
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
		return exists;
	}

	public ICollection<com.amazon.s3.Bucket> GetBuckets()
	{
		bool error = false;
		Exception exception = null;
		Stopwatch stopwatch = Stopwatch.StartNew();
		ArrayList buckets;
		try
		{
			using ListAllMyBucketsResponse response = _SecureConnection.listAllMyBuckets(null);
			buckets = response.Buckets;
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
			buckets = new ArrayList();
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
		com.amazon.s3.Bucket[] result = new com.amazon.s3.Bucket[buckets.Count];
		buckets.CopyTo(result);
		return result;
	}

	public string GetDownloadUrl(string bucket, CallingFormat format, string key, bool secureConnection)
	{
		StringBuilder buffer = new StringBuilder();
		buffer.Append(secureConnection ? "https://" : "http://");
		try
		{
			buffer.Append(CdnUrlResolver.GetCdnUrl(bucket));
			buffer.Append(HttpUtility.UrlEncode(key));
			return buffer.ToString();
		}
		catch (CdnUrlResolver.ResolverException ex)
		{
			_Logger.Error(ex);
			buffer.Append(secureConnection ? Utils.buildUrlBase(Utils.Host, Utils.SecurePort, bucket, CallingFormat.REGULAR) : Utils.buildUrlBase(Utils.Host, Utils.InsecurePort, bucket, format));
			buffer.Append(HttpUtility.UrlEncode(key));
			return buffer.ToString();
		}
	}

	public ICollection<ListEntry> GetEntries(string bucket, string prefix, int maxKeys)
	{
		if (bucket == null)
		{
			return new ListEntry[0];
		}
		bool error = false;
		Exception exception = null;
		Stopwatch stopwatch = Stopwatch.StartNew();
		ArrayList entries;
		try
		{
			using ListBucketResponse response = _SecureConnection.listBucket(bucket, prefix, null, maxKeys, null);
			entries = response.Entries;
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
			entries = new ArrayList();
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
		ListEntry[] result = new ListEntry[entries.Count];
		entries.CopyTo(result);
		return result;
	}

	public string GetUploadUrl(string bucket, CallingFormat format, string key, TimeSpan expiration, string mimeType, DecompressionMethods contentEncoding)
	{
		if (expiration.TotalMinutes > 5.0)
		{
			throw new ApplicationException("Public expiration time is too long (5 minutes max)");
		}
		SortedList headers = NewUploadHeaders(contentEncoding, neverExpires: false);
		if (mimeType != null)
		{
			headers.Add("Content-Type", mimeType);
		}
		return NewExpiringGenerator(format, expiration).put(bucket, key, null, headers);
	}

	public string ParseBucket(string urlString)
	{
		CallingFormat format;
		return ParseBucket(urlString, out format);
	}

	public string ParseBucket(string urlString, out CallingFormat format)
	{
		Uri uri = new Uri(urlString);
		string host = uri.Host;
		int pos = host.IndexOf(Utils.Host);
		if (pos < 0)
		{
			format = CallingFormat.VANITY;
			return host;
		}
		if (pos == 0)
		{
			format = CallingFormat.REGULAR;
			return uri.AbsolutePath;
		}
		format = CallingFormat.SUBDOMAIN;
		return host.Substring(0, pos - 1);
	}

	public void Upload(string bucket, string key, FileInfo fileInfo, string mimeType, DecompressionMethods contentEncoding, bool neverExpires)
	{
		bool error = false;
		Exception exception = null;
		byte[] bytes = File.ReadAllBytes(fileInfo.FullName);
		SortedList headers = NewUploadHeaders(contentEncoding, neverExpires);
		headers.Add("Content-Disposition", "inline; filename=" + fileInfo.Name);
		if (mimeType != null)
		{
			headers.Add("Content-Type", mimeType);
		}
		S3Object s3Object = new S3Object(bytes, null);
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			using (_SecureConnection.put(bucket, key, s3Object, headers))
			{
			}
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
	}

	public void Upload(string bucket, string key, byte[] data, string mimeType, DecompressionMethods contentEncoding, bool neverExpires)
	{
		bool error = false;
		Exception exception = null;
		SortedList headers = NewUploadHeaders(contentEncoding, neverExpires);
		if (mimeType != null)
		{
			headers.Add("Content-Type", mimeType);
		}
		S3Object s3Object = new S3Object(data, null);
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			using (_SecureConnection.put(bucket, key, s3Object, headers))
			{
			}
		}
		catch (Exception ex)
		{
			error = true;
			exception = ex;
		}
		finally
		{
			stopwatch.Stop();
			LogPerfs(stopwatch, error);
			if (error)
			{
				throw exception;
			}
		}
	}
}
