using System;

namespace Roblox.Platform.Counters;

/// <summary>
/// A single-value counter
/// </summary>
public interface ICounter
{
	/// <summary>
	/// Decrements the counter
	/// </summary>
	/// <param name="value">Decrement by</param>
	void Decrement(double value = 1.0);

	/// <summary>
	/// Get value of the counter
	/// </summary>
	/// <param name="useCache">Whether to return any cached values</param>
	/// <param name="cacheDuration">How long should the value be cached?</param>
	/// <returns>current value of the counter</returns>
	double GetCount(bool useCache = true, TimeSpan? cacheDuration = null);

	/// <summary>
	/// Increments the counter
	/// </summary>
	/// <param name="value">Increment by</param>
	void Increment(double value = 1.0);

	/// <summary>
	/// Increments the counter without blocking the thread
	/// </summary>
	/// <param name="value">Increments by</param>
	/// <param name="exceptionHandler">Handler to call on exceptions</param>
	[Obsolete("Should be using a buffered counter instead.")]
	void IncrementInBackground(double value = 1.0, Action<Exception> exceptionHandler = null);

	/// <summary>
	/// Decrements the counter without blocking the thread
	/// </summary>
	/// <param name="value">Decrements by</param>
	/// <param name="exceptionHandler">Handler to call on exceptions</param>
	[Obsolete("Should be using a buffered counter instead.")]
	void DecrementInBackground(double value = 1.0, Action<Exception> exceptionHandler = null);

	/// <summary>
	/// Returns the counter's key
	/// </summary>
	/// <returns>the counter's key</returns>
	string GetKey();
}
