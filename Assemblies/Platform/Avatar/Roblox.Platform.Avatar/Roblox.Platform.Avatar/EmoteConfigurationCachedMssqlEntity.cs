using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Avatar;

[ExcludeFromCodeCoverage]
internal class EmoteConfigurationCachedMssqlEntity : IEmoteConfigurationEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long AssetId { get; set; }

	public long UserId { get; set; }

	public byte Position { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		EmoteConfigurationEntity cal = EmoteConfigurationEntity.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AssetID = AssetId;
		cal.UserID = UserId;
		cal.Position = Position;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(EmoteConfigurationEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
