namespace Roblox.Platform.Outfits;

internal interface IOutfitEntityFactory
{
	IOutfitEntity GetOutfit(long id);

	IOutfitEntity GetOutfitByAssetHashID(long assetHashId);

	IOutfitEntity CreateNew(long assetHashId, long bodyColorSetId, int? scaleId, byte? playerAvatarTypeId);

	IOutfitEntity GetOrCreate(long assetHashId, long bodyColorSetId, int? scaleId, byte? playerAvatarTypeId, out bool createdNewEntity);
}
