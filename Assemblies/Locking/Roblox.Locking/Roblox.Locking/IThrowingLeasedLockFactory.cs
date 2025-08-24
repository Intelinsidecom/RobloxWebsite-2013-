using System;

namespace Roblox.Locking;

public interface IThrowingLeasedLockFactory : ILeasedLockFactory
{
	ILeasedLock CreateLeasedLockAndThrowOnFailure(string lockKey, TimeSpan leaseDuration);
}
