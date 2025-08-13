using System.IO;
using System.Net;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Badges;

/// <summary>
/// A factory for creating <see cref="!:IBadge" /> icons
/// </summary>
public interface IBadgeIconFactory
{
	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Assets.IImage" /> shaped for <see cref="!:IBadge" /> icons.
	/// </summary>
	/// <remarks>
	/// The image uploaded from the <see cref="T:System.IO.Stream" /> gets reshaped into a circular format.
	/// </remarks>
	/// <param name="creator">The <see cref="T:Roblox.Platform.Membership.IUser" /> creating the badge icon.</param>
	/// <param name="name">The <see cref="!:IBadge" /> icon <see cref="T:Roblox.Platform.Assets.IImage" /> name.</param>
	/// <param name="imageFile">The file <see cref="T:System.IO.Stream" /> with the icon image.</param>
	/// <param name="imageFileDecompressionMethods">The <see cref="T:System.Net.DecompressionMethods" /> on the <paramref name="imageFile" />.</param>
	/// <returns>The <see cref="!:IBadge" /> <see cref="T:Roblox.Platform.Assets.IImage" /> icon.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="creator" />, <paramref name="imageFile" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="name" /> is null, whitespace, or longer than <see cref="P:Roblox.Platform.Badges.Properties.ISettings.MaxBadgeIconNameLength" />.</exception>
	/// <exception cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException"><paramref name="name" /> was fully moderated.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Failed to create badge image due to service error. (e.g. text filtering service unavailable.)</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException"><paramref name="creator" /> is has hit the image upload floodcheck.</exception>
	IImage CreateBadgeIcon(IUser creator, string name, Stream imageFile, DecompressionMethods imageFileDecompressionMethods);
}
