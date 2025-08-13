using System;

namespace Roblox.Platform.Assets;

public interface IAssetVersion
{
	long Id { get; }

	long AssetId { get; }

	int VersionNumber { get; }

	long? ParentAssetVersionId { get; }

	long RawContentId { get; }

	CreatorType CreatorType { get; }

	long CreatorTargetId { get; }

	long? CreatingUniverseId { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	IAsset GetAsset();

	IAssetVersion GetParentAssetVersion();

	IRawContent GetRawContent();
}
