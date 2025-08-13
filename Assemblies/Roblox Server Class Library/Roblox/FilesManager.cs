using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Web;
using System.Xml;
using com.amazon.s3;
using Roblox.Amazon;
using Roblox.BucketStore;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Properties;
using Roblox.S3;

namespace Roblox;

public class FilesManager : IFilesManager
{
	public static readonly FilesManager Singleton = new FilesManager();

	private const string _GzipFileExtension = "gzip";

	internal readonly short TemporaryContentStoreLocationId = Location.GetByLocationTypeIDAndValue(LocationType.GetByValue("UncFileShare").ID, "RobloxTemporaryContentStore").ID;

	internal readonly short S3ContentLocationId = Location.GetByLocationTypeIDAndValue(LocationType.GetByValue("S3BucketFan").ID, "RobloxS3Content").ID;

	private IHttpRequestProtocolResolver _RequestProtocolResolver;

	private readonly ILogger _Logger;

	internal IBucket PermanentStore { get; }

	public TempStoreManager TemporaryStoreManager { get; set; }

	public event Action<FileUploadEventArgs> OnFileUploadedComplete;

	public event Action<DeleteFromTempStoreArgs> EnqueueToDeleteFromTemporaryStore;

	private void InitializeTemporaryStoreManager()
	{
		DirectoryInfo directoryInfoOnPrime = new DirectoryInfo(Settings.Default.TemporaryStoreDirectory);
		DirectoryInfo directoryInfoOnChi1 = null;
		try
		{
			directoryInfoOnChi1 = new DirectoryInfo(Settings.Default.TemporaryStoreDirectoryOnChi1);
		}
		catch (ArgumentNullException)
		{
			_Logger?.Warning("TemporaryStoreDirectoryOnChi1 was null");
		}
		TemporaryStoreManager = new TempStoreManager(directoryInfoOnPrime, directoryInfoOnChi1, Settings.Default.ReadFromTemporaryStoreDirectoryOnChi1, Settings.Default.WriteToTemporaryStoreDirectoryOnChi1, Settings.Default.StopWritingToTemporaryStoreDirectoryOnPrime, _Logger);
	}

	private FilesManager()
	{
		_Logger = StaticLoggerRegistry.Instance;
		S3BucketPersistorFactory bucketPersistorFactory = new S3BucketPersistorFactory(Settings.Default.StaticFilesAwsBucketAccessKey, Settings.Default.StaticFilesAwsBucketSecretAccessKey, _Logger);
		InitializeTemporaryStoreManager();
		Settings.Default.MonitorChanges((Settings s) => s.TemporaryStoreDirectory, InitializeTemporaryStoreManager);
		Settings.Default.MonitorChanges((Settings s) => s.TemporaryStoreDirectoryOnChi1, InitializeTemporaryStoreManager);
		Settings.Default.MonitorChanges((Settings s) => s.ReadFromTemporaryStoreDirectoryOnChi1, InitializeTemporaryStoreManager);
		Settings.Default.MonitorChanges((Settings s) => s.WriteToTemporaryStoreDirectoryOnChi1, InitializeTemporaryStoreManager);
		Settings.Default.MonitorChanges((Settings s) => s.StopWritingToTemporaryStoreDirectoryOnPrime, InitializeTemporaryStoreManager);
		Roblox.S3.Bucket[] buckets = new Roblox.S3.Bucket[8]
		{
			new Roblox.S3.Bucket(bucketPersistorFactory.GetBucketPersistor(), "c0.roblox.com", CallingFormat.VANITY, DecompressionMethods.GZip, neverExpires: true),
			new Roblox.S3.Bucket(bucketPersistorFactory.GetBucketPersistor(), "c1.roblox.com", CallingFormat.VANITY, DecompressionMethods.GZip, neverExpires: true),
			new Roblox.S3.Bucket(bucketPersistorFactory.GetBucketPersistor(), "c2.roblox.com", CallingFormat.VANITY, DecompressionMethods.GZip, neverExpires: true),
			new Roblox.S3.Bucket(bucketPersistorFactory.GetBucketPersistor(), "c3.roblox.com", CallingFormat.VANITY, DecompressionMethods.GZip, neverExpires: true),
			new Roblox.S3.Bucket(bucketPersistorFactory.GetBucketPersistor(), "c4.roblox.com", CallingFormat.VANITY, DecompressionMethods.GZip, neverExpires: true),
			new Roblox.S3.Bucket(bucketPersistorFactory.GetBucketPersistor(), "c5.roblox.com", CallingFormat.VANITY, DecompressionMethods.GZip, neverExpires: true),
			new Roblox.S3.Bucket(bucketPersistorFactory.GetBucketPersistor(), "c6.roblox.com", CallingFormat.VANITY, DecompressionMethods.GZip, neverExpires: true),
			new Roblox.S3.Bucket(bucketPersistorFactory.GetBucketPersistor(), "c7.roblox.com", CallingFormat.VANITY, DecompressionMethods.GZip, neverExpires: true)
		};
		PermanentStore = new BucketFan(buckets);
		_RequestProtocolResolver = new HttpRequestProtocolResolver();
	}

