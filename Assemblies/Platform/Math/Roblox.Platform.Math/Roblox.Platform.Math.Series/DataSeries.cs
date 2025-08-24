using System;
using System.Collections.Generic;

namespace Roblox.Platform.Math.Series;

internal abstract class DataSeries<TKey, TVal> : IDataSeries<TKey, TVal> where TKey : IComparable<TKey>
{
	private readonly SortedDictionary<TKey, TVal> _Datapoints = new SortedDictionary<TKey, TVal>();

	public SortedDictionary<TKey, TVal> DataPoints
	{
		get
		{
			lock (_Datapoints)
			{
				return new SortedDictionary<TKey, TVal>(_Datapoints);
			}
		}
	}

	public IEnumerable<KeyValuePair<TKey, TVal>> KeyValuePairs => DataPoints;

	public void AddDataPoint(TKey key, TVal val)
	{
		lock (_Datapoints)
		{
			DoAddDataPoint(key, val);
		}
	}

	public void AddDataPoints(IDictionary<TKey, TVal> dataPoints)
	{
		if (dataPoints == null)
		{
			return;
		}
		lock (_Datapoints)
		{
			foreach (TKey key in dataPoints.Keys)
			{
				DoAddDataPoint(key, dataPoints[key]);
			}
		}
	}

	public void AddDataPoints(IEnumerable<KeyValuePair<TKey, TVal>> dataPoints)
	{
		if (dataPoints == null)
		{
			return;
		}
		lock (_Datapoints)
		{
			foreach (KeyValuePair<TKey, TVal> pair in dataPoints)
			{
				DoAddDataPoint(pair.Key, pair.Value);
			}
		}
	}

	protected void LockAndOperateOnDataPoints(Action<SortedDictionary<TKey, TVal>> operation)
	{
		lock (_Datapoints)
		{
			operation(_Datapoints);
		}
	}

	protected abstract TVal PreProcessValueToAdd(TKey key, TVal val, bool keyExists, TVal oldVal);

	protected abstract void PostProcessAddedDataPoint(TKey key, TVal val);

	private void DoAddDataPoint(TKey key, TVal val)
	{
		bool keyExists = false;
		TVal oldVal = default(TVal);
		if (_Datapoints.ContainsKey(key))
		{
			keyExists = true;
			oldVal = _Datapoints[key];
		}
		val = PreProcessValueToAdd(key, val, keyExists, oldVal);
		_Datapoints[key] = val;
		PostProcessAddedDataPoint(key, val);
	}
}
