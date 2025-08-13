using System;

namespace Roblox;

[Serializable]
[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
public class AssetReference
{
	public enum AssetReferenceTypes
	{
		AssetSubscription,
		AssetVersion
	}

	private long _Id;

	private long _AssetID
	{
		get
		{
			if (IsAsset)
			{
				return _Id;
			}
			return 0L;
		}
	}

	private long _AssetVersionID
	{
		get
		{
			if (IsAssetVersion)
			{
				return Math.Abs(_Id);
			}
			return 0L;
		}
	}

	public long ID
	{
		get
		{
			return _Id;
		}
		set
		{
			_Id = value;
		}
	}

	public bool IsAsset => _Id > 0;

	public bool IsAssetVersion => _Id < 0;

	public IAsset ReferredAsset
	{
		get
		{
			if (IsAssetVersion)
			{
				return AssetVersion.Get(_AssetVersionID);
			}
			if (IsAsset)
			{
				return Asset.Get(_AssetID);
			}
			return null;
		}
	}

	public AssetReference(long assetReferenceId)
	{
		_Id = assetReferenceId;
	}

	public AssetReference(IAsset asset, AssetReferenceTypes type)
	{
		switch (type)
		{
		case AssetReferenceTypes.AssetSubscription:
			_Id = asset.CurrentVersion.AssetID;
			break;
		case AssetReferenceTypes.AssetVersion:
			_Id = -1 * asset.CurrentVersion.ID;
			break;
		default:
			throw new ApplicationException("Asset Reference type unknown");
		}
	}

	public static AssetReference FromAssetSubscription(long assetId)
	{
		return new AssetReference(assetId);
	}

	public static AssetReference FromAssetVersion(long assetVersionId)
	{
		return new AssetReference(-1 * assetVersionId);
	}
}
