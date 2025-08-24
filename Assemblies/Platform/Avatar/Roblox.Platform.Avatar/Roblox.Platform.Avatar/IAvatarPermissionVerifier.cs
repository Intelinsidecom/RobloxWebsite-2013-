namespace Roblox.Platform.Avatar;

public interface IAvatarPermissionVerifier
{
	bool TryOnEnabledForNonPurchasableAssets();
}
