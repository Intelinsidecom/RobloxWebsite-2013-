using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class StatusCachedMssqlEntity : IStatusEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long GroupId { get; set; }

	public long PosterId { get; set; }

	public string Message { get; set; }

	public DateTime Updated { get; set; }

	public DateTime Created { get; set; }

	public void Update()
	{
		GroupStatus cal = GroupStatus.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.GroupID = GroupId;
		cal.PosterID = PosterId;
		cal.Message = Message;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(GroupStatus.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
