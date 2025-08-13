using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Roblox.Collections.Interfaces;

namespace Roblox.Collections;

public sealed class DeduplicatingBufferedQueue<TKey, TValue> : IDisposable, IDeduplicatingBufferedQueue<TKey, TValue>
{
	private readonly Func<TimeSpan> _CommitIntervalGetter;

	private readonly BlockingCollection<KeyValuePair<TKey, TValue>> _BlockingCollection;

	private ConcurrentDictionary<TKey, TValue> _CurrentDictionary;

	private Timer _CommitTimer;

	private bool _Disposed;

	public int Count => _BlockingCollection.Count + _CurrentDictionary.Count;

	public DeduplicatingBufferedQueue(Func<TimeSpan> commitIntervalGetter)
	{
		_CommitIntervalGetter = commitIntervalGetter;
		_CurrentDictionary = new ConcurrentDictionary<TKey, TValue>();
		_BlockingCollection = new BlockingCollection<KeyValuePair<TKey, TValue>>();
		TimeSpan commitInterval = _CommitIntervalGetter();
		_CommitTimer = new Timer(delegate
		{
			PauseTimerAndCommit();
		}, null, commitInterval, commitInterval);
	}

	public bool TryAdd(TKey key, TValue value)
	{
		return _CurrentDictionary.TryAdd(key, value);
	}

	public bool TryTake(out KeyValuePair<TKey, TValue> kvp)
	{
		return _BlockingCollection.TryTake(out kvp);
	}

	public bool TryTake(out KeyValuePair<TKey, TValue> kvp, TimeSpan timeout)
	{
		return _BlockingCollection.TryTake(out kvp, timeout);
	}

	public KeyValuePair<TKey, TValue> Take()
	{
		return _BlockingCollection.Take();
	}

	public IEnumerable<KeyValuePair<TKey, TValue>> TakeMultiple(int maxCount)
	{
		List<KeyValuePair<TKey, TValue>> result = new List<KeyValuePair<TKey, TValue>>(maxCount);
		for (int i = 0; i < maxCount; i++)
		{
			if (!_BlockingCollection.TryTake(out var kvp))
			{
				break;
			}
			result.Add(kvp);
		}
		return result;
	}

	public void Dispose()
	{
		if (!_Disposed)
		{
			EnqueueAccumulatedItems();
			_CommitTimer?.Dispose();
			_CommitTimer = null;
			_Disposed = true;
		}
	}

	internal void PauseTimerAndCommit()
	{
		_CommitTimer.Change(-1, -1);
		EnqueueAccumulatedItems();
		TimeSpan commitInterval = _CommitIntervalGetter();
		_CommitTimer.Change(commitInterval, commitInterval);
	}

	internal void EnqueueAccumulatedItems()
	{
		ConcurrentDictionary<TKey, TValue> replacementDictionary = new ConcurrentDictionary<TKey, TValue>();
		foreach (KeyValuePair<TKey, TValue> kvp in Interlocked.Exchange(ref _CurrentDictionary, replacementDictionary))
		{
			_BlockingCollection.TryAdd(kvp);
		}
	}
}
