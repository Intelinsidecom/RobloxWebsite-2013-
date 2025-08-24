using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using com.amazon.s3;

namespace Roblox.S3;

/// <summary>
/// A no-sql data persistence interface.
/// </summary>
public interface IBucketPersistor
{
	/// <summary>
	/// Does this storage bucket exist.
	/// </summary>
	/// <param name="bucketName">Name of the bucket.</param>
	/// <returns></returns>
	bool BucketExists(string bucketName);

	/// <summary>
	/// Clears the bucket.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	void ClearBucket(string bucket);

	/// <summary>
	/// Creates a bucket.
	/// </summary>
	/// <param name="name">The name of the bucket to create.</param>
	void CreateBucket(string name);

	/// <summary>
	/// Deletes the specified item in a bucket.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	/// <param name="key">The key.</param>
	void Delete(string bucket, string key);

	/// <summary>
	/// Deletes the bucket.
	/// </summary>
	/// <param name="name">The name.</param>
	void DeleteBucket(string name);

	/// <summary>
	/// Gets the specified item from a bucket bucket.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	/// <param name="key">The key.</param>
	/// <returns><see cref="T:com.amazon.s3.GetResponse" /></returns>
	GetResponse Get(string bucket, string key);

	/// <summary>
	/// Downloads the specified item from a bucket.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	/// <param name="key">The key.</param>
	/// <returns>byte []</returns>
	byte[] Download(string bucket, string key);

	/// <summary>
	/// Does the specified item exist in the given bucket.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	/// <param name="key">The key.</param>
	/// <returns>bool</returns>
	bool Exists(string bucket, string key);

	/// <summary>
	/// Gets the buckets.
	/// </summary>
	/// <returns><see cref="!:ICollection&lt;com.amazon.s3.Bucket&gt;" /></returns>
	ICollection<com.amazon.s3.Bucket> GetBuckets();

	/// <summary>
	/// Gets the download URL.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	/// <param name="format">The format.</param>
	/// <param name="key">The key.</param>
	/// <param name="secureConnection">if set to <c>true</c> [secure connection].</param>
	/// <returns>The fully realized URL to get the item.</returns>
	string GetDownloadUrl(string bucket, CallingFormat format, string key, bool secureConnection);

	/// <summary>
	/// Gets the entries.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	/// <param name="prefix">The prefix.</param>
	/// <param name="maxKeys">The maximum keys.</param>
	/// <returns><see cref="!:ICollection&lt;com.amazon.s3.Bucket&gt;" /></returns>
	ICollection<ListEntry> GetEntries(string bucket, string prefix, int maxKeys);

	/// <summary>
	/// Gets the upload URL.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	/// <param name="format">The format.</param>
	/// <param name="key">The key.</param>
	/// <param name="expiration">The expiration.</param>
	/// <param name="mimeType">Type of the MIME.</param>
	/// <param name="contentEncoding">The content encoding.</param>
	/// <returns>The fully realized URL which with to upload the item.</returns>
	string GetUploadUrl(string bucket, CallingFormat format, string key, TimeSpan expiration, string mimeType, DecompressionMethods contentEncoding);

	/// <summary>
	/// Parses the bucket url.
	/// </summary>
	/// <param name="urlString">The URL string.</param>
	/// <returns></returns>
	string ParseBucket(string urlString);

	/// <summary>
	/// Parses the bucket url with a given format.
	/// </summary>
	/// <param name="urlString">The URL string.</param>
	/// <param name="format">The format.</param>
	/// <returns></returns>
	string ParseBucket(string urlString, out CallingFormat format);

	/// <summary>
	/// Uploads a file to a specified bucket.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	/// <param name="key">The key.</param>
	/// <param name="fileInfo">The file information.</param>
	/// <param name="mimeType">Type of the MIME.</param>
	/// <param name="contentEncoding">The content encoding.</param>
	/// <param name="neverExpires">if set to <c>true</c> [never expires].</param>
	void Upload(string bucket, string key, FileInfo fileInfo, string mimeType, DecompressionMethods contentEncoding, bool neverExpires);

	/// <summary>
	/// Uploads a byte array to a specified bucket.
	/// </summary>
	/// <param name="bucket">The bucket.</param>
	/// <param name="key">The key.</param>
	/// <param name="data">The data.</param>
	/// <param name="mimeType">Type of the MIME.</param>
	/// <param name="contentEncoding">The content encoding.</param>
	/// <param name="neverExpires">if set to <c>true</c> [never expires].</param>
	void Upload(string bucket, string key, byte[] data, string mimeType, DecompressionMethods contentEncoding, bool neverExpires);
}
