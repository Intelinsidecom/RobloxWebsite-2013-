using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Chat.Properties;

namespace Roblox.Platform.Chat.Entities;

internal class OneToOneConversation : IRobloxEntity<long, OneToOneConversationDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private OneToOneConversationDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(OneToOneConversation).ToString(), isNullCacheable: true);

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

	internal int FirstParticipantTypeID
	{
		get
		{
			return _EntityDAL.FirstParticipantTypeID;
		}
		set
		{
			_EntityDAL.FirstParticipantTypeID = value;
		}
	}

	internal long FirstParticipantTargetID
	{
		get
		{
			return _EntityDAL.FirstParticipantTargetID;
		}
		set
		{
			_EntityDAL.FirstParticipantTargetID = value;
		}
	}

	internal int SecondParticipantTypeID
	{
		get
		{
			return _EntityDAL.SecondParticipantTypeID;
		}
		set
		{
			_EntityDAL.SecondParticipantTypeID = value;
		}
	}

	internal long SecondParticipantTargetID
	{
		get
		{
			return _EntityDAL.SecondParticipantTargetID;
		}
		set
		{
			_EntityDAL.SecondParticipantTargetID = value;
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

	public OneToOneConversation()
	{
		_EntityDAL = new OneToOneConversationDAL();
	}

	public OneToOneConversation(OneToOneConversationDAL oneToOneConversationDAL)
	{
		_EntityDAL = oneToOneConversationDAL;
	}

	public static OneToOneConversation CreateNew(long conversationId, int firstParticipantTypeID, long firstParticipantTargetID, int secondParticipantTypeID, long secondParticipantTargetID)
	{
		if (firstParticipantTypeID > secondParticipantTypeID || (firstParticipantTypeID == secondParticipantTypeID && firstParticipantTargetID >= secondParticipantTargetID))
		{
			throw new ConversationPersistenceException("Invalid ordering of OneToOneConversation Participants");
		}
		OneToOneConversation oneToOneConversation = new OneToOneConversation();
		oneToOneConversation.ConversationID = conversationId;
		oneToOneConversation.FirstParticipantTypeID = firstParticipantTypeID;
		oneToOneConversation.FirstParticipantTargetID = firstParticipantTargetID;
		oneToOneConversation.SecondParticipantTypeID = secondParticipantTypeID;
		oneToOneConversation.SecondParticipantTargetID = secondParticipantTargetID;
		oneToOneConversation.Save();
		return oneToOneConversation;
	}

	internal void Delete()
	{
		if (Settings.Default.UseRemoteCacheForOneToOneConversationLookup)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	internal void Save()
	{
		if (Settings.Default.UseRemoteCacheForOneToOneConversationLookup)
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
		else
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
	}

	internal static OneToOneConversation Get(long id)
	{
		return EntityHelper.GetEntity<long, OneToOneConversationDAL, OneToOneConversation>(EntityCacheInfo, id, () => OneToOneConversationDAL.Get(id));
	}

	private static ICollection<OneToOneConversation> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, OneToOneConversationDAL, OneToOneConversation>(ids, EntityCacheInfo, OneToOneConversationDAL.MultiGet);
	}

	public static OneToOneConversation GetByConversationID(long conversationId)
	{
		if (Settings.Default.UseRemoteCacheForOneToOneConversationLookup)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<long, OneToOneConversationDAL, OneToOneConversation>(EntityCacheInfo, GetLookupCacheKeysByConversationID(conversationId), () => OneToOneConversationDAL.GetOneToOneConversationByConversationID(conversationId), Get);
		}
		return EntityHelper.GetEntityByLookup<long, OneToOneConversationDAL, OneToOneConversation>(EntityCacheInfo, GetLookupCacheKeysByConversationID(conversationId), () => OneToOneConversationDAL.GetOneToOneConversationByConversationID(conversationId));
	}

	public static OneToOneConversation GetByByFirstAndSecondParticipants(int firstParticipantTypeID, long firstParticipantTargetID, int secondParticipantTypeID, long secondParticipantTargetID)
	{
		if (Settings.Default.UseRemoteCacheForOneToOneConversationLookup)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<long, OneToOneConversationDAL, OneToOneConversation>(EntityCacheInfo, GetLookupCacheKeysByFirstParticipantTypeIDFirstParticipantTargetIDSecondParticipantTypeIDSecondParticipantTargetID(firstParticipantTypeID, firstParticipantTargetID, secondParticipantTypeID, secondParticipantTargetID), () => OneToOneConversationDAL.GetOneToOneConversationByFirstAndSecondParticipants(firstParticipantTypeID, firstParticipantTargetID, secondParticipantTypeID, secondParticipantTargetID), Get);
		}
		return EntityHelper.GetEntityByLookup<long, OneToOneConversationDAL, OneToOneConversation>(EntityCacheInfo, GetLookupCacheKeysByFirstParticipantTypeIDFirstParticipantTargetIDSecondParticipantTypeIDSecondParticipantTargetID(firstParticipantTypeID, firstParticipantTargetID, secondParticipantTypeID, secondParticipantTargetID), () => OneToOneConversationDAL.GetOneToOneConversationByFirstAndSecondParticipants(firstParticipantTypeID, firstParticipantTargetID, secondParticipantTypeID, secondParticipantTargetID));
	}

	public void Construct(OneToOneConversationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByFirstParticipantTypeIDFirstParticipantTargetIDSecondParticipantTypeIDSecondParticipantTargetID(FirstParticipantTypeID, FirstParticipantTargetID, SecondParticipantTypeID, SecondParticipantTargetID);
		yield return GetLookupCacheKeysByConversationID(ConversationID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByConversationID(long conversationId)
	{
		return $"ConversationID:{conversationId}";
	}

	private static string GetLookupCacheKeysByFirstParticipantTypeIDFirstParticipantTargetIDSecondParticipantTypeIDSecondParticipantTargetID(int firstParticipantTypeID, long firstParticipantTargetID, int secondParticipantTypeID, long secondParticipantTargetID)
	{
		return $"FirstParticipantTypeID:{firstParticipantTypeID}_FirstParticipantTargetID:{firstParticipantTargetID}_SecondParticipantTypeID:{secondParticipantTypeID}_SecondParticipantTargetID:{secondParticipantTargetID}";
	}
}
