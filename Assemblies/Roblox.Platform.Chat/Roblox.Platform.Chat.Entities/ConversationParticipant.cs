using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Chat.Entities;

internal class ConversationParticipant : IRobloxEntity<long, ConversationParticipantDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private ConversationParticipantDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ConversationParticipant).ToString(), isNullCacheable: true);

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

	internal int ParticipantTypeID
	{
		get
		{
			return _EntityDAL.ParticipantTypeID;
		}
		set
		{
			_EntityDAL.ParticipantTypeID = value;
		}
	}

	internal long ParticipantTargetID
	{
		get
		{
			return _EntityDAL.ParticipantTargetID;
		}
		set
		{
			_EntityDAL.ParticipantTargetID = value;
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

	public ConversationParticipant()
	{
		_EntityDAL = new ConversationParticipantDAL();
	}

	public ConversationParticipant(ConversationParticipantDAL conversationParticipantDAL)
	{
		_EntityDAL = conversationParticipantDAL;
	}

	public static ConversationParticipant CreateNew(long conversationId, int participantTypeId, long participantTargetId)
	{
		ConversationParticipant conversationParticipant = new ConversationParticipant();
		conversationParticipant.ConversationID = conversationId;
		conversationParticipant.ParticipantTypeID = participantTypeId;
		conversationParticipant.ParticipantTargetID = participantTargetId;
		conversationParticipant.Save();
		return conversationParticipant;
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

	internal static ConversationParticipant Get(long id)
	{
		return EntityHelper.GetEntity<long, ConversationParticipantDAL, ConversationParticipant>(EntityCacheInfo, id, () => ConversationParticipantDAL.Get(id));
	}

	private static ICollection<ConversationParticipant> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, ConversationParticipantDAL, ConversationParticipant>(ids, EntityCacheInfo, ConversationParticipantDAL.MultiGet);
	}

	public static ConversationParticipant GetByConversationIDParticipantTypeIDAndParticipantTargetID(long conversationID, int participantTypeID, long participantTargetID)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, ConversationParticipantDAL, ConversationParticipant>(EntityCacheInfo, GetLookupCacheKeysByConversationIDParticipantTypeIDParticipantTargetID(conversationID, participantTypeID, participantTargetID), () => ConversationParticipantDAL.GetConversationParticipantByConversationIDParticipantTypeIDAndParticipantTargetID(conversationID, participantTypeID, participantTargetID), Get);
	}

	internal static ICollection<ConversationParticipant> GetConversationParticipantsByConversationIDPaged(long conversationID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetConversationParticipantsByConversationIDPaged_ConversationID:{conversationID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByConversationID(conversationID)), collectionId, () => ConversationParticipantDAL.GetConversationParticipantIDsByConversationIDPaged(conversationID, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<ConversationParticipant> GetConversationParticipantsByParticipantTypeIDAndParticipantTargetIDPaged(int participantTypeID, long participantTargetID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetConversationParticipantsByParticipantTypeIDAndParticipantTargetIDPaged_ParticipantTypeID:{participantTypeID}_ParticipantTargetID:{participantTargetID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByParticipantTypeIDParticipantTargetID(participantTypeID, participantTargetID)), collectionId, () => ConversationParticipantDAL.GetConversationParticipantIDsByParticipantTypeIDAndParticipantTargetIDPaged(participantTypeID, participantTargetID, startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(ConversationParticipantDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByConversationIDParticipantTypeIDParticipantTargetID(ConversationID, ParticipantTypeID, ParticipantTargetID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByConversationID(ConversationID));
		yield return new StateToken(GetLookupCacheKeysByParticipantTypeIDParticipantTargetID(ParticipantTypeID, ParticipantTargetID));
	}

	private static string GetLookupCacheKeysByConversationIDParticipantTypeIDParticipantTargetID(long conversationID, int participantTypeID, long participantTargetID)
	{
		return $"ConversationID:{conversationID}_ParticipantTypeID:{participantTypeID}_ParticipantTargetID:{participantTargetID}";
	}

	private static string GetLookupCacheKeysByConversationID(long conversationID)
	{
		return $"ConversationID:{conversationID}";
	}

	private static string GetLookupCacheKeysByParticipantTypeIDParticipantTargetID(int participantTypeID, long participantTargetID)
	{
		return $"ParticipantTypeID:{participantTypeID}_ParticipantTargetID:{participantTargetID}";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
