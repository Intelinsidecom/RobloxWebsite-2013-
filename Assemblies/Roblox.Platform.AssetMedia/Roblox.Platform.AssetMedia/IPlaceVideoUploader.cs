using Roblox.Platform.Assets;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Handles adding YouTube videos to places.
/// </summary>
public interface IPlaceVideoUploader
{
	/// <summary>
	/// Adds a YouTube video media item to a place, which includes charging the user for the cost of adding
	/// a YouTube video item.
	/// </summary>
	/// <param name="place">Place to add the video to.</param>
	/// <param name="actingUser">The user performing the action.</param>
	/// <param name="youTubeVideoUrl">YouTube video URL.</param>
	/// <param name="initiatingPlatformType">Platform from which the action was initiated.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="place" />
	/// - <paramref name="actingUser" />
	/// - <paramref name="youTubeVideoUrl" />
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
	/// <exception cref="T:Roblox.Platform.VirtualCurrency.InsufficientFundsException">
	/// Thrown if the user does not have sufficient funds to purchase the video.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">
	/// Thrown if the purchase transaction could not complete.
	/// </exception>
	void AddPlaceVideo(IPlace place, IUser actingUser, string youTubeVideoUrl, PlatformType initiatingPlatformType);
}
