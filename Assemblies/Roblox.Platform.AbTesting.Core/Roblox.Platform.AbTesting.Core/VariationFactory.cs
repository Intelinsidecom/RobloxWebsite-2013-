using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AbTesting.Core.Entities;

namespace Roblox.Platform.AbTesting.Core;

public class VariationFactory : IVariationFactory
{
	private static readonly VariationFactory _Instance = new VariationFactory();

	/// <summary>
	/// Gets a static instance of the <see cref="T:Roblox.Platform.AbTesting.Core.VariationFactory" /> class.
	/// </summary>
	public static VariationFactory Instance => _Instance;

	public IVariation GetById(int id)
	{
		Roblox.Platform.AbTesting.Core.Entities.Variation entity = Roblox.Platform.AbTesting.Core.Entities.Variation.Get(id);
		if (entity != null)
		{
			return new Variation(entity);
		}
		return null;
	}

	public IEnumerable<IVariation> GetByExperimentIdAndVersionNumber(int experimentId, byte versionNumber)
	{
		List<IVariation> variations = new List<IVariation>();
		int startRowIndex = 1;
		List<Roblox.Platform.AbTesting.Core.Entities.Variation> page = Roblox.Platform.AbTesting.Core.Entities.Variation.GetVariationsByExperimentIDAndVersionPaged(experimentId, versionNumber, startRowIndex, 10L).ToList();
		variations.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Variation entity) => new Variation(entity)));
		while (page.Count == 10)
		{
			startRowIndex += 10;
			page = Roblox.Platform.AbTesting.Core.Entities.Variation.GetVariationsByExperimentIDAndVersionPaged(experimentId, versionNumber, startRowIndex, 10L).ToList();
			variations.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Variation entity) => new Variation(entity)));
		}
		return variations;
	}
}
