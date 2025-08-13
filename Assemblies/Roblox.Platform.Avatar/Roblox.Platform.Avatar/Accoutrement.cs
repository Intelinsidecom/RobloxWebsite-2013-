using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Roblox.Avatar.Client;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Http.ServiceClient;
using Roblox.Platform.Avatar.Properties;

namespace Roblox.Platform.Avatar;

/// <summary>
/// An accoutrement is an asset that is being worn on a user's avatar
/// </summary>
[Serializable]
[DataObject]
[DebuggerDisplay("Accoutrement {ID}")]
internal class Accoutrement : IRobloxEntity<long, AccoutrementDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject, IAccoutrement
{
	public delegate void EntityCRUDEventHandler(string methodName);

	private AccoutrementDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Accoutrement", isNullCacheable: true);

	public static IAvatarClient AvatarClient { get; set; }

	private static int UserIdAvatarServiceRolloutPercentage => Settings.Default.UseAvatarServiceForUserIdAccoutrementsRolloutPercentage;

	private static int UserAssetIdAvatarServiceRolloutPercentage => Settings.Default.UseAvatarServiceForUserAssetIdAccoutrementsRolloutPercentage;

	[DataObjectField(true, true, false)]
	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	[DataObjectField(false, false, false)]
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

	public User User
	{
		get
		{
			return GetUser();
		}
		set
		{
			if (value != null)
			{
				UserID = value.ID;
			}
			else
			{
				UserID = 0L;
			}
		}
	}

	[DataObjectField(false, false, false)]
	public long UserAssetID
	{
		get
		{
			return _EntityDAL.UserAssetID;
		}
		set
		{
			_EntityDAL.UserAssetID = value;
		}
	}

	[DataObjectField(false, false, false)]
	public DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event EntityCRUDEventHandler EntityCRUD;

	public Accoutrement()
	{
		_EntityDAL = new AccoutrementDAL();
	}

	public Accoutrement(AccoutrementDAL dal)
	{
		_EntityDAL = dal;
	}

