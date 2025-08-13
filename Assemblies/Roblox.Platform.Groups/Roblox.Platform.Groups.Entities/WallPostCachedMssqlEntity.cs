using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class WallPostCachedMssqlEntity : IWallPostEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long GroupId { get; set; }

	public long UserId { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		GroupWallPost cal = GroupWallPost.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.GroupID = GroupId;
		cal.UserID = UserId;
		cal.Value = Value;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(GroupWallPost.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
