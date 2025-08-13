using System;
using System.Collections.Generic;
using System.IO;

namespace Roblox.BucketStore;

/// <summary>
/// Partitions entries among a collection of IBuckets
/// </summary>
public class BucketFan : IBucket
{
	private readonly IBucket[] _Buckets;

	public BucketFan(ICollection<IBucket> buckets)
	{
		if (buckets.Count == 0)
		{
			throw new ApplicationException("BucketFan needs at least one IBucket.");
		}
		_Buckets = new IBucket[buckets.Count];
		buckets.CopyTo(_Buckets, 0);
	}

	protected virtual IBucket GetBucket(string key)
	{
		int index = GetBucketNumber(key, _Buckets.Length);
		return _Buckets[index];
	}

	public void Delete(string key)
	{
		GetBucket(key).Delete(key);
	}

	public byte[] Download(string key)
	{
		return GetBucket(key).Download(key);
	}

	public bool Exists(string key)
	{
		return GetBucket(key).Exists(key);
	}

	public string GetDownloadUrl(string key, bool secureConnection)
	{
		return GetBucket(key).GetDownloadUrl(key, secureConnection);
	}

	public ICollection<Entry> GetEntries(string prefix, int maxKeys)
	{
		throw new Exception("The method or operation is not implemented.");
	}

	public string GetUploadUrl(string key, TimeSpan expiration)
	{
		return GetBucket(key).GetUploadUrl(key, expiration);
	}

	public void Upload(string key, byte[] data, string mimeType = null)
	{
		GetBucket(key).Upload(key, data, mimeType);
	}

	public void Upload(string key, FileInfo file)
	{
		GetBucket(key).Upload(key, file);
	}

	public void Verify(string key, int expectedLength, string expectedHash)
	{
		GetBucket(key).Verify(key, expectedLength, expectedHash);
	}

	public string DeriveKey(string hash)
	{
		return hash;
	}

	public string DeriveHash(string key)
	{
		return key;
	}

	public static int GetBucketNumber(string key, int totalNumOfBuckets)
	{
		byte hash = 31;
		foreach (char c in key)
		{
			hash = (byte)(hash ^ (byte)c);
		}
		return (int)hash % totalNumOfBuckets;
	}
}
