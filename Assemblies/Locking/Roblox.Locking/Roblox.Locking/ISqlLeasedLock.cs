using System;

namespace Roblox.Locking;

public interface ISqlLeasedLock : ILeasedLock, IDisposable
{
	void ForceDispose();
}
