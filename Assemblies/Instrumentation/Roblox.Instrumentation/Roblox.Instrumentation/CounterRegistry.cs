using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Roblox.Instrumentation;

public class CounterRegistry : ICounterRegistry
{
	private static readonly byte[] _DefaultPercentiles = new byte[9] { 1, 5, 10, 25, 50, 75, 90, 95, 99 };

	private readonly ConcurrentDictionary<CounterKey, RateOfCountsPerSecondCounter> _RateOfCountsPerSecondCounters = new ConcurrentDictionary<CounterKey, RateOfCountsPerSecondCounter>();

	private readonly ConcurrentDictionary<CounterKey, AverageValueCounter> _AverageValueCounters = new ConcurrentDictionary<CounterKey, AverageValueCounter>();

	private readonly ConcurrentDictionary<CounterKey, MaximumValueCounter> _MaximumValueCounters = new ConcurrentDictionary<CounterKey, MaximumValueCounter>();

	private readonly ConcurrentDictionary<CounterKey, FractionCounter> _FractionCounters = new ConcurrentDictionary<CounterKey, FractionCounter>();

	private readonly ConcurrentDictionary<CounterKey, RawValueCounter> _RawValueCounters = new ConcurrentDictionary<CounterKey, RawValueCounter>();

	private readonly ConcurrentDictionary<string, PercentileCounter> _PercentileCounters = new ConcurrentDictionary<string, PercentileCounter>();

	public IRateOfCountsPerSecondCounter GetRateOfCountsPerSecondCounter(string category, string name, string instance = null)
	{
		CounterKey key2 = new CounterKey(category, name, instance);
		return _RateOfCountsPerSecondCounters.GetOrAdd(key2, (CounterKey key) => new RateOfCountsPerSecondCounter(category, name, instance));
	}

	public IAverageValueCounter GetAverageValueCounter(string category, string name, string instance = null)
	{
		CounterKey key2 = new CounterKey(category, name, instance);
		return _AverageValueCounters.GetOrAdd(key2, (CounterKey key) => new AverageValueCounter(category, name, instance));
	}

	public IMaximumValueCounter GetMaximumValueCounter(string category, string name, string instance = null)
	{
		CounterKey key2 = new CounterKey(category, name, instance);
		return _MaximumValueCounters.GetOrAdd(key2, (CounterKey key) => new MaximumValueCounter(category, name, instance));
	}

	public IRawValueCounter GetRawValueCounter(string category, string name, string instance = null)
	{
		CounterKey key2 = new CounterKey(category, name, instance);
		return _RawValueCounters.GetOrAdd(key2, (CounterKey key) => new RawValueCounter(category, name, instance));
	}

	public IFractionCounter GetFractionCounter(string category, string name, string instance = null)
	{
		CounterKey key2 = new CounterKey(category, name, instance);
		return _FractionCounters.GetOrAdd(key2, (CounterKey key) => new FractionCounter(category, name, instance));
	}

	public IPercentileCounter GetPercentileCounter(string category, string nameFormatString, byte[] percentiles, string instance = null)
	{
		ValidateStringParameter(category, "category");
		ValidateStringParameter(nameFormatString, "nameFormatString");
		PercentileCounter.ValidatePercentiles(percentiles);
		string key = $"category={category}|nameformatstring={nameFormatString}|instance={instance}|{Convert.ToBase64String(percentiles)}";
		return _PercentileCounters.GetOrAdd(key, delegate
		{
			Dictionary<byte, CounterKey> dictionary = new Dictionary<byte, CounterKey>();
			byte[] array = percentiles;
			for (int i = 0; i < array.Length; i++)
			{
				byte key2 = array[i];
				string name = string.Format(nameFormatString, key2.ToString("D2"));
				CounterKey value = new CounterKey(category, name, instance);
				dictionary[key2] = value;
			}
			return new PercentileCounter(dictionary);
		});
	}

