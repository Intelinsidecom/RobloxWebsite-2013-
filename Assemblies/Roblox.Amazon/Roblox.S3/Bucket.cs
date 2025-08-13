using System;
using System.IO;
using System.Net;
using com.amazon.s3;
using Roblox.BucketStore;
using Roblox.Common.NetStandard;

namespace Roblox.S3;

public class Bucket : IBucket
{
	protected class Key
	{
		public readonly string Name;

		public readonly string MimeType;

		public Key(string key)
		{
			int pos = key.LastIndexOf('.');
			if (pos < 0)
			{
				Name = key;
				return;
			}
			Name = key.Substring(0, pos);
			string extension = key.Substring(pos + 1).ToLower();
			if (string.IsNullOrEmpty(extension))
			{
				MimeType = "application/octet-stream";
				return;
			}
			switch (extension)
			{
			case "png":
				MimeType = "image/png";
				break;
			case "jpeg":
				MimeType = "image/jpeg";
				break;
			case "gif":
				MimeType = "image/gif";
				break;
			case "exe":
				MimeType = "application/exe";
				break;
			case "obj":
				MimeType = "text/plain";
				break;
			case "mtl":
				MimeType = "text/plain";
				break;
			case "ico":
				MimeType = "image/x-icon";
				break;
			case "svg":
				MimeType = "image/svg+xml";
				break;
			}
		}
	}

	private readonly string _Name;

	private readonly CallingFormat _Format;

	private readonly DecompressionMethods _ContentEncoding;

	private readonly bool _NeverExpires;

	private readonly IBucketPersistor _BucketPersistor;

	public string Name => _Name;

	protected virtual bool IncludeFileExtensions(Key key)
	{
		return true;
	}

	public Bucket(IBucketPersistor bucketPersistor, string name, CallingFormat format, DecompressionMethods contentEncoding, bool neverExpires)
	{
		_Name = name;
		_Format = format;
		_ContentEncoding = contentEncoding;
		_NeverExpires = neverExpires;
		_BucketPersistor = bucketPersistor;
	}

	public void Delete(string key)
	{
		_BucketPersistor.Delete(_Name, key);
	}

	public byte[] Download(string key)
	{
		return _BucketPersistor.Download(_Name, key);
	}

	public bool Exists(string key)
	{
		return _BucketPersistor.Exists(_Name, key);
	}

	public string GetDownloadUrl(string key, bool secureConnection)
	{
		Key i = new Key(key);
		if (!IncludeFileExtensions(i))
		{
			key = i.Name;
		}
		return _BucketPersistor.GetDownloadUrl(Name, _Format, key, secureConnection);
	}

	public string GetUploadUrl(string key, TimeSpan expiration)
	{
		Key i = new Key(key);
		return _BucketPersistor.GetUploadUrl(Name, _Format, IncludeFileExtensions(i) ? key : i.Name, expiration, i.MimeType, _ContentEncoding);
	}

	public void Upload(string key, byte[] data, string mimeType = null)
	{
		Key i = new Key(key);
		string s3Key = (IncludeFileExtensions(i) ? key : i.Name);
		string s3MimeType = mimeType ?? i.MimeType;
		_BucketPersistor.Upload(Name, s3Key, data, s3MimeType, _ContentEncoding, _NeverExpires);
	}

	public void Upload(string key, FileInfo file)
	{
		Upload(key, file, null);
	}

	public void Upload(string key, FileInfo file, string mimeType)
	{
		Key i = new Key(key);
		string s3Key = (IncludeFileExtensions(i) ? key : i.Name);
		string s3MimeType = mimeType ?? i.MimeType;
		_BucketPersistor.Upload(Name, s3Key, file, s3MimeType, _ContentEncoding, _NeverExpires);
	}

	public void Verify(string key, int expectedLength, string expectedhash)
	{
		Key i = new Key(key);
		byte[] downloadedContent = Download(IncludeFileExtensions(i) ? key : i.Name);
		if (downloadedContent.Length != expectedLength)
		{
			throw new ApplicationException("S3 verification failure.  Expected size: " + expectedLength + ".  Downloaded length: " + downloadedContent.Length);
		}
		string downloadedHash = HashFunctions.ComputeHashString(downloadedContent);
		if (expectedhash != downloadedHash)
		{
			throw new ApplicationException("S3 verification failure.  Expected hash: " + expectedhash + ".  Downloaded hash: " + downloadedHash);
		}
	}

	public string DeriveKey(string hash)
	{
		return hash;
	}

	public string DeriveHash(string key)
	{
		return key;
	}
}
