namespace Roblox.Platform.Assets;

internal interface IAssetVersionCreationEventPublisher
{
	void Publish(IAssetVersion assetVersion, string localeCodeOverride = null);
}
