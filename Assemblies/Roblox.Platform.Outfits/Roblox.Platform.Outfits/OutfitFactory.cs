using System;
using System.Collections.Generic;
using Roblox.Common;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Outfits;

public class OutfitFactory : IOutfitFactory
{
	private readonly OutfitDomainFactories _OutfitDomainFactories;

	public OutfitFactory(OutfitDomainFactories outfitDomainFactories)
	{
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
	}

	public IOutfit GetOutfit(long id)
	{
		IOutfitEntity outfitEntity = _OutfitDomainFactories.OutfitEntityFactory.GetOutfit(id);
		return Translate(outfitEntity);
	}

	public virtual IOutfit GetOutfitByAssetHashID(long assetHashId)
	{
		IOutfitEntity outfitEntity = _OutfitDomainFactories.OutfitEntityFactory.GetOutfitByAssetHashID(assetHashId);
		if (outfitEntity == null)
		{
			return null;
		}
		return Translate(outfitEntity);
	}

	public IOutfit GetOrCreate(List<long> assetIds, IBrickBodyColorSet brickBodyColorSet, Scale scale, PlayerAvatarType playerAvatarType, IUser user)
	{
		IBodyColorSet bodyColorSet = _OutfitDomainFactories.BodyColorSetFactory.GetOrCreate(brickBodyColorSet);
		return GetOrCreate(assetIds, bodyColorSet.ID, scale.Id, (byte)playerAvatarType, user.Id);
	}

	/// <summary>
	/// Create an outfit based on a body color set, scale, playerAvatarType and assets
	/// UserId is used for creating an AssetHash for BodyColors, nothing else
	/// Since this does not create from an existing avatar, we need to make sure business rules are applied before we call this
	/// </summary>
	public virtual IOutfit GetOrCreate(List<long> assetIds, long bodyColorSetId, int scaleId, byte playerAvatarTypeId, long userId)
	{
		IRawContent assetHash = _OutfitDomainFactories.OutfitKeyGenerator.GenerateAssetHash(assetIds, bodyColorSetId, scaleId, playerAvatarTypeId, userId);
		int resolvedScaleId = ((EnumUtils.StrictTryParseEnum<PlayerAvatarType>(playerAvatarTypeId.ToString()) != PlayerAvatarType.R6) ? scaleId : _OutfitDomainFactories.ScaleEntityFactory.GetDefault().Id);
		bool createdNewEntity;
		IOutfitEntity outfitEntity = _OutfitDomainFactories.OutfitEntityFactory.GetOrCreate(assetHash.Id, bodyColorSetId, resolvedScaleId, playerAvatarTypeId, out createdNewEntity);
		IOutfit outfit = Translate(outfitEntity);
		long outfitId = outfit.ID;
		if (createdNewEntity)
		{
			foreach (long assetId in assetIds)
			{
				_OutfitDomainFactories.OutfitAccoutrementFactory.Create(outfitId, assetId);
			}
		}
		return outfit;
	}

	internal virtual IOutfit Translate(IOutfitEntity entity)
	{
		if (entity == null)
		{
			return null;
		}
		long id = entity.Id;
		long assetHashId = entity.AssetHashId;
		long bodyColorSetId = entity.BodyColorSetId;
		IScaleEntity scale = (entity.ScaleId.HasValue ? _OutfitDomainFactories.ScaleEntityFactory.Get(entity.ScaleId.Value) : _OutfitDomainFactories.ScaleEntityFactory.GetDefault());
		PlayerAvatarType playerAvatarType = (PlayerAvatarType)((!entity.PlayerAvatarTypeID.HasValue) ? 1 : entity.PlayerAvatarTypeID.Value);
		DateTime created = entity.Created;
		DateTime updated = entity.Updated;
		return new Outfit(id, assetHashId, bodyColorSetId, created, updated, scale.Id, (byte)playerAvatarType, _OutfitDomainFactories);
	}
}
