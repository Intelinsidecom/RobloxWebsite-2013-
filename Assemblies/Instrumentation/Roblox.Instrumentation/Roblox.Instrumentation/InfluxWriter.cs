using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Roblox.Instrumentation;

internal class InfluxWriter
{
	private readonly Action<Exception> _ExceptionHandler;

	internal InfluxWriter(Action<Exception> exceptionHandler)
	{
		_ExceptionHandler = exceptionHandler ?? throw new ArgumentException("exceptionHandler");
	}

	public void Persist(ICollectionConfiguration configuration, IReadOnlyCollection<KeyValuePair<CounterKey, double>> datapoints)
	{
		if (datapoints.Count == 0)
		{
			return;
		}
		Dictionary<string, List<KeyValuePair<CounterKey, double>>> dictionary = GroupByEndpoint(configuration, datapoints);
		try
		{
			foreach (KeyValuePair<string, List<KeyValuePair<CounterKey, double>>> item in dictionary)
			{
				string key = item.Key;
				List<KeyValuePair<CounterKey, double>> value = item.Value;
				StringBuilder stringBuilder = new StringBuilder();
				foreach (KeyValuePair<CounterKey, double> item2 in value)
				{
					CounterKey key2 = item2.Key;
					stringBuilder.Append("perfmon,machine=");
					stringBuilder.Append(EscapeTagName(configuration.HostIdentifier));
					stringBuilder.Append(",category=");
					stringBuilder.Append(EscapeTagName(key2.Category));
					stringBuilder.Append(",counter=");
					stringBuilder.Append(EscapeTagName(key2.Name));
					if (!string.IsNullOrWhiteSpace(key2.Instance))
					{
						stringBuilder.Append(",instance=");
						stringBuilder.Append(EscapeTagName(key2.Instance));
					}
					if (!string.IsNullOrWhiteSpace(configuration.FarmIdentifier))
					{
						stringBuilder.Append(",farm=");
						stringBuilder.Append(EscapeTagName(configuration.FarmIdentifier));
					}
					if (!string.IsNullOrWhiteSpace(configuration.SuperFarmIdentifier))
					{
						stringBuilder.Append(",superFarm=");
						stringBuilder.Append(EscapeTagName(configuration.SuperFarmIdentifier));
					}
					stringBuilder.Append(" value=");
					stringBuilder.Append(item2.Value);
					stringBuilder.Append('\n');
				}
				string data = stringBuilder.ToString();
				try
				{
					string address = key + "/write?db=" + configuration.InfluxDatabaseName + "&precision=s";
					using ExtendedWebClient extendedWebClient = new ExtendedWebClient();
					extendedWebClient.UploadStringGzipped(address, data, configuration.InfluxCredentials?.Username, configuration.InfluxCredentials?.Password);
				}
				catch (WebException webException)
				{
					Exception obj = CreateDetailedException(webException, key);
					_ExceptionHandler(obj);
				}
				catch (Exception obj2)
				{
					_ExceptionHandler(obj2);
				}
			}
		}
		catch (Exception obj3)
		{
			try
			{
				_ExceptionHandler(obj3);
			}
			catch
			{
			}
		}
	}

	internal Dictionary<string, List<KeyValuePair<CounterKey, double>>> GroupByEndpoint(ICollectionConfiguration configuration, IEnumerable<KeyValuePair<CounterKey, double>> datapoints)
	{
		Dictionary<string, List<KeyValuePair<CounterKey, double>>> dictionary = new Dictionary<string, List<KeyValuePair<CounterKey, double>>>();
		foreach (KeyValuePair<CounterKey, double> datapoint in datapoints)
		{
			foreach (string item in configuration.GetInfluxEndpointsForCategory(datapoint.Key.Category))
			{
				if (!dictionary.TryGetValue(item, out var value))
				{
					value = (dictionary[item] = new List<KeyValuePair<CounterKey, double>>());
				}
				value.Add(datapoint);
			}
		}
		return dictionary;
	}

	private static Exception CreateDetailedException(WebException webException, string baseUrl)
	{
		try
		{
			string arg = null;
			Stream stream = webException.Response?.GetResponseStream();
			if (stream != null)
			{
				using StreamReader streamReader = new StreamReader(stream);
				arg = streamReader.ReadToEnd();
			}
			return new Exception($"Failed to write to InfluxDB server {baseUrl}. Response body = {arg}. Status = {webException.Status}", webException);
		}
		catch
		{
			return webException;
		}
	}

	private static string EscapeTagName(string stringToEscape)
	{
		stringToEscape = stringToEscape.Replace(" ", "\\ ");
		stringToEscape = stringToEscape.Replace(",", "\\,");
		stringToEscape = stringToEscape.Replace("=", "\\=");
		return stringToEscape;
	}
}
