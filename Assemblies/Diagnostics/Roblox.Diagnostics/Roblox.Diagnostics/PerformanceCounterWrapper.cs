using System;
using System.Diagnostics;

namespace Roblox.Diagnostics;

/// <summary>
/// An implementation of <see cref="T:Roblox.Diagnostics.IPerformanceCounter" /> that wraps <see cref="T:System.Diagnostics.PerformanceCounter" />
/// </summary>
public sealed class PerformanceCounterWrapper : IPerformanceCounter, IDisposable
{
	private bool _IsDisposed;

	private readonly PerformanceCounter _Counter;

	/// <inheritdoc cref="P:Roblox.Diagnostics.IPerformanceCounter.Value" />
	public long Value
	{
		get
		{
			return _Counter.RawValue;
		}
		set
		{
			_Counter.RawValue = value;
		}
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Diagnostics.PerformanceCounterWrapper" />
	/// </summary>
	/// <param name="performanceCounter">The <see cref="T:System.Diagnostics.PerformanceCounter" /></param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	public PerformanceCounterWrapper(PerformanceCounter performanceCounter)
	{
		_Counter = performanceCounter ?? throw new ArgumentNullException("performanceCounter");
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.IPerformanceCounter.Increment" />
	public void Increment()
	{
		_Counter.Increment();
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.IPerformanceCounter.IncrementBy(System.Int64)" />
	public void IncrementBy(long value)
	{
		_Counter.IncrementBy(value);
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.IPerformanceCounter.Reset" />
	public void Reset()
	{
		_Counter.RawValue = 0L;
	}

	/// <inheritdoc cref="M:System.IDisposable.Dispose" />
	public void Dispose()
	{
		if (!_IsDisposed)
		{
			_Counter?.Dispose();
			_IsDisposed = true;
		}
	}
}
