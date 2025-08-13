using System;

namespace Roblox.Locking;

public abstract class ThrowingLeasedLockFactory : IThrowingLeasedLockFactory, ILeasedLockFactory
{
	public abstract ILeasedLock CreateLeasedLock(string lockKey, TimeSpan leaseDuration, Action<Exception> exceptionHandler = null);

	public ILeasedLock CreateLeasedLockAndThrowOnFailure(string lockKey, TimeSpan leaseDuration)
	{
		ILeasedLock leasedLock = CreateLeasedLock(lockKey, leaseDuration, delegate(Exception e)
		{
			throw new LeasedLockException(e);
		});
		if (!leasedLock.IsLockAcquired)
		{
			leasedLock.Dispose();
			throw new LeasedLockException();
		}
		return leasedLock;
	}
}
