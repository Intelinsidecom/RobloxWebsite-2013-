using System;

namespace Roblox.Locking;

public class SqlLeasedLockFactory : ThrowingLeasedLockFactory
{
	protected Guid Requestor;

	public SqlLeasedLockFactory(Guid guid)
	{
		Requestor = guid;
	}

	public override ILeasedLock CreateLeasedLock(string lockKey, TimeSpan leaseDuration, Action<Exception> exceptionHandler = null)
	{
		return new SqlLeasedLock(lockKey, Requestor, leaseDuration, exceptionHandler);
	}
}
