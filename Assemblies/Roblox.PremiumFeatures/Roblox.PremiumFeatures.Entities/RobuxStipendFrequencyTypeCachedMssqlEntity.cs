using System;
using Roblox.Entities;
using Roblox.PremiumFeatures.Interfaces.Entities;

namespace Roblox.PremiumFeatures.Entities;

internal class RobuxStipendFrequencyTypeCachedMssqlEntity : IRobuxStipendFrequencyTypeEntity, IUpdateableEntity<byte>, IEntity<byte>
{
	public byte Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		RobuxStipendFrequencyTypeEntity frequencyTypeEntity = RobuxStipendFrequencyTypeEntity.Get(Id);
		if (frequencyTypeEntity == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		frequencyTypeEntity.Value = Value;
		frequencyTypeEntity.Save();
		Updated = frequencyTypeEntity.UpdatedUtc ?? DateTime.UtcNow;
	}

	public void Delete()
	{
		(RobuxStipendFrequencyTypeEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