	public string AddFile(byte[] compressedData, string contentType = null)
	{
		string hash = HashFunctions.ComputeHashString(compressedData);
		Upload(hash, compressedData, contentType);
		return hash;
	}

	public string AddUncompressedFile(byte[] uncompressedData)
	{
		using MemoryStream stream = new MemoryStream(uncompressedData);
		return AddFile(stream, DecompressionMethods.None);
	}

	public string AddFile(Stream data, DecompressionMethods method, string contentType = null)
	{
		byte[] compressedData = GetCompressedDataFromStream(data, method);
		return AddFile(compressedData, contentType);
	}

	public string AddFormattedSourceContentFile(Stream data, DecompressionMethods method, string sourceContentHash, string format, string contentType = null)
	{
		byte[] compressedData = GetCompressedDataFromStream(data, method);
		Upload(sourceContentHash, compressedData, contentType, format);
		return GenerateFormattedSourceContentHash(sourceContentHash, format);
	}

	public MemoryStream GetStream(string hash)
	{
		DecompressionMethods method;
		return GetStream(hash, DecompressionMethods.None, out method);
	}

	public MemoryStream GetStream(string hash, DecompressionMethods acceptEncoding, out DecompressionMethods method)
	{
		return GetLocationAndUpdateIfMissing(hash, acceptEncoding) switch
		{
			FileContentLocation.None => throw new ApplicationException($"File '{hash}' is not in the inventory."), 
			FileContentLocation.S3Content => GetStreamFromGZipStore(hash, acceptEncoding, PermanentStore, out method), 
			FileContentLocation.TemporaryContentStore => GetStreamFromGZipStore(hash + ".gzip", acceptEncoding, TemporaryStoreManager.GetTempStoreToRead(), out method), 
			_ => throw new ApplicationException("Unknown FileInventory.LegacyFileLocation"), 
		};
	}

	/// <summary>
	/// Gets the <see cref="T:Roblox.FileContentLocation" /> for <paramref name="hash" />.
	/// </summary>
	/// <param name="hash">The hash used to identify the file.</param>
	/// <returns>the requested <see cref="T:Roblox.FileContentLocation" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="hash" /> is null or empty.</exception>
	public FileContentLocation GetFileContentLocation(string hash)
	{
		if (string.IsNullOrEmpty(hash))
		{
			throw new ArgumentNullException("hash");
		}
		File file = File.GetByMD5Hash(hash);
		if (file == null)
		{
			return FileContentLocation.None;
		}
		return GetFileContentLocation(file);
	}

	public Uri GetUri(string hash, HttpRequest request)
	{
		return GetUri(hash, _RequestProtocolResolver.IsRequestSecure(request), request.Headers["Accept-Encoding"], request.UserAgent);
	}

