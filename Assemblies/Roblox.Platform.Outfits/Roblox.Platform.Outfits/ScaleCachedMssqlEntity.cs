using System;
using Roblox.Entities;

namespace Roblox.Platform.Outfits;

internal class ScaleCachedMssqlEntity : IScaleEntity, IEntity<int>
{
	public int Id { get; set; }

	public decimal Height { get; set; }

	public decimal Width { get; set; }

	public decimal Head { get; set; }

	public decimal Proportion { get; set; }

	public decimal BodyType { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(ScaleEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
