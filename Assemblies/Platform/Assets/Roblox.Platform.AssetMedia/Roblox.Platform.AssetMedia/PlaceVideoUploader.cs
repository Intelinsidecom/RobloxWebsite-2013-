using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.AssetMedia;
using Roblox.Platform.AssetMedia.Properties;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Implements <see cref="T:Roblox.Platform.AssetMedia.IPlaceVideoUploader" />
/// </summary>
public class PlaceVideoUploader : IPlaceVideoUploader
{
	private readonly ISettings _Settings;

	private readonly IYouTubeVideoAssetBuilder _YouTubeVideoAssetBuilder;

	private readonly IYouTubeVideoBroker _YouTubeVideoBroker;

	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.PlaceVideoUploader" />
	/// </summary>
	/// <param name="settings">Asset media settings.</param>
	/// <param name="youTubeVideoAssetBuilder">An <see cref="T:Roblox.Platform.AssetMedia.IYouTubeVideoAssetBuilder" />.</param>
	/// <param name="youTubeVideoBroker">An <see cref="T:Roblox.Platform.AssetMedia.IYouTubeVideoBroker" />.</param>
	/// <param name="assetOwnershipAuthority">An <see cref="T:Roblox.Platform.AssetOwnership.IAssetOwnershipAuthority" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="settings" />
	/// - <paramref name="youTubeVideoAssetBuilder" />
	/// - <paramref name="youTubeVideoBroker" />
	/// - <paramref name="assetOwnershipAuthority" />
	/// </exception>
	public PlaceVideoUploader(ISettings settings, IYouTubeVideoAssetBuilder youTubeVideoAssetBuilder, IYouTubeVideoBroker youTubeVideoBroker, IAssetOwnershipAuthority assetOwnershipAuthority)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_YouTubeVideoAssetBuilder = youTubeVideoAssetBuilder ?? throw new ArgumentNullException("youTubeVideoAssetBuilder");
		_YouTubeVideoBroker = youTubeVideoBroker ?? throw new ArgumentNullException("youTubeVideoBroker");
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new ArgumentNullException("assetOwnershipAuthority");
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetMedia.IPlaceVideoUploader.AddPlaceVideo(Roblox.Platform.Assets.IPlace,Roblox.Platform.Membership.IUser,System.String,Roblox.Platform.Devices.PlatformType)" />
	public void AddPlaceVideo(IPlace place, IUser actingUser, string youTubeVideoUrl, PlatformType initiatingPlatformType)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		if (actingUser == null)
		{
			throw new ArgumentNullException("actingUser");
		}
		if (youTubeVideoUrl == null)
		{
			throw new ArgumentNullException("youTubeVideoUrl");
		}
		long videoCostInRobux = _Settings.YouTubeVideoPurchasePrice;
		_YouTubeVideoBroker.PurchaseVideo(actingUser, initiatingPlatformType, videoCostInRobux, out var saleId);
		try
		{
			IYouTubeVideo videoAsset = _YouTubeVideoAssetBuilder.CreateVideoAssetFromUrl(youTubeVideoUrl, actingUser);
			AddPlaceMedia(place, videoAsset, actingUser);
			_AssetOwnershipAuthority.AwardAsset(videoAsset.Id, actingUser.Id);
		}
		catch
		{
			_YouTubeVideoBroker.RefundVideo(actingUser, videoCostInRobux, saleId);
			throw;
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual long AddPlaceMedia(IPlace place, Roblox.Platform.Assets.IAsset asset, IUser user)
	{
		return PlaceMediaManager.AddPlaceMedia(place.Id, asset.Id, user.Id).ID;
	}
}
