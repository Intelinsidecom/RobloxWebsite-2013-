using Roblox.Platform.Core;
using Roblox.Platform.Studio.Entities;

namespace Roblox.Platform.Studio;

internal class ToolboxSearchAlgorithmResultEntityFactory : IToolboxSearchAlgorithmResultEntityFactory, IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	public StudioDomainFactories DomainFactories { get; }

	public ToolboxSearchAlgorithmResultEntityFactory(StudioDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IToolboxSearchAlgorithmResultEntity Create(int algorithmId, string keyword, long[] result)
	{
		Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithmResult.GetByAlgorithmIDAndKeyword(algorithmId, keyword)?.Delete();
		Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithmResult toolboxSearchAlgorithmResult = new Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithmResult();
		toolboxSearchAlgorithmResult.AlgorithmID = algorithmId;
		toolboxSearchAlgorithmResult.Keyword = keyword;
		toolboxSearchAlgorithmResult.Results = result;
		toolboxSearchAlgorithmResult.Save();
		return CalToCachedMssql(toolboxSearchAlgorithmResult);
	}

	public IToolboxSearchAlgorithmResultEntity Get(long id)
	{
		return CalToCachedMssql(Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithmResult.Get(id));
	}

	public IToolboxSearchAlgorithmResultEntity GetByAlgorithmIdAndKeyword(int algorithmId, string keyword)
	{
		if (algorithmId == 0)
		{
			throw new PlatformArgumentException(string.Format("{0} can not be 0.", "algorithmId"));
		}
		if (string.IsNullOrEmpty(keyword))
		{
			throw new PlatformArgumentException(string.Format("{0} can not be null or empty.", "keyword"));
		}
		return CalToCachedMssql(Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithmResult.GetByAlgorithmIDAndKeyword(algorithmId, keyword));
	}

	private static IToolboxSearchAlgorithmResultEntity CalToCachedMssql(Roblox.Platform.Studio.Entities.ToolboxSearchAlgorithmResult cal)
	{
		if (cal != null)
		{
			return new ToolboxSearchAlgorithmResultCachedMssqlEntity
			{
				Id = cal.ID,
				AlgorithmId = cal.AlgorithmID,
				Keyword = cal.Keyword,
				Results = cal.Results,
				Created = cal.Created
			};
		}
		return null;
	}
}
