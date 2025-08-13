using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Files.Client;

public interface IFilesClient
{
	AddFileResult AddFile(byte[] content, string decompressionMethod, string contentType, bool isCjvRequest, string assetType);

	Task<AddFileResult> AddFileAsync(byte[] content, string decompressionMethod, string contentType, bool isCjvRequest, string assetType, CancellationToken cancellationToken);

	AddFileResult AddFileV2(byte[] content, string decompressionMethod, string contentType, bool isCjvRequest, string assetType);

	Task<AddFileResult> AddFileV2Async(byte[] content, string decompressionMethod, string contentType, bool isCjvRequest, string assetType, CancellationToken cancellationToken);

	GetUriResult GetUri(string Hash, bool IsRequestSecure);

	Task<GetUriResult> GetUriAsync(string Hash, bool IsRequestSecure, CancellationToken cancellationToken);

	AddFileLocationResult AddFileLocation(string Hash, FileContentLocation FileContentLocation);

	Task<AddFileLocationResult> AddFileLocationAsync(string Hash, FileContentLocation FileContentLocation, CancellationToken cancellationToken);

	DeleteFileLocationResult DeleteFileLocation(string Hash, FileContentLocation FileContentLocation);

	Task<DeleteFileLocationResult> DeleteFileLocationAsync(string Hash, FileContentLocation FileContentLocation, CancellationToken cancellationToken);

	GetFileContentLocationResult GetFileContentLocation(string Hash);

	Task<GetFileContentLocationResult> GetFileContentLocationAsync(string Hash, CancellationToken cancellationToken);
}
