using System;

namespace Roblox.Platform.AssetOwnership;

public interface IUnlocker
{
	bool Unlock(Guid guid);
}
