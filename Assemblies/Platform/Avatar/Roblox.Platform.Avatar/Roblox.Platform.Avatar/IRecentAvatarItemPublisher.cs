using System.Collections.Generic;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

public interface IRecentAvatarItemPublisher
{
	void AddUserOutfits(long userId, List<IUserOutfit> userOutfitIds);

	void AddAssets(long userId, List<long> assetIds);

	void RemoveAssets(long userId, List<long> assetIds);

	void RemoveUserOutfits(long userId, List<IUserOutfit> userOutfits);
}
