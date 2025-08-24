using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using Roblox.Amazon;
using Roblox.BucketStore;
using Roblox.EventLog;
using Roblox.Platform.Thumbnails.Repository.Properties;
using Roblox.S3;

namespace Roblox.Platform.Thumbnails.Repository;

public class ThumbnailRepository
{
	private const int _NumberOfBuckets = 8;

	private static readonly HashSet<string> _ExtensionsToCompress = new HashSet<string> { ".obj", ".mtl", ".animationmanifest", ".etc" };

	private static readonly IBucketPersistorFactory _BucketPersistorFactory = new S3BucketPersistorFactory(Settings.Default.ThumbnailRepositoryAwsBucketAccessKey, Settings.Default.ThumbnailRepositoryAwsBucketSecretAccessKey, StaticLoggerRegistry.Instance);

	private static readonly IBucketPersistor _BucketPersistor = _BucketPersistorFactory.GetBucketPersistor();

	private readonly AwsThumbnailBucketFan _UncompressedBucketFan = Create(compressedData: false);

	private readonly AwsThumbnailBucketFan _CompressedBucketFan = Create(compressedData: true);

	internal static AwsThumbnailBucketFan Create(bool compressedData)
	{
		_ = Settings.Default.CdnSuffix;
		List<IBucket> buckets = new List<IBucket>();
		for (int i = 0; i < 8; i++)
		{
			string name = $"t{i}.roblox.com";
			Bucket bucket = (compressedData ? ((Bucket)new CompressedThumbnailBucket(_BucketPersistor, name)) : ((Bucket)new UncompressedThumbnailBucket(_BucketPersistor, name)));
			buckets.Add(bucket);
		}
		return new AwsThumbnailBucketFan(buckets);
	}

	public string GetThumbnailUrl(string hash, bool secureConnection)
	{
		return _UncompressedBucketFan.GetDownloadUrl(hash, secureConnection);
	}

	public string SaveThumbnailContent(string extension, byte[] uncompressedBinaryContent)
	{
		string text = ComputeHashString(uncompressedBinaryContent);
		string key = text + extension;
		string extensionLowercase = extension.ToLowerInvariant();
		if (_ExtensionsToCompress.Contains(extensionLowercase))
		{
			byte[] compressedBinaryContent = CompressUsingGZip(uncompressedBinaryContent);
			_CompressedBucketFan.Upload(key, compressedBinaryContent);
			return text;
		}
		_UncompressedBucketFan.Upload(key, uncompressedBinaryContent);
		return text;
	}

	public string ComputeHashString(byte[] uncompressedBinaryContent)
	{
		return HashFunctions.ComputeHashString(uncompressedBinaryContent);
	}

	private static byte[] CompressUsingGZip(byte[] raw)
	{
		using MemoryStream memory = new MemoryStream();
		using (GZipStream stream = new GZipStream(memory, CompressionMode.Compress))
		{
			stream.Write(raw, 0, raw.Length);
		}
		return memory.ToArray();
	}
}
