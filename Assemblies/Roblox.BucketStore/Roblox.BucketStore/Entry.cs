using System;

namespace Roblox.BucketStore;

public class Entry
{
	public string Key { get; private set; }

	public DateTime LastModified { get; private set; }

	public long Size { get; private set; }

	public string Url { get; private set; }

	public Entry(string key, DateTime lastModified, long size, string url)
	{
		Key = key;
		LastModified = lastModified;
		Size = size;
		Url = url;
	}
}
