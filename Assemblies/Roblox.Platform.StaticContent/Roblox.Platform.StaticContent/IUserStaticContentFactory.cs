using Roblox.Platform.Membership;

namespace Roblox.Platform.StaticContent;

/// <summary>
/// A factory for returning <see cref="!:IStaticContent" /> based on who is requesting it.
/// </summary>
public interface IUserStaticContentFactory
{
	/// <summary>
	/// Gets the latest enabled <see cref="T:Roblox.Platform.StaticContent.IContentPack" /> for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="component">The <see cref="T:Roblox.Platform.StaticContent.StaticContentComponent" />.</param>
	/// <returns>The latest enabled <see cref="T:Roblox.Platform.StaticContent.IContentPack" /> (or <c>null</c> if there isn't one.)</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
	/// - <paramref name="component" /> is invalid.
	/// </exception>
	IContentPack GetLatestContentPack(IUser user, StaticContentComponent component);
}
