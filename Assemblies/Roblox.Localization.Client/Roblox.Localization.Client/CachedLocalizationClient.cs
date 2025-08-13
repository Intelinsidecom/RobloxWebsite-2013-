using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Localization.Client;

public class CachedLocalizationClient : ILocalizationClient
{
	private ILocalizationClient _LocalizationClient;

	private ILocalizationClientCache _LocalizationClientCache;

	public CachedLocalizationClient(ILocalizationClient uncachedClient, ILocalizationClientCache localizationCache)
	{
		_LocalizationClient = uncachedClient ?? throw new ArgumentNullException("uncachedClient");
		_LocalizationClientCache = localizationCache ?? throw new ArgumentNullException("localizationCache");
	}

	public GetLanguageFamilyByIdResponse GetLanguageFamilyById(int id)
	{
		if (_LocalizationClientCache.TryGetLanguageFamilyById(id, out var languageFamily))
		{
			return new GetLanguageFamilyByIdResponse
			{
				LanguageFamily = languageFamily
			};
		}
		GetLanguageFamilyByIdResponse languageFamilyById = _LocalizationClient.GetLanguageFamilyById(id);
		_LocalizationClientCache.SaveLanguageFamily(languageFamilyById.LanguageFamily);
		return languageFamilyById;
	}

	public async Task<GetLanguageFamilyByIdResponse> GetLanguageFamilyByIdAsync(int id, CancellationToken cancellationToken)
	{
		if (_LocalizationClientCache.TryGetLanguageFamilyById(id, out var languageFamily))
		{
			return await Task.FromResult(new GetLanguageFamilyByIdResponse
			{
				LanguageFamily = languageFamily
			});
		}
		GetLanguageFamilyByIdResponse getLanguageFamilyByIdResponse = await _LocalizationClient.GetLanguageFamilyByIdAsync(id, cancellationToken);
		_LocalizationClientCache.SaveLanguageFamily(getLanguageFamilyByIdResponse.LanguageFamily);
		return getLanguageFamilyByIdResponse;
	}

	public GetLanguageFamilyByLanguageCodeResponse GetLanguageFamilyByLanguageCode(string languageCode)
	{
		if (_LocalizationClientCache.TryGetLanguageFamilyByLanguageCode(languageCode, out var languageFamily))
		{
			return new GetLanguageFamilyByLanguageCodeResponse
			{
				LanguageFamily = languageFamily
			};
		}
		GetLanguageFamilyByLanguageCodeResponse languageFamilyByLanguageCode = _LocalizationClient.GetLanguageFamilyByLanguageCode(languageCode);
		_LocalizationClientCache.SaveLanguageFamily(languageFamilyByLanguageCode.LanguageFamily);
		return languageFamilyByLanguageCode;
	}

	public async Task<GetLanguageFamilyByLanguageCodeResponse> GetLanguageFamilyByLanguageCodeAsync(string languageCode, CancellationToken cancellationToken)
	{
		if (_LocalizationClientCache.TryGetLanguageFamilyByLanguageCode(languageCode, out var languageFamily))
		{
			return await Task.FromResult(new GetLanguageFamilyByLanguageCodeResponse
			{
				LanguageFamily = languageFamily
			});
		}
		GetLanguageFamilyByLanguageCodeResponse getLanguageFamilyByLanguageCodeResponse = await _LocalizationClient.GetLanguageFamilyByLanguageCodeAsync(languageCode, cancellationToken);
		_LocalizationClientCache.SaveLanguageFamily(getLanguageFamilyByLanguageCodeResponse.LanguageFamily);
		return getLanguageFamilyByLanguageCodeResponse;
	}

	public IEnumerable<SupportedLocale> GetAllSupportedLocales()
	{
		if (_LocalizationClientCache.TryGetAllSupportedLocales(out var allSupportedLocales))
		{
			return allSupportedLocales;
		}
		IEnumerable<SupportedLocale> allSupportedLocales2 = _LocalizationClient.GetAllSupportedLocales();
		_LocalizationClientCache.SaveAllSupportedLocale(allSupportedLocales2);
		return allSupportedLocales2;
	}

	public async Task<IEnumerable<SupportedLocale>> GetAllSupportedLocalesAsync(CancellationToken cancellationToken)
	{
		if (_LocalizationClientCache.TryGetAllSupportedLocales(out var allSupportedLocales))
		{
			return await Task.FromResult(allSupportedLocales);
		}
		IEnumerable<SupportedLocale> enumerable = await _LocalizationClient.GetAllSupportedLocalesAsync(cancellationToken);
		_LocalizationClientCache.SaveAllSupportedLocale(enumerable);
		return enumerable;
	}

