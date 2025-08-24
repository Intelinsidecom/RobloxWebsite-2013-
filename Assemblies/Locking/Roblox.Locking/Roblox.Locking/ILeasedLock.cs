using System;

namespace Roblox.Locking;

public interface ILeasedLock : IDisposable
{
	bool IsLockAcquired { get; }
}
