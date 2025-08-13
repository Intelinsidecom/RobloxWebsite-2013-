using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Roblox.Configuration;

internal class ConfigurationServiceProvider
{
	private readonly string _Endpoint;

	public ConfigurationServiceProvider(string endpoint)
	{
		_Endpoint = endpoint;
	}

	public bool SettingUpdatesAreAvailable(string groupName, DateTime lastModificationDateTime)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("lastModificationDateTime", lastModificationDateTime)
		};
		return Get<bool>("/v1/SettingUpdatesAreAvailable", queryStringParameters);
	}

	public bool ConnectionStringUpdatesAreAvailable(string groupName, DateTime lastModificationDateTime)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("lastModificationDateTime", lastModificationDateTime)
		};
		return Get<bool>("/v1/ConnectionStringUpdatesAreAvailable", queryStringParameters);
	}

	public IReadOnlyCollection<ISetting> GetSettings(string groupName, int pageSize, int page)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return Get<IReadOnlyCollection<Setting>>("/v1/GetSettings", queryStringParameters);
	}

	public IReadOnlyCollection<IConnectionString> GetConnectionStrings(string groupName, int pageSize, int page)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("pageSize", pageSize),
			new KeyValuePair<string, object>("page", page)
		};
		return Get<IReadOnlyCollection<ConnectionString>>("/v1/GetConnectionStrings", queryStringParameters);
	}

	public void SetProperty(string groupName, string name, string type, string value, DateTime updated)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[5]
		{
			new KeyValuePair<string, object>("groupName", groupName),
			new KeyValuePair<string, object>("name", name),
			new KeyValuePair<string, object>("type", type),
			new KeyValuePair<string, object>("value", value),
			new KeyValuePair<string, object>("updated", updated)
		};
		Post("/v1/SetProperty", queryStringParameters);
	}

	private void Post(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null)
	{
		ExecuteHttpRequest(actionPath, queryStringParameters, isPost: true);
	}

	private T Get<T>(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null)
	{
		return GetPayloadData<T>(ExecuteHttpRequest(actionPath, queryStringParameters));
	}

	private string ExecuteHttpRequest(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, bool isPost = false)
	{
		string requestUrl = BuildUrl(actionPath, queryStringParameters);
		using WebClient webClient = new WebClient();
		return isPost ? DoPost(webClient, requestUrl) : DoGet(webClient, requestUrl);
	}

	private string BuildUrl(string actionPath, IEnumerable<KeyValuePair<string, object>> queryStringParameters)
	{
		string text = _Endpoint + actionPath;
		StringBuilder stringBuilder = null;
		if (queryStringParameters != null)
		{
			bool flag = true;
			foreach (KeyValuePair<string, string> item in PrepareQueryStringParameters(queryStringParameters))
			{
				if (flag)
				{
					stringBuilder = new StringBuilder("?");
					flag = false;
				}
				else
				{
					stringBuilder.Append("&");
				}
				stringBuilder.Append(item.Key);
				stringBuilder.Append('=');
				stringBuilder.Append(item.Value);
			}
		}
		if (stringBuilder == null)
		{
			return text;
		}
		string text2 = stringBuilder.ToString();
		return text + text2;
	}

	private static IEnumerable<KeyValuePair<string, string>> PrepareQueryStringParameters(IEnumerable<KeyValuePair<string, object>> parameters)
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		foreach (KeyValuePair<string, object> parameter in parameters)
		{
			object value = parameter.Value;
			string key = parameter.Key;
			IEnumerable enumerable = ((value is string) ? null : (value as IEnumerable));
			if (enumerable != null)
			{
				foreach (object? item in enumerable)
				{
					string value2 = ((item != null) ? WebUtility.UrlEncode(item.ToString()) : string.Empty);
					list.Add(new KeyValuePair<string, string>(key, value2));
				}
			}
			else
			{
				string value3 = string.Empty;
				if (value != null)
				{
					value3 = WebUtility.UrlEncode((value as DateTime?)?.ToString("o") ?? value.ToString());
				}
				list.Add(new KeyValuePair<string, string>(key, value3));
			}
		}
		return list;
	}

	private static string DoPost(WebClient webClient, string requestUrl)
	{
		byte[] bytes = webClient.Encoding.GetBytes(string.Empty);
		byte[] bytes2 = webClient.UploadData(requestUrl, "POST", bytes);
		return Encoding.UTF8.GetString(bytes2);
	}

	private static string DoGet(WebClient webClient, string requestUrl)
	{
		byte[] bytes = webClient.DownloadData(requestUrl);
		return Encoding.UTF8.GetString(bytes);
	}

	private static T GetPayloadData<T>(string responseString)
	{
		return JsonConvert.DeserializeObject<Payload<T>>(responseString).Data;
	}
}
