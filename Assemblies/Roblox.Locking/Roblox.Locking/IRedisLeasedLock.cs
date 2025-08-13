using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Locking;

public interface IRedisLeasedLock : ILeasedLock, IDisposable
{
	bool TryAcquire();

	Task<bool> TryAcquireAsync(CancellationToken token);
}
