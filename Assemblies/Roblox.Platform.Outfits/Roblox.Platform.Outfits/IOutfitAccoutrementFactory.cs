using System.Collections.Generic;

namespace Roblox.Platform.Outfits;

public interface IOutfitAccoutrementFactory
{
	IOutfitAccoutrementEntity GetOutfitAccoutrement(long id);

	IOutfitAccoutrementEntity Create(long outfitId, long assetId);

	IEnumerable<IOutfitAccoutrementEntity> GetAllOutfitAccoutrements(long outfitId);
}