	public Uri GetUri(string hash, HttpRequestBase request)
	{
		return GetUri(hash, _RequestProtocolResolver.IsRequestSecure(request), request.Headers["Accept-Encoding"], request.UserAgent);
	}

	public Uri GetUri(string hash, bool secureConnection, string encodingType, string userAgent)
	{
		return GetUri(hash, null, secureConnection, encodingType, userAgent);
	}

	[Obsolete("This is only meant for temporary use for multi-binary assets V1")]
	public Uri GetUri(string hash, string format, bool secureConnection, string encodingType, string userAgent)
	{
		DecompressionMethods acceptedMethods = DecompressionMethodExtractor.ParseAcceptEncoding(encodingType, userAgent);
		switch (GetLocationAndUpdateIfMissing(hash, acceptedMethods))
		{
		case FileContentLocation.TemporaryContentStore:
			if ((acceptedMethods & DecompressionMethods.GZip) != 0)
			{
				return new Uri(TemporaryStoreManager.GetDownloadUrl(string.Format("{0}.{1}", hash, "gzip"), secureConnection));
			}
			throw new NoGzipSupportException();
		case FileContentLocation.S3Content:
			if ((acceptedMethods & DecompressionMethods.GZip) != 0)
			{
				string s3Key = GenerateS3KeyForFormattedContent(hash, format);
				return new Uri(PermanentStore.GetDownloadUrl(s3Key, secureConnection));
			}
			throw new NoGzipSupportException();
		case FileContentLocation.None:
			throw new ApplicationException($"File '{hash}' is not in the inventory.");
		default:
			throw new ApplicationException("Unknown FileInventory.Location");
		}
	}

	public void ProcessRequest(string hash, HttpContext context)
	{
		Uri uri = GetUri(hash, context.Request);
		context.Response.Redirect(uri.AbsoluteUri, endResponse: false);
	}

	public XmlDocument GetFileXml(string fileHash)
	{
		XmlDocument xmlDocument = new XmlDocument();
		using MemoryStream memoryStream = GetStream(fileHash);
		xmlDocument.Load(memoryStream);
		return xmlDocument;
	}

	public FileTransferStatus TransferFromTemporaryContentStoreToS3ProcessorOnly(string hash, string contentType, ILogger logger = null, string format = null)
	{
		string temporaryStoreFileName = TemporaryStoreManager.DeriveKey(hash);
		if (!TemporaryStoreManager.Exists(temporaryStoreFileName))
		{
			return FileTransferStatus.DoesNotExistInTempStore;
		}
		File file = File.GetByMD5Hash(hash);
		if (file == null)
		{
			logger?.Error($"Lookup returned null for file hash: {hash}");
			return FileTransferStatus.DoesNotExistInTempStore;
		}
		if (GetFileContentLocation(file) == FileContentLocation.S3Content)
		{
			if (PermanentStore.Exists(hash))
			{
				DeleteFromTemporaryContentStore(hash, logger);
			}
			return FileTransferStatus.AlreadyExistsOnPermanentStore;
		}
		byte[] content;
		try
		{
			content = TemporaryStoreManager.Download(temporaryStoreFileName);
		}
		catch (Exception e2)
		{
			logger?.Error($"Failed to download {temporaryStoreFileName} from temporary store: \r\n{e2}");
			return FileTransferStatus.ErrorDownloadingFromTempStore;
		}
		Stopwatch permanentStoreUploadWatch = null;
		try
		{
			string s3Key = GenerateS3KeyForFormattedContent(hash, format);
			if (!PermanentStore.Exists(s3Key))
			{
				permanentStoreUploadWatch = Stopwatch.StartNew();
				PermanentStore.Upload(s3Key, content, contentType);
				permanentStoreUploadWatch.Stop();
				FileUploadEventArgs fileUploadArgs = new FileUploadEventArgs
				{
					FileSizeInBytes = content.Length,
					TimeInMilliseconds = permanentStoreUploadWatch.ElapsedMilliseconds,
					Destination = "S3",
					FileName = temporaryStoreFileName
				};
				this.OnFileUploadedComplete?.Invoke(fileUploadArgs);
			}
		}
		catch (Exception e)
		{
			if (permanentStoreUploadWatch != null && permanentStoreUploadWatch.IsRunning)
			{
				permanentStoreUploadWatch.Stop();
			}
			logger?.Error($"Failed to upload {hash} to permanent store: \r\n{e}");
			if (Settings.Default.AddTempFileLocationIfS3UploadFails)
			{
				file.AddLocationId(TemporaryContentStoreLocationId);
				file.Save();
			}
			return FileTransferStatus.ErrorUploadingToPermanentStore;
		}
		return VerifyS3UploadAndDeleteFromTempStore(hash, logger, format);
	}