	/// <summary>
	/// Removes an accoutrement from the user's avatar.
	/// accoutrements are only accessed through avatar, which handles thumbnail invalidation.
	/// </summary>
	public void Delete()
	{
		if (UserID % 100 < UserIdAvatarServiceRolloutPercentage && AvatarClient != null)
		{
			OnEntityCRUD("OnDeletingAccoutrement_AvatarService");
			try
			{
				AvatarClient.DeleteAccoutrement(ID);
				return;
			}
			catch (ServiceOperationErrorException e)
			{
				throw new AvatarServiceException(e.Code, (Exception)(object)e);
			}
		}
		OnEntityCRUD("DeleteAccoutrement");
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	public User GetUser()
	{
		return User.MustGet(UserID);
	}

	/// accoutrements are only accessed through avatar, which handles thumbnail invalidation.
	public void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			OnEntityCRUD("CreateAccoutrement");
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			OnEntityCRUD("UpdateAccoutrement");
			_EntityDAL.Update();
		});
	}

	public static Accoutrement CreateNew(long userId, long userAssetId)
	{
		if (userId % 100 < UserIdAvatarServiceRolloutPercentage && AvatarClient != null)
		{
			OnEntityCRUD("OnCreatingNewAccoutrement_AvatarService");
			try
			{
				return TranslateAccoutrementResult(AvatarClient.CreateAccoutrement(userId, userAssetId));
			}
			catch (ServiceOperationErrorException e)
			{
				throw new AvatarServiceException(e.Code, (Exception)(object)e);
			}
		}
		OnEntityCRUD("CreateNew");
		Accoutrement accoutrement = new Accoutrement();
		accoutrement.UserID = userId;
		accoutrement.UserAssetID = userAssetId;
		accoutrement.Save();
		return accoutrement;
	}

	public static Accoutrement Get(long id)
	{
		OnEntityCRUD("GetAccoutrement");
		return EntityHelper.GetEntity<long, AccoutrementDAL, Accoutrement>(EntityCacheInfo, id, () => AccoutrementDAL.Get(id));
	}

	private static ICollection<Accoutrement> MultiGet(ICollection<long> ids)
	{
		OnEntityCRUD("MultiGetAccoutrement");
		return EntityHelper.MultiGetEntity<long, AccoutrementDAL, Accoutrement>(ids, EntityCacheInfo, AccoutrementDAL.MultiGet);
	}

	public static Accoutrement Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static Accoutrement GetByUserAssetID(long userAssetId)
	{
		if (userAssetId % 100 < UserAssetIdAvatarServiceRolloutPercentage && AvatarClient != null)
		{
			OnEntityCRUD("GetAccoutrementByUserAssetID_AvatarService");
			try
			{
				AccoutrementResultBatch accoutrementsByUserAssetIds = AvatarClient.GetAccoutrementsByUserAssetIds((IEnumerable<long>)new long[1] { userAssetId });
				IDictionary<long, AccoutrementResult> results = ((accoutrementsByUserAssetIds != null) ? accoutrementsByUserAssetIds.Data : null);
				if (results != null && results.TryGetValue(userAssetId, out var value))
				{
					return TranslateAccoutrementResult(value);
				}
				return null;
			}
			catch (ServiceOperationErrorException e)
			{
				throw new AvatarServiceException(e.Code, (Exception)(object)e);
			}
		}
		OnEntityCRUD("GetAccoutrementByUserAssetID");
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, AccoutrementDAL, Accoutrement>(EntityCacheInfo, GetEntityLookupByUserAssetId(userAssetId), () => AccoutrementDAL.GetByUserAssetID(userAssetId), Get);
	}

	/// <summary>
	/// A version of GetUserAccoutrements which doesn't apply business rules at the end.
	/// </summary>
	public static IEnumerable<Accoutrement> GetUserAccoutrementsNoFilter(long userId)
	{
		string collectionId = "GetUserAccoutrements_UserID:" + userId;
		string cachedStateQualifier = GetEntityLookupByUserId(userId);
		if (userId % 100 < UserIdAvatarServiceRolloutPercentage && AvatarClient != null)
		{
			OnEntityCRUD("GetAccoutrementIDsByUserID_AvatarService");
			try
			{
				AccoutrementResultListBatch accoutrementsByUserIds = AvatarClient.GetAccoutrementsByUserIds((IEnumerable<long>)new long[1] { userId });
				IDictionary<long, IReadOnlyCollection<AccoutrementResult>> serviceResults = ((accoutrementsByUserIds != null) ? accoutrementsByUserIds.Data : null);
				if (serviceResults != null && serviceResults.TryGetValue(userId, out var values))
				{
					return from x in values.Select(TranslateAccoutrementResult)
						where x != null
						select x;
				}
				return null;
			}
			catch (ServiceOperationErrorException e)
			{
				throw new AvatarServiceException(e.Code, (Exception)(object)e);
			}
		}
		OnEntityCRUD("GetAccoutrementIDsByUserID");
		return (from x in EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(cachedStateQualifier), collectionId, () => AccoutrementDAL.GetUserAccoutrementIDs(userId), MultiGet)
			where x != null
			select x).ToList();
	}

	public void Construct(AccoutrementDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return GetEntityLookupByUserAssetId(UserAssetID);
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetEntityLookupByUserId(UserID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetEntityLookupByUserAssetId(long userAssetId)
	{
		return "UserAssetID:" + userAssetId;
	}

	private static string GetEntityLookupByUserId(long userId)
	{
		return "UserID:" + userId;
	}

	private static void OnEntityCRUD(string methodName)
	{
		Accoutrement.EntityCRUD?.Invoke(methodName);
	}

	private static Accoutrement TranslateAccoutrementResult(AccoutrementResult result)
	{
		if (result != null)
		{
			return new Accoutrement
			{
				ID = result.Id,
				UserID = result.UserId,
				UserAssetID = result.UserAssetId
			};
		}
		return null;
	}
}
