namespace Roblox.Platform.AssetOwnership;

internal interface IAssetOwnershipObserver
{
	void OnExecutionStarted(AssetOwnershipActionEventArgs e);

	void OnExecutionFinished(AssetOwnershipActionEventArgs e);
}