	public FileTransferStatus VerifyS3UploadAndDeleteFromTempStore(string hash, ILogger logger = null, string format = null)
	{
		string temporaryStoreFileName = TemporaryStoreManager.DeriveKey(hash);
		byte[] content;
		try
		{
			content = TemporaryStoreManager.Download(temporaryStoreFileName);
		}
		catch (Exception e4)
		{
			logger?.Error($"Failed to download {temporaryStoreFileName} from temporary store during verification: \r\n{e4}");
			return FileTransferStatus.ErrorDownloadingFromTempStore;
		}
		File file = File.GetByMD5Hash(hash);
		if (file == null)
		{
			logger?.Error($"Lookup returned null for file hash during verification: {hash}");
			return FileTransferStatus.DoesNotExistInTempStore;
		}
		bool verifyFailed = false;
		try
		{
			string s3Key = GenerateS3KeyForFormattedContent(hash, format);
			string expectedFileHash = (string.IsNullOrEmpty(format) ? hash : HashFunctions.ComputeHashString(content));
			PermanentStore.Verify(s3Key, content.Length, expectedFileHash);
		}
		catch (Exception e3)
		{
			logger?.Error($"Failed to verify {hash} on permanent store: {e3}");
			verifyFailed = true;
		}
		if (verifyFailed)
		{
			if (Settings.Default.AddTempFileLocationIfS3VerificationFails)
			{
				file.AddLocationId(TemporaryContentStoreLocationId);
				file.Save();
			}
			return FileTransferStatus.ErrorVerifyingFileOnPermanentStore;
		}
		try
		{
			file.AddLocationId(S3ContentLocationId);
			if (Settings.Default.CondenseFileLocationSaveEnabled)
			{
				file.RemoveLocationId(TemporaryContentStoreLocationId);
			}
			file.Save();
		}
		catch (Exception e2)
		{
			logger?.Error($"Failed to set location of {hash} to S3: {e2}");
			return FileTransferStatus.ErrorSettingContentLocationToPermanentStore;
		}
		if (Settings.Default.ExecuteTempStoreDeletionRequestsOnTimer)
		{
			DeleteFromTempStoreArgs deleteFromTempStoreArgs = new DeleteFromTempStoreArgs
			{
				FileHash = hash,
				TransferredTime = DateTime.UtcNow
			};
			try
			{
				this.EnqueueToDeleteFromTemporaryStore?.Invoke(deleteFromTempStoreArgs);
				return FileTransferStatus.TransferToPermanentStoreSucceeded;
			}
			catch (Exception e)
			{
				logger?.Error($"There was an exception while enqueuing file for delete from temp store: {e}");
				return FileTransferStatus.ErrorQueueingFileForDeletion;
			}
		}
		return DeleteFromTemporaryContentStore(hash, logger);
	}

