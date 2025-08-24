using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.AssetMedia.Properties;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;
using Roblox.YouTube;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Implements <see cref="T:Roblox.Platform.AssetMedia.IYouTubeVideoAssetBuilder" />.
/// </summary>
public class YouTubeVideoAssetBuilder : IYouTubeVideoAssetBuilder
{
	internal class YouTubeVideoProperties
	{
		public string VideoID { get; set; }

		public bool SupportsEmbedding { get; set; }

		public int TotalSeconds { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }
	}

	private readonly ISettings _Settings;

	private readonly IYouTubeVideoFactory _YouTubeVideoFactory;

	/// <summary>
	/// Constructs <see cref="T:Roblox.Platform.AssetMedia.YouTubeVideoAssetBuilder" />
	/// </summary>
	/// <param name="settings">Asset media settings.</param>
	/// <param name="youTubeVideoFactory">An <see cref="T:Roblox.Platform.Assets.IYouTubeVideoFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="settings" />
	/// - <paramref name="youTubeVideoFactory" />
	/// </exception>
	public YouTubeVideoAssetBuilder(ISettings settings, IYouTubeVideoFactory youTubeVideoFactory)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_YouTubeVideoFactory = youTubeVideoFactory ?? throw new ArgumentNullException("youTubeVideoFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetMedia.IYouTubeVideoAssetBuilder.CreateVideoAssetFromUrl(System.String,Roblox.Platform.Membership.IUser)" />
	public IYouTubeVideo CreateVideoAssetFromUrl(string youTubeVideoUrl, IUser actingUser)
	{
		if (actingUser == null)
		{
			throw new ArgumentNullException("actingUser");
		}
		if (youTubeVideoUrl == null)
		{
			throw new ArgumentNullException("youTubeVideoUrl");
		}
		youTubeVideoUrl = youTubeVideoUrl.Trim();
		if (!youTubeVideoUrl.StartsWith("http"))
		{
			youTubeVideoUrl = "https://" + youTubeVideoUrl;
		}
		YouTubeVideoProperties video = LoadVideo(youTubeVideoUrl);
		if (video == null)
		{
			throw new InvalidVideoException("The video cannot be loaded");
		}
		if (!video.SupportsEmbedding)
		{
			throw new VideoDoesNotSupportEmbeddingException("The video does not support embedding");
		}
		if (video.TotalSeconds > _Settings.MaximumYouTubeVideoUploadLengthInSeconds)
		{
			throw new VideoTooLongException($"The video duration is longer than the allowed maximum of {_Settings.MaximumYouTubeVideoUploadLengthInSeconds} seconds");
		}
		AssetCreatorInfo assetCreatorInfo = new AssetCreatorInfo(Roblox.Platform.Assets.CreatorType.User, actingUser.Id);
		AssetNameAndDescription assetNameAndDescription = new AssetNameAndDescription(actingUser, video.Title, video.Description ?? string.Empty);
		return _YouTubeVideoFactory.CreateYouTubeVideo(assetNameAndDescription, assetCreatorInfo, video.VideoID, actingUser);
	}

	[ExcludeFromCodeCoverage]
	internal virtual YouTubeVideoProperties LoadVideo(string youTubeVideoUrl)
	{
		YouTubeVideo video = new YouTubeVideo(new Uri(youTubeVideoUrl));
		if (!video.LoadVideo())
		{
			return null;
		}
		return new YouTubeVideoProperties
		{
			VideoID = video.VideoID,
			SupportsEmbedding = video.SupportsEmbedding,
			TotalSeconds = video.TotalSeconds,
			Title = video.Title,
			Description = video.Description
		};
	}
}
