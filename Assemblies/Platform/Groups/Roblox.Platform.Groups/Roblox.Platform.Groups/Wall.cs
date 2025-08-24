using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Groups.Entities;

namespace Roblox.Platform.Groups;

/// <inheritdoc />
internal class Wall : IWall
{
	private IWallPostEntityFactory _WallPostEntityFactory { get; }

	/// <inheritdoc cref="P:Roblox.Platform.Groups.IWall.MaxWallPostLength" />
	/// <remarks>
	/// This is the limit for a wall post in the database.
	/// If you update the schema for wall post lists please update this too.
	/// </remarks>
	public int MaxWallPostLength { get; } = 500;


	public IGroup Group { get; }

	public Wall(IWallPostEntityFactory wallPostEntityFactory, IGroup group)
	{
		_WallPostEntityFactory = wallPostEntityFactory ?? throw new PlatformArgumentNullException("wallPostEntityFactory");
		Group = group ?? throw new PlatformArgumentNullException("group");
	}

	public IWallPost GetPost(long wallPostId)
	{
		IWallPostEntity entity = _WallPostEntityFactory.Get(wallPostId);
		if (entity?.GroupId != Group.Id)
		{
			return null;
		}
		return new WallPost(entity);
	}

	public ICollection<IWallPost> GetPostsPaged(int startRowIndex, int maximumRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("startRowIndex");
		}
		if (maximumRows < 1)
		{
			throw new PlatformArgumentException("maximumRows");
		}
		return (from e in _WallPostEntityFactory.GetByGroupIdPaged(Group.Id, startRowIndex, maximumRows)
			where e.GroupId == Group.Id
			select new WallPost(e)).ToArray();
	}

	public IPlatformPageResponse<long, IWallPost> GetPosts(IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		return new PlatformPageResponse<long, IWallPost>((from e in _WallPostEntityFactory.GetByGroupId(Group.Id, exclusiveStartKeyInfo.Count + 1, exclusiveStartKeyInfo.GetNullableExclusiveStartKey(), exclusiveStartKeyInfo.GetDatabaseRequestSortOrder())
			select new WallPost(e)).Cast<IWallPost>().ToArray(), exclusiveStartKeyInfo, (IWallPost wp) => wp.Id);
	}

	public int GetCount()
	{
		return _WallPostEntityFactory.GetTotalByGroupId(Group.Id);
	}
}
