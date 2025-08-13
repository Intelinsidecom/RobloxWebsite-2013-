using System;
using Roblox.Outfits;

namespace Roblox.Platform.Outfits;

internal class UserOutfitEntity : IUserOutfitEntity
{
	public long Id { get; set; }

	public long OutfitId { get; set; }

	public long UserId { get; set; }

	public string Name { get; set; }

	public bool IsEditable { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		Roblox.Outfits.UserOutfit cal = Roblox.Outfits.UserOutfit.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.OutfitID = OutfitId;
		cal.Name = Name;
		cal.IsEditable = IsEditable;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(Roblox.Outfits.UserOutfit.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
