using System.Collections.Generic;
using System.Linq;
using Roblox.Outfits;
using Roblox.Platform.Outfits.Properties;

namespace Roblox.Platform.Outfits;

public class OutfitAccoutrementFactory : IOutfitAccoutrementFactory
{
	public IOutfitAccoutrementEntity GetOutfitAccoutrement(long id)
	{
		return OutfitAccoutrement.Get(id).Translate();
	}

	public virtual IOutfitAccoutrementEntity Create(long outfitId, long assetId)
	{
		return OutfitAccoutrement.Create(outfitId, assetId)?.Translate();
	}

	public IEnumerable<IOutfitAccoutrementEntity> GetAllOutfitAccoutrements(long outfitId)
	{
		return GetOutfitAccoutrementsPaged(outfitId, 1, Settings.Default.MaximumAccoutrements);
	}

	public IEnumerable<IOutfitAccoutrementEntity> GetOutfitAccoutrementsPaged(long outfitId, int startRow, int maxRows)
	{
		return from o in OutfitAccoutrement.GetOutfitAccoutrementsByOutfitIDPaged(outfitId, startRow, maxRows)
			select GetOutfitAccoutrement(o.ID);
	}
}
