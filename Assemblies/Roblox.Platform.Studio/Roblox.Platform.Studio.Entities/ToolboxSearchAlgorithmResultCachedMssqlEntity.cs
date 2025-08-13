using System;

namespace Roblox.Platform.Studio.Entities;

internal class ToolboxSearchAlgorithmResultCachedMssqlEntity : IToolboxSearchAlgorithmResultEntity
{
	public long Id { get; set; }

	public int AlgorithmId { get; set; }

	public string Keyword { get; set; }

	public long[] Results { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(ToolboxSearchAlgorithmResult.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
