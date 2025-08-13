using System;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Http;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.RequestContext;
using Roblox.TextFilter.Client.Properties;

namespace Roblox.TextFilter.Client;

public class TextFilterClientV2 : ITextFilterClientV2
{
	private readonly IServiceClientSettings _ServiceClientSettings;

	private readonly IHttpClient _HttpClient;

	public FilterLiveTextResult FilterLiveText(string text, IClientTextAuthor author, TextFilterUsage usage, string server, string instanceId)
	{
		FilterLiveTextRequest requestData = new FilterLiveTextRequest
		{
			Text = text,
			Author = author,
			UsageType = usage,
			TextUsage = string.Empty,
			Server = server,
			InstanceIdentifier = instanceId
		};
		return SendRequest<FilterLiveTextRequest, FilterLiveTextResult>("/v1/FilterLiveText", requestData);
	}

	public Task<FilterLiveTextResult> FilterLiveTextAsync(string text, IClientTextAuthor author, TextFilterUsage usage, string server, string instanceId, CancellationToken cancellationToken)
	{
		FilterLiveTextRequest requestData = new FilterLiveTextRequest
		{
			Text = text,
			Author = author,
			UsageType = usage,
			TextUsage = string.Empty,
			Server = server,
			InstanceIdentifier = instanceId
		};
		return SendRequestAsync<FilterLiveTextRequest, FilterLiveTextResult>("/v1/FilterLiveText", requestData, cancellationToken);
	}

	public FilterTextResult FilterObjectName(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter)
	{
		FilterTextRequest requestData = new FilterTextRequest
		{
			Text = text,
			Author = author,
			UsageType = usage,
			TextUsage = string.Empty,
			InstanceIdentifier = instanceId,
			IgnoreVerticalFilter = ignoreVerticalFilter
		};
		return SendRequest<FilterTextRequest, FilterTextResult>("/v1/FilterObjectName", requestData);
	}

	public Task<FilterTextResult> FilterObjectNameAsync(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter, CancellationToken cancellationToken)
	{
		FilterTextRequest requestData = new FilterTextRequest
		{
			Text = text,
			Author = author,
			UsageType = usage,
			TextUsage = string.Empty,
			InstanceIdentifier = instanceId,
			IgnoreVerticalFilter = ignoreVerticalFilter
		};
		return SendRequestAsync<FilterTextRequest, FilterTextResult>("/v1/FilterObjectName", requestData, cancellationToken);
	}

	public FilterTextResult FilterSearchKeyword(string text, IClientTextAuthor author, TextFilterUsage usage)
	{
		FilterTextRequest requestData = new FilterTextRequest
		{
			Text = text,
			Author = author,
			UsageType = usage,
			TextUsage = string.Empty,
			InstanceIdentifier = string.Empty
		};
		return SendRequest<FilterTextRequest, FilterTextResult>("/v1/FilterSearchKeyword", requestData);
	}

	public Task<FilterTextResult> FilterSearchKeywordAsync(string text, IClientTextAuthor author, TextFilterUsage usage, CancellationToken cancellationToken)
	{
		FilterTextRequest requestData = new FilterTextRequest
		{
			Text = text,
			Author = author,
			UsageType = usage,
			TextUsage = string.Empty,
			InstanceIdentifier = string.Empty
		};
		return SendRequestAsync<FilterTextRequest, FilterTextResult>("/v1/FilterSearchKeyword", requestData, cancellationToken);
	}

	public FilterTextResult FilterText(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter)
	{
		FilterTextRequest requestData = new FilterTextRequest
		{
			Text = text,
			Author = author,
			UsageType = usage,
			TextUsage = string.Empty,
			InstanceIdentifier = instanceId,
			IgnoreVerticalFilter = ignoreVerticalFilter
		};
		return SendRequest<FilterTextRequest, FilterTextResult>("/v1/FilterText", requestData);
	}

	public Task<FilterTextResult> FilterTextAsync(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter, CancellationToken cancellationToken)
	{
		FilterTextRequest requestData = new FilterTextRequest
		{
			Text = text,
			Author = author,
			UsageType = usage,
			TextUsage = string.Empty,
			InstanceIdentifier = instanceId,
			IgnoreVerticalFilter = ignoreVerticalFilter
		};
		return SendRequestAsync<FilterTextRequest, FilterTextResult>("/v1/FilterText", requestData, cancellationToken);
	}

	public FilterUsernameResult FilterUsername(string text, IClientTextAuthor author, bool canBypassReservedUsername)
	{
		FilterUsernameRequest requestData = new FilterUsernameRequest
		{
			Text = text,
			Author = author,
			CanBypassReservedUsername = canBypassReservedUsername
		};
		return SendRequest<FilterUsernameRequest, FilterUsernameResult>("/v1/FilterUsername", requestData);
	}

	public Task<FilterUsernameResult> FilterUsernameAsync(string text, IClientTextAuthor author, bool canBypassReservedUsername, CancellationToken cancellationToken)
	{
		FilterUsernameRequest requestData = new FilterUsernameRequest
		{
			Text = text,
			Author = author,
			CanBypassReservedUsername = canBypassReservedUsername
		};
		return SendRequestAsync<FilterUsernameRequest, FilterUsernameResult>("/v1/FilterUsername", requestData, cancellationToken);
	}

	private TResponse SendRequest<TRequest, TResponse>(string path, TRequest requestData)
	{
		IHttpRequest request = CreateRequest(path, requestData);
		IHttpResponse response = _HttpClient.Send(request);
		return ParseResponse<TResponse>(response);
	}

	private async Task<TResponse> SendRequestAsync<TRequest, TResponse>(string path, TRequest requestData, CancellationToken cancellationToken)
	{
		IHttpRequest request = CreateRequest(path, requestData);
		return ParseResponse<TResponse>(await _HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
	}

	private IHttpRequest CreateRequest<TRequest>(string path, TRequest requestData)
	{
		HttpRequest httpRequest = new HttpRequest(HttpMethod.Post, new Uri(_ServiceClientSettings.Endpoint.TrimEnd(new char[1] { '/' }) + "/" + path.TrimStart(new char[1] { '/' })));
		httpRequest.SetJsonRequestBody(requestData);
		return httpRequest;
	}

	private TResponse ParseResponse<TResponse>(IHttpResponse response)
	{
		return response.GetJsonBody<Payload<TResponse>>().Data;
	}

	public TextFilterClientV2(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader)
		: this(new Roblox.Http.ServiceClient.HttpClientBuilder(Settings.Default, counterRegistry, apiKeyGetter, null, requestContextLoader), Settings.Default)
	{
		if (requestContextLoader == null)
		{
			throw new ArgumentNullException("requestContextLoader");
		}
	}

	[Obsolete("Please use TextFilterClientV2(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader)", true)]
	public TextFilterClientV2(ICounterRegistry counterRegistry, Func<string> apiKeyGetter)
	{
		throw new NotSupportedException("This constructor is not supported");
	}

	private TextFilterClientV2(IHttpClientBuilder httpClientBuilder, IServiceClientSettings serviceClientSettings)
	{
		if (httpClientBuilder == null)
		{
			throw new ArgumentNullException("httpClientBuilder");
		}
		_HttpClient = httpClientBuilder.Build();
		_ServiceClientSettings = serviceClientSettings ?? throw new ArgumentNullException("serviceClientSettings");
	}
}
