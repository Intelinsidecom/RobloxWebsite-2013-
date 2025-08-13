using System;
using System.Collections.Generic;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.Groups;

/// <summary>
/// A public interface for the Group Wall
///
/// The wall is a place where <seealso cref="T:Roblox.Platform.Groups.IWallPost" />s are made.  
/// Each group has its own wall.
/// </summary>
public interface IWall
{
	/// <summary>
	/// The group who owns the particular wall instance.
	/// </summary>
	IGroup Group { get; }

	/// <summary>
	/// The maximum length for a group wall post
	/// </summary>
	int MaxWallPostLength { get; }

	/// <summary>
	/// Gets a wall post specified by its id.
	///
	/// Returns null if no corresponding post is found, or if the post belongs to a different group.
	/// </summary>
	IWallPost GetPost(long wallPostId);

	/// <summary>
	/// Gets a page of wall posts for the group
	/// </summary>
	[Obsolete("Please use GetPosts instead.")]
	ICollection<IWallPost> GetPostsPaged(int startRowIndex, int maximumRows);

	/// <summary>
	/// Gets a list of <see cref="T:Roblox.Platform.Groups.IWallPost" />s for the group (<see cref="P:Roblox.Platform.Groups.IWall.Group" />.)
	/// </summary>
	/// <param name="exclusiveStartKeyInfo">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2" /></returns>
	IPlatformPageResponse<long, IWallPost> GetPosts(IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	/// <summary>
	/// Gets the total count of wall posts for the group
	/// </summary>
	int GetCount();
}
