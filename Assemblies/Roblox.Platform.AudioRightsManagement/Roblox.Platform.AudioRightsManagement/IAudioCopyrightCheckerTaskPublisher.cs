using Roblox.Platform.Assets;

namespace Roblox.Platform.AudioRightsManagement;

public interface IAudioCopyrightCheckerTaskPublisher
{
	/// <summary>
	/// Publishes an <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> of an audio <see cref="T:Roblox.Platform.Assets.IAsset" /> to the queue for a copyright check.
	/// </summary>
	/// <param name="assetVersion"></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersion" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="assetVersion" /> is not an audio asset.</exception>
	/// <exception cref="T:System.InvalidOperationException">sns publisher issues</exception>
	void PublishTaskForAudioAssetVersion(IAssetVersion assetVersion);
}
