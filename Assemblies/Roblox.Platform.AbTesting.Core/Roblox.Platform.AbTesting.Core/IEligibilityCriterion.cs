using System;

namespace Roblox.Platform.AbTesting.Core;

internal interface IEligibilityCriterion
{
	int Id { get; }

	int ExperimentId { get; }

	int EligibilityCriterionTypeId { get; }

	DateTime Created { get; }

	void Delete();
}
