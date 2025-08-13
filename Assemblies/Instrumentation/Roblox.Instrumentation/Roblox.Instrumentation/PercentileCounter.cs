using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Roblox.Instrumentation.PrometheusListener;

namespace Roblox.Instrumentation;

internal class PercentileCounter : IPercentileCounter
{
	private readonly IDictionary<byte, CounterKey> _CounterKeyByPercentile;

	private readonly IDictionary<CounterKey, GaugeWrapper> _PromGaugeByCounterKey;

	private ConcurrentBag<double> _Values;

	public PercentileCounter(IDictionary<byte, CounterKey> counterKeyByPercentile)
	{
		_CounterKeyByPercentile = counterKeyByPercentile;
		_Values = new ConcurrentBag<double>();
		if (PrometheusServerWrapper.Instance.UpdatingCountersEnabled)
		{
			_PromGaugeByCounterKey = counterKeyByPercentile.Values.ToDictionary((CounterKey key) => key, (CounterKey key) => new GaugeWrapper(key.Name, key.Instance, key.Category, "generic_percentile"));
		}
	}

	public void Sample(double value)
	{
		_Values.Add(value);
	}

	internal IReadOnlyCollection<KeyValuePair<CounterKey, double>> Flush()
	{
		ConcurrentBag<double> value = new ConcurrentBag<double>();
		ConcurrentBag<double> concurrentBag = Interlocked.Exchange(ref _Values, value);
		if (concurrentBag.IsEmpty)
		{
			return (IReadOnlyCollection<KeyValuePair<CounterKey, double>>)(object)Array.Empty<KeyValuePair<CounterKey, double>>();
		}
		List<double> list = concurrentBag.ToList();
		list.Sort();
		IReadOnlyCollection<KeyValuePair<CounterKey, double>> readOnlyCollection = ComputePercentiles(list);
		if (PrometheusServerWrapper.Instance.UpdatingCountersEnabled)
		{
			foreach (KeyValuePair<CounterKey, double> item in readOnlyCollection)
			{
				_PromGaugeByCounterKey[item.Key].Set(item.Value);
			}
		}
		return readOnlyCollection;
	}

	internal IReadOnlyCollection<KeyValuePair<CounterKey, double>> Get()
	{
		List<double> list = _Values.ToList();
		if (list.Count == 0)
		{
			return (IReadOnlyCollection<KeyValuePair<CounterKey, double>>)(object)Array.Empty<KeyValuePair<CounterKey, double>>();
		}
		list.Sort();
		return ComputePercentiles(list);
	}

	internal static double GetPercentile(IList<double> sortedValues, double percentile)
	{
		if (sortedValues.Count == 0)
		{
			throw new ArgumentException(string.Format("{0} count must be > 0", "sortedValues"), "sortedValues");
		}
		double num = percentile * (double)(sortedValues.Count - 1);
		int num2 = (int)num;
		double num3 = num - (double)num2;
		if (num2 + 1 < sortedValues.Count)
		{
			return sortedValues[num2] * (1.0 - num3) + sortedValues[num2 + 1] * num3;
		}
		return sortedValues[num2];
	}

	internal static void ValidatePercentiles(byte[] percentiles)
	{
		if (percentiles == null || percentiles.Length == 0)
		{
			throw new ArgumentException("Percentiles cannot be null or empty", "percentiles");
		}
		foreach (byte b in percentiles)
		{
			if (b < 1 || b > 99)
			{
				throw new ArgumentException("Percentiles cannot be < 1 or > 99.  The value was " + b, "percentiles");
			}
		}
	}

	internal IReadOnlyCollection<KeyValuePair<CounterKey, double>> ComputePercentiles(IList<double> sortedValues)
	{
		List<KeyValuePair<CounterKey, double>> list = new List<KeyValuePair<CounterKey, double>>(_CounterKeyByPercentile.Count);
		foreach (KeyValuePair<byte, CounterKey> item in _CounterKeyByPercentile)
		{
			double percentile = (double)(int)item.Key / 100.0;
			double percentile2 = GetPercentile(sortedValues, percentile);
			list.Add(new KeyValuePair<CounterKey, double>(item.Value, percentile2));
		}
		return list;
	}
}
