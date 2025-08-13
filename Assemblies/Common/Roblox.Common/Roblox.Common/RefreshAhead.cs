using System;
using System.Threading;

namespace Roblox.Common;

/// <inheritdoc cref="T:Roblox.Common.IRefreshAhead`1" />
public class RefreshAhead<T> : IRefreshAhead<T>, IDisposable
{
	private DateTime _LastRefresh = DateTime.MinValue;

	private readonly Timer _RefreshTimer;

	private bool _RunningRefresh;

	private TimeSpan _RefreshInterval;

	private readonly Func<T, T> _RefreshDelegate;

	public TimeSpan IntervalSinceRefresh => DateTime.Now.Subtract(_LastRefresh);

	/// <inheritdoc cref="P:Roblox.Common.IRefreshAhead`1.Value" />
	public T Value { get; private set; }

	public RefreshAhead(TimeSpan refreshInterval, Func<T> refreshDelegate)
		: this(default(T), refreshInterval, (Func<T, T>)((T t) => refreshDelegate()))
	{
	}

	public RefreshAhead(T initialValue, TimeSpan refreshInterval, Func<T> refreshDelegate)
		: this(initialValue, refreshInterval, (Func<T, T>)((T t) => refreshDelegate()))
	{
	}

	public RefreshAhead(T initialValue, TimeSpan refreshInterval, Func<T, T> refreshDelegate)
	{
		int refreshIntervalInMilliseconds = (int)refreshInterval.TotalMilliseconds;
		_RefreshInterval = refreshInterval;
		_RefreshDelegate = refreshDelegate ?? throw new ArgumentNullException("refreshDelegate");
		Value = initialValue;
		_LastRefresh = DateTime.UtcNow;
		_RefreshTimer = new Timer(delegate
		{
			Refresh();
		}, null, refreshIntervalInMilliseconds, refreshIntervalInMilliseconds);
	}

	/// <inheritdoc cref="M:Roblox.Common.IRefreshAhead`1.SetRefreshInterval(System.TimeSpan)" />
	public void SetRefreshInterval(TimeSpan newRefreshInterval)
	{
		TimeSpan timeSinceLastRefresh = DateTime.UtcNow - _LastRefresh;
		TimeSpan nextRunTime = newRefreshInterval - timeSinceLastRefresh;
		if (nextRunTime.TotalMilliseconds < 0.0)
		{
			nextRunTime = TimeSpan.Zero;
		}
		_RefreshTimer.Change(nextRunTime, newRefreshInterval);
		_RefreshInterval = newRefreshInterval;
	}

	/// <inheritdoc cref="M:Roblox.Common.IRefreshAhead`1.Refresh" />
	public void Refresh()
	{
		if (_RunningRefresh)
		{
			return;
		}
		_RunningRefresh = true;
		bool refreshTimer = true;
		try
		{
			Value = _RefreshDelegate(Value);
			_LastRefresh = DateTime.UtcNow;
		}
		catch (ThreadAbortException)
		{
			refreshTimer = false;
			throw;
		}
		catch (Exception ex2)
		{
			ExceptionHandler.LogException(ex2);
		}
		finally
		{
			_RunningRefresh = false;
			if (refreshTimer)
			{
				_RefreshTimer.Change(_RefreshInterval, _RefreshInterval);
			}
		}
	}

	public static RefreshAhead<T> ConstructAndPopulate(TimeSpan refreshInterval, Func<T> refreshDelegate)
	{
		return ConstructAndPopulate(refreshInterval, (T t) => refreshDelegate());
	}

	public static RefreshAhead<T> ConstructAndPopulate(TimeSpan refreshInterval, Func<T, T> refreshDelegate)
	{
		T value = refreshDelegate(default(T));
		return new RefreshAhead<T>(value, refreshInterval, refreshDelegate);
	}

	public void Dispose()
	{
		_RefreshTimer?.Dispose();
	}
}
