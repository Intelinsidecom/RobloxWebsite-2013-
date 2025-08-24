using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AbTesting.Core.Entities;

namespace Roblox.Platform.AbTesting.Core;

public class EligibilityCriterionTypeFactory : IEligibilityCriterionTypeFactory
{
	public IEnumerable<IEligibilityCriterionType> GetAllEligibilityCriterionTypes()
	{
		List<IEligibilityCriterionType> eligibilityCriterionTypes = new List<IEligibilityCriterionType>();
		int startRowIndex = 1;
		List<Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterionType> page = Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterionType.GetEligibilityCriterionTypesPaged(startRowIndex, 10).ToList();
		eligibilityCriterionTypes.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterionType entity) => new EligibilityCriterionType(entity)));
		while (page.Count == 10)
		{
			startRowIndex += 10;
			page = Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterionType.GetEligibilityCriterionTypesPaged(startRowIndex, 10).ToList();
			eligibilityCriterionTypes.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterionType entity) => new EligibilityCriterionType(entity)));
		}
		return eligibilityCriterionTypes;
	}

	public IEligibilityCriterionType GetById(int id)
	{
		Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterionType entity = Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterionType.Get(id);
		if (entity == null)
		{
			return null;
		}
		return new EligibilityCriterionType(entity);
	}

	public IEnumerable<IEligibilityCriterionType> GetByExperimentId(int experimentId)
	{
		return from c in GetAllByExperimentId(experimentId)
			select Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterionType.Get(c.EligibilityCriterionTypeId) into t
			select new EligibilityCriterionType(t);
	}

	private IEnumerable<IEligibilityCriterion> GetAllByExperimentId(int experimentId)
	{
		List<IEligibilityCriterion> eligibilityCriteria = new List<IEligibilityCriterion>();
		int startRowIndex = 1;
		List<Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion> page = Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion.GetEligibilityCriteriaByExperimentIDPaged(experimentId, startRowIndex, 10L).ToList();
		eligibilityCriteria.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion entity) => new EligibilityCriterion(entity)));
		while (page.Count == 10)
		{
			startRowIndex += 10;
			page = Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion.GetEligibilityCriteriaByExperimentIDPaged(experimentId, startRowIndex, 10L).ToList();
			eligibilityCriteria.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterion entity) => new EligibilityCriterion(entity)));
		}
		return eligibilityCriteria;
	}
}
