using System;

namespace Roblox.Caching;

public class LazyWithRetry<T> : ILazyWithRetry<T>
{
	private readonly TimeSpan _TimeoutBetweenRetries = TimeSpan.FromSeconds(30.0);

	private Lazy<T> _Lazy;

	private readonly object _Sync;

	private readonly Func<T> _ValueFactory;

	private readonly Func<DateTime> _NowGetter;

	private DateTime? _LastExceptionTimeStamp;

	public bool IsValueCreated => _Lazy.IsValueCreated;

	public T Value
	{
		get
		{
			try
			{
				return _Lazy.Value;
			}
			catch (Exception)
			{
				bool flag = false;
				lock (_Sync)
				{
					if (!_LastExceptionTimeStamp.HasValue)
					{
						_LastExceptionTimeStamp = _NowGetter();
					}
					else
					{
						DateTime value = _NowGetter();
						DateTime? dateTime = _LastExceptionTimeStamp + _TimeoutBetweenRetries;
						if (value > dateTime)
						{
							Reset();
							flag = true;
						}
					}
				}
				if (flag)
				{
					return _Lazy.Value;
				}
				throw;
			}
		}
	}

	public LazyWithRetry(Func<T> valueFactory, Func<DateTime> nowGetter = null)
	{
		_ValueFactory = valueFactory ?? throw new ArgumentNullException("valueFactory");
		_Lazy = new Lazy<T>(_ValueFactory);
		_Sync = new object();
		_NowGetter = nowGetter ?? ((Func<DateTime>)(() => DateTime.UtcNow));
	}

	public LazyWithRetry(Func<T> valueFactory, TimeSpan timeoutBetweenRetries, Func<DateTime> nowGetter = null)
		: this(valueFactory, nowGetter)
	{
		_TimeoutBetweenRetries = timeoutBetweenRetries;
	}

	public void Reset()
	{
		_Lazy = new Lazy<T>(_ValueFactory);
		_LastExceptionTimeStamp = null;
	}
}
