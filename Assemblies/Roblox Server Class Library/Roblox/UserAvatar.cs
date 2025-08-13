using System;
using System.Collections.Generic;
using Roblox.Business_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class UserAvatar : IRobloxEntity<int, UserAvatarDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject, IUserAvatar
{
	public delegate void EntityClearThumbnailEventHandler(long userId);

	public delegate void EntityUserAssetRemovedEventHandler(long userAssetId, long userId);

	public static readonly byte[] DefaultPants = CharacterAppearance.Pants;

	public static readonly byte[] DefaultShirt = CharacterAppearance.Shirt;

	public static readonly byte[] DefaultTeeShirt = CharacterAppearance.TeeShirt;

	private UserAvatarDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "UserAvatar", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long UserID => _EntityDAL.UserID;

	/// <summary>
	/// NewAvatarAssetHashID points to an AssetHash that stores a URL
	/// e.g. if you download from S3, it looks something like this
	/// <![CDATA[
	/// http://www.roblox.com/Asset/AvatarAccoutrements.ashx?AvatarHash=d1bf78e06aa76ee4ad11d6c6eee87e30&AssetIDs=48474313,120955812,129906909
	/// ]]>
	/// </summary>
	public long NewAvatarAssetHashID
	{
		get
		{
			return _EntityDAL.NewAvatarAssetHashID;
		}
		set
		{
			_EntityDAL.NewAvatarAssetHashID = value;
		}
	}

	/// <summary>
	/// AvatarHash points to an S3 file XML file that contains the BodyColors of the avatar
	/// </summary>
	public string AvatarHash
	{
		get
		{
			return _EntityDAL.AvatarHash;
		}
		set
		{
			if (_EntityDAL.AvatarHash != value)
			{
				_EntityDAL.NewAvatarAssetHashID = 0L;
			}
			_EntityDAL.AvatarHash = value.Substring(0, (value.Length < 32) ? value.Length : 32);
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public long? BodyColorSetID
	{
		get
		{
			return _EntityDAL.BodyColorSetID;
		}
		set
		{
			_EntityDAL.BodyColorSetID = value;
		}
	}

	public byte? PlayerAvatarTypeID
	{
		get
		{
			return _EntityDAL.PlayerAvatarTypeID;
		}
		set
		{
			_EntityDAL.PlayerAvatarTypeID = value;
		}
	}

	public int? ScaleID
	{
		get
		{
			return _EntityDAL.ScaleID;
		}
		set
		{
			_EntityDAL.ScaleID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event EntityClearThumbnailEventHandler EntityClearThumbnail;

	public static event EntityUserAssetRemovedEventHandler EntityUserAssetRemoved;

	public UserAvatar()
	{
		_EntityDAL = new UserAvatarDAL();
	}

	public UserAvatar(UserAvatarDAL userAvatarDAL)
	{
		_EntityDAL = userAvatarDAL;
	}

	/// <summary>
	/// Since the user appearance has changed (could be accoutrements added/removed),
	/// Clear out the AvatarAssetHashID to make sure the thumbnail is re-rendered.
	/// </summary>
	public void ClearThumbnail()
	{
		if (NewAvatarAssetHashID != 0L)
		{
			NewAvatarAssetHashID = 0L;
			Save();
		}
	}

	public void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			throw new NotImplementedException();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static UserAvatar DoGetOrCreate(long userId, byte? playerAvatarTypeId, int? scaleId)
	{
		return EntityHelper.DoGetOrCreate<int, UserAvatarDAL, UserAvatar>(() => UserAvatarDAL.GetOrCreate(userId, playerAvatarTypeId, scaleId));
	}

	public static UserAvatar Get(int id)
	{
		return EntityHelper.GetEntity<int, UserAvatarDAL, UserAvatar>(EntityCacheInfo, id, () => UserAvatarDAL.Get(id));
	}

	public static ICollection<UserAvatar> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, UserAvatarDAL, UserAvatar>(ids, EntityCacheInfo, UserAvatarDAL.MultiGet);
	}

	public static UserAvatar GetOrCreate(long userId, byte? playerAvatarTypeId, int? scaleId)
	{
		string entityIdLookup = "UserID:" + userId;
		EntityHelper.GetOrCreate<UserAvatar> getterOrCreater = () => DoGetOrCreate(userId, playerAvatarTypeId, scaleId);
		return EntityHelper.GetOrCreateEntityWithRemoteCache<int, UserAvatar>(EntityCacheInfo, entityIdLookup, getterOrCreater, Get);
	}

	public void Construct(UserAvatarDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "UserID:" + UserID;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public static void InvokeClearThumbnailEvent(long userId)
	{
		UserAvatar.EntityClearThumbnail?.Invoke(userId);
	}

	public static void InvokeUserAssetRemovedEvent(long userAssetId, long userId)
	{
		UserAvatar.EntityUserAssetRemoved?.Invoke(userAssetId, userId);
	}
}
