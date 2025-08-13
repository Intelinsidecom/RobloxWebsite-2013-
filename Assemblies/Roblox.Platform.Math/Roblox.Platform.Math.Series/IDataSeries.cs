using System;
using System.Collections.Generic;

namespace Roblox.Platform.Math.Series;

internal interface IDataSeries<TKey, TVal> where TKey : IComparable<TKey>
{
	SortedDictionary<TKey, TVal> DataPoints { get; }

	IEnumerable<KeyValuePair<TKey, TVal>> KeyValuePairs { get; }

	void AddDataPoint(TKey key, TVal val);

	void AddDataPoints(IDictionary<TKey, TVal> dataPoints);

	void AddDataPoints(IEnumerable<KeyValuePair<TKey, TVal>> dataPoints);
}
