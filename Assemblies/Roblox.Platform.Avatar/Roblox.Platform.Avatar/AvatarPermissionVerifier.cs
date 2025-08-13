using Roblox.Platform.Avatar.Properties;

namespace Roblox.Platform.Avatar;

public class AvatarPermissionVerifier : IAvatarPermissionVerifier
{
	public AvatarPermissionVerifier()
	{
		_ = Settings.Default;
	}

	public bool TryOnEnabledForNonPurchasableAssets()
	{
		return Settings.Default.TryOnEnabledForNonPurchasableAssets;
	}
}
