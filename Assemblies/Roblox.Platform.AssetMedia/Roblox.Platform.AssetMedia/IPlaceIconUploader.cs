using System.IO;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Provides method for adding place icons.
/// </summary>
public interface IPlaceIconUploader
{
	/// <summary>
	/// Sets an icon generated from the place contents. If the place already has an icon, the existing icon is replaced
	/// with the auto-generated one.
	/// </summary>
	/// <param name="place">A place for which to set the icon.</param>
	/// <param name="actingUser">The user that performs the operation.</param>
	/// <returns>Place icon.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///  - <paramref name="place" />
	///  - <paramref name="actingUser" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the generated place icon is not available</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">If there are too many icon upload requests.</exception>
	IPlaceIcon SetGeneratedPlaceIcon(IPlace place, IUser actingUser);

	/// <summary>
	/// Sets a custom icon. If the place already has an icon, the existing icon is replaced with the provided image.
	/// </summary>
	/// <param name="place">A place for which to set the icon.</param>
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
	IPlaceIcon SetPlaceIcon(IPlace place, IUser actingUser, Stream imageData);
}
