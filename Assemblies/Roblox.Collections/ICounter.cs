namespace Roblox.Collections;

/// <summary>
/// A generic counter interface
/// </summary>
/// <typeparam name="TKey">The type of thing to count.</typeparam>
public interface ICounter<in TKey>
{
	/// <summary>
	/// Increments the specified counter key.
	/// </summary>
	/// <param name="counterKey">The counter key.</param>
	/// <param name="amount">The amount.</param>
	void Increment(TKey counterKey, double amount = 1.0);
}
