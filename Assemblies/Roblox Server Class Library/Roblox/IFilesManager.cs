using System;
using System.IO;
using System.Net;
using System.Web;
using System.Xml;
using Roblox.EventLog;

namespace Roblox;

public interface IFilesManager
{
	TempStoreManager TemporaryStoreManager { get; set; }

	event Action<FileUploadEventArgs> OnFileUploadedComplete;

	event Action<DeleteFromTempStoreArgs> EnqueueToDeleteFromTemporaryStore;

	string AddFile(byte[] compressedData, string contentType = null);

	string AddUncompressedFile(byte[] uncompressedData);

	string AddFile(Stream data, DecompressionMethods method, string contentType = null);

	MemoryStream GetStream(string hash);

	MemoryStream GetStream(string hash, DecompressionMethods acceptEncoding, out DecompressionMethods method);

	/// <summary>
	/// Gets the <see cref="T:Roblox.FileContentLocation" /> for <paramref name="hash" />.
	/// </summary>
	/// <param name="hash">The hash used to identify the file.</param>
	/// <returns>the requested <see cref="T:Roblox.FileContentLocation" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="hash" /> is null or empty.</exception>
	FileContentLocation GetFileContentLocation(string hash);

	Uri GetUri(string hash, HttpRequest request);

	Uri GetUri(string hash, HttpRequestBase request);

	Uri GetUri(string hash, bool secureConnection, string encodingType, string userAgent);

	[Obsolete("This is only meant for temporary use for multi-binary assets V1")]
	Uri GetUri(string hash, string format, bool secureConnection, string encodingType, string userAgent);

	void ProcessRequest(string hash, HttpContext context);

	XmlDocument GetFileXml(string fileHash);

	FileTransferStatus TransferFromTemporaryContentStoreToS3ProcessorOnly(string hash, string contentType, ILogger logger = null, string format = null);

	FileTransferStatus DeleteFromTemporaryContentStore(string hash, ILogger logger);
}
