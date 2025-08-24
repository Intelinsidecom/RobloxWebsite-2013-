using System;

namespace Roblox.Platform.Assets.Places;

/// <summary>
/// A public interface for the factory producing <see cref="T:Roblox.Platform.Assets.Places.IPlaceAttribute" />s.
/// </summary>
public interface IPlaceAttributeFactory
{
	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Assets.Places.IPlaceAttribute" /> by its placeId.
	/// </summary>
	/// <param name="placeId"></param>
	/// <returns></returns>
	[Obsolete("Use `GetByPlace(IPlace place);` instead.")]
	IPlaceAttribute GetByPlaceId(long placeId);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Assets.Places.IPlaceAttribute" /> by its place.
	/// </summary>
	IPlaceAttribute GetByPlace(IPlace place);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Assets.Places.IPlaceAttribute" /> by its place Id, or if the PlaceAttribute doesn't exist, 
	/// creats a new <see cref="T:Roblox.Platform.Assets.Places.IPlaceAttribute" /> by the specified placeId
	/// </summary>
	[Obsolete("Use `GetOrCreate(IPlace place);` instead.")]
	IPlaceAttribute GetOrCreate(long placeId);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Assets.Places.IPlaceAttribute" /> by its place, or if the PlaceAttribute doesn't exist, 
	/// creates a new <see cref="T:Roblox.Platform.Assets.Places.IPlaceAttribute" /> by the specified place
	/// </summary>
	IPlaceAttribute GetOrCreate(IPlace place);
}
