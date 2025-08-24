using System;
using Roblox.Platform.Core;
using Roblox.Platform.Universes;
using Roblox.Thumbs;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Contains extensions methods on a <see cref="T:Roblox.Platform.Universes.IUniverse" />.
/// </summary>
public static class UniverseExtensions
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Thumbs.ThumbResult" /> for the <see cref="T:Roblox.Platform.Universes.IUniverse" />'s icon .
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" /> to get the icon for.</param>
	/// <param name="imageParameters">The <see cref="T:Roblox.Thumbs.ImageParameters" />.</param>
	/// <param name="placeIconFactory">The <see cref="T:Roblox.Platform.AssetMedia.IPlaceIconFactory" /> factory to use to get <see cref="T:Roblox.Platform.AssetMedia.IPlaceIcon" />s.</param>
	/// <returns>The <see cref="T:Roblox.Thumbs.ThumbResult" /> for the <see cref="T:Roblox.Platform.Universes.IUniverse" />'s icon.</returns>
	/// <exception cref="T:System.NullReferenceException">Thrown if <paramref name="universe" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="imageParameters" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="placeIconFactory" /> is null.</exception>
	public static ThumbResult GetIconThumbResult(this IUniverse universe, ImageParameters imageParameters, IPlaceIconFactory placeIconFactory)
	{
		if (universe == null)
		{
			throw new NullReferenceException();
		}
		if (imageParameters == null)
		{
			throw new PlatformArgumentNullException("imageParameters");
		}
		if (placeIconFactory == null)
		{
			throw new PlatformArgumentNullException("placeIconFactory");
		}
		return placeIconFactory.GetPlaceIconByPlaceId(universe.RootPlaceId ?? 0).GetGameIconThumbResult(imageParameters);
	}
}