	public GetSupportedLocaleByLocaleCodeResponse GetSupportedLocaleByLocaleCode(string code)
	{
		if (_LocalizationClientCache.TryGetSupportedLocaleByLocaleCode(code, out var supportedLocale))
		{
			return new GetSupportedLocaleByLocaleCodeResponse
			{
				SupportedLocale = supportedLocale
			};
		}
		GetSupportedLocaleByLocaleCodeResponse supportedLocaleByLocaleCode = _LocalizationClient.GetSupportedLocaleByLocaleCode(code);
		_LocalizationClientCache.SaveSupportedLocale(supportedLocaleByLocaleCode.SupportedLocale);
		return supportedLocaleByLocaleCode;
	}

	public async Task<GetSupportedLocaleByLocaleCodeResponse> GetSupportedLocaleByLocaleCodeAsync(string code, CancellationToken cancellationToken)
	{
		if (_LocalizationClientCache.TryGetSupportedLocaleByLocaleCode(code, out var supportedLocale))
		{
			return await Task.FromResult(new GetSupportedLocaleByLocaleCodeResponse
			{
				SupportedLocale = supportedLocale
			});
		}
		GetSupportedLocaleByLocaleCodeResponse getSupportedLocaleByLocaleCodeResponse = await _LocalizationClient.GetSupportedLocaleByLocaleCodeAsync(code, cancellationToken);
		_LocalizationClientCache.SaveSupportedLocale(getSupportedLocaleByLocaleCodeResponse.SupportedLocale);
		return getSupportedLocaleByLocaleCodeResponse;
	}

	public GetSupportedLocaleByIdResponse GetSupportedLocaleById(int id)
	{
		if (_LocalizationClientCache.TryGetSupportedLocaleById(id, out var supportedLocale))
		{
			return new GetSupportedLocaleByIdResponse
			{
				SupportedLocale = supportedLocale
			};
		}
		GetSupportedLocaleByIdResponse supportedLocaleById = _LocalizationClient.GetSupportedLocaleById(id);
		_LocalizationClientCache.SaveSupportedLocale(supportedLocaleById.SupportedLocale);
		return supportedLocaleById;
	}

	public async Task<GetSupportedLocaleByIdResponse> GetSupportedLocaleByIdAsync(int id, CancellationToken cancellationToken)
	{
		if (_LocalizationClientCache.TryGetSupportedLocaleById(id, out var supportedLocale))
		{
			return await Task.FromResult(new GetSupportedLocaleByIdResponse
			{
				SupportedLocale = supportedLocale
			});
		}
		GetSupportedLocaleByIdResponse getSupportedLocaleByIdResponse = await _LocalizationClient.GetSupportedLocaleByIdAsync(id, cancellationToken);
		_LocalizationClientCache.SaveSupportedLocale(getSupportedLocaleByIdResponse.SupportedLocale);
		return getSupportedLocaleByIdResponse;
	}

	public GetDefaultSupportedLocaleByLanguageCodeResponse GetDefaultSupportedLocaleByLanguageCode(string languageCode)
	{
		return _LocalizationClient.GetDefaultSupportedLocaleByLanguageCode(languageCode);
	}

	public Task<GetDefaultSupportedLocaleByLanguageCodeResponse> GetDefaultSupportedLocaleByLanguageCodeAsync(string languageCode, CancellationToken cancellationToken)
	{
		return _LocalizationClient.GetDefaultSupportedLocaleByLanguageCodeAsync(languageCode, cancellationToken);
	}

	public GetSupportedLocalesByParentLanguageResponse GetSupportedLocalesByParentLanguage(string languageCode)
	{
		return _LocalizationClient.GetSupportedLocalesByParentLanguage(languageCode);
	}

	public Task<GetSupportedLocalesByParentLanguageResponse> GetSupportedLocalesByParentLanguageAsync(string languageCode, CancellationToken cancellationToken)
	{
		return _LocalizationClient.GetSupportedLocalesByParentLanguageAsync(languageCode, cancellationToken);
	}

	public int RecordDeviceReportedLocale(string rawDeviceReportedLocaleCode)
	{
		if (_LocalizationClientCache.TryGetDeviceReportedLocaleId(rawDeviceReportedLocaleCode, out var deviceReportedLocaleId) && deviceReportedLocaleId.HasValue)
		{
			return deviceReportedLocaleId.Value;
		}
		int num = _LocalizationClient.RecordDeviceReportedLocale(rawDeviceReportedLocaleCode);
		_LocalizationClientCache.SaveDeviceReportedLocaleId(rawDeviceReportedLocaleCode, num);
		return num;
	}

	public async Task<int> RecordDeviceReportedLocaleAsync(string rawDeviceReportedLocaleCode, CancellationToken cancellationToken)
	{
		if (_LocalizationClientCache.TryGetDeviceReportedLocaleId(rawDeviceReportedLocaleCode, out var deviceReportedLocaleId) && deviceReportedLocaleId.HasValue)
		{
			return deviceReportedLocaleId.Value;
		}
		int num = await _LocalizationClient.RecordDeviceReportedLocaleAsync(rawDeviceReportedLocaleCode, cancellationToken);
		_LocalizationClientCache.SaveDeviceReportedLocaleId(rawDeviceReportedLocaleCode, num);
		return num;
	}

