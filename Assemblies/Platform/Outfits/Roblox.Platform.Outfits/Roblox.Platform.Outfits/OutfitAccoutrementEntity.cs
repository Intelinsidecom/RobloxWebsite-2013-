using System;

namespace Roblox.Platform.Outfits;

public class OutfitAccoutrementEntity : IOutfitAccoutrementEntity
{
	public long ID { get; private set; }

	public long AssetID { get; private set; }

	public long OutfitID { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	internal OutfitAccoutrementEntity(long id, long assetId, long outfitId, DateTime created, DateTime updated)
	{
		ID = id;
		AssetID = assetId;
		OutfitID = outfitId;
		Created = created;
		Updated = updated;
	}
}
