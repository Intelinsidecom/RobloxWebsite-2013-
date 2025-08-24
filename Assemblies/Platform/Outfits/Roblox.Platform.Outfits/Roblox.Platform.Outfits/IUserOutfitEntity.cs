using System;

namespace Roblox.Platform.Outfits;

internal interface IUserOutfitEntity
{
	long Id { get; }

	long OutfitId { get; set; }

	long UserId { get; }

	string Name { get; set; }

	bool IsEditable { get; set; }

	DateTime Created { get; set; }

	DateTime Updated { get; }

	void Update();

	void Delete();
}
