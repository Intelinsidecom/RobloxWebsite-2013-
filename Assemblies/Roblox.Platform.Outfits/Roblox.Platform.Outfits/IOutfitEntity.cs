using System;

namespace Roblox.Platform.Outfits;

internal interface IOutfitEntity
{
	long Id { get; }

	long AssetHashId { get; set; }

	long BodyColorSetId { get; }

	int? ScaleId { get; set; }

	byte? PlayerAvatarTypeID { get; set; }

	DateTime Created { get; set; }

	DateTime Updated { get; }

	void Update();

	void Delete();
}
