using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

/// <summary>
/// A typed asset factory interface for YouTube videos.
/// </summary>
public interface IYouTubeVideoFactory : IAssetFactoryBase<IYouTubeVideo>
{
	/// <summary>
	/// Creates a YouTube video asset.
	/// </summary>
	/// <param name="assetNameAndDescription">Asset name and description.</param>
	/// <param name="assetCreatorInfo">Asset creator.</param>
	/// <param name="youTubeVideoId">Video id on YouTube.</param>
	/// <param name="actorUserIdentity">User performing the operation.</param>
	/// <returns>YouTube video asset instance.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="assetNameAndDescription" />
	/// - <paramref name="assetCreatorInfo" />
	/// - <paramref name="youTubeVideoId" />
	/// - <paramref name="actorUserIdentity" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.LongDescriptionException">
	/// Thrown if the video description is too long.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException">
	/// Thrown if the video description was fully moderated.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Assets.VideoDisapprovedException">
	/// Thrown if this video was previously uploaded and was moderated.
	/// </exception>
	IYouTubeVideo CreateYouTubeVideo(AssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, string youTubeVideoId, IUserIdentifier actorUserIdentity);
}
