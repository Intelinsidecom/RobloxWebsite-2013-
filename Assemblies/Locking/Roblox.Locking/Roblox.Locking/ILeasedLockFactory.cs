using System;

namespace Roblox.Locking;

public interface ILeasedLockFactory
{
	ILeasedLock CreateLeasedLock(string lockKey, TimeSpan leaseDuration, Action<Exception> exceptionHandler = null);
}
