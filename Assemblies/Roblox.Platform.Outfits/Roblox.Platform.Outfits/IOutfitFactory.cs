using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Outfits;

public interface IOutfitFactory
{
	IOutfit GetOutfit(long id);

	IOutfit GetOutfitByAssetHashID(long assetHashId);

	IOutfit GetOrCreate(List<long> assetIds, IBrickBodyColorSet brickBodyColorSet, Scale scale, PlayerAvatarType playerAvatarType, IUser user);

	IOutfit GetOrCreate(List<long> assetIds, long bodyColorSetId, int scaleId, byte playerAvatarTypeId, long userId);
}
