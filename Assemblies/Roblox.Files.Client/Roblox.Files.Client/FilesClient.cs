using System;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Files.Client.Properties;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.RequestContext;

namespace Roblox.Files.Client;

public class FilesClient : IFilesClient
{
	private readonly IServiceRequestSender _ServiceRequestSender;

	public FilesClient(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader = null)
		: this(CreateHttpClientBuilder(counterRegistry, apiKeyGetter, requestContextLoader), Settings.Default)
	{
	}

	public FilesClient(IHttpClientBuilder httpClientBuilder, IServiceClientSettings serviceClientSettings)
	{
		if (httpClientBuilder == null)
		{
			throw new ArgumentNullException("httpClientBuilder");
		}
		if (serviceClientSettings == null)
		{
			throw new ArgumentNullException("serviceClientSettings");
		}
		IHttpClient httpClient = httpClientBuilder.Build();
		HttpRequestBuilder httpRequestBuilder = new HttpRequestBuilder(serviceClientSettings.Endpoint);
		_ServiceRequestSender = new ServiceRequestSender(httpClient, httpRequestBuilder);
	}

	public AddFileResult AddFile(byte[] content, string decompressionMethod, string contentType, bool isCjvRequest, string assetType)
	{
		AddFileRequest requestData = new AddFileRequest
		{
			Content = content,
			DecompressionMethod = decompressionMethod,
			ContentType = contentType,
			IsCjvRequest = isCjvRequest,
			AssetType = assetType
		};
		return _ServiceRequestSender.SendPostRequest<AddFileRequest, AddFileResult>("/v1/AddFile", requestData);
	}

	public Task<AddFileResult> AddFileAsync(byte[] content, string decompressionMethod, string contentType, bool isCjvRequest, string assetType, CancellationToken cancellationToken)
	{
		AddFileRequest requestData = new AddFileRequest
		{
			Content = content,
			DecompressionMethod = decompressionMethod,
			ContentType = contentType,
			IsCjvRequest = isCjvRequest,
			AssetType = assetType
		};
		return _ServiceRequestSender.SendPostRequestAsync<AddFileRequest, AddFileResult>("/v1/AddFile", requestData, cancellationToken);
	}

	public AddFileResult AddFileV2(byte[] content, string decompressionMethod, string contentType, bool isCjvRequest, string assetType)
	{
		AddFileRequest requestData = new AddFileRequest
		{
			Content = content,
			DecompressionMethod = decompressionMethod,
			ContentType = contentType,
			IsCjvRequest = isCjvRequest,
			AssetType = assetType
		};
		return _ServiceRequestSender.SendPostRequest<AddFileRequest, AddFileResult>("/v1/AddFileV2", requestData);
	}

	public Task<AddFileResult> AddFileV2Async(byte[] content, string decompressionMethod, string contentType, bool isCjvRequest, string assetType, CancellationToken cancellationToken)
	{
		AddFileRequest requestData = new AddFileRequest
		{
			Content = content,
			DecompressionMethod = decompressionMethod,
			ContentType = contentType,
			IsCjvRequest = isCjvRequest,
			AssetType = assetType
		};
		return _ServiceRequestSender.SendPostRequestAsync<AddFileRequest, AddFileResult>("/v1/AddFileV2", requestData, cancellationToken);
	}

	public GetUriResult GetUri(string Hash, bool IsRequestSecure)
	{
		GetUriRequest requestData = new GetUriRequest
		{
			Hash = Hash,
			IsRequestSecure = IsRequestSecure
		};
		return _ServiceRequestSender.SendPostRequest<GetUriRequest, GetUriResult>("/v1/GetUri", requestData);
	}

	public Task<GetUriResult> GetUriAsync(string Hash, bool IsRequestSecure, CancellationToken cancellationToken)
	{
		GetUriRequest requestData = new GetUriRequest
		{
			Hash = Hash,
			IsRequestSecure = IsRequestSecure
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetUriRequest, GetUriResult>("/v1/GetUri", requestData, cancellationToken);
	}

	public AddFileLocationResult AddFileLocation(string Hash, FileContentLocation FileContentLocation)
	{
		AddFileLocationRequest requestData = new AddFileLocationRequest
		{
			Hash = Hash,
			FileContentLocation = FileContentLocation
		};
		return _ServiceRequestSender.SendPostRequest<AddFileLocationRequest, AddFileLocationResult>("/v1/AddFileLocation", requestData);
	}

	public Task<AddFileLocationResult> AddFileLocationAsync(string Hash, FileContentLocation FileContentLocation, CancellationToken cancellationToken)
	{
		AddFileLocationRequest requestData = new AddFileLocationRequest
		{
			Hash = Hash,
			FileContentLocation = FileContentLocation
		};
		return _ServiceRequestSender.SendPostRequestAsync<AddFileLocationRequest, AddFileLocationResult>("/v1/AddFileLocation", requestData, cancellationToken);
	}

	public DeleteFileLocationResult DeleteFileLocation(string Hash, FileContentLocation FileContentLocation)
	{
		DeleteFileLocationRequest requestData = new DeleteFileLocationRequest
		{
			Hash = Hash,
			FileContentLocation = FileContentLocation
		};
		return _ServiceRequestSender.SendPostRequest<DeleteFileLocationRequest, DeleteFileLocationResult>("/v1/DeleteFileLocation", requestData);
	}

	public Task<DeleteFileLocationResult> DeleteFileLocationAsync(string Hash, FileContentLocation FileContentLocation, CancellationToken cancellationToken)
	{
		DeleteFileLocationRequest requestData = new DeleteFileLocationRequest
		{
			Hash = Hash,
			FileContentLocation = FileContentLocation
		};
		return _ServiceRequestSender.SendPostRequestAsync<DeleteFileLocationRequest, DeleteFileLocationResult>("/v1/DeleteFileLocation", requestData, cancellationToken);
	}

	public GetFileContentLocationResult GetFileContentLocation(string Hash)
	{
		GetFileContentLocationRequest requestData = new GetFileContentLocationRequest
		{
			Hash = Hash
		};
		return _ServiceRequestSender.SendPostRequest<GetFileContentLocationRequest, GetFileContentLocationResult>("/v1/GetFileContentLocation", requestData);
	}

	public Task<GetFileContentLocationResult> GetFileContentLocationAsync(string Hash, CancellationToken cancellationToken)
	{
		GetFileContentLocationRequest requestData = new GetFileContentLocationRequest
		{
			Hash = Hash
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetFileContentLocationRequest, GetFileContentLocationResult>("/v1/GetFileContentLocation", requestData, cancellationToken);
	}

	private static ClientCircuitBreakerType GetClientCircuitBreakerType()
	{
		if (!Settings.Default.PerEndpointCircuitBreakerEnabled)
		{
			return (ClientCircuitBreakerType)1;
		}
		return (ClientCircuitBreakerType)2;
	}

	private static bool ApiKeyViaHeaderEnabled()
	{
		return Settings.Default.ApiKeyViaHeaderEnabled;
	}

	private static IHttpClientBuilder CreateHttpClientBuilder(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader)
	{
		return new Roblox.Http.ServiceClient.HttpClientBuilder(Settings.Default, counterRegistry, apiKeyGetter, null, requestContextLoader)
		{
			ApiKeyViaHeaderEnabled = ApiKeyViaHeaderEnabled,
			GetClientCircuitBreakerType = GetClientCircuitBreakerType
		};
	}
}
