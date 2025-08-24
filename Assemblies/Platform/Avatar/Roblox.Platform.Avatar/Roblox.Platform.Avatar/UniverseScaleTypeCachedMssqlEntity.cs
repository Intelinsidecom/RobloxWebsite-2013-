using System;
using Roblox.Entities;

namespace Roblox.Platform.Avatar;

internal class UniverseScaleTypeCachedMssqlEntity : IUniverseScaleTypeEntity, IEntity<byte>
{
	public byte Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		UniverseScaleType cal = UniverseScaleType.Get(Id);
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
		(UniverseScaleType.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
