using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

internal class EligibilityCriterionType : IEligibilityCriterionType
{
	public int Id { get; set; }

	public string Value { get; set; }

	internal EligibilityCriterionType(Roblox.Platform.AbTesting.Core.Entities.EligibilityCriterionType entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Id = entity.ID;
		Value = entity.Value;
	}

	internal EligibilityCriterionType()
	{
	}
}