	public FileTransferStatus DeleteFromTemporaryContentStore(string hash, ILogger logger)
	{
		if (string.IsNullOrWhiteSpace(hash))
		{
			logger?.Error(string.Format("Unable to delete file from temp store. {0} is null or empty", "hash"));
		}
		File file = File.GetByMD5Hash(hash);
		if (file == null)
		{
			logger?.Error($"Unable to delete file from temp store. File with hash {hash} not found in database");
		}
		string temporaryStoreFileName = TemporaryStoreManager.DeriveKey(hash);
		try
		{
			TemporaryStoreManager.Delete(temporaryStoreFileName);
		}
		catch (Exception e2)
		{
			logger?.Error($"Failed to delete {temporaryStoreFileName} from temporary store: {e2}");
			return FileTransferStatus.ErrorDeletingFromTemporaryStore;
		}
		if (file.GetLocationIds().Contains(TemporaryContentStoreLocationId))
		{
			try
			{
				file.RemoveLocationId(TemporaryContentStoreLocationId);
				file.Save();
			}
			catch (Exception e)
			{
				logger?.Error($"Failed to remove temporary location from file: {e}");
				return FileTransferStatus.ErrorRemovingTempStoreLocationId;
			}
		}
		return FileTransferStatus.DeleteFromTempStoreSucceeded;
	}

	private FileContentLocation GetLocationAndUpdateIfMissing(string hash, DecompressionMethods acceptEncoding)
	{
		File file = File.GetByMD5Hash(hash);
		if (file == null)
		{
			_Logger.Warning($"Could not fetch File for {hash}");
			return FileContentLocation.None;
		}
		FileContentLocation fileContentLocation = GetFileContentLocation(file);
		if (ShouldFixLocation(fileContentLocation, file))
		{
			try
			{
				if (GetStreamFromGZipStore(hash, acceptEncoding, PermanentStore, out var _) != null)
				{
					_Logger.Info($"Location for {hash} on File Entity was {fileContentLocation} but file was found on Permanent store");
					file.AddLocationId(S3ContentLocationId);
					file.Save();
					return FileContentLocation.S3Content;
				}
			}
			catch (Exception e2)
			{
				_Logger?.Error($"Exception while trying to download file from PermanentStore. Attempting to download from tempstore. Hash: {hash} Exception: {e2}");
			}
			try
			{
				GetStreamFromGZipStore(hash + ".gzip", acceptEncoding, TemporaryStoreManager.GetTempStoreToRead(), out var method);
				_Logger.Info($"Location for {hash} on File Entity was {fileContentLocation} but file was found on Temporary store");
				file.AddLocationId(TemporaryContentStoreLocationId);
				file.Save();
				FileUploadEventPublisher.PublishToSqs(hash, method.ToString());
				return FileContentLocation.TemporaryContentStore;
			}
			catch (Exception e)
			{
				_Logger?.Error($"Exception while trying to download file from tempstore. Hash: {hash} Exception: {e}");
			}
		}
		return fileContentLocation;
	}

	private static bool ShouldFixLocation(FileContentLocation fileContentLocation, File file)
	{
		if (!Settings.Default.AttemptToFixNoneFileLocations || fileContentLocation != 0)
		{
			if (Settings.Default.TempFileLocationFixEnabled && fileContentLocation == FileContentLocation.TemporaryContentStore && file.Updated.HasValue)
			{
				return DateTime.UtcNow.Subtract(file.Updated.Value.ToUniversalTime()) >= Settings.Default.TempFileLocationAgeThreshold;
			}
			return false;
		}
		return true;
	}

	private static MemoryStream GetStreamFromGZipStore(string hash, DecompressionMethods acceptEncoding, IBucket gzipBucket, out DecompressionMethods method)
	{
		if ((acceptEncoding & DecompressionMethods.GZip) != 0)
		{
			method = DecompressionMethods.GZip;
			return new MemoryStream(gzipBucket.Download(hash), writable: false);
		}
		method = DecompressionMethods.None;
		MemoryStream uncompressed = new MemoryStream();
		using MemoryStream gzipStream = new MemoryStream(gzipBucket.Download(hash), writable: false);
		StreamUtilities.Uncompress(gzipStream, DecompressionMethods.GZip, uncompressed);
		return uncompressed;
	}

