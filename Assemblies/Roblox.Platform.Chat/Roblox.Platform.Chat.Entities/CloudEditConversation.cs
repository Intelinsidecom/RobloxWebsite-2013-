using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Chat.Entities;

internal class CloudEditConversation : IRobloxEntity<long, CloudEditConversationDAL>, ICacheableObject<long>, ICacheableObject
{
	private CloudEditConversationDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(CloudEditConversation).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long ConversationID
	{
		get
		{
			return _EntityDAL.ConversationID;
		}
		set
		{
			_EntityDAL.ConversationID = value;
		}
	}

	internal long PlaceID
	{
		get
		{
			return _EntityDAL.PlaceID;
		}
		set
		{
			_EntityDAL.PlaceID = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public CloudEditConversation()
	{
		_EntityDAL = new CloudEditConversationDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
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

	internal static CloudEditConversation CreateNew(long conversationId, long placeId)
	{
		CloudEditConversation cloudEditConversation = new CloudEditConversation();
		cloudEditConversation.ConversationID = conversationId;
		cloudEditConversation.PlaceID = placeId;
		cloudEditConversation.Save();
		return cloudEditConversation;
	}

	internal static CloudEditConversation Get(long id)
	{
		return EntityHelper.GetEntity<long, CloudEditConversationDAL, CloudEditConversation>(EntityCacheInfo, id, () => CloudEditConversationDAL.Get(id));
	}

	private static ICollection<CloudEditConversation> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, CloudEditConversationDAL, CloudEditConversation>(ids, EntityCacheInfo, CloudEditConversationDAL.MultiGet);
	}

	public static CloudEditConversation GetByConversationID(long conversationId)
	{
		return EntityHelper.GetEntityByLookup<long, CloudEditConversationDAL, CloudEditConversation>(EntityCacheInfo, GetLookupCacheKeysByConversationID(conversationId), () => CloudEditConversationDAL.GetCloudEditConversationByConversationID(conversationId));
	}

	public static CloudEditConversation GetByPlaceID(long placeId)
	{
		return EntityHelper.GetEntityByLookup<long, CloudEditConversationDAL, CloudEditConversation>(EntityCacheInfo, GetLookupCacheKeysByPlaceID(placeId), () => CloudEditConversationDAL.GetCloudEditConversationByPlaceID(placeId));
	}

	public void Construct(CloudEditConversationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByConversationID(ConversationID);
		yield return GetLookupCacheKeysByPlaceID(PlaceID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByConversationID(long conversationID)
	{
		return $"ConversationID:{conversationID}";
	}

	private static string GetLookupCacheKeysByPlaceID(long placeId)
	{
		return $"PlaceID:{placeId}";
	}
}
