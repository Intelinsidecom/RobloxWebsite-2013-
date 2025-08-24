using System;
using Roblox.PremiumFeatures.Entities;
using Roblox.PremiumFeatures.Interfaces.Entities;
using Roblox.PremiumFeatures.Interfaces.EntityFactories;

namespace Roblox.PremiumFeatures;

/// <summary>
/// The entity factory for <see cref="T:Roblox.PremiumFeatures.Entities.RobuxStipendFrequencyTypeEntity" />
/// </summary>
public class RobuxStipendFrequencyTypeEntityFactory : IRobuxStipendFrequencyTypeEntityFactory
{
	/// <summary>
	/// Gets a <see cref="T:Roblox.PremiumFeatures.Entities.RobuxStipendFrequencyTypeEntity" /> by ID
	/// </summary>
	public IRobuxStipendFrequencyTypeEntity Get(byte id)
	{
		return CachedMssql(RobuxStipendFrequencyTypeEntity.Get(id));
	}

	/// <summary>
	/// Gets a <see cref="T:Roblox.PremiumFeatures.Entities.RobuxStipendFrequencyTypeEntity" /> by value
	/// </summary>
	public IRobuxStipendFrequencyTypeEntity GetByValue(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return CachedMssql(RobuxStipendFrequencyTypeEntity.GetByValue(value));
	}

	private static IRobuxStipendFrequencyTypeEntity CachedMssql(RobuxStipendFrequencyTypeEntity frequencyTypeEntity)
	{
		if (frequencyTypeEntity != null)
		{
			return new RobuxStipendFrequencyTypeCachedMssqlEntity
			{
				Id = frequencyTypeEntity.ID,
				Value = frequencyTypeEntity.Value,
				Created = (frequencyTypeEntity.CreatedUtc ?? DateTime.UtcNow),
				Updated = (frequencyTypeEntity.UpdatedUtc ?? DateTime.UtcNow)
			};
		}
		return null;
	}
}
