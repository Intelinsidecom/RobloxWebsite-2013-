using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Roblox.Collections;

public class ExpirableDictionary<TKey, TValue> : IDisposable where TValue : class
{
	private class ExpirableValue
	{
		private DateTime _Expiration;

		private DateTime _Updated;

		public TValue Value { get; }

		public ExpirableValue(TValue value, TimeSpan timeToLive)
		{
			Value = value;
			ExtendExpiration(timeToLive);
		}

		public bool IsExpired(DateTime now)
		{
			return now >= _Expiration;
		}

		public void ExtendExpiration(TimeSpan timeToLive)
		{
			_Updated = DateTime.UtcNow;
			_Expiration = _Updated + timeToLive;
		}
	}

	private readonly TimeSpan _TraversalInterval;

	private readonly ExpirationPolicy _ExpirationPolicy;

	private readonly Func<TimeSpan> _TimeToLiveGetter;

	private ConcurrentDictionary<TKey, ExpirableValue> _Entries = new ConcurrentDictionary<TKey, ExpirableValue>();

	private Timer _Timer;

	private bool _Disposed;

	public event Action PreTraversal;

	public event Action TraversalComplete;

	public event Action<TValue, RemovalReason> EntryRemoved;

	public event Action<TValue, DateTime> EntryTraversed;

	public event Action<Exception> ExceptionOccurred;

	public ExpirableDictionary(TimeSpan entryTimeToLive)
		: this(entryTimeToLive, TimeSpan.FromSeconds(1.0))
	{
	}

	public ExpirableDictionary(TimeSpan entryTimeToLive, TimeSpan traversalInterval)
		: this((Func<TimeSpan>)(() => entryTimeToLive), traversalInterval, ExpirationPolicy.RenewOnRead)
	{
	}

	public ExpirableDictionary(Func<TimeSpan> entryTimeToLiveGetter, ExpirationPolicy expirationPolicy)
		: this(entryTimeToLiveGetter, TimeSpan.FromSeconds(1.0), expirationPolicy)
	{
	}

	public ExpirableDictionary(Func<TimeSpan> entryTimeToLiveGetter, TimeSpan traversalInterval, ExpirationPolicy expirationPolicy)
	{
		_TraversalInterval = traversalInterval;
		_ExpirationPolicy = expirationPolicy;
		_TimeToLiveGetter = entryTimeToLiveGetter ?? throw new ArgumentNullException("entryTimeToLiveGetter");
		_Timer = new Timer(TraverseAndPurge, null, traversalInterval, traversalInterval);
	}

	public void Clear()
	{
		_Entries = new ConcurrentDictionary<TKey, ExpirableValue>();
	}

	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
	{
		ExpirableValue expirableValue = _Entries.GetOrAdd(key, (TKey s) => new ExpirableValue(valueFactory(key), _TimeToLiveGetter()));
		if (_ExpirationPolicy == ExpirationPolicy.RenewOnRead)
		{
			expirableValue.ExtendExpiration(_TimeToLiveGetter());
		}
		return expirableValue.Value;
	}

	public void Set(TKey key, TValue value)
	{
		_Entries[key] = new ExpirableValue(value, _TimeToLiveGetter());
	}

	public TValue Remove(TKey key)
	{
		_Entries.TryRemove(key, out var removed);
		if (removed != null)
		{
			this.EntryRemoved?.Invoke(removed.Value, RemovalReason.ExplicitlyRemoved);
			return removed.Value;
		}
		return null;
	}

	public IEnumerable<TValue> GetValues()
	{
		DateTime now = DateTime.UtcNow;
		foreach (KeyValuePair<TKey, ExpirableValue> entry in _Entries)
		{
			ExpirableValue expirableValue = entry.Value;
			if (!expirableValue.IsExpired(now))
			{
				yield return expirableValue.Value;
			}
		}
	}

	public IEnumerable<TKey> GetKeys()
	{
		DateTime now = DateTime.UtcNow;
		foreach (KeyValuePair<TKey, ExpirableValue> keyValuePair in _Entries)
		{
			if (!keyValuePair.Value.IsExpired(now))
			{
				yield return keyValuePair.Key;
			}
		}
	}

	public TValue Get(TKey key)
	{
		if (_Entries.TryGetValue(key, out var expirableValue))
		{
			if (_ExpirationPolicy == ExpirationPolicy.RenewOnRead)
			{
				expirableValue.ExtendExpiration(_TimeToLiveGetter());
			}
			return expirableValue.Value;
		}
		return null;
	}

	/// <summary>
	/// Check if the key exists.  Will not extend expiration.
	/// </summary>
	/// <param name="key"></param>
	/// <returns>True if the key exists</returns>
	public bool ContainsKey(TKey key)
	{
		return _Entries.ContainsKey(key);
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
				_Timer?.Dispose();
			}
			_Timer = null;
			_Disposed = true;
		}
	}

	private void TraverseAndPurge(object timer)
	{
		_Timer.Change(-1, -1);
		try
		{
			this.PreTraversal?.Invoke();
			DateTime now = DateTime.UtcNow;
			foreach (KeyValuePair<TKey, ExpirableValue> keyValuePair in _Entries)
			{
				ExpirableValue expirableValue = keyValuePair.Value;
				this.EntryTraversed?.Invoke(expirableValue.Value, now);
				if (expirableValue.IsExpired(now))
				{
					_Entries.TryRemove(keyValuePair.Key, out var _);
					this.EntryRemoved?.Invoke(expirableValue.Value, RemovalReason.Expired);
				}
			}
			this.TraversalComplete?.Invoke();
		}
		catch (Exception ex)
		{
			if (this.ExceptionOccurred != null)
			{
				try
				{
					this.ExceptionOccurred(ex);
				}
				catch
				{
				}
			}
		}
		_Timer.Change(_TraversalInterval, _TraversalInterval);
	}
}
