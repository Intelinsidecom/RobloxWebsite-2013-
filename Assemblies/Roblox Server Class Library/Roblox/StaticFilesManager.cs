using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Web;
using com.amazon.s3;
using Roblox.Amazon;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Properties;
using Roblox.S3;

namespace Roblox;

public static class StaticFilesManager
{
	private static Dictionary<string, Roblox.S3.Bucket> _ContentStoreBuckets;

	private static IBucketPersistor _bucketPersistor;

	private static IHttpRequestProtocolResolver _RequestProtocolResolver;

	private const string _GzipFileExtension = "gzip";

	private static readonly Dictionary<string, bool> _MimeGZipSupport;

	private static readonly Dictionary<string, string> _MimeTypeHeader;

	private static void InitBucketPersistance()
	{
		_bucketPersistor = new S3BucketPersistorFactory(Settings.Default.StaticFilesAwsBucketAccessKey, Settings.Default.StaticFilesAwsBucketSecretAccessKey, StaticLoggerRegistry.Instance).GetBucketPersistor();
	}

	static StaticFilesManager()
	{
		_MimeGZipSupport = new Dictionary<string, bool>
		{
			{ ".css", true },
			{ ".gif", false },
			{ ".ico", true },
			{ ".jpeg", false },
			{ ".jpg", false },
			{ ".js", true },
			{ ".mp3", false },
			{ ".png", false },
			{ ".svg", true }
		};
		_MimeTypeHeader = new Dictionary<string, string>
		{
			{ ".css", "text/css" },
			{ ".gif", "image/gif" },
			{ ".ico", "image/x-icon" },
			{ ".jpeg", "image/jpeg" },
			{ ".jpg", "image/jpeg" },
			{ ".js", "application/javascript" },
			{ ".mp3", "audio/mpeg" },
			{ ".png", "image/png" },
			{ ".svg", "image/svg+xml" }
		};
		Settings.Default.PropertyChanged += delegate(object sender, PropertyChangedEventArgs e)
		{
			string propertyName = e.PropertyName;
			if (propertyName.EndsWith("Bucket") || propertyName.EndsWith("CDNUrl"))
			{
				PopulateContentStoreBuckets();
			}
			if (propertyName.EndsWith("AccessKey"))
			{
				InitBucketPersistance();
			}
		};
		InitBucketPersistance();
		PopulateContentStoreBuckets();
		_RequestProtocolResolver = new HttpRequestProtocolResolver();
	}

	/// <summary>
	/// Upload a File to S3 directly based on File Extension and without compression
	/// </summary>
	public static string UploadFile(byte[] content, string fileName)
	{
		return UploadFile(content, fileName.ToLower(), DecompressionMethods.None);
	}

	/// <summary>
	/// Upload a File as  File Stream without any GZip.
	/// To be used for Images.
	/// </summary>
	public static string UploadFile(Stream data, string fileName)
	{
		byte[] content = new byte[data.Length];
		data.Read(content, 0, (int)data.Length);
		return UploadFile(content, fileName);
	}

	/// <summary>
	/// Upload content to S3 Bucket based on the File Extension and Compression Method.
	/// </summary>
	private static string UploadFile(byte[] content, string fileName, DecompressionMethods method)
	{
		string hash = HashFunctions.ComputeHashString(content);
		try
		{
			Roblox.S3.Bucket bucket = GetBucket(Path.GetExtension(fileName), method);
			string mimetype = GetMimeTypeHeader(fileName);
			if (!bucket.Exists(hash))
			{
				bucket.Upload(hash, content, mimetype);
				bucket.Verify(hash, content.Length, hash);
			}
			return hash;
		}
		catch (Exception e)
		{
			throw new ApplicationException($"Error while trying to upload the file {fileName}\n Exception: {e.Message}");
		}
	}

	/// <summary>
	/// Get the download Url for a FileName as String.
	/// If unavailable in BucketStore, it uploads the file.
	/// </summary>
	public static string GetUrlByFileName(string fileName, HttpRequest request)
	{
		return GetUriByFileName(fileName, request).AbsoluteUri;
	}

