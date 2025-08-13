using System;
using Roblox.Entities;

namespace Roblox.Platform.Assets.Entities.AssetHash;

internal class AssetHashEntity : IAssetHashEntity, IEntity<long>
{
	public long Id { get; set; }

	public int AssetTypeId { get; set; }

	public string Hash { get; set; }

	public bool IsApproved { get; set; }

	public bool IsReviewed { get; set; }

	public long CreatorId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Delete()
	{
		(Roblox.AssetHash.Get(Id) ?? throw new InvalidOperationException("Attempted update on unpersisted entity.")).Delete();
	}

	public void SetApproval(bool isApproved, bool isReviewed)
	{
		Roblox.AssetHash cal = Roblox.AssetHash.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.SetApproval(isApproved, isReviewed);
		IsApproved = cal.IsApproved;
		IsReviewed = cal.IsReviewed;
		Updated = cal.Updated;
	}
}