	public MapDeviceReportedLocaleToSupportedLocaleResult MapDeviceReportedLocaleToSupportedLocale(int supportedLocaleId, int deviceReportedLocaleId)
	{
		return _LocalizationClient.MapDeviceReportedLocaleToSupportedLocale(supportedLocaleId, deviceReportedLocaleId);
	}

	public async Task<MapDeviceReportedLocaleToSupportedLocaleResult> MapDeviceReportedLocaleToSupportedLocaleAsync(int supportedLocaleId, int deviceReportedLocaleId, CancellationToken cancellationToken)
	{
		return await _LocalizationClient.MapDeviceReportedLocaleToSupportedLocaleAsync(supportedLocaleId, deviceReportedLocaleId, cancellationToken);
	}

	public MapDeviceReportedLocaleToLanguageFamilyResult MapDeviceReportedLocaleToLanguageFamily(int languageFamilyId, int deviceReportedLocaleId)
	{
		return _LocalizationClient.MapDeviceReportedLocaleToLanguageFamily(languageFamilyId, deviceReportedLocaleId);
	}

	public async Task<MapDeviceReportedLocaleToLanguageFamilyResult> MapDeviceReportedLocaleToLanguageFamilyAsync(int languageFamilyId, int deviceReportedLocaleId, CancellationToken cancellationToken)
	{
		return await _LocalizationClient.MapDeviceReportedLocaleToLanguageFamilyAsync(languageFamilyId, deviceReportedLocaleId, cancellationToken);
	}

	public GetDeviceReportedLocaleByIdResponse GetDeviceReportedLocaleById(int id)
	{
		if (_LocalizationClientCache.TryGetDeviceReportedLocaleById(id, out var deviceReportedLocale))
		{
			return new GetDeviceReportedLocaleByIdResponse
			{
				DeviceReportedLocale = deviceReportedLocale
			};
		}
		GetDeviceReportedLocaleByIdResponse deviceReportedLocaleById = _LocalizationClient.GetDeviceReportedLocaleById(id);
		_LocalizationClientCache.SaveDeviceReportedLocaleById(deviceReportedLocaleById.DeviceReportedLocale);
		return deviceReportedLocaleById;
	}

	public async Task<GetDeviceReportedLocaleByIdResponse> GetDeviceReportedLocaleByIdAsync(int id, CancellationToken cancellationToken)
	{
		if (_LocalizationClientCache.TryGetDeviceReportedLocaleById(id, out var deviceReportedLocale))
		{
			return new GetDeviceReportedLocaleByIdResponse
			{
				DeviceReportedLocale = deviceReportedLocale
			};
		}
		GetDeviceReportedLocaleByIdResponse getDeviceReportedLocaleByIdResponse = await _LocalizationClient.GetDeviceReportedLocaleByIdAsync(id, cancellationToken);
		_LocalizationClientCache.SaveDeviceReportedLocaleById(getDeviceReportedLocaleByIdResponse.DeviceReportedLocale);
		return getDeviceReportedLocaleByIdResponse;
	}

	public GetDeviceReportedLocaleByCodeResponse GetDeviceReportedLocaleByCode(string rawLocaleCode)
	{
		if (_LocalizationClientCache.TryGetDeviceReportedLocaleByCode(rawLocaleCode, out var deviceReportedLocale))
		{
			return new GetDeviceReportedLocaleByCodeResponse
			{
				DeviceReportedLocale = deviceReportedLocale
			};
		}
		GetDeviceReportedLocaleByCodeResponse deviceReportedLocaleByCode = _LocalizationClient.GetDeviceReportedLocaleByCode(rawLocaleCode);
		_LocalizationClientCache.SaveDeviceReportedLocaleByCode(rawLocaleCode, deviceReportedLocaleByCode.DeviceReportedLocale);
		return deviceReportedLocaleByCode;
	}

	public async Task<GetDeviceReportedLocaleByCodeResponse> GetDeviceReportedLocaleByCodeAsync(string rawLocaleCode, CancellationToken cancellationToken)
	{
		if (_LocalizationClientCache.TryGetDeviceReportedLocaleByCode(rawLocaleCode, out var deviceReportedLocale))
		{
			return new GetDeviceReportedLocaleByCodeResponse
			{
				DeviceReportedLocale = deviceReportedLocale
			};
		}
		GetDeviceReportedLocaleByCodeResponse getDeviceReportedLocaleByCodeResponse = await _LocalizationClient.GetDeviceReportedLocaleByCodeAsync(rawLocaleCode, cancellationToken);
		_LocalizationClientCache.SaveDeviceReportedLocaleByCode(rawLocaleCode, getDeviceReportedLocaleByCodeResponse.DeviceReportedLocale);
		return getDeviceReportedLocaleByCodeResponse;
	}
}
