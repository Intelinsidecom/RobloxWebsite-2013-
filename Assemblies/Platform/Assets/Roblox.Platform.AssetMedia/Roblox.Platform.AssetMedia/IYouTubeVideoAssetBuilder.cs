using Roblox.Platform.Assets;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Builds YouTube video assets.
/// </summary>
public interface IYouTubeVideoAssetBuilder
{
	/// <summary>
	/// Creates a YouTube video asset from a YouTube video URL.
	/// </summary>
	/// <param name="youTubeVideoUrl">The video URL.</param>
	/// <param name="actingUser">User performing the action.</param>
	/// <returns>YouTube video asset.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="youTubeVideoUrl" />
	/// - <paramref name="actingUser" />
	/// </exception>
	/// <exception cref="T:System.UriFormatException">
	/// Thrown if the provided URL is syntactically invalid.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.AssetMedia.InvalidVideoException">
	/// Thrown if the provided URL is syntactically valid but does not refer to a valid video.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.AssetMedia.VideoDoesNotSupportEmbeddingException">
	/// Thrown if the video referred to by the provided URL does not support embedding.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.AssetMedia.VideoTooLongException">
	/// Thrown if the video duration is longer than the allowed limit.
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
	IYouTubeVideo CreateVideoAssetFromUrl(string youTubeVideoUrl, IUser actingUser);
}
