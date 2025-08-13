using System;
using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core.Implementation;

internal class LockedOnExperimentSetting : ILockedOnExperimentSetting
{
	public int Id { get; private set; }

	public int ExperimentId { get; private set; }

	public byte? LockedOnVariationValue { get; set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Core.Implementation.LockedOnExperimentSetting" /> class from the given <see cref="T:Roblox.Platform.AbTesting.Core.Entities.LockedOnExperimentSetting" />.
	/// </summary>
	/// <param name="entity">The <see cref="T:Roblox.Platform.AbTesting.Core.Entities.LockedOnExperimentSetting" /> to construct the <see cref="T:Roblox.Platform.AbTesting.Core.Implementation.LockedOnExperimentSetting" /> from.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="entity" /> is null.</exception>
	internal LockedOnExperimentSetting(Roblox.Platform.AbTesting.Core.Entities.LockedOnExperimentSetting entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Id = entity.ID;
		ExperimentId = entity.ExperimentID;
		LockedOnVariationValue = entity.LockedOnVariationValue;
		Created = entity.Created;
		Updated = entity.Updated;
	}

	public virtual void Save()
	{
		Roblox.Platform.AbTesting.Core.Entities.LockedOnExperimentSetting entity = Roblox.Platform.AbTesting.Core.Entities.LockedOnExperimentSetting.GetOrCreate(ExperimentId);
		entity.LockedOnVariationValue = LockedOnVariationValue;
		entity.Save();
		Id = entity.ID;
		Created = entity.Created;
		Updated = entity.Updated;
	}
}
