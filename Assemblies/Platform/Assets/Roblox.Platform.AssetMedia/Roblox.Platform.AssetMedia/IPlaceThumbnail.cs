namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Represents a place thumbnail.
/// </summary>
public interface IPlaceThumbnail
{
	/// <summary>
	/// The identifier of the place thumbnail.
	/// </summary>
	long Id { get; }

	/// <summary>
	/// The identifier of the place this thumbnail belongs to.
	/// </summary>
	long PlaceId { get; }

	/// <summary>
	/// The identifier of the corresponding image asset.
	/// </summary>
	long ImageId { get; }
}
