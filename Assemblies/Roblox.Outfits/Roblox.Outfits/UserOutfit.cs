using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Outfits;

public class UserOutfit : IRobloxEntity<long, UserOutfitDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private UserOutfitDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UserOutfit).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long OutfitID
	{
		get
		{
			return _EntityDAL.OutfitID;
		}
		set
		{
			_EntityDAL.OutfitID = value;
		}
	}

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public bool IsEditable
	{
		get
		{
			return _EntityDAL.IsEditable;
		}
		set
		{
			_EntityDAL.IsEditable = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public UserOutfit()
	{
		_EntityDAL = new UserOutfitDAL();
	}

	public UserOutfit(UserOutfitDAL userOutfitDAL)
	{
		_EntityDAL = userOutfitDAL;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static UserOutfit CreateNew(long outfitid, long userId, string name, bool isEditable)
	{
		UserOutfit userOutfit = new UserOutfit();
		userOutfit.OutfitID = outfitid;
		userOutfit.UserID = userId;
		userOutfit.Name = name;
		userOutfit.IsEditable = isEditable;
		userOutfit.Save();
		return userOutfit;
	}

	public static UserOutfit Get(long id)
	{
		return EntityHelper.GetEntity<long, UserOutfitDAL, UserOutfit>(EntityCacheInfo, id, () => UserOutfitDAL.Get(id));
	}

	public static ICollection<UserOutfit> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, UserOutfitDAL, UserOutfit>(ids, EntityCacheInfo, UserOutfitDAL.MultiGet);
	}

	public static ICollection<UserOutfit> GetUserOutfitsByUserIDPaged(long userId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetUserOutfitIDsByUserIDPaged_UserID:{userId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), collectionId, () => UserOutfitDAL.GetUserOutfitIDsByUserIDPaged(userId, startRowIndex, maximumRows), MultiGet);
	}

	public static ICollection<UserOutfit> GetUserOutfitsByUserIDIsEditablePaged(long userId, bool isEditable, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetUserOutfitIDsByUserIDIsEditablePaged_UserID:{userId}_IsEditable:{isEditable}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), collectionId, () => UserOutfitDAL.GetUserOutfitIDsByUserIDIsEditablePaged(userId, isEditable, startRowIndex, maximumRows), MultiGet);
	}

	public static int GetTotalNumberOfUserOutfitsByUserID(long userId)
	{
		string countId = $"GetTotalNumberOfUserOutfitsByUserID_UserID:{userId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), countId, () => UserOutfitDAL.GetTotalNumberOfUserOutfitsByUserID(userId));
	}

	public static int GetTotalNumberOfEditableUserOutfitsByUserID(long userId)
	{
		string countId = $"GetTotalNumberOfEditableUserOutfitsByUserID_UserID:{userId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), countId, () => UserOutfitDAL.GetTotalNumberOfEditableUserOutfitsByUserID(userId));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(UserOutfitDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"UserID:{UserID}");
	}
}
