using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Roblox.ApiClientBase;
using Roblox.Configuration;
using Roblox.EphemeralCounters.Client.Properties;
using Roblox.Instrumentation;

namespace Roblox.EphemeralCounters.Client;

public class EphemeralCountersClient : GuardedApiClientBase
{
	private readonly Func<string> _ApiKeyGetter;

	private readonly Func<string> _ServiceUrlGetter;

	public override string Name => "EphemeralCountersClient";

	protected override string ApiKey => _ApiKeyGetter();

	protected override string Endpoint => _ServiceUrlGetter();

	protected override TimeSpan Timeout => Settings.Default.EphemeralCountersClientTimeout;

	public EphemeralCountersClient(Func<string> apiKeyGetter)
		: this(apiKeyGetter, DefaultServiceUrlGetter, StaticCounterRegistry.Instance)
	{
	}

	public EphemeralCountersClient(Func<string> apiKeyGetter, ICounterRegistry counterRegistry)
		: this(apiKeyGetter, DefaultServiceUrlGetter, counterRegistry)
	{
	}

	public EphemeralCountersClient(Func<string> apiKeyGetter, Func<string> serviceUrlGetter)
		: this(apiKeyGetter, serviceUrlGetter, StaticCounterRegistry.Instance)
	{
	}

	public EphemeralCountersClient(Func<string> apiKeyGetter, Func<string> serviceUrlGetter, ICounterRegistry counterRegistry)
		: base(counterRegistry)
	{
		_ApiKeyGetter = apiKeyGetter;
		_ServiceUrlGetter = serviceUrlGetter;
	}

	public void AddToSequence(string sequenceName, double value, bool isBufferedWrite = true)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("sequenceName", sequenceName),
			new KeyValuePair<string, object>("value", value),
			new KeyValuePair<string, object>("isBufferedWrite", isBufferedWrite)
		};
		Post("/v1.0/SequenceStatistics/AddToSequence", queryStringParameters);
	}

	public void BatchAddToSequences(IDictionary<string, double> entries, bool isBufferedWrite = true)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("isBufferedWrite", isBufferedWrite)
		};
		string jsonPostData = JsonConvert.SerializeObject(entries);
		PostJson("/v1.0/SequenceStatistics/BatchAddToSequences", queryStringParameters, null, jsonPostData);
	}

	public IDictionary<string, double> GetSequenceStatistics(string sequenceName)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("sequenceName", sequenceName)
		};
		return Get<IDictionary<string, double>>("/v1.0/SequenceStatistics/GetSequenceStatistics", queryStringParameters);
	}

	public IDictionary<string, double> FlushSequenceStatistics(string sequenceName)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("sequenceName", sequenceName)
		};
		return Post<IDictionary<string, double>>("/v1.0/SequenceStatistics/FlushSequenceStatistics", queryStringParameters);
	}

	public void Decrement(string counterName, int amount = 1, bool isBufferedWrite = true)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("counterName", counterName),
			new KeyValuePair<string, object>("amount", amount),
			new KeyValuePair<string, object>("isBufferedWrite", isBufferedWrite)
		};
		Post("/v1.1/Counters/Decrement", queryStringParameters);
	}

	public void Delete(string counterName)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("counterName", counterName)
		};
		Post("/v1.1/Counters/Delete", queryStringParameters);
	}

	public long Flush(string counterName)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("counterName", counterName)
		};
		return Post<long>("/v1.1/Counters/Flush", queryStringParameters);
	}

	public IDictionary<string, long> BatchFlush(IEnumerable<string> counterNames)
	{
		string jsonPostData = JsonConvert.SerializeObject(counterNames);
		return PostJson<IDictionary<string, long>>("/v1.1/Counters/BatchFlush", null, null, jsonPostData);
	}

	public long Get(string counterName)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("counterName", counterName)
		};
		return Get<long>("/v1.1/Counters/Get", queryStringParameters);
	}

	public void Increment(string counterName, int amount = 1, bool isBufferedWrite = true)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[3]
		{
			new KeyValuePair<string, object>("counterName", counterName),
			new KeyValuePair<string, object>("amount", amount),
			new KeyValuePair<string, object>("isBufferedWrite", isBufferedWrite)
		};
		Post("/v1.1/Counters/Increment", queryStringParameters);
	}

	public void MultiIncrement(IEnumerable<string> counterNames, bool isBufferedWrite = true)
	{
		string value = string.Join(",", counterNames);
		KeyValuePair<string, object>[] formParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("counterNamesCsv", value)
		};
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("isBufferedWrite", isBufferedWrite)
		};
		Post("/v1.0/MultiIncrement", queryStringParameters, formParameters);
	}

	public void BatchIncrement(IDictionary<string, long> entries, bool isBufferedWrite = true)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("isBufferedWrite", isBufferedWrite)
		};
		string jsonPostData = JsonConvert.SerializeObject(entries);
		PostJson("/v1.1/Counters/BatchIncrement", queryStringParameters, null, jsonPostData);
	}

	private static string DefaultServiceUrlGetter()
	{
		return RobloxEnvironment.GetApiEndpoint("ephemeralcounters");
	}
}
