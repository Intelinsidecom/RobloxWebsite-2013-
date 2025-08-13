using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Assets.Entities.AssetHash;

internal class AssetHashEntityFactory : IAssetHashEntityFactory
{
	private struct ModerationFlags
	{
		public bool IsApproved { get; }

		public bool IsReviewed { get; }

		public ModerationFlags(bool isReviewed, bool isApproved)
		{
			IsReviewed = isReviewed;
			IsApproved = isApproved;
		}
	}

	public IAssetHashEntity Get(long id)
	{
		return MapBllToEntity(Roblox.AssetHash.Get(id));
	}

	public IAssetHashEntity Get(int assetTypeId, string hash)
	{
		return MapBllToEntity(Roblox.AssetHash.Get(assetTypeId, hash));
	}

	public IEnumerable<IAssetHashEntity> GetByMd5HashPaged(string hash, int startRowIndex, int maximumRows)
	{
		return from p in Roblox.AssetHash.GetAssetHashesPaged(hash, startRowIndex, maximumRows)
			select MapBllToEntity(p);
	}

	public IAssetHashEntity GetOrCreate(int assetTypeId, string hash, ICreator creator)
	{
		Roblox.AssetType assetTypeEntity = Roblox.AssetType.Get(assetTypeId);
		ModerationFlags moderationFlags = GetDefaultModerationFlags(creator, assetTypeEntity);
		return MapBllToEntity(Roblox.AssetHash.GetOrCreate(assetTypeId, hash, creator, moderationFlags.IsApproved, moderationFlags.IsReviewed));
	}

	private static IAssetHashEntity MapBllToEntity(Roblox.AssetHash bll)
	{
		if (bll != null)
		{
			return new AssetHashEntity
			{
				Id = bll.ID,
				AssetTypeId = bll.AssetTypeID,
				Hash = bll.Hash,
				IsApproved = bll.IsApproved,
				IsReviewed = bll.IsReviewed,
				CreatorId = bll.CreatorId,
				Created = bll.Created,
				Updated = bll.Updated
			};
		}
		return null;
	}

	/// <summary>
	/// Logic for figuring out if an asset requires review.
	/// TODO - Currently a copy-paste job from SCL, clearly belong in a separate file.
	/// </summary>
	/// <param name="creator">Creator of the Content</param>
	/// <param name="assetType">AssetType of the Content</param>
	/// <returns>A <see cref="T:Roblox.Platform.Assets.Entities.AssetHash.AssetHashEntityFactory.ModerationFlags" /> object containing default values for IsApproved and IsReviewed.</returns>
	private static ModerationFlags GetDefaultModerationFlags(ICreator creator, Roblox.AssetType assetType)
	{
		if (creator.CreatorType == Roblox.CreatorType.User)
		{
			User user = (User)creator;
			if (user.TestIsTrustedContributor() || user.TestIsContentCreator())
			{
				return new ModerationFlags(isReviewed: true, isApproved: true);
			}
		}
		if (assetType.RequiresReview)
		{
			return new ModerationFlags(isReviewed: false, isApproved: false);
		}
		return new ModerationFlags(isReviewed: false, isApproved: true);
	}
}
