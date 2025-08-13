using System;
using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Outfits;

internal class TemporaryOutfit : IOutfit
{
	private readonly OutfitDomainFactories _OutfitDomainFactories;

	public long ID => -1L;

	public long AssetHashID { get; private set; }

	public long BodyColorSetID { get; private set; }

	public int ScaleId { get; private set; }

	public byte PlayerAvatarTypeId { get; private set; }

	public DateTime Created => DateTime.Now;

	public DateTime Updated => DateTime.Now;

	public IReadOnlyCollection<long> AssetIds { get; private set; }

	public IUser User { get; private set; }

	internal TemporaryOutfit(List<long> assetIds, long bodyColorSetId, int scaleId, byte playerAvatarTypeId, IUser user, OutfitDomainFactories outfitDomainFactories)
	{
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
		BodyColorSetID = bodyColorSetId;
		ScaleId = scaleId;
		PlayerAvatarTypeId = playerAvatarTypeId;
		AssetHashID = _OutfitDomainFactories.OutfitKeyGenerator.GenerateAssetHash(assetIds, bodyColorSetId, scaleId, PlayerAvatarTypeId, user.Id).Id;
	}

	public IBrickBodyColorSet GetBodyColors()
	{
		IBodyColorSet bodyColorSet = _OutfitDomainFactories.BodyColorSetFactory.GetById(BodyColorSetID);
		return _OutfitDomainFactories.BrickBodyColorSetFactory.FromBodyColorSet(bodyColorSet);
	}
}
