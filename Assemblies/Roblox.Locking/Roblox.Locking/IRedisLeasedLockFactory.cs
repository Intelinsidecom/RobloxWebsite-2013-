using System;

namespace Roblox.Locking;

public interface IRedisLeasedLockFactory : ILeasedLockFactory
{
	new IRedisLeasedLock CreateLeasedLock(string lockKey, TimeSpan leaseDuration, Action<Exception> exceptionHandler = null);
}
