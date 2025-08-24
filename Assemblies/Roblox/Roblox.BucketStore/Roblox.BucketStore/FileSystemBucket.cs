using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Roblox.BucketStore.Properties;
using Roblox.Common.NetStandard;
using Roblox.Configuration;

namespace Roblox.BucketStore;

/// <summary>
/// A simple File System implementation of IBucket
/// </summary>
public class FileSystemBucket : IBucket
{
	private readonly DirectoryInfo _Directory;

	private readonly string _Domain;

	public FileSystemBucket(DirectoryInfo directory)
	{
		_Directory = directory ?? throw new ArgumentNullException("directory", "FileSystemBucket requires a non-null DirectoryInfo.");
		_Domain = "content." + RobloxEnvironment.Domain;
	}

	public ICollection<string> GetRandomKeys(string prefix, int desiredNumberOfResults, string regex)
	{
		ICollection<string> keys = new List<string>();
		string[] files = Directory.GetFiles(_Directory.ToString(), prefix);
		foreach (string fileName in files)
		{
			if (string.IsNullOrEmpty(regex))
			{
				keys.Add(fileName);
			}
			else if (Regex.Match(Path.GetFileNameWithoutExtension(fileName), regex).Success)
			{
				keys.Add(fileName);
			}
		}
		return new List<string>(keys.RandomizeCollection(desiredNumberOfResults));
	}

	public void Delete(string key)
	{
		File.Delete($"{_Directory.FullName}{Path.DirectorySeparatorChar}{key}");
	}

	public string DeriveHash(string key)
	{
		return Path.GetFileNameWithoutExtension(key);
	}

	public string DeriveKey(string hash)
	{
		return $"{hash}.gzip";
	}

	public byte[] Download(string key)
	{
		return File.ReadAllBytes($"{_Directory.FullName}{Path.DirectorySeparatorChar}{key}");
	}

	public bool Exists(string key)
	{
		return File.Exists($"{_Directory}{key}");
	}

	public string GetDownloadUrl(string key, bool secureConnection)
	{
		return new UriBuilder
		{
			Host = _Domain,
			Path = "content/" + key,
			Scheme = (secureConnection ? "https" : "http"),
			Port = -1
		}.ToString();
	}

	public string GetUploadUrl(string key, TimeSpan expiration)
	{
		throw new NotImplementedException();
	}

	public void Upload(string key, byte[] data, string mimeType = null)
	{
		string filePath = $"{_Directory.FullName}{Path.DirectorySeparatorChar}{key}";
		if (Settings.Default.UploadToTempFileAndRenameEnabled)
		{
			string guid = Guid.NewGuid().ToString("N");
			string tempFilePath = string.Format("{0}{1}{2}", _Directory.FullName, Path.DirectorySeparatorChar, key + "_temp" + guid);
			try
			{
				File.WriteAllBytes(tempFilePath, data);
			}
			catch (IOException ex)
			{
				throw new Exception($"Failed to copy file to path '{tempFilePath}'", ex);
			}
			try
			{
				File.Move(tempFilePath, filePath);
				return;
			}
			catch (IOException)
			{
				return;
			}
		}
		File.WriteAllBytes(filePath, data);
	}

	public void Upload(string key, FileInfo fileInfo)
	{
		string filePath = $"{_Directory.FullName}{Path.DirectorySeparatorChar}{key}";
		if (Settings.Default.UploadToTempFileAndRenameEnabled)
		{
			string guid = Guid.NewGuid().ToString("N");
			string tempFilePath = string.Format("{0}{1}{2}", _Directory.FullName, Path.DirectorySeparatorChar, key + "_temp" + guid);
			fileInfo.CopyTo(tempFilePath);
			try
			{
				File.Move(tempFilePath, filePath);
				return;
			}
			catch (IOException)
			{
				return;
			}
		}
		fileInfo.CopyTo(filePath);
	}

	public void Verify(string key, int expectedLength, string expectedhash)
	{
		byte[] downloadedContent = Download(key);
		if (downloadedContent.Length != expectedLength)
		{
			throw new ApplicationException("File verification failure.  Expected size: " + expectedLength + ".  Downloaded length: " + downloadedContent.Length);
		}
		string downloadedHash = HashFunctions.ComputeHashString(downloadedContent);
		if (expectedhash != downloadedHash)
		{
			throw new ApplicationException("File verification failure.  Expected hash: " + expectedhash + ".  Downloaded hash: " + downloadedHash);
		}
	}
}
