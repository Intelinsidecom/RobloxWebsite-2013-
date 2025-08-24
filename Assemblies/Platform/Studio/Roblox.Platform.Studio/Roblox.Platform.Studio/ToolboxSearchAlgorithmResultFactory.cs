using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

internal class ToolboxSearchAlgorithmResultFactory : IToolboxSearchAlgorithmResultFactory, IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	public StudioDomainFactories DomainFactories { get; }

	public ToolboxSearchAlgorithmResultFactory(StudioDomainFactories studioDomainFactories)
	{
		if (studioDomainFactories == null)
		{
			throw new PlatformArgumentNullException("studioDomainFactories");
		}
		DomainFactories = studioDomainFactories;
	}

	public IToolboxSearchAlgorithmResult Create(string algorithmName, string keyword, long[] ids)
	{
		if (string.IsNullOrEmpty(algorithmName))
		{
			throw new PlatformArgumentNullException("algorithmName");
		}
		if (string.IsNullOrEmpty(keyword))
		{
			throw new PlatformArgumentNullException("keyword");
		}
		if (ids == null || ids.Length == 0)
		{
			throw new PlatformArgumentNullException("ids");
		}
		IToolboxSearchAlgorithmEntity algorithm = DomainFactories.ToolboxSearchAlgorithmEntityFactory.Get(algorithmName);
		if (algorithm == null)
		{
			throw new Exception($"Algorithm name {algorithmName} does not exist.");
		}
		IToolboxSearchAlgorithmResultEntity res = DomainFactories.ToolboxSearchAlgorithmResultEntityFactory.Create(algorithm.Id, keyword, ids);
		IToolboxSearchAlgorithmResult algoResult = null;
		if (res != null)
		{
			algoResult = new ToolboxSearchAlgorithmResult(res.Id, res.AlgorithmId, res.Keyword, res.Results);
		}
		return algoResult;
	}

	public IToolboxSearchAlgorithmResult GetByAlgorithmNameAndKeyword(string algorithmName, string keyword)
	{
		if (string.IsNullOrEmpty(algorithmName))
		{
			throw new PlatformArgumentNullException("algorithmName");
		}
		if (string.IsNullOrEmpty(keyword))
		{
			throw new PlatformArgumentNullException("keyword");
		}
		IToolboxSearchAlgorithmEntity algorithm = DomainFactories.ToolboxSearchAlgorithmEntityFactory.Get(algorithmName);
		if (algorithm == null)
		{
			throw new Exception($"Algorithm name {algorithmName} does not exist.");
		}
		return GetByAlgorithmIdAndKeyword(algorithm.Id, keyword);
	}

	public IToolboxSearchAlgorithmResult GetByAlgorithmIdAndKeyword(int algorithmId, string keyword)
	{
		if (algorithmId == 0)
		{
			throw new PlatformArgumentException("algorithmId");
		}
		if (string.IsNullOrEmpty(keyword))
		{
			throw new PlatformArgumentNullException("keyword");
		}
		IToolboxSearchAlgorithmResultEntity res = DomainFactories.ToolboxSearchAlgorithmResultEntityFactory.GetByAlgorithmIdAndKeyword(algorithmId, keyword);
		IToolboxSearchAlgorithmResult algoResult = null;
		if (res != null)
		{
			algoResult = new ToolboxSearchAlgorithmResult(res.Id, res.AlgorithmId, res.Keyword, res.Results);
		}
		return algoResult;
	}
}
