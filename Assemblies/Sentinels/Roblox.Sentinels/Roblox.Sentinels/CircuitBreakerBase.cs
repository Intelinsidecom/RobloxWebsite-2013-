using System;
using System.Threading;

namespace Roblox.Sentinels;

public abstract class CircuitBreakerBase : ICircuitBreaker
{
	private int _IsTripped;

	protected internal abstract string Name { get; }

	protected internal DateTime? Tripped { get; private set; }

	protected virtual DateTime Now => DateTime.UtcNow;

	public bool IsTripped => _IsTripped == 1;

	public virtual bool Reset()
	{
		bool num = Interlocked.Exchange(ref _IsTripped, 0) == 1;
		if (num)
		{
			Tripped = null;
		}
		return num;
	}

	public virtual void Test()
	{
		if (IsTripped)
		{
			throw new CircuitBreakerException(this);
		}
	}

	public virtual bool Trip()
	{
		bool num = Interlocked.Exchange(ref _IsTripped, 1) == 1;
		if (!num)
		{
			Tripped = Now;
		}
		return num;
	}
}
