using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Studio.Entities;

namespace Roblox.Platform.Studio;

internal class ToolboxSearchAlgorithmEntityFactory : IToolboxSearchAlgorithmEntityFactory, IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	public StudioDomainFactories DomainFactories { get; }

	public ToolboxSearchAlgorithmEntityFactory(StudioDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IToolboxSearchAlgorithmEntity Get(string name)
	{
		return CalToCachedMssql(Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithm.GetByName(name));
	}

	public IToolboxSearchAlgorithmEntity Create(string name, string description)
	{
		Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithm toolboxSearchAlgorithm = new Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithm();
		toolboxSearchAlgorithm.Name = name;
		toolboxSearchAlgorithm.Desciption = description;
		toolboxSearchAlgorithm.Save();
		return CalToCachedMssql(toolboxSearchAlgorithm);
	}

	public IEnumerable<IToolboxSearchAlgorithmEntity> GetAllPaged(int startRowIndex, int maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithm.GetToolboxSearchAlgorithmsPaged(startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	private static IToolboxSearchAlgorithmEntity CalToCachedMssql(Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithm cal)
	{
		if (cal != null)
		{
			return new ToolboxSearchAlgorithmCachedMssqlEntity
			{
				Id = cal.ID,
				Name = cal.Name,
				Description = cal.Desciption,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
