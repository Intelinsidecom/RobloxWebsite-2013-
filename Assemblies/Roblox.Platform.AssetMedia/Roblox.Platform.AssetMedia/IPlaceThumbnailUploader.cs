using System.IO;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Provides methods for adding place thumbnails.
/// </summary>
public interface IPlaceThumbnailUploader
{
	/// <summary>
	/// Adds a generated place thumbnail.
	/// </summary>
	/// <param name="place">Place to add the generated thumbnail to.</param>
	/// <param name="actingUser">The user that performs the operation.</param>
	/// <returns>Place thumbnail.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///  - <paramref name="place" />
	///  - <paramref name="actingUser" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the generated place thumbnail is not available</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">If there are too many thumbnail upload requests.</exception>
	IPlaceThumbnail AddGeneratedPlaceThumbnail(IPlace place, IUser actingUser);

	/// <summary>
	/// Adds a custom place thumbnail.
	/// </summary>
	/// <param name="place">Place the add the thumbnail to.</param>
	/// <param name="actingUser">The user that performs the operation.</param>
	/// <param name="imageData">A stream containing image data.</param>
	/// <returns>Place icon.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///  - <paramref name="place" />
	///  - <paramref name="actingUser" />
	///  - <paramref name="imageData" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">If there are too many icon upload requests.</exception>
	/// <exception cref="T:System.IO.InvalidDataException">If the image data stream is in an invalid format.</exception>
	IPlaceThumbnail AddPlaceThumbnail(IPlace place, IUser actingUser, Stream imageData);
}
