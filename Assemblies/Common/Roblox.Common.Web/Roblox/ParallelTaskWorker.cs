using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Diagnostics;

namespace Roblox;

[CounterCategory("Roblox.ParallelTaskWorker v2")]
public sealed class ParallelTaskWorker : IDisposable
{
	public class Configuration
	{
		public TimeSpan LeaseDuration { get; }

		public TimeSpan MinSleepTime { get; }

		public TimeSpan MaxSleepTime { get; }

		public TimeSpan SleepTimeDecay { get; }

		public int WorkerThreadCount { get; }

		public Guid WorkerId { get; }

		public Action<Exception> ExceptionHandler { get; }

		public int? MaxTaskQueueLength { get; }

		public bool SleepBetweenProcessItems { get; }

		public Configuration(Guid workerId, TimeSpan leaseDuration, TimeSpan minSleepTime, TimeSpan maxSleepTime, long sleepTimeDecayInTicks, int workerThreadCount = 2, Action<Exception> exceptionHandler = null, int? maxTaskQueueLength = null, bool sleepBetweenProcessItems = false)
		{
			LeaseDuration = leaseDuration;
			MinSleepTime = minSleepTime;
			MaxSleepTime = maxSleepTime;
			SleepTimeDecay = TimeSpan.FromTicks(sleepTimeDecayInTicks);
			WorkerId = workerId;
			WorkerThreadCount = workerThreadCount;
			ExceptionHandler = exceptionHandler;
			MaxTaskQueueLength = maxTaskQueueLength;
			SleepBetweenProcessItems = sleepBetweenProcessItems;
		}
	}

	public struct LeaseResult
	{
		public bool AreMoreExpected;

		public IEnumerable<IParallelWorkTask> Tasks;

		public LeaseResult(bool moreResultsAreExpected, IEnumerable<IParallelWorkTask> tasks)
		{
			AreMoreExpected = moreResultsAreExpected;
			Tasks = tasks;
		}
	}

	private Configuration _Configuration;

	private readonly Func<LeaseResult> _LeasedTasksFetcher;

	private TimeSpan _SleepTime = TimeSpan.Zero;

	private readonly BlockingCollection<IParallelWorkTask> _TaskQueue = new BlockingCollection<IParallelWorkTask>();

	public static Guid ID = Guid.NewGuid();

	private CancellationTokenSource _ProcessTaskCancellationTokenSource;

	private CancellationTokenSource _RequestTaskCancellationTokenSource;

	[Counter("Requests", PerformanceCounterType.NumberOfItems64)]
	private readonly PerformanceCounter _RequestsTotal;

	[Counter("Requests/s", PerformanceCounterType.RateOfCountsPerSecond32)]
	private readonly PerformanceCounter _RequestsPerSecond;

	[Counter("Tasks Errors", PerformanceCounterType.NumberOfItems32)]
	private readonly PerformanceCounter _TaskErrorsTotal;

	[Counter("Tasks Errors/s", PerformanceCounterType.RateOfCountsPerSecond32)]
	private readonly PerformanceCounter _TaskErrorsPerSecond;

	[Counter("Tasks Processed", PerformanceCounterType.NumberOfItems32)]
	private readonly PerformanceCounter _TasksProcessedTotal;

	[Counter("Tasks Processed/s", PerformanceCounterType.RateOfCountsPerSecond32)]
	private readonly PerformanceCounter _TasksProcessedPerSecond;

	[Counter("Tasks Success", PerformanceCounterType.NumberOfItems32)]
	private readonly PerformanceCounter _TaskSuccessesTotal;

	[Counter("Tasks Success/s", PerformanceCounterType.RateOfCountsPerSecond32)]
	private readonly PerformanceCounter _TaskSuccessesPerSecond;

	[Counter("Queued Tasks", PerformanceCounterType.NumberOfItems32)]
	private readonly PerformanceCounter _TaskQueued;

	[Counter("Delay Interval", PerformanceCounterType.NumberOfItems32)]
	private readonly PerformanceCounter _CurrentDelay;

	public int QueuedTasks => _TaskQueue.Count;

	public ParallelTaskWorker(string taskName, Configuration configuration, Func<LeaseResult> leasedTasksFetcher)
	{
		PerfCounters.Initialize(this, taskName);
		_Configuration = configuration;
		_LeasedTasksFetcher = leasedTasksFetcher;
	}

