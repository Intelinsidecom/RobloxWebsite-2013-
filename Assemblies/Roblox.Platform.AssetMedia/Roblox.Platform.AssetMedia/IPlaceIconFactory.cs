namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Manages place icons.
/// </summary>
public interface IPlaceIconFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AssetMedia.IPlaceIcon" /> with the given placeId.  This will always get a <see cref="T:Roblox.Platform.AssetMedia.IPlaceIcon" /> even where none exist.  This behavior is necessary in order to call <see cref="!:IPlaceIcon.GetGameIconThumbResult(int,int,System.Drawing.Imaging.ImageFormat)" /> on a place that has no icon.
	/// </summary>
	/// <param name="placeId"></param>
	/// <returns>The <see cref="T:Roblox.Platform.AssetMedia.IPlaceIcon" /> for the given placeId.  If the place has no respective <see cref="T:Roblox.Platform.AssetMedia.IPlaceIcon" />, a new one will be returned.</returns>
	IPlaceIcon GetPlaceIconByPlaceId(long placeId);

	/// <summary>
	/// Deletes the provided <see cref="T:Roblox.Platform.AssetMedia.IPlaceIcon" />.  This will modify the passed in instance by resetting it to a new <see cref="T:Roblox.Platform.AssetMedia.IPlaceIcon" />.  This is again to provide access to <see cref="!:IPlaceIcon.GetGameIconThumbResult(int,int,System.Drawing.Imaging.ImageFormat)" /> on a freshly deleted <see cref="T:Roblox.Platform.AssetMedia.IPlaceIcon" />.
	/// </summary>
	/// <param name="placeIcon"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="placeIcon" /> is null.</exception>
	void DeletePlaceIcon(ref IPlaceIcon placeIcon);

	/// <summary>
	/// Saves the provided <see cref="T:Roblox.Platform.AssetMedia.IPlaceIcon" />.  This will modify the passed in instance by updating its fields to match those in the database (necessary for Updated, Created, etc).
	/// </summary>
	/// <param name="placeIcon"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="placeIcon" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="placeIcon" />'s 'ImageId' property is null.</exception>
	void SavePlaceIcon(ref IPlaceIcon placeIcon);

	/// <summary>
	/// Determines if a place has a place icon.
	/// </summary>
	/// <param name="placeId">Place to test for the presence of the icon.</param>
	/// <returns>True if the place has an icon or false - otherwise.</returns>
	bool ContainsPlaceIcon(long placeId);
}
