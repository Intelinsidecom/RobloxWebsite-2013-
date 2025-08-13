using System;

namespace Roblox.Platform.AssetOwnership.Implementation;

internal class Unlocker : IUnlocker
{
	private OwnershipV1UserAssetFactory _Ov1 { get; }

	public Unlocker(OwnershipV1UserAssetFactory ov1)
	{
		_Ov1 = ov1 ?? throw new ArgumentNullException("ov1");
	}

	public bool Unlock(Guid token)
	{
		return _Ov1.Unlock(token);
	}
}