	public IPercentileCounter GetPercentileCounter(string category, string name, string instanceFormatString, byte[] percentiles)
	{
		ValidateStringParameter(category, "category");
		ValidateStringParameter(name, "name");
		ValidateStringParameter(instanceFormatString, "instanceFormatString");
		PercentileCounter.ValidatePercentiles(percentiles);
		string key = $"category={category}|name={name}|instanceFormatString={instanceFormatString}|{Convert.ToBase64String(percentiles)}";
		return _PercentileCounters.GetOrAdd(key, delegate
		{
			Dictionary<byte, CounterKey> dictionary = new Dictionary<byte, CounterKey>();
			byte[] array = percentiles;
			for (int i = 0; i < array.Length; i++)
			{
				byte key2 = array[i];
				string instance = string.Format(instanceFormatString, key2.ToString("D2"));
				CounterKey value = new CounterKey(category, name, instance);
				dictionary[key2] = value;
			}
			return new PercentileCounter(dictionary);
		});
	}

	public IReadOnlyCollection<KeyValuePair<CounterKey, double>> FlushCounters()
	{
		List<KeyValuePair<CounterKey, double>> list = new List<KeyValuePair<CounterKey, double>>();
		foreach (CounterBase allRegisteredCounter in GetAllRegisteredCounters())
		{
			double value = allRegisteredCounter.Flush();
			list.Add(new KeyValuePair<CounterKey, double>(allRegisteredCounter.Key, value));
		}
		foreach (KeyValuePair<string, PercentileCounter> percentileCounter in _PercentileCounters)
		{
			IReadOnlyCollection<KeyValuePair<CounterKey, double>> collection = percentileCounter.Value.Flush();
			list.AddRange(collection);
		}
		return list;
	}

	public IReadOnlyCollection<KeyValuePair<CounterKey, double>> GetCounterValues()
	{
		List<KeyValuePair<CounterKey, double>> list = new List<KeyValuePair<CounterKey, double>>();
		foreach (CounterBase allRegisteredCounter in GetAllRegisteredCounters())
		{
			double value = allRegisteredCounter.Get();
			list.Add(new KeyValuePair<CounterKey, double>(allRegisteredCounter.Key, value));
		}
		foreach (KeyValuePair<string, PercentileCounter> percentileCounter in _PercentileCounters)
		{
			IReadOnlyCollection<KeyValuePair<CounterKey, double>> collection = percentileCounter.Value.Get();
			list.AddRange(collection);
		}
		return list;
	}

	public IReadOnlyCollection<byte> GetDefaultPercentiles()
	{
		return (IReadOnlyCollection<byte>)(object)_DefaultPercentiles;
	}

	private IEnumerable<CounterBase> GetAllRegisteredCounters()
	{
		foreach (KeyValuePair<CounterKey, RateOfCountsPerSecondCounter> rateOfCountsPerSecondCounter in _RateOfCountsPerSecondCounters)
		{
			yield return rateOfCountsPerSecondCounter.Value;
		}
		foreach (KeyValuePair<CounterKey, AverageValueCounter> averageValueCounter in _AverageValueCounters)
		{
			yield return averageValueCounter.Value;
		}
		foreach (KeyValuePair<CounterKey, MaximumValueCounter> maximumValueCounter in _MaximumValueCounters)
		{
			yield return maximumValueCounter.Value;
		}
		foreach (KeyValuePair<CounterKey, RawValueCounter> rawValueCounter in _RawValueCounters)
		{
			yield return rawValueCounter.Value;
		}
		foreach (KeyValuePair<CounterKey, FractionCounter> fractionCounter in _FractionCounters)
		{
			yield return fractionCounter.Value;
		}
	}

	private void ValidateStringParameter(string parameter, string parameterName)
	{
		if (string.IsNullOrWhiteSpace(parameter))
		{
			throw new ArgumentException(parameterName);
		}
	}
}
