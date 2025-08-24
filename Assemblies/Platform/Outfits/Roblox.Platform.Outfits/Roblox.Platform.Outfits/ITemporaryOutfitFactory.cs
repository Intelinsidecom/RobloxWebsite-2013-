using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Outfits;

public interface ITemporaryOutfitFactory
{
	IOutfit Create(List<long> assetIds, IBodyColorSet bodyColorSet, Scale scale, PlayerAvatarType playerAvatarType, IUser user);
}