	private void Upload(string sourceContentHash, byte[] compressedData, string contentType, string format = null)
	{
		string hash = (string.IsNullOrEmpty(format) ? sourceContentHash : GenerateFormattedSourceContentHash(sourceContentHash, format));
		if (GetFileContentLocation(hash) != 0)
		{
			return;
		}
		string temporaryStoreFileName = TemporaryStoreManager.DeriveKey(hash);
		Stopwatch tempStoreUploadWatch = null;
		try
		{
			tempStoreUploadWatch = Stopwatch.StartNew();
			TemporaryStoreManager.Upload(temporaryStoreFileName, compressedData);
			tempStoreUploadWatch.Stop();
			FileUploadEventArgs fileUploadArgs = new FileUploadEventArgs
			{
				FileSizeInBytes = compressedData.Length,
				TimeInMilliseconds = tempStoreUploadWatch.ElapsedMilliseconds,
				Destination = "FileStore",
				FileName = temporaryStoreFileName
			};
			this.OnFileUploadedComplete?.Invoke(fileUploadArgs);
			File orCreate = File.GetOrCreate(hash);
			orCreate.AddLocationId(TemporaryContentStoreLocationId);
			orCreate.Save();
			FileUploadEventPublisher.PublishToSqs(hash, contentType, 0, 0, reverify: false, 0, format);
		}
		catch (IOException ex) when (ex.Message.ToLowerInvariant().Contains("because it is being used by another process"))
		{
			_Logger?.Info($"Failed to upload {hash} to temp store because it was being used by another process. Exception: \r\n{ex}");
		}
		catch (Exception e)
		{
			_Logger?.Error($"Failed to upload {hash} to temp store: \r\n{e}");
			throw;
		}
		finally
		{
			if (tempStoreUploadWatch != null && tempStoreUploadWatch.IsRunning)
			{
				tempStoreUploadWatch.Stop();
			}
		}
	}

	internal FileContentLocation GetFileContentLocation(File file)
	{
		if (file != null)
		{
			ISet<short> locationIds = file.GetLocationIds();
			if (locationIds.Contains(S3ContentLocationId))
			{
				return FileContentLocation.S3Content;
			}
			if (locationIds.Contains(TemporaryContentStoreLocationId))
			{
				return FileContentLocation.TemporaryContentStore;
			}
		}
		return FileContentLocation.None;
	}

	private byte[] GetCompressedDataFromStream(Stream data, DecompressionMethods method)
	{
		byte[] compressedData;
		if (method == DecompressionMethods.GZip)
		{
			compressedData = new byte[data.Length];
			data.Read(compressedData, 0, (int)data.Length);
		}
		else
		{
			using MemoryStream compressedStream = new MemoryStream();
			using (Stream s = StreamUtilities.Wrap(compressedStream, DecompressionMethods.GZip, CompressionMode.Compress))
			{
				if (method == DecompressionMethods.None)
				{
					StreamUtilities.CopyStream(data, s);
				}
				else
				{
					using Stream uncompressedStream = StreamUtilities.Wrap(data, method, CompressionMode.Decompress);
					StreamUtilities.CopyStream(uncompressedStream, s);
				}
			}
			compressedData = compressedStream.ToArray();
		}
		return compressedData;
	}

	[Obsolete("This is only meant for temporary use for multi-binary assets V1")]
	private string GenerateFormattedSourceContentHash(string sourceContentHash, string format)
	{
		return HashFunctions.ComputeMd5HashString($"{sourceContentHash}_{format}").ToLower();
	}

	[Obsolete("This is only meant for temporary use for multi-binary assets V1")]
	private string GenerateS3KeyForFormattedContent(string hash, string format)
	{
		if (string.IsNullOrEmpty(format))
		{
			return hash;
		}
		return $"{format}/{hash}";
	}
}
