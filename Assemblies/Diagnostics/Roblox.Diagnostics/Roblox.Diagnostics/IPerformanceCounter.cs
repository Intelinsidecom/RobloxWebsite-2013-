using System;

namespace Roblox.Diagnostics;

/// <summary>
/// A performance counter
/// </summary>
public interface IPerformanceCounter : IDisposable
{
	/// <summary>
	/// The current value
	/// </summary>
	long Value { get; set; }

	/// <summary>
	/// Increments <see cref="P:Roblox.Diagnostics.IPerformanceCounter.Value" /> by 1
	/// </summary>
	void Increment();

	/// <summary>
	/// Increments <see cref="P:Roblox.Diagnostics.IPerformanceCounter.Value" /> by <paramref name="value" />
	/// </summary>
	/// <param name="value">The delta to increment by.</param>
	void IncrementBy(long value);

	/// <summary>
	/// Resets <see cref="P:Roblox.Diagnostics.IPerformanceCounter.Value" /> back to default (0.)
	/// </summary>
	void Reset();
}
