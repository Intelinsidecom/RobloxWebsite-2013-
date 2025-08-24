using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Chat.Entities;

internal class Conversation : IRobloxEntity<long, ConversationDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private ConversationDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Conversation).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal string Title
	{
		get
		{
			return _EntityDAL.Title;
		}
		set
		{
			_EntityDAL.Title = value;
		}
	}

	internal int CreatorTypeID
	{
		get
		{
			return _EntityDAL.CreatorTypeID;
		}
		set
		{
			_EntityDAL.CreatorTypeID = value;
		}
	}

	internal long CreatorTargetID
	{
		get
		{
			return _EntityDAL.CreatorTargetID;
		}
		set
		{
			_EntityDAL.CreatorTargetID = value;
		}
	}

	internal byte ConversationTypeID
	{
		get
		{
			return _EntityDAL.ConversationTypeID;
		}
		set
		{
			_EntityDAL.ConversationTypeID = value;
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

	public Conversation()
	{
		_EntityDAL = new ConversationDAL();
	}

	public Conversation(ConversationDAL conversationDAL)
	{
		_EntityDAL = conversationDAL;
	}

	public static Conversation CreateNew(int creatorTypeId, long creatorTargetId, byte conversationTypeId, string title)
	{
		Conversation conversation = new Conversation();
		conversation.ConversationTypeID = conversationTypeId;
		conversation.CreatorTypeID = creatorTypeId;
		conversation.CreatorTargetID = creatorTargetId;
		conversation.Title = title;
		conversation.Save();
		return conversation;
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

	internal static Conversation Get(long id)
	{
		return EntityHelper.GetEntity<long, ConversationDAL, Conversation>(EntityCacheInfo, id, () => ConversationDAL.Get(id));
	}

	private static ICollection<Conversation> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, ConversationDAL, Conversation>(ids, EntityCacheInfo, ConversationDAL.MultiGet);
	}

	public void Construct(ConversationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
