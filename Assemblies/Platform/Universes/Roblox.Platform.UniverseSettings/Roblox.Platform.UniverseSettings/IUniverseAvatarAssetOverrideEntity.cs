using System;
using Roblox.Entities;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarAssetOverrideEntity : IEntity<long>
{
	long UniverseId { get; }

	long AssetId { get; }

	int AssetTypeId { get; }

	bool IsPlayerChoice { get; }

	new DateTime Created { get; }

	DateTime Updated { get; }
}
