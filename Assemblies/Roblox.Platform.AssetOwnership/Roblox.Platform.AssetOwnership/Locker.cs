using System;
using Roblox.Ownership.Client;

namespace Roblox.Platform.AssetOwnership;

internal class Locker : ILocker
{
	private OwnershipV1UserAssetFactory _Ov1 { get; }

	public Locker(OwnershipV1UserAssetFactory ov1)
	{
		_Ov1 = ov1 ?? throw new ArgumentNullException("ov1");
	}

	public ILockResult Lock(long userAssetId)
	{
		return _Ov1.Lock(userAssetId);
	}
}
