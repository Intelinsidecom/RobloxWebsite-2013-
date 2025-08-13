using Roblox.Outfits;
using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

internal class OutfitEntityFactory : IOutfitEntityFactory
{
	private readonly OutfitDomainFactories _OutfitDomainFactories;

	public OutfitEntityFactory(OutfitDomainFactories outfitDomainFactories)
	{
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
	}

	public IOutfitEntity GetOutfit(long id)
	{
		return Translate(Roblox.Outfits.Outfit.Get(id));
	}

	public IOutfitEntity GetOutfitByAssetHashID(long assetHashId)
	{
		return Translate(Roblox.Outfits.Outfit.GetOutfitByAssetHashID(assetHashId));
	}

	public virtual IOutfitEntity CreateNew(long assetHashId, long bodyColorSetId, int? scaleId, byte? playerAvatarTypeId)
	{
		Roblox.Outfits.Outfit entity = Roblox.Outfits.Outfit.CreateNew(assetHashId, bodyColorSetId, scaleId, playerAvatarTypeId);
		return Translate(entity);
	}

	public virtual IOutfitEntity GetOrCreate(long assetHashId, long bodyColorSetId, int? scaleId, byte? playerAvatarTypeId, out bool createdNewEntity)
	{
		return Translate(Roblox.Outfits.Outfit.GetOrCreate(assetHashId, bodyColorSetId, scaleId, playerAvatarTypeId, out createdNewEntity));
	}

	private IOutfitEntity Translate(Roblox.Outfits.Outfit outfitEntity)
	{
		if (outfitEntity == null)
		{
			return null;
		}
		return new OutfitEntity
		{
			Id = outfitEntity.ID,
			AssetHashId = outfitEntity.AssetHashID,
			BodyColorSetId = outfitEntity.BodyColorSetID,
			PlayerAvatarTypeID = outfitEntity.PlayerAvatarTypeID,
			ScaleId = outfitEntity.ScaleID,
			Created = outfitEntity.Created,
			Updated = outfitEntity.Updated
		};
	}
}