	private void DoActionForeverInNewThread(int workerThreadCount, CancellationToken cancellationToken, Action performAction, bool sleepBetweenLoop = false)
	{
		for (int i = 0; i < workerThreadCount; i++)
		{
			Task.Factory.StartNew(delegate
			{
				while (true)
				{
					try
					{
						performAction();
					}
					catch (Exception ex)
					{
						LogException(ex);
					}
					if (cancellationToken.IsCancellationRequested)
					{
						break;
					}
					if (sleepBetweenLoop)
					{
						_CurrentDelay.RawValue = (long)_SleepTime.TotalSeconds;
						Thread.Sleep(_SleepTime);
					}
				}
			}, cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);
		}
	}

	private void ProcessItems()
	{
		_ProcessTaskCancellationTokenSource = new CancellationTokenSource();
		DoActionForeverInNewThread(_Configuration.WorkerThreadCount, _ProcessTaskCancellationTokenSource.Token, delegate
		{
			IParallelWorkTask workItem = _TaskQueue.Take();
			ProcessWorkItem(workItem);
		}, _Configuration.SleepBetweenProcessItems);
	}

	private void RequestWork()
	{
		_RequestTaskCancellationTokenSource = new CancellationTokenSource();
		DoActionForeverInNewThread(1, _RequestTaskCancellationTokenSource.Token, delegate
		{
			if (_Configuration.MaxTaskQueueLength.HasValue && _TaskQueue.Count > _Configuration.MaxTaskQueueLength.Value)
			{
				DecaySleepTime(reset: false);
			}
			else
			{
				_RequestsTotal.Increment();
				_RequestsPerSecond.Increment();
				LeaseResult leaseResult = _LeasedTasksFetcher();
				foreach (IParallelWorkTask current in leaseResult.Tasks)
				{
					EnqueueWorkItem(current);
				}
				DecaySleepTime(leaseResult.AreMoreExpected);
			}
		}, sleepBetweenLoop: true);
	}

	private void DecaySleepTime(bool reset)
	{
		if (reset)
		{
			_SleepTime = _Configuration.MinSleepTime;
			return;
		}
		_SleepTime += _Configuration.SleepTimeDecay;
		if (_SleepTime > _Configuration.MaxSleepTime)
		{
			_SleepTime = _Configuration.MaxSleepTime;
		}
	}

	private void EnqueueWorkItem(IParallelWorkTask workItem)
	{
		if (workItem != null)
		{
			_TaskQueue.Add(workItem);
			_TaskQueued.RawValue = _TaskQueue.Count;
		}
	}

	private void ProcessWorkItem(IParallelWorkTask workItem)
	{
		try
		{
			if (workItem != null)
			{
				_TasksProcessedTotal.Increment();
				_TasksProcessedPerSecond.Increment();
				workItem.ProcessTaskAndMarkComplete();
				_TaskSuccessesTotal.Increment();
				_TaskSuccessesPerSecond.Increment();
			}
		}
		catch (Exception ex)
		{
			_TaskErrorsTotal.Increment();
			_TaskErrorsPerSecond.Increment();
			LogException(ex);
		}
		finally
		{
			_TaskQueued.RawValue = _TaskQueue.Count;
		}
	}

	public static ParallelTaskWorker Start(string taskName, Configuration configuration, Func<LeaseResult> leasedTasksFetcher)
	{
		ParallelTaskWorker parallelTaskWorker = new ParallelTaskWorker(taskName, configuration, leasedTasksFetcher);
		parallelTaskWorker.Start();
		return parallelTaskWorker;
	}

	public void Reconfigure(Configuration configuration)
	{
		if (configuration != null)
		{
			_Configuration = configuration;
		}
	}

	public void Restart(Configuration configuration = null)
	{
		if (configuration != null)
		{
			_Configuration = configuration;
		}
		Stop();
		Start();
	}

	public void Start()
	{
		ProcessItems();
		RequestWork();
	}

	public void Stop()
	{
		_ProcessTaskCancellationTokenSource?.Cancel();
		_RequestTaskCancellationTokenSource?.Cancel();
	}

	public void Dispose()
	{
		PerfCounters.Dispose(this);
	}

	private void LogException(Exception ex)
	{
		if (_Configuration?.ExceptionHandler != null)
		{
			_Configuration.ExceptionHandler(ex);
		}
		else
		{
			ExceptionHandler.LogException(ex);
		}
	}
}
