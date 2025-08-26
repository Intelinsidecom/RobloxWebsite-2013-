using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Configuration.Client.Properties;
using Roblox.Http;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.RequestContext;

namespace Roblox.Configuration.Client;

public class ConfigurationClient : IConfigurationClient
{
	private readonly Func<string> _ApiKeyGetter;

	public const int MaxPageSize = 200;

	private readonly IServiceRequestSender _ServiceRequestSender;

	private static readonly TimeSpan _DefaultTimeout = TimeSpan.FromSeconds(6.0);

	public ConfigurationClient(Func<string> endpointGetter)
		: this(endpointGetter, () => _DefaultTimeout)
	{
	}

	public ConfigurationClient(Func<string> endpointGetter, Func<string> apiKeyGetter)
		: this(endpointGetter, () => _DefaultTimeout, apiKeyGetter)
	{
		if (apiKeyGetter == null)
		{
			throw new ArgumentNullException("apiKeyGetter");
		}
	}

	public ConfigurationClient(Func<string> endpointGetter, Func<TimeSpan> timeoutGetter)
		: this(StaticCounterRegistry.Instance, new ConfigurationClientSettings(endpointGetter, timeoutGetter), null)
	{
	}

	public ConfigurationClient(Func<string> endpointGetter, Func<TimeSpan> timeoutGetter, Func<string> apiKeyGetter)
		: this(StaticCounterRegistry.Instance, new ConfigurationClientSettings(endpointGetter, timeoutGetter), apiKeyGetter)
	{
		if (apiKeyGetter == null)
		{
			throw new ArgumentNullException("apiKeyGetter");
		}
	}

	internal ConfigurationClient(ICounterRegistry counterRegistry, IServiceClientSettings serviceClientSettings, Func<string> apiKeyGetter)
		: this(CreateHttpClientBuilder(counterRegistry, serviceClientSettings, apiKeyGetter), serviceClientSettings, apiKeyGetter)
	{
	}

	internal ConfigurationClient(IHttpClientBuilder httpClientBuilder, IServiceClientSettings serviceClientSettings, Func<string> apiKeyGetter)
	{
		if (httpClientBuilder == null)
		{
			throw new ArgumentNullException("httpClientBuilder");
		}
		if (serviceClientSettings == null)
		{
			throw new ArgumentNullException("serviceClientSettings");
		}
		_ApiKeyGetter = apiKeyGetter;
		IHttpClient httpClient = httpClientBuilder.Build();
		HttpRequestBuilder httpRequestBuilder = new HttpRequestBuilder(serviceClientSettings.Endpoint);
		_ServiceRequestSender = new ServiceRequestSender(httpClient, httpRequestBuilder);
	}

