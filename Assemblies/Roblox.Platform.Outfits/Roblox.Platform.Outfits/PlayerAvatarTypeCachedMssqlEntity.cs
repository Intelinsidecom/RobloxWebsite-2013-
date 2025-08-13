using System;
using Roblox.Entities;

namespace Roblox.Platform.Outfits;

internal class PlayerAvatarTypeCachedMssqlEntity : IPlayerAvatarTypeEntity, IEntity<byte>
{
	public byte Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		PlayerAvatarTypeEntity cal = PlayerAvatarTypeEntity.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Value = Value;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(PlayerAvatarTypeEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
