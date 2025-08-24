using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.Platform.Core;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class WallPostEntityFactory : IWallPostEntityFactory
{
	public IWallPostEntity Get(long id)
	{
		return CalToCachedMssql(GroupWallPost.Get(id));
	}

	public IEnumerable<IWallPostEntity> GetByGroupIdPaged(long groupId, int startRowIndex, int maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return GroupWallPost.GetGroupWallPostsByGroupIDPaged(groupId, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public IEnumerable<IWallPostEntity> GetByGroupId(long groupId, int count, long? exclusiveStartId, SortOrder sortOrder)
	{
		return GroupWallPost.GetGroupWallPostsByGroupId(groupId, count, exclusiveStartId, sortOrder.Equals(SortOrder.Asc) ? SortOrder.Asc : SortOrder.Desc).Select(CalToCachedMssql);
	}

	public int GetTotalByGroupId(long groupId)
	{
		return GroupWallPost.GetTotalNumberOfGroupWallPostsByGroupID(groupId);
	}

	private static IWallPostEntity CalToCachedMssql(GroupWallPost cal)
	{
		if (cal != null)
		{
			return new WallPostCachedMssqlEntity
			{
				Id = cal.ID,
				GroupId = cal.GroupID,
				UserId = cal.UserID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}

	public IWallPostEntity Create(long groupId, long userId, string value)
	{
		GroupWallPost groupWallPost = new GroupWallPost();
		groupWallPost.GroupID = groupId;
		groupWallPost.UserID = userId;
		groupWallPost.Value = value;
		groupWallPost.Save();
		return CalToCachedMssql(groupWallPost);
	}

	public IEnumerable<IWallPostEntity> GetTopPostsByGroupIdPaged(long userId, long groupId, int maxRows)
	{
		return GroupWallPost.GetTopGroupWallPostsByUserIDAndGroupID(userId, groupId, maxRows).Select(CalToCachedMssql);
	}
}
