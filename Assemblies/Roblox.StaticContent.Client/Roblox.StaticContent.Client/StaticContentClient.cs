using System;
using System.Threading;
using System.Threading.Tasks;
using Roblox.DataV2.Core;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.RequestContext;
using Roblox.StaticContent.Client.Properties;

namespace Roblox.StaticContent.Client;

public class StaticContentClient : IStaticContentClient
{
	private readonly IServiceRequestSender _ServiceRequestSender;

	public StaticContentClient(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader = null)
		: this(new Roblox.Http.ServiceClient.HttpClientBuilder(Settings.Default, counterRegistry, apiKeyGetter, null, requestContextLoader), Settings.Default)
	{
	}

	public StaticContentClient(IHttpClientBuilder httpClientBuilder, IServiceClientSettings serviceClientSettings)
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

	public StaticContentResult CreateContentPack(string name, string componentName, string cssContent, string javaScriptContent, string[] translationResourceNamespaces, string[] componentDependencies)
	{
		CreateContentPackRequest requestData = new CreateContentPackRequest
		{
			Name = name,
			ComponentName = componentName,
			CssContent = cssContent,
			JavaScriptContent = javaScriptContent,
			TranslationResourceNamespaces = translationResourceNamespaces,
			ComponentDependencies = componentDependencies
		};
		return _ServiceRequestSender.SendPostRequest<CreateContentPackRequest, StaticContentResult>("/v1/CreateContentPack", requestData);
	}

	public Task<StaticContentResult> CreateContentPackAsync(string name, string componentName, string cssContent, string javaScriptContent, string[] translationResourceNamespaces, string[] componentDependencies, CancellationToken cancellationToken)
	{
		CreateContentPackRequest requestData = new CreateContentPackRequest
		{
			Name = name,
			ComponentName = componentName,
			CssContent = cssContent,
			JavaScriptContent = javaScriptContent,
			TranslationResourceNamespaces = translationResourceNamespaces,
			ComponentDependencies = componentDependencies
		};
		return _ServiceRequestSender.SendPostRequestAsync<CreateContentPackRequest, StaticContentResult>("/v1/CreateContentPack", requestData, cancellationToken);
	}

	public ContentPackResult[] GetContentPacks(string component, bool? enabled, bool? validated, SortOrder sortOrder, long? exclusiveStartContentPackId, int count)
	{
		GetContentPacksRequest requestData = new GetContentPacksRequest
		{
			Component = component,
			Enabled = enabled,
			Validated = validated,
			SortOrder = sortOrder,
			ExclusiveStartContentPackId = exclusiveStartContentPackId,
			Count = count
		};
		return _ServiceRequestSender.SendPostRequest<GetContentPacksRequest, ContentPackResult[]>("/v1/GetContentPacks", requestData);
	}

