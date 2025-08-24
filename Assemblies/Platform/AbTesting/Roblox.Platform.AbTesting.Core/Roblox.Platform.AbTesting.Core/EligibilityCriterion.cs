using System;
using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

internal class EligibilityCriterion : IEligibilityCriterion
{
	public int Id { get; set; }

	public int ExperimentId { get; set; }

	public int EligibilityCriterionTypeId { get; set; }

	public DateTime Created { get; set; }

	internal EligibilityCriterion(Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Id = entity.ID;
		ExperimentId = entity.ExperimentID;
		Created = entity.Created;
		EligibilityCriterionTypeId = entity.EligibilityCriterionTypeID;
	}

	internal EligibilityCriterion()
	{
	}

	public virtual void Save()
	{
		Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion obj = Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion.Get(Id) ?? new Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion();
		obj.Created = Created;
		obj.EligibilityCriterionTypeID = EligibilityCriterionTypeId;
		obj.ExperimentID = ExperimentId;
		obj.Save();
	}

	public virtual void Delete()
	{
		Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion.Get(Id)?.Delete();
	}
}
