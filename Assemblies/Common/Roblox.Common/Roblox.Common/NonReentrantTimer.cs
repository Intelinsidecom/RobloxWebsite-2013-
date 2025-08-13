using System;
using System.Threading;

namespace Roblox.Common;

public class NonReentrantTimer : MarshalByRefObject, IDisposable
{
	private readonly Timer _Timer;

	private readonly TimerCallback _Callback;

	private TimerCallback _SkipExecutionCallback;

	private int _Count;

	public TimerCallback SkipExecutionCallback
	{
		get
		{
			return _SkipExecutionCallback;
		}
		set
		{
			_SkipExecutionCallback = value;
		}
	}

	private NonReentrantTimer(TimerCallback callback)
	{
		_Callback = callback;
		_Count = 0;
		_SkipExecutionCallback = null;
	}

	public NonReentrantTimer(TimerCallback callback, object state, int dueTime, int period)
		: this(callback)
	{
		_Timer = new Timer(InternalCallback, state, dueTime, period);
	}

	public NonReentrantTimer(TimerCallback callback, object state, long dueTime, long period)
		: this(callback)
	{
		_Timer = new Timer(InternalCallback, state, dueTime, period);
	}

	public NonReentrantTimer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period)
		: this(callback)
	{
		_Timer = new Timer(InternalCallback, state, dueTime, period);
	}

	public NonReentrantTimer(TimerCallback callback, object state, uint dueTime, uint period)
		: this(callback)
	{
		_Timer = new Timer(InternalCallback, state, dueTime, period);
	}

	public bool Change(int dueTime, int period)
	{
		return _Timer.Change(dueTime, period);
	}

	public bool Change(long dueTime, long period)
	{
		return _Timer.Change(dueTime, period);
	}

	public bool Change(TimeSpan dueTime, TimeSpan period)
	{
		return _Timer.Change(dueTime, period);
	}

	public bool Change(uint dueTime, uint period)
	{
		return _Timer.Change(dueTime, period);
	}

	private void InternalCallback(object state)
	{
		try
		{
			if (Interlocked.Increment(ref _Count) == 1)
			{
				_Callback(state);
			}
			else if (_SkipExecutionCallback != null)
			{
				_SkipExecutionCallback(state);
			}
		}
		finally
		{
			Interlocked.Decrement(ref _Count);
		}
	}

	public bool Dispose(WaitHandle notifyObject)
	{
		if (_Timer != null)
		{
			return _Timer.Dispose(notifyObject);
		}
		return false;
	}

	public void Dispose()
	{
		if (_Timer != null)
		{
			_Timer.Dispose();
		}
	}
}
