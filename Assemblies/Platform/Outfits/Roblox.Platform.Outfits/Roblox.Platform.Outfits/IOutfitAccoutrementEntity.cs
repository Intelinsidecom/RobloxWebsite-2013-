using System;

namespace Roblox.Platform.Outfits;

public interface IOutfitAccoutrementEntity
{
	long ID { get; }

	long AssetID { get; }

	long OutfitID { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
