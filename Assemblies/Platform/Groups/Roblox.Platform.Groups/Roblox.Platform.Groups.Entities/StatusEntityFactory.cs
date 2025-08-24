using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class StatusEntityFactory : IStatusEntityFactory
{
	public IStatusEntity Get(long id)
	{
		return CalToCachedMssql(GroupStatus.Get(id));
	}

	public IStatusEntity GetByGroupId(long groupId)
	{
		return CalToCachedMssql(GroupStatus.GetGroupStatusByGroupID(groupId));
	}

	private static IStatusEntity CalToCachedMssql(GroupStatus cal)
	{
		if (cal != null)
		{
			return new StatusCachedMssqlEntity
			{
				Id = cal.ID,
				GroupId = cal.GroupID,
				PosterId = cal.PosterID,
				Message = cal.Message,
				Updated = cal.Updated,
				Created = cal.Created
			};
		}
		return null;
	}

	public IStatusEntity UpdateOrCreate(long groupId, long userId, string message)
	{
		GroupStatus obj = GroupStatus.GetGroupStatusByGroupID(groupId) ?? new GroupStatus
		{
			GroupID = groupId
		};
		obj.PosterID = userId;
		obj.Message = message;
		obj.Save();
		return CalToCachedMssql(obj);
	}
}
