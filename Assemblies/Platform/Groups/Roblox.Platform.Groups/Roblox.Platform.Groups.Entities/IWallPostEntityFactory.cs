using System;
using System.Collections.Generic;
using Roblox.DataV2.Core;

namespace Roblox.Platform.Groups.Entities;

internal interface IWallPostEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Groups.Entities.IWallPostEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Groups.Entities.IWallPostEntity" /> with the given ID, or null if none existed.</returns>
	IWallPostEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Groups.Entities.IWallPostEntity" />s by their TODO: Fill in.
	/// </summary>
	/// TODO: Add params
	/// <param name="groupId">The groupId to get.</param>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// TODO: Add other exceptions
	/// <returns>The page of <see cref="T:Roblox.Platform.Groups.Entities.IWallPostEntity" />s.</returns>
	[Obsolete("Please use GetByGroupId instead.")]
	IEnumerable<IWallPostEntity> GetByGroupIdPaged(long groupId, int startRowIndex, int maxRows);

	/// <summary>
	/// Gets a list of <see cref="T:Roblox.Platform.Groups.Entities.IWallPostEntity" />s by their group id.
	/// </summary>
	/// <param name="groupId">The group id.</param>
	/// <param name="count">The max amount of <see cref="T:Roblox.Platform.Groups.Entities.IWallPostEntity" />s to return.</param>
	/// <param name="exclusiveStartId">The exclusive start id.</param>
	/// <param name="sortOrder">The sort order.</param>
	/// <returns>
	///   <see cref="T:System.Collections.Generic.IEnumerable`1" />
	/// </returns>
	IEnumerable<IWallPostEntity> GetByGroupId(long groupId, int count, long? exclusiveStartId, SortOrder sortOrder);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Groups.Entities.IWallPostEntity" />s with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Add params
	/// TODO: Add other exceptions
	/// <returns>The total number of <see cref="T:Roblox.Platform.Groups.Entities.IWallPostEntity" />s with the given TODO: Fill in characteristics.</returns>
	int GetTotalByGroupId(long groupId);

	IWallPostEntity Create(long groupId, long userId, string value);

	IEnumerable<IWallPostEntity> GetTopPostsByGroupIdPaged(long userId, long groupId, int maxRows);
}
