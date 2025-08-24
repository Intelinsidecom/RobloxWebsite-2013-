using System;

namespace Roblox.Platform.AssetMedia.Properties;

/// <summary>
/// Asset media settings.
/// </summary>
public interface ISettings
{
	/// <summary>
	/// Whether it is allowed to remove the default thumbnail generated for an asset.
	/// </summary>
	bool IsDefaultCameraGeneratedThumbnailRemovalEnabled { get; }

	/// <summary>
	/// Maximum allowed asset image width or height.
	/// </summary>
	int MaximumUploadedImageWidthOrHeight { get; }

	/// <summary>
	/// Width of generated asset thumbnails, in pixels.
	/// </summary>
	int GeneratedThumbnailWidth { get; }

	/// <summary>
	/// Height of generated asset thumbnails, in pixels.
	/// </summary>
	int GeneratedThumbnailHeight { get; }

	/// <summary>
	/// The timeout for default thumbnail generation.
	/// </summary>
	TimeSpan DefaultCameraGeneratedThumbnailTimeout { get; }

	/// <summary>
	/// The timeout for downloading generated images.
	/// </summary>
	TimeSpan DownloadImageTimeout { get; }

	/// <summary>
	/// The maximum allowed length of YouTube videos, in seconds.
	/// </summary>
	int MaximumYouTubeVideoUploadLengthInSeconds { get; }

	/// <summary>
	/// The price of YouTube media items.
	/// </summary>
	long YouTubeVideoPurchasePrice { get; }

	/// <summary>
	/// Whether adding YouTube videos as game thumbnails is disabled for users under 13.
	/// </summary>
	bool IsVideoThumbnailUploadDisabledForUnder13Users { get; }
}
