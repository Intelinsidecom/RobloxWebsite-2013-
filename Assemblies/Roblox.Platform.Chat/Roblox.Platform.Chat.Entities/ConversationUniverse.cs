using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Chat.Entities;

internal class ConversationUniverse : IRobloxEntity<long, ConversationUniverseDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private ConversationUniverseDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ConversationUniverse).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.Id;

	internal long ConversationId
	{
		get
		{
			return _EntityDAL.ConversationId;
		}
		set
		{
			_EntityDAL.ConversationId = value;
		}
	}

	internal long UniverseId
	{
		get
		{
			return _EntityDAL.UniverseId;
		}
		set
		{
			_EntityDAL.UniverseId = value;
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

	public ConversationUniverse()
	{
		_EntityDAL = new ConversationUniverseDAL();
	}

	public ConversationUniverse(ConversationUniverseDAL conversationUniverseDAL)
	{
		_EntityDAL = conversationUniverseDAL;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(ConversationUniverseDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByConversationId(ConversationId);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public static ConversationUniverse Create(long conversationId, long universeId)
	{
		ConversationUniverse conversationUniverse = new ConversationUniverse();
		conversationUniverse.ConversationId = conversationId;
		conversationUniverse.UniverseId = universeId;
		conversationUniverse.Save();
		return conversationUniverse;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	internal void Save()
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

	internal static ConversationUniverse Get(long id)
	{
		return EntityHelper.GetEntity<long, ConversationUniverseDAL, ConversationUniverse>(EntityCacheInfo, id, () => ConversationUniverseDAL.Get(id));
	}

	internal static ConversationUniverse GetByConversationId(long conversationId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, ConversationUniverseDAL, ConversationUniverse>(EntityCacheInfo, GetLookupCacheKeysByConversationId(conversationId), () => ConversationUniverseDAL.GetConversationUniverseByConversationId(conversationId), Get);
	}

	private static ICollection<ConversationUniverse> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, ConversationUniverseDAL, ConversationUniverse>(ids, EntityCacheInfo, ConversationUniverseDAL.MultiGet);
	}

	private static string GetLookupCacheKeysByConversationId(long conversationId)
	{
		return $"ConversationId:{conversationId}";
	}
}