	public Task<ContentPackResult[]> GetContentPacksAsync(string component, bool? enabled, bool? validated, SortOrder sortOrder, long? exclusiveStartContentPackId, int count, CancellationToken cancellationToken)
	{
		GetContentPacksRequest requestData = new GetContentPacksRequest
		{
			Component = component,
			Enabled = enabled,
			Validated = validated,
			SortOrder = sortOrder,
			ExclusiveStartContentPackId = exclusiveStartContentPackId,
			Count = count
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetContentPacksRequest, ContentPackResult[]>("/v1/GetContentPacks", requestData, cancellationToken);
	}

	public StaticContentResult UpdateContentPack(long id, bool enabled, bool validated)
	{
		UpdateContentPackRequest requestData = new UpdateContentPackRequest
		{
			Id = id,
			Enabled = enabled,
			Validated = validated
		};
		return _ServiceRequestSender.SendPostRequest<UpdateContentPackRequest, StaticContentResult>("/v1/UpdateContentPack", requestData);
	}

	public Task<StaticContentResult> UpdateContentPackAsync(long id, bool enabled, bool validated, CancellationToken cancellationToken)
	{
		UpdateContentPackRequest requestData = new UpdateContentPackRequest
		{
			Id = id,
			Enabled = enabled,
			Validated = validated
		};
		return _ServiceRequestSender.SendPostRequestAsync<UpdateContentPackRequest, StaticContentResult>("/v1/UpdateContentPack", requestData, cancellationToken);
	}

	public UploadImageResult UploadImage(string imageName, byte[] imageContent)
	{
		UploadImageRequest requestData = new UploadImageRequest
		{
			ImageName = imageName,
			ImageContent = imageContent
		};
		return _ServiceRequestSender.SendPostRequest<UploadImageRequest, UploadImageResult>("/v1/UploadImage", requestData);
	}

	public Task<UploadImageResult> UploadImageAsync(string imageName, byte[] imageContent, CancellationToken cancellationToken)
	{
		UploadImageRequest requestData = new UploadImageRequest
		{
			ImageName = imageName,
			ImageContent = imageContent
		};
		return _ServiceRequestSender.SendPostRequestAsync<UploadImageRequest, UploadImageResult>("/v1/UploadImage", requestData, cancellationToken);
	}

	public UploadSourceMapResult UploadSourceMap(string sourceMapName, string sourceMapContent)
	{
		UploadSourceMapRequest requestData = new UploadSourceMapRequest
		{
			SourceMapName = sourceMapName,
			SourceMapContent = sourceMapContent
		};
		return _ServiceRequestSender.SendPostRequest<UploadSourceMapRequest, UploadSourceMapResult>("/v1/UploadSourceMap", requestData);
	}

	public Task<UploadSourceMapResult> UploadSourceMapAsync(string sourceMapName, string sourceMapContent, CancellationToken cancellationToken)
	{
		UploadSourceMapRequest requestData = new UploadSourceMapRequest
		{
			SourceMapName = sourceMapName,
			SourceMapContent = sourceMapContent
		};
		return _ServiceRequestSender.SendPostRequestAsync<UploadSourceMapRequest, UploadSourceMapResult>("/v1/UploadSourceMap", requestData, cancellationToken);
	}

	public StaticContentResult CreateDevelopmentContentPack(string workspace, string componentName, string cssContent, string javaScriptContent, string[] translationResourceNamespaces, string[] componentDependencies)
	{
		CreateDevelopmentContentPackRequest requestData = new CreateDevelopmentContentPackRequest
		{
			Workspace = workspace,
			ComponentName = componentName,
			CssContent = cssContent,
			JavaScriptContent = javaScriptContent,
			TranslationResourceNamespaces = translationResourceNamespaces,
			ComponentDependencies = componentDependencies
		};
		return _ServiceRequestSender.SendPostRequest<CreateDevelopmentContentPackRequest, StaticContentResult>("/v1/CreateDevelopmentContentPack", requestData);
	}

	public Task<StaticContentResult> CreateDevelopmentContentPackAsync(string workspace, string componentName, string cssContent, string javaScriptContent, string[] translationResourceNamespaces, string[] componentDependencies, CancellationToken cancellationToken)
	{
		CreateDevelopmentContentPackRequest requestData = new CreateDevelopmentContentPackRequest
		{
			Workspace = workspace,
			ComponentName = componentName,
			CssContent = cssContent,
			JavaScriptContent = javaScriptContent,
			TranslationResourceNamespaces = translationResourceNamespaces,
			ComponentDependencies = componentDependencies
		};
		return _ServiceRequestSender.SendPostRequestAsync<CreateDevelopmentContentPackRequest, StaticContentResult>("/v1/CreateDevelopmentContentPack", requestData, cancellationToken);
	}

	public string GetRawContent(long contentPackItemId)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = contentPackItemId
		};
		return _ServiceRequestSender.SendPostRequest<Payload<long>, string>("/v1/GetRawContent", requestData);
	}

	public Task<string> GetRawContentAsync(long contentPackItemId, CancellationToken cancellationToken)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = contentPackItemId
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<long>, string>("/v1/GetRawContent", requestData, cancellationToken);
	}
}
