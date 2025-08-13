using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.Localization.Client.Properties;
using Roblox.RequestContext;

namespace Roblox.Localization.Client;

public class LocalizationClient : ILocalizationClient
{
	private readonly IServiceRequestSender _ServiceRequestSender;

	public LocalizationClient(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader = null)
		: this(CreateHttpClientBuilder(counterRegistry, apiKeyGetter, requestContextLoader), Settings.Default)
	{
	}

	public LocalizationClient(IHttpClientBuilder httpClientBuilder, IServiceClientSettings serviceClientSettings)
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

	public GetLanguageFamilyByIdResponse GetLanguageFamilyById(int id)
	{
		GetLanguageFamilyByIdRequest requestData = new GetLanguageFamilyByIdRequest
		{
			Id = id
		};
		return _ServiceRequestSender.SendPostRequest<GetLanguageFamilyByIdRequest, GetLanguageFamilyByIdResponse>("/v1/GetLanguageFamilyById", requestData);
	}

	public Task<GetLanguageFamilyByIdResponse> GetLanguageFamilyByIdAsync(int id, CancellationToken cancellationToken)
	{
		GetLanguageFamilyByIdRequest requestData = new GetLanguageFamilyByIdRequest
		{
			Id = id
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetLanguageFamilyByIdRequest, GetLanguageFamilyByIdResponse>("/v1/GetLanguageFamilyById", requestData, cancellationToken);
	}

	public GetLanguageFamilyByLanguageCodeResponse GetLanguageFamilyByLanguageCode(string languageCode)
	{
		GetLanguageFamilyByLanguageCodeRequest requestData = new GetLanguageFamilyByLanguageCodeRequest
		{
			LanguageCode = languageCode
		};
		return _ServiceRequestSender.SendPostRequest<GetLanguageFamilyByLanguageCodeRequest, GetLanguageFamilyByLanguageCodeResponse>("/v1/GetLanguageFamilyByLanguageCode", requestData);
	}

	public Task<GetLanguageFamilyByLanguageCodeResponse> GetLanguageFamilyByLanguageCodeAsync(string languageCode, CancellationToken cancellationToken)
	{
		GetLanguageFamilyByLanguageCodeRequest requestData = new GetLanguageFamilyByLanguageCodeRequest
		{
			LanguageCode = languageCode
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetLanguageFamilyByLanguageCodeRequest, GetLanguageFamilyByLanguageCodeResponse>("/v1/GetLanguageFamilyByLanguageCode", requestData, cancellationToken);
	}

	public IEnumerable<SupportedLocale> GetAllSupportedLocales()
	{
		EmptyRequest requestData = new EmptyRequest();
		return _ServiceRequestSender.SendPostRequest<EmptyRequest, IEnumerable<SupportedLocale>>("/v1/GetAllSupportedLocales", requestData);
	}

	public Task<IEnumerable<SupportedLocale>> GetAllSupportedLocalesAsync(CancellationToken cancellationToken)
	{
		EmptyRequest requestData = new EmptyRequest();
		return _ServiceRequestSender.SendPostRequestAsync<EmptyRequest, IEnumerable<SupportedLocale>>("/v1/GetAllSupportedLocales", requestData, cancellationToken);
	}

	public GetSupportedLocaleByLocaleCodeResponse GetSupportedLocaleByLocaleCode(string code)
	{
		GetSupportedLocaleByLocaleCodeRequest requestData = new GetSupportedLocaleByLocaleCodeRequest
		{
			Code = code
		};
		return _ServiceRequestSender.SendPostRequest<GetSupportedLocaleByLocaleCodeRequest, GetSupportedLocaleByLocaleCodeResponse>("/v1/GetSupportedLocaleByLocaleCode", requestData);
	}

	public Task<GetSupportedLocaleByLocaleCodeResponse> GetSupportedLocaleByLocaleCodeAsync(string code, CancellationToken cancellationToken)
	{
		GetSupportedLocaleByLocaleCodeRequest requestData = new GetSupportedLocaleByLocaleCodeRequest
		{
			Code = code
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetSupportedLocaleByLocaleCodeRequest, GetSupportedLocaleByLocaleCodeResponse>("/v1/GetSupportedLocaleByLocaleCode", requestData, cancellationToken);
	}

	public GetSupportedLocaleByIdResponse GetSupportedLocaleById(int id)
	{
		GetSupportedLocaleByIdRequest requestData = new GetSupportedLocaleByIdRequest
		{
			Id = id
		};
		return _ServiceRequestSender.SendPostRequest<GetSupportedLocaleByIdRequest, GetSupportedLocaleByIdResponse>("/v1/GetSupportedLocaleById", requestData);
	}

	public Task<GetSupportedLocaleByIdResponse> GetSupportedLocaleByIdAsync(int id, CancellationToken cancellationToken)
	{
		GetSupportedLocaleByIdRequest requestData = new GetSupportedLocaleByIdRequest
		{
			Id = id
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetSupportedLocaleByIdRequest, GetSupportedLocaleByIdResponse>("/v1/GetSupportedLocaleById", requestData, cancellationToken);
	}

	public GetDefaultSupportedLocaleByLanguageCodeResponse GetDefaultSupportedLocaleByLanguageCode(string languageCode)
	{
		GetDefaultSupportedLocaleByLanguageCodeRequest requestData = new GetDefaultSupportedLocaleByLanguageCodeRequest
		{
			LanguageCode = languageCode
		};
		return _ServiceRequestSender.SendPostRequest<GetDefaultSupportedLocaleByLanguageCodeRequest, GetDefaultSupportedLocaleByLanguageCodeResponse>("/v1/GetDefaultSupportedLocaleByLanguageCode", requestData);
	}

	public Task<GetDefaultSupportedLocaleByLanguageCodeResponse> GetDefaultSupportedLocaleByLanguageCodeAsync(string languageCode, CancellationToken cancellationToken)
	{
		GetDefaultSupportedLocaleByLanguageCodeRequest requestData = new GetDefaultSupportedLocaleByLanguageCodeRequest
		{
			LanguageCode = languageCode
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetDefaultSupportedLocaleByLanguageCodeRequest, GetDefaultSupportedLocaleByLanguageCodeResponse>("/v1/GetDefaultSupportedLocaleByLanguageCode", requestData, cancellationToken);
	}

	public GetSupportedLocalesByParentLanguageResponse GetSupportedLocalesByParentLanguage(string languageCode)
	{
		GetSupportedLocalesByParentLanguageRequest requestData = new GetSupportedLocalesByParentLanguageRequest
		{
			LanguageCode = languageCode
		};
		return _ServiceRequestSender.SendPostRequest<GetSupportedLocalesByParentLanguageRequest, GetSupportedLocalesByParentLanguageResponse>("/v1/GetSupportedLocalesByParentLanguage", requestData);
	}

	public Task<GetSupportedLocalesByParentLanguageResponse> GetSupportedLocalesByParentLanguageAsync(string languageCode, CancellationToken cancellationToken)
	{
		GetSupportedLocalesByParentLanguageRequest requestData = new GetSupportedLocalesByParentLanguageRequest
		{
			LanguageCode = languageCode
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetSupportedLocalesByParentLanguageRequest, GetSupportedLocalesByParentLanguageResponse>("/v1/GetSupportedLocalesByParentLanguage", requestData, cancellationToken);
	}

	public int RecordDeviceReportedLocale(string rawDeviceReportedLocaleCode)
	{
		Payload<string> requestData = new Payload<string>
		{
			Data = rawDeviceReportedLocaleCode
		};
		return _ServiceRequestSender.SendPostRequest<Payload<string>, int>("/v1/RecordDeviceReportedLocale", requestData);
	}

	public Task<int> RecordDeviceReportedLocaleAsync(string rawDeviceReportedLocaleCode, CancellationToken cancellationToken)
	{
		Payload<string> requestData = new Payload<string>
		{
			Data = rawDeviceReportedLocaleCode
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<string>, int>("/v1/RecordDeviceReportedLocale", requestData, cancellationToken);
	}

	public MapDeviceReportedLocaleToSupportedLocaleResult MapDeviceReportedLocaleToSupportedLocale(int supportedLocaleId, int deviceReportedLocaleId)
	{
		MapDeviceReportedLocaleToSupportedLocaleRequest requestData = new MapDeviceReportedLocaleToSupportedLocaleRequest
		{
			SupportedLocaleId = supportedLocaleId,
			DeviceReportedLocaleId = deviceReportedLocaleId
		};
		return _ServiceRequestSender.SendPostRequest<MapDeviceReportedLocaleToSupportedLocaleRequest, MapDeviceReportedLocaleToSupportedLocaleResult>("/v1/MapDeviceReportedLocaleToSupportedLocale", requestData);
	}

	public Task<MapDeviceReportedLocaleToSupportedLocaleResult> MapDeviceReportedLocaleToSupportedLocaleAsync(int supportedLocaleId, int deviceReportedLocaleId, CancellationToken cancellationToken)
	{
		MapDeviceReportedLocaleToSupportedLocaleRequest requestData = new MapDeviceReportedLocaleToSupportedLocaleRequest
		{
			SupportedLocaleId = supportedLocaleId,
			DeviceReportedLocaleId = deviceReportedLocaleId
		};
		return _ServiceRequestSender.SendPostRequestAsync<MapDeviceReportedLocaleToSupportedLocaleRequest, MapDeviceReportedLocaleToSupportedLocaleResult>("/v1/MapDeviceReportedLocaleToSupportedLocale", requestData, cancellationToken);
	}

	public MapDeviceReportedLocaleToLanguageFamilyResult MapDeviceReportedLocaleToLanguageFamily(int languageFamilyId, int deviceReportedLocaleId)
	{
		MapDeviceReportedLocaleToLanguageFamilyRequest requestData = new MapDeviceReportedLocaleToLanguageFamilyRequest
		{
			LanguageFamilyId = languageFamilyId,
			DeviceReportedLocaleId = deviceReportedLocaleId
		};
		return _ServiceRequestSender.SendPostRequest<MapDeviceReportedLocaleToLanguageFamilyRequest, MapDeviceReportedLocaleToLanguageFamilyResult>("/v1/MapDeviceReportedLocaleToLanguageFamily", requestData);
	}

	public Task<MapDeviceReportedLocaleToLanguageFamilyResult> MapDeviceReportedLocaleToLanguageFamilyAsync(int languageFamilyId, int deviceReportedLocaleId, CancellationToken cancellationToken)
	{
		MapDeviceReportedLocaleToLanguageFamilyRequest requestData = new MapDeviceReportedLocaleToLanguageFamilyRequest
		{
			LanguageFamilyId = languageFamilyId,
			DeviceReportedLocaleId = deviceReportedLocaleId
		};
		return _ServiceRequestSender.SendPostRequestAsync<MapDeviceReportedLocaleToLanguageFamilyRequest, MapDeviceReportedLocaleToLanguageFamilyResult>("/v1/MapDeviceReportedLocaleToLanguageFamily", requestData, cancellationToken);
	}

	public GetDeviceReportedLocaleByIdResponse GetDeviceReportedLocaleById(int id)
	{
		GetDeviceReportedLocaleByIdRequest requestData = new GetDeviceReportedLocaleByIdRequest
		{
			Id = id
		};
		return _ServiceRequestSender.SendPostRequest<GetDeviceReportedLocaleByIdRequest, GetDeviceReportedLocaleByIdResponse>("/v1/GetDeviceReportedLocaleById", requestData);
	}

	public Task<GetDeviceReportedLocaleByIdResponse> GetDeviceReportedLocaleByIdAsync(int id, CancellationToken cancellationToken)
	{
		GetDeviceReportedLocaleByIdRequest requestData = new GetDeviceReportedLocaleByIdRequest
		{
			Id = id
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetDeviceReportedLocaleByIdRequest, GetDeviceReportedLocaleByIdResponse>("/v1/GetDeviceReportedLocaleById", requestData, cancellationToken);
	}

	public GetDeviceReportedLocaleByCodeResponse GetDeviceReportedLocaleByCode(string deviceReportedLocaleCode)
	{
		GetDeviceReportedLocaleByCodeRequest requestData = new GetDeviceReportedLocaleByCodeRequest
		{
			DeviceReportedLocaleCode = deviceReportedLocaleCode
		};
		return _ServiceRequestSender.SendPostRequest<GetDeviceReportedLocaleByCodeRequest, GetDeviceReportedLocaleByCodeResponse>("/v1/GetDeviceReportedLocaleByCode", requestData);
	}

	public Task<GetDeviceReportedLocaleByCodeResponse> GetDeviceReportedLocaleByCodeAsync(string deviceReportedLocaleCode, CancellationToken cancellationToken)
	{
		GetDeviceReportedLocaleByCodeRequest requestData = new GetDeviceReportedLocaleByCodeRequest
		{
			DeviceReportedLocaleCode = deviceReportedLocaleCode
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetDeviceReportedLocaleByCodeRequest, GetDeviceReportedLocaleByCodeResponse>("/v1/GetDeviceReportedLocaleByCode", requestData, cancellationToken);
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
		return new Roblox.Http.ServiceClient.HttpClientBuilder((IServiceClientSettings)Settings.Default, counterRegistry, apiKeyGetter, (Func<bool>)null, (CookieContainer)null, requestContextLoader, (IHttpMessageHandlerBuilder)null, (CircuitBreakerMode)0)
		{
			ApiKeyViaHeaderEnabled = ApiKeyViaHeaderEnabled,
			GetClientCircuitBreakerType = GetClientCircuitBreakerType
		};
	}
}
