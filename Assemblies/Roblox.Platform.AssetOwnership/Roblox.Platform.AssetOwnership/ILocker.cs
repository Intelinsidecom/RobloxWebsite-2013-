using Roblox.Ownership.Client;

namespace Roblox.Platform.AssetOwnership;

internal interface ILocker
{
	ILockResult Lock(long userAssetId);
}
