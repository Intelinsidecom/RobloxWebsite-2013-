using System;

namespace Roblox.Platform.Outfits;

internal class Outfit : IOutfit
{
	private readonly OutfitDomainFactories _OutfitDomainFactories;

	public long ID { get; set; }

	public long AssetHashID { get; set; }

	public long BodyColorSetID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public int ScaleId { get; set; }

	public byte PlayerAvatarTypeId { get; set; }

	public IBrickBodyColorSet GetBodyColors()
	{
		IBodyColorSet bodyColorSet = _OutfitDomainFactories.BodyColorSetFactory.GetById(BodyColorSetID);
		return _OutfitDomainFactories.BrickBodyColorSetFactory.FromBodyColorSet(bodyColorSet);
	}

	internal Outfit(long id, long assetHashId, long bodyColorSetId, DateTime created, DateTime updated, int scaleId, byte playerAvatarTypeId, OutfitDomainFactories outfitDomainFactories)
	{
		ID = id;
		AssetHashID = assetHashId;
		BodyColorSetID = bodyColorSetId;
		Created = created;
		Updated = updated;
		ScaleId = scaleId;
		PlayerAvatarTypeId = playerAvatarTypeId;
		_OutfitDomainFactories = outfitDomainFactories;
	}
}
