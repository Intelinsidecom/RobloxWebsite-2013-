using System;

namespace Roblox.Locking;

public class RedisLeasedLockFactory : IRedisLeasedLockFactory, ILeasedLockFactory
{
	ILeasedLock ILeasedLockFactory.CreateLeasedLock(string lockKey, TimeSpan leaseDuration, Action<Exception> exceptionHandler = null)
	{
		return CreateLeasedLock(lockKey, leaseDuration, exceptionHandler);
	}

	public IRedisLeasedLock CreateLeasedLock(string lockKey, TimeSpan leaseDuration, Action<Exception> exceptionHandler = null)
	{
		return new RedisLeasedLock(lockKey, leaseDuration, exceptionHandler);
	}
}
