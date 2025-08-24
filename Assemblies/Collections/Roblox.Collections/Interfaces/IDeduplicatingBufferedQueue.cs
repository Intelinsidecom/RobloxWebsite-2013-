using System;
using System.Collections.Generic;

namespace Roblox.Collections.Interfaces;

public interface IDeduplicatingBufferedQueue<TKey, TValue>
{
	int Count { get; }

	bool TryAdd(TKey key, TValue value);

	bool TryTake(out KeyValuePair<TKey, TValue> kvp);

	bool TryTake(out KeyValuePair<TKey, TValue> kvp, TimeSpan timeout);

	KeyValuePair<TKey, TValue> Take();

	IEnumerable<KeyValuePair<TKey, TValue>> TakeMultiple(int maxCount);
}
