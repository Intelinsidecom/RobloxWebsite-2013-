using System;

namespace Roblox.Platform.Outfits;

public interface IOutfit
{
	long ID { get; }

	long AssetHashID { get; }

	long BodyColorSetID { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	int ScaleId { get; }

	byte PlayerAvatarTypeId { get; }

	IBrickBodyColorSet GetBodyColors();
}
