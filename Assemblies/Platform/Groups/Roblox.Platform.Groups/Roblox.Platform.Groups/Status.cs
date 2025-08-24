using System;
using Roblox.Platform.Groups.Entities;

namespace Roblox.Platform.Groups;

internal class Status : IStatus
{
	public long GroupId { get; }

	public long PosterId { get; }

	public string Message { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public Status(IStatusEntity entity)
	{
		GroupId = entity.GroupId;
		PosterId = entity.PosterId;
		Message = entity.Message;
		Created = entity.Created;
		Updated = entity.Updated;
	}
}
