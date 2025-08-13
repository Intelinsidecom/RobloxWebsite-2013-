using System;
using System.Threading;

namespace Roblox.Sentinels;

public class ServiceSentinel : ISentinel, IDisposable
{
	private readonly Func<bool> _HealthChecker;

	private bool _IsDisposed;

	protected readonly Func<TimeSpan> _MonitorIntervalGetter;

	protected Timer _MonitorTimer;

	public bool IsHealthy { get; private set; }

	public ServiceSentinel(Func<bool> healthChecker, Func<TimeSpan> monitorIntervalGetter, bool isHealthy = true)
	{
		_HealthChecker = healthChecker;
		_MonitorIntervalGetter = monitorIntervalGetter;
		IsHealthy = isHealthy;
		_MonitorTimer = new Timer(OnTimerCallback);
		TimeSpan timeSpan = monitorIntervalGetter();
		_MonitorTimer.Change(timeSpan, timeSpan);
	}

	private void OnTimerCallback(object state)
	{
		if (_IsDisposed)
		{
			return;
		}
		Timer timer = (Timer)state;
		try
		{
			timer.Change(-1, -1);
			IsHealthy = _HealthChecker();
		}
		catch (Exception)
		{
			IsHealthy = false;
		}
		finally
		{
			try
			{
				TimeSpan timeSpan = _MonitorIntervalGetter();
				timer.Change(timeSpan, timeSpan);
			}
			catch
			{
			}
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_IsDisposed)
		{
			if (disposing)
			{
				_MonitorTimer.CheckAndDispose();
				_MonitorTimer = null;
			}
			_IsDisposed = true;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
