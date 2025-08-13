using System;

namespace Roblox.Platform.Assets;

internal class AssetVersion : IAssetVersion
{
	private readonly AssetDomainFactories _AssetDomainFactories;

	public long Id { get; private set; }

	public long AssetId { get; private set; }

	public int VersionNumber { get; private set; }

	public long RawContentId { get; private set; }

	public long? ParentAssetVersionId { get; private set; }

	public CreatorType CreatorType { get; private set; }

	public long CreatorTargetId { get; private set; }

	public long? CreatingUniverseId { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	internal AssetVersion(AssetDomainFactories assetDomainFactories, long id, long assetId, int versionNumber, long rawContentId, long? parentAssetVersionId, CreatorType creatorType, long creatorTargetId, long? creatingUniverseId, DateTime created, DateTime updated)
	{
		_AssetDomainFactories = assetDomainFactories;
		Id = id;
		AssetId = assetId;
		VersionNumber = versionNumber;
		RawContentId = rawContentId;
		ParentAssetVersionId = parentAssetVersionId;
		CreatorType = creatorType;
		CreatorTargetId = creatorTargetId;
		CreatingUniverseId = creatingUniverseId;
		Created = created;
		Updated = updated;
	}

	public IAsset GetAsset()
	{
		return _AssetDomainFactories.AssetFactory.CheckedGetAsset(AssetId);
	}

	public IAssetVersion GetParentAssetVersion()
	{
		return _AssetDomainFactories.AssetVersionFactory.Get(ParentAssetVersionId);
	}

	public IRawContent GetRawContent()
	{
		return _AssetDomainFactories.RawContentFactory.CheckedGet(RawContentId);
	}
}
