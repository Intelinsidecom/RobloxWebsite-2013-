using System;
using Roblox.LeasedLocks.Client;
using Roblox.Locking.Properties;

namespace Roblox.Locking;

public class LeasedLock
{
	private static readonly ILeasedLocksClient _LeasedLocksClient = new LeasedLocksClient(() => Settings.Default.LeasedLocksServiceApiKeyShim);

	private readonly string _LockKey;

	public LeasedLock(string lockKey)
	{
		_LockKey = lockKey;
	}

	public bool TryAcquire(Guid lockRequester, int leaseDurationInMilliseconds)
	{
		return _LeasedLocksClient.TryAcquire(LeasedLockType.Mssql, _LockKey, lockRequester, TimeSpan.FromMilliseconds(leaseDurationInMilliseconds));
	}

	public bool TryRelease(Guid lockHolder)
	{
		return _LeasedLocksClient.TryRelease(LeasedLockType.Mssql, _LockKey, lockHolder);
	}

	public bool TryRenew(Guid lockRequester, int leaseDurationInMilliseconds)
	{
		return _LeasedLocksClient.TryRenew(LeasedLockType.Mssql, _LockKey, lockRequester, TimeSpan.FromMilliseconds(leaseDurationInMilliseconds));
	}

	public static LeasedLock GetOrCreate(string lockKey)
	{
		lockKey = lockKey.Substring(0, (lockKey.Length < 100) ? lockKey.Length : 100);
		return new LeasedLock(lockKey);
	}
}