	/// <summary>
	/// Get the Download url for a File name as System.Uri
	/// </summary>
	private static Uri GetUriByFileName(string fileName, HttpRequest request)
	{
		byte compressionTypeID = GetCompressionTypeId(request);
		string extension = Path.GetExtension(fileName);
		bool appendGZip;
		if ((DecompressionMethodExtractor.ParseAcceptEncoding(request) & DecompressionMethods.GZip) != 0 && GetCompressionRule(extension))
		{
			appendGZip = true;
		}
		else
		{
			appendGZip = false;
		}
		StaticFile staticFile = StaticFile.GetStaticFileByFileNameAndCompressionType(fileName, compressionTypeID);
		if (staticFile == null)
		{
			string returnUrl = (_RequestProtocolResolver.IsRequestSecure(request) ? "https://" : "http://");
			returnUrl += request.Url.Host;
			if (!request.Url.Host.Contains("roblox.com"))
			{
				returnUrl = returnUrl + ":" + request.Url.Port;
			}
			returnUrl += fileName.Replace("~", "");
			string filePath = request.MapPath(fileName);
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				UploadStaticFile(fileName, filePath, appendGZip, compressionTypeID);
			});
			return new Uri(returnUrl);
		}
		Roblox.S3.Bucket downloadBucket = (appendGZip ? GetBucket(extension, DecompressionMethods.GZip) : GetBucket(extension, DecompressionMethods.None));
		return GetDownloadUriByHashAndExtension(staticFile.Hash, extension, appendGZip, downloadBucket, _RequestProtocolResolver.IsRequestSecure(request));
	}

	/// <summary>
	/// Return the download URL using the Hash.
	/// </summary>
	public static string GetImageUrlByHash(string hash, HttpRequest request)
	{
		return GetImageUrlByHash(hash, new HttpRequestWrapper(request));
	}

	/// <summary>
	/// Return the download URL using the Hash.
	/// </summary>
	public static string GetImageUrlByHash(string hash, HttpRequestBase request)
	{
		return GetImageUriByHash(hash, request).AbsoluteUri;
	}

	/// <summary>
	/// Get the S3 Bucket based on File Type - js/css or image and the CompressionMethod
	/// </summary>
	public static Roblox.S3.Bucket GetBucket(string fileType, DecompressionMethods compressionMethod)
	{
		if (compressionMethod == DecompressionMethods.GZip)
		{
			fileType += ".gzip";
		}
		if (_ContentStoreBuckets.ContainsKey(fileType.ToLower()))
		{
			return _ContentStoreBuckets[fileType];
		}
		throw new ApplicationException($"Unknown FileType Bucket Requested '{fileType}'\n Include in the appropriate bucket. ");
	}

	/// <summary>
	/// Return the Uri using the Hash.
	/// </summary>
	public static Uri GetImageUriByHash(string hash, HttpRequest request)
	{
		return GetImageUriByHash(hash, new HttpRequestWrapper(request));
	}

	/// <summary>
	/// Return the Uri using the Hash.
	/// </summary>
	public static Uri GetImageUriByHash(string hash, HttpRequestBase request)
	{
		Roblox.S3.Bucket bucket = GetBucket("images", DecompressionMethods.None);
		return GetDownloadUriByHashAndExtension(hash, string.Empty, appendGZip: false, bucket, _RequestProtocolResolver.IsRequestSecure(request));
	}

	/// <summary>
	/// Retrieve the Location of the File using the Hash and Extension and return URI
	/// Should be used if FileName is known - js, css etc.,
	/// </summary>
	public static Uri GetDownloadUriByHashAndExtension(string hash, string extension, bool appendGZip, Roblox.S3.Bucket downloadBucket, bool secureConnection)
	{
		string key = (appendGZip ? (hash + extension + ".gzip") : (hash + extension));
		string url = downloadBucket.GetDownloadUrl(key, secureConnection);
		if (!Settings.Default.IsAkamaiEnabledForStatic && !secureConnection)
		{
			url = AmazonS3UrlFormat(url);
		}
		return new Uri(url);
	}

	/// <summary>
	/// Uploads the File based on the Compression Rule.
	/// Checks File Extension and GZip(s) the Data if necessary.
	/// </summary>
	private static void UploadStaticFile(string fileName, string filePath, bool requireCompression, byte compressionTypeID)
	{
		try
		{
			LeasedLock leasedLock = LeasedLock.GetOrCreate("Static Content File Uploader, FileName: " + fileName);
			if (!leasedLock.TryAcquire(ParallelTaskWorker.ID, 20000))
			{
				return;
			}
			byte[] content;
			using (FileStream fStream = System.IO.File.OpenRead(filePath))
			{
				if (!requireCompression)
				{
					content = new byte[fStream.Length];
					fStream.Read(content, 0, Convert.ToInt32(fStream.Length));
				}
				else
				{
					using MemoryStream outStream = new MemoryStream();
					using (GZipStream gzipContent = new GZipStream(outStream, CompressionMode.Compress, leaveOpen: true))
					{
						fStream.CopyTo(gzipContent);
					}
					content = outStream.ToArray();
				}
			}
			string extension = Path.GetExtension(fileName);
			string mimetype = GetMimeTypeHeader(fileName);
			string hash = HashFunctions.ComputeHashString(content);
			string key = (requireCompression ? (hash + extension + ".gzip") : (hash + extension));
			Roblox.S3.Bucket obj = (requireCompression ? GetBucket(extension, DecompressionMethods.GZip) : GetBucket(extension, DecompressionMethods.None));
			obj.Upload(key, content, mimetype);
			obj.Verify(key, content.Length, hash);
			StaticFile.CreateNew(fileName, hash, compressionTypeID);
			leasedLock.TryRelease(ParallelTaskWorker.ID);
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
	}

	private static byte GetCompressionTypeId(HttpRequest request)
	{
		if ((DecompressionMethodExtractor.ParseAcceptEncoding(request) & DecompressionMethods.GZip) != 0)
		{
			return CompressionType.GZIP.ID;
		}
		return CompressionType.None.ID;
	}

	private static void PopulateContentStoreBuckets()
	{
		_ContentStoreBuckets = new Dictionary<string, Roblox.S3.Bucket>
		{
			{
				".css",
				NewBucket(Settings.Default.CssS3Bucket, DecompressionMethods.None)
			},
			{
				".css.gzip",
				NewBucket(Settings.Default.CssGZipS3Bucket, DecompressionMethods.GZip)
			},
			{
				".gif",
				NewBucket(Settings.Default.ImagesS3Bucket, DecompressionMethods.None)
			},
			{
				".ico",
				NewBucket(Settings.Default.ImagesS3Bucket, DecompressionMethods.None)
			},
			{
				".ico.gzip",
				NewBucket(Settings.Default.ImagesS3Bucket, DecompressionMethods.GZip)
			},
			{
				"images",
				NewBucket(Settings.Default.ImagesS3Bucket, DecompressionMethods.None)
			},
			{
				".js",
				NewBucket(Settings.Default.JavaScriptS3Bucket, DecompressionMethods.None)
			},
			{
				".js.gzip",
				NewBucket(Settings.Default.JavaScriptGZipS3Bucket, DecompressionMethods.GZip)
			},
			{
				".jpeg",
				NewBucket(Settings.Default.ImagesS3Bucket, DecompressionMethods.None)
			},
			{
				".jpg",
				NewBucket(Settings.Default.ImagesS3Bucket, DecompressionMethods.None)
			},
			{
				".png",
				NewBucket(Settings.Default.ImagesS3Bucket, DecompressionMethods.None)
			},
			{
				".svg",
				NewBucket(Settings.Default.ImagesS3Bucket, DecompressionMethods.None)
			},
			{
				".svg.gzip",
				NewBucket(Settings.Default.ImagesS3Bucket, DecompressionMethods.GZip)
			}
		};
	}

	private static Roblox.S3.Bucket NewBucket(string name, DecompressionMethods method)
	{
		return new Roblox.S3.Bucket(_bucketPersistor, name, CallingFormat.VANITY, method, neverExpires: true);
	}

	/// <summary>
	/// Determines if a File requires Compression or not.
	/// </summary>
	/// <param name="fileName">File name with Extension</param>
	private static bool GetCompressionRule(string fileName)
	{
		string extension = Path.GetExtension(fileName);
		if (_MimeGZipSupport.ContainsKey(extension.ToLower()))
		{
			return _MimeGZipSupport[extension];
		}
		throw new ApplicationException($"Unknown File Extension Requested '{extension}'\n Include in the Dictionary ");
	}

	/// <summary>
	/// Returns the Content-Type Header based on the MimeType.
	/// For images, it returns an empty string.
	/// </summary>
	private static string GetMimeTypeHeader(string fileName)
	{
		string extension = Path.GetExtension(fileName);
		if (_MimeTypeHeader.ContainsKey(extension.ToLower()))
		{
			return _MimeTypeHeader[extension];
		}
		throw new ApplicationException($"Unknown Mime-Type header Requested '{fileName}'\n Include in the MimeTypeHeader Dictionary ");
	}

	/// <summary>
	/// Return s3.Amazon.com url appended instead of Cloudfront URL.
	/// To be used if Akamai is disabled for some reason.
	/// </summary>
	private static string AmazonS3UrlFormat(string url)
	{
		url = (url.Contains("https") ? url.Replace("https://", "https://s3.amazonaws.com/") : url.Replace("http://", "http://s3.amazonaws.com/"));
		url = url.Replace(":80", "");
		return url;
	}
}
