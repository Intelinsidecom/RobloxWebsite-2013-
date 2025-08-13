namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Implements <see cref="T:Roblox.Platform.AssetMedia.IPlaceThumbnail" />
/// </summary>
public class PlaceThumbnail : IPlaceThumbnail
{
	/// <inheritdoc cref="P:Roblox.Platform.AssetMedia.IPlaceThumbnail.Id" />
	public long Id { get; internal set; }

	/// <inheritdoc cref="P:Roblox.Platform.AssetMedia.IPlaceThumbnail.PlaceId" />
	public long PlaceId { get; internal set; }

	/// <inheritdoc cref="P:Roblox.Platform.AssetMedia.IPlaceThumbnail.ImageId" />
	public long ImageId { get; internal set; }
}
