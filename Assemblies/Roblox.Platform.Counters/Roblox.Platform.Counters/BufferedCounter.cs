using System;
using System.Timers;
using Roblox.EventLog;

namespace Roblox.Platform.Counters;

/// <summary>
/// Implementation of an <see cref="T:Roblox.Platform.Counters.ICounter" /> using batched commits for efficency
/// </summary>
internal class BufferedCounter : ICounter, IDisposable
{
	private double _CachedDelta;

	private readonly object _UpdateLock = new object();

	private readonly TimeSpan _CommitInterval;

	private readonly Timer _CommitTimer;

	private readonly ICounter _Counter;

	private readonly ILogger _Logger;

	public BufferedCounter(ICounter counter, TimeSpan commitInterval, ILogger logger)
	{
		_CachedDelta = 0.0;
		_CommitInterval = commitInterval;
		_CommitTimer = new Timer(_CommitInterval.TotalMilliseconds);
		_CommitTimer.Elapsed += delegate
		{
			DoCommit();
		};
		_Counter = counter ?? throw new ArgumentNullException("counter");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ICounter.Increment(System.Double)" />
	public void Increment(double value = 1.0)
	{
		ApplyDelta(value);
	}

	/// <inheritdoc />
	public void IncrementInBackground(double value = 1.0, Action<Exception> exceptionHandler = null)
	{
		Increment(value);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ICounter.Decrement(System.Double)" />
	public void Decrement(double value = 1.0)
	{
		ApplyDelta(value * -1.0);
	}

	/// <inheritdoc />
	public void DecrementInBackground(double value = 1.0, Action<Exception> exceptionHandler = null)
	{
		Decrement(value);
	}

	/// <inheritdoc />
	public double GetCount(bool useCache = true, TimeSpan? cacheDuration = null)
	{
		return _Counter.GetCount(useCache, cacheDuration);
	}

	/// <inheritdoc />
	public string GetKey()
	{
		return _Counter.GetKey();
	}

	private void ApplyDelta(double delta)
	{
		lock (_UpdateLock)
		{
			_CachedDelta += delta;
			_CommitTimer.Enabled = true;
		}
	}

	private void Commit(double value)
	{
		if (value == 0.0)
		{
			return;
		}
		try
		{
			_Counter.Increment(value);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			ApplyDelta(value);
		}
	}

	private void DoCommit()
	{
		double toCommit = 0.0;
		lock (_UpdateLock)
		{
			toCommit = _CachedDelta;
			_CachedDelta = 0.0;
			if (toCommit == 0.0)
			{
				_CommitTimer.Enabled = false;
				return;
			}
		}
		Commit(toCommit);
	}

	public void Dispose()
	{
		_CommitTimer.Dispose();
		DoCommit();
	}
}
