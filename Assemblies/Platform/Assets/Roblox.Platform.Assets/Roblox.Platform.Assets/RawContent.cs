using System;
using Roblox.Platform.Assets.Entities.AssetHash;

namespace Roblox.Platform.Assets;

public class RawContent : IRawContent
{
	private readonly IAssetHashEntityFactory _AssetHashEntityFactory;

	public long Id { get; private set; }

	public string Md5Hash { get; private set; }

	public bool IsReviewed { get; private set; }

	public bool IsApproved { get; private set; }

	public CreatorType CreatorType { get; private set; }

	public long CreatorTargetId { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	public AssetType AssetType { get; private set; }

	internal RawContent(IAssetHashEntityFactory assetHashEntityFactory, long id, string md5Hash, bool isReviewed, bool isApproved, CreatorType creatorType, long creatorTargetId, DateTime created, DateTime updated, AssetType assetType)
	{
		_AssetHashEntityFactory = assetHashEntityFactory ?? throw new ArgumentNullException("assetHashEntityFactory");
		Id = id;
		Md5Hash = md5Hash;
		IsReviewed = isReviewed;
		IsApproved = isApproved;
		CreatorType = creatorType;
		CreatorTargetId = creatorTargetId;
		Created = created;
		Updated = updated;
		AssetType = assetType;
	}

	public void SetApproval(bool isApproved, bool isReviewed)
	{
		IAssetHashEntity entity = _AssetHashEntityFactory.Get(Id);
		if (entity == null)
		{
			throw new InvalidOperationException("Unable to modify non-persisted entity");
		}
		if (entity.IsApproved != isApproved || entity.IsReviewed != isReviewed)
		{
			entity.SetApproval(isApproved, isReviewed);
		}
		IsApproved = entity.IsApproved;
		IsReviewed = entity.IsReviewed;
		Updated = entity.Updated;
	}
}
