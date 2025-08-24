using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.LeasedLocks.Client;

public interface ILeasedLocksClient
{
	bool TryAcquire(LeasedLockType leasedLockType, string lockKey, Guid lockRequester, TimeSpan leaseDuration);

	Task<bool> TryAcquireAsync(LeasedLockType leasedLockType, string lockKey, Guid lockRequester, TimeSpan leaseDuration, CancellationToken token);

	bool TryRelease(LeasedLockType leasedLockType, string lockKey, Guid lockHolder);

	bool TryRenew(LeasedLockType leasedLockType, string lockKey, Guid lockRequester, TimeSpan leaseDuration);
}
