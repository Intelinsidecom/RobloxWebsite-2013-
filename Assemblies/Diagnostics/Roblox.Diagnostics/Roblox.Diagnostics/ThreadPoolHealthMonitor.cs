using System;
using System.Threading;

namespace Roblox.Diagnostics;

public sealed class ThreadPoolHealthMonitor : IDisposable
{
	public class ThreadPoolHealthEventArgs : EventArgs
	{
		public int AvailableWorkerThreads { get; private set; }

		public int AvailableCompletionPortThreads { get; private set; }

		public TimeSpan ExhaustionDuration { get; private set; }

		public ThreadPoolHealthEventArgs(int availableWorkerThreads, int availableCompletionPortThreads, TimeSpan exhaustionDuration)
		{
			AvailableWorkerThreads = availableWorkerThreads;
			AvailableCompletionPortThreads = availableCompletionPortThreads;
			ExhaustionDuration = exhaustionDuration;
		}
	}

	public delegate void ThreadPoolExhaustedEventHandler(object sender, EventArgs e);

	public delegate void ThreadPoolRecoveredEventHandler(object sender, EventArgs e);

	private readonly Func<int> _ThreadPoolExhaustionThresholdGetter;

	private readonly Func<TimeSpan> _ThreadPoolExhaustionDurationGetter;

	private bool _ContinueRunning = true;

	private DateTime? _Exhausted;

	private readonly Thread _MonitorThread;

	private static readonly TimeSpan _Interval = TimeSpan.FromMilliseconds(100.0);

	public event ThreadPoolExhaustedEventHandler ThreadPoolExhausted;

	public event ThreadPoolRecoveredEventHandler ThreadPoolRecovered;

	public ThreadPoolHealthMonitor(Func<int> threadPoolExhaustionThresholdGetter, Func<TimeSpan> threadPoolExhaustionDurationGetter)
	{
		_ThreadPoolExhaustionThresholdGetter = threadPoolExhaustionThresholdGetter;
		_ThreadPoolExhaustionDurationGetter = threadPoolExhaustionDurationGetter;
		_MonitorThread = new Thread(Monitor)
		{
			IsBackground = true
		};
		_MonitorThread.Start();
	}

	private void Monitor()
	{
		while (_ContinueRunning)
		{
			try
			{
				DateTime now = DateTime.Now;
				ThreadPool.GetAvailableThreads(out var availableWorkerThreads, out var availableCompletionPortThreads);
				if (availableWorkerThreads <= _ThreadPoolExhaustionThresholdGetter())
				{
					if (!_Exhausted.HasValue)
					{
						_Exhausted = now;
					}
					TimeSpan exhaustionDuration2 = now.Subtract(_Exhausted.Value);
					if (exhaustionDuration2 > _ThreadPoolExhaustionDurationGetter())
					{
						OnThreadPoolExhausted(availableWorkerThreads, availableCompletionPortThreads, exhaustionDuration2);
					}
				}
				else if (_Exhausted.HasValue)
				{
					TimeSpan exhaustionDuration = now.Subtract(_Exhausted.Value);
					_Exhausted = null;
					OnThreadPoolRecovered(availableWorkerThreads, availableCompletionPortThreads, exhaustionDuration);
				}
				Thread.Sleep(_Interval);
			}
			catch (Exception)
			{
			}
		}
	}

	private void OnThreadPoolExhausted(int availableWorkerThreads, int availableCompletionPortThreads, TimeSpan exhaustionDuration)
	{
		if (this.ThreadPoolExhausted != null)
		{
			ThreadPoolHealthEventArgs threadPoolHealthEventArgs = new ThreadPoolHealthEventArgs(availableWorkerThreads, availableCompletionPortThreads, exhaustionDuration);
			this.ThreadPoolExhausted(this, threadPoolHealthEventArgs);
		}
	}

	private void OnThreadPoolRecovered(int availableWorkerThreads, int availableCompletionPortThreads, TimeSpan exhaustionDuration)
	{
		if (this.ThreadPoolRecovered != null)
		{
			ThreadPoolHealthEventArgs threadPoolHealthEventArgs = new ThreadPoolHealthEventArgs(availableWorkerThreads, availableCompletionPortThreads, exhaustionDuration);
			this.ThreadPoolRecovered(this, threadPoolHealthEventArgs);
		}
	}

	public void Dispose()
	{
		_ContinueRunning = false;
	}
}
