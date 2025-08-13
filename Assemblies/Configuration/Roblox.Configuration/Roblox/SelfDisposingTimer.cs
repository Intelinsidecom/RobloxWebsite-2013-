using System;
using System.Threading;

namespace Roblox;

public class SelfDisposingTimer
{
	private readonly Action _Action;

	private Timer _Timer;

	private TimeSpan _Period;

	public SelfDisposingTimer(Action action, TimeSpan startTime, TimeSpan period)
	{
		_Action = action;
		_Period = period;
		_Timer = new Timer(delegate(object weakThis)
		{
			OnTimer((WeakReference)weakThis);
		}, new WeakReference(this), startTime, period);
	}

	private static void OnTimer(WeakReference self)
	{
		(self.Target as SelfDisposingTimer)?._Action();
	}

	public bool Change(TimeSpan dueTime, TimeSpan period)
	{
		_Period = period;
		return _Timer.Change(dueTime, period);
	}

	public void Stop()
	{
		_Timer.Dispose();
		_Timer = null;
	}

	~SelfDisposingTimer()
	{
		_Timer?.Dispose();
	}

	internal void Pause()
	{
		_Timer.Change(-1, -1);
	}

	internal void Unpause()
	{
		_Timer.Change(_Period, _Period);
	}
}
