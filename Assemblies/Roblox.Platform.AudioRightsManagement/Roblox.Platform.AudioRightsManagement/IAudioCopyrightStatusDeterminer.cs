using Roblox.Platform.Assets;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// Fetches and determines an audio's copyright status using external systems and saves it within our system.
/// Should not be used to simply fetch information about an audio asset, use an <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader" /> for that instead.
/// </summary>
public interface IAudioCopyrightStatusDeterminer
{
	/// <summary>
	/// Determines the audio copyright, including basic validity and whether the content's rights are protected.
	/// Saves this information in our own datastores.
	/// </summary>
	/// <param name="assetVersion">The audio <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> to check.</param>
	/// <returns>whether the audio's copyright is protected</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersion" /></exception>
	bool DetermineAudioVersionCopyrightStatus(IAssetVersion assetVersion);

	/// <summary>
	/// Determines the audio file status, including basic validity and whether the content's rights are protected.
	/// Saves this information in our own datastores.
	/// </summary>
	/// <param name="assetVersion">The audio <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> to check.</param>
	/// <returns>whether the audio's copyright is protected</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersion" /></exception>
	AudioCopyrightStatus DetermineAudioVersionFileStatus(IAssetVersion assetVersion);
}