	public bool SettingUpdatesAreAvailable(string groupName, DateTime lastModificationDateTime)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("lastModificationDateTime", lastModificationDateTime.ToString("o"))
		};
		return Get<bool>("/v1/SettingUpdatesAreAvailable", parameters);
	}

	public Task<bool> SettingUpdatesAreAvailableAsync(string groupName, DateTime lastModificationDateTime, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("lastModificationDateTime", lastModificationDateTime.ToString("o"))
		};
		return GetAsync<bool>("/v1/SettingUpdatesAreAvailable", cancellationToken, parameters);
	}

	public bool ConnectionStringUpdatesAreAvailable(string groupName, DateTime lastModificationDateTime)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("lastModificationDateTime", lastModificationDateTime.ToString("o"))
		};
		return Get<bool>("/v1/ConnectionStringUpdatesAreAvailable", parameters);
	}

	public Task<bool> ConnectionStringUpdatesAreAvailableAsync(string groupName, DateTime lastModificationDateTime, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("lastModificationDateTime", lastModificationDateTime.ToString("o"))
		};
		return GetAsync<bool>("/v1/ConnectionStringUpdatesAreAvailable", cancellationToken, parameters);
	}

	public Setting GetSetting(int id)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("id", id)
		};
		return Get<Setting>("/v1/GetSettingById", parameters);
	}

	public Task<Setting> GetSettingAsync(int id, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("id", id)
		};
		return GetAsync<Setting>("/v1/GetSettingById", cancellationToken, parameters);
	}

	public Setting GetSetting(string groupName, string settingName)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("settingName", settingName)
		};
		return Get<Setting>("/v1/GetSetting", parameters);
	}

	public Task<Setting> GetSettingAsync(string groupName, string settingName, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("settingName", settingName)
		};
		return GetAsync<Setting>("/v1/GetSetting", cancellationToken, parameters);
	}

	public ConnectionString GetConnectionString(int id)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("id", id)
		};
		return Get<ConnectionString>("/v1/GetConnectionStringById", parameters);
	}

	public Task<ConnectionString> GetConnectionStringAsync(int id, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("id", id)
		};
		return GetAsync<ConnectionString>("/v1/GetConnectionStringById", cancellationToken, parameters);
	}

	public ConnectionString GetConnectionString(string groupName, string connectionStringName)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("connectionStringName", connectionStringName)
		};
		return Get<ConnectionString>("/v1/GetConnectionString", parameters);
	}

	public Task<ConnectionString> GetConnectionStringAsync(string groupName, string connectionStringName, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("connectionStringName", connectionStringName)
		};
		return GetAsync<ConnectionString>("/v1/GetConnectionString", cancellationToken, parameters);
	}

	public IReadOnlyCollection<Setting> GetSettings(string groupName, int pageSize, int page)
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return Get<IReadOnlyCollection<Setting>>("/v1/GetSettings", parameters);
	}

	public Task<IReadOnlyCollection<Setting>> GetSettingsAsync(string groupName, int pageSize, int page, CancellationToken cancellationToken)
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return GetAsync<IReadOnlyCollection<Setting>>("/v1/GetSettings", cancellationToken, parameters);
	}

	public IReadOnlyCollection<ConnectionString> GetConnectionStrings(string groupName, int pageSize, int page)
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return Get<IReadOnlyCollection<ConnectionString>>("/v1/GetConnectionStrings", parameters);
	}

	public Task<IReadOnlyCollection<ConnectionString>> GetConnectionStringsAsync(string groupName, int pageSize, int page, CancellationToken cancellationToken)
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return GetAsync<IReadOnlyCollection<ConnectionString>>("/v1/GetConnectionStrings", cancellationToken, parameters);
	}

	public IReadOnlyCollection<ConnectionString> GetAllConnectionStrings(int pageSize, int page)
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return Get<IReadOnlyCollection<ConnectionString>>("/v1/GetAllConnectionStrings", parameters);
	}

	public Task<IReadOnlyCollection<ConnectionString>> GetAllConnectionStringsAsync(int pageSize, int page, CancellationToken cancellationToken)
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return GetAsync<IReadOnlyCollection<ConnectionString>>("/v1/GetAllConnectionStrings", cancellationToken, parameters);
	}

	public IReadOnlyCollection<string> GetSettingGroupNames(int pageSize, int page)
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return Get<IReadOnlyCollection<string>>("/v1/GetSettingGroupNames", parameters);
	}

	public Task<IReadOnlyCollection<string>> GetSettingGroupNamesAsync(int pageSize, int page, CancellationToken cancellationToken)
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return GetAsync<IReadOnlyCollection<string>>("/v1/GetSettingGroupNames", cancellationToken, parameters);
	}

	public IReadOnlyCollection<Setting> GetSettingsByPartialName(string partialName, int pageSize, int page, string groupName = null)
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("partialName", partialName),
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		if (!string.IsNullOrEmpty(groupName))
		{
			list.Add(new KeyValuePair<string, object>("groupName", groupName));
		}
		return Get<IReadOnlyCollection<Setting>>("/v1/GetSettingsByPartialName", list);
	}

	public Task<IReadOnlyCollection<Setting>> GetSettingsByPartialNameAsync(string partialName, int pageSize, int page, string groupName = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (pageSize > 200)
		{
			throw new ArgumentException($"pageSize must not exceed {200}", "pageSize");
		}
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("partialName", partialName),
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		if (!string.IsNullOrEmpty(groupName))
		{
			list.Add(new KeyValuePair<string, object>("groupName", groupName));
		}
		return GetAsync<IReadOnlyCollection<Setting>>("/v1/GetSettingsByPartialName", cancellationToken, list);
	}

	public IReadOnlyCollection<Setting> GetAllSettings(int exclusiveStartSettingId, int count)
	{
		List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("exclusiveStartSettingID", exclusiveStartSettingId),
			new KeyValuePair<string, object>("count", count)
		};
		return Get<IReadOnlyCollection<Setting>>("/v1/GetAllSettings", parameters);
	}

	public IReadOnlyCollection<Setting> GetAllSettingsByGroupName(string groupName)
	{
		VerifyApiKeyUsage("GetAllSettingsByGroupName");
		return _ServiceRequestSender.SendPostRequest<Payload<string>, IReadOnlyCollection<Setting>>("/v1/GetAllSettingsByGroupName", new Payload<string>
		{
			Data = groupName
		});
	}

	public LoadSettingsByGroupNameResult LoadSettingsByGroupName(string groupName, DateTime lastModified)
	{
		return _ServiceRequestSender.SendPostRequest<LoadSettingsByGroupNameRequest, LoadSettingsByGroupNameResult>("/v1/LoadSettingsByGroupName", new LoadSettingsByGroupNameRequest
		{
			GroupName = groupName,
			LastModified = lastModified
		});
	}

	public void CreateSettingV2(string groupName, string settingName, string type, string value, string comment, SettingFlags settingFlags, int priority, SettingConditions conditions)
	{
		VerifyApiKeyUsage("CreateSettingV2");
		((IHttpRequestSender)_ServiceRequestSender).SendRequestWithJsonBody(HttpMethod.Post, "/v1/CreateSettingV2", new CreateSettingRequest
		{
			GroupName = groupName,
			Name = settingName,
			Type = type,
			Value = value,
			Comment = comment,
			Flags = settingFlags,
			Conditions = conditions,
			Priority = priority
		}, (IEnumerable<(string Key, string Value)>)null);
	}

	public void UpdateSetting(int id, string value, string comment, SettingFlags settingFlags, int priority, SettingConditions conditions, DateTime lastModified)
	{
		VerifyApiKeyUsage("UpdateSetting");
		((IHttpRequestSender)_ServiceRequestSender).SendRequestWithJsonBody(HttpMethod.Post, "/v1/UpdateSetting", new UpdateSettingRequest
		{
			Id = id,
			Value = value,
			Comment = comment,
			Flags = settingFlags,
			Conditions = conditions,
			Priority = priority,
			LastModified = lastModified
		}, (IEnumerable<(string Key, string Value)>)null);
	}

	public void MaskSetting(int id)
	{
		VerifyApiKeyUsage("MaskSetting");
		((IHttpRequestSender)_ServiceRequestSender).SendRequestWithJsonBody(HttpMethod.Post, "/v1/MaskSetting", new Payload<int>
		{
			Data = id
		}, (IEnumerable<(string Key, string Value)>)null);
	}

	public void UnmaskSetting(int id)
	{
		VerifyApiKeyUsage("UnmaskSetting");
		((IHttpRequestSender)_ServiceRequestSender).SendRequestWithJsonBody(HttpMethod.Post, "/v1/UnmaskSetting", new Payload<int>
		{
			Data = id
		}, (IEnumerable<(string Key, string Value)>)null);
	}

	public void CreateSetting(Setting setting)
	{
		CreateSetting(setting.GroupName, setting.Name, setting.Type, setting.Value, setting.Comment, setting.IsEnvironmentSpecific, setting.IsMasked, setting.IsValueSameForAllTestEnvironments, setting.IsValueUniqueForProduction);
	}

	public Task CreateSettingAsync(Setting setting, CancellationToken cancellationToken)
	{
		return CreateSettingAsync(setting.GroupName, setting.Name, setting.Type, setting.Value, setting.Comment, setting.IsEnvironmentSpecific, setting.IsMasked, setting.IsValueSameForAllTestEnvironments, setting.IsValueUniqueForProduction, cancellationToken);
	}

	public void CreateSetting(string groupName, string settingName, string type, string value, string comment, bool isEnvironmentSpecific, bool isMasked, bool isValueSameForAllTestEnvironments, bool isValueUniqueForProduction)
	{
		List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("settingName", settingName),
			new KeyValuePair<string, object>("type", type),
			new KeyValuePair<string, object>("value", value),
			new KeyValuePair<string, object>("comment", comment ?? string.Empty),
			new KeyValuePair<string, object>("isEnvironmentSpecific", isEnvironmentSpecific),
			new KeyValuePair<string, object>("isMasked", isMasked),
			new KeyValuePair<string, object>("isValueSameForAllTestEnvironments", isValueSameForAllTestEnvironments),
			new KeyValuePair<string, object>("isValueUniqueForProduction", isValueUniqueForProduction)
		};
		Post("/v1/CreateSetting", parameters);
	}

	public Task CreateSettingAsync(string groupName, string settingName, string type, string value, string comment, bool isEnvironmentSpecific, bool isMasked, bool isValueSameForAllTestEnvironments, bool isValueUniqueForProduction, CancellationToken cancellationToken)
	{
		List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("settingName", settingName),
			new KeyValuePair<string, object>("type", type),
			new KeyValuePair<string, object>("value", value),
			new KeyValuePair<string, object>("comment", comment ?? string.Empty),
			new KeyValuePair<string, object>("isEnvironmentSpecific", isEnvironmentSpecific),
			new KeyValuePair<string, object>("isMasked", isMasked),
			new KeyValuePair<string, object>("isValueSameForAllTestEnvironments", isValueSameForAllTestEnvironments),
			new KeyValuePair<string, object>("isValueUniqueForProduction", isValueUniqueForProduction)
		};
		return PostAsync("/v1/CreateSetting", cancellationToken, parameters);
	}

	public void CreateConnectionString(ConnectionString connectionString)
	{
		CreateConnectionString(connectionString.GroupName, connectionString.Name, connectionString.Value);
	}

	public Task CreateConnectionStringAsync(ConnectionString connectionString, CancellationToken cancellationToken)
	{
		return CreateConnectionStringAsync(connectionString.GroupName, connectionString.Name, connectionString.Value, cancellationToken);
	}

	public void CreateConnectionString(string groupName, string connectionStringName, string value)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("connectionStringName", connectionStringName),
			new KeyValuePair<string, object>("value", value)
		};
		Post("/v1/CreateConnectionString", parameters);
	}

	public Task CreateConnectionStringAsync(string groupName, string connectionStringName, string value, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("connectionStringName", connectionStringName),
			new KeyValuePair<string, object>("value", value)
		};
		return PostAsync("/v1/CreateConnectionString", cancellationToken, parameters);
	}

	public void SetSetting(Setting setting)
	{
		SetSetting(setting.GroupName, setting.Name, setting.Type, setting.Value, setting.Comment, setting.IsEnvironmentSpecific, setting.IsMasked, setting.IsValueSameForAllTestEnvironments, setting.IsValueUniqueForProduction);
	}

	public Task SetSettingAsync(Setting setting, CancellationToken cancellationToken)
	{
		return SetSettingAsync(setting.GroupName, setting.Name, setting.Type, setting.Value, setting.Comment, setting.IsEnvironmentSpecific, setting.IsMasked, setting.IsValueSameForAllTestEnvironments, setting.IsValueUniqueForProduction, cancellationToken);
	}

	public void SetSetting(string groupName, string settingName, string type, string value, string comment, bool isEnvironmentSpecific, bool isMasked, bool isValueSameForAllTestEnvironments, bool isValueUniqueForProduction)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("settingName", settingName),
			new KeyValuePair<string, object>("type", type),
			new KeyValuePair<string, object>("value", value),
			new KeyValuePair<string, object>("isEnvironmentSpecific", isEnvironmentSpecific),
			new KeyValuePair<string, object>("isMasked", isMasked),
			new KeyValuePair<string, object>("isValueSameForAllTestEnvironments", isValueSameForAllTestEnvironments),
			new KeyValuePair<string, object>("isValueUniqueForProduction", isValueUniqueForProduction)
		};
		if (comment != null)
		{
			KeyValuePair<string, object> item = new KeyValuePair<string, object>("comment", comment);
			list.Add(item);
		}
		Post("/v1/SetSetting", list);
	}

	public Task SetSettingAsync(string groupName, string settingName, string type, string value, string comment, bool isEnvironmentSpecific, bool isMasked, bool isValueSameForAllTestEnvironments, bool isValueUniqueForProduction, CancellationToken cancellationToken)
	{
		List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("settingName", settingName),
			new KeyValuePair<string, object>("type", type),
			new KeyValuePair<string, object>("value", value),
			new KeyValuePair<string, object>("comment", comment),
			new KeyValuePair<string, object>("isEnvironmentSpecific", isEnvironmentSpecific),
			new KeyValuePair<string, object>("isMasked", isMasked),
			new KeyValuePair<string, object>("isValueSameForAllTestEnvironments", isValueSameForAllTestEnvironments),
			new KeyValuePair<string, object>("isValueUniqueForProduction", isValueUniqueForProduction)
		};
		return PostAsync("/v1/SetSetting", cancellationToken, parameters);
	}

	public void SetConnectionString(ConnectionString connectionString)
	{
		SetConnectionString(connectionString.GroupName, connectionString.Name, connectionString.Value);
	}

	public Task SetConnectionStringAsync(ConnectionString connectionString, CancellationToken cancellationToken)
	{
		return SetConnectionStringAsync(connectionString.GroupName, connectionString.Name, connectionString.Value, cancellationToken);
	}

	public void SetConnectionString(string groupName, string connectionStringName, string value)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("connectionStringName", connectionStringName),
			new KeyValuePair<string, object>("value", value)
		};
		Post("/v1/SetConnectionString", parameters);
	}

	public Task SetConnectionStringAsync(string groupName, string connectionStringName, string value, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("connectionStringName", connectionStringName),
			new KeyValuePair<string, object>("value", value)
		};
		return PostAsync("/v1/SetConnectionString", cancellationToken, parameters);
	}

	public void DeleteSetting(int id)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("id", id)
		};
		Post("/v1/DeleteSetting", parameters);
	}

	public Task DeleteSettingAsync(int id, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("id", id)
		};
		return PostAsync("/v1/DeleteSetting", cancellationToken, parameters);
	}

	public void DeleteConnectionString(int id)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("id", id)
		};
		Post("/v1/DeleteConnectionString", parameters);
	}

	public Task DeleteConnectionStringAsync(int id, CancellationToken cancellationToken)
	{
		KeyValuePair<string, object>[] parameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("id", id)
		};
		return PostAsync("/v1/DeleteConnectionString", cancellationToken, parameters);
	}

	private T Get<T>(string path, IEnumerable<KeyValuePair<string, object>> parameters)
	{
		try
		{
			return ((IHttpRequestSender)_ServiceRequestSender).SendRequest<Payload<T>>(HttpMethod.Get, path, TranslateParameters(parameters)).Data;
		}
		catch (Exception exception)
		{
			throw TranslateException(exception);
		}
	}

	private void Post(string path, IEnumerable<KeyValuePair<string, object>> parameters)
	{
		try
		{
			((IHttpRequestSender)_ServiceRequestSender).SendRequest(HttpMethod.Post, path, TranslateParameters(parameters));
		}
		catch (Exception exception)
		{
			throw TranslateException(exception);
		}
	}

	private async Task<T> GetAsync<T>(string path, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> parameters)
	{
		try
		{
			IServiceRequestSender serviceRequestSender = _ServiceRequestSender;
			IEnumerable<(string, string)> queryStringParameters = TranslateParameters(parameters);
			return (await ((IHttpRequestSender)serviceRequestSender).SendRequestAsync<Payload<T>>(HttpMethod.Get, path, cancellationToken, queryStringParameters).ConfigureAwait(continueOnCapturedContext: false)).Data;
		}
		catch (Exception exception)
		{
			throw TranslateException(exception);
		}
	}

	private async Task PostAsync(string path, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> parameters)
	{
		try
		{
			IServiceRequestSender serviceRequestSender = _ServiceRequestSender;
			IEnumerable<(string, string)> queryStringParameters = TranslateParameters(parameters);
			await ((IHttpRequestSender)serviceRequestSender).SendRequestAsync(HttpMethod.Post, path, cancellationToken, queryStringParameters).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception exception)
		{
			throw TranslateException(exception);
		}
	}

	private IEnumerable<(string Key, string Value)> TranslateParameters(IEnumerable<KeyValuePair<string, object>> parameters)
	{
		return parameters.Select((KeyValuePair<string, object> kvp) => (kvp.Key, $"{kvp.Value}"));
	}

	private Exception TranslateException(Exception exception)
	{
		ConfigurationServiceErrorResponse configurationServiceErrorResponse = null;
		if (exception is HttpRequestFailedException ex)
		{
			IHttpResponse response = ex.Response;
			if (response != null && response.StatusCode == HttpStatusCode.BadRequest)
			{
				try
				{
					configurationServiceErrorResponse = ex.Response.GetJsonBody<ConfigurationServiceErrorResponse>();
				}
				catch
				{
				}
			}
		}
		if (configurationServiceErrorResponse != null)
		{
			throw new ConfigurationClientException(configurationServiceErrorResponse.Message, exception);
		}
		throw exception;
	}

	private void VerifyApiKeyUsage(string methodName)
	{
		if (_ApiKeyGetter == null)
		{
			throw new ConfigurationClientException("To use " + methodName + " you must have an API key passed in the ConfigurationClient constructor.", null);
		}
	}

	private static IHttpClientBuilder CreateHttpClientBuilder(ICounterRegistry counterRegistry, IServiceClientSettings serviceClientSettings, Func<string> apiKeyGetter)
	{
		if (apiKeyGetter == null)
		{
			apiKeyGetter = () => null;
		}
		var builder = new Roblox.Http.ServiceClient.HttpClientBuilder(serviceClientSettings, counterRegistry, apiKeyGetter, (CookieContainer)null, (IRequestContextLoader)null);
		builder.ApiKeyViaHeaderEnabled = () => true;
		return builder;
	}
}
