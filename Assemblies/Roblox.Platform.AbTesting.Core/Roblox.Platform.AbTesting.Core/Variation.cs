using System;
using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

internal class Variation : IVariation
{
	public int Id { get; internal set; }

	public int ExperimentId { get; internal set; }

	public int Value { get; internal set; }

	public int PercentEnrollments { get; internal set; }

	public byte VersionNumber { get; internal set; }

	public DateTime Created { get; internal set; }

	public DateTime Updated { get; internal set; }

	public Variation()
	{
	}

	internal Variation(Roblox.Platform.AbTesting.Core.Entities.Variation entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Id = entity.ID;
		ExperimentId = entity.ExperimentID;
		Value = entity.Value;
		PercentEnrollments = entity.PercentEnrollments;
		VersionNumber = entity.Version;
		Created = entity.Created;
		Updated = entity.Updated;
	}

	public virtual void Save()
	{
		Roblox.Platform.AbTesting.Core.Entities.Variation entity = Roblox.Platform.AbTesting.Core.Entities.Variation.Get(Id) ?? new Roblox.Platform.AbTesting.Core.Entities.Variation();
		entity.Version = VersionNumber;
		entity.PercentEnrollments = PercentEnrollments;
		entity.Value = Value;
		entity.ExperimentID = ExperimentId;
		entity.Save();
		Id = entity.ID;
		Created = entity.Created;
		Updated = entity.Updated;
	}
}
