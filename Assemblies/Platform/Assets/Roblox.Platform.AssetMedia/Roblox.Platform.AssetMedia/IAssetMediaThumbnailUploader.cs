using System;
using System.IO;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;
using Roblox.Thumbs;

namespace Roblox.Platform.AssetMedia;

public interface IAssetMediaThumbnailUploader
{
	/// <summary>
	/// Requests a model thumbnail to be generated.
	/// </summary>
	/// <param name="asset">The model.</param>
	ThumbResult GenerateModelImage(Asset asset);

	/// <summary>
	/// Creates an auto-generated thumbnail of the asset.
	/// Meant to be used for models, hasn't been tested with places.
	/// If the asset already has an 'Image' AssetMedia, a new version is created.
	/// If there is no AssetMedia, a new one is created.
	/// The newly created image has to go through moderation before it becomes visible.
	/// </summary>
	/// <param name="asset">The asset that needs an auto-generated thumbnail</param>
	/// <param name="authenticatedUser"></param>
	/// <returns></returns>
	/// <exception cref="T:System.ApplicationException">Thrown if thumbnail generation takes longer than the allowed limit</exception>
	void UploadGeneratedAssetMediaImageAsync(Asset asset, IUser authenticatedUser);

	/// <summary>
	/// Uploads and sets the <paramref name="imageStream" /> as an image asset.
	/// </summary>
	/// <remarks>
	/// Creates an AssetMedia or PlaceMedia based on the new image asset, that is tied to <paramref name="asset" />.
	/// </remarks>
	/// <param name="imageStream">The stream being uploaded into an image asset.</param>
	/// <param name="asset">The asset that will have the media tied to it.</param>
	/// <param name="user">The user performing the action.</param>
	/// <param name="isPlace">Whether or not <paramref name="asset" /> is a place.</param>
	/// <returns>The uploaded <see cref="T:Roblox.Platform.Assets.IImage" />.</returns>
	[Obsolete("Please call UploadAssetMediaImage with IAsset and call AddAssetMediaImage right after.")]
	IImage UploadAssetMediaImage(Stream imageStream, Asset asset, IUser user, bool isPlace);

	/// <summary>
	/// Uploads an <paramref name="imageStream" /> as an image asset for an <see cref="T:Roblox.Platform.Assets.IAsset" />.
	/// </summary>
	/// <param name="imageStream">The stream being uploaded into an image asset.</param>
	/// <param name="asset">The asset that will have the media tied to it.</param>
	/// <param name="user">The user performing the action.</param>
	/// <returns>The uploaded <see cref="T:Roblox.Platform.Assets.IImage" />.</returns>
	IImage UploadAssetMediaImage(Stream imageStream, Roblox.Platform.Assets.IAsset asset, IUser user);

	/// <summary>
	/// Adds an <see cref="T:Roblox.Platform.Assets.IImage" /> as asset media for an <see cref="T:Roblox.Platform.Assets.IAsset" />.
	/// </summary>
	/// <param name="asset">The <see cref="T:Roblox.Platform.Assets.IAsset" />.</param>
	/// <param name="image">The <see cref="T:Roblox.Platform.Assets.IImage" />.</param>
	/// <param name="user">The user performing the action.</param>
	void AddAssetMediaImage(Roblox.Platform.Assets.IAsset asset, IImage image, IUser user);
}
