using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Outfits;

public class TemporaryOutfitFactory : ITemporaryOutfitFactory
{
	private readonly OutfitDomainFactories _OutfitDomainFactories;

	public TemporaryOutfitFactory(OutfitDomainFactories outfitDomainFactories)
	{
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
	}

	public IOutfit Create(List<long> assetIds, IBodyColorSet bodyColorSet, Scale scale, PlayerAvatarType playerAvatarType, IUser user)
	{
		return new TemporaryOutfit(assetIds, bodyColorSet.ID, scale.Id, (byte)playerAvatarType, user, _OutfitDomainFactories);
	}
}
