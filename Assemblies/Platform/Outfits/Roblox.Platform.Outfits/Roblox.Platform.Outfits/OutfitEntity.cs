using System;
using Roblox.Outfits;

namespace Roblox.Platform.Outfits;

internal class OutfitEntity : IOutfitEntity
{
	public long Id { get; set; }

	public long AssetHashId { get; set; }

	public long BodyColorSetId { get; set; }

	public int? ScaleId { get; set; }

	public byte? PlayerAvatarTypeID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		Roblox.Outfits.Outfit cal = Roblox.Outfits.Outfit.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AssetHashID = AssetHashId;
		cal.BodyColorSetID = BodyColorSetId;
		cal.ScaleID = ScaleId;
		cal.PlayerAvatarTypeID = PlayerAvatarTypeID;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(Roblox.Outfits.Outfit.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
