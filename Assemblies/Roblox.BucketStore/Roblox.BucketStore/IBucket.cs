using System;
using System.IO;

namespace Roblox.BucketStore;

public interface IBucket
{
	void Delete(string key);

	byte[] Download(string key);

	bool Exists(string key);

	string GetDownloadUrl(string key, bool secureConnection);

	string GetUploadUrl(string key, TimeSpan expiration);

	void Upload(string key, byte[] data, string mimeType = null);

	void Upload(string key, FileInfo file);

	/// <summary>
	/// Derive an entry's Key from the entry's Hash value
	/// </summary>
	/// <param name="hash">Hash value of an entry</param>
	/// <returns>returns the Key value of an entry, based on the Hash</returns>
	string DeriveKey(string hash);

	/// <summary>
	/// Derive an entry's Hash from the entry's Key value
	/// </summary>
	/// <param name="key">Key value of an entry</param>
	/// <returns>returns the Hash value of an entry, based on the Key</returns>
	string DeriveHash(string key);

	/// <summary>
	/// Verify that the uploaded data can be downloaded and identified
	/// </summary>
	/// <param name="key">Key identifier by which the data can be downloaded</param>
	/// <param name="expectedLength">The expected length of the downloaded content</param>
	/// <param name="expectedHash">The expected hash of the downloaded content</param>
	/// <returns></returns>
	void Verify(string key, int expectedLength, string expectedHash);
}
