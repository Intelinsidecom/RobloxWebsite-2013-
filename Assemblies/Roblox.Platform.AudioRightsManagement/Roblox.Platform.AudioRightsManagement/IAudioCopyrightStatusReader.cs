using System.Collections.Generic;
using Roblox.Platform.Assets;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// Validates an audio <see cref="T:Roblox.Platform.Assets.IAsset" />'s copyright status using the records in our system.
/// </summary>
public interface IAudioCopyrightStatusReader
{
	/// <summary>
	/// Returns whether the audio's rights are protected and therefore whether we have to block it on our platform.
	/// Checks the latest version of this asset.
	/// </summary>
	/// <param name="asset">The audio's <see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <returns>whether the rights are protected</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="asset" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="asset" /> is not audio.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="asset" /> does not have a current version.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="asset" />'s <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> does not have a valid raw content.</exception>
	bool IsAudioCopyrightProtected(IAsset asset);

	/// <summary>
	/// Returns whether the audio's rights are protected and therefore whether we have to block it on our platform.
	/// Checks a specific version.
	/// </summary>
	/// <param name="assetVersion">The audio's <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> to check.</param>
	/// <returns>whether the rights are protected</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersion" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="assetVersion" /> is not audio.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="assetVersion" /> does not have a valid raw content.</exception>
	bool IsAudioCopyrightProtected(IAssetVersion assetVersion);

	/// <summary>
	/// Returns whether the audio's rights are protected and therefore whether we have to block it on our platform.
	/// Checks a specific version.
	/// </summary>
	/// <param name="rawContent">The audio's <see cref="T:Roblox.Platform.Assets.IRawContent" /> to check.</param>
	/// <returns>whether the rights are protected</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="rawContent" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="rawContent" /> is not audio.</exception>
	bool IsAudioCopyrightProtected(IRawContent rawContent);

	/// <summary>
	/// Returns all <see cref="T:Roblox.Platform.Assets.IRawContent" /> containing copyrighted audio. These have to be blocked on our platform.
	/// </summary>
	/// <param name="rawContents">An <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of all <see cref="T:Roblox.Platform.Assets.IRawContent" />s, we'd like to check</param>
	/// <returns>All <c>blocked</c> <see cref="T:Roblox.Platform.Assets.IRawContent" />s. The order is <c>not</c> defined.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="rawContents" /></exception>
	/// <exception cref="T:System.ArgumentException">any <see cref="T:Roblox.Platform.Assets.IRawContent" /> in <paramref name="rawContents" /> is not audio.</exception>
	IReadOnlyCollection<IRawContent> GetCopyrightProtectedAudio(IReadOnlyCollection<IRawContent> rawContents);
}
