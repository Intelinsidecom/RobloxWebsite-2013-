using System;
using Roblox.Platform.Groups.Entities;

namespace Roblox.Platform.Groups;

internal class WallPost : IWallPost
{
	public long Id { get; }

	public long GroupId { get; }

	public long UserId { get; }

	public string Value { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public WallPost(IWallPostEntity entity)
	{
		Id = entity.Id;
		GroupId = entity.GroupId;
		UserId = entity.UserId;
		Value = entity.Value;
		Created = entity.Created;
		Updated = entity.Updated;
	}
}
