using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

internal class ToolboxSearchAlgorithmFactory : IToolboxSearchAlgorithmFactory, IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	public StudioDomainFactories DomainFactories { get; }

	public ToolboxSearchAlgorithmFactory(StudioDomainFactories studioDomainFactories)
	{
		if (studioDomainFactories == null)
		{
			throw new PlatformArgumentNullException("studioDomainFactories");
		}
		DomainFactories = studioDomainFactories;
	}

	public IToolboxSearchAlgorithm Create(string algorithmName, string description)
	{
		if (string.IsNullOrEmpty(algorithmName))
		{
			throw new PlatformArgumentNullException("algorithmName");
		}
		IToolboxSearchAlgorithmEntity res = DomainFactories.ToolboxSearchAlgorithmEntityFactory.Create(algorithmName, description);
		IToolboxSearchAlgorithm algo = null;
		if (res != null)
		{
			algo = new ToolboxSearchAlgorithm(res.Id, res.Name, res.Description);
		}
		return algo;
	}

	public IEnumerable<IToolboxSearchAlgorithm> GetAllPaged(int startRowIndex, int maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		IEnumerable<IToolboxSearchAlgorithmEntity> res = DomainFactories.ToolboxSearchAlgorithmEntityFactory.GetAllPaged(startRowIndex, maxRows);
		IEnumerable<IToolboxSearchAlgorithm> algoList = null;
		if (res != null)
		{
			algoList = res.Select((IToolboxSearchAlgorithmEntity a) => new ToolboxSearchAlgorithm(a.Id, a.Name, a.Description));
		}
		return algoList;
	}
}
