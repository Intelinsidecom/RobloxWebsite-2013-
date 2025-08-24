using System;
using System.Diagnostics;

namespace BeIT.MemCached;

internal class RateLimiter : IRateLimiter
{
	private readonly Func<bool> _IsEnabledGetter;

	private readonly Func<TimeSpan> _PeriodLengthGetter;

	private readonly Func<int> _OperationsPerPeriodGetter;

	private readonly object _InstanceLock = new object();

	private Stopwatch _PeriodStartwatch;

	private int _OperationsInPeriod;

	public RateLimiter(Func<bool> isEnabledGetter, Func<TimeSpan> periodLengthGetter, Func<int> operationsPerPeriodGetter)
	{
		_IsEnabledGetter = isEnabledGetter ?? throw new ArgumentNullException("isEnabledGetter");
		_PeriodLengthGetter = periodLengthGetter ?? throw new ArgumentNullException("periodLengthGetter");
		_OperationsPerPeriodGetter = operationsPerPeriodGetter ?? throw new ArgumentNullException("operationsPerPeriodGetter");
	}

	public bool TryOperation()
	{
		if (!_IsEnabledGetter())
		{
			return true;
		}
		TimeSpan timeSpan = _PeriodLengthGetter();
		int num = _OperationsPerPeriodGetter();
		lock (_InstanceLock)
		{
			if (_PeriodStartwatch == null || _PeriodStartwatch.Elapsed > timeSpan)
			{
				_PeriodStartwatch = Stopwatch.StartNew();
				_OperationsInPeriod = 1;
				return true;
			}
			if (_OperationsInPeriod >= num)
			{
				return false;
			}
			_OperationsInPeriod++;
			return true;
		}
	}
}
