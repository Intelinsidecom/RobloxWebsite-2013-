using System.Collections.Generic;

namespace Roblox.Collections;

/// <summary>
/// A base class for counters that includes the protected Commit method used to persist counts.
/// </summary>
/// <typeparam name="TKey">The type of the key.</typeparam>
/// <seealso cref="T:Roblox.Collections.ICounter`1" />
public abstract class CounterBase<TKey> : ICounter<TKey>
{
	protected virtual void Commit(IEnumerable<KeyValuePair<TKey, double>> committableDictionary)
	{
	}

	/// <summary>
	/// Increments the specified counter key.
	/// </summary>
	/// <param name="counterKey">The counter key.</param>
	/// <param name="amount">The amount.</param>
	public abstract void Increment(TKey counterKey, double amount = 1.0);
}
