using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Roblox.EventLog;

namespace Roblox.Collections;

public abstract class BufferedCounterBase<TKey> : CounterBase<TKey>, IDisposable
{
	public delegate void OnCommitHandler(IEnumerable<TKey> counterKeys);

	private ConcurrentDictionary<TKey, double> _Current;

	private Timer _CommitTimer;

	private bool _Disposed;

	private readonly ILogger _Logger;

	protected abstract TimeSpan CommitInterval { get; }

	public event OnCommitHandler OnCommit;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Collections.BufferedCounterBase`1" /> class.
	/// </summary>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// <paramref name="logger" />
	/// </exception>
	protected BufferedCounterBase(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_Current = new ConcurrentDictionary<TKey, double>();
		InitializeTimer();
	}

	public override void Increment(TKey counterKey, double amount = 1.0)
	{
		_Current.AddOrUpdate(counterKey, amount, (TKey k, double v) => v + amount);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_Disposed)
		{
			if (disposing)
			{
				DoCommit();
				_CommitTimer?.Dispose();
			}
			_CommitTimer = null;
			_Disposed = true;
		}
	}

	private void InitializeTimer()
	{
		_CommitTimer = new Timer(delegate
		{
			PauseTimerAndCommit();
		}, null, CommitInterval, CommitInterval);
	}

	private void PauseTimerAndCommit()
	{
		_CommitTimer.Change(-1, -1);
		DoCommit();
		_CommitTimer.Change(CommitInterval, CommitInterval);
	}

	internal void DoCommit()
	{
		ConcurrentDictionary<TKey, double> newDictionary = new ConcurrentDictionary<TKey, double>();
		ConcurrentDictionary<TKey, double> toCommit = Interlocked.Exchange(ref _Current, newDictionary);
		Commit(toCommit);
		if (this.OnCommit != null)
		{
			try
			{
				this.OnCommit(toCommit.Keys);
			}
			catch (Exception e)
			{
				_Logger.Error(e);
			}
		}
	}

	~BufferedCounterBase()
	{
		try
		{
			DoCommit();
		}
		catch (Exception)
		{
		}
		Dispose(disposing: false);
	}
}
