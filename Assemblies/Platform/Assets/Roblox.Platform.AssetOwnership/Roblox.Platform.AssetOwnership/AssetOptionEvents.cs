using System;

namespace Roblox.Platform.AssetOwnership;

public static class AssetOptionEvents
{
	public static event Action<IUserAssetOption> AssetOptionEntityCreated;

	public static event Action<IUserAssetOption> AssetOptionEntityUpdated;

	internal static void OnAssetOptionCreated(IUserAssetOption obj)
	{
		if (obj != null)
		{
			AssetOptionEvents.AssetOptionEntityCreated?.Invoke(obj);
		}
	}

	internal static void OnAssetOptionUpdated(IUserAssetOption obj)
	{
		if (obj != null)
		{
			AssetOptionEvents.AssetOptionEntityUpdated?.Invoke(obj);
		}
	}
}
