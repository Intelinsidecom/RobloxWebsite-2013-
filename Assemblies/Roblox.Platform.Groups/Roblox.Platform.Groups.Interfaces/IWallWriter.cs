using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups.Interfaces;

/// <summary>
/// An interface for a class that writes to <see cref="T:Roblox.Platform.Groups.IWall" /> object
/// </summary>
public interface IWallWriter
{
	/// <summary>
	/// Creates a post on the wall, authored by an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <remarks>
	/// <paramref name="message" /> will be filtered, trimmed, and truncated before posting.
	/// </remarks>
	/// <param name="wall">The <see cref="T:Roblox.Platform.Groups.IWall" />.</param>
	/// <param name="group''">The <see cref="T:Roblox.Platform.Groups.IGroup" />.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="message">The post content.</param>
	/// <returns>The new <see cref="T:Roblox.Platform.Groups.IWallPost" />.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="user" /> is null.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="message" /> is null, whitespace.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Floodcheck reached for wall posting.</exception>
	IWallPost Post(IWall wall, IUser user, string message);

	/// <summary>
	/// Deletes a post, performed by the specified user.
	/// </summary>
	/// <param name="wallPost">The <see cref="T:Roblox.Platform.Groups.IWallPost" /> being deleted.</param>
	/// <param name="group''">The Wall's<see cref="T:Roblox.Platform.Groups.IGroup" />.</param>
	/// <param name="actorUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> deleting the post.</param>
	void DeletePost(IWallPost wallPost, IGroup group, IUser actorUser);

	/// <summary>
	/// Deletes all posts made by a specified <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="actorUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> deleting all the posts.</param>
	/// /// <param name="group''">The Wall's<see cref="T:Roblox.Platform.Groups.IGroup" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	void DeleteAllPostsByUser(IUser user, IUser actorUser, IGroup group);
}
