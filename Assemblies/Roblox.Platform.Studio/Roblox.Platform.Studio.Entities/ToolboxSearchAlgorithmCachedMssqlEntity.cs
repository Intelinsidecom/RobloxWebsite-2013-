using System;
using Roblox.Entities;

namespace Roblox.Platform.Studio.Entities;

internal class ToolboxSearchAlgorithmCachedMssqlEntity : IToolboxSearchAlgorithmEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		ToolboxSearchAlgorithm cal = ToolboxSearchAlgorithm.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Name = Name;
		cal.Desciption = Description;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(ToolboxSearchAlgorithm.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
